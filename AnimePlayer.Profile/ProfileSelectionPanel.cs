using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using AnimePlayer.Core;

namespace AnimePlayer.Profile
{
    public partial class ProfileSelectionPanel : UserControl
    {
        public ProfileSelectionPanel()
        {
            InitializeComponent();
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(buttonCreate, 100);
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(pictureBoxIcon, 100);
            SetLocationChildControl();
            CenterChildControlPanelCreate();
        }

        private void SetLocationChildControl()
        {
            try
            {
                int w = 0;
                foreach (Control c in newFlowLayoutPanel1.Controls)
                {
                    w += c.Width;
                }
                int p = (this.ClientSize.Width-w)/2;
                newFlowLayoutPanel1.Padding = new Padding(p, 0, 0, 0);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void newFlowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            SetLocationChildControl();
        }

        private void newFlowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            SetLocationChildControl();
        }

        private void newFlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            SetLocationChildControl();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            textBoxDescryption.Text = null;
            textBoxHelperQuestion.Text = null;
            textBoxName.Text = null;
            pictureBoxIcon.Image = null;
            maskedTextBoxPassword.Text = null;
            checkBoxPasswordState.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            panelCreate.Show();
            panelCreate.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void LocationSetCenter(Control control)
        {
            control.Location = new((control.Parent.Width- control.Width) / 2, control.Location.Y);
        }

        private void CenterChildControlPanelCreate()
        {
            LocationSetCenter(labelC1);
            LocationSetCenter(labelC2);
            LocationSetCenter(labelC3);
            LocationSetCenter(labelC4);
            LocationSetCenter(labelC5);
            LocationSetCenter(labelC6);
            LocationSetCenter(labelC7);
            LocationSetCenter(pictureBoxIcon);
            LocationSetCenter(buttonSetIcon);
            LocationSetCenter(textBoxName);
            LocationSetCenter(dateTimePicker1);
            LocationSetCenter(groupBox1);
            LocationSetCenter(textBoxDescryption);
            LocationSetCenter(checkBoxPasswordState);
            LocationSetCenter(maskedTextBoxPassword);
            LocationSetCenter(buttonShowPassword);
            LocationSetCenter(textBoxHelperQuestion);
            LocationSetCenter(buttonProfileCreate);
        }

        private void panelCreate_SizeChanged(object sender, EventArgs e)
        {
            CenterChildControlPanelCreate();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelCreate.Hide();
        }

        private void panel3_SizeChanged(object sender, EventArgs e)
        {
            LocationSetCenter(button1);
        }

        private void checkBoxPasswordState_CheckedChanged(object sender, EventArgs e)
        {
            panelPass.Visible = checkBoxPasswordState.Checked;
        }

        private void buttonSetIcon_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new();
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxIcon.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void buttonProfileCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show("Pole tekstowe nie może być puste!");
                    return;
                }
                DirectoryInfo directoryInfo = new DirectoryInfo(AnimePlayer.Class.AppFolders.Profiles);
                foreach (DirectoryInfo childDirectory in directoryInfo.GetDirectories())
                {
                    if(childDirectory.Name.Equals(Replacer.Names(textBoxName.Text)))
                    {
                        return;
                    }
                }

                AnimePlayer.Profile.ProfileClass profileClass = new();
                profileClass.IconProfile = (Bitmap)pictureBoxIcon.Image;
                profileClass.YearOfBirth = dateTimePicker1.Value;
                profileClass.Name = textBoxName.Text;
                profileClass.Description = textBoxDescryption.Text;
                profileClass.PassState = checkBoxPasswordState.Checked;
                if(checkBoxPasswordState.Checked)
                {
                    profileClass.K = Replacer.Names(DateTime.Now.ToString()).Replace(".", "").Replace(" ", "");
                    profileClass.Password = AesOperation.EncryptString(profileClass.K, maskedTextBoxPassword.Text);
                    profileClass.HelperQuestion = textBoxHelperQuestion.Text;
                }
                else
                {
                    profileClass.K = null;
                    profileClass.Password = null;
                    profileClass.HelperQuestion = null;
                }
                string path = AnimePlayer.Class.AppFolders.Profiles + Replacer.Names(textBoxName.Text);
                Directory.CreateDirectory(path);
                SerializationAndDeserialization
                    .Serialization(profileClass, path + "\\profile.dat");

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public void LoadProfiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(AnimePlayer.Class.AppFolders.Profiles);
            foreach (DirectoryInfo childDirectory in directoryInfo.GetDirectories())
            {
                foreach (FileInfo fileInfo in childDirectory.GetFiles())
                {
                    if (fileInfo.FullName.EndsWith(".dat"))
                    {
                        AnimePlayer.Profile.ProfileClass profileClass;
                        profileClass = (ProfileClass)
                            AnimePlayer.Core.SerializationAndDeserialization
                            .Deserialization(fileInfo.FullName);
                        if (profileClass != null)
                        {
                            Panel panel = new Panel();
                            panel.Size = new Size(100, 125);
                            PictureBox pictureBox = new PictureBox();
                            if(profileClass.IconProfile !=null)
                            {
                                pictureBox.Image = profileClass.IconProfile;
                            }
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox.Size = new(100, 100);
                            pictureBox.Dock = DockStyle.Fill;
                            Label label = new Label();
                            label.TextAlign = ContentAlignment.MiddleCenter;
                            label.Text = profileClass.Name;
                            label.Dock = DockStyle.Bottom;
                            panel.Controls.Add(pictureBox);
                            panel.Controls.Add(label);
                            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(pictureBox, 100);
                            newFlowLayoutPanel1.Controls.Add(panel);
                        }
                    }
                }
            }
        }

        private void ProfileSelectionPanel_Load(object sender, EventArgs e)
        {
            try
            {
                if(!Directory.Exists(AnimePlayer.Class.AppFolders.Profiles))
                {
                    Directory.CreateDirectory(AnimePlayer.Class.AppFolders.Profiles);
                }
                LoadProfiles();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
