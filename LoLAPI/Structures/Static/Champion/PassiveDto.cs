namespace LoLAPI.Structures.Static.Champion
{
    public struct PassiveDto
    {
        //This object contains champion passive data.
        public string description { get; set; }
        public ImageDto image { get; set; }
        public string name { get; set; }
        public string sanitizedDescription { get; set; }
    }
}
