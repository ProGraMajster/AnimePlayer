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

namespace AnimePlayer.Updater
{
    public partial class FormUpdater : Form
    {
        public FormUpdater()
        {
            InitializeComponent();
            AnimePlayer.Core.CheckingAppFolders.CheckMainFolder();
            FileStream filestream = new FileStream(AnimePlayer.Class.AppFolders.Logs+"\\"+ Process.GetCurrentProcess().StartTime.ToString().Replace(":", " ") + "_updater.txt", FileMode.Append);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            Console.SetOut(streamwriter);
            Console.SetError(streamwriter);
            if (updaterSettingsPanel1.settingsUpdater.DevChannelUpdate)
            {
                DevChannel.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormUpdater_Load(object sender, EventArgs e)
        {
            timerCheckingForUpdates.Enabled = updaterSettingsPanel1.settingsUpdater.CheckingForUpdatesTimer;
            timerReadSettingsFile.Enabled = updaterSettingsPanel1.settingsUpdater.ReadFileSettingTimer;
            timerCheckingForUpdates.Interval = updaterSettingsPanel1.settingsUpdater.CheckingForUpdatesTimerInterval;
            timerReadSettingsFile.Interval = updaterSettingsPanel1.settingsUpdater.ReadFileSettingsTimerInterval;
            this.Hide();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
