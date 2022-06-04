using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.Updater
{
    public partial class UpdaterSettingsPanel : UserControl
    {
        public UpdaterSettingsPanel()
        {
            InitializeComponent();
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
