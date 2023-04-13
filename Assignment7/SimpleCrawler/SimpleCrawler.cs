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
namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        //绝对地址正则表达式
        //site地址，host域名，file文件夹名
        public string AddrRegex = @"^(?<site>https?://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                Match urlMatch = Regex.Match(current, AddrRegex);
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                //判断当前网页的类型
                if (urlMatch.Groups["file"].Value != "" && urlMatch.Groups["file"].Value != null)
                {
                    string currentFile = urlMatch.Groups["file"].Value;
                    int end = currentFile.LastIndexOf(".");
                    string currentType = currentFile.Substring(end + 1);
                    if (currentType != "html" && currentType != "htm" && currentType != "aspx" &&
                        currentType != "php" && currentType != "jsp") continue;
                }
                Parse(html, current);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
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

        private void Parse(string html, string url)
        {
            //超级链接正则表达式
            Regex regex = new Regex(@"(href|HREF)[]*=[]*[""'][^""'#>]+[""']");
            MatchCollection matches = regex.Matches(html);
            foreach (Match match in matches)
            {
                //从href=后面开始
                string strRef;
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                strRef = UrlConvert(strRef, url);//转变成绝对地址
                if (urls[strRef] == null) urls[strRef] = false;
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
