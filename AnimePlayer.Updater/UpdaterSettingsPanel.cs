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
        public SettingsUpdater settingsUpdater = new SettingsUpdater();
        public UpdaterSettingsPanel()
        {
            InitializeComponent();
            try
            {
                if(!File.Exists(AppFolders.Settings+"settingsUpdater.dat"))
                {
                    SerializationAndDeserialization.Serialization(settingsUpdater, AppFolders.Settings+"settingsUpdater.dat");
                }
                else
                {
                    ReadSettings();
                }
                checkBoxDevVersion.Checked =settingsUpdater.DevChannelUpdate;
                checkBoxUpdateOpenApp.Checked = settingsUpdater.CheckingForUpdates;
                checkBoxBackUpdate.Checked = settingsUpdater.CheckingForUpdatesTimer;
                numericUpDown1.Value = settingsUpdater.CheckingForUpdatesTimerInterval;

                groupBoxMain.Text = "Ustawienia aktualizacji";
            }
            catch (Exception ex)
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
            groupBoxMain.Text = "Ustawienia aktualizacji *(Nie zapisane zmiany)";
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
            try
            {
                settingsUpdater.DevChannelUpdate = checkBoxDevVersion.Checked;
                settingsUpdater.CheckingForUpdates = checkBoxUpdateOpenApp.Checked;
                settingsUpdater.CheckingForUpdatesTimer = checkBoxBackUpdate.Checked;
                settingsUpdater.CheckingForUpdatesTimerInterval = int.Parse(numericUpDown1.Value.ToString());
                SerializationAndDeserialization.Serialization(settingsUpdater, AppFolders.Settings+"settingsUpdater.dat");
                groupBoxMain.Text = "Ustawienia aktualizacji";
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex.ToString());
            }
        }

        private void checkBoxUpdateOpenApp_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMain.Text = "Ustawienia aktualizacji *(Nie zapisane zmiany)";
        }

        private void checkBoxBackUpdate_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMain.Text = "Ustawienia aktualizacji *(Nie zapisane zmiany)";
        }

        private void checkBoxDevVersion_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMain.Text = "Ustawienia aktualizacji *(Nie zapisane zmiany)";
        }

        private void UpdaterSettingsPanel_ForeColorChanged(object sender, EventArgs e)
        {
            groupBoxMain.ForeColor = this.ForeColor;
        }
    }
}
