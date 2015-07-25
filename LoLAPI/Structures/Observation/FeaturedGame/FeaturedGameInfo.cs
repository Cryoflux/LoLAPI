using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.FeaturedGame
{
    public struct FeaturedGameInfo
    {
        public List<BannedChampion> bannedChampions { get; set; } //Banned champion information
        public long gameId { get; set; } //The ID of the game
        public long gameLength { get; set; } //The amount of time in seconds that has passed since the game started
        public string gameMode { get; set; } //The game mode (Legal values: {Enum.GetNames(typeof(GameMode))})
        public long gameQueueConfigId { get; set; } //The queue type (queue types are documented on the Game Constants page)
        public long gameStartTime { get; set; } //The game start time represented in epoch milliseconds
        public string gameType { get; set; } //The game type (Legal values: {Enum.GetNames(typeof(GameType))})
        public long mapId { get; set; } //The ID of the map
        public Observer observers { get; set; } //The observer information
        public List<Participant> participants { get; set; } //The participant information
        public string platformId { get; set; } //The ID of the platform on which the game is being played
    }
}
