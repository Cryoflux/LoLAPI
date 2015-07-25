using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Champion
{
    public struct ChampionSpellDto
    {
        //This object contains champion spell data.
        public List<ImageDto> altimages { get; set; }
        public List<double> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public string costType { get; set; }
        public string description { get; set; }
        public List<List<double>> effect { get; set; } //This field is a List of List of Double. **Documented as List[object]
        public List<string> effectBurn { get; set; }
        public ImageDto image { get; set; }
        public string key { get; set; }
        //public LevelTipDto leveltip { get; set; }
        public int maxrank { get; set; }
        public string name { get; set; }
        public object range { get; set; } //This field is either a List of Integer or the String 'self' for spells that target one's own champion.
        public string rangeBurn { get; set; }
        public string resource { get; set; }
        public string sanitizedDescription { get; set; }
        public string sanitizedTooltip { get; set; }
        public string tooltip { get; set; }
        //public List<SpellVarsDto> vars { get; set; }
    }
}
