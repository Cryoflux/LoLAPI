using System.Collections.Generic;

namespace LoLAPI.Structures.Status
{
    public struct ShardStatus
    {
        public string hostname { get; set; }
        public List<string> locales { get; set; }
        public string name { get; set; }
        public string region_tag { get; set; }
        public List<Service> services { get; set; }
        public string slug { get; set; }
    }
}
