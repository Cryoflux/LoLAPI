using System.Collections.Generic;

namespace LoLAPI.Structures.Static
{
    public struct LevelTipDto
    {
        //This object contains champion level tip data.
        public List<string> effect { get; set; }
        public List<string> label { get; set; }
    }
}
