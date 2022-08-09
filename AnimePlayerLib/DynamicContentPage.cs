using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnimePlayerLibrary
{
    public partial class DynamicContentPage : UserControl
    {
        public string PathToFile;
        public DynamicContentPage(string filename)
        {
            InitializeComponent();
            PathToFile = filename;
            bWLoadContnt.RunWorkerAsync();
        }

        private void BWLoadContnt_DoWork(object sender, DoWorkEventArgs e)
        {
            if (PathToFile == null)
            {
                return;
            }

            if (!File.Exists(PathToFile))
            {
                Console.WriteLine("public static List<ListNews> SetFile(string path) > \n File.Exists(path) > false");
                return ;
            }
            string[] content = File.ReadAllText(PathToFile).Split(';');
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

                    if (content[position] == "ImageAutoSize")
                    {
                        Application.DoEvents();
                        position++;
                        if (content[position] == "Link")
                        {
                            position++;
                            PictureBox pictureBox = new()
                            {
                                ImageLocation = content[position]
                            };
                            position++;
                            pictureBox.Dock = DockStyle.Top;
                            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                            this.Controls.Add(pictureBox);

                            this.Controls.SetChildIndex(pictureBox, 0);
                        }
                    }
                    else if (content[position] == "Label")
                    {
                        Application.DoEvents();
                        Label label = new();
                        position++;
                        if (content[position] == "Text")
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
                                label.ForeColor = Color.White;
                                label.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                this.Controls.Add(label);
                                this.Controls.SetChildIndex(label, 0);
                            }
                        }
                    }
                    else if (content[position] == "LabelTitle")
                    {
                        Application.DoEvents();
                        Label label = new Label();
                        position++;
                        if (content[position] == "Text")
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
                                label.ForeColor = Color.White;
                                label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                this.Controls.Add(label);
                                this.Controls.SetChildIndex(label, 0);
                            }
                        }
                    }
                    else if (content[position] == "ButtonOpenP")
                    {
                        Application.DoEvents();
                        position++;
                        Button button = new Button
                        {
                            ForeColor = Color.White,
                            Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                        };
                        button.Click += ButtonOpenP_Click;
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ButtonOpenP_Click(object sender, EventArgs e)
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
    }
}
