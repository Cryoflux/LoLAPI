namespace LoLAPI.Structures.Team
{
    public struct MatchHistorySummaryDto
    {
        //This object contains match history summary information.
        public int assists { get; set; }
        public long date { get; set; } //Date that match was completed specified as epoch milliseconds.
        public int deaths { get; set; }
        public long gameId { get; set; }
        public string gameMode { get; set; }
        public bool invalid { get; set; }
        public int kills { get; set; }
        public int mapId { get; set; }
        public int opposingTeamKills { get; set; }
        public string opposingTeamName { get; set; }
        public bool win { get; set; }
    }
}
