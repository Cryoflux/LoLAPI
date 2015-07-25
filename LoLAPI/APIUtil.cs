using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using WebUtil;

namespace LoLAPI
{
    public static class APIUtil
    {
        #region General

        public static void LoadConfig(string json)
        {
            JsonUtil.DeserializeJson<Config>(json);
        }

        public static int LoadDDragonScraper()
        {
            Structures.Static.Realm.RealmDto realm;
            int result;
            realm = LoLAPI.APIUtil.RetrieveRealm(out result);
            if (result == 200) //200 - OK
                LoLAPI.DataDragon.DDragonScraper.Create(realm.cdn, realm.v); //Create an instance of DDragonScraper
            return result;
        }

        private static string CreateRequestURL(string baseUrl, params string[] parameters)
        {
            string url = string.Format(baseUrl,
                Enum.GetName(typeof(Region), Config.Instance.Region),
                Enum.GetName(typeof(Platform), Config.Instance.Region));
            url += "?";
            foreach (string p in parameters)
                url += p + "&";
            url += "api_key=" + Config.Instance.APIKey;
            return url;
        }

        #endregion

        /*#region API Challenge v4.1

        private const string APIChallengeURL = "https://{0}.api.pvp.net/api/lol/{0}/v4.1/game/ids";

        public static long GetBucketTime()
        {
            DateTime now = DateTime.UtcNow;
            int mins = now.Minute;
            while (mins % 5 != 0) mins--;
            DateTime bucketTime = new DateTime(now.Year, now.Month, now.Day, now.Hour, mins, 0, DateTimeKind.Utc);
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (long)(bucketTime - epoch).TotalSeconds;
        }

        public static List<long> GetBucket(long beginDate, out int statusCode)
        {
            string url = CreateRequestURL(APIChallengeURL, "beginDate=" + beginDate);
            return JsonUtil.DeserializeJsonFromWeb<List<long>>(url, out statusCode);
        }

        #endregion*/

        #region Champion v2.1

        private const string ChampionURL = "https://{0}.api.pvp.net/api/lol/{0}/v1.2/champion";

        public static Structures.Champion.ChampionListDto RetrieveChampions(bool freeToPlay, out int statusCode)
        {
            string url = CreateRequestURL(ChampionURL, "freeToPlay" + freeToPlay);
            return JsonUtil.DeserializeJsonFromWeb<Structures.Champion.ChampionListDto>(url, out statusCode);
        }

        public static Structures.Champion.ChampionDto RetrieveChampion(int id, out int statusCode)
        {
            string url = CreateRequestURL(ChampionURL + "/" + id);
            return JsonUtil.DeserializeJsonFromWeb<Structures.Champion.ChampionDto>(url, out statusCode);
        }

        #endregion

        #region Current Game v1.0

        private const string CurrentGameURL = "https://{0}.api.pvp.net/observer-mode/rest/consumer/getSpectatorGameInfo/{1}";

        public static Structures.Observation.CurrentGame.CurrentGameInfo GetSpectatorGameInfo(long summonerId, out int statusCode)
        {
            string url = CreateRequestURL(CurrentGameURL + "/" + summonerId);
            return JsonUtil.DeserializeJsonFromWeb<Structures.Observation.CurrentGame.CurrentGameInfo>(url, out statusCode);
        }

        #endregion

        #region Featured Games v1.0

        private const string FeaturedGamesURL = "https://{0}.api.pvp.net/observer-mode/rest/featured";

        public static Structures.Observation.FeaturedGame.FeaturedGames GetFeaturedGames(out int statusCode)
        {
            string url = CreateRequestURL(FeaturedGamesURL);
            return JsonUtil.DeserializeJsonFromWeb<Structures.Observation.FeaturedGame.FeaturedGames>(url, out statusCode);
        }

        #endregion

        #region Game v1.3

        public const string RecentGamesURL = "https://{0}.api.pvp.net/api/lol/{0}/v1.3/game/by-summoner";

        public static Structures.Game.RecentGamesDto GetRecentGames(long summonerId, out int statusCode)
        {
            string url = CreateRequestURL(RecentGamesURL + string.Format("/{0}/recent", summonerId));
            return JsonUtil.DeserializeJsonFromWeb<Structures.Game.RecentGamesDto>(url, out statusCode);
        }

        #endregion

        #region League v2.5

        public const string LeagueURL = "https://{0}.api.pvp.net/api/lol/{0}/v2.5/league";

