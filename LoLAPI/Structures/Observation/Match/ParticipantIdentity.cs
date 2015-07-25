namespace LoLAPI.Structures.Observation.Match
{
    public struct ParticipantIdentity
    {
        //This object contains participant identity information
        public int participantId { get; set; } //Participant ID
        public Player player { get; set; } //Player information
    }
}
