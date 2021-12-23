using System.IO;

namespace CGT
{
    public static class ProtocolTools
    {
#if JSON_PROTOCOL
        public static JsonTextReader GetReader(byte [] data)
        {
            var r = new JsonTextReader(new StreamReader(new MemoryStream(data)));
            r.Read();
            return r;
        }
#else
        public static BinaryReader GetReader(byte [] data) => new BinaryReader(new MemoryStream(data));
#endif

#if CLIENT
        public static void StoreToFile<T>(this T data, string fileName) where T : ISerializable, IJsonSerializable
        {
            #if JSON_STORAGE_FORMAT
            data.SaveJsonToFile(fileName);
            #else
            data.SaveToFile(fileName, true);
            #endif
        }

        public static bool LoadFromFile<T>(string filename, out T val) where T : class, ISerializable, IJsonSerializable, new()
        {
            #if JSON_STORAGE_FORMAT
            return Utils.LoadFromJsonFileIfExists(filename, out val);
            #else
            return Utils.LoadBinary<T>(filename, out val);
            #endif
        }
#endif
    }
}