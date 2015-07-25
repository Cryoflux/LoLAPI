using System.Collections.Generic;

namespace LoLAPI.Structures.Status
{
    public struct Incident
    {
        public bool active { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public List<Message> updates { get; set; }
    }
}
