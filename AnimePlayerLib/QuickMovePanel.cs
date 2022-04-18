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
            Panel panel = new Panel();
            panel.BackColor=Color.FromArgb(30,30,30);
            panel.Name = "ItemQuickMove";
            panel.Size = new Size(50, 50);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "pBox";
            pictureBox.Size = new Size(50, 40);
            pictureBox.Dock = DockStyle.Fill;
            Button button = new Button();
            button.Name = "btn";
            button.Text = "NameSite";
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(button);
            flowLayoutPanel1.Controls.Add(panel);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
