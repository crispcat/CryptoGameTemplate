using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace GameTools {

    public partial class LocalSettings : IJsonSerializable
    {
        public  LocalSettings() 
        {
            authData = new Game.AuthData();
            currentLocale = new ZergRush.ReactiveCore.Cell<string>();
        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
                case "authData":
                authData.ReadFromJson(reader);
                break;
                case "lastRemoteGameModelHash":
                lastRemoteGameModelHash = ulong.Parse((string)reader.Value);
                break;
                case "logRemoteGameMetaCommands":
                logRemoteGameMetaCommands = (System.Boolean)reader.Value;
                break;
                case "tolerateLocalizationErrors":
                tolerateLocalizationErrors = (System.Boolean)reader.Value;
                break;
                case "currentLocale":
                if (reader.TokenType == JsonToken.Null) {
                    currentLocale.value = null;
                }
                else { 
                    currentLocale.value = (string) reader.Value;
                }
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            writer.WritePropertyName("authData");
            authData.WriteJson(writer);
            writer.WritePropertyName("lastRemoteGameModelHash");
            writer.WriteValue(lastRemoteGameModelHash.ToString());
            writer.WritePropertyName("logRemoteGameMetaCommands");
            writer.WriteValue(logRemoteGameMetaCommands);
            writer.WritePropertyName("tolerateLocalizationErrors");
            writer.WriteValue(tolerateLocalizationErrors);
            if (currentLocale.value == null)
            {
                writer.WritePropertyName("currentLocale");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("currentLocale");
                writer.WriteValue(currentLocale.value);
            }
        }
    }
}
#endif
