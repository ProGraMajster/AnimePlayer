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
    public partial class PageTitileStatusList : UserControl
    {
        public PageTitileStatusList()
        {
            InitializeComponent();
            ControlTitleStatusList ctsl = new ControlTitleStatusList();
            ctsl.Name = "ControlTitleStatusList_1";
            tabPage1.Controls.Add(ctsl);
            ctsl.Show();
            ctsl.Dock = DockStyle.Fill;
            ctsl = new ControlTitleStatusList();
            ctsl.Name = "ControlTitleStatusList_2";
            tabPage2.Controls.Add(ctsl);
            ctsl.Show();
            ctsl.Dock = DockStyle.Fill;
            ctsl = new ControlTitleStatusList();
            ctsl.Name = "ControlTitleStatusList_3";
            tabPage3.Controls.Add(ctsl);
            ctsl.Show();
            ctsl.Dock = DockStyle.Fill;
            ctsl = new ControlTitleStatusList();
            ctsl.Name = "ControlTitleStatusList_4";
            tabPage4.Controls.Add(ctsl);
            ctsl.Show();
            ctsl.Dock = DockStyle.Fill;
            ctsl = new ControlTitleStatusList();
            ctsl.Name = "ControlTitleStatusList_5";
            tabPage5.Controls.Add(ctsl);
            ctsl.Show();
            ctsl.Dock = DockStyle.Fill;
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            GC.Collect();
        }

        private void PageTitileStatusList_Load(object sender, EventArgs e)
        {

        }
    }
}
