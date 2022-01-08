using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary
{
    public partial class NewsPageContent : UserControl
    {
        ListNews news;
        public NewsPageContent(ListNews listnews, bool local=false)
        {
            InitializeComponent();
            try
            {
                news = listnews;
                labelLoadingD.Text = "Loading content";
                Application.DoEvents();
                this.Show();
                SetContentPage();
                ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = button;
                rc.CornerRadius = 15;
                labelLoadingD.Text = "Loaded content";
                Application.DoEvents();
                labelLoadingD.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SetContentPage()
        {
            try
            {
                string path = DefaultAppDir.Temp + "\\" + news.ID + "_newspage.txt";
                if (path == null)
                {
                    return;
                }
                string[] content = File.ReadAllText(path).Split(';');
                int limits = 0;
                for (int i = 0; i < content.Length; i++)
                {
                    limits = i;
                    content[i] = content[i].Replace("\n", "").Replace("\r", "").Replace("\t", "");
                }
                    
                bool end = false;
                int position = 0;
                while (end != true)
                {
                    if (position == limits)
                    {
                        end = true;
                    }

                    if (content[position] == "Image")
                    {
                        labelLoadingD.Text = "Loading content > Adding > Image";
                        Application.DoEvents();
                        position++;
                        if(content[position] =="Link")
                        {
                            position++;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.ImageLocation = content[position];
                            position++;
                            if(content[position]=="Size")
                            {
                                position++;
                                int x = int.Parse(content[position]);
                                position++;
                                pictureBox.Size = new Size(x, int.Parse(content[position]));
                                pictureBox.Dock = DockStyle.Top;
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                this.Controls.Add(pictureBox);

                                this.Controls.SetChildIndex(pictureBox, 0);
                            }
                        }
                    }
                    else if (content[position] == "Label")
                    {
                        labelLoadingD.Text = "Loading content > Adding > Label";
                        Application.DoEvents();
                        Label label = new Label();
                        position++;
                        if(content[position]=="Text")
                        {
                            position++;
                            label.Text = content[position];
                            position++;
                            if (content[position] == "Size")
                            {
                                position++;
                                int x = int.Parse(content[position]);
                                position++;
                                label.Size = new Size(x, int.Parse(content[position]));
                                label.Dock = DockStyle.Top;
                                label.ForeColor= Color.White;
                                label.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                this.Controls.Add(label);
                                this.Controls.SetChildIndex(label, 0);
                            }
                        }
                    }
                    else if (content[position] == "LabelTitle")
                    {
                        labelLoadingD.Text = "Loading content > Adding > LabelTitle";
                        Application.DoEvents();
                        Label label = new Label();
                        position++;
                        if(content[position]=="Text")
                        {
                            position++;
                            label.Text = content[position];
                            position++;
                            if (content[position] == "Size")
                            {
                                position++;
                                int x = int.Parse(content[position]);
                                position++;
                                label.Size = new Size(x, int.Parse(content[position]));
                                label.Dock = DockStyle.Top;
                                label.ForeColor= Color.White;
                                label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                this.Controls.Add(label);
                                this.Controls.SetChildIndex(label, 0);
                            }
                        }
                    }
                    else if (content[position] == "ButtonOpenLink")
                    {
                        labelLoadingD.Text = "Loading content > Adding > ButtonOpenLink";
                        Application.DoEvents();
                        position++;
                        Button button = new Button();
                        button.ForeColor = Color.White;
                        button.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        button.Click += ButtonOpenLink_Click;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 0;
                        button.Tag = content[position];
                        position++;
                        if (content[position] == "Text")
                        {
                            position++;
                            button.Text = content[position];
                            position++;
                            if (content[position] == "Size")
                            {
                                position++;
                                int x = int.Parse(content[position]);
                                position++;
                                button.Size = new Size(x, int.Parse(content[position]));
                                button.Dock = DockStyle.Top;
                                this.Controls.Add(button);
                                this.Controls.SetChildIndex(button, 0);
                            }
                        }
                    }
                    position++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ButtonOpenLink_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                System.Diagnostics.Process.Start(button.Tag.ToString());
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
