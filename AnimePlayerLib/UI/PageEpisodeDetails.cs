using AnimePlayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary.UI
{
    public partial class PageEpisodeDetails : UserControl
    {
        public PanelItemEpisode PanelItemEpisode;
        public PageEpisodeDetails(PanelItemEpisode panelItemEpisode)
        {
            InitializeComponent();
            try
            {
                PanelItemEpisode = panelItemEpisode;
                labelTitleAndNumber.Text = "Odcinek: " + PanelItemEpisode.Episode.NumberEpisode + " | " + PanelItemEpisode.Episode.TitleOfEpisode;
                labelType.Text = "Typ:    " + PanelItemEpisode.Episode.Type;
                labelAudio.Text = "Audio:   " + PanelItemEpisode.Episode.AudioLanguage;
                labelSubtitle.Text = "Napisy:   " + PanelItemEpisode.Episode.SubtitleLanguage;
                linkLabel1.Text = "Tłumacz:    " + PanelItemEpisode.Episode.TranslationCreator;
                linkLabel1.LinkArea = new LinkArea(12, 1000);
                richTextBox1.Text = PanelItemEpisode.Episode.TranslationCreatorAdditionalInformation;
                buttonDownloadEpisode.Tag = PanelItemEpisode.Episode;

                if (PanelItemEpisode.Episode.LinkToEpisode.Contains("cda"))
                {
                    labelType.Text += "   | Serwis: CDA";
                    //buttonDownloadEpisode.Visible = true;
                }
                else if (PanelItemEpisode.Episode.LinkToEpisode.Contains("drive.google"))
                {
                    labelType.Text += "   | Serwis: Google";
                }
                else if (PanelItemEpisode.Episode.LinkToEpisode.Contains("mega"))
                {
                    labelType.Text += "   | Serwis: Mega";
                }
                else if (PanelItemEpisode.Episode.LinkToEpisode.Contains("sibnet.ru"))
                {
                    labelType.Text += "   | Serwis: Sibnet";
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void buttonPlayEp_Click(object sender, EventArgs e)
        {
            VideoPlayerWeb videoPlayerWeb = new(PanelItemEpisode.Episode);
            this.Parent.Parent.Controls.Add(videoPlayerWeb);
            videoPlayerWeb.Dock = DockStyle.Fill;
            videoPlayerWeb.Show();
            videoPlayerWeb.BringToFront();
        }

        private void buttonDownloadEpisode_Click(object sender, EventArgs e)
        {

        }
    }
}
