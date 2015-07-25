namespace LoLAPI.Structures.Observation.Match
{
    public struct Player
    {
        //This object contains match player information
        public string matchHistoryUri { get; set; } //Match history URI
        public int profileIcon { get; set; } //Profile icon ID
        public long summonerId { get; set; } //Summoner ID
        public string summonerName { get; set; } //Summoner name
    }
}
