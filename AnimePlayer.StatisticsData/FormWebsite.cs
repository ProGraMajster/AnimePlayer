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

namespace AnimePlayer.StatisticsData
{
    public partial class FormWebsite : Form
    {
        Process ParentProcess;
        public FormWebsite()
        {
            InitializeComponent();
            try
            {
                foreach(string arg in Environment.GetCommandLineArgs())
                {
                    if(arg.StartsWith("-parent_process;"))
                    {
                        string sid = arg.Split(";")[1];
                        int id = int.Parse(sid);
                        ParentProcess = Process.GetProcessById(id);
                        timerParentProcess.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public bool flag_show = false;

        private void FormWebsite_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormWebsite_Shown(object sender, EventArgs e)
        {
            if(!flag_show)
            {
                this.Hide();
            }
        }

        private void timerParentProcess_Tick(object sender, EventArgs e)
        {
            if(ParentProcess.HasExited)
            {
                Environment.Exit(0);
            }
        }
    }
}
