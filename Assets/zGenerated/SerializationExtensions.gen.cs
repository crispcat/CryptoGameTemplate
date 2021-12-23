using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ZergRush.Alive;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION

public static partial class SerializationExtensions
{
    public static void Deserialize(this CGT.SessionInfo self, BinaryReader reader) 
    {
        self.playerId = reader.ReadString();
        self.sessionId = reader.ReadString();
    }
    public static void Serialize(this CGT.SessionInfo self, BinaryWriter writer) 
    {
        writer.Write(self.playerId);
        writer.Write(self.sessionId);
    }
    public static void ReadFromJson(this CGT.SessionInfo self, JsonTextReader reader) 
    {
        while (reader.Read())
        {
            if (reader.TokenType == JsonToken.PropertyName)
            {
                var __name = (string) reader.Value;
                reader.Read();
                switch(__name)
                {
                    case "playerId":
                    self.playerId = (string) reader.Value;
                    break;
                    case "sessionId":
                    self.sessionId = (string) reader.Value;
                    break;
                }
            }
            else if (reader.TokenType == JsonToken.EndObject) { break; }
        }
    }
    public static void WriteJson(this CGT.SessionInfo self, JsonTextWriter writer) 
    {
        writer.WriteStartObject();
        writer.WritePropertyName("playerId");
        writer.WriteValue(self.playerId);
        writer.WritePropertyName("sessionId");
        writer.WriteValue(self.sessionId);
        writer.WriteEndObject();
    }
    public static void ReadFromJson(this ZergRush.ReactiveCore.ReactiveCollection<CGT.LocalMetaCommand> self, JsonTextReader reader) 
    {
        if (reader.TokenType != JsonToken.StartArray) throw new JsonSerializationException("Bad Json Format");
        while (reader.Read())
        {
            if (reader.TokenType == JsonToken.EndArray) { break; }
            CGT.LocalMetaCommand val = default;
            val = new CGT.LocalMetaCommand();
            val.ReadFromJson(reader);
            self.Add(val);
        }
    }
    public static void WriteJson(this ZergRush.ReactiveCore.ReactiveCollection<CGT.LocalMetaCommand> self, JsonTextWriter writer) 
    {
        writer.WriteStartArray();
        for (int i = 0; i < self.Count; i++)
        {
            self[i].WriteJson(writer);
        }
        writer.WriteEndArray();
    }
    public static void Serialize(this ZergRush.ReactiveCore.ReactiveCollection<CGT.LocalMetaCommand> self, BinaryWriter writer) 
    {
        writer.Write(self.Count);
        for (int i = 0; i < self.Count; i++)
        {
            self[i].Serialize(writer);
        }
    }
    public static void Deserialize(this ZergRush.ReactiveCore.ReactiveCollection<CGT.LocalMetaCommand> self, BinaryReader reader) 
    {
        var size = reader.ReadInt32();
        if(size > 1000) throw new ZergRushCorruptedOrInvalidDataLayout();
        self.Capacity = size;
        for (int i = 0; i < size; i++)
        {
            CGT.LocalMetaCommand val = default;
            val = new CGT.LocalMetaCommand();
            val.Deserialize(reader);
            self.Add(val);
        }
    }
}
#endif
