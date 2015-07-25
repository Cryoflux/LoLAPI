using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.Match
{
    public struct Timeline
    {
        //This object contains game timeline information
        public long frameInterval { get; set; } //Time between each returned frame in milliseconds.
        public List<Frame> frames { get; set; } //List of timeline frames for the game.
    }
}
