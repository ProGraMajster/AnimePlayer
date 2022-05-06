using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    public partial class BrowserWebView2 : UserControl
    {
        string _address;
        public BrowserWebView2()
        {
            InitializeComponent();
        }

        public BrowserWebView2(string address)
        {
            InitializeComponent();
            _address = address;
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

        }

        private void textBoxLink_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webView.CoreWebView2.Navigate(textBoxLink.Text);
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
    }
}
