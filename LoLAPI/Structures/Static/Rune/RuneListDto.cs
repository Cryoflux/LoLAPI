using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Rune
{
    public struct RuneListDto
    {
        //This object contains rune list data.
        public BasicDataDto basic { get; set; }
        public Dictionary<string, RuneDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
}
