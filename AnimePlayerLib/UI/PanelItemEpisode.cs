using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AnimePlayer.Class;

namespace AnimePlayerLibrary.UI
{
    public partial class PanelItemEpisode : UserControl
    {
        public PanelItemEpisode(Episode episode)
        {
            InitializeComponent();
            try
            {
                labelTitleAndNumber.Text ="Odcinek: "+episode.NumberEpisode+" | "+ episode.TitleOfEpisode;
                labelType.Text = "Typ:    "+episode.Type;
                labelAudio.Text = "Audio:   "+episode.AudioLanguage;
                labelSubtitle.Text = "Napisy:   "+episode.SubtitleLanguage;
                linkLabel1.Text = "Tłumacz:    "+episode.TranslationCreator;
                linkLabel1.LinkArea = new LinkArea(12, 1000);
                richTextBox1.Text = episode.TranslationCreatorAdditionalInformation;
                buttonPlayEpisode.Tag = episode;

                if(episode.LinkToEpisode.Contains("cda"))
                {
                    labelType.Text+="   | Serwis: CDA";
                }
                else if(episode.LinkToEpisode.Contains("drive.google"))
                {
                    labelType.Text+="   | Serwis: Google";
                }
                else if(episode.LinkToEpisode.Contains("mega"))
                {
                    labelType.Text+="   | Serwis: Mega";
                }
                else if (episode.LinkToEpisode.Contains("sibnet.ru"))
                {
                    labelType.Text += "   | Serwis: Sibnet";
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            AnimePlayer.Core.OpenLinks.Start(e.LinkText);
        }

        private void PanelItemEpisode_Load(object sender, EventArgs e)
        {
            /*try
            {
                var status = new Ping().Send("www.google.com.mx").Status == IPStatus.Success;
                Debug.WriteLine(status.ToString());
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }*/
        }
    }
}
