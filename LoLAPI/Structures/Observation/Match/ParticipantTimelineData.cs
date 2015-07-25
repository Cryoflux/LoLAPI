namespace LoLAPI.Structures.Observation.Match
{
    public struct ParticipantTimelineData
    {
        //This object contains timeline data
        public double tenToTwenty { get; set; } //Value per minute from 10 min to 20 min
        public double thirtyToEnd { get; set; } //Value per minute from 30 min to the end of the game
        public double twentyToThirty { get; set; } //Value per minute from 20 min to 30 min
        public double zeroToTen { get; set; } //Value per minute from the beginning of the game to 10 min
    }
}
