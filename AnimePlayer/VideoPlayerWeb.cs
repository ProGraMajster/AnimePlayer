using System;
using System.Windows.Forms;

namespace AnimePlayer
{
    public partial class VideoPlayerWeb : UserControl
    {
        public string videoLink;

        public enum TypeVideo : int
        {
            YouTube = 0,
            GoogleDrive = 1,
            Cda
        }

        public VideoPlayerWeb(string vlink, TypeVideo video, Panel panel)
        {
            InitializeComponent();
            panel.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            this.Show();
            /*
            if (video == TypeVideo.YouTube)
            {
                var embed = "<html><head>" +
                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                "</head><body>" +
                "<iframe width=\"700\" height = \"450\" src=\"{0}\"" +
                "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                "</body></html>";
                var url = vlink.Replace("watch?v=", "embed/");
                webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (video == TypeVideo.GoogleDrive)
            {
                //vlink = https://drive.google.com/file/d/1UQu5rXnwpJPirhCIBocszJpX7YCjGDeJ/preview\
                var embed = "<html><head>" +
                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                "</head><body>" +
                "<iframe src=\"https://drive.google.com/file/d/"+vlink+"/view" +"\" width=\"640\" height=\"480\"" +
                " allow=\"autoplay\"></iframe>";
                webBrowser1.DocumentText = string.Format(embed);
            }
            */
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
