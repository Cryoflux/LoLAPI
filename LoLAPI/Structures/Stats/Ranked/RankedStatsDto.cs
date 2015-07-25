using System.Collections.Generic;

namespace LoLAPI.Structures.Stats.Ranked
{
    public struct RankedStatsDto
    {
        //This object contains ranked stats information.
        public List<ChampionStatsDto> champions { get; set; } //Collection of aggregated stats summarized by champion.
        public long modifyDate { get; set; } //Date stats were last modified specified as epoch milliseconds.
        public long summonerId { get; set; } //Summoner ID.
    }
}
