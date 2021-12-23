using System;
using Newtonsoft.Json;
using ZergRush;
using ZergRush.CodeGen;
using ZergRush.ReactiveCore;

namespace CGT
{
    [GenTask(GenTaskFlags.DefaultConstructor | GenTaskFlags.JsonSerialization)]
    public partial class LocalSettings : IJsonSerializable
    {
        public bool tolerateLocalizationErrors = true;
        [CanBeNull] public Cell<string> currentLocale;

        public static LocalSettings Default()
        {
            var def = new LocalSettings
            {
            };
            return def;
        }

        static Cell<LocalSettings> _instanceCell = new Cell<LocalSettings>();

        public static ICell<LocalSettings> instanceCell
        {
            get
            {
                var i = Instance;
                return _instanceCell;
            }
        }

        // Infrastructure
        public static void Reset()
        {
            _instanceCell.value = Default();
        }

        public static void EnsureInstanceExists()
        {
            if (_instanceCell.value == null)
            {
                _instanceCell.value = SerializationTools.LoadFromJsonFile(path, () => { return Default(); });
            }
        }

        public static LocalSettings Instance
        {
            get
            {
                EnsureInstanceExists();
                return _instanceCell.value;
            }
        }

        public static void SaveLocally()
        {
            if (_instanceCell.value != null)
                _instanceCell.value.SaveToJsonFile(path);
        }

        static string path => "local_game_settings";
    }
}
