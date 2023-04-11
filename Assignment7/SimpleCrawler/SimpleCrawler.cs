using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment7
{
    class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        private int count = 0;
        public string StartURL { get; set; }//起始网址
        public int MaxPage { get; set; }//最大下载数量

        //停止事件
        public event Action<SimpleCrawler> CrawlerStopped;
        //下载事件
        public event Action<SimpleCrawler, string, string> PageDownloaded;
        //等待访问序列
        private readonly Queue<string> waiting = new Queue<string>();
        public string HostFilter { get; set; }
        public string FileFilter { get; set; }

        public Encoding HtmlEncoding { get; set; }

        public SimpleCrawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        public void Crawl()
        {
            urls.Clear();
            waiting.Clear();
            waiting.Enqueue(StartURL);

            while (count < MaxPage && waiting.Count > 0)
            {
                string url = waiting.Dequeue();
                try
                {
                    string html = DownLoad(url);
                    urls[url] = true;
                    count++;
                    PageDownloaded(this, url, "success");
                    Parse(html, url);
                }
                catch (Exception ex)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
            CrawlerStopped(this);
        }

        private string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string pageUrl)//解析，得到超级链接href
        {
            string strRef = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                strRef = UrlConvert(strRef, StartURL);
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private string UrlConvert(string url, string pageUrl)
        {
            string urlParseRegex = @"^(?<site>https?://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
            if (url.Contains("://"))//如果地址里面有://已经是绝对地址
            {
                return url;
            }
            else if (url.StartsWith("//"))//如果地址以//开头则加上http:
            {
                return "http:" + url;
            }
            else if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }
            else if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return UrlConvert(url, pageUrl.Substring(0, idx));
            }
            else if (url.StartsWith("./"))
            {
                return UrlConvert(url.Substring(2), pageUrl);
            }
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
