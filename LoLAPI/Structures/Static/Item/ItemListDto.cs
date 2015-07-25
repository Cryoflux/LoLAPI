using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Item
{
    public struct ItemListDto
    {
        //This object contains item list data.
        public BasicDataDto basic { get; set; }
        public Dictionary<string, ItemDto> data { get; set; }
        public List<GroupDto> groups { get; set; }
        public List<ItemTreeDto> tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
}
