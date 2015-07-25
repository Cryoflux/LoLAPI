using System.Collections.Generic;

namespace LoLAPI.Structures.Champion
{
    public struct ChampionListDto
    {
        //This object contains a collection of champion information.
        public List<ChampionDto> champions { get; set; } //The collection of champion information.
    }
}
