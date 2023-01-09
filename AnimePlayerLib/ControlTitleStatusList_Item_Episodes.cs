using AnimePlayer.Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary
{
    public partial class ControlTitleStatusList_Item_Episodes : UserControl
    {
        public bool CheckBoxState = false;
        public EventHandler<EventArgsIE> EpisodeChangeSettings;
        public EpisodeAnimeList episodeAnime;
        public ControlTitleStatusList_Item_Episodes()
        {
            InitializeComponent();
        }

        public class EventArgsIE : EventArgs
        {
            public EpisodeAnimeList EpisodeAnimeList;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
           checkBox.Checked = CheckBoxState;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(EpisodeChangeSettings!= null)
            {
                EpisodeChangeSettings.Invoke(this, new EventArgsIE() { EpisodeAnimeList=episodeAnime});
            }
        }
    }
}
