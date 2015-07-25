using System.Collections.Generic;

namespace LoLAPI.Structures.Summoner
{
    public struct RunePagesDto
    {
        //This object contains rune pages information.
        public List<RunePageDto> pages { get; set; } //Collection of rune pages associated with the summoner.
        public long summonerId { get; set; } //Summoner ID.
    }
}
