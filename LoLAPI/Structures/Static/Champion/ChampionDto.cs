using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Champion
{
    public struct ChampionDto
    {
        //This object contains champion data.
        public List<string> allytips { get; set; }
        public string blurb { get; set; }
        public List<string> enemytips { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public InfoDto info { get; set; }
        public string key { get; set; }
        public string lore { get; set; }
        public string name { get; set; }
        public string partype { get; set; }
        public PassiveDto passive { get; set; }
        public List<RecommendedDto> recommended { get; set; }
        public List<SkinDto> skins { get; set; }
        public List<ChampionSpellDto> spells { get; set; }
        public StatsDto stats { get; set; }
        public List<string> tags { get; set; }
        public string title { get; set; }
    }
}
