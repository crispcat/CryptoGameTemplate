using System.Linq;
using GameTools;
using UnityEngine;

namespace Game
{
    public partial class ConfigsBuilder
    {
        enum GooglePages
        {
            SamplePage
        }
        static GoogleSheetConfig googleConfig => new GoogleSheetConfig
        {
            new GoogleSheet
            {
                name = "Sample", id = "1COLbgYd6X-Fmy7JeD-bHy2u6VS0jBKnOVMudKOctN18", pages =
                {
                    {GooglePages.SamplePage, "0"},
                }
            },
        };

        static void ParseConfig(GameConfig config)
        {
            var p = Page(GooglePages.SamplePage);

            // Fill the config with data in this function
            foreach (var row in p.Skip(1))
            {
                if (row["values"].IsNullOrWhitespace()) continue;
                Debug.Log($"test value from excel table {row["values"].ParseIntStrict()}");
            }
        }
    }
}