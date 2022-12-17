using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.StatisticsData
{
    public partial class FormWebsite : Form
    {
        public FormWebsite()
        {
            InitializeComponent();
        }

        public bool flag_show = false;

        private void FormWebsite_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormWebsite_Shown(object sender, EventArgs e)
        {
            if(!flag_show)
            {
                this.Hide();
            }
        }
    }
}
