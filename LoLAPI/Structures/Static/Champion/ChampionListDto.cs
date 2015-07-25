using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Champion
{
    public struct ChampionListDto
    {
        //This object contains champion list data.
        public Dictionary<string, ChampionDto> data;
        public string format;
        public Dictionary<string, string> keys;
        public string type;
        public string version;
    }
}
