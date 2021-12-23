using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CGT;
using ZergRush.CodeGen;

public static partial class CommandGen
{
    [CodeGenExtension]
    static void GenerateServerApi()
    {
        HashSet<string> allCommands = new HashSet<string>();
        var type = typeof(MetaServerPlayerSessionController);

        string commandTypeName = typeof(RemoteMetaRequestType).Name; //"ServerRequestType";
        var responseType = typeof(RemoteMetaResponse);
        var thisTypeCommands = new List<MethodInfo>();
        var senderSink = CodeGen.defaultContext.createSharpClass("GameServerAPI", "GameServerAPI", "Game",
            isStatic: false, isStruct: false, isSealed: false, isPartial: true);
        senderSink.usingSink("System.Threading.Tasks");

        var printerSink = StartGenArgPrinter(PrintArgsRemoteStaticClassName, commandTypeName, null);

        foreach (var method in type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public |
                                               BindingFlags.Instance))
        {
            if (method.HasAttribute<GenServerCommand>() == false) continue;
            allCommands.Add(method.Name);
            thisTypeCommands.Add(method);

            SinkCommandArgPrinterCase(commandTypeName, printerSink, method);
            GenCommandSender(
                methodFactory: args =>
                {
                    var m = senderSink.Method(method.Name, typeof(ClientMetaNetworkLayer),
                        MethodType.Instance, method.ReturnType, args);
                    m.async = true;
                    return m;
                },
                method: method,
                commandBuilder: $"network.PrepareRequest({commandTypeName}.{method.Name});",
                exec: sink =>
                {
                    sink.async = true;
                    //sink.content($"if (network.log) ServerEngine.Debug.Log($\"sending {method.Name} meta game remote command request\");");
                    sink.content($"var _result = await network.CallServerApi(command);");
                    //sink.content($"_result = await TryResendIfNotAuthed(command, _result);");
                    sink.content($"if (!_result.success) throw new GameException(_result.error);");
                    //sink.content($"if (network.log) ServerEngine.Debug.Log($\"receiving {method.Name} meta game remote command response\");");
                    if (method.ReturnType.IsVoidOrTask() == false)
                    {
                        InitDataProtocolRead(sink, "_result.responseData");
                        var parsed = "parsedResult";
                        ReadItem(sink,
                            new DataInfo
                            {
                                type = method.ReturnType.FirstGenericArg(), baseAccess = parsed, sureIsNull = true
                            });
                        sink.content($"return {parsed};");
                    }
                },
                execFailed: sink =>
                {
                    //sink.content($"root.ExecutionFailed(command);");
                    sink.closeBrace();
                    if (method.ReturnType.IsVoidOrTask() == false)
                        sink.content($"return default({method.ReturnType.FirstGenericArg().RealName(true)});");
                },
                localOrRemoteCommands: false);
        }

        FinishArgPrinting(printerSink);
        GenerateCommandResultPrinter(thisTypeCommands);

        var receiverSink = CodeGen.GenClassSink(type);
        receiverSink.defineSink("SERVER");
        receiverSink.usingSink("System.Threading.Tasks");
        receiverSink.usingSink(responseType.Namespace);
        GenCommandReceiver(type, thisTypeCommands, typeof(Task<RemoteMetaResponse>),
            $"{responseType.Name}.NotFound",
            commandTypeName, true,
            exec:
            (method, args, eSink) =>
            {
                if (method.ReturnType.IsVoidOrTask())
                {
                    eSink.content($"await {method.Name}({args});");
                    eSink.content($"return {responseType.Name}.Complete();");
                }
                else
                {
                    eSink.content($"var {resultObjName} = await {method.Name}({args});");
                    InitDataProtocolWrite(eSink);
                    WriteItem(eSink,
                        new DataInfo { type = method.ReturnType.FirstGenericArg(), baseAccess = resultObjName });
                    FinishDataProtocolWrite(eSink, bufferName);
                    eSink.content($"return {responseType.Name}.Complete({bufferName});");
                }
            });
        EnumTable.MakeAndSaveEnum(commandTypeName, allCommands.ToList(), "Assets/zGenerated/", CodeGen.defaultContext);
    }

    static void GenerateCommandResultPrinter(List<MethodInfo> commandFunctions)
    {
        var className = PrintArgsRemoteResultStaticClassName;
        var enumType = typeof(RemoteMetaRequestType).Name;
        var senderSink = CodeGen.defaultContext.createSharpClass(className, className,
            "Game", isStatic: true, isStruct: false, isSealed: false, isPartial: true);

        var method = senderSink.Method(PrintCommandResultFuncName, null, MethodType.StaticFunction,
            typeof(string), $"{enumType} __type, byte[] __data");

        method.indent++;
        method.content($"if (__data == null) return \"\";");
        InitDataProtocolRead(method, "__data");
        method.content($"switch (__type)");
        method.openBrace();

        foreach (var command in commandFunctions)
        {
            method.content($"case {enumType}.{command.Name}:");
            var type = command.ReturnType.AntiTask();
            if (type == CodeGen.Void) method.content("return \"void\";");
            else
            {
                method.openBrace();
                CodeGen.GenReadValueFromStream(method, new DataInfo
                {
                    type = type, baseAccess = "result", sureIsNull =
                        true
                }, "reader", false, true);
                method.content($"return result.{ToPrintStringMethod(type)}();");
                method.closeBrace();
            }
        }

        method.closeBrace();
        method.content($"throw new GameException(\"command id not found\");");
    }
}