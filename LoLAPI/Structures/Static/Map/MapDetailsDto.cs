using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Map
{
    public struct MapDetailsDto
    {
        //This object contains map details data.
        public ImageDto image { get; set; }
        public long mapId { get; set; }
        public string mapName { get; set; }
        public List<long> unpurchasableItemList { get; set; }
    }
}
