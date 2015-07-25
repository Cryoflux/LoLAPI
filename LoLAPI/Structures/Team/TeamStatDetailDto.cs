namespace LoLAPI.Structures.Team
{
    public struct TeamStatDetailDto
    {
        //This object contains team statistics detail information.
        public int averageGamesPlayed { get; set; }
        public int losses { get; set; }
        public string teamStatType { get; set; }
        public int wins { get; set; }
    }
}
