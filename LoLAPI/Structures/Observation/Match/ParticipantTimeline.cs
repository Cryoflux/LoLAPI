namespace LoLAPI.Structures.Observation.Match
{
    public struct ParticipantTimeline
    {
        //This object contains all timeline information
        public ParticipantTimelineData ancientGolemAssistsPerMinCounts { get; set; } //Ancient golem assists per minute timeline counts
        public ParticipantTimelineData ancientGolemKillsPerMinCounts { get; set; } //Ancient golem kills per minute timeline counts
        public ParticipantTimelineData assistedLaneDeathsPerMinDeltas { get; set; } //Assisted lane deaths per minute timeline data
        public ParticipantTimelineData assistedLaneKillsPerMinDeltas { get; set; } //Assisted lane kills per minute timeline data
        public ParticipantTimelineData baronAssistsPerMinCounts { get; set; } //Baron assists per minute timeline counts
        public ParticipantTimelineData baronKillsPerMinCounts { get; set; } //Baron kills per minute timeline counts
        public ParticipantTimelineData creepsPerMinDeltas { get; set; } //Creeps per minute timeline data
        public ParticipantTimelineData csDiffPerMinDeltas { get; set; } //Creep score difference per minute timeline data
        public ParticipantTimelineData damageTakenDiffPerMinDeltas { get; set; } //Damage taken difference per minute timeline data
        public ParticipantTimelineData damageTakenPerMinDeltas { get; set; } //Damage taken per minute timeline data
        public ParticipantTimelineData dragonAssistsPerMinCounts { get; set; } //Dragon assists per minute timeline counts
        public ParticipantTimelineData dragonKillsPerMinCounts { get; set; } //Dragon kills per minute timeline counts
        public ParticipantTimelineData elderLizardAssistsPerMinCounts { get; set; } //Elder lizard assists per minute timeline counts
        public ParticipantTimelineData elderLizardKillsPerMinCounts { get; set; } //Elder lizard kills per minute timeline counts
        public ParticipantTimelineData goldPerMinDeltas { get; set; } //Gold per minute timeline data
        public ParticipantTimelineData inhibitorAssistsPerMinCounts { get; set; } //Inhibitor assists per minute timeline counts
        public ParticipantTimelineData inhibitorKillsPerMinCounts { get; set; } //Inhibitor kills per minute timeline counts
        public string lane { get; set; } //Participant's lane (Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM)
        public string role { get; set; } //Participant's role (Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT)
        public ParticipantTimelineData towerAssistsPerMinCounts { get; set; } //Tower assists per minute timeline counts
        public ParticipantTimelineData towerKillsPerMinCounts { get; set; } //Tower kills per minute timeline counts
        public ParticipantTimelineData towerKillsPerMinDeltas { get; set; } //Tower kills per minute timeline data
        public ParticipantTimelineData vilemawAssistsPerMinCounts { get; set; } //Vilemaw assists per minute timeline counts
        public ParticipantTimelineData vilemawKillsPerMinCounts { get; set; } //Vilemaw kills per minute timeline counts
        public ParticipantTimelineData wardsPerMinDeltas { get; set; } //Wards placed per minute timeline data
        public ParticipantTimelineData xpDiffPerMinDeltas { get; set; } //Experience difference per minute timeline data
        public ParticipantTimelineData xpPerMinDeltas { get; set; } //Experience per minute timeline data
    }
}
