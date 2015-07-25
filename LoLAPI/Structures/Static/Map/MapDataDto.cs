using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Map
{
    public struct MapDataDto
    {
        //This object contains map data.
        public Dictionary<string, MapDetailsDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
}
