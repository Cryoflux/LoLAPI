using System.Collections.Generic;

namespace LoLAPI.Structures.Team
{
    public struct TeamDto
    {
        //This object contains team information.
        public long createDate { get; set; } //Date that team was created specified as epoch milliseconds.
        public string fullId { get; set; }
        public long lastGameDate { get; set; } //Date that last game played by team ended specified as epoch milliseconds.
        public long lastJoinDate { get; set; } //Date that last member joined specified as epoch milliseconds.
        public long lastJoinedRankedTeamQueueDate { get; set; } //Date that team last joined the ranked team queue specified as epoch milliseconds.
        public List<MatchHistorySummaryDto> matchHistory { get; set; }
        public long modifyDate { get; set; } //Date that team was last modified specified as epoch milliseconds.
        public string name { get; set; }
        public RosterDto roster { get; set; }
        public long secondLastJoinDate { get; set; } //Date that second to last member joined specified as epoch milliseconds.
        public string status { get; set; }
        public string tag { get; set; }
        public List<TeamStatDetailDto> teamStatDetails { get; set; }
        public long thirdLastJoinDate { get; set; } //Date that third to last member joined specified as epoch milliseconds.
    }
}
