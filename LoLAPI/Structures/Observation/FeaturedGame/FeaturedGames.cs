using System.Collections.Generic;

namespace LoLAPI.Structures.Observation.FeaturedGame
{
    public struct FeaturedGames
    {
        public long clientRefreshInterval { get; set; } //The suggested interval to wait before requesting FeaturedGames again
        public List<FeaturedGameInfo> gameList { get; set; } //The list of featured games
    }
}
