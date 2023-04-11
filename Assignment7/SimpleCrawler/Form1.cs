using System.Text.RegularExpressions;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        string urlParseRegex = @"^(?<site>https?://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        SimpleCrawler crawler = new SimpleCrawler();
        BindingSource resultBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Result.DataSource = resultBindingSource;
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(SimpleCrawler obj)
        {
            Action action = () => state.Text = "≈¿≥Ê“—Õ£÷π";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void Crawler_PageDownloaded(SimpleCrawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            crawler.StartURL = starturl.Text;

            Match match = Regex.Match(crawler.StartURL, urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".html?$";

            Task task = Task.Run(() => crawler.Crawl());
            state.Text = "≈¿≥Ê“—∆Ù∂Ø....";
        }
    }
}