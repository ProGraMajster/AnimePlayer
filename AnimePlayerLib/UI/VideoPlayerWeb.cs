using System;
using System.Drawing;
using System.Windows.Forms;

using AnimePlayer.Class;

namespace AnimePlayerLibrary
{
    public partial class VideoPlayerWeb : UserControl
    {
        Episode _Episode;
        public VideoPlayerWeb(Episode episode)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            this.Show();
            timerLoadingStatus.Start();
            timerLoad.Start();
            normal = Application.OpenForms[0].Size;
            _Episode=episode;
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            webView21.Dispose();
            this.Hide();
            this.Dispose();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                if(_Episode.LinkToEpisode.Contains("https://www.cda.pl"))
                {
                    string url = _Episode.LinkToEpisode.Replace("https://www.cda.pl/video/", "https://ebd.cda.pl/620x395/");
                    webView21.CoreWebView2.Navigate(url);
                }
                else
                {
                    webView21.NavigateToString(_Episode.LinkToEpisode);
                }
                label1.Hide();
                timerLoad.Stop();
                timerM.Start();
            }
        }

        private void webView21_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void timerM_Tick(object sender, EventArgs e)
        {
            var relativePoint = this.PointToClient(Cursor.Position);
            if (relativePoint.Y < 30)
            {
                panel1.Show();
            }
            else
            {
                panel1.Hide();
            }
        }

        private void webView21_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            timerLoadingStatus.Start();
            label1.Show();
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            timerLoadingStatus.Stop();
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(status_ws)
            {
                GoFullscreen(false);
            }
            else
            {
                GoFullscreen(true);
            }
        }

        Size normal;
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen == false)
            {
                this.ParentForm.Size = normal;
                this.ParentForm.WindowState = FormWindowState.Normal;
                this.ParentForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                button1.Text = "Okno pełnoekranowe";
                status_ws = false;
                normal = this.ParentForm.Size;
            }
            else
            {
                this.ParentForm.WindowState = FormWindowState.Maximized;
                this.ParentForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.ParentForm.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.ParentForm.Height = Screen.PrimaryScreen.WorkingArea.Height;
                button1.Text = "Zwykłe okno";
                status_ws = true;
            }
        }

        bool status_ws = false;
        bool readkey = false;
        private void VideoPlayerWeb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F11)
            {
                if(readkey == false)
                {
                    if (status_ws)
                    {
                        GoFullscreen(false);
                    }
                    else
                    {
                        GoFullscreen(true);
                    }
                }
            }
        }

        private void VideoPlayerWeb_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F11)
            {
                readkey = true;
            }
        }

        private void timerLoadingStatus_Tick(object sender, EventArgs e)
        {
            if(label1.Text == "Ładowanie...")
            {
                label1.Text = "Ładowanie";
            }
            label1.Text += ".";
        }
    }
}
