using System.Collections.Generic;

namespace LoLAPI.Structures.Status
{
    public struct Service
    {
        public List<Incident> incidents { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string status { get; set; } //Legal values: Online, Alert, Offline, Deploying
    }
}
