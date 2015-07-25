using System.Collections.Generic;

namespace LoLAPI.Structures.Status
{
    public struct Shard
    {
        public string hostname { get; set; }
        public List<string> locales { get; set; }
        public string name { get; set; }
        public string region_tag { get; set; }
        public string slug { get; set; }
    }
}
