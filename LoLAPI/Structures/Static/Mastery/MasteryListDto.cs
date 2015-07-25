using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Mastery
{
    public struct MasteryListDto
    {
        //This object contains mastery list data.
        public Dictionary<string, MasteryDto> data { get; set; }
        public MasteryTreeDto tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
}
