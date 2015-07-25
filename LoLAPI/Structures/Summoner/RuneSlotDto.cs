namespace LoLAPI.Structures.Summoner
{
    public struct RuneSlotDto
    {
        //This object contains rune slot information.
        public int runeId { get; set; } //Rune ID associated with the rune slot. For static information correlating to rune IDs, please refer to the LoL Static Data API.
        public int runeSlotId { get; set; } //Rune slot ID.
    }
}
