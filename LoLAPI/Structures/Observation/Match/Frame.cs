using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.Match
{
    public struct Frame
    {
        //This object contains game frame information
        public List<Event> events { get; set; } //List of events for this frame.
        public Dictionary<string, ParticipantFrame> participantFrames { get; set; } //Map of each participant ID to the participant's information for the frame.
        public long timestamp { get; set; } //Represents how many milliseconds into the game the frame occurred.
    }
}
