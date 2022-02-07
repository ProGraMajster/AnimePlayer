using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using OpenScraping.Config;
using OpenScraping;

namespace AnimePlayerLibrary
{
    public partial class PanelAllNewsContent : UserControl
    {
        public PanelAllNewsContent()
        {
            InitializeComponent();
        }

        private void PanelAllNewsContent_Load(object sender, EventArgs e)
        {
            
            
        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                string html = await webView21.ExecuteScriptAsync("document.documentElement.outerHTML;");
                html = Regex.Unescape(html);
                html = html.Remove(0, 1);
                html = html.Remove(html.Length - 1, 1);
                var configJson = @"
                {
                    'img': {
                        '@class': '',
                        '@src': 'https://i.imgur.com/RRK1dQv.png',
                        '@alt': '„Jaku Chara Tomozaki-kun” dostanie nowe anime! image'
                            },
                    'p': '',
                    'div': {
                        '@class': 'box-more',
                        'ul': {
                            '@class': 'inline-tags-numbered'
                                }
                        }
                      }
            ";


                var config = StructuredDataConfig.ParseJsonString(configJson);


                var openScraping = new StructuredDataExtractor(config);
                var scrapingResults = openScraping.Extract(html);
                foreach (var s in scrapingResults)
                {
                    MessageBox.Show(s.ToString());
                }
            }
        }
    }
}
