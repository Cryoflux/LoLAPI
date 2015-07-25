using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Spell
{
    public struct SummonerSpellListDto
    {
        //This object contains summoner spell list data.
        public Dictionary<string, SummonerSpellDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
}
