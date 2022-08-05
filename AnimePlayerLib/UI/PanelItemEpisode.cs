using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                labelTitleAndNumber.Text = episode.TitleOfEpisode+ " Odcinek"+episode.NumberEpisode;
                labelType.Text = episode.Type;
                labelAudio.Text = "Audio:"+episode.AudioLanguage;
                labelSubtitle.Text = "Napisy:"+episode.SubtitleLanguage;
                linkLabel1.Text = "Tłumacz:"+episode.TranslationCreator;
                richTextBox1.Text = episode.TranslationCreatorAdditionalInformation;
                buttonPlayEpisode.Tag = episode;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
