namespace LoLAPI.Structures.Game
{
    public struct PlayerDto
    {
        //This object contains player information.
        public int championId { get; set; } //Champion id associated with player.
        public long summonerId { get; set; } //Summoner id associated with player.
        public int teamId { get; set; } //Team id associated with player.
    }
}
