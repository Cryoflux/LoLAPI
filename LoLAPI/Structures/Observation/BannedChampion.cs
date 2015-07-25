namespace LoLAPI.Structures.Observation
{
    public struct BannedChampion
    {
        public long championId { get; set; } //The ID of the banned champion
        public int pickTurn { get; set; } //The turn during which the champion was banned
        public long teamId { get; set; } //The ID of the team that banned the champion
    }
}
