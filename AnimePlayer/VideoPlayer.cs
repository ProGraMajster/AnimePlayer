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
        Form form;
        AxWMPLib.AxWindowsMediaPlayer axwmp;
        public VideoPlayer(string vlink,string olink, Panel panel, string path, Form f, WebContent.Skip skip)
        {
            InitializeComponent();
            axwmp = new AxWMPLib.AxWindowsMediaPlayer();
            axwmp.MouseMoveEvent += axwmp_mouseMoveEvent;
            this.Controls.Add(axwmp);
            axwmp.Dock = DockStyle.Fill;
            form = f;
            pathToFile = path;
            videoLink = vlink;
            orginalLink = olink;
            panel.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            this.Show();
            axwmp.URL = videoLink;
            label1.Text = "Status: Odtwarzanie";
            ShowSkipIntroTime = skip.time_showButton;
            SkipIntro = skip.time_skipIntro;    
            axwmp.Ctlcontrols.pause();
        }

        public VideoPlayer(Panel panel, bool local, Form f)
        {
            InitializeComponent();
            form = f;
            panel.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            this.Show();
            button4.Visible = local;
            axwmp = new AxWMPLib.AxWindowsMediaPlayer();
            axwmp.MouseMoveEvent += axwmp_mouseMoveEvent;
            this.Controls.Add(axwmp);
            axwmp.Dock = DockStyle.Fill;
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            form.Size = sizeform;
            form.FormBorderStyle = FormBorderStyle.Sizable;
            this.Hide();
            this.Dispose();
        }

        bool full = false;

        Size sizeform;

        private void button1_Click(object sender, EventArgs e)
        {
            form.SuspendLayout();
            if (full)
            {
                form.Size = sizeform;
                form.FormBorderStyle = FormBorderStyle.Sizable;
                full = false;
                timer.Start();
                panel1.Show();
                form.ResumeLayout(true);
                return;
            }
            else
            {
                sizeform = form.Size;
                if (form.WindowState == FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                full = true;
                timer.Stop();
                panel1.Hide();
                form.FormBorderStyle = FormBorderStyle.None;
                form.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                form.Location = new Point(0, 0);
                form.ResumeLayout(true);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axwmp.Ctlcontrols.play();
            label1.Text = "Status: Odtwarzanie";
            timer.Start();
            timerShowSkipButton.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axwmp.Ctlcontrols.pause();
            label1.Text = "Status: Wstrzymano";
            timer.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
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

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void timerShowSkipButton_Tick(object sender, EventArgs e)
        {
            if (axwmp.Ctlcontrols.currentPosition == ShowSkipIntroTime)
            {
                buttonSkip.Show();
                timerHidebuttonSkip.Start();
                timerShowSkipButton.Stop();
            }
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            axwmp.Ctlcontrols.currentPosition = SkipIntro;
            buttonSkip.Hide();
        }

        private void timerHidebuttonSkip_Tick(object sender, EventArgs e)
        {
            buttonSkip.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(orginalLink);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Open link");
                Console.WriteLine("> "+ orginalLink);
                Console.WriteLine(ex.ToString());
            }
        }

        private void axwmp_mouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
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
