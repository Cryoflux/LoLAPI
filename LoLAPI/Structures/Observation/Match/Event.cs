using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.Match
{
    public struct Event
    {
        /*This object contains game event information. Note that not all legal type values documented below are valid for all games. Event data
          evolves over time and certain values may be relevant only for older or newer games.*/
        public string ascendedType { get; set; } /*The ascended type of the event. Only present if relevant. Note that CLEAR_ASCENDED refers to when
                                                   a participants kills the ascended player. (Legal values: {Enum.GetNames(typeof(AscendedType))})*/
        public List<int> assistingParticipantIds { get; set; } //The assisting participant IDs of the event. Only present if relevant.
        public string buildingType { get; set; } //The building type of the event. Only present if relevant. (Legal values: INHIBITOR_BUILDING, TOWER_BUILDING)
        public int creatorId { get; set; } //The creator ID of the event. Only present if relevant.
        public string eventType { get; set; } //Event type. (Legal values: {Enum.GetNames(typeof(EventType))})
        public int itemAfter { get; set; } //The ending item ID of the event. Only present if relevant.
        public int itemBefore { get; set; } //The starting item ID of the event. Only present if relevant.
        public int itemId { get; set; } //The item ID of the event. Only present if relevant.
        public int killerId { get; set; } //The killer ID of the event. Only present if relevant. Killer ID 0 indicates a minion.
        public string laneType { get; set; } //The lane type of the event. Only present if relevant. (Legal values: BOT_LANE, MID_LANE, TOP_LANE)
        public string levelUpType { get; set; } //The level up type of the event. Only present if relevant. (Legal values: EVOLVE, NORMAL)
        public string monsterType { get; set; } //The monster type of the event. Only present if relevant. (Legal values: BARON_NASHOR, BLUE_GOLEM, DRAGON, RED_LIZARD, VILEMAW)
        public int participantId { get; set; } //The participant ID of the event. Only present if relevant.
        public string pointCaptured { get; set; } //The point captured in the event. Only present if relevant. (Legal values: POINT_A, POINT_B, POINT_C, POINT_D, POINT_E)
        public Position position { get; set; } //The position of the event. Only present if relevant.
        public int skillSlot { get; set; } //The skill slot of the event. Only present if relevant.
        public int teamId { get; set; } //The team ID of the event. Only present if relevant.
        public long timestamp { get; set; } //Represents how many milliseconds into the game the event occurred.
        public string towerType { get; set; } //The tower type of the event. Only present if relevant. (Legal values: BASE_TURRET, FOUNTAIN_TURRET, INNER_TURRET, NEXUS_TURRET, OUTER_TURRET, UNDEFINED_TURRET)
        public int victimId { get; set; } //The victim ID of the event. Only present if relevant.
        public string wardType { get; set; } //The ward type of the event. Only present if relevant. (Legal values: SIGHT_WARD, TEEMO_MUSHROOM, UNDEFINED, VISION_WARD, YELLOW_TRINKET, YELLOW_TRINKET_UPGRADE)
    }
}
