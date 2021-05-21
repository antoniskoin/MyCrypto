using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyCrypto
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            CryptoWorker.RunWorkerAsync();
        }

        private List<string> cryptoNames = new List<string>();
        private List<string> cryptoPrices = new List<string>();
        private List<string> cryptoMarketCap = new List<string>();
        private List<string> cryptoImages = new List<string>();
        private List<string> cryptoGraph = new List<string>();
        private List<string> cryptoAcronyms = new List<string>();

        public void InvokeIfNeeded(Action action)
        {
            if (InvokeRequired)
            {
                BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }

        private void CryptoWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            HtmlWeb hw = new HtmlWeb();

            for (int i = 1; i < 15; i++)
            {
                HtmlAgilityPack.HtmlDocument doc = hw.Load("https://coinmarketcap.com/?page=" + i);

                foreach (HtmlNode name in doc.DocumentNode.SelectNodes("//td[3]//div[@class='sc-16r8icm-0 sc-1teo54s-1 cPNAgw']//p[@class='sc-1eb5slv-0 iJjGCS']"))
                {
                    cryptoNames.Add(name.InnerText.Trim());
                }

                foreach (HtmlNode acronym in doc.DocumentNode.SelectNodes("//td[3]//div[@class='sc-1teo54s-2 fZIJcI']//p[@class='sc-1eb5slv-0 gGIpIK coin-item-symbol']"))
                {
                    cryptoAcronyms.Add(acronym.InnerText.Trim());
                }

                foreach (HtmlNode price in doc.DocumentNode.SelectNodes("//td[4]//div//a[@class='cmc-link']"))
                {
                    cryptoPrices.Add(Regex.Replace(price.InnerText.Trim(), @"\s+", ""));
                }

                foreach (HtmlNode marketCap in doc.DocumentNode.SelectNodes("//td[7]//p[@class='sc-1eb5slv-0 kDEzev']//span[@class='ggzdxp-1 ftvydZ']"))
                {
                    cryptoMarketCap.Add(Regex.Replace(marketCap.InnerText.Trim(), @"\s+", ""));
                }

                foreach (HtmlNode image in doc.DocumentNode.SelectNodes("//td[3]//div[@class='sc-16r8icm-0 sc-1teo54s-0 jDQqmt']//img[@class='coin-logo']"))
                {
                    HtmlAttribute att = image.Attributes["src"];
                    cryptoImages.Add(att.Value.Trim().Replace("64x64", "32x32"));
                }

                foreach (HtmlNode graph in doc.DocumentNode.SelectNodes("//td[10]//a[@class='cmc-link']//img"))
                {
                    HtmlAttribute att = graph.Attributes["src"];
                    cryptoGraph.Add(att.Value.Trim());
                }
            }
            GC.Collect();
        }

        private void CryptoWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {

                for (int y = 0; y < cryptoNames.Count; y++)
                {
                    CryptoEntry cryptoEntry = new CryptoEntry();
                    CryptoList.Controls.Add(cryptoEntry);
                    ((CryptoEntry)CryptoList.Controls[y]).CryptoName = cryptoNames[y];
                    ((CryptoEntry)CryptoList.Controls[y]).CryptoAcronym = cryptoAcronyms[y];
                    ((CryptoEntry)CryptoList.Controls[y]).CryptoPrice = cryptoPrices[y];
                    ((CryptoEntry)CryptoList.Controls[y]).CryptoMarketCap = cryptoMarketCap[y];
                    ((CryptoEntry)CryptoList.Controls[y]).CryptoImage = cryptoImages[y];
                    ((CryptoEntry)CryptoList.Controls[y]).CryptoGraph = cryptoGraph[y];
                }

                GC.Collect();

                InvokeIfNeeded(() =>
                {
                    PanelLoading.Visible = false;
                    CryptoList.Dock = DockStyle.Fill;
                });
            }
        }
    }
}
