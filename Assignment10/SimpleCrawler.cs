using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
//htm/html/aspx/php/jsp
namespace CrawlerApp
{
    class SimpleCrawler
    {
        //private Hashtable urls = new Hashtable();
        //private int count = 0;

        public event Action<SimpleCrawler> CrawlerStopped;
        public event Action<SimpleCrawler, string, string> PageDownloaded;
        //待下载队列
        Queue<string> pending = new Queue<string>();
        //已下载网页
        public Dictionary<string, bool> Downloaded { get; } = new Dictionary<string, bool>();
        //绝对地址正则表达式
        //site地址，host域名，file文件名,(:\d+)端口号可以出现可以不出现，(\w+/)*路径名
        public string AddrRegex = @"^(?<site>https?://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //主机过滤规则
        public string HostFilter { get; set; }
        //文件过滤规则
        public string FileFilter { get; set; }
        //最大下载数量
        public int MaxPage { get; set; }
        //起始网址
        public string StartURL { get; set; }
        //网页编码
        public Encoding HtmlEncoding { get; set; }
        public SimpleCrawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }
        public void Crawl()
        {
            Downloaded.Clear();
            pending.Clear();
            pending.Enqueue(StartURL);
            Console.WriteLine("开始爬行了.... ");
            while (Downloaded.Count < MaxPage && pending.Count > 0)
            {
                string url = pending.Dequeue();
                try
                {
                    string html = DownLoad(url); // 下载
                    Downloaded[url] = true;
                    PageDownloaded(this, url, "success");
                    Parse(html, url);//解析,并加入新的链接
                }
                catch (Exception ex)
                {
                    Downloaded[url] = false;
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
            CrawlerStopped(this);
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = Downloaded.Count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html,string url)
        {
            //超级链接正则表达式
            Regex regex = new Regex(@"(href|HREF)\s*=\s*[""'][^""'#>]+[""']");
            MatchCollection matches = regex.Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;
                linkUrl = UrlConvert(linkUrl, url);//转绝对路径
                                                   //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, AddrRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !Downloaded.ContainsKey(linkUrl) && !pending.Contains(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                }
            }
        }
        private string UrlConvert(string url, string pageUrl)
        {
            if (url.Contains("://"))//如果地址里面有://已经是绝对地址
            {
                return url;
            }
            else if (url.StartsWith("//"))//如果地址以//开头则加上协议名https:
            {
                return "http:" + url;
            }
            else if (url.StartsWith("/"))//如果以/开头则把根目录加在url前
            {
                Match urlMatch = Regex.Match(pageUrl, AddrRegex);
                String site = urlMatch.Groups["site"].Value;
                //如果site结尾有/则只要把url的/后面的地址加入，如果没有则全部加入
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }   
            else if (url.StartsWith("../"))//如果以../则将上一级目录加入
            {
                return UrlConvert(url.Substring(3), pageUrl.Substring(0, pageUrl.LastIndexOf('/')));
            }
            else if (url.StartsWith("./"))//如果以./开头则这一级目录加入
            {
                return UrlConvert(url.Substring(2), pageUrl);
            }
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}