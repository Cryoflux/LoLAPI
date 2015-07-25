using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Mastery
{
    public struct MasteryTreeDto
    {
        //This object contains mastery tree data.
        public List<MasteryTreeListDto> Defense { get; set; }
        public List<MasteryTreeListDto> Offense { get; set; }
        public List<MasteryTreeListDto> Utility { get; set; }
    }
}
