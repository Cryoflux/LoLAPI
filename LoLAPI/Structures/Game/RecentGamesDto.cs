using System.Collections.Generic;

namespace LoLAPI.Structures.Game
{
    public struct RecentGamesDto
    {
        //This object contains recent games information.
        public List<GameDto> games { get; set; } //Collection of recent games played (max 10).
        public long summonerId { get; set; } //Summoner ID.
    }
}
