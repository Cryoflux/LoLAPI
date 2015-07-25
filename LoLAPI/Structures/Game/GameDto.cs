using System.Collections.Generic;

namespace LoLAPI.Structures.Game
{
    public struct GameDto
    {
        //This object contains game information.
        public int championId { get; set; } //Champion ID associated with game.
        public long createDate { get; set; } //Date that end game data was recorded, specified as epoch milliseconds.
        public List<PlayerDto> fellowPlayers { get; set; } //Other players associated with the game.
        public long gameId { get; set; } //Game ID.
        public string gameMode { get; set; } //Game mode. (Legal values: {Enum.GetNames(typeof(GameMode))})
        public string gameType { get; set; } //Game type. (Legal values: {Enum.GetNames(typeof(GameType))})
        public bool invalid { get; set; } //Invalid flag.
        public int ipEarned { get; set; } //IP Earned.
        public int level { get; set; } //Level.
        public int mapId { get; set; } //Map ID.
        public int spell1Id { get; set; } //ID of first summoner spell.
        public int spell2Id { get; set; } //ID of second summoner spell.
        public RawStatsDto stats { get; set; } //Statistics associated with the game for this summoner.
        public string subType { get; set; } //Game sub-type. (Legal values: {Enum.GetNames(typeof(GameSubType))})
        public int teamId { get; set; } //Team ID associated with game. Team ID 100 is blue team. Team ID 200 is purple team.
    }
}
