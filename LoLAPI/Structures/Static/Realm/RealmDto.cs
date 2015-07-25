using System.Collections.Generic;

namespace LoLAPI.Structures.Static.Realm
{
    public struct RealmDto
    {
        //This object contains realm data.
        public string cdn { get; set; } //The base CDN url.
        public string css { get; set; } //Latest changed version of Dragon Magic's css file.
        public string dd { get; set; } //Latest changed version of Dragon Magic.
        public string l { get; set; } //Default language for this realm.
        public string lg { get; set; } //Legacy script mode for IE6 or older.
        public Dictionary<string, string> n { get; set; } //Latest changed version for each data type listed.
        public int profileiconmax { get; set; } /*Special behavior number identifying the largest profileicon id that can be used under 500. Any profileicon that is
                                                  requested between this number and 500 should be mapped to 0.*/
        public string store { get; set; } //Additional api data drawn from other sources that may be related to data dragon functionality.
        public string v { get; set; } //Current version of this file for this realm.
    }
}
