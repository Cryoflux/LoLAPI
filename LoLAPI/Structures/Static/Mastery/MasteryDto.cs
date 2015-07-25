using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Mastery
{
    public struct MasteryDto
    {
        //This object contains mastery data.
        public List<string> description { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public string masteryTree { get; set; } //Legal values: Defense, Offense, Utility
        public string name { get; set; }
        public string prereq { get; set; }
        public int ranks { get; set; }
        public List<string> sanitizedDescription { get; set; }
    }
}
