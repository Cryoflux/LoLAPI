using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Rune
{
    public struct RuneDto
    {
        //This object contains rune data.
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public List<string> from { get; set; }
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public bool inStore { get; set; }
        public List<string> into { get; set; }
        public Dictionary<string, bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public MetaDataDto rune { get; set; }
        public string sanitizedDescription { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStatsDto stats { get; set; }
        public List<string> tags { get; set; }
    }
}
