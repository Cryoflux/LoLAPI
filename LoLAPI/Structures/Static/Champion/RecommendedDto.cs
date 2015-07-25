using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Champion
{
    public struct RecommendedDto
    {
        //This object contains champion recommended data.
        public List<BlockDto> blocks { get; set; }
        public string champion { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public bool priority { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }
}