        public static Dictionary<string, List<Structures.League.LeagueDto>> GetSummonerLeagues(long[] summonerIds, out int statusCode)
        {
            string url = CreateRequestURL(LeagueURL + string.Format("/by-summoner/{0}", string.Join(",", summonerIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, List<Structures.League.LeagueDto>>>(url, out statusCode);
        }

        public static Dictionary<string, List<Structures.League.LeagueDto>> GetSummonerLeagueEntries(long[] summonerIds, out int statusCode)
        {
            string url = CreateRequestURL(LeagueURL + string.Format("/by-summoner/{0}/entry", string.Join(",", summonerIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, List<Structures.League.LeagueDto>>>(url, out statusCode);
        }

        public static Dictionary<string, List<Structures.League.LeagueDto>> GetTeamLeagues(long[] teamIds, out int statusCode)
        {
            string url = CreateRequestURL(LeagueURL + string.Format("/by-team/{0}", string.Join(",", teamIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, List<Structures.League.LeagueDto>>>(url, out statusCode);
        }

        public static Dictionary<string, List<Structures.League.LeagueDto>> GetTeamLeagueEntries(long[] teamIds, out int statusCode)
        {
            string url = CreateRequestURL(LeagueURL + string.Format("/by-team/{0}/entry", string.Join(",", teamIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, List<Structures.League.LeagueDto>>>(url, out statusCode);
        }

        public static Structures.League.LeagueDto GetChallengers(Structures.League.LeagueQueue type, out int statusCode)
        {
            string url = CreateRequestURL(LeagueURL + "/challenger", "type=" + Enum.GetName(typeof(Structures.League.LeagueQueue), type));
            return JsonUtil.DeserializeJsonFromWeb<Structures.League.LeagueDto>(url, out statusCode);
        }

        #endregion

        #region Static Data v1.2

        public const string StaticDataURL = "https://global.api.pvp.net/api/lol/static-data/{0}/v1.2";

        public static Structures.Static.Champion.ChampionListDto RetrieveChampionsData(out int statusCode, string locale = null, string version = null, bool? dataById = null, string champData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (dataById.HasValue)
                optParams.Add("dataById=" + dataById.Value);
            if (champData != null)
                optParams.Add("champData=" + champData);
            string url = CreateRequestURL(StaticDataURL + "/champion", optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Champion.ChampionListDto>(url, out statusCode);
        }

        public static Structures.Static.Champion.ChampionDto RetrieveChampionData(int id, out int statusCode, string locale = null, string version = null, bool? dataById = null, string champData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (dataById.HasValue)
                optParams.Add("dataById=" + dataById.Value);
            if (champData != null)
                optParams.Add("champData=" + champData);
            string url = CreateRequestURL(StaticDataURL + "/champion/" + id, optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Champion.ChampionDto>(url, out statusCode);
        }

        public static Structures.Static.Item.ItemListDto RetrieveItems(out int statusCode, string locale = null, string version = null, string itemListData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (itemListData != null)
                optParams.Add("itemListData=" + itemListData);
            string url = CreateRequestURL(StaticDataURL + "/item", optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Item.ItemListDto>(url, out statusCode);
        }

        public static Structures.Static.Item.ItemListDto RetrieveItem(int id, out int statusCode, string locale = null, string version = null, string itemListData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (itemListData != null)
                optParams.Add("itemListData=" + itemListData);
            string url = CreateRequestURL(StaticDataURL + "/item/" + id, optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Item.ItemListDto>(url, out statusCode);
        }

        public static Structures.Static.String.LanguageStringsDto RetrieveStrings(out int statusCode, string locale = null, string version = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            string url = CreateRequestURL(StaticDataURL + "/language-strings", optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.String.LanguageStringsDto>(url, out statusCode);
        }

        public static List<string> RetrieveLanguages(out int statusCode)
        {
            string url = CreateRequestURL(StaticDataURL + "/languages");
            return JsonUtil.DeserializeJsonFromWeb<List<string>>(url, out statusCode);
        }

        public static Structures.Static.Map.MapDataDto RetrieveMaps(out int statusCode, string locale = null, string version = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            string url = CreateRequestURL(StaticDataURL + "/map", optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Map.MapDataDto>(url, out statusCode);
        }

        public static Structures.Static.Mastery.MasteryListDto RetrieveMasteries(out int statusCode, string locale = null, string version = null, string masteryListData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (masteryListData != null)
                optParams.Add("masteryListData=" + masteryListData);
            string url = CreateRequestURL(StaticDataURL + "/mastery", optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Mastery.MasteryListDto>(url, out statusCode);
        }

        public static Structures.Static.Mastery.MasteryDto RetrieveMastery(int id, out int statusCode, string locale = null, string version = null, string masteryListData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (masteryListData != null)
                optParams.Add("masteryListData=" + masteryListData);
            string url = CreateRequestURL(StaticDataURL + "/mastery/" + id, optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Mastery.MasteryDto>(url, out statusCode);
        }

        public static Structures.Static.Realm.RealmDto RetrieveRealm(out int statusCode)
        {
            string url = CreateRequestURL(StaticDataURL + "/realm");
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Realm.RealmDto>(url, out statusCode);
        }

        public static Structures.Static.Rune.RuneListDto RetrieveRunes(out int statusCode, string locale = null, string version = null, string runeListData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (runeListData != null)
                optParams.Add("runeListData=" + runeListData);
            string url = CreateRequestURL(StaticDataURL + "/rune", optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Rune.RuneListDto>(url, out statusCode);
        }

        public static Structures.Static.Rune.RuneDto RetrieveRune(int id, out int statusCode, string locale = null, string version = null, string runeListData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (runeListData != null)
                optParams.Add("runeListData=" + runeListData);
            string url = CreateRequestURL(StaticDataURL + "/rune/" + id, optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Rune.RuneDto>(url, out statusCode);
        }

        public static Structures.Static.Spell.SummonerSpellListDto RetrieveSummonerSpells(out int statusCode, string locale = null, string version = null, bool? dataById = null, string spellData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (dataById.HasValue)
                optParams.Add("dataById=" + dataById.Value);
            if (spellData != null)
                optParams.Add("spellData=" + spellData);
            string url = CreateRequestURL(StaticDataURL + "/summoner-spell", optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Spell.SummonerSpellListDto>(url, out statusCode);
        }

        public static Structures.Static.Spell.SummonerSpellDto RetrieveSummonerSpell(int id, out int statusCode, string locale = null, string version = null, bool? dataById = null, string spellData = null)
        {
            List<string> optParams = new List<string>();
            if (locale != null)
                optParams.Add("locale=" + locale);
            if (version != null)
                optParams.Add("version=" + version);
            if (dataById.HasValue)
                optParams.Add("dataById=" + dataById.Value);
            if (spellData != null)
                optParams.Add("spellData=" + spellData);
            string url = CreateRequestURL(StaticDataURL + "/summoner-spell/" + id, optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Static.Spell.SummonerSpellDto>(url, out statusCode);
        }

        public static List<string> RetrieveVersions(out int statusCode)
        {
            string url = CreateRequestURL(StaticDataURL + "/versions");
            return JsonUtil.DeserializeJsonFromWeb<List<string>>(url, out statusCode);
        }

        #endregion

        #region Status v1.0

        public const string StatusURL = "http://status.leagueoflegends.com/";

        public static List<Structures.Status.Shard> RetrieveShards(out int statusCode)
        {
            string url = CreateRequestURL(StatusURL + "/shards");
            return JsonUtil.DeserializeJsonFromWeb<List<Structures.Status.Shard>>(url, out statusCode);
        }

        public static Structures.Status.ShardStatus RetrieveShardStatus(out int statusCode)
        {
            string url = StatusURL + "/shards/" + Config.Instance.Region;
            return JsonUtil.DeserializeJsonFromWeb<Structures.Status.ShardStatus>(url, out statusCode);
        }

        #endregion

        #region Match v2.2

        public const string MatchURL = "https://{0}.api.pvp.net/api/lol/{0}/v2.2/match";

        public static Structures.Observation.Match.MatchDetail RetrieveMatchDetail(long matchId, out int statusCode, bool? includeTimeline = null)
        {
            List<string> optParams = new List<string>();
            if (includeTimeline.HasValue)
                optParams.Add("includeTimeline=" + includeTimeline.Value);
            string url = CreateRequestURL(MatchURL + "/" + matchId, optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Observation.Match.MatchDetail>(url, out statusCode);
        }

        #endregion

        #region Match History v2.2

        public const string MatchHistoryURL = "https://{0}.api.pvp.net/api/lol/{0}/v2.2/matchhistory";

        public static Structures.Observation.Match.History.PlayerHistory RetrieveMatchHistory(
            long summonerId, out int statusCode, long[] championIds = null,
            Structures.League.LeagueQueue? rankedQueues = null,
            int? beginIndex = null, int? endIndex = null)
        {
            List<string> optParams = new List<string>();
            if (championIds != null)
                optParams.Add("championIds=" + string.Join(",", championIds));
            if (rankedQueues.HasValue)
                optParams.Add("rankedQueues=" + Enum.GetName(typeof(Structures.League.LeagueQueue), rankedQueues.Value));
            if (beginIndex.HasValue)
                optParams.Add("beginIndex=" + beginIndex.Value);
            if (endIndex.HasValue)
                optParams.Add("endIndex=" + endIndex.Value);
            string url = CreateRequestURL(MatchHistoryURL + "/" + summonerId, optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Observation.Match.History.PlayerHistory>(url, out statusCode);
        }

        #endregion

        #region Stats v1.3

        public const string StatsURL = "https://{0}.api.pvp.net/api/lol/{0}/v1.3/stats";

        public static Structures.Stats.Ranked.RankedStatsDto RetrieveRankedStats(long summonerId, out int statusCode, Structures.Stats.Season? season = null)
        {
            List<string> optParams = new List<string>();
            if (season.HasValue)
                optParams.Add(Enum.GetName(typeof(Structures.Stats.Season), season.Value));
            string url = CreateRequestURL(StatsURL + string.Format("/by-summoner/{0}/ranked", summonerId), optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Stats.Ranked.RankedStatsDto>(url, out statusCode);
        }

        public static Structures.Stats.Summary.PlayerStatsSummaryListDto RetrieveStatsSummary(long summonerId, out int statusCode, Structures.Stats.Season? season = null)
        {
            List<string> optParams = new List<string>();
            if (season.HasValue)
                optParams.Add(Enum.GetName(typeof(Structures.Stats.Season), season.Value));
            string url = CreateRequestURL(StatsURL + string.Format("/by-summoner/{0}/summary", summonerId), optParams.ToArray());
            return JsonUtil.DeserializeJsonFromWeb<Structures.Stats.Summary.PlayerStatsSummaryListDto>(url, out statusCode);
        }

        #endregion

        #region Summoner v1.4

        public const string SummonerURL = "https://{0}.api.pvp.net/api/lol/{0}/v1.4/summoner";

        public static Dictionary<string, Structures.Summoner.SummonerDto> RetrieveSummonerData(string[] summonerNames, out int statusCode)
        {
            string url = CreateRequestURL(SummonerURL + string.Format("/by-name/{0}", string.Join(",", summonerNames)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, Structures.Summoner.SummonerDto>>(url, out statusCode);
        }

        public static Dictionary<string, Structures.Summoner.SummonerDto> RetrieveSummonerData(long[] summonerIds, out int statusCode)
        {
            string url = CreateRequestURL(SummonerURL + string.Format("/{0}", string.Join(",", summonerIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, Structures.Summoner.SummonerDto>>(url, out statusCode);
        }

        public static Dictionary<string, Structures.Summoner.MasteryPagesDto> RetrieveSummonerMasteries(long[] summonerIds, out int statusCode)
        {
            string url = CreateRequestURL(SummonerURL + string.Format("/{0}/masteries", string.Join(",", summonerIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, Structures.Summoner.MasteryPagesDto>>(url, out statusCode);
        }

        public static Dictionary<string, string> RetrieveSummonerName(long[] summonerIds, out int statusCode)
        {
            string url = CreateRequestURL(SummonerURL + string.Format("/{0}/name", string.Join(",", summonerIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, string>>(url, out statusCode);
        }

        public static Dictionary<string, Structures.Summoner.RunePagesDto> RetrieveSummonerRunes(long[] summonerIds, out int statusCode)
        {
            string url = CreateRequestURL(SummonerURL + string.Format("/{0}/runes", string.Join(",", summonerIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, Structures.Summoner.RunePagesDto>>(url, out statusCode);
        }

        #endregion

        #region Team v2.4

        public const string TeamURL = "https://{0}.api.pvp.net/api/lol/{0}/v2.4/team";

        public static Dictionary<string, Structures.Team.TeamDto> RetrieveSummonerTeams(long[] summonerIds, out int statusCode)
        {
            string url = CreateRequestURL(TeamURL + string.Format("/by-summoner/{0}", string.Join(",", summonerIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, Structures.Team.TeamDto>>(url, out statusCode);
        }

        public static Dictionary<string, Structures.Team.TeamDto> RetrieveTeams(long[] teamIds, out int statusCode)
        {
            string url = CreateRequestURL(TeamURL + string.Format("/{0}", string.Join(",", teamIds)));
            return JsonUtil.DeserializeJsonFromWeb<Dictionary<string, Structures.Team.TeamDto>>(url, out statusCode);
        }

        #endregion
    }
}
