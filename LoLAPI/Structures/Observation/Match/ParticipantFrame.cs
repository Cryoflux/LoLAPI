namespace LoLAPI.Structures.Observation.Match
{
    public struct ParticipantFrame
    {
        //This object contains participant frame information
        public int currentGold { get; set; } //Participant's current gold
        public int dominionScore { get; set; } //Dominion score of the participant
        public int jungleMinionsKilled { get; set; } //Number of jungle minions killed by participant
        public int level { get; set; } //Participant's current level
        public int minionsKilled { get; set; } //Number of minions killed by participant
        public int participantId { get; set; } //Participant ID
        public Position position { get; set; } //Participant's position
        public int teamScore { get; set; } //Team score of the participant
        public int totalGold { get; set; } //Participant's total gold
        public int xp { get; set; } //Experience earned by participant
    }
}
