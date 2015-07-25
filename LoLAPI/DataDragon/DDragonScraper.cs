using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;

namespace LoLAPI.DataDragon
{
    public sealed class DDragonScraper
    {
        private static DDragonScraper mInstance;
        private Dictionary<string, Image> ImageCache;
        private string BaseURL;

        private DDragonScraper(string cdn, string version)
        {
            ImageCache = new Dictionary<string, Image>();
            this.BaseURL = string.Format("{0}/{1}/", cdn, version);
        }

        public static DDragonScraper Instance
        {
            get
            {
                return mInstance;
            }
        }

        public static void Create(string cdn, string version)
        {
            if (mInstance != null)
                return;
            mInstance = new DDragonScraper(cdn, version);
        }

        public Image DownloadImage(string imgPath)
        {
            if (ImageCache.ContainsKey(imgPath))
                return ImageCache[imgPath];

            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(BaseURL + imgPath);
            try
            {
                using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    Image img = Image.FromStream(stream);
                    ImageCache.Add(imgPath, img);
                    return img;
                }
            }
            catch { }
            return null;
        }
    }
}
