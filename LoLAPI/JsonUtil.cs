using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace WebUtil
{
    public static class JsonUtil
    {
        public static T DeserializeJson<T>(string json)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            if (!json.Equals(string.Empty))
                return serializer.Deserialize<T>(json);
            return default(T);
        }

        public static T DeserializeJsonFromWeb<T>(string url, out int statusCode)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response;
            request.ContentType = "application/json; charset=utf-8";
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                    statusCode = (int)((HttpWebResponse)ex.Response).StatusCode;
                else
                    statusCode = 0;
                return default(T);
            }
            statusCode = (int)response.StatusCode;
            string json;
            using (var sr = new StreamReader(response.GetResponseStream()))
                json = sr.ReadToEnd();
            return DeserializeJson<T>(json);
        }
    }
}
