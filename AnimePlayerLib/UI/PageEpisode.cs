using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayerLibrary;
using AnimePlayer.Class;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AnimePlayerLibrary.UI
{
    public partial class PageEpisode : UserControl
    {
        readonly PageItemData _PageItemData;
        int numberEp;
        private List<string> linksToIcon;
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
                Thread thread = new(() =>
                {
                    List<Episode> episodes = ContentManagerLibary.GetEpisode(numberEp, _PageItemData.TitleInformation.Title);
                    if(episodes != null&& episodes.Count > 0)
                    {
                        foreach (var item in episodes)
                        {
                            flowLayoutPanel1.Invoke(() =>
                            {
                                PanelItemEpisode panel = new(item);
                                panel.buttonPlayEpisode.Click += ButtonPlayEpisode_Click;
                                flowLayoutPanel1.Controls.Add(panel);
                            });
                        }
                    }

                    if(flowLayoutPanel1.Controls.Count == 0)
                    {
                        Label label = new()
                        {
                            Text = " Brak dostępnych odcinków... ಥ_ಥ",
                            ForeColor = Color.White,
                            AutoSize = true
                        };
                        label.Font = new(label.Font.FontFamily, 18);
                        flowLayoutPanel1.Invoke(() =>
                        {
                            flowLayoutPanel1.Controls.Add(label);
                        });
                    }
                    else
                    {
                        this.Invoke(() =>
                        {
                            comboBoxSort.SelectedIndex = 0;
                            panelSort.Show();
                            comboBoxSort_Working = true;
                        });
                    }
                });
                thread.Name="Thread_LoadEpisode";
                thread.Start();
                Thread thread2 = new(() =>
                {
                    List<string> strings = ContentManagerLibary.GetLinkToIcon(_PageItemData.TitleInformation.Title);
                    if(strings == null)
                    {
                        return;
                    }
                    linksToIcon = strings;
                    pictureBox1.Invoke(() =>
                    {
                        pictureBox1.ImageLocation = strings[0];
                    });
                });
                thread2.Name = "Thread_LoadIcon";
                thread2.Start();
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
                VideoPlayerWeb videoPlayerWeb = new(episode);
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            panelViewIcon.Size = new Size(this.Size.Width - 200, this.Size.Height - 100);
            panelViewIcon.Left = (this.ClientSize.Width - panelViewIcon.Width) / 2;
            panelViewIcon.Top = (this.ClientSize.Height - panelViewIcon.Height) / 2;

            panelViewIcon.BringToFront();
            panelViewIcon.Show();
            pictureBox2.Image = pictureBox1.Image;
        }

        private void ButtonViewIconClose_Click(object sender, EventArgs e)
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

        private void ButtonBackEp_Click(object sender, EventArgs e)
        {
            if(numberEp==1)
            {
                return;
            }
            PageEpisode pageEpisode = new(_PageItemData, numberEp-=1)
            {
                Dock = DockStyle.Fill
            };
            this.Parent.Controls.Add(pageEpisode);
            pageEpisode.Show();
            pageEpisode.BringToFront();
            this.Dispose();
        }

        private void ButtonForwardEp_Click(object sender, EventArgs e)
        {
            PageEpisode pageEpisode = new(_PageItemData, numberEp+=1)
            {
                Dock = DockStyle.Fill
            };
            this.Parent.Controls.Add(pageEpisode);
            pageEpisode.Show();
            pageEpisode.BringToFront();
            this.Dispose();
        }
            
        bool comboBoxSort_Working = false;

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxSort_Working != true)
                {
                    return;
                }
                labelSortLoading.Show();
                flowLayoutPanel1.Enabled = false;
                comboBoxSort.Enabled = false;
                int index = comboBoxSort.SelectedIndex;
                foreach (var ctn in flowLayoutPanel1.Controls.OfType<PanelItemEpisode>())
                {
                    ctn.Show();
                    if (index == 2)
                    {
                        if (ctn.Episode.Type != "Lektor PL")
                        {
                            ctn.Hide();
                        }
                    }
                    else if (index == 1)
                    {
                        if (ctn.Episode.Type != "Napisy PL")
                        {
                            ctn.Hide();
                        }
                    }
                }
                labelSortLoading.Hide();
                flowLayoutPanel1.Enabled = true;
                comboBoxSort.Enabled = true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
