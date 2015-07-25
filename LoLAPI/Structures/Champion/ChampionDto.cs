namespace LoLAPI.Structures.Champion
{
    public struct ChampionDto
    {
        //This object contains champion information.
        public bool active { get; set; } //Indicates if the champion is active.
        public bool botEnabled { get; set; } //Bot enabled flag (for custom games).
        public bool botMmEnabled { get; set; } //Bot Match Made enabled flag (for Co-op vs. AI games).
        public bool freeToPlay { get; set; } //Indicates if the champion is free to play. Free to play champions are rotated periodically.
        public long id { get; set; } //Champion ID. For static information correlating to champion IDs, please refer to the LoL Static Data API.
        public bool rankedPlayEnabled { get; set; } //Ranked play enabled flag.
    }
}
