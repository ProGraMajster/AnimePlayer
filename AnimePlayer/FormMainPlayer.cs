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
                var wc = new System.Net.WebClient();
                Image x = Image.FromStream(wc.OpenRead("data:image/jpeg;base64,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"));
                panelStartPage.BackgroundImage = x;
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
            /*profileSelectionPanel = new AnimePlayer.Profile.ProfileSelectionPanel();
            this.Controls.Add(profileSelectionPanel);
            profileSelectionPanel.eventHandler += ProfileSelect_Click;
            profileSelectionPanel.Dock = DockStyle.Fill;
            profileSelectionPanel.Show();
            profileSelectionPanel.BringToFront();*/
        }
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
                //MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    pageTitileStatusList = new PageTitileStatusList
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
                    pageTitileStatusList = new PageTitileStatusList
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
    }
}