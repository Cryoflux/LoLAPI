using System.Collections.Generic;

namespace LoLAPI.Structures.Summoner
{
    public struct MasteryPageDto
    {
        //This object contains mastery page information.
        public bool current { get; set; } //Indicates if the mastery page is the current mastery page.
        public long id { get; set; } //Mastery page ID.
        public List<MasteryDto> masteries { get; set; } //Collection of masteries associated with the mastery page.
        public string name { get; set; } //Mastery page name.
    }
}
