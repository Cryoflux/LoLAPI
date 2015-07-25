namespace LoLAPI
{
    public class Config
    {
        public static Config Instance;
        public string APIKey;
        public Region Region;

        public Config()
        {
            Instance = this;
        }
    }
}
