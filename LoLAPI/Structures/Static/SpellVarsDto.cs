using System.Collections.Generic;

namespace LoLAPI.Structures.Static
{
    public struct SpellVarsDto
    {
        //This object contains spell vars data.
        public List<double> coeff { get; set; }
        public string dyn { get; set; }
        public string key { get; set; }
        public string link { get; set; }
        public string ranksWith { get; set; }
    }
}
