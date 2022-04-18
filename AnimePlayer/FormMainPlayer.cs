global using ControlsNewMethods = AnimePlayerLibrary.ControlsNewMethods;
using AnimePlayerLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using ProfileSupportLibrary;

namespace AnimePlayer
{
    public partial class FormMainPlayer : Form
    {
        string[] args = Environment.GetCommandLineArgs();
        public int server = 0;

        public Control controlAuxiliary;
        public WebContentControls.CtnPanel ctnPanelAuxiliary;

        public bool debug = false;
        public bool onOnline = true;
        PanelSearchFilters panelSearch;
        NewFlowLayoutPanel panelNews;
        public AutoCompleteStringCollection autoCSC_find;
        public List<ItemsGroup> itemsGroups = new List<ItemsGroup>();
        public  ThemeChanger themeChanger;
        public ThemeChangerColors tchangerColors;
        public bool usedThemeColors = false;
        public string ThemePath = null;
        public ItemList_ClassItemOnStateList iList_ClassItemOnState;
        public PerformanceCounter performanceCounter_app;

        int memsize;

        public FormMainPlayer()  
        {
            InitializeComponent();
            AP_Lib aP_Lib = new AP_Lib((Form)this);
            try
            {
                tchangerColors = new ThemeChangerColors();
                autoCSC_find = new AutoCompleteStringCollection();
                themeChanger = new ThemeChanger(this, tchangerColors, autoCSC_find);
                panelSearch = new PanelSearchFilters(flowLayoutPanelAll, flowLayoutPanelFinditem, AnimePlayer.Properties.Settings.Default.RoundingControl);
                panelSearch.Dock = DockStyle.None;
                panelAllitem.Controls.Add(panelSearch);
                panelSearch.Location = new Point(0, 110);
                panelSearch.Hide();
                labelLoadingDetails.Text = "Initialize";

                //Do naprawy!!!!!!!!!!!!!!!!!!!!!!!
                panelNews = new NewFlowLayoutPanel();
                panelNews.Name = "newFlowLayoutPanel_panelNews";
                panelNews.Dock = DockStyle.Fill;
                panelSTNewsMain.Controls.Add(panelNews);
                panelNews.Show();
                panelNews.ControlAdded += PanelNews_ControlAdded;
                panelNews.WrapContents = false;
                panelNews.AutoScroll = true;
                panelSTNewsMain.Hide();
                Application.DoEvents();
                if (!Directory.Exists("C:\\ContentLibrarys"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys");
                }
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles");
                }
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp");
                }

                if(!File.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\NoImage.png"))
                {
                    Image img = Properties.Resources.NoImage;
                    img.Save("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\NoImage.png");
                }

                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon");
                }

                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup");
                }

                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page");
                }
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video");
                }
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\DatabaseOftitles"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\DatabaseOftitles");
                }
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Temp"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Temp");
                }
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Items"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Items");
                }
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Web_script"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Web_script");
                }
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Community"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Community");
                }
                quickMove = new QuickMovePanel();
                quickMove.Hide();   
                this.Controls.Add(quickMove);
            }
            catch (Exception)
            {

            }
            CreateBackupicon();
            if (AnimePlayer.Properties.Settings.Default.RoundingControl)
            {
                ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonStartPageFinditem;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonMenuOpen;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = textBoxStartPagefinditem;
                rc.CornerRadius = 15;

                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = textBoxFinditem;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonFindItem;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonfinditemReset;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonFinditemPageClose;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = panelMenu;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonfinditemF;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = labelEnableFiltres;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl
                {
                    TargetControl = buttonSetting,
                    CornerRadius = 15
                };
                rc = new ControlsNewMethods.RoundingControl
                {
                    TargetControl = buttonPlayer,
                    CornerRadius = 15
                };
                rc = new ControlsNewMethods.RoundingControl
                {
                    TargetControl = buttonViewFindintems,
                    CornerRadius = 15
                };
                rc = new ControlsNewMethods.RoundingControl
                {
                    TargetControl = buttonRestartApp,
                    CornerRadius = 15
                };
                rc = new ControlsNewMethods.RoundingControl
                {
                    TargetControl = buttonExitApp,
                    CornerRadius = 15
                };
                rc = new ControlsNewMethods.RoundingControl
                {
                    TargetControl = label2,
                    CornerRadius = 15
                };  
                rc = new ControlsNewMethods.RoundingControl
                {
                    TargetControl = label_InfoText_news,
                    CornerRadius = 15
                };  
            }
            try
            {
                performanceCounter_app = new PerformanceCounter();
                performanceCounter_app.CategoryName = "Process";
                performanceCounter_app.CounterName = "Working Set - Private";
                performanceCounter_app.InstanceName = "AnimePlayerPL";
                memsize = Convert.ToInt32(performanceCounter_app.NextValue()) / (int)(1024);
                timerAppPer.Start();
            }
            catch (Exception exPer)
            {
                FileLog.Write(exPer.ToString());
            }
        }



        private void PanelNews_ControlAdded(object sender, ControlEventArgs e)
        {
            panelNews.Show();
            panelSTNewsMain.Show();
            panelStartPage.Controls.SetChildIndex(panelSTNewsMain, 2);
        }

        Task CreateBackupicon()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon");

                foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                {
                    File.Copy(fileInfo.FullName, "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + fileInfo.Name, true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        QuickMovePanel quickMove=null;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (panelMenu.Visible == false)
                {
                    panelMenu.Location = new Point(this.ClientSize.Width - panelMenu.Width, 0);
                    panelMenu.Size = new Size(panelMenu.Width, this.ClientSize.Height);
                    Application.DoEvents();
                    panelMenu.Show();
                    panelMenu.BringToFront();
                    return;
                }
                else if (panelMenu.Visible == true)
                {
                    panelMenu.Hide();
                    return;
                }
            }
            else if(e.KeyCode == Keys.F12)
            {
                if(panelCommands.Visible == false)
                {
                    panelCommands.BringToFront();
                    panelCommands.Show();
                }
                else
                {
                    panelCommands.Hide();
                }
            }
            else if(e.KeyCode == Keys.Tab && e.Control)
            {
                CenterControlInForm(quickMove);
                quickMove.BringToFront();
                quickMove.Show();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                quickMove.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }


        private void buttonYTlinkClose_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUseYTlink_Click(object sender, EventArgs e)
        {
        }

        private void otwórzZlinkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void buttonCloseWeb_Click(object sender, EventArgs e)
        {
        }

        private void FormMainPlayer_Load(object sender, EventArgs e)
        {
            bool local = false;
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                if (arg == "-local")
                {
                    local = true;
                }
                if (arg =="-offline")
                {
                    onOnline = false;
                }
                if (arg =="-debug")
                {
                    debug = true;
                }
            }

            if(debug)
            {
                if(!Directory.Exists(DefaultAppDir.Logs))
                {
                    Directory.CreateDirectory(DefaultAppDir.Logs);
                }
                labelLoadingDetails.TextChanged += labelLoadingDetails_TextChanged;
                try
                {
                    FileStream filestream = new FileStream(DefaultAppDir.Logs+ Process.GetCurrentProcess().StartTime.ToString().Replace(":", " ") + "_console_out.txt", FileMode.Append);
                    var streamwriter = new StreamWriter(filestream);
                    streamwriter.AutoFlush = true;
                    Console.SetOut(streamwriter);
                    Console.SetError(streamwriter);
                }
                catch(Exception exFile)
                {
                    Console.Error.WriteLine(exFile.ToString());
                }
            }

            if (local == false)
            {
                panelLoading.BringToFront();
                CenterControlInForm(labelLoading);
                panelLoading.Show();
                this.Show();
                Application.DoEvents();
                WebContent.Initialize(this);
            }
            else
            {
                panelLoading.BringToFront();
                CenterControlInForm(labelLoading);
                panelLoading.Show();
                this.Show();
                WebContent.Initialize(this);
                //Interpreter interpreter = new Interpreter(this);
                //interpreter.Local();
            }

            /*
            if(panelNews.Controls.Count <= 0)
            {
                panelSTNewsMain.Hide();
            }
            */

            try
            {
                if (File.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\theme.txt"))
                {
                    labelLoadingDetails.Text = "Ładowanie motywu.";
                    Application.DoEvents();
                    string txt = File.ReadAllLines("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\theme.txt")[0];
                    labelLoadingDetails.Text = "Ładowanie motywu..";
                    Application.DoEvents();
                    themeChanger.LoadThemeFile(txt);
                    labelLoadingDetails.Text = "Ładowanie motywu...";
                    Application.DoEvents();
                    usedThemeColors = true;
                }
            }
            catch (Exception exx)
            {
                Console.WriteLine(exx.ToString());
            }

            labelLoadingDetails.Text = "Download Files";
            backgroundWorkerGetSTNews.RunWorkerAsync();

            textBoxFinditem.AutoCompleteCustomSource = autoCSC_find;
            textBoxStartPagefinditem.AutoCompleteCustomSource = autoCSC_find;
            panelLoading.Hide();
            this.Show();
            backgroundWorkerLoadItems.RunWorkerAsync();
        }

        public void CenterControlInForm(Control control)
        {
            try
            {
                control.Left = (this.ClientSize.Width - control.Width) / 2;
                control.Top = (this.ClientSize.Height - control.Height) / 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine);
                //MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            RoundedPanel panel = (RoundedPanel)sender;
            panel.Refresh();
        }

        private void buttonMenuClose_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
        }

        private void buttonMenuOpen_Click(object sender, EventArgs e)
        {
            panelMenu.Location = new Point(this.ClientSize.Width - panelMenu.Width, 0);
            panelMenu.Size = new Size(panelMenu.Width, this.ClientSize.Height);
            Application.DoEvents();
            panelMenu.Show();
            panelMenu.BringToFront();
        }


        private void labelLoading_VisibleChanged(object sender, EventArgs e)
        {
            CenterControlInForm(labelLoading);
        }

        private void panelLoading_VisibleChanged(object sender, EventArgs e)
        {
            CenterControlInForm(labelLoading);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            PageSettings pageSettings = new PageSettings(this);
            pageSettings.Dock = DockStyle.Fill;
            panel2.Controls.Add(pageSettings);
            pageSettings.Show();
            pageSettings.BringToFront();
        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            VideoPlayer _ = new VideoPlayer(panel2, true, this);
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int timerShow = 20;
        int timer_i = 0;

        public void ShowAppMessageBox(string text, int time)
        {
            timer_i = 0;
            labelError.Text = text;
            timerShow = time;
            timerAnimationError.Start();
        }

        private void timerAnimationError_Tick(object sender, EventArgs e)
        {

            timer_i++;
            panelNotifiError.Show();
            panelNotifiError.BringToFront();
            panelNotifiError.Location = new Point(this.ClientSize.Width - panelNotifiError.Width,
                this.ClientSize.Height - panelNotifiError.Height);
            if (timer_i >= timerShow)
            {
                timer_i = 0;
                timerAnimationError.Stop();
                panelNotifiError.Hide();
            }
        }

        private async void pictureBoxGithub_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    Process.Start("start \"\" https://github.com/ProGraMajster/AnimePlayer");
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private async void pictureBoxSite_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    Process.Start("start \"\" https://sites.google.com/view/twojeanimepl");
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private async void buttonSite_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    Process.Start("start \"\" https://sites.google.com/view/twojeanimepl");
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        FormWindowState LastWindowState = FormWindowState.Normal;
        private void FormMainPlayer_Resize(object sender, EventArgs e)
        {
            if (labelLoading.Visible)
            {
                CenterControlInForm(labelLoading);
            }

            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {
                    if (panelMenu.Visible)
                    {
                        panelMenu.Location = new Point(-100000, -100000);
                        Application.DoEvents();
                        panelMenu.Hide();
                        panelMenu.Location = new Point(this.ClientSize.Width - panelMenu.Width, 0);
                        panelMenu.Size = new Size(panelMenu.Width, this.ClientSize.Height);
                        Application.DoEvents();
                        panelMenu.Show();
                    }
                    // Maximized!
                }
                if (WindowState == FormWindowState.Normal)
                {

                    // Restored!
                }
            }
        }

        private void FormMainPlayer_ResizeBegin(object sender, EventArgs e)
        {
            panelMenu.Location = new Point(-100000, -100000);
            //panel2.SuspendLayout();
        }

        private void FormMainPlayer_ResizeEnd(object sender, EventArgs e)
        {
            if (labelLoading.Visible)
            {
                CenterControlInForm(labelLoading);
            }

            if (panelMenu.Visible)
            {
                panelMenu.Hide();
                Application.DoEvents();
                panelMenu.Location = new Point(this.ClientSize.Width - panelMenu.Width, 0);
                panelMenu.Size = new Size(panelMenu.Width, this.ClientSize.Height);
                Application.DoEvents();
                panelMenu.Show();
            }
            //panel2.ResumeLayout(true);
        }

        public void flowLayoutPanelPolecane_ControlAdded(object sender, ControlEventArgs e)
        {
            taskAddToAllList(e);
        }


        public void flowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            taskAddToAllList(e);
        }

        public Task taskAddToAllList(ControlEventArgs e)
        {
            try
            {
                bool add = true;
                foreach(Control c in flowLayoutPanelAll.Controls)
                {
                    if(c.Tag == null)
                    {
                        add = false;
                    }
                    WebContentControls.CtnPanel ctn = (WebContentControls.CtnPanel)c.Tag;
                    if(ctn.panelItem.Name == e.Control.Name)
                    {
                        add=false;
                    }
                }
                if(add)
                {
                    WebContentControls.CtnPanel panel = (WebContentControls.CtnPanel)e.Control.Tag;
                    flowLayoutPanelAll.Controls.Add(panel.Duplication());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        private void flowLayoutPanelAll_ControlAdded(object sender, ControlEventArgs e)
        {

        }


        bool flags_findItem = false;

        private void buttonFindItem_Click(object sender, EventArgs e)
        {
            if(flags_findItem == false)
            {
                flowLayoutPanelFinditem.Controls.Clear();
                flowLayoutPanelFinditem.Enabled = false;
                findItems();
                flowLayoutPanelFinditem.Enabled = true;
            }
            else
            {
                Console.WriteLine("flags_findItem = true");
            }
        }



        public void findItemsF()
        {
            SetInfofilersLabel();
            string findText = textBoxFinditem.Text.ToLower().Replace("\n", "").Replace("\r", "").Replace("\t", "");
            if (textBoxFinditem.Text == null)
            {
                flowLayoutPanelFinditem.Hide();
                labelFindSatus.Hide();
                labelFindSatus.Text = "";
                flags_findItem = false;
                return;
            }
            int i = 0;
            bool add = true;
            flowLayoutPanelFinditem.Controls.Clear();
            labelFindSatus.Show();
            flowLayoutPanelAll.Hide();
            try
            {
                labelFindSatus.Text = "Szukanie";
                Application.DoEvents();
                List<string> unList = new List<string>();
                List<WebContent.Values> list = new List<WebContent.Values>();
                foreach (CheckBox box in panelSearch.panelAllS.Controls.OfType<CheckBox>())
                {
                    if (box.CheckState == CheckState.Unchecked)
                    {
                        unList.Add(box.Text);
                    }
                }
                labelFindSatus.Text += ".";
                Application.DoEvents();
                foreach (Control c in flowLayoutPanelAll.Controls)
                {
                    labelFindSatus.Text += ".";
                    Application.DoEvents();
                    add = true;
                    WebContentControls.CtnPanel cp = (WebContentControls.CtnPanel)c.Tag;
                    if (findText != null && findText != "")
                    {
                        if(!cp.values.name.ToLower().Contains(findText.ToLower()))
                        {
                            break;
                        }
                    }
                    foreach (string x in unList)
                    {
                        if (cp.values.titleInformation.Species.Contains(x))
                        {
                            add = false;
                        }
                    }

                    if(add)
                    {
                        flowLayoutPanelFinditem.Controls.Add(cp.Duplication());
                        i++;
                    }
                }
            }
            catch (Exception eex)
            {
                Console.WriteLine(eex.ToString());
            }
            textBoxFinditem.Text = findText;
            labelFindSatus.Text = "Znaleziono: " + i;
            Application.DoEvents();
            flowLayoutPanelFinditem.Show();
            flags_findItem = false;
        }


        public void findItems()
        {
            SetInfofilersLabel();
            flags_findItem = true;
            if(panelSearch.use)
            {
                findItemsF();
                flags_findItem = false;
                return;
            }
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string findText = textBoxFinditem.Text.ToLower().Replace("\n", "").Replace("\r", "").Replace("\t", "");
            if (textBoxFinditem.Text == null)
            {
                flowLayoutPanelFinditem.Hide();
                labelFindSatus.Hide();
                labelFindSatus.Text = "";
                flags_findItem = false;
                return;
            }
            int i = 0;
            flowLayoutPanelFinditem.Controls.Clear();
            labelFindSatus.Show();
            flowLayoutPanelAll.Hide();
            try
            {
                labelFindSatus.Text = "Szukanie";
                Application.DoEvents();
                foreach (Control c in flowLayoutPanelAll.Controls)
                {
                    try
                    {
                        labelFindSatus.Text += ".";
                        Application.DoEvents();
                        if (c.Tag != null)
                        {
                            WebContentControls.CtnPanel ctn = (WebContentControls.CtnPanel)c.Tag;
                            if (ctn.values.name.ToLower().Contains(findText.ToLower()))
                            {
                                flowLayoutPanelFinditem.Controls.Add(ctn.Duplication());
                                i++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
                textBoxFinditem.Text = findText;
                labelFindSatus.Text = "Znaleziono: " + i;
                flowLayoutPanelFinditem.Show();
            }
            catch (Exception eex)
            {
                Console.WriteLine(eex.ToString());
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            stopWatch.Reset();
            Console.WriteLine("Loading time: " + elapsedTime);
            flags_findItem = false;
        }

        public List<Control> findItemsRetrunListControl(string findText)
        {
            findText = findText.ToLower().Replace("\n", "").Replace("\r", "").Replace("\t", "");
            List<Control> list = new List<Control>();
            if (findText == null)
            {
                return null;
            }
            try
            {
                foreach (Control c in flowLayoutPanelAll.Controls)
                {
                    try
                    {
                        Application.DoEvents();
                        if (c.Tag != null)
                        {
                            WebContentControls.CtnPanel ctn = (WebContentControls.CtnPanel)c.Tag;
                            if (ctn.values.name.ToLower().Contains(findText.ToLower()))
                            {
                                list.Add(ctn.Duplication());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                return list;
            }
            catch (Exception eex)
            {
                Console.WriteLine(eex.ToString());
                return null;
            }
        }
        
        public void findItems(string findText)
        {
            flags_findItem = true;
            Stopwatch stopWatch = new Stopwatch();
            findText = findText.ToLower().Replace("\n", "").Replace("\r", "").Replace("\t", "");
            if (findText == null)
            {
                flowLayoutPanelFinditem.Hide();
                labelFindSatus.Hide();
                labelFindSatus.Text = "";
                flags_findItem = false;
                return;
            }
            int i = 0;
            flowLayoutPanelFinditem.Controls.Clear();
            Application.DoEvents();
            labelFindSatus.Show();
            flowLayoutPanelAll.Hide();
            try
            {
                labelFindSatus.Text = "Szukanie";
                Application.DoEvents();
                foreach (Control c in flowLayoutPanelAll.Controls)
                {
                    try
                    {
                        labelFindSatus.Text += ".";
                        Application.DoEvents();
                        if (c.Tag != null)
                        {
                            WebContentControls.CtnPanel ctn = (WebContentControls.CtnPanel)c.Tag;
                            if (ctn.values.name.ToLower().Contains(findText.ToLower()))
                            {
                                flowLayoutPanelFinditem.Controls.Add(ctn.Duplication());
                                i++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                labelFindSatus.Text = "Znaleziono: " + i;
                flowLayoutPanelFinditem.Show();
            }
            catch (Exception eex)
            {
                Console.WriteLine(eex.ToString());
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            stopWatch.Reset();
            Console.WriteLine("Loading time: " + elapsedTime);
            flags_findItem = false;
        }

        private void buttonfinditemReset_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFinditem.Controls.Clear();
            flowLayoutPanelFinditem.Hide();
            labelFindSatus.Text = "Szukanie";
            labelFindSatus.Hide();
            flowLayoutPanelAll.Show();
            textBoxFinditem.Text = "";
            GC.Collect();
        }


        private void buttonFinditemPageClose_Click(object sender, EventArgs e)
        {
            panelAllitem.Hide();
        }

        private void textBoxFinditem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findItems();
            }
        }

        private void textBoxSPfinditem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panelAllitem.BringToFront();
                panelAllitem.Show();
                textBoxFinditem.Text = textBoxStartPagefinditem.Text;
                findItems(textBoxStartPagefinditem.Text);
                textBoxStartPagefinditem.Text = "";
            }
        }

        private void buttonStartPageFinditem_Click(object sender, EventArgs e)
        {
            panelAllitem.BringToFront();
            panelAllitem.Show();
            textBoxFinditem.Text = textBoxStartPagefinditem.Text;
            findItems(textBoxStartPagefinditem.Text);
            textBoxStartPagefinditem.Text = "";
        }

        private void buttonViewFindintems_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            flowLayoutPanelFinditem.Controls.Clear();
            flowLayoutPanelFinditem.Hide();
            labelFindSatus.Text = "Szukanie";
            labelFindSatus.Hide();
            flowLayoutPanelAll.Show();
            panelAllitem.BringToFront();
            panelAllitem.Show();
        }

        private void buttonRestartApp_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void SetInfofilersLabel()
        {
            if (panelSearch.use_Species)
            {
                labelEnableFiltres.Show();
            }
            else
            {
                labelEnableFiltres.Hide();
            }
        }

        private void buttonfinditemF_Click(object sender, EventArgs e)
        {
            SetInfofilersLabel();
            if(panelSearch.Visible == true)
            {
                panelSearch.Hide();
                return;
            }
            if(panelSearch.Visible == false)
            {
                panelSearch.Show();
                panelSearch.BringToFront();
                return;
            }
        }

        private void backgroundWorkerGetSTNews_DoWork(object sender, DoWorkEventArgs e)
        {
            
            if(onOnline)
            {
                bool state = DownloadFileNews.DownloadWithGdrive();
                if(state == false)
                {
                    DownloadFileNews.DownloadWithOneDrive();
                }
                InterpreterFileNews.Start(panelNews, DownloadFileNews.GetPathListNews(), panel2);
            }
            else
            {
                InterpreterFileNews.Start(panelNews, DownloadFileNews.GetPathListNews(), panel2);
            }
            if(panelNews.Controls.Count > 0)
            {
                this.Invoke(new Action(() => panelNews.Show()));
            }
            return;
        }

        private void FormMainPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Directory.Delete(DefaultAppDir.Temp, true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        PageTitileStatusList pageTitileStatusList;
        private void buttonShowTitleStatusList_Click(object sender, EventArgs e)
        {
            try
            {
                panelMenu.Hide();
                if(pageTitileStatusList == null)
                {
                    pageTitileStatusList = new PageTitileStatusList();
                    pageTitileStatusList.Name = "pageTitileStatusList";
                    pageTitileStatusList.Dock = DockStyle.Fill;
                    panel2.Controls.Add(pageTitileStatusList);
                    pageTitileStatusList.Show();
                    pageTitileStatusList.BringToFront();
                    pageTitileStatusList.Disposed += PageTitileStatusList_Disposed;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void PageTitileStatusList_Disposed(object sender, EventArgs e)
        {
            pageTitileStatusList = null;
        }

        private void panelStartPage_ControlAdded(object sender, ControlEventArgs e)
        {
            panelStartPage.Controls.SetChildIndex(panelSTNewsMain, 2);
        }

        private void buttonMoreBtnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            panelMoreButtons.Show();
            panelMoreButtons.BringToFront();
        }

        private void button_MoreBtn_Open_Settings_Click(object sender, EventArgs e)
        {
            panelMoreButtons.Hide();
            PageSettings pageSettings = new PageSettings(this);
            pageSettings.Dock = DockStyle.Fill;
            panel2.Controls.Add(pageSettings);
            pageSettings.Show();
            pageSettings.BringToFront();
        }

        private void button2button_MoreBtn_Open_Player_Click(object sender, EventArgs e)
        {
            panelMoreButtons.Hide();
            VideoPlayer _ = new VideoPlayer(panel2, true, this);
        }

        private void button4button2button_MoreBtn_Open_FindItem_Click(object sender, EventArgs e)
        {
            panelMoreButtons.Hide();
            flowLayoutPanelFinditem.Controls.Clear();
            flowLayoutPanelFinditem.Hide();
            labelFindSatus.Text = "Szukanie";
            labelFindSatus.Hide();
            flowLayoutPanelAll.Show();
            panelAllitem.BringToFront();
            panelAllitem.Show();
        }

        private void button5button2button_MoreBtn_Open_Lists_Click(object sender, EventArgs e)
        {
            try
            {
                panelMoreButtons.Hide();
                if (pageTitileStatusList == null)
                {
                    pageTitileStatusList = new PageTitileStatusList();
                    pageTitileStatusList.Name = "pageTitileStatusList";
                    pageTitileStatusList.Dock = DockStyle.Fill;
                    panel2.Controls.Add(pageTitileStatusList);
                    pageTitileStatusList.Show();
                    pageTitileStatusList.BringToFront();
                    pageTitileStatusList.Disposed += PageTitileStatusList_Disposed;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button2button_MoreBtn_Open_GitHub_Click(object sender, EventArgs e)
        {
            try
            {
                OpenLinks.Start("https://github.com/ProGraMajster/AnimePlayer");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd :(", "Error");
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void button7button2button_MoreBtn_Open_twojeanimepl_Click(object sender, EventArgs e)
        {
            Exception ex = OpenLinks.Start("https://sites.google.com/view/twojeanimepl");
            if(ex != null)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            GC.Collect();
            GC.KeepAlive(ex);
        }

        private void timerAppPer_Tick(object sender, EventArgs e)
        {
            memsize = Convert.ToInt32(performanceCounter_app.NextValue()) / (int)(1024);
            labelAppRamUsage.Text = "Wykorzystanie pamięci RAM przez aplikację: " + (memsize / 1024).ToString() + "MB";
        }

        private void buttonCloseMoreButtons_Click(object sender, EventArgs e)
        {
            panelMoreButtons.Hide();
        }

        private void labelLoadingDetails_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string path = DefaultAppDir.Logs + Process.GetCurrentProcess().StartTime.ToString().Replace(":"," ") + ".txt";
                string text = "[ " + DateTime.Now.ToString().Replace(":", " ")+" ]" + labelLoadingDetails.Text + Environment.NewLine;
                File.AppendAllText(path, text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonAllNewsContnet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja nie dostęona!");
            /*
            PanelAllNewsContent panelAllNewsContent = new PanelAllNewsContent();
            panelAllNewsContent.Name = "panelAllNewsContent";
            panel2.Controls.Add(panelAllNewsContent);
            panelAllNewsContent.Dock = DockStyle.Fill;
            panelAllNewsContent.Show();
            panelAllNewsContent.BringToFront();
            */
        }

        private void backgroundWorkerLoadItems_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string[] line = File.ReadAllLines("main.txt");
                if(line.Length > 1)
                {
                    string duri = line[3];
                    string onedrive = null;
                    if (File.Exists(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\" + duri + ".txt"))
                    {
                        Interpreter interpreter = new Interpreter(this);
                        interpreter.AsyncStart(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\" + duri + ".txt");
                    }
                    else
                    {
                        //onedrive = line[5];
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.BeginInvoke(new Action(() => {
                    ShowAppMessageBox("Wystąpił błąd podczas odtwarzania bazy danych. Kod błędu: IL01", 350);
                }));
            }
        }

        private void textBoxCommandInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ConsoleCommands(textBoxCommandInput.Text);
                textBoxCommandInput.Text = "";
            }
        }

        public void ConsoleCommands(string input)
        {
            if(input.StartsWith("videoplayerweb open type youtube;"))
            {
                VideoPlayerWeb videoPlayerWeb = new VideoPlayerWeb(input.Split(';')[1], VideoPlayerWeb.TypeVideo.YouTube, panel2);
                videoPlayerWeb.Name = "videoPlayerWeb";
                videoPlayerWeb.Show();
            }
        }

        private void FormMainPlayer_SizeChanged(object sender, EventArgs e)
        {
            if(quickMove.Visible)
            {
                CenterControlInForm(quickMove);
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {

        }
    }
}