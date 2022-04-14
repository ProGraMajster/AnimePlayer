using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer
{
    public partial class FormStarter : Form
    {
        public FormStarter()
        {
            InitializeComponent();
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panelSettings.Show();
        }

        private void buttonCloseSettings_Click(object sender, EventArgs e)
        {
            panelSettings.Hide();
            panel1.Show();
        }

        private void buttonRunApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            OknoG oknoG = new OknoG();
            oknoG.Show();
        }

        private void buttonCheckUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
