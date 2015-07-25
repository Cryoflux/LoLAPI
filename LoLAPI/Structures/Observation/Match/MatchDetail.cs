using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.Match
{
    public struct MatchDetail
    {
        //This object contains match detail information
        public int mapId { get; set; } //Match map ID
        public long matchCreation { get; set; } /*Match creation time. Designates when the team select lobby is created and/or the match is
                                                  made through match making, not when the game actually starts.*/
        public long matchDuration { get; set; } //Match duration
        public long matchId { get; set; } //ID of the match
        public string matchMode { get; set; } //Match mode (Legal values: {Enum.GetNames(typeof(GameMode))})
        public string matchType { get; set; } //Match type (Legal values: {Enum.GetNames(typeof(GameType))})
        public string matchVersion { get; set; } //Match version
        public List<ParticipantIdentity> participantIdentities { get; set; } //Participant identity information
        public List<Participant> participants { get; set; } //Participant information
        public string platformId { get; set; } //Platform ID of the match
        public string queueType { get; set; } //Match queue type (Legal values: {Enum.GetNames(typeof(GameSubType))})
        public string region { get; set; } //Region where the match was played
        public string season { get; set; } //Season match was played (Legal values: {Enum.GetNames(typeof(Season))})
        public List<Team> teams { get; set; } //Team information
        public Timeline timeline { get; set; } //Match timeline data (not included by default)
    }
}
