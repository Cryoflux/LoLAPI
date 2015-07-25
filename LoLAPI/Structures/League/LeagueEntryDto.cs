namespace LoLAPI.Structures.League
{
    public struct LeagueEntryDto
    {
        //This object contains league participant information representing a summoner or team.
        public string division { get; set; } //The league division of the participant.
        public bool isFreshBlood { get; set; } //Specifies if the participant is fresh blood.
        public bool isHotStreak { get; set; } //Specifies if the participant is on a hot streak.
        public bool isInactive { get; set; } //Specifies if the participant is inactive.
        public bool isVeteran { get; set; } //Specifies if the participant is a veteran.
        public int leaguePoints { get; set; } //The league points of the participant.
        public int losses { get; set; } //The number of losses for the participant.
        public MiniSeriesDto miniSeries { get; set; } //Mini series data for the participant. Only present if the participant is currently in a mini series.
        public string playerOrTeamId { get; set; } //The ID of the participant (i.e., summoner or team) represented by this entry.
        public string playerOrTeamName { get; set; } //The name of the the participant (i.e., summoner or team) represented by this entry.
        public int wins { get; set; } //The number of wins for the participant.
    }
}
