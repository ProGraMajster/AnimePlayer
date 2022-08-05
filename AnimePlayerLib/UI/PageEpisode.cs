using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayerLibrary;
using AnimePlayer.Class;
using System.Threading;

namespace AnimePlayerLibrary.UI
{
    public partial class PageEpisode : UserControl
    {
        PageItemData _PageItemData;
        int numberEp;
        public PageEpisode(PageItemData pageItemData, int number)
        {
            InitializeComponent();
            this.Load += PageEpisode_Load;
            _PageItemData = pageItemData;
            numberEp = number;
        }

        private void PageEpisode_Load(object sender, EventArgs e)
        {
            if(numberEp > 1)
            {
                buttonBackEp.Show();
            }
            else
            {
                buttonBackEp.Hide();
            }
            if(_PageItemData == null)
            {
                MessageBox.Show("Wystąpił błąd podczas ładwoania zawartości", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (numberEp == int.Parse(_PageItemData.TitleInformation.NumberOfEpisodes))
                {
                    buttonForwardEp.Hide();
                }
                else
                {
                    buttonForwardEp.Show();
                }
            }
            catch(Exception ex1)
            {
                Console.Error.WriteLine("ex1\n"+ex1.ToString());
            }

            try
            {
                labelTitle.Text = _PageItemData.TitleInformation.Title;
                labelEpNumber.Text = "Odcinek "+numberEp.ToString();
                Thread thread = new Thread(() =>
                {
                    foreach (var item in ContentManagerLibary.GetEpisode(numberEp, _PageItemData.TitleInformation.Title))
                    {
                        flowLayoutPanel1.Invoke(() =>
                        {
                            PanelItemEpisode panel = new PanelItemEpisode(item);
                            panel.buttonPlayEpisode.Click +=ButtonPlayEpisode_Click;
                            flowLayoutPanel1.Controls.Add(panel);
                        });
                    }
                });
                thread.Start();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void ButtonPlayEpisode_Click(object sender, EventArgs e)    
        {
            try
            {
                Control control = (Control)sender;
                Episode episode = (Episode)control.Tag;
                VideoPlayerWeb videoPlayerWeb = new VideoPlayerWeb(episode);
                this.Parent.Controls.Add(videoPlayerWeb);
                videoPlayerWeb.Dock = DockStyle.Fill;
                videoPlayerWeb.Show();
                videoPlayerWeb.BringToFront();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
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

        private void buttonBackEp_Click(object sender, EventArgs e)
        {
            if(numberEp==1)
            {
                return;
            }
            PageEpisode pageEpisode = new PageEpisode(_PageItemData, numberEp-=1);
            pageEpisode.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(pageEpisode);
            pageEpisode.Show();
            pageEpisode.BringToFront();
            this.Dispose();
        }

        private void buttonForwardEp_Click(object sender, EventArgs e)
        {
            PageEpisode pageEpisode = new PageEpisode(_PageItemData, numberEp+=1);
            pageEpisode.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(pageEpisode);
            pageEpisode.Show();
            pageEpisode.BringToFront();
            this.Dispose();
        }
    }
}
