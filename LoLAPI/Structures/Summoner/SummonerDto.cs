using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Structures.Summoner
{
    public struct SummonerDto
    {
        //This object contains summoner information.
        public long id { get; set; } //Summoner ID.
        public string name { get; set; } //Summoner name.
        public int profileIconId { get; set; } //ID of the summoner icon associated with the summoner.
        public long revisionDate { get; set; } //Date summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change
        public long summonerLevel { get; set; } //Summoner level associated with the summoner.
    }
}
