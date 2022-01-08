using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;
namespace AnimePlayerLibrary
{
    public class AP_Lib
    {
        private Timer timer;
        public Form formMain;
        Panel panelMenu;
        Button buttonUpdate;
        public AP_Lib(Form form)
        {
            formMain = form;
            timer = new Timer();
            try
            {
                timer.Interval = 1000;
                buttonUpdate = new Button();
                panelMenu = (Panel)form.Controls.Find("panelMenu", true)[0];
                buttonUpdate.Size = new System.Drawing.Size(180, 40);
                buttonUpdate.Visible = false;
                panelMenu.Controls.Add(buttonUpdate);
                buttonUpdate.ForeColor = Color.Yellow;
                buttonUpdate.FlatStyle = FlatStyle.Flat;
                buttonUpdate.FlatAppearance.BorderSize = 0;
                buttonUpdate.Dock = DockStyle.Top;
                buttonUpdate.Text = "Zrestartuj by zaktualizować";
                timer.Tick += Timer_Tick;
                buttonUpdate.Click += ButtonUpdate_Click;
                timer.Start();
            }
            catch(Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
                FileLog.Write(ex1.ToString());
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("Update.txt");
                Application.Restart();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                FileLog.Write(ex.ToString());
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("Update.txt"))
                {
                    if(File.ReadAllLines("Update.txt")[0] == "1")
                    {
                        buttonUpdate.Visible = true;
                        timer.Stop();
                    }
                }
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.ToString());
                FileLog.Write(ex.ToString());
            }
        }
    }

    public class ValuesDebug
    {
        public ValuesDebug(string pathToFile)
        {
            path = pathToFile;  
        }

        public ValuesDebug()
        {

        }

        public string path { get; set; }
        public string name { get; set; }
        public string iconLink { get; set; }
        public string iconPath { get; set; }
        public string siteLink { get; set; }
        public string contentId { get; set; }
        public string contentId2 { get; set; }
        public string pathPage { get; set; }
        public string groupName { get; set; }
    }

    public static class Replacer
    {
        public static string Names(string name)
        {
            return name.Replace(":", " ").Replace("?", " ");
        }
    }

    public static class FileLog
    {
        public static void Write(string text)
        {
            try
            {
                Console.WriteLine(text);
                File.AppendAllText("logs.txt", text + Environment.NewLine + Environment.NewLine);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
