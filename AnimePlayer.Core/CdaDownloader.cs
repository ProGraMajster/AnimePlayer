using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimePlayer.Core
{
    public enum CdaQuality
    {
        auto = 0,
        p360 = 360,
        p480 = 480,
        p720 = 720,
        p1080 = 1080
    }

    public static class CdaDownloader
    {
        static readonly HttpClient web = new();
        static readonly Regex regex_link = new(@"https:\/\/www.cda.pl\/video\/([^\/\s]+)");
        static readonly Regex regex_file = new(@"""file"":""(.*?)(?:"")");

        /* spytaj sie cda o co im chodzi nie mnie */
        static readonly string[] remove_keys = { "_XDDD", "_CDA", "_ADC", "_CXD", "_QWE", "_Q5", "_IKSDE" };

        static CdaDownloader()
        {
            web.DefaultRequestHeaders.Add("Referer", "https://www.cda.pl");
            web.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:74.0) Gecko/20100101 Firefox/74.0");
            web.DefaultRequestHeaders.Add("Accept-Encoding", "identity");
        }

        /* cda robi przemagiczne rzeczy z tymi stringami */
        public static string DecryptKey(string key, bool https = false)
        {
            string result = String.Empty;
            key = Uri.UnescapeDataString(key);

            foreach (string vkey in remove_keys)
                key = key.Replace(vkey, "");

            foreach (char c in key)
                result += (c >= 33 && c <= 126) ? (char)(33 + ((c + 14) % 94)) : c;

            result = result.Replace(".cda.mp4", "");
            result = result.Replace(".2cda.pl", ".cda.pl");
            result = result.Replace(".3cda.pl", ".cda.pl");

            return (https) ? "https://" : "http://" + result + ".mp4";
        }

        public static string GetVideoLink(string link, CdaQuality quality = CdaQuality.auto, bool https = false)
        {
            if (link.EndsWith("/vfilm"))
                link = link[..^5];

            if (link.EndsWith("/"))
                link = link[..^1];

            if (link.StartsWith("http://"))
                link = string.Concat("https://", link.AsSpan(7, link.Length - 7));

            if (!regex_link.Match(link).Success)
                return null;

            if (quality != CdaQuality.auto)
                link = link + "?wersja=" + (int)quality + "p";

            /* mozna wyciagac to łopatologicznie ze z html tagów potem json objekt ale regex jest szybszy i krótszy :P :D */
            var task = Task.Run(() => web.GetAsync(link).Result.Content.ReadAsStringAsync());
            task.Wait();

            Match match = regex_file.Match(task.Result);

            if (match.Success && match.Groups.Count >= 2)
                return DecryptKey(match.Groups[1].Value, https);

            return null;
        }
    }
}
