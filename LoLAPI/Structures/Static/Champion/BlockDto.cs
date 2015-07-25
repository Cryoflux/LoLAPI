using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Champion
{
    public struct BlockDto
    {
        //This object contains champion recommended block data.
        public List<BlockItemDto> items { get; set; }
        public bool recMath { get; set; }
        public string type { get; set; }
    }
}
