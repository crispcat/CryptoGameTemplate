using System.Collections.Generic;
using System.IO;
using ZergRush.CodeGen;

public static partial class CommandGen
{
    static bool BinaryProtocol = true;
    static GenTaskFlags dataProtocolTags = GenTaskFlags.Serialization | GenTaskFlags.JsonSerialization;

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
            CodeGen.ReadJsonValueStatement(eSink, arg, true, true);
        }
    }

    static void WriteItem(MethodBuilder sink, DataInfo arg)
    {
        if (BinaryProtocol)
        {
            CodeGen.GenWriteValueToStream(sink, arg, "writer", true);
        }
        else
        {
            CodeGen.WriteJsonValueStatement(sink, arg, false, true);
        }
    }

    static void PackArgs(MethodBuilder sink, string bufferGetterName, IEnumerable<DataInfo> args)
    {
        InitDataProtocolWrite(sink);

        foreach (var arg in args)
        {
            if (arg.type.IsConfig() == false) CodeGen.RequestGen(arg.type, null, dataProtocolTags);
            WriteItem(sink, arg);
        }

        FinishDataProtocolWrite(sink, bufferGetterName);
    }
}