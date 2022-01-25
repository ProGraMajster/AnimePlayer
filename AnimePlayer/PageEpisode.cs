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
        private Panel panelvv;
        public string nameTypeEpisode;
        public string pathToFile;
        WebContent.Values values;
        Form formLocla;
        public ThemeChangerColors tChcolors;
        public PageEpisode(string name, string path, WebContent.Values val, Panel panel, Form form, ThemeChangerColors colors=null)
        {
            InitializeComponent();
            if (colors != null)
            {
                tChcolors = colors;
            }
            formLocla = form;
            panelvv = panel;
            values = val;
            nameTypeEpisode = name;
            pathToFile = path;
            this.Load += PageEpisode_Load;
            pictureBox1.ImageLocation = val.iconPath;
            labelTitle.Text = val.name;
            if (colors != null && colors.PageEpisode_BackColor != null && colors.PageEpisode_BackColor2 != null && colors.PageEpisode_ForeColor != null)
            {
                panel1.BackColor = colors.PageEpisode_BackColor;
                panel4.BackColor = colors.PageEpisode_BackColor;
                flowLayoutPanel1.BackColor = colors.PageEpisode_BackColor2;

                panel1.ForeColor = colors.PageEpisode_ForeColor;
                panel4.ForeColor = colors.PageEpisode_ForeColor;
                flowLayoutPanel1.ForeColor = colors.PageEpisode_ForeColor;
            }
        }

        private void PageEpisode_Load(object sender, EventArgs e)
        {
            GetEpisode(pathToFile);
            if (tChcolors != null && tChcolors.PageEpisode_BackColor != null && tChcolors.PageEpisode_BackColor2 != null && tChcolors.PageEpisode_ForeColor != null)
            {
                BackColor = tChcolors.PageEpisode_BackColor;
                panel1.BackColor = tChcolors.PageEpisode_BackColor;
                panel4.BackColor = tChcolors.PageEpisode_BackColor;
                flowLayoutPanel1.BackColor = tChcolors.PageEpisode_BackColor2;

                ForeColor = tChcolors.PageEpisode_ForeColor;
                panel1.ForeColor = tChcolors.PageEpisode_ForeColor;
                panel4.ForeColor = tChcolors.PageEpisode_ForeColor;
                flowLayoutPanel1.ForeColor = tChcolors.PageEpisode_ForeColor;
                labelTitle.ForeColor = tChcolors.PageEpisode_ForeColor;
                label1.ForeColor = tChcolors.PageEpisode_ForeColor;
                buttonClose.ForeColor = tChcolors.PageEpisode_ForeColor;
            }
            buttonClose.ForeColor = Color.Red;
        }

        Task GetEpisode(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Nie udało się załadować zawartości");
                return null;
            }
            string[] content = File.ReadAllText(path).Split(';');
            int limits = 0;
            for (int i = 0; i < content.Length; i++)
            {
                limits = i;
                content[i] = content[i].Replace("\n", "").Replace("\r", "").Replace("\t", "");
            }
            try
            {
                bool end = false;
                int position = 0;
                while (end != true)
                {
                    if (position == limits)
                    {
                        end = true;
                    }

                    if (content[position] == "EpisodeListed")
                    {
                        position++;
                        WebContent.Skip skip = new WebContent.Skip();
                        //Service host file
                        string zm = "[" + content[position] + "] ";
                        position++;
                        zm += content[position] + " | ";
                        position++;
                        zm += content[position] + " ;";
                        position++;
                        zm += content[position];
                        if (zm == nameTypeEpisode)
                        {
                            position++;
                            int ep = int.Parse(content[position]);
                            position++;
                            if (content[position] == "Quality")
                            {
                                position++;
                                int num_btn = int.Parse(content[position]);
                                string ep_link = null;
                                for (int i = 0; i < num_btn; i++)
                                {
                                    position++;
                                    ep_link += content[position] + ";";
                                    position++;
                                    ep_link += content[position] + ";";
                                }
                                position++;
                                int more = 1;
                                if (content[position] == "SkipButton")
                                {
                                    try
                                    {
                                        more++;
                                        position++;
                                        skip.time_showButton = double.Parse(content[position]);
                                        more++;
                                        position++;
                                        skip.time_showButton = double.Parse(content[position]);
                                    }
                                    catch (Exception exParse)
                                    {
                                        Console.WriteLine(exParse.ToString());
                                        position = position - more;
                                    }
                                }
                                else
                                {
                                    position = position - more;
                                }
                                ClassEpisodePanel episodePanel = new ClassEpisodePanel(zm, ep, num_btn, path, ep_link, panelvv, formLocla, skip);
                                flowLayoutPanel1.Controls.Add(episodePanel.panelMain);
                            }
                        }
                    }

                    position++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return null;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
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
