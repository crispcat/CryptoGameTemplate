using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Game;
using ZergRush;
using ZergRush.Alive;
using ZergRush.CodeGen;
using static ZergRush.CodeGen.CodeGen;

public static partial class CommandGen
{
    static string CommandDescriptorCommandTypeFieldName = "command";
    static string CommandDescriptorObjIdFieldName = "objId";
    static string CommandExecuteFuncName = "ExecuteCommand";

    static bool BinaryProtocol = true;
    static GenTaskFlags dataProtocolTags = GenTaskFlags.Serialization | GenTaskFlags.JsonSerialization;

    static T GetAttributeIfAny<T>(this MemberInfo info) where T : Attribute
    {
        if (info.HasAttribute<T>())
            return info.GetCustomAttribute<T>();
        return null;
    }

    static string ReadStringTillWhiteSpace(ref int pos, string str)
    {
        var initPos = pos;
        while (str[pos].IsWhiteSpace() == false) pos++;
        return str.Substring(initPos, pos - initPos);
    }

    static bool IsWhiteSpace(this char c)
    {
        return c == ' ' || c == '\r' || c == '\n' || c == '\t';
    }

    static void ConsumeSpaces(ref int pos, string str)
    {
        while (str[pos].IsWhiteSpace()) pos++;
    }

    static string NewProtocolReader(string data) => BinaryProtocol
        ? $"new BinaryReader(new MemoryStream({data}))"
        : $"new JsonTextReader(new StringReader({data}))";

    static string ProtocolReaderType => BinaryProtocol ? $"BinaryReader" : "JsonTextReader";

    static string dataStream = "_data";
    static string bufferName = "_bytes";
    static string resultObjName = "_result";

    static void InitDataProtocolRead(MethodBuilder sink, string bufferName)
    {
        sink.classBuilder.usingSink("System.IO");
        var www = new StreamWriter(new MemoryStream());
        if (BinaryProtocol)
        {
            sink.content($"var reader = new BinaryReader(new MemoryStream({bufferName}));");
        }
        else
        {
            sink.classBuilder.usingSink("Newtonsoft.Json");
            sink.content($"var reader = new JsonTextReader(new StreamReader(new MemoryStream({bufferName})));");
            sink.content($"reader.Read();");
        }
    }

    static void InitDataProtocolWrite(MethodBuilder sink)
    {
        sink.classBuilder.usingSink("System.IO");
        var www = new StreamWriter(new MemoryStream());
        if (BinaryProtocol)
        {
            sink.content($"var {dataStream} = new MemoryStream();");
            sink.content($"var writer = new BinaryWriter({dataStream});");
        }
        else
        {
            sink.classBuilder.usingSink("Newtonsoft.Json");
            sink.content($"var {dataStream} = new MemoryStream();");
            sink.content($"var writer = new JsonTextWriter(new StreamWriter({dataStream}));");
            sink.content($"writer.WriteStartObject();");
        }
    }

    static void FinishDataProtocolWrite(MethodBuilder sink, string bufferGetterName)
    {
        if (BinaryProtocol)
        {
        }
        else
        {
            sink.content($"writer.WriteEndObject();");
        }

        sink.content($"var {bufferGetterName} = {dataStream}.GetBuffer();");
    }

    static void PackArgs(MethodBuilder sink, string bufferGetterName, MethodInfo method)
    {
        PackArgs(sink, bufferGetterName, method.GetParameters().Select(p => new DataInfo
        {
            type = p.ParameterType,
            baseAccess = p.Name,
            canBeNull = p.ParameterType.IsClass
        }));
    }

    static void ReadItem(MethodBuilder eSink, DataInfo arg)
    {
        if (BinaryProtocol)
        {
            ZergRush.CodeGen.CodeGen.GenReadValueFromStream(eSink, arg,
                stream: "reader", pooled: false, needVar: true, readDataNodeFromId: true);
        }
        else
        {
            eSink.content($"reader.ReadAssertPropertyName(\"{arg.baseAccess}\");");
            eSink.content($"reader.Read();");
            ReadJsonValueStatement(eSink, arg, true, true);
        }
    }

    static void WriteItem(MethodBuilder sink, DataInfo arg)
    {
        if (BinaryProtocol)
        {
            GenWriteValueToStream(sink, arg, "writer", true);
        }
        else
        {
            WriteJsonValueStatement(sink, arg, false, true);
        }
    }


    static void PackArgs(MethodBuilder sink, string bufferGetterName, IEnumerable<DataInfo> args)
    {
        InitDataProtocolWrite(sink);

        foreach (var arg in args)
        {
            if (arg.type.IsConfig() == false) RequestGen(arg.type, null, dataProtocolTags);
            WriteItem(sink, arg);
        }

        FinishDataProtocolWrite(sink, bufferGetterName);
    }

    static void GenCommandSender(Func<string, MethodBuilder> methodFactory, MethodInfo method,
        string commandBuilder, Action<MethodBuilder> exec, Action<MethodBuilder> execFailed,
        bool localOrRemoteCommands)
    {
        List<DataInfo> args = new List<DataInfo>();
        Type returnType = method.ReturnType;
        foreach (var parameter in method.GetParameters())
        {
            args.Add(new DataInfo { type = parameter.ParameterType, baseAccess = parameter.Name });
        }

        var sink = methodFactory(args.Select(a => $"{a.type} {a.name}").PrintCollection());
        sink.isDebug = method.HasAttribute<IsDebug>();
        sink.indent++;

        sink.content($"var command = {commandBuilder};");

        const string buffer = "commandArgData";
        PackArgs(sink, buffer, method);
        sink.content($"command.args = {buffer};");

        bool hasReturn = returnType != CodeGen.Void;
        sink.content("try");
        sink.openBrace();
        exec(sink);
        sink.closeBrace();
        sink.content($"catch (Exception e)");
        sink.openBrace();
        string whatCommand = localOrRemoteCommands ? "Local" : "Remote";
        sink.content(
            $"SystemLayer.LogError($\"{whatCommand} command {method.Name} execution failed, request args: {method.GetParameters().Select(p => $"{{{p.Name}}}").PrintCollection()}, " +
            $"\\n SERVER ERROR = {{e.Message}}, \\nstacktrace={{e.StackTrace}}\");");
        //sink.content($"SystemLayer.LogError(e);");
        execFailed(sink);
    }

    static void GenCommandReceiver(Type type, List<MethodInfo> thisTypeCommands, Type returnType, string defReturn,
        string commandType, bool async, Action<MethodInfo, string, MethodBuilder> exec)
    {
        var localMetaCommandResultType = typeof(LocalMetaCommandResultType);
        var commArg = "_type";
        var eSink = MakeGenMethod(type, GenTaskFlags.CommandsGen, "ExecuteCommand", returnType,
            $"{commandType} {commArg}, {ProtocolReaderType} reader");
        if (!BinaryProtocol) eSink.classBuilder.usingSink("Newtonsoft.Json");
        eSink.indent++;
        if (eSink.type == MethodType.Override)
            eSink.content($"if (baseVal.type != {localMetaCommandResultType.Name}.NotFound) return baseVal;");
        eSink.content($"switch({commArg})");
        eSink.openBrace();
        eSink.async = async;
        eSink.classBuilder.usingSink("System.IO");


        foreach (var method in thisTypeCommands)
        {
            if (method.HasAttribute<IsDebug>())
                eSink.content($"#if !RELEASE");
            eSink.content($"case {commandType}.{method.Name}:");
            eSink.openBrace();
            foreach (var arg in method.GetParameters())
            {
                ReadItem(eSink,
                    new DataInfo
                        { type = arg.ParameterType, baseAccess = arg.Name, sureIsNull = true, canBeNull = true });
            }

            exec(method, method.GetParameters().Select(p => p.Name).PrintCollection(), eSink);
            eSink.content($"break;");
            eSink.closeBrace();
            if (method.HasAttribute<IsDebug>())
                eSink.content($"#endif");
        }

        eSink.closeBrace();
        eSink.content($"return {defReturn};");
    }

    static bool IsVoidOrTask(this Type type)
    {
        return type == ZergRush.CodeGen.CodeGen.Void || type == typeof(Task);
    }

    static string PrintCommandArgsFuncName = "PrintArgs";
    static string PrintCommandResultFuncName = "PrintResult";
    static string PrintArgsRemoteStaticClassName = "DebugRemoteCommandPrinter";
    static string PrintArgsRemoteResultStaticClassName = "DebugRemoteCommandResultPrinter";
    static string PrintArgsLocalStaticClassName = "DebugLocalCommandPrinter";

    static MethodBuilder StartGenArgPrinter(string className, string enumType, string modelForRefs)
    {
        var senderSink = defaultContext.createSharpClass(className, className,
            "Game", isStatic: true, isStruct: false, isSealed: false, isPartial: true);

        var method = senderSink.Method(PrintCommandArgsFuncName, null, MethodType.StaticFunction,
            typeof(string),
            $"{enumType} __type, byte[] __data" + (modelForRefs != null ? $", {modelForRefs} root" : ""));

        method.indent++;
        method.content($"if (__data == null) return \"\";");
        InitDataProtocolRead(method, "__data");
        method.content($"switch (__type)");
        method.openBrace();

        return method;
    }

    static void FinishArgPrinting(MethodBuilder argPrinter)
    {
        argPrinter.closeBrace();
        argPrinter.content("return \"invalid command type\";");
    }

    static string WrapPrint(Type t, string access)
    {
        return t.IsValueType
            ? $"{access}.ToString()"
            : $"({access} == null ? \"null\" : {access}.{ToPrintStringMethod(t)}())";
    }

    static string ToPrintStringMethod(Type t) =>
        typeof(IJsonSerializable).IsAssignableFrom(t) ? "SaveToJsonString" : "ToString";

    static void SinkCommandArgPrinterCase(string enumName, MethodBuilder builder, MethodInfo method)
    {
        builder.content($"case {enumName}.{method.Name}:");
        builder.openBrace();
        var str = new StringBuilder();
        str.Append("$\"");
        foreach (var arg in method.GetParameters())
        {
            var info = new DataInfo
                { type = arg.ParameterType, baseAccess = arg.Name, sureIsNull = true, canBeNull = true };

            if (info.type.IsDataNode())
            {
                builder.content($"string {info.baseAccess}Str = null;");

                // Commented due to situation when object referenced here is no longer exists in the model
//                    builder.content("if (root == null) ");
//                    builder.openBrace();
                builder.content(
                    $"{info.baseAccess}Str = !reader.ReadBoolean() ? \"null\" : (\"objId:\" + reader.ReadInt32());");
//                    builder.closeBrace();
//                    builder.content("else");
//                    builder.openBrace();
//                    ReadItem(builder, info);
//                    builder.content($"{info.baseAccess}Str = {WrapPrint(info.type, info.baseAccess)};");
//                    builder.closeBrace();
                str.Append($"{info.baseAccess}: {{{info.baseAccess}Str}}; ");
            }
            else
            {
                ReadItem(builder, info);
                str.Append($"{info.baseAccess}: {{{WrapPrint(info.type, info.baseAccess)}}}; ");
            }
        }

        str.Append("\"");
        builder.content($"return {str};");
        builder.closeBrace();
    }

    [CodeGenExtension]
    static void GenerateServerApi()
    {
        HashSet<string> allCommands = new HashSet<string>();
        var type = typeof(ServerPlayerSessionController);

        string commandTypeName = typeof(RemoteMetaRequestType).Name; //"ServerRequestType";
        var responseType = typeof(RemoteMetaResponse);
        var thisTypeCommands = new List<MethodInfo>();
        var senderSink = defaultContext.createSharpClass("GameServerAPI", "GameServerAPI", "Game",
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

        var receiverSink = GenClassSink(type);
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
        EnumTable.MakeAndSaveEnum(commandTypeName, allCommands.ToList(), "Assets/zGenerated/", defaultContext);
    }

    static void GenerateCommandResultPrinter(List<MethodInfo> commandFunctions)
    {
        var className = PrintArgsRemoteResultStaticClassName;
        var enumType = typeof(RemoteMetaRequestType).Name;
        var senderSink = defaultContext.createSharpClass(className, className,
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
                GenReadValueFromStream(method, new DataInfo
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

    static Type AntiTask(this Type t)
    {
        if (t == typeof(Task)) return CodeGen.Void;
        if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Task<>)) return t.FirstGenericArg();
        return t;
    }

    [CodeGenExtension]
    static void GenerateLocalCommands()
    {
        HashSet<string> allCommands = new HashSet<string>();
        string commandTypeName = nameof(LocalMetaCommandType); //"CommandType";
        var localResultType = typeof(LocalMetaCommandResult);

        var printerSink = StartGenArgPrinter(PrintArgsLocalStaticClassName, commandTypeName, "GameModel");

        var assembly = typeof(IGameCommandSink).Assembly;
            
        foreach (var type in assembly.GetTypes())
        {
            if (type.HasInHierarchy(p => p.HasAttribute<GenCommands>()) == false) continue;
            var thisTypeCommands = new List<MethodInfo>();
            var classSink = GenClassSink(type);
            foreach (var method in type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public |
                                                   BindingFlags.Instance))
            {
                if (method.HasAttribute<LocalCommand>() == false) continue;

                if (type.IsDataRoot() == false && type.HasReferenceId() == false)
                {
                    Error($"type {type} without refId can not have commands, probably need to change its the parent to ReferensableGameNode");
                    continue;
                }

                SinkCommandArgPrinterCase(commandTypeName, printerSink, method);
                allCommands.Add(method.Name);
                thisTypeCommands.Add(method);

                var objId = (typeof(DataRoot).IsAssignableFrom(type) ? "0" : "id");
                GenCommandSender(args => classSink.Method(method.Name + "Command", type,
                        MethodType.Instance, method.ReturnType, args), method,
                    commandBuilder: $"root.PrepareCommand({commandTypeName}.{method.Name}, {objId});",
                    exec: sink =>
                    {
                        bool hasReturn = method.ReturnType != ZergRush.CodeGen.CodeGen.Void;
                        sink.content($"root.BeforeExecutionLocalCommand(command);");
                        sink.content(
                            $"{(hasReturn ? "var commandResult = " : "")}{method.Name}({method.GetParameters().Select(p => p.Name).PrintCollection()});");
                        sink.content($"root.SinkLocalCommand(command);");
                        if (hasReturn) sink.content($"return commandResult;");
                    }, execFailed: sink =>
                    {
                        sink.content($"root.ExecutionFailed(command);");
                        sink.closeBrace();
                        if (method.ReturnType != ZergRush.CodeGen.CodeGen.Void)
                            sink.content($"return default({method.ReturnType.RealName(true)});");
                    },
                    localOrRemoteCommands: true
                );
            }


            GenCommandReceiver(type, thisTypeCommands, localResultType, $"{localResultType}.NotFound",
                commandTypeName, false,
                exec:
                (method, args, eSink) =>
                {
                    string call = $"{method.Name}({args});";
                    var hasResult = method.ReturnType != ZergRush.CodeGen.CodeGen.Void;
                    var rName = method.Name + "Result";
                    eSink.content((hasResult ? $"var {rName} = " : "") + call);
                    eSink.content($"return {localResultType.Name}.Complete({(hasResult ? rName : "")});");
                });
        }

        FinishArgPrinting(printerSink);

        EnumTable.MakeAndSaveEnum(commandTypeName, allCommands.ToList(), "Assets/zGenerated/", defaultContext);
    }
}