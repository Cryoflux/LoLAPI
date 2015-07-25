using System.Collections.Generic;

namespace LoLAPI.Structures.Static.String
{
    public struct LanguageStringsDto
    {
        //This object contains language strings data.
        public Dictionary<string, string> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
}
