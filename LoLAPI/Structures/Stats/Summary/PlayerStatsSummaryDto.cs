namespace LoLAPI.Structures.Stats.Summary
{
    public struct PlayerStatsSummaryDto
    {
        //This object contains player stats summary information.
        public AggregatedStatsDto aggregatedStats { get; set; } //Aggregated stats.
        public int losses { get; set; } //Number of losses for this queue type. Returned for ranked queue types only.
        public long modifyDate { get; set; } //Date stats were last modified specified as epoch milliseconds.
        public string playerStatSummaryType { get; set; } //Player stats summary type. (Legal values: {Enum.GetNames(typeof(PlayerStatSummaryType))})
        public int wins { get; set; } //Number of wins for this queue type.
    }
}
