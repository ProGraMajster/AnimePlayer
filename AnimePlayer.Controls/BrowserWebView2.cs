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

namespace AnimePlayer.ControlsWinForms
{
    public partial class BrowserWebView2 : UserControl
    {
        string _address;
        public BrowserWebView2()
        {
            InitializeComponent();
            timerRe.Start();
        }

        public BrowserWebView2(string address)
        {
            InitializeComponent();
            _address = address;
            timerRe.Start();
        }

        private void webView_ContentLoading(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
        {

        }

        private void webView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(_address);
            }
        }

        private void webView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            textBoxLink.Text = webView.Source.ToString();
        }

        private void webView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {

        }

        private void webView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            BrowserTabPageItem item = ((BrowserTabPageItem)webView.Tag);
                item.labelItemTitle.Text = webView.CoreWebView2.DocumentTitle;

            item.pictureBoxItemIcon.ImageLocation =@"http://www.google.com/s2/favicons?domain="+webView.CoreWebView2.Source;
            if (webView.CoreWebView2.Source != null)
            {
                if(webView.CoreWebView2.Source.StartsWith(@"https://www.cda.pl/video/"))
                {
                    panelCda.Show();
                    textBoxCdaUrl.Text = webView.CoreWebView2.Source;
                }
                else
                {
                    panelMenu.Hide();
                }
            }
        }

        private void textBoxLink_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    webView.CoreWebView2.Navigate(textBoxLink.Text);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoBack();
            }
        }

        private void buttonReundo_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoForward();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Reload();  
            }
        }

        private void BrowserWebView2_Resize(object sender, EventArgs e)
        {
            webView.Invoke(() =>
            {
                webView.Size = new Size(Width, this.Height - panel1.Height);
                webView.Location = new Point(0, panel1.Height);
                webView.Update();
                webView.Refresh();
            });
        }

        private void timerRe_Tick(object sender, EventArgs e)
        {
            webView.Size = new Size(Width, this.Height - panel1.Height);
            webView.Location = new Point(0, panel1.Height);
            webView.Refresh();

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }

        private void BrowserWebView2_SizeChanged(object sender, EventArgs e)
        {
            panelMenu.Left = this.Width-panelMenu.Width;
        }

        private void webView_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
        }

        private void panelCda_VisibleChanged(object sender, EventArgs e)
        {
            comboBoxCdaQualityVideo.SelectedIndex=0;
        }

        private void buttonCdaDwonload_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string link = AnimePlayer.Core.CdaDownloader.GetVideoLink(textBoxCdaUrl.Text,
                        (Core.CdaQuality)comboBoxCdaQualityVideo.SelectedIndex);
                    WebClient webClient = new WebClient();
                    webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                    webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                    webClient.DownloadFileAsync(new Uri(link), folderBrowserDialog.SelectedPath+"\\"+
                        webView.CoreWebView2.DocumentTitle +".mp4");
                    webClient.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd:\n"+ex.ToString(), "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                labelCdaDownloadProgres.Text= "File download cancelled.";
            }

            if (e.Error != null)
            {
                labelCdaDownloadProgres.Text =e.Error.Message;
                Console.Error.WriteLine(e.Error.ToString());
            }
            labelCdaDownloadProgres.Text = "Pobrano!";
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            labelCdaDownloadProgres.Text = String.Format("Pobrano {0} z {1} bajtów. Ukończono {2}%...",
        e.BytesReceived,
        e.TotalBytesToReceive,
        e.ProgressPercentage);
            progressBarCdaDownload.Value = e.ProgressPercentage;
        }

        private void textBoxCdaUrl_TextChanged(object sender, EventArgs e)
        {
            labelCdaDownloadProgres.Text=":";
            progressBarCdaDownload.Value = 0;
        }
    }
}
