using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace CloudFlareWARPTool
{
    public static class Util
    {
        public const int REQUEST_TIMEOUT = 5000;
        public const string HOST_URL = "api.cloudflareclient.com";
        public const string RANDOM_NUMBER_STRING = "0123456789";
        public const string PROXY_URL = "https://api.proxyscrape.com?request=getproxies&proxytype=http&timeout=10000&country=all&ssl=all&anonymity=all";

        public static readonly string RANDOM_STRING = $"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ{RANDOM_NUMBER_STRING}";
        public static readonly Regex UUIDPattern = new Regex("^([0-9A-Fa-f]{8}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{12})$");
        public static readonly Random random = new Random();

        public static bool isUUID(string data)
        {
            return UUIDPattern.IsMatch(data);
        }

        public static string generateRandomString(string randomString, int length)
        {
            string ret = string.Empty;
            int index = randomString.Length;
            while (ret.Length < length)
            {
                ret += randomString[random.Next(0, index)];
            }
            return ret;
        }

        public static string generateRandomString(int length)
        {
            return generateRandomString(RANDOM_STRING, length);
        }

        public static string generateNumber(int length)
        {
            return generateRandomString(RANDOM_NUMBER_STRING, length);
        }

        public static IList<string> getProxyList(int timeout = REQUEST_TIMEOUT)
        {
            IList<string> ret = new List<string>();
            WebRequest request = WebRequest.Create(PROXY_URL);
            request.Timeout = timeout;

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    string proxy = sr.ReadToEnd();
                    MatchCollection matchCollection = new Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}").Matches(proxy);
                    foreach (Match match in matchCollection)
                    {
                        ret.Add(match.Value);
                    }
                }
            }
            return ret;
        }

        public static void sendRegister(string userId, string proxyAddress = null, int timeout = REQUEST_TIMEOUT)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://{HOST_URL}/v0a{generateNumber(3)}/reg");
            httpWebRequest.ContentType = "application/json; charset=UTF-8";
            httpWebRequest.Headers.Add("Accept-Encoding", "gzip");
            httpWebRequest.Host = HOST_URL;
            httpWebRequest.Method = "POST";
            httpWebRequest.ReadWriteTimeout = httpWebRequest.ServicePoint.ConnectionLeaseTimeout = httpWebRequest.ServicePoint.MaxIdleTime
                = httpWebRequest.Timeout = timeout;
            httpWebRequest.UserAgent = "okhttp/3.12.1";

            if (proxyAddress != null)
            {
                string[] split = proxyAddress.Split(':');
                string host = split[0];
                string value = split[1];
                httpWebRequest.Proxy = new WebProxy(host, Convert.ToInt32(value));
            }

            const int ADD_HOUR = 2;
            string installId = generateRandomString(22);
            string fcmToken = $"{installId}:APA91b{generateRandomString(134)}";
            var body = new
            {
                install_id = installId,
                key = $"{generateRandomString(43)}=",
                tos = $"{DateTime.UtcNow.AddHours(ADD_HOUR).ToString("yyyy-MM-ddTHH:mm:ss.fff")}+0{ADD_HOUR}:00",
                fcm_token = fcmToken,
                referrer = userId,
                warp_enabled = false,
                type = "Android",
                locale = "es_ES"
            };
            string jsonBody = JsonConvert.SerializeObject(body);
            using (StreamWriter sw = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                sw.Write(jsonBody);
            }

            using (WebResponse httpResponse = httpWebRequest.GetResponse())
            {
                using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
                {
                    sr.ReadToEnd();
                }
            }
        }
    }
}