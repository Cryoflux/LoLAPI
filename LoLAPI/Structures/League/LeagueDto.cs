using System.Collections.Generic;

namespace LoLAPI.Structures.League
{
    public struct LeagueDto
    {
        //This object contains league information.
        public List<LeagueEntryDto> entries { get; set; } //The requested league entries.
        public string name { get; set; } /*This name is an internal place-holder name only. Display and localization of names in the game client
                                             are handled client-side.*/
        public string participantId { get; set; } /*Specifies the relevant participant that is a member of this league (i.e., a requested summoner ID, a
                                                      requested team ID, or the ID of a team to which one of the requested summoners belongs). Only
                                                      present when full league is requested so that participant's entry can be identified. Not present when
                                                      individual entry is requested.*/
        public string queue { get; set; } //The league's queue type. (Legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        public string tier { get; set; } //The league's tier. (Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)
    }
}
