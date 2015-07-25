namespace LoLAPI.Structures.Stats.Ranked
{
    public struct ChampionStatsDto
    {
        //This object contains a collection of champion stats information.
        public int id { get; set; } //Champion ID. Note that champion ID 0 represents the combined stats for all champions. For static information correlating to champion IDs, please refer to the LoL Static Data API.
        public AggregatedStatsDto stats { get; set; } //Aggregated stats associated with the champion.
    }
}
