using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ZergRush.Alive;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION

public static partial class SerializationExtensions
{
    public static void ReadFromJson(this ZergRush.ReactiveCore.ReactiveCollection<Game.LocalMetaCommand> self, JsonTextReader reader) 
    {
        if (reader.TokenType != JsonToken.StartArray) throw new JsonSerializationException("Bad Json Format");
        while (reader.Read())
        {
            if (reader.TokenType == JsonToken.EndArray) { break; }
            Game.LocalMetaCommand val = default;
            val = new Game.LocalMetaCommand();
            val.ReadFromJson(reader);
            self.Add(val);
        }
    }
    public static void WriteJson(this ZergRush.ReactiveCore.ReactiveCollection<Game.LocalMetaCommand> self, JsonTextWriter writer) 
    {
        writer.WriteStartArray();
        for (int i = 0; i < self.Count; i++)
        {
            self[i].WriteJson(writer);
        }
        writer.WriteEndArray();
    }
    public static void Serialize(this ZergRush.ReactiveCore.ReactiveCollection<Game.LocalMetaCommand> self, BinaryWriter writer) 
    {
        writer.Write(self.Count);
        for (int i = 0; i < self.Count; i++)
        {
            self[i].Serialize(writer);
        }
    }
    public static void Deserialize(this ZergRush.ReactiveCore.ReactiveCollection<Game.LocalMetaCommand> self, BinaryReader reader) 
    {
        var size = reader.ReadInt32();
        if(size > 1000) throw new ZergRushCorruptedOrInvalidDataLayout();
        self.Capacity = size;
        for (int i = 0; i < size; i++)
        {
            Game.LocalMetaCommand val = default;
            val = new Game.LocalMetaCommand();
            val.Deserialize(reader);
            self.Add(val);
        }
    }
}
#endif
