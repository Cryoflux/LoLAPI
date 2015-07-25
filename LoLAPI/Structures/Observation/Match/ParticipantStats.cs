namespace LoLAPI.Structures.Observation.Match
{
    public struct ParticipantStats
    {
        //This object contains participant statistics information
        public long assists { get; set; } //Number of assists
        public long champLevel { get; set; } //Champion level achieved
        public long combatPlayerScore { get; set; } //If game was a dominion game, player's combat score, otherwise 0
        public long deaths { get; set; } //Number of deaths
        public long doubleKills { get; set; } //Number of double kills
        public bool firstBloodAssist { get; set; } //Flag indicating if participant got an assist on first blood
        public bool firstBloodKill { get; set; } //Flag indicating if participant got first blood
        public bool firstInhibitorAssist { get; set; } //Flag indicating if participant got an assist on the first inhibitor
        public bool firstInhibitorKill { get; set; } //Flag indicating if participant destroyed the first inhibitor
        public bool firstTowerAssist { get; set; } //Flag indicating if participant got an assist on the first tower
        public bool firstTowerKill { get; set; } //Flag indicating if participant destroyed the first tower
        public long goldEarned { get; set; } //Gold earned
        public long goldSpent { get; set; } //Gold spent
        public long inhibitorKills { get; set; } //Number of inhibitor kills
        public long item0 { get; set; } //First item ID
        public long item1 { get; set; } //Second item ID
        public long item2 { get; set; } //Third item ID
        public long item3 { get; set; } //Fourth item ID
        public long item4 { get; set; } //Fifth item ID
        public long item5 { get; set; } //Sixth item ID
        public long item6 { get; set; } //Seventh item ID
        public long killingSprees { get; set; } //Number of killing sprees
        public long kills { get; set; } //Number of kills
        public long largestCriticalStrike { get; set; } //Largest critical strike
        public long largestKillingSpree { get; set; } //Largest killing spree
        public long largestMultiKill { get; set; } //Largest multi kill
        public long magicDamageDealt { get; set; } //Magical damage dealt
        public long magicDamageDealtToChampions { get; set; } //Magical damage dealt to champions
        public long magicDamageTaken { get; set; } //Magic damage taken
        public long minionsKilled { get; set; } //Minions killed
        public long neutralMinionsKilled { get; set; } //Neutral minions killed
        public long neutralMinionsKilledEnemyJungle { get; set; } //Neutral jungle minions killed in the enemy team's jungle
        public long neutralMinionsKilledTeamJungle { get; set; } //Neutral jungle minions killed in your team's jungle
        public long nodeCapture { get; set; } //If game was a dominion game, number of node captures
        public long nodeCaptureAssist { get; set; } //If game was a dominion game, number of node capture assists
        public long nodeNeutralize { get; set; } //If game was a dominion game, number of node neutralizations
        public long nodeNeutralizeAssist { get; set; } //If game was a dominion game, number of node neutralization assists
        public long objectivePlayerScore { get; set; } //If game was a dominion game, player's objectives score, otherwise 0
        public long pentakills { get; set; } //Number of penta kills
        public long physicalDamageDealt { get; set; } //Physical damage dealt
        public long physicalDamageDealtToChampions { get; set; } //Physical damage dealt to champions
        public long physicalDamageTaken { get; set; } //Physical damage taken
        public long quadraKills { get; set; } //Number of quadra kills
        public long sightWardsBoughtInGame { get; set; } //Sight wards purchased
        public long teamObjective { get; set; } //If game was a dominion game, number of completed team objectives (i.e., quests)
        public long totalDamageDealt { get; set; } //Total damage dealt
        public long totalDamageDealtToChampions { get; set; } //Total damage dealt to champions
        public long totalDamageTaken { get; set; } //Total damage taken
        public long totalHeal { get; set; } //Total heal amount
        public long totalPlayerScore { get; set; } //If game was a dominion game, player's total score, otherwise 0
        public long totalScoreRank { get; set; } //If game was a dominion game, team rank of the player's total score (e.g., 1-5)
        public long totalTimeCrowdControlDealt { get; set; } //Total dealt crowd control time
        public long totalUnitsHealed { get; set; } //Total units healed
        public long towerKills { get; set; } //Number of tower kills
        public long tripleKills { get; set; } //Number of triple kills
        public long trueDamageDealt { get; set; } //True damage dealt
        public long trueDamageDealtToChampions { get; set; } //True damage dealt to champions
        public long trueDamageTaken { get; set; } //True damage taken
        public long unrealKills { get; set; } //Number of unreal kills
        public long visionWardsBoughtInGame { get; set; } //Vision wards purchased
        public long wardsKilled { get; set; } //Number of wards killed
        public long wardsPlaced { get; set; } //Number of wards placed
        public bool winner { get; set; } //Flag indicating whether or not the participant won
    }
}
