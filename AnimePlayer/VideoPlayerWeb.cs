using System;
using System.Windows.Forms;

namespace AnimePlayer
{
    public partial class VideoPlayerWeb : UserControl
    {
        public string videoLink;
        public TypeVideo tvideo;
        public enum TypeVideo : int
        {
            YouTube = 0,
            GoogleDrive = 1,
            Cda = 2,
            Mega = 3
        }

        public VideoPlayerWeb(string vlink, TypeVideo video, Panel panel)
        {
            InitializeComponent();
            panel.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            this.Show();
            videoLink = vlink;
            tvideo = video;
            timerLoadingStatus.Start();
            timerLoad.Start();
            normal = Application.OpenForms[0].Size;
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
                if (tvideo == TypeVideo.YouTube)
                {
                    var url = videoLink.Replace("watch?v=", "embed/");
                    webView21.NavigateToString(url);
                }
                else if(tvideo == TypeVideo.Cda)
                {
                    videoLink = videoLink.Replace("https://www.cda.pl/video/", "https://ebd.cda.pl/620x395/");
                    webView21.CoreWebView2.Navigate(videoLink);
                }
                else if (tvideo == TypeVideo.GoogleDrive)
                {
                    //vlink = https://drive.google.com/file/d/1UQu5rXnwpJPirhCIBocszJpX7YCjGDeJ/preview\
                    var embed = "<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe src=\"https://drive.google.com/file/d/" + videoLink + "/view" + "\" width=\"640\" height=\"480\"" +
                    " allow=\"autoplay\"></iframe>";
                    webView21.NavigateToString(embed);
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
                Application.OpenForms[0].Size = normal;
                Application.OpenForms[0].WindowState = FormWindowState.Normal;
                Application.OpenForms[0].FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                button1.Text = "Okno pełnoekranowe";
                status_ws = false;
                normal = Application.OpenForms[0].Size;
            }
            else
            {
                Application.OpenForms[0].WindowState = FormWindowState.Maximized;
                Application.OpenForms[0].FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Application.OpenForms[0].Width = Screen.PrimaryScreen.WorkingArea.Width;
                Application.OpenForms[0].Height = Screen.PrimaryScreen.WorkingArea.Height;
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
