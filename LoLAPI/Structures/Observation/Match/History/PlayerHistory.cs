using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.Match.History
{
    public struct PlayerHistory
    {
        //This object contains player match history information
        public List<MatchSummary> matches { get; set; } //List of matches for the player
    }
}
