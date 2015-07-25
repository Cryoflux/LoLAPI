using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.Match
{
    public struct Team
    {
        //This object contains team information
        public List<BannedChampion> bans { get; set; } //If game was draft mode, contains banned champion data, otherwise null
        public int baronKills { get; set; } //Number of times the team killed baron
        public long dominionVictoryScore { get; set; } //If game was a dominion game, specifies the points the team had at game end, otherwise null
        public int dragonKills { get; set; } //Number of times the team killed dragon
        public bool firstBaron { get; set; } //Flag indicating whether or not the team got the first baron kill
        public bool firstBlood { get; set; } //Flag indicating whether or not the team got first blood
        public bool firstDragon { get; set; } //Flag indicating whether or not the team got the first dragon kill
        public bool firstInhibitor { get; set; } //Flag indicating whether or not the team destroyed the first inhibitor
        public bool firstTower { get; set; } //Flag indicating whether or not the team destroyed the first tower
        public int inhibitorKills { get; set; } //Number of inhibitors the team destroyed
        public int teamId { get; set; } //Team ID
        public int towerKills { get; set; } //Number of towers the team destroyed
        public int vilemawKills { get; set; } //Number of times the team killed vilemaw
        public bool winner { get; set; } //Flag indicating whether or not the team won
    }
}
