using System.Collections.Generic;

namespace LoLAPI.Structures.Status
{
    public struct Message
    {
        public string author { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public string severity { get; set; } //Legal values: Info, Alert, Error
        public List<Translation> translations { get; set; }
        public string updated_at { get; set; }
    }
}
