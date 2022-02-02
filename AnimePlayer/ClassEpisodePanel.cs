using System;
using System.Drawing;
using System.Windows.Forms;
using AnimePlayerLibrary;

namespace AnimePlayer
{
    public class ClassEpisodePanel
    {

        public Panel panelMain;
        public Label labelTitle;
        public Label labelEp;
        public Button button_1080p;
        public Button button_720p;
        public Button button_480p;
        public Button button_360p;
        public Button buttonOtherQuality;
        public int NumberBtn;
        public int numEp;
        string pathFile;
        private Panel panelTopv;
        Form formW;
        WebContent.Skip skipLolcal;

        public ClassEpisodePanel(string text, int ep, int numberQuality, string path, string link, Panel panel, Form form, WebContent.Skip skip)
        {
            skipLolcal = skip;
            formW = form;
            panelTopv = panel;
            pathFile = path;
            string[] zm = link.Split(';');
            panelMain = new Panel();
            panelMain.BackColor = Color.FromArgb(30, 30, 30);
            panelMain.Size = new Size(800, 40);


            labelTitle = new Label();
            labelTitle.Dock = DockStyle.Left;
            labelTitle.Text = text;
            labelTitle.Size = new Size(400, 30);
            //labelTitle.AutoSize = true;
            labelTitle.AutoEllipsis = true;
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;


            labelEp = new Label();
            labelEp.Dock = DockStyle.Left;
            labelEp.BackColor = Color.FromArgb(35, 35, 35);
            labelEp.Text = "Odcinek: " + ep;
            labelEp.Size = new Size(100, 30);
            //labelEp.AutoSize = true;
            labelEp.AutoEllipsis = true;
            labelEp.ForeColor = Color.White;
            labelEp.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            labelEp.TextAlign = ContentAlignment.MiddleLeft;

            button_1080p = new Button();
            button_1080p.Size = new Size(50, 30);
            button_1080p.FlatStyle = FlatStyle.Flat;
            button_1080p.ForeColor = Color.White;
            button_1080p.Dock = DockStyle.Right;
            button_1080p.Text = "1080p";
            button_1080p.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            button_1080p.AutoSize = true;

            button_720p = new Button();
            button_720p.Size = new Size(50, 30);
            button_720p.FlatStyle = FlatStyle.Flat;
            button_720p.ForeColor = Color.White;
            button_720p.Dock = DockStyle.Right;
            button_720p.Text = "720p";
            button_720p.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            button_720p.AutoSize = true;

            button_480p = new Button();
            button_480p.Size = new Size(50, 30);
            button_480p.FlatStyle = FlatStyle.Flat;
            button_480p.ForeColor = Color.White;
            button_480p.Dock = DockStyle.Right;
            button_480p.Text = "480p";
            button_480p.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            button_480p.AutoSize = true;

            button_360p = new Button();
            button_360p.Size = new Size(50, 30);
            button_360p.FlatStyle = FlatStyle.Flat;
            button_360p.ForeColor = Color.White;
            button_360p.Dock = DockStyle.Right;
            button_360p.Text = "360p";
            button_360p.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            button_360p.AutoSize = true;


            buttonOtherQuality = new Button();
            buttonOtherQuality.Size = new Size(50, 30);
            buttonOtherQuality.FlatStyle = FlatStyle.Flat;
            buttonOtherQuality.ForeColor = Color.White;
            buttonOtherQuality.Dock = DockStyle.Right;
            buttonOtherQuality.Text = "Quality";
            buttonOtherQuality.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            buttonOtherQuality.AutoSize = true;

            if(numberQuality == 0)
            {
                buttonOtherQuality.Show();
            }
            else if (numberQuality == 1)
            {
                button_360p.Show();
                button_480p.Hide();
                button_720p.Hide();
                button_1080p.Hide();
            }
            else if (numberQuality == 2)
            {
                button_360p.Show();
                button_480p.Show();
                button_720p.Hide();
                button_1080p.Hide();
            }
            else if (numberQuality == 3)
            {
                button_360p.Show();
                button_480p.Show();
                button_720p.Show();
                button_1080p.Hide();
            }
            else if (numberQuality == 4)
            {
                button_360p.Show();
                button_480p.Show();
                button_720p.Show();
                button_1080p.Show();
            }


            try
            {
                bool end = false;
                int position = 0;
                while (end != true)
                {
                    if (position == zm.Length - 1)
                    {
                        end = true;
                    }

                    if (zm[position] == "1080p")
                    {
                        position++;
                        if (zm[position] != null)
                        {
                            button_1080p.Tag = zm[position];
                        }
                    }
                    else if (zm[position] == "720p")
                    {
                        position++;
                        if (zm[position] != null)
                        {
                            button_720p.Tag = zm[position];
                        }
                    }
                    else if (zm[position] == "480p")
                    {
                        position++;
                        if (zm[position] != null)
                        {
                            button_480p.Tag = zm[position];
                        }
                    }
                    else if (zm[position] == "360p")
                    {
                        position++;
                        if (zm[position] != null)
                        {
                            button_360p.Tag = zm[position];
                        }
                    }

                    position++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            button_1080p.Name = "1080";
            button_720p.Name = "720";
            button_480p.Name = "480";
            button_360p.Name = "360";
            panelMain.Controls.Add(button_1080p);
            panelMain.Controls.Add(button_720p);
            panelMain.Controls.Add(button_480p);
            panelMain.Controls.Add(button_360p);
            panelMain.Controls.Add(labelEp);
            panelMain.Controls.Add(labelTitle);
            button_1080p.Click += Button_Click;
            button_720p.Click += Button_Click;
            button_480p.Click += Button_Click;
            button_360p.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                if (btn.Tag != null)
                {
                    if (btn.Tag.ToString().Contains("www.cda.pl"))
                    {
                        if (btn.Name == "1080")
                        {
                            VideoPlayer videoPlayer = new VideoPlayer(CdaDownloader.GetVideoLink(btn.Tag.ToString(), CdaQuality.p1080), btn.Tag.ToString(), panelTopv, pathFile, formW, skipLolcal);
                        }
                        else if (btn.Name == "720")
                        {
                            VideoPlayer videoPlayer = new VideoPlayer(CdaDownloader.GetVideoLink(btn.Tag.ToString(), CdaQuality.p720), btn.Tag.ToString(), panelTopv, pathFile, formW, skipLolcal);
                        }
                        else if (btn.Name == "480")
                        {
                            VideoPlayer videoPlayer = new VideoPlayer(CdaDownloader.GetVideoLink(btn.Tag.ToString(), CdaQuality.p480), btn.Tag.ToString(), panelTopv, pathFile, formW, skipLolcal);
                        }
                        else if (btn.Name == "360")
                        {
                            VideoPlayer videoPlayer = new VideoPlayer(CdaDownloader.GetVideoLink(btn.Tag.ToString(), CdaQuality.p360), btn.Tag.ToString(), panelTopv, pathFile, formW, skipLolcal);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
