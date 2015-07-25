namespace LoLAPI.Structures.Observation.FeaturedGame
{
    public struct Participant
    {
        public bool bot { get; set; } //Flag indicating whether or not this participant is a bot
        public long championId { get; set; } //The ID of the champion played by this participant
        public long profileIconId { get; set; } //The ID of the profile icon used by this participant
        public long spell1Id { get; set; } //The ID of the first summoner spell used by this participant
        public long spell2Id { get; set; } //The ID of the second summoner spell used by this participant
        public string summonerName { get; set; } //The summoner name of this participant
        public long teamId { get; set; } //The team ID of this participant, indicating the participant's team
    }
}
