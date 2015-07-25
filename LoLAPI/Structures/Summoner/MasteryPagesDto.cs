using System.Collections.Generic;

namespace LoLAPI.Structures.Summoner
{
    public struct MasteryPagesDto
    {
        //This object contains masteries information.
        public List<MasteryPageDto> pages { get; set; } //Collection of mastery pages associated with the summoner.
        public long summonerId { get; set; } //Summoner ID.
    }
}
