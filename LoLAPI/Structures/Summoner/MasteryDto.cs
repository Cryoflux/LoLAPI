namespace LoLAPI.Structures.Summoner
{
    public struct MasteryDto
    {
        //This object contains mastery information.
        public int id { get; set; } //Mastery ID. For static information correlating to masteries, please refer to the LoL Static Data API.
        public int rank { get; set; } //Mastery rank (i.e., the number of points put into this mastery).
    }
}
