namespace LoLAPI.Structures.Stats
{
    public struct AggregatedStatsDto
    {
        //This object contains aggregated stat information.
        public int averageAssists { get; set; } //Dominion only.
        public int averageChampionsKilled { get; set; } //Dominion only.
        public int averageCombatPlayerScore { get; set; } //Dominion only.
        public int averageNodeCapture { get; set; } //Dominion only.
        public int averageNodeCaptureAssist { get; set; } //Dominion only.
        public int averageNodeNeutralize { get; set; } //Dominion only.
        public int averageNodeNeutralizeAssist { get; set; } //Dominion only.
        public int averageNumDeaths { get; set; } //Dominion only.
        public int averageObjectivePlayerScore { get; set; } //Dominion only.
        public int averageTeamObjective { get; set; } //Dominion only.
        public int averageTotalPlayerScore { get; set; } //Dominion only.
        public int botGamesPlayed { get; set; }
        public int killingSpree { get; set; }
        public int maxAssists { get; set; } //Dominion only.
        public int maxChampionsKilled { get; set; }
        public int maxCombatPlayerScore { get; set; } //Dominion only.
        public int maxLargestCriticalStrike { get; set; }
        public int maxLargestKillingSpree { get; set; }
        public int maxNodeCapture { get; set; } //Dominion only.
        public int maxNodeCaptureAssist { get; set; } //Dominion only.
        public int maxNodeNeutralize { get; set; } //Dominion only.
        public int maxNodeNeutralizeAssist { get; set; } //Dominion only.
        public int maxNumDeaths { get; set; } //Only returned for ranked statistics.
        public int maxObjectivePlayerScore { get; set; } //Dominion only.
        public int maxTeamObjective { get; set; } //Dominion only.
        public int maxTimePlayed { get; set; }
        public int maxTimeSpentLiving { get; set; }
        public int maxTotalPlayerScore { get; set; } //Dominion only.
        public int mostChampionKillsPerSession { get; set; }
        public int mostSpellsCast { get; set; }
        public int normalGamesPlayed { get; set; }
        public int rankedPremadeGamesPlayed { get; set; }
        public int rankedSoloGamesPlayed { get; set; }
        public int totalAssists { get; set; }
        public int totalChampionKills { get; set; }
        public int totalDamageDealt { get; set; }
        public int totalDamageTaken { get; set; }
        public int totalDeathsPerSession { get; set; } //Only returned for ranked statistics.
        public int totalDoubleKills { get; set; }
        public int totalFirstBlood { get; set; }
        public int totalGoldEarned { get; set; }
        public int totalHeal { get; set; }
        public int totalMagicDamageDealt { get; set; }
        public int totalMinionKills { get; set; }
        public int totalNeutralMinionsKilled { get; set; }
        public int totalNodeCapture { get; set; } //Dominion only.
        public int totalNodeNeutralize { get; set; } //Dominion only.
        public int totalPentaKills { get; set; }
        public int totalPhysicalDamageDealt { get; set; }
        public int totalQuadraKills { get; set; }
        public int totalSessionsLost { get; set; }
        public int totalSessionsPlayed { get; set; }
        public int totalSessionsWon { get; set; }
        public int totalTripleKills { get; set; }
        public int totalTurretsKilled { get; set; }
        public int totalUnrealKills { get; set; }
    }
}
