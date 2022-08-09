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
    public partial class QuickMovePanel : UserControl
    {
        public QuickMovePanel()
        {
            InitializeComponent();
            CreatePanel();
        }

        void CreatePanel()
        {
            Panel panel = new()
            {
                BackColor=Color.FromArgb(30, 30, 30),
                Name = "ItemQuickMove",
                Size = new Size(50, 50)
            };
            PictureBox pictureBox = new()
            {
                Name = "pBox",
                Size = new Size(50, 40),
                Dock = DockStyle.Fill
            };
            Button button = new()
            {
                Name = "btn",
                Text = "NameSite"
            };
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(button);
            flowLayoutPanel1.Controls.Add(panel);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
