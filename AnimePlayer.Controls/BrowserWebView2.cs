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
        readonly string _address = "https://www.google.com/webhp";
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

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            try
            {
                BrowserTabPage browserTabPage = (BrowserTabPage)this.Tag;
                if(browserTabPage == null)
                {
                    return;
                }
                BrowserWebView2 browserWebView = new(e.Uri);
                BrowserTabPageItem item = browserTabPage.AddPageAndRef("Nowe okno", null, browserWebView);
                browserWebView.webView.Tag =item;
                e.Handled=false;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void WebView_ContentLoading(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
        {

        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(_address);
                webView.CoreWebView2.NewWindowRequested+=CoreWebView2_NewWindowRequested;
            }
        }

        private void WebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            textBoxLink.Text = webView.Source.ToString();
        }

        private void WebView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {

        }

        private void WebView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
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

        private void TextBoxLink_KeyDown(object sender, KeyEventArgs e)
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

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoBack();
            }
        }

        private void ButtonReundo_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoForward();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
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

        private void TimerRe_Tick(object sender, EventArgs e)
        {
            webView.Size = new Size(Width, this.Height - panel1.Height);
            webView.Location = new Point(0, panel1.Height);
            webView.Refresh();

        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }

        private void BrowserWebView2_SizeChanged(object sender, EventArgs e)
        {
            panelMenu.Left = this.Width-panelMenu.Width;
        }

        private void WebView_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
        }

        private void PanelCda_VisibleChanged(object sender, EventArgs e)
        {
            comboBoxCdaQualityVideo.SelectedIndex=0;
        }

        private void ButtonCdaDwonload_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new();
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string link = AnimePlayer.Core.CdaDownloader.GetVideoLink(textBoxCdaUrl.Text,
                        (Core.CdaQuality)comboBoxCdaQualityVideo.SelectedIndex);
                    WebClient webClient = new();
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

        private void TextBoxCdaUrl_TextChanged(object sender, EventArgs e)
        {
            labelCdaDownloadProgres.Text=":";
            progressBarCdaDownload.Value = 0;
        }
    }
}
