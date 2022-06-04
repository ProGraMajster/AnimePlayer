using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayer.Core;
using AnimePlayer.Class;

namespace AnimePlayer.Updater
{ 
    public partial class UpdaterSettingsPanel : UserControl
    {
        SettingsUpdater settingsUpdater = new SettingsUpdater();
        public UpdaterSettingsPanel()
        {
            InitializeComponent();
            try
            {
                if(!File.Exists(AppFolders.Settings+"settingsUpdater.dat"))
                {
                    SerializationAndDeserialization.Serialization(settingsUpdater, AppFolders.Settings+"settingsUpdater.dat");
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public void ReadSettings()
        {
            settingsUpdater = (SettingsUpdater)SerializationAndDeserialization.Deserialization(AppFolders.Settings+"settingsUpdater.dat");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Math();
        }

        public void Math()
        {
            try
            {
                TimeSpan t = TimeSpan.FromMilliseconds(double.Parse(numericUpDown1.Value.ToString()));
                string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                        t.Hours,
                                        t.Minutes,
                                        t.Seconds,
                                        t.Milliseconds);
                toolTip1.SetToolTip(numericUpDown1, answer);
                toolTip1.SetToolTip(labelUpdateTimerInterval, answer);
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void buttonSaveUpdaterSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
