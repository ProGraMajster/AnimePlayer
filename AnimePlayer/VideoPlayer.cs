using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnimePlayer
{
    public partial class VideoPlayer : UserControl
    {
        public string videoLink;
        public string pathToFile;
        public string orginalLink;
        public double ShowSkipIntroTime = double.NaN;
        public double SkipIntro = double.NaN;
        readonly AxWMPLib.AxWindowsMediaPlayer axwmp;
        public VideoPlayer()
        {
            InitializeComponent();
            axwmp = new AxWMPLib.AxWindowsMediaPlayer();
            axwmp.MouseMoveEvent += Axwmp_mouseMoveEvent;
            this.Controls.Add(axwmp);
            axwmp.Dock = DockStyle.Fill;
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            this.Show();
            /*
            label1.Text = "Status: Odtwarzanie";*/
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Size = sizeform;
            this.ParentForm.FormBorderStyle = FormBorderStyle.Sizable;
            this.Hide();
            this.Dispose();
        }

        bool full = false;

        Size sizeform;

        private void Button1_Click(object sender, EventArgs e)
        {
            this.ParentForm.SuspendLayout();
            if (full)
            {
                this.ParentForm.Size = sizeform;
                this.ParentForm.FormBorderStyle = FormBorderStyle.Sizable;
                full = false;
                timer.Start();
                panel1.Show();
                this.ParentForm.ResumeLayout(true);
                return;
            }
            else
            {
                sizeform = this.ParentForm.Size;
                if (this.ParentForm.WindowState == FormWindowState.Maximized)
                {
                    this.ParentForm.WindowState = FormWindowState.Normal;
                }
                full = true;
                timer.Stop();
                panel1.Hide();
                this.ParentForm.FormBorderStyle = FormBorderStyle.None;
                this.ParentForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.ParentForm.Location = new Point(0, 0);
                this.ParentForm.ResumeLayout(true);
                return;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            axwmp.Ctlcontrols.play();
            label1.Text = "Status: Odtwarzanie";
            timer.Start();
            timerShowSkipButton.Start();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            axwmp.Ctlcontrols.pause();
            label1.Text = "Status: Wstrzymano";
            timer.Stop();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(openFileDialog.FileName))
                    {
                        axwmp.URL = openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void TimerShowSkipButton_Tick(object sender, EventArgs e)
        {
            if (axwmp.Ctlcontrols.currentPosition == ShowSkipIntroTime)
            {
                buttonSkip.Show();
                timerHidebuttonSkip.Start();
                timerShowSkipButton.Stop();
            }
        }

        private void ButtonSkip_Click(object sender, EventArgs e)
        {
            axwmp.Ctlcontrols.currentPosition = SkipIntro;
            buttonSkip.Hide();
        }

        private void TimerHidebuttonSkip_Tick(object sender, EventArgs e)
        {
            buttonSkip.Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "PlayerType_0")
            {
                axwmp.uiMode = "none";
            }
            else if (comboBox1.SelectedItem.ToString() == "PlayerType_1")
            {
                axwmp.uiMode = "full";
            }
            else if (comboBox1.SelectedItem.ToString() == "PlayerType_2")
            {
                
            }
        }

        private void VideoPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd.exe /C start \"\" "+orginalLink);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Open link");
                Console.WriteLine("> "+ orginalLink);
                Console.WriteLine(ex.ToString());
            }
        }

        private void Axwmp_mouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            if(full)
            {
                if (e.fY <= 50)
                {
                    panel1.Show();
                }
                else
                {
                    panel1.Hide();
                }
            }
        }
    }
}
