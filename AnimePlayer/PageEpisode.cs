using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayerLibrary;

namespace AnimePlayer
{
    public partial class PageEpisode : UserControl
    {
        public PageEpisode()
        {
            InitializeComponent();
            this.Load += PageEpisode_Load;
            
        }

        private void PageEpisode_Load(object sender, EventArgs e)
        {
            buttonClose.ForeColor = Color.Red;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelViewIcon.Size = new Size(this.Size.Width - 200, this.Size.Height - 100);
            panelViewIcon.Left = (this.ClientSize.Width - panelViewIcon.Width) / 2;
            panelViewIcon.Top = (this.ClientSize.Height - panelViewIcon.Height) / 2;

            panelViewIcon.BringToFront();
            panelViewIcon.Show();
            pictureBox2.Image = pictureBox1.Image;
        }

        private void buttonViewIconClose_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            panelViewIcon.Hide();
        }

        private void PageEpisode_Resize(object sender, EventArgs e)
        {
            if (panelViewIcon.Visible)
            {
                panelViewIcon.Size = new Size(this.Size.Width - 200, this.Size.Height - 100);
                panelViewIcon.Left = (this.ClientSize.Width - panelViewIcon.Width) / 2;
                panelViewIcon.Top = (this.ClientSize.Height - panelViewIcon.Height) / 2;
            }
        }
    }
}
