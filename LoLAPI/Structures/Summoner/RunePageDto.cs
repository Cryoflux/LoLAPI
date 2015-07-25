using System.Collections.Generic;

namespace LoLAPI.Structures.Summoner
{
    public struct RunePageDto
    {
        //This object contains rune page information.
        public bool current { get; set; } //Indicates if the page is the current page.
        public long id { get; set; } //Rune page ID.
        public string name { get; set; } //Rune page name.
        public List<RuneSlotDto> slots { get; set; } //Collection of rune slots associated with the rune page.
    }
}
