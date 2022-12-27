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

using Newtonsoft.Json;

using AnimePlayerLibrary;
using AnimePlayerLibrary.UI;
using AnimePlayer.Core;
using AnimePlayer.CNM;
using AnimePlayer.ControlsWinForms;
using AnimePlayer.Class;
using AnimePlayer.Profile;
using AnimePlayer.StatisticsData;

namespace AnimePlayer
{
    public partial class FormMainPlayer : Form
    {
        public Control controlAuxiliary;

        public bool debug = false;
        public bool onOnline = true;
        readonly PanelSearchFilters panelSearch;
        readonly NewFlowLayoutPanel panelNews;
        public AutoCompleteStringCollection autoCSC_find;
        public List<ItemsGroup> itemsGroups = new();
        public bool usedThemeColors = false;
        public string ThemePath = null;
        public ItemList_ClassItemOnStateList iList_ClassItemOnState;
        public PerformanceCounter performanceCounter_app;

        private ProfileClass currentProfile=null;

        int memsize;
        public ZetaIpc.Runtime.Server.IpcServer IpcServerData;
        public ZetaIpc.Runtime.Client.IpcClient clientToBrowser;

        public HelpPage helpPage;

        private FormLoading formLoading;

        public FormMainPlayer()  
        {
            InitializeComponent();
            try
            { 
                formLoading = new FormLoading();
                IpcServerData = new ZetaIpc.Runtime.Server.IpcServer();
                IpcServerData.Start();
                IpcServerData.ReceivedRequest += IpcServerData_ReceivedRequest;
                formLoading.Show();
                autoCSC_find = new AutoCompleteStringCollection();
                panelSearch = new PanelSearchFilters(flowLayoutPanelAll, flowLayoutPanelFinditem)
                {
                    Dock = DockStyle.None
                };
                panelAllitem.Controls.Add(panelSearch);
                panelSearch.Location = new Point(0, 110);
                panelSearch.Hide();
                labelLoadingDetails.Text = "Initialize";

                panelNews = new NewFlowLayoutPanel
                {
                    Name = "newFlowLayoutPanel_panelNews",
                    Dock = DockStyle.Fill
                };
                panelSTNewsMain.Controls.Add(panelNews);
                panelNews.Show();
                panelNews.ControlAdded += PanelNews_ControlAdded;
                panelNews.WrapContents = false;
                panelNews.AutoScroll = true;
                panelSTNewsMain.Hide();

                AnimePlayer.Core.CheckingAppFolders.CheckMainFolder();
                quickMove = new QuickMovePanel();
                quickMove.Hide();   
                this.Controls.Add(quickMove);
                clientToBrowser = new ZetaIpc.Runtime.Client.IpcClient();
                clientToBrowser.Initialize(65500);
                File.WriteAllText("IpcServerData_port.txt", IpcServerData.Port.ToString());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            CreateBackupicon();
            try
            {
                performanceCounter_app = new PerformanceCounter
                {
                    CategoryName = "Process",
                    CounterName = "Working Set - Private",
                    InstanceName = "AnimePlayerPL"
                };
                memsize = Convert.ToInt32(performanceCounter_app.NextValue()) / (int)(1024);
                timerAppPer.Start();
            }
            catch (Exception exPer)
            {
                Console.Error.WriteLine(exPer.ToString());
            }
        }

        private void IpcServerData_ReceivedRequest(object sender, ZetaIpc.Runtime.Server.ReceivedRequestEventArgs e)
        {
            try
            {
                if (e.Request == "get;c;ProfileClass")
                {
                    if (currentProfile != null)
                    {
                        e.Response = Core.SerializationAndDeserialization.SerializationJsonGetString(currentProfile, typeof(ProfileClass));
                    }
                    else
                    {
                        e.Response = "null";
                    }
                }
                else if (e.Request == "get;c;ProfileClass;YearOfBirth")
                {
                    if (currentProfile != null)
                    {
                        e.Response = currentProfile.YearOfBirth.ToString();
                    }
                    else
                    {
                        e.Response = "null";
                    }
                }
                e.Handled = true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void PanelNews_ControlAdded(object sender, ControlEventArgs e)
        {
            panelNews.Show();
            panelSTNewsMain.Show();
            panelStartPage.Controls.SetChildIndex(panelSTNewsMain, 2);
        }

        static Task CreateBackupicon()
        {
            try
            {
                DirectoryInfo directoryInfo = new("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon");

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

        readonly QuickMovePanel quickMove=null;
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
            else if(e.KeyCode == Keys.F1)
            {
                helpPage.Show();
                helpPage.BringToFront();
            }
            else if(e.KeyCode == Keys.F10)
            {
                FormDebug fd = new()
                {
                    form=(Form)this
                };
                fd.Show();
            }
            
            if(debug)
            {
                if (e.KeyCode == Keys.F12)
                {
                    if (panelCommands.Visible == false)
                    {
                        panelCommands.BringToFront();
                        panelCommands.Show();
                    }
                    else
                    {
                        panelCommands.Hide();
                    }
                }
                else if (e.KeyCode == Keys.Tab && e.Control)
                {
                    CenterControlInForm(quickMove);
                    quickMove.BringToFront();
                    quickMove.Show();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                quickMove.Hide();
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
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
                if(arg == "-updated")
                {
                    if(File.Exists(AppFolders.Updater+"update"))
                    {
                        File.Delete(AppFolders.Updater+"update");
                    }
                }
            }

            if(debug)
            {
                labelLoadingDetails.TextChanged += LabelLoadingDetails_TextChanged;
                try
                {
                    FileStream filestream = new(AnimePlayer.Class.AppFolders.Logs+"\\"+ Process.GetCurrentProcess().StartTime.ToString().Replace(":", " ") + "_console_out.txt", FileMode.Append);
                    var streamwriter = new StreamWriter(filestream)
                    {
                        AutoFlush = true
                    };
                    Console.SetOut(streamwriter);
                    Console.SetError(streamwriter);
                }
                catch(Exception exFile)
                {
                    Console.Error.WriteLine(exFile.ToString());
                }
            }
            if (formLoading!=null)
            {
                formLoading.Hide();
                formLoading.Dispose();
            }
            panelLoading.BringToFront();
            CenterControlInForm(labelLoading);
            panelLoading.Show();
            this.Show();
            Console.WriteLine("ContentManager.Initalize...");
            ContentManager.Initalize(this);
            helpPage = new HelpPage();
            helpPage.Dock = DockStyle.Fill;
            panel2.Controls.Add(helpPage);
            helpPage.DelegateLoadContentToForm = ContentManager.LoadContentToForm;
            ContentManager.Start();
            labelLoadingDetails.Text = "Download Files";
           
            //Nie używać aż do ukończenia prac związanych z powiązanymi funkcjami!
            //backgroundWorkerGetSTNews.RunWorkerAsync();

            //textBoxFinditem.AutoCompleteCustomSource = autoCSC_find;
            //textBoxStartPagefinditem.AutoCompleteCustomSource = autoCSC_find;
            panelLoading.Hide();
            this.Show();
            /*FormStatisticData formStatisticData = new FormStatisticData();
            formStatisticData.Show();*/
            //backgroundWorkerLoadItems.RunWorkerAsync();
            profileSelectionPanel = new AnimePlayer.Profile.ProfileSelectionPanel();
            this.Controls.Add(profileSelectionPanel);
            profileSelectionPanel.eventHandler += ProfileSelect_Click;
            profileSelectionPanel.Dock = DockStyle.Fill;
            profileSelectionPanel.Show();
            profileSelectionPanel.BringToFront();
            //managerStatistics = new();
        }
        AnimePlayer.StatisticsData.ManagerStatisticsData managerStatistics;
        AnimePlayer.Profile.ProfileSelectionPanel profileSelectionPanel;

        private void ProfileSelect_Click(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                ProfileClass profileClass = (ProfileClass)control.Tag;
                currentProfile = profileClass;
                profileSelectionPanel.Hide();
                pictureBoxProfileIcon.Image = profileClass.IconProfile;
                AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(pictureBoxProfileIcon, 100);
                ProfileManager.Init(profileClass);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
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
            }
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            RoundedPanel panel = (RoundedPanel)sender;
            panel.Refresh();
        }

        private void ButtonMenuClose_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
        }

        private void ButtonMenuOpen_Click(object sender, EventArgs e)
        {
            panelMenu.Location = new Point(this.ClientSize.Width - panelMenu.Width, 0);
            panelMenu.Size = new Size(panelMenu.Width, this.ClientSize.Height);
            Application.DoEvents();
            panelMenu.Show();
            panelMenu.BringToFront();
        }

        private void LabelLoading_VisibleChanged(object sender, EventArgs e)
        {
            CenterControlInForm(labelLoading);
        }

        private void PanelLoading_VisibleChanged(object sender, EventArgs e)
        {
            CenterControlInForm(labelLoading);
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            PageSettings pageSettings = new(this)
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(pageSettings);
            pageSettings.Show();
            pageSettings.BringToFront();
        }

        private void ButtonPlayer_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            VideoPlayer _ = new();
            panel2.Controls.Add(_);
            _.Dock = DockStyle.Fill;
            _.Show();
            _.BringToFront();
        }

        private void ButtonExitApp_Click(object sender, EventArgs e)
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

        private void TimerAnimationError_Tick(object sender, EventArgs e)
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

        private async void PictureBoxGithub_Click(object sender, EventArgs e)
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

        private async void PictureBoxSite_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    OpenLinks.Start("https://sites.google.com/view/twojeanimepl");
                    //Process.Start("start \"\" https://sites.google.com/view/twojeanimepl");
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private async void ButtonSite_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    OpenLinks.Start("https://sites.google.com/view/twojeanimepl");
                    //Process.Start("start \"\" https://sites.google.com/view/twojeanimepl");
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

        public void FlowLayoutPanelPolecane_ControlAdded(object sender, ControlEventArgs e)
        {
           TaskAddToAllList(e);
        }


        public void FlowLayoutPanelControlAdded(object sender, ControlEventArgs e)
        {
            TaskAddToAllList(e);
        }

        public Task TaskAddToAllList(ControlEventArgs e)
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
                    PanelItem panelItem = (PanelItem)c.Tag;
                    if(panelItem._previewTitleClass.Title== e.Control.Name)
                    {
                        add=false;
                    }
                }
                if(add)
                {
                    PanelItem panelItem = (PanelItem)e.Control.Tag;
                    PanelItem item = new(panelItem._previewTitleClass);
                    flowLayoutPanelAll.Controls.Add(item.panelItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        private void FlowLayoutPanelAll_ControlAdded(object sender, ControlEventArgs e)
        {

        }


        bool flags_findItem = false;

        private void ButtonFindItem_Click(object sender, EventArgs e)
        {
            if(flags_findItem == false)
            {
                flowLayoutPanelFinditem.Controls.Clear();
                flowLayoutPanelFinditem.Enabled = false;
                FindItems();
                flowLayoutPanelFinditem.Enabled = true;
            }
            else
            {
                Console.WriteLine("flags_findItem = true");
            }
        }



        public void FindItemsF()
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
            flowLayoutPanelFinditem.Controls.Clear();
            labelFindSatus.Show();
            flowLayoutPanelAll.Hide();
            try
            {
                labelFindSatus.Text = "Szukanie";
                Application.DoEvents();
                List<string> unList = new();
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
                    bool add = true;
                    PanelItem panelItem = (PanelItem)c.Tag;
                    if (findText != null && findText != "")
                    {
                        if(!panelItem._previewTitleClass.Title.ToLower().Contains(findText.ToLower()))
                        {
                            break;
                        }
                    }
                    foreach (string x in unList)
                    {
                        /*if (cp.values.titleInformation.Species.Contains(x))
                        {
                            add = false;
                        }*/
                    }

                    if(add)
                    {
                        PanelItem pi = new(panelItem._previewTitleClass);
                        flowLayoutPanelFinditem.Controls.Add(pi.panelItem);
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
            if (flowLayoutPanelFinditem.Controls.Count == 0)
            {
                Panel panel = new()
                {
                    Size = new Size(300, 300)
                };
                panel.Show();
                Label label = new()
                {
                    AutoSize = false,
                    AutoEllipsis = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Podana fraza - "+ findText+" - nie została odnaleziona.",
                    Dock = DockStyle.Bottom,
                    ForeColor = Color.White,
                    Size = new Size(300, 100)
                };
                label.Font = new Font(label.Font.FontFamily, 12);
                PictureBox pictureBox = new()
                {
                    ImageLocation =@"https://cdn-icons-png.flaticon.com/512/6134/6134065.png",
                    Size = new Size(200, 200),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                pictureBox.Show();
                pictureBox.Dock = DockStyle.Fill;
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                flowLayoutPanelFinditem.Controls.Add(panel);
            }
        }


        public void FindItems()
        {
            SetInfofilersLabel();
            flags_findItem = true;
            if(panelSearch.use)
            {
                FindItemsF();
                flags_findItem = false;
                return;
            }
            
            Stopwatch stopWatch = new();
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
                            PanelItem panelItem = (PanelItem)c.Tag;
                            if (panelItem._previewTitleClass.Title.ToLower().Contains(findText.ToLower()))
                            {
                                PanelItem item = new(panelItem._previewTitleClass);
                                flowLayoutPanelFinditem.Controls.Add(item.panelItem);
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
            if (flowLayoutPanelFinditem.Controls.Count == 0)
            {
                Panel panel = new()
                {
                    Size = new Size(300, 300)
                };
                panel.Show();
                Label label = new()
                {
                    AutoSize = false,
                    AutoEllipsis = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Podana fraza - "+ findText+" - nie została odnaleziona.",
                    Dock = DockStyle.Bottom,
                    ForeColor = Color.White,
                    Size = new Size(300, 100)
                };
                label.Font = new Font(label.Font.FontFamily, 12);
                PictureBox pictureBox = new()
                {
                    ImageLocation =@"https://cdn-icons-png.flaticon.com/512/6134/6134065.png",
                    Size = new Size(200, 200),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                pictureBox.Show();
                pictureBox.Dock = DockStyle.Fill;
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                flowLayoutPanelFinditem.Controls.Add(panel);
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

        public void FindItems(string findText)
        {
            flags_findItem = true;
            Stopwatch stopWatch = new();
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
                            PanelItem panelItem = (PanelItem)c.Tag;
                            if (panelItem._previewTitleClass.Title.ToLower().Contains(findText.ToLower()))
                            {
                                PanelItem item = new(panelItem._previewTitleClass);
                                flowLayoutPanelFinditem.Controls.Add(item.panelItem);
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
            if(flowLayoutPanelFinditem.Controls.Count == 0)
            {
                Panel panel = new()
                {
                    Size = new Size(300, 300)
                };
                panel.Show();
                Label label = new()
                {
                    AutoSize = false,
                    AutoEllipsis = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Podana fraza - "+ findText+" - nie została odnaleziona.",
                    Dock = DockStyle.Bottom,
                    ForeColor = Color.White,
                    Size = new Size(300, 100)
                };
                label.Font = new Font(label.Font.FontFamily,12);
                PictureBox pictureBox = new()
                {
                    ImageLocation =@"https://cdn-icons-png.flaticon.com/512/6134/6134065.png",
                    Size = new Size(200, 200),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                pictureBox.Show();
                pictureBox.Dock = DockStyle.Fill;
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                flowLayoutPanelFinditem.Controls.Add(panel);
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

        private void ButtonfinditemReset_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFinditem.Controls.Clear();
            flowLayoutPanelFinditem.Hide();
            labelFindSatus.Text = "Szukanie";
            labelFindSatus.Hide();
            flowLayoutPanelAll.Show();
            textBoxFinditem.Text = "";
            GC.Collect();
        }


        private void ButtonFinditemPageClose_Click(object sender, EventArgs e)
        {
            panelAllitem.Hide();
        }

        private void TextBoxFinditem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindItems();
            }
        }

        private void TextBoxSPfinditem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panelAllitem.BringToFront();
                panelAllitem.Show();
                textBoxFinditem.Text = textBoxStartPagefinditem.Text;
                FindItems(textBoxStartPagefinditem.Text);
                textBoxStartPagefinditem.Text = "";
            }
        }

        private void ButtonStartPageFinditem_Click(object sender, EventArgs e)
        {
            panelAllitem.BringToFront();
            panelAllitem.Show();
            textBoxFinditem.Text = textBoxStartPagefinditem.Text;
            FindItems(textBoxStartPagefinditem.Text);
            textBoxStartPagefinditem.Text = "";
        }

        private void ButtonViewFindintems_Click(object sender, EventArgs e)
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

        private void ButtonRestartApp_Click(object sender, EventArgs e)
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

        private void ButtonfinditemF_Click(object sender, EventArgs e)
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

        private void BackgroundWorkerGetSTNews_DoWork(object sender, DoWorkEventArgs e)
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
                if(managerStatistics!=null)
                {
                    managerStatistics.Exit();
                }
                
                //Directory.Delete(DefaultAppDir.Temp, true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        PageTitileStatusList pageTitileStatusList;
        private void ButtonShowTitleStatusList_Click(object sender, EventArgs e)
        {
            try
            {
                panelMenu.Hide();
                if(pageTitileStatusList == null)
                {
                    pageTitileStatusList = new PageTitileStatusList(currentProfile)
                    {
                        Name = "pageTitileStatusList",
                        Dock = DockStyle.Fill
                    };
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

        private void PanelStartPage_ControlAdded(object sender, ControlEventArgs e)
        {
            panelStartPage.Controls.SetChildIndex(panelSTNewsMain, 2);
        }

        private void ButtonMoreBtnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            panelMoreButtons.Show();
            panelMoreButtons.BringToFront();
        }

        private void Button_MoreBtn_Open_Settings_Click(object sender, EventArgs e)
        {
            panelMoreButtons.Hide();
            PageSettings pageSettings = new(this)
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(pageSettings);
            pageSettings.Show();
            pageSettings.BringToFront();
        }

        private void Button2button_MoreBtn_Open_Player_Click(object sender, EventArgs e)
        {
            panelMoreButtons.Hide();
            VideoPlayer _ = new();
            panel2.Controls.Add(_);
            _.Dock = DockStyle.Fill;
            _.Show();
            _.BringToFront();
        }

        private void Button4button2button_MoreBtn_Open_FindItem_Click(object sender, EventArgs e)
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

        private void Button5button2button_MoreBtn_Open_Lists_Click(object sender, EventArgs e)
        {
            try
            {
                panelMoreButtons.Hide();
                if (pageTitileStatusList == null && debug)
                {
                    pageTitileStatusList = new PageTitileStatusList(currentProfile)
                    {
                        Name = "pageTitileStatusList",
                        Dock = DockStyle.Fill
                    };
                    panel2.Controls.Add(pageTitileStatusList);
                    pageTitileStatusList.Show();
                    pageTitileStatusList.BringToFront();
                    pageTitileStatusList.Disposed += PageTitileStatusList_Disposed;
                }
                else
                {
                    MessageBox.Show("Brak dostępu.\n Ta funkcjia nie jest jeszce gotowa!", "Inforamcja");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Button2button_MoreBtn_Open_GitHub_Click(object sender, EventArgs e)
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

        private void Button7button2button_MoreBtn_Open_twojeanimepl_Click(object sender, EventArgs e)
        {
            Exception ex = OpenLinks.Start("https://sites.google.com/view/twojeanimepl");
            if(ex != null)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            GC.Collect();
            GC.KeepAlive(ex);
        }

        private void TimerAppPer_Tick(object sender, EventArgs e)
        {
            memsize = Convert.ToInt32(performanceCounter_app.NextValue()) / (int)(1024);
            labelAppRamUsage.Text = "Wykorzystanie pamięci RAM przez aplikację: " + (memsize / 1024).ToString() + "MB";
        }

        private void ButtonCloseMoreButtons_Click(object sender, EventArgs e)
        {
            panelMoreButtons.Hide();
        }

        private void LabelLoadingDetails_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string path = AnimePlayer.Class.AppFolders.Logs + Process.GetCurrentProcess().StartTime.ToString().Replace(":"," ") + ".txt";
                string text = "[ " + DateTime.Now.ToString().Replace(":", " ")+" ]" + labelLoadingDetails.Text + Environment.NewLine;
                File.AppendAllText(path, text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ButtonAllNewsContnet_Click(object sender, EventArgs e)
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

        private void BackgroundWorkerLoadItems_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.BeginInvoke(new Action(() => {
                    ShowAppMessageBox("Wystąpił błąd podczas odtwarzania bazy danych. Kod błędu: IL01", 350);
                }));
            }
        }

        private void TextBoxCommandInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ConsolePlayer(textBoxCommandInput.Text);
                textBoxCommandInput.Text = "";  
            }
        }

        public void ConsolePlayer(string input)
        {
            if(input.StartsWith("control.show;"))
            {
                try
                {
                    string controlName = input.Split(';')[1];
                    Control control = this.Controls.Find(controlName, true)[0];
                    control.Show();
                }
                catch(Exception ex)
                {
                    Console.Error.WriteLine(ex.ToString());
                }
            }
        }

        private void FormMainPlayer_SizeChanged(object sender, EventArgs e)
        {
            if(quickMove != null && quickMove.Visible)
            {
                CenterControlInForm(quickMove);
            }
        }

        private void ButtonProfile_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxFinditem_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDefined_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            DefinitionsPage definitionsPage = new()
            {
                Name = "definitionsPage",
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(definitionsPage);
            definitionsPage.Show();
            definitionsPage.BringToFront();
        }

        private void ButtonCommunity_Click(object sender, EventArgs e)
        {
            PageCommunity pageCommunity = new()
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(pageCommunity);
            pageCommunity.Show();
            pageCommunity.BringToFront();
        }

        private void ButtonHomePage_Click(object sender, EventArgs e)
        {
            panelStartPage.Show();
            panelStartPage.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja nie dostęona!");
        }

        private void pictureBoxProfileIcon_Paint(object sender, PaintEventArgs e)
        {
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(pictureBoxProfileIcon, 100);
        }

        private void panel2_ControlAdded(object sender, ControlEventArgs e)
        {
           //
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            helpPage.Show();
            helpPage.BringToFront();
        }
        private void comboBoxViewtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxViewtype.SelectedIndex == 0)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*PageWinterEvent2022 pageWinterEvent2022 = new();
            this.Controls.Add(pageWinterEvent2022);
            pageWinterEvent2022.Dock = DockStyle.Fill;
            pageWinterEvent2022.Show();
            pageWinterEvent2022.BringToFront();*/
        }
    }
}