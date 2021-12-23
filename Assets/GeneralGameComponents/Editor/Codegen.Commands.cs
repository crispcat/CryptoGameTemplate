using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CGT;
using ZergRush;
using ZergRush.Alive;
using ZergRush.CodeGen;
using static ZergRush.CodeGen.CodeGen;

[GenInLocalFolder]
public static partial class CommandGen
{
    static string CommandDescriptorCommandTypeFieldName = "command";
    static string CommandDescriptorObjIdFieldName = "objId";
    static string CommandExecuteFuncName = "ExecuteCommand";

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

    static void PackArgs(MethodBuilder sink, string bufferGetterName, MethodInfo method)
    {
        PackArgs(sink, bufferGetterName, method.GetParameters().Select(p => new DataInfo
        {
            type = p.ParameterType,
            baseAccess = p.Name,
            canBeNull = p.ParameterType.IsClass
        }));
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

    static MethodBuilder StartGenArgPrinter(string className, string enumType, string modelForRefs, GeneratorContext context)
    {
        var senderSink = context.createSharpClass(className, className,
            "CGT", isStatic: true, isStruct: false, isSealed: false, isPartial: true);

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

    static Type AntiTask(this Type t)
    {
        if (t == typeof(Task)) return CodeGen.Void;
        if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Task<>)) return t.FirstGenericArg();
        return t;
    }

    public static GeneratorContext GetLocalOrDefaultContext(Type type)
    {
        var genLocal = (GenInLocalFolder) Attribute.GetCustomAttribute(type, typeof(GenInLocalFolder));
        return genLocal == null
            ? defaultContext
            : new GeneratorContext(new GenInfo { sharpGenPath = genLocal.folder }, false);
    }

    public static string GetLocalOrDefaultPath(Type type)
    {
        var genLocal = (GenInLocalFolder) Attribute.GetCustomAttribute(type, typeof(GenInLocalFolder));
        return genLocal == null
            ? "Assets/zGenerated/"
            : genLocal.folder;
    }

    [CodeGenExtension]
    static void GenerateLocalCommands()
    {
        HashSet<string> allCommands = new HashSet<string>();
        string commandTypeName = nameof(LocalMetaCommandType); //"CommandType";
        var localResultType = typeof(LocalMetaCommandResult);

        var assembly = AppDomain.CurrentDomain.GetAssemblies()
            .First(a => a.FullName.StartsWith("CryptoGameTemplate"));

        string genPath = null;
        GeneratorContext genContext = null;
        MethodBuilder printerSink = null;

        foreach (var type in assembly.GetTypes())
        {
            if (type.HasInHierarchy(p => p.HasAttribute<GenCommands>()) == false) continue;

            genPath = GetLocalOrDefaultPath(type);
            genContext = GetLocalOrDefaultContext(type);
            printerSink = StartGenArgPrinter(PrintArgsLocalStaticClassName, commandTypeName, "GameModel", genContext);
            
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

        if (printerSink != null) 
            FinishArgPrinting(printerSink);

        EnumTable.MakeAndSaveEnum(commandTypeName, allCommands.ToList(), genPath, genContext);
    }
}