using System.Collections.Generic;

namespace LoLAPI.Structures.Stats.Summary
{
    public struct PlayerStatsSummaryListDto
    {
        //This object contains a collection of player stats summary information.
        public List<PlayerStatsSummaryDto> playerStatSummaries { get; set; } //Collection of player stats summaries associated with the summoner.
        public long summonerId { get; set; } //Summoner ID.
    }
}
