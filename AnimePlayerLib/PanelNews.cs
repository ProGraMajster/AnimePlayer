using AnimePlayer.CNM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary
{
    public partial class PanelNews : UserControl
    {
        private string linkContent;
        public string pathToIconFile;
        public Panel panelMain;
        public ListNews ln;
        System.Windows.Forms.Timer timer;
        private bool flag_local = false;

        BackgroundWorker worker;
        public PanelNews(ListNews listNews, Panel panel, bool local = false)
        {
            InitializeComponent();
            panelMain = panel;
            ln = listNews;
            flag_local = local;
            try
            {
                linkContent = listNews.ContentLink;
                if (local==false)
                {
                    worker = new BackgroundWorker();
                    worker.DoWork += Worker_DoWork;
                    worker.RunWorkerAsync();
                }
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = this;
                rc.CornerRadius = 15;
                labelTitle.Text = listNews.Title;
                labelDescription.Text = listNews.Descryption;
                pathToIconFile = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Temp\\" + listNews.ID + ".png";
                if (Download.File(listNews.IconLink,pathToIconFile))
                {
                    pictureBox1.Load(pathToIconFile);
                }
                this.BackgroundImage = pictureBox1.Image;
                timer.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(linkContent, AnimePlayer.Class.AppFolders.Temp + "\\" + ln.ID + "_newspage.txt");
                webClient.Dispose();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == pictureBox1.ErrorImage || pictureBox1.InitialImage == pictureBox1.Image)
                {
                    pictureBox1.Load(pathToIconFile);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                pictureBox1 = null;
                this.BackgroundImage=null;
            }
            timer.Stop();
        }

        private void PanelNews_SizeChanged(object sender, EventArgs e)
        {

        }

        private void item_Click(object sender, EventArgs e)
        {
            NewsPageContent npc = new NewsPageContent(ln, flag_local);
            panelMain.Controls.Add(npc);
            npc.Show();
            npc.BringToFront();
            npc.Dock = DockStyle.Fill;
            Application.DoEvents();
        }
    }
}
