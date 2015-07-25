using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.Match
{
    public struct Participant
    {
        //This object contains match participant information
        public int championId { get; set; } //Champion ID
        public string highestAchievedSeasonTier { get; set; } /*Highest ranked tier achieved for the previous season, if any, otherwise null. Used to
                                                                display border in game loading screen. (Legal values: {Enum.GetNames(typeof(LeagueTier))})*/
        public List<Mastery> masteries { get; set; } //List of mastery information
        public int participantId { get; set; } //Participant ID
        public List<Rune> runes { get; set; } //List of rune information
        public long spell1Id { get; set; } //First summoner spell ID
        public long spell2Id { get; set; } //Second summoner spell ID
        public ParticipantStats stats { get; set; } //Participant statistics
        public int teamId { get; set; } //Team ID
        public ParticipantTimeline timeline { get; set; } /*Timeline data. Delta fields refer to values for the specified period (e.g., the gold per minute
                                                            over the first 10 minutes of the game versus the second 20 minutes of the game. Diffs
                                                            fields refer to the deltas versus the calculated lane opponent(s).*/
    }
}
