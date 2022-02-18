using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayerLibrary;

namespace AnimePlayer
{
    public static class WebContent
    {
        public static void StartProcesSite(string link)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public class Skip
        {
            public double time_showButton { get; set; }
            public double time_skipIntro { get; set; }
        }

        public class Values
        {
            public Values(string pathToFile)
            {
                path = pathToFile;
                titleInformation = new TitleInformation();
            }
            public Values()
            {
                titleInformation = new TitleInformation();
            }

            public TitleInformation titleInformation;

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

        public static void Initialize(OknoG oknoG)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            oknoG.labelLoadingDetails.Text = "Initialize";
            oknoG.panelLoading.Show();
            Application.DoEvents();
            oknoG.labelLoadingDetails.Text = "DownloadMainFile";
            Application.DoEvents();
            if (downloadMainFile(oknoG) == false)
            {
                //MessageBox.Show("Wystąpił błąd podczas pobierania zawartości!", "Wstąpił błąd", MessageBoxButtons.OK);
                oknoG.labelLoadingDetails.Text = "DownloadMainFile > an error occured";
                oknoG.labelSatusWorkingApp.Text = "Status działania: Ograniczony\nSerwer: Lokalny";
                Application.DoEvents();
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(oknoG.labelSatusWorkingApp, "Ograniczony dostęp do serwera");
                oknoG.ShowAppMessageBox("Error code: DF01", 500);
                oknoG.timerAnimationError.Start();
                Console.WriteLine("--------- Local ----------");
                oknoG.labelLoading.Text += ".";
                oknoG.labelLoadingDetails.Text = "Interpreter > Local";
                Application.DoEvents();
                Interpreter interpreter = new Interpreter(oknoG);
                interpreter.Local();
                oknoG.onOnline = false;
                oknoG.labelLoading.Text += ".";
                Application.DoEvents();
            }
            else
            {
                oknoG.labelLoadingDetails.Text = "DownloadMainFile > successfully downloaded >> openMainFile";
                oknoG.labelLoading.Text += ".";
                Application.DoEvents();
                openMainFile(oknoG);
                oknoG.labelLoading.Text += ".";
                Application.DoEvents();
                oknoG.onOnline = true;
                oknoG.labelSatusWorkingApp.Text = "Status działania: Prawidłowy\nSerwer nr: "+oknoG.server;
            }

            oknoG.panelLoading.Hide();
            oknoG.labelLoading.Text = "Ładowanie...";
            Application.DoEvents();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
            stopWatch.Reset();
            Console.WriteLine("{WebContent.Initialize} Loading time: " + elapsedTime);
        }
        public static void openMainFile(OknoG oknoG)
        {
            string link_duri = null;
            string link_onedrive = null;
            oknoG.labelLoadingDetails.Text = "openMainFile > File.Exists";
            Application.DoEvents();
            if (File.Exists("main.txt"))
            {
                oknoG.labelLoadingDetails.Text = "openMainFile > File.ReadAllLines";
                Application.DoEvents();
                string[] line = File.ReadAllLines("main.txt");
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] != null)
                    {
                        if(line[i] != "Async")
                        {
                            oknoG.labelLoadingDetails.Text = "openMainFile > downloadFile: " + i;
                            Application.DoEvents();
                            if (oknoG.server == 0)
                            {
                                oknoG.labelLoadingDetails.Text = "openMainFile > downloadFile: " + i + " > server:0";
                                Application.DoEvents();
                                downloadFile(line[i]);
                            }
                            else if (oknoG.server == 1)
                            {
                                AnimePlayerLibrary.Download.OneDrive.downloadFile(line[i]);
                                oknoG.labelLoadingDetails.Text = "openMainFile > downloadFile: " + i + " > server:1";
                                Application.DoEvents();
                            }
                        }
                        else
                        {
                            

                            oknoG.labelLoadingDetails.Text = "openMainFile > start async download content";
                            Application.DoEvents();
                            if(line[i + 1] == "dUri")
                            {
                                link_duri = line[i + 2];
                                if (line[i + 3] == "oneDrive")
                                {
                                    link_onedrive = line[i + 4];
                                }
                            }
                            if(oknoG.server == 0)
                            {
                                downloadFile(link_duri);
                            }
                            else
                            {

                            }
                        }
                    }
                }


                oknoG.labelLoadingDetails.Text = "openMainFile > Interpreter > file";
                Application.DoEvents();
                Interpreter interpreter = new Interpreter(oknoG);
                if (oknoG.server == 0)
                {
                    interpreter.Start("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\" + line[0] + ".txt");
                }
                else if (oknoG.server == 1)
                {
                    interpreter.Start("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\" + Download.OneDrive.onedriveUri(line[1]) + ".txt");
                }
            }
        }

        public static bool downloadMainFile(OknoG oknoG)
        {
            try
            {
                try
                {
                    foreach (string a in Environment.GetCommandLineArgs())
                    {
                        if (a == "-local")
                        {
                            return false;
                        }
                        else if(a == "-server_0")
                        {
                            oknoG.server = 0;
                        }
                        else if(a == "-server_1")
                        {
                            oknoG.server = 1;
                        }
                    }
                    Console.WriteLine("downloadMainFile");
                    if (oknoG.server == 0)
                    {
                        Console.WriteLine("server: 0");
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile(dUri(AnimePlayer.Properties.Settings.Default.idMain), "main.txt");
                        webClient.Dispose();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("server: 1");
                        return AnimePlayerLibrary.Download.OneDrive.MainFile();
                    }
                }
                catch(Exception ex0)
                {
                    Console.WriteLine(ex0.ToString());
                    oknoG.server = 1;
                    return AnimePlayerLibrary.Download.OneDrive.MainFile();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static void downloadFile(string id)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(dUri(id), "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\" + id + ".txt");
                webClient.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{ERROR}downloadPage > \n" + id);
                Console.WriteLine(ex.ToString() + Environment.NewLine);
            }
        }

        public static void downloadFile(string id, string path)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(dUri(id), path);
                webClient.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{ERROR}downloadPage > \n id: " + id + "\n path: " + path);
                Console.WriteLine(ex.ToString() + Environment.NewLine);
            }
        }

        public static string downloadPage(string id, string filename)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(dUri(id), "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page\\" + filename + ".txt");
                webClient.Dispose();
                return "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page\\" + filename + ".txt";
            }
            catch (Exception ex)
            {
                Console.WriteLine("{ERROR}downloadPage > \n" + id + "\n" + filename +"\n");
                Console.WriteLine(ex.ToString() + Environment.NewLine);
                return null;
            }
        }


        public static string downloadIcon(string link, string filename)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(link, "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + filename.Replace(":", " ") + ".png");
                webClient.Dispose();
                return "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + filename.Replace(":", " ") + ".png";
            }
            catch (Exception ex)
            {
                Console.WriteLine("--------- downloadIcon ------");
                Console.WriteLine("filename: " + filename);
                Console.WriteLine("{ERROR}downloadPage > \n" + link + "\n" + filename);
                Console.WriteLine(ex.ToString() + Environment.NewLine);
                return null;
            }
        }

        public static string downloadVideoContent(string link, string filename)
        {
            try
            {
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video");
                }
                WebClient webClient = new WebClient();
                webClient.DownloadFile(link, "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + filename + "_list_ep.txt");
                webClient.Dispose();
                return "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + filename + "_list_ep.txt";
            }
            catch (Exception ex)
            {
                Console.WriteLine("{ERROR}downloadPage > \n" + link + "\n" + filename);
                Console.WriteLine(ex.ToString() + Environment.NewLine);
                return null;
            }
        }

        public static string dUri(string id)
        {
            id = "https://drive.google.com/uc?export=download&id=" + id;
            return id;
        }

        public static void SaveToDatabaseOftitles(Values va)
        {
            try
            {
                if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\DatabaseOftitles"))
                {
                    Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\DatabaseOftitles");
                }

                DirectoryInfo directoryInfo = new DirectoryInfo("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\DatabaseOftitles");
                bool add = true;
                foreach (FileInfo fi in directoryInfo.GetFiles())
                {
                    if (va.name + "_item.txt" == fi.Name)
                    {
                        add = false;
                    }
                }
                if (add)
                {
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    public static class WebContentControls
    {


        public class CtnPanel
        {
            public WebContent.Values values;
            public ValuesDebug valuesDebug;
            OknoG oknoG;

            public Panel panelItem;
            public PictureBox pictureBoxItem;
            public Button buttonItem;
            public ContextMenuStrip cms;
            public ToolStripMenuItem menuItem;
            private ThemeChangerColors themeChangerColors;

            public CtnPanel(WebContent.Values va, OknoG okno, ThemeChangerColors _themeChangerColors=null)
            {
                if(_themeChangerColors!=null)
                {
                    themeChangerColors = _themeChangerColors;
                }
                values = va;
                oknoG = okno;
                try
                {
                    okno.autoCSC_find.Add(va.name);
                    valuesDebug = new ValuesDebug();
                    valuesDebug.path = va.path;
                    valuesDebug.name = va.name;
                    valuesDebug.iconLink = va.iconLink;
                    valuesDebug.iconPath = va.iconPath;
                    valuesDebug.siteLink = va.siteLink;
                    valuesDebug.contentId = va.contentId;
                    valuesDebug.contentId2 = va.contentId2;
                    valuesDebug.pathPage = va.pathPage;
                    valuesDebug.groupName = va.groupName;
                    cms = new ContextMenuStrip();
                    cms.Name = "cms";

                    menuItem = new ToolStripMenuItem();
                    menuItem.Text = "DebugInfo";
                    menuItem.Click += MenuItem_Click;
                    cms.Items.Add(menuItem);
                }
                catch(Exception)
                {

                }
                
                // 
                // pictureBoxItem
                // 
                oknoG.labelLoadingDetails.Text = ">> Create CtnPanel file:" +va.path +" > create PictureBox";
                Application.DoEvents();
                pictureBoxItem = new PictureBox();
                pictureBoxItem.ContextMenuStrip = cms;
                this.pictureBoxItem.Dock = System.Windows.Forms.DockStyle.Fill;
                this.pictureBoxItem.Image = global::AnimePlayer.Properties.Resources.NoImage;
                pictureBoxItem.ErrorImage = AnimePlayer.Properties.Resources.NoImage;
                pictureBoxItem.InitialImage = AnimePlayer.Properties.Resources.NoImage;
                this.pictureBoxItem.Location = new System.Drawing.Point(0, 0);
                this.pictureBoxItem.Name = "picżtureBoxItem";
                this.pictureBoxItem.Size = new System.Drawing.Size(160, 199);
                this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxItem.BackgroundImageLayout = ImageLayout.Zoom;
                this.pictureBoxItem.TabIndex = 0;
                this.pictureBoxItem.TabStop = false;
                // 
                // buttonItem
                // 
                oknoG.labelLoadingDetails.Text = ">> Create CtnPanel file:" + va.path + "> create Button";
                Application.DoEvents();
                buttonItem = new Button();
                this.buttonItem.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.buttonItem.Location = new System.Drawing.Point(0, 199);
                this.buttonItem.Name = "buttonItem";
                buttonItem.ForeColor = Color.White;
                buttonItem.AutoSize = true;
                buttonItem.Font = new Font("Comic Sans MS", 9F);
                buttonItem.FlatStyle = FlatStyle.Flat;
                buttonItem.FlatAppearance.BorderSize = 0;
                buttonItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 35, 35);
                this.buttonItem.Size = new System.Drawing.Size(177, 42);
                this.buttonItem.TabIndex = 1;
                this.buttonItem.Text = "Name";
                buttonItem.AutoEllipsis = true;
                this.buttonItem.UseVisualStyleBackColor = true;

                // 
                // panelItem
                // 
                oknoG.labelLoadingDetails.Text = ">> Create CtnPanel file:" + va.path + "> create Panel";
                Application.DoEvents();
                panelItem = new Panel();
                panelItem.Tag = this;
                this.panelItem.Controls.Add(pictureBoxItem);
                this.panelItem.Controls.Add(buttonItem);
                this.panelItem.Location = new System.Drawing.Point(13, 5);
                this.panelItem.Name = values.name;
                this.panelItem.Size = new System.Drawing.Size(160, 240);
                this.panelItem.Font = new Font("Comic Sans MS", 9F);
                panelItem.BackColor = Color.FromArgb(30, 30, 30);
                this.panelItem.TabIndex = 0;
                if (va.groupName.EndsWith("Polecane"))
                {
                    oknoG.labelLoadingDetails.Text = ">> Create CtnPanel file:" + va.path + "> Add to group";
                    Application.DoEvents();
                    okno.flowLayoutPanelPolecane.Controls.Add(panelItem);
                    Application.DoEvents();
                }
                else
                {
                    //FileInfo fi = new FileInfo(va.path);
                    foreach(ItemsGroup ig in okno.itemsGroups)
                    {
                        try
                        {
                            if(ig.groupTitle == values.groupName)
                            {
                                ig.layoutPanel.Controls.Add(panelItem);
                            }
                        }
                        catch (Exception exig)
                        {
                            Console.WriteLine(exig.ToString());
                        }
                    }
                }

                oknoG.labelLoadingDetails.Text = ">> Create CtnPanel file:" + va.path + "> Set name";
                Application.DoEvents();
                SetName();
                oknoG.labelLoadingDetails.Text = ">> Create CtnPanel file:" + va.path + "> Set image";
                Application.DoEvents();
                SetImage();
                buttonItem.Click += ButtonItem_Click;
                pictureBoxItem.Click += ButtonItem_Click;
                if (AnimePlayer.Properties.Settings.Default.RoundingControl)
                {
                    oknoG.labelLoadingDetails.Text = ">> Create CtnPanel > RoundingControl";
                    ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                    rc.TargetControl = buttonItem;
                    rc.CornerRadius = 15;
                    rc = new ControlsNewMethods.RoundingControl();
                    rc.TargetControl = panelItem;
                    rc.CornerRadius = 15;
                }

                if(themeChangerColors != null && okno.usedThemeColors)
                {
                    oknoG.labelLoadingDetails.Text = ">> Create CtnPanel > Set color theme";
                    Application.DoEvents();
                    panelItem.BackColor = themeChangerColors.CtnPanel_MainBackColor;
                    panelItem.BackColor = themeChangerColors.CtnPanel_MainForeColor;
                    buttonItem.BackColor = themeChangerColors.CtnPanel_ButtonBackColor;
                    buttonItem.ForeColor = themeChangerColors.CtnPanel_ButtonForeColor;
                    buttonItem.FlatAppearance.MouseOverBackColor = themeChangerColors.CtnPanel_ButtonMouseOverBackColor;
                    buttonItem.FlatAppearance.MouseDownBackColor = themeChangerColors.CtnPanel_ButtonMouseDownBackColor;
                }

                SetInformation();
                oknoG.labelLoadingDetails.Text = ">> Create CtnPanel > "+va.name+ "> Created";
                Application.DoEvents();
            }

            private void MenuItem_Click(object sender, EventArgs e)
            {
                FormDebug fd = new FormDebug(oknoG,valuesDebug, pictureBoxItem);
                fd.Show();
            }

            private void ButtonItem_Click(object sender, EventArgs e)
            {
                oknoG.labelLoadingDetails.Text = "Click >" + values.name;
                Application.DoEvents();
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                oknoG.panelLoading.BringToFront();
                oknoG.panelLoading.Show();
                Application.DoEvents();
                if (values.pathPage != null)
                {
                    SetPage(values.pathPage);
                }
                else
                {
                    if (oknoG.onOnline == true)
                    {
                        oknoG.labelLoadingDetails.Text = "Click >" + values.name +" > downloadPage";
                        Application.DoEvents();
                        if (oknoG.server == 0)
                        {
                            values.pathPage = WebContent.downloadPage(values.contentId, values.name + "_page");
                        }
                        else if(oknoG.server == 1 )
                        {
                            values.pathPage = Download.OneDrive.downloadPage(values.contentId2, values.name + "_page");
                        }

                        if(values.pathPage == null)
                        {
                            if(Interpreter.FindFileNameInDirPage(values.name + "_page.txt"))
                            {
                                values.pathPage = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page\\" + values.name + "_page.txt";
                            }
                        }

                        if (values.pathPage != null)
                        {
                            SetPage(values.pathPage);
                        }
                        else
                        {
                            oknoG.labelLoadingDetails.Text = "Click >" + values.name + " > donloadPage > Error";
                            Application.DoEvents();
                            MessageBox.Show("Nie udało się załadować strony!", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        oknoG.labelLoadingDetails.Text = "Click >" + values.name + " > load local";
                        Application.DoEvents();
                        SetPage("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page\\" + values.name + "_page.txt");
                    }
                }
                oknoG.panelLoading.Hide();
                Application.DoEvents();
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                stopWatch.Reset();
                Console.WriteLine("{CtnPanel} Loading page time: " + elapsedTime);
            }

            public void SetName()
            {
                buttonItem.Text = values.name;
            }

            public void SetImage()
            {
                try
                {
                    SetImage2(pictureBoxItem);
                    /*
                    pictureBoxItem.Tag = values.iconPath;
                    pictureBoxItem.ImageLocation = values.iconPath;
                    pictureBoxItem.LoadAsync(values.iconPath);
                    */
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString() + Environment.NewLine);
                }
            }
            
            public void SetImage2(PictureBox box)
            {
                string nam = values.name.Replace(":","");
                Interpreter interpreter = new Interpreter(oknoG);
                try
                {
                    if(interpreter.FindFileNameInDirIcon(nam + "_icon.png"))
                    {
                        box.Tag = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + nam + "_icon.png";
                        //box.ImageLocation = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + nam + "_icon.png";
                        box.LoadAsync("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + nam + "_icon.png");
                    }
                    else
                    {
                        box.Tag = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + nam + "_icon.png";
                        //box.ImageLocation = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + nam + "_icon.png";
                        box.LoadAsync("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + nam + "_icon.png");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString() + Environment.NewLine);
                    try
                    {   
                        box.Tag = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + nam + "_icon.png";box.ImageLocation = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + nam + "_icon.png";
                        box.LoadAsync("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + nam + "_icon.png");
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine(ex2.ToString() + Environment.NewLine);
                        box.Image = AnimePlayer.Properties.Resources.NoImage;
                    }
                }
            }

            public void SetInformation()
            {
                string path = values.pathPage;
                if (path == null)
                {
                    return;
                }
                string[] content = File.ReadAllText(path).Split(';');
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

                        if (content[position] == "Content")
                        {
                            position++;
                            values.titleInformation.Title = values.name;
                        }
                        else if (content[position] == "description")
                        {
                            position++;
                            values.titleInformation.Description = content[position];
                        }
                        else if (content[position] == "OtherName")
                        {
                            position++;
                            values.titleInformation.OtherTitle = content[position].Split(',');
                        }
                        else if (content[position] == "OtherTags")
                        {
                            position++;
                            values.titleInformation.OtherTags = content[position].Split(',');
                        }
                        else if (content[position] == "Archetype")
                        {
                            position++;
                            values.titleInformation.Archetype = content[position];
                        }
                        else if (content[position] == "Species")
                        {
                            try
                            {
                                position++;
                                values.titleInformation.Species = content[position].Split(',');
                                if (values.titleInformation.Species != null && values.titleInformation.Species.Length != 0)
                                {
                                    for (int i = 0; i >= values.titleInformation.Species.Length; i++)
                                    {
                                        values.titleInformation.Species[i] = values.titleInformation.Species[i].TrimStart(' ');
                                    }
                                }
                            }
                            catch(Exception exSpe)
                            {
                                Console.WriteLine(exSpe.ToString());
                            }
                        }
                        else if (content[position] == "typesOfCharacters")
                        {
                            position++;
                            values.titleInformation.TypesOfCharacters = content[position].Split(',');
                        }
                        else if (content[position] == "TargetGroups")
                        {
                            position++;
                            values.titleInformation.TargetGroups = content[position];
                        }
                        else if (content[position] == "PlaceAndTime")
                        {
                            position++;
                            values.titleInformation.PlaceAndTime = content[position].Split(',');
                        }
                        else if (content[position] == "Type")
                        {
                            position++;
                            values.titleInformation.Type = content[position];
                        }
                        else if (content[position] == "Status")
                        {
                            position++;
                            values.titleInformation.Status = content[position];
                        }
                        else if (content[position] == "DateOfIssue")
                        {
                            position++;
                            values.titleInformation.DateOfIssue = content[position];
                        }
                        else if (content[position] == "EndOfIssue")
                        {
                            position++;
                            values.titleInformation.EndOfIssue = content[position];
                        }
                        else if (content[position] == "NumberOfEpisodes")
                        {
                            position++;
                            values.titleInformation.NumberOfEpisodes = content[position];
                        }
                        else if (content[position] == "Studio")
                        {
                            position++;
                            values.titleInformation.Studio = content[position].Split(',');
                        }
                        else if (content[position] == "EpisodeLength")
                        {
                            position++;
                            values.titleInformation.EpisodeLength = content[position];
                        }
                        else if (content[position] == "MPAA")
                        {
                            position++;
                            values.titleInformation.MPAA = content[position];
                        }
                        position++;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Start>\n" + path);
                    Console.WriteLine(ex.ToString());
                }
            }

            public Panel Duplication()
            {
                // 
                // picture
                // 
                PictureBox picture = new PictureBox();
                picture.Dock = System.Windows.Forms.DockStyle.Fill;
                picture.Image = global::AnimePlayer.Properties.Resources.NoImage;
                picture.ErrorImage = AnimePlayer.Properties.Resources.NoImage;
                picture.InitialImage = AnimePlayer.Properties.Resources.NoImage;
                picture.Location = new System.Drawing.Point(0, 0);
                picture.Name = "pictureBoxItem";
                picture.Size = new System.Drawing.Size(160, 199);
                picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                picture.BackgroundImageLayout = ImageLayout.Zoom;
                picture.TabIndex = 0;
                // 
                // button
                // 
                Button button = new Button();
                button.Dock = System.Windows.Forms.DockStyle.Bottom;
                button.Location = new System.Drawing.Point(0, 199);
                button.Name = "buttonItem";
                button.ForeColor = Color.White;
                button.AutoSize = true;
                button.Font = new Font("Comic Sans MS", 9F);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 35, 35);
                button.Size = new System.Drawing.Size(177, 42);
                button.TabIndex = 1;
                button.Text = "Name";
                button.AutoEllipsis = true;
                button.UseVisualStyleBackColor = true;

                // 
                // panel
                // 
                Panel panel = new Panel();
                panel.Tag = this;
                panel.Controls.Add(picture);
                panel.Controls.Add(button);
                panel.Location = new System.Drawing.Point(13, 5);
                panel.Name = values.name;
                panel.Size = new System.Drawing.Size(160, 240);
                panel.BackColor = Color.FromArgb(30, 30, 30);
                panel.Font = new Font("Comic Sans MS", 9F);
                button.Click += ButtonItem_Click;
                picture.Click += ButtonItem_Click;
                try
                {
                    button.Text = values.name;
                    SetImage2(picture);
                    /*
                    picture.ImageLocation = values.iconPath;
                    picture.LoadAsync(values.iconPath);
                    */
                    if (AnimePlayer.Properties.Settings.Default.RoundingControl)
                    {
                        ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                        rc.TargetControl = button;
                        rc.CornerRadius = 15;
                        rc = new ControlsNewMethods.RoundingControl();
                        rc.TargetControl = panel;
                        rc.CornerRadius = 15;
                    }

                    if (themeChangerColors != null && oknoG.usedThemeColors)
                    {
                        panel.BackColor = themeChangerColors.CtnPanel_MainBackColor;
                        panel.BackColor = themeChangerColors.CtnPanel_MainForeColor;
                        button.BackColor = themeChangerColors.CtnPanel_ButtonBackColor;
                        button.ForeColor = themeChangerColors.CtnPanel_ButtonForeColor;
                        button.FlatAppearance.MouseOverBackColor = themeChangerColors.CtnPanel_ButtonMouseOverBackColor;
                        button.FlatAppearance.MouseDownBackColor = themeChangerColors.CtnPanel_ButtonMouseDownBackColor;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return panel;
            }

            public void SetPage(string path)
            {
                oknoG.labelLoadingDetails.Text = "Load page: " + values.name + " [0%]";
                Application.DoEvents();
                if (!File.Exists(path))
                {
                    oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> file not found";
                    Application.DoEvents();
                    MessageBox.Show("Wystąpił błąd podczas ładowania zawartości!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                oknoG.labelLoadingDetails.Text = "Load page: " + values.name + " [1%]";
                Application.DoEvents();
                PageItem pageItem1 = new PageItem(values, oknoG);
                oknoG.labelLoadingDetails.Text = "Load page: " + values.name + " [10%]";
                Application.DoEvents();
                oknoG.panel2.Controls.Add(pageItem1);
                pageItem1.Dock = DockStyle.Fill;
                pageItem1.BringToFront();
                try
                {
                    #if DEBUG
                    Console.WriteLine(values.iconPath);
                    #endif
                    pageItem1.pictureBoxIcon.ImageLocation =  values.iconPath;
                }
                catch (Exception ex)
                {
                    pageItem1.pictureBoxIcon.Image = null;
                    Console.WriteLine(ex.ToString() + Environment.NewLine);
                }

                oknoG.labelLoadingDetails.Text = "Load page: " + values.name + " [15%]";
                Application.DoEvents();

                string[] content = File.ReadAllText(path).Split(';');
                int limits = 0;
                for (int i = 0; i < content.Length; i++)
                {
                    limits = i;
                    content[i] = content[i].Replace("\n", "").Replace("\r", "").Replace("\t", "");
                }
                oknoG.labelLoadingDetails.Text = "Load page: " + values.name + " [20%]";
                Application.DoEvents();
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

                        if (content[position] == "Content")
                        {
                            pageItem1.labelTitle.Text = values.name;
                        }
                        else if (content[position] == "description")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > description";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelDes.Text = content[position];
                        }
                        else if (content[position] == "OtherName")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > OtherName";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelotherTitle.Text = content[position];
                        }
                        else if (content[position] == "OtherTags")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > OtherTags";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelOtherTags.Text = content[position];
                        }
                        else if (content[position] == "Archetype")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > Archetype";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelArchetype.Text = content[position];
                        }
                        else if (content[position] == "Species")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > Species";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelSpecies.Text = content[position];
                        }
                        else if (content[position] == "typesOfCharacters")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > typesOfCharacters";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelTypesOfCharacters.Text = content[position];
                        }
                        else if (content[position] == "TargetGroups")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > TargetGroups";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelTargetGroups.Text = content[position];
                        }
                        else if (content[position] == "PlaceAndTime")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > PlaceAndTime";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelPlaceAndTime.Text = content[position];
                        }
                        else if (content[position] == "Type")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > Type";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelType.Text = content[position];
                        }
                        else if (content[position] == "Status")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > Status";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelStatus.Text = content[position];
                        }
                        else if (content[position] == "DateOfIssue")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > DateOfIssue";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelDateS.Text = content[position];
                        }
                        else if (content[position] == "EndOfIssue")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > EndOfIssue";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelDateE.Text = content[position];
                        }
                        else if (content[position] == "NumberOfEpisodes")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > NumberOfEpisodes";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelNE.Text = content[position];
                        }
                        else if (content[position] == "Studio")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > Studio";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelStudio.Text = content[position];
                        }
                        else if (content[position] == "EpisodeLength")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > EpisodeLength";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelLE.Text = content[position];
                        }
                        else if (content[position] == "MPAA")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > MPAA";
                            Application.DoEvents();
                            position++;
                            pageItem1.labelMPAA.Text = content[position];
                        }
                        else if (content[position] == "EpisodeList")
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > episode list";
                            Application.DoEvents();
                            position++;
                            if (oknoG.onOnline)
                            {
                                if(oknoG.server == 0)
                                {
                                    string zm = WebContent.downloadVideoContent(WebContent.dUri(content[position]), values.name);
                                    GetListTypeEp(pageItem1, zm);
                                }
                                else if(oknoG.server == 1)
                                {
                                    string zm = Download.OneDrive.downloadVideoContent(content[position], values.name);
                                    GetListTypeEp(pageItem1, zm);
                                }
                            }
                            else
                            {
                                GetListTypeEp(pageItem1, "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + values.name + "_list_ep.txt");
                            }
                        }
                        else if (content[position] == "LinkToScriptComment")//LinkToScriptComment
                        {
                            oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > LinkToScriptComment";
                            Application.DoEvents();
                            position++;
                            try
                            {
                                if(AnimePlayerLibrary.Download.File(pageItem1.linkToScriptComment = content[position],
                                    DefaultAppDir.Web_script + Replacer.Names(values.name) + "_script_comments.html"))
                                {
                                    pageItem1.button_Load_Comments.Visible = true;
                                }
                                else
                                {
                                    oknoG.ShowAppMessageBox("Wystąpił błąd podczas wstępnego ładowania komentarzy", 400);
                                }
                            }
                            catch (Exception exDwonScrCom)
                            {
                                Console.WriteLine(exDwonScrCom.ToString());
                            }
                        }
                        else if(content[position] == "RelatedSeries")
                        {
                            position++;
                            string typetitles = content[position];
                            position++;
                            string findname = content[position];
                            try
                            {
                                foreach (Control c in oknoG.flowLayoutPanelAll.Controls)
                                {
                                    try
                                    {
                                        Application.DoEvents();
                                        if (c.Tag != null)
                                        {
                                            WebContentControls.CtnPanel ctn = (WebContentControls.CtnPanel)c.Tag;
                                            if (ctn.values.name.ToLower() == findname.ToLower())
                                            {
                                                Panel p = ctn.Duplication();
                                                if(p != null)
                                                {
                                                    PanelRelatedSeries _ = new PanelRelatedSeries(pageItem1.flowLayoutPanelRelatedSeries, p,
                                                        (TypeRelatedSeries)int.Parse(typetitles));
                                                }
                                                else
                                                {
                                                    p.Dispose();
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.ToString());
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                        position++;
                    }

                    if(pageItem1.flowLayoutPanelRelatedSeries.Controls.Count == 0)
                    {
                        Label label = new Label();
                        label.Size = new Size(160, 25);
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Text = "Brak powiązanych serii.";
                        label.BackColor = Color.FromArgb(35,35,35);
                        label.ForeColor = Color.White;
                        label.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                        pageItem1.flowLayoutPanelRelatedSeries.Controls.Add(label);
                        pageItem1.panelRelatedSeries.Size = new Size(pageItem1.flowLayoutPanelRelatedSeries.Size.Width,
                            105);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Start>\n" + path);
                    Console.WriteLine(ex.ToString());
                    oknoG.panelLoading.Hide();
                }
                oknoG.labelLoadingDetails.Text = "Load page: " + values.name + " [100%]";
                Application.DoEvents();
            }

            Task GetListTypeEp(PageItem pageItem, string path)
            {
                oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > episode list";
                Application.DoEvents();
                if (!File.Exists(path))
                {
                    pageItem.listBoxEpType.Items.Add("Brak odcinków");
                    return null;
                }
                string[] content = File.ReadAllText(path).Split(';');
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

                        if (content[position] == "EpisodeListed")
                        {
                            position++;
                            string zm = "[" + content[position] + "] ";
                            position++;
                            zm += content[position] + " | ";
                            position++;
                            zm += content[position] + " ;";
                            position++;
                            zm += content[position];
                            // Find the item in the list and store the index to the item.
                            int index = pageItem.listBoxEpType.FindStringExact(zm);
                            // Determine if a valid index is returned. Select the item if it is valid.
                            if (index == ListBox.NoMatches)
                            {
                                oknoG.labelLoadingDetails.Text = "Load page: " + values.name + "> load > episode list > "+zm;
                                pageItem.listBoxEpType.Items.Add(zm);
                                Button btn = new Button();
                                btn.Name = "ButtonEpType";
                                btn.Text = zm.Split(';')[0];
                                btn.Tag = zm;
                                btn.FlatAppearance.BorderSize = 0;
                                btn.FlatStyle = FlatStyle.Flat;
                                btn.BackColor = Color.FromArgb(38, 38, 38);
                                btn.ForeColor = Color.White;
                                btn.AutoSize = true;
                                pageItem.flowLayoutPanelEpType.Controls.Add(btn);
                                btn.Click += pageItem.buttonEpType_Click;
                            }
                        }

                        position++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    pageItem.listBoxEpType.Items.Add("Error: FLI02");
                    return null;
                }

                return null;
            }
        }
    }

    //Watch out the spaghetti code!
    public class Interpreter
    {
        OknoG oknoG;
        string dirpath = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Items\\";
        public Interpreter(OknoG okno) => oknoG = okno;

        public void Local()
        {
            if (Directory.Exists(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\"))
            {
                oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal";
                Application.DoEvents();
                StartLocal(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\1g4n1bVnHcI_W6WXVjScBos2dG6Kpbglk.txt");
            }
        }

        public string GetImage(string name)
        {
            name = Replacer.Names(name);
            if(FindFileNameInDirIcon(name))
            {
                return "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + name;
            }

            if(FindFileNameInDirIconBackup(name))
            {
                return "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + name;
            }
            return null;
        }

        public void Start(string path)
        {
            string[] content = File.ReadAllText(path).Split(';');
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

                    if (content[position] == "GroupName")
                    {
                        position++;
                        if (content[position] == "Polecane")
                        {
                            oknoG.panePolecane.Show();
                            if (!Directory.Exists(dirpath + "Polecane"))
                            {
                                try
                                {
                                    Directory.CreateDirectory(dirpath + "Polecane");
                                }
                                catch (Exception)
                                {

                                }
                            }
                            position++;
                            if (content[position] == "dUri")
                            {
                                position++;
                                WebContent.downloadFile(content[position], dirpath + "Polecane\\" + content[position] + ".txt");
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.Start(dirpath + "Polecane\\" + content[position] + ".txt");

                            }
                            else if(content[position] == "oneDriveUri")
                            {
                                position++;
                                Download.OneDrive.downloadFile(content[position],
                                    dirpath + "Polecane\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.Start(dirpath + "Polecane\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                            }
                        }
                        else
                        {
                            string gname = content[position];
                            Panel panel = new Panel();
                            panel.Show();
                            panel.Name = "panelDockGroup";
                            panel.Size = new Size(931, 296);
                            panel.Dock = DockStyle.Top;
                            AnimePlayerLibrary.ItemsGroup itemsGroup = new ItemsGroup(oknoG.panelStartPage, gname);
                            itemsGroup.Name= gname;
                            itemsGroup.layoutPanel.ControlAdded += oknoG.flowLayoutPanelPolecane_ControlAdded;
                            oknoG.itemsGroups.Add(itemsGroup);
                            oknoG.panelStartPage.Controls.Add(panel);
                            panel.Controls.Add(itemsGroup);
                            itemsGroup.Dock = DockStyle.Fill;
                            oknoG.panelStartPage.Controls.SetChildIndex(panel, 0);
                            if (!Directory.Exists(dirpath + gname))
                            {
                                try
                                {
                                    Directory.CreateDirectory(dirpath + gname);
                                }
                                catch (Exception)
                                {

                                }
                            }
                            position++;
                            if (content[position] == "dUri")
                            {
                                position++;
                                //WebContent.downloadFile(content[position], dirpath + "Polecane\\" + content[position] + ".txt");
                                oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > new Interpreter > StartLocal path:" +
                                    dirpath + gname + "\\" + content[position] + ".txt";
                                Application.DoEvents();
                                WebContent.downloadFile(content[position], dirpath + gname+ "\\" + content[position] + ".txt");
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.Start(dirpath + gname + "\\" + content[position] + ".txt");
                            }
                            else if (content[position] == "oneDriveUri")
                            {
                                position++;
                                oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > new Interpreter > StartLocal";
                                Application.DoEvents();
                                Download.OneDrive.downloadFile(content[position],
                                    dirpath + gname + "\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.Start(dirpath + gname + "\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                            }
                        }

                    }
                    else if (content[position] == "Name")
                    {
                        try
                        {
                            WebContent.Values values = new WebContent.Values(path);
                            string code = content[position]+";";
                            position++;
                            values.name = Replacer.Names(content[position]);
                            code += content[position] + ";";
                            position++;
                            code += content[position] + ";";
                            if (content[position] == "Icon")
                            {
                                position++;
                                code += content[position] + ";";
                                values.iconLink = content[position];
                                values.iconPath = WebContent.downloadIcon(content[position], values.name + "_icon");
                                if(values.iconPath == null)
                                {
                                    values.iconPath = GetImage(values.name + "_icon");
                                }
                                position++;
                                if (content[position] == "Link")
                                {
                                    code += content[position] + ";";
                                    position++;
                                    code += content[position] + ";";
                                    values.siteLink = content[position];
                                    position++;
                                    if (content[position] == "ContentId")
                                    {
                                        code += content[position] + ";";
                                        position++;
                                        code += content[position] + ";";
                                        values.contentId = content[position];
                                        try
                                        {
                                            FileInfo fi = new FileInfo(path);
                                            values.groupName = fi.Directory.Name;
                                        }
                                        catch (Exception)
                                        {

                                        }
                                        if(FindTitlesInProgram(values.name, oknoG))
                                        {
                                            Console.WriteLine("FindTitlesInProgram > true");
                                            foreach (ItemsGroup ig in oknoG.itemsGroups)
                                            {
                                                try
                                                {
                                                    if (ig.groupTitle == values.groupName)
                                                    {
                                                        ig.layoutPanel.Controls.Add(oknoG.ctnPanelAuxiliary.Duplication());
                                                    }
                                                }
                                                catch (Exception exig)
                                                {
                                                    Console.WriteLine(exig.ToString());
                                                }
                                            }
                                        }
                                        else
                                        {
                                            WebContentControls.CtnPanel panel = new WebContentControls.CtnPanel(values, oknoG, oknoG.tchangerColors);
                                        }
                                        
                                    }
                                    position++;
                                    if(content[position] == "ContentId_2")
                                    {
                                        position++;
                                        values.contentId2 = content[position];
                                    }
                                    else
                                    {
                                        position--;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString() + Environment.NewLine);
                        }
                    }
                    position++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Start>\n" + path);
                Console.WriteLine(ex.ToString());
                oknoG.panelLoading.Hide();
            }
        }


        public void AsyncStart(string path)
        {
            string[] content = File.ReadAllText(path).Split(';');
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

                    if (content[position] == "GroupName")
                    {
                        position++;
                        if (content[position] == "Polecane")
                        {
                            oknoG.panePolecane.Show();
                            if (!Directory.Exists(dirpath + "Polecane"))
                            {
                                try
                                {
                                    Directory.CreateDirectory(dirpath + "Polecane");
                                }
                                catch (Exception)
                                {

                                }
                            }
                            position++;
                            if (content[position] == "dUri")
                            {
                                position++;
                                WebContent.downloadFile(content[position], dirpath + "Polecane\\" + content[position] + ".txt");
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.Start(dirpath + "Polecane\\" + content[position] + ".txt");

                            }
                            else if(content[position] == "oneDriveUri")
                            {
                                position++;
                                Download.OneDrive.downloadFile(content[position],
                                    dirpath + "Polecane\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.Start(dirpath + "Polecane\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                            }
                        }
                        else
                        {
                            string gname = content[position];
                            Panel panel = new Panel();
                            panel.Show();
                            panel.Name = "panelDockGroup";
                            panel.Size = new Size(931, 296);
                            panel.Dock = DockStyle.Top;
                            oknoG.Invoke(() =>
                            {
                                AnimePlayerLibrary.ItemsGroup itemsGroup = new ItemsGroup(oknoG.panelStartPage, gname);
                                itemsGroup.Name = gname;
                                itemsGroup.layoutPanel.ControlAdded += oknoG.flowLayoutPanelPolecane_ControlAdded;
                                oknoG.itemsGroups.Add(itemsGroup);
                                oknoG.panelStartPage.Controls.Add(panel);
                                panel.Controls.Add(itemsGroup);
                                itemsGroup.Dock = DockStyle.Fill;
                                oknoG.panelStartPage.Controls.SetChildIndex(panel, 0);
                            });
                            if (!Directory.Exists(dirpath + gname))
                            {
                                try
                                {
                                    Directory.CreateDirectory(dirpath + gname);
                                }
                                catch (Exception)
                                {

                                }
                            }
                            position++;
                            if (content[position] == "dUri")
                            {
                                position++;
                                //WebContent.downloadFile(content[position], dirpath + "Polecane\\" + content[position] + ".txt");
                                //oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > new Interpreter > StartLocal path:" +
                                //    dirpath + gname + "\\" + content[position] + ".txt";
                                Application.DoEvents();
                                WebContent.downloadFile(content[position], dirpath + gname+ "\\" + content[position] + ".txt");
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.AsyncStart(dirpath + gname + "\\" + content[position] + ".txt");
                            }
                            else if (content[position] == "oneDriveUri")
                            {
                                position++;
                               // oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > new Interpreter > StartLocal";
                                Application.DoEvents();
                                Download.OneDrive.downloadFile(content[position],
                                    dirpath + gname + "\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.AsyncStart(dirpath + gname + "\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                            }
                        }

                    }
                    else if (content[position] == "Name")
                    {
                        try
                        {
                            WebContent.Values values = new WebContent.Values(path);
                            string code = content[position]+";";
                            position++;
                            values.name = Replacer.Names(content[position]);
                            code += content[position] + ";";
                            position++;
                            code += content[position] + ";";
                            if (content[position] == "Icon")
                            {
                                position++;
                                code += content[position] + ";";
                                values.iconLink = content[position];
                                values.iconPath = WebContent.downloadIcon(content[position], values.name + "_icon");
                                if(values.iconPath == null)
                                {
                                    values.iconPath = GetImage(values.name + "_icon");
                                }
                                position++;
                                if (content[position] == "Link")
                                {
                                    code += content[position] + ";";
                                    position++;
                                    code += content[position] + ";";
                                    values.siteLink = content[position];
                                    position++;
                                    if (content[position] == "ContentId")
                                    {
                                        code += content[position] + ";";
                                        position++;
                                        code += content[position] + ";";
                                        values.contentId = content[position];
                                        try
                                        {
                                            FileInfo fi = new FileInfo(path);
                                            values.groupName = fi.Directory.Name;
                                        }
                                        catch (Exception)
                                        {

                                        }
                                        /*
                                        bool ftip = false;
                                        try
                                        {
                                            foreach (Control c in okno.flowLayoutPanelAll.Controls)
                                            {
                                                try
                                                {
                                                    Application.DoEvents();
                                                    if (c.Tag != null)
                                                    {
                                                        WebContentControls.CtnPanel ctn = (WebContentControls.CtnPanel)c.Tag;
                                                        if (ctn.values.name.ToLower().Contains(name.ToLower()))
                                                        {
                                                            okno.ctnPanelAuxiliary = ctn;
                                                            ftip= true;
                                                            break;
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine(ex.ToString());
                                                }
                                            }
                                        }
                                        catch (Exception eex)
                                        {
                                            Console.WriteLine(eex.ToString());
                                        }
                                        */
                                        if (Async_FindTitlesInProgram(values.name, oknoG))
                                        {
                                            Console.WriteLine("FindTitlesInProgram > true");
                                            foreach (ItemsGroup ig in oknoG.itemsGroups)
                                            {
                                                try
                                                {
                                                    if (ig.groupTitle == values.groupName)
                                                    {
                                                        oknoG.Invoke(() =>
                                                        {
                                                            ig.layoutPanel.Controls.Add(oknoG.ctnPanelAuxiliary.Duplication());
                                                        });
                                                    }
                                                }
                                                catch (Exception exig)
                                                {
                                                    Console.WriteLine(exig.ToString());
                                                }
                                            }
                                        }
                                        else
                                        {
                                            oknoG.Invoke(() =>
                                            {
                                                WebContentControls.CtnPanel panel = new WebContentControls.CtnPanel(values, oknoG, oknoG.tchangerColors);
                                            });
                                        }
                                        
                                    }
                                    position++;
                                    if(content[position] == "ContentId_2")
                                    {
                                        position++;
                                        values.contentId2 = content[position];
                                    }
                                    else
                                    {
                                        position--;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString() + Environment.NewLine);
                        }
                    }
                    position++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Start>\n" + path);
                Console.WriteLine(ex.ToString());
                oknoG.panelLoading.Hide();
            }
        }

        public Panel selectPanel;

        public void StartLocal(string path)
        {
            
            oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > file:"+path;
            if(!File.Exists(path))
            {
                oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > file > Error";
                Application.DoEvents();
                return;
            }
            string[] content = File.ReadAllText(path).Split(';');
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

                    if (content[position] == "GroupName")
                    {
                        Console.WriteLine("content[position]: "+ content[position]);
                        position++;
                        Console.WriteLine("content[position]: " + content[position]);
                        Console.WriteLine("GroupName if Polecane");
                        if (content[position] == "Polecane")
                        {
                            Console.WriteLine("true");
                            Console.WriteLine("!Exists Dir> "+ dirpath + "Polecane");
                            oknoG.panePolecane.Show();
                            if (!Directory.Exists(dirpath + "Polecane"))
                            {
                                try
                                {
                                    Directory.CreateDirectory(dirpath + "Polecane");
                                }
                                catch (Exception)
                                {

                                }
                            }
                            position++;
                            Console.WriteLine("content[position]: " + content[position]);
                            Console.WriteLine("dUri");
                            if (content[position] == "dUri")
                            {
                                position++;
                                Console.WriteLine("content[position]: " + content[position]);
                                //WebContent.downloadFile(content[position], dirpath + "Polecane\\" + content[position] + ".txt");
                                oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > new Interpreter > StartLocal path:" +
                                    dirpath + "Polecane\\" + content[position] + ".txt";
                                Application.DoEvents();
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.StartLocal(dirpath + "Polecane\\" + content[position] + ".txt");
                            }
                            else if (content[position] == "oneDriveUri")
                            {
                                position++;
                                Console.WriteLine("content[position]: " + content[position]);
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.StartLocal(dirpath + "Polecane\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                            }
                        }
                        else
                        {
                            Console.WriteLine("------OTHER GROUP-----");
                            string gname = content[position];
                            Console.WriteLine("gname: " + gname);
                            Panel panel = new Panel();
                            panel.Show();
                            panel.Name = "panelDockGroup";
                            panel.Size = new Size(931, 296);
                            panel.Dock = DockStyle.Top;
                            AnimePlayerLibrary.ItemsGroup itemsGroup = new ItemsGroup(oknoG.panelStartPage, gname);
                            itemsGroup.Name = gname;
                            itemsGroup.layoutPanel.ControlAdded += oknoG.flowLayoutPanelPolecane_ControlAdded;
                            oknoG.itemsGroups.Add(itemsGroup);
                            oknoG.panelStartPage.Controls.Add(panel);
                            panel.Controls.Add(itemsGroup);
                            itemsGroup.Dock = DockStyle.Fill;
                            oknoG.panelStartPage.Controls.SetChildIndex(panel, 0);
                            if (!Directory.Exists(dirpath + gname))
                            {
                                try
                                {
                                    Directory.CreateDirectory(dirpath + gname);
                                }
                                catch (Exception)
                                {

                                }
                            }
                            position++;
                            Console.WriteLine("content[position]: " + content[position]);
                            if (content[position] == "dUri")
                            {
                                Console.WriteLine("true");
                                position++;
                                Console.WriteLine("content[position]: " + content[position]);
                                //WebContent.downloadFile(content[position], dirpath + "Polecane\\" + content[position] + ".txt");
                                oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > new Interpreter > StartLocal path:" +
                                    dirpath + gname + "\\" + content[position] + ".txt";
                                Application.DoEvents();
                                Interpreter interpreter = new Interpreter(oknoG);
                                Console.WriteLine("StartLocal");
                                interpreter.StartLocal(dirpath + gname + "\\" + content[position] + ".txt");
                            }
                            else if (content[position] == "oneDriveUri")
                            {
                                position++;
                                Console.WriteLine("content[position]: " + content[position]);
                                Interpreter interpreter = new Interpreter(oknoG);
                                interpreter.StartLocal(dirpath + gname + "\\" + Download.OneDrive.onedriveUri(content[position]) + ".txt");
                            }
                        }

                    }
                    else if (content[position] == "Name")
                    {
                        try
                        {
                            string code = content[position] + ";";
                            WebContent.Values values = new WebContent.Values(path);
                            position++;
                            Console.WriteLine("content[position]: " + content[position]);
                            code += content[position] + ";";
                            values.name = Replacer.Names(content[position]);
                            position++;
                            Console.WriteLine("content[position]: " + content[position]);
                            code += content[position] + ";";
                            if (content[position] == "Icon")
                            {
                                position++;
                                Console.WriteLine("content[position]: " + content[position]);
                                code += content[position] + ";";
                                values.iconLink = content[position];
                                //"C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + filename + ".png"
                                //values.iconPath = WebContent.downloadIcon(content[position], values.name + "_icon");

                                if (FindFileNameInDirIconBackup(values.name + "_icon.png"))
                                {
                                    values.iconPath = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + values.name + "_icon.png";
                                }

                                position++;
                                Console.WriteLine("content[position]: " + content[position]);
                                if (content[position] == "Link")
                                {
                                    code += content[position] + ";";
                                    position++;
                                    Console.WriteLine("content[position]: " + content[position]);
                                    code += content[position] + ";";
                                    values.siteLink = content[position];
                                    position++;
                                    Console.WriteLine("content[position]: " + content[position]);
                                    if (content[position] == "ContentId")
                                    {
                                        code += content[position] + ";";
                                        position++;
                                        Console.WriteLine("content[position]: " + content[position]);
                                        code += content[position] + ";";
                                        values.contentId = content[position];
                                        try
                                        {
                                            FileInfo fi = new FileInfo(path);
                                            values.groupName = fi.Directory.Name;
                                            if (FindFileNameInDirPage(values.name + "_page.txt"))
                                            {
                                                values.pathPage = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page\\" + values.name + "_page.txt";
                                            }
                                        }
                                        catch (Exception)
                                        {

                                        }
                                        oknoG.labelLoadingDetails.Text = "Interpreter > Local > StartLocal > file:" + path+ " > Create CtnPanel";
                                        if (FindTitlesInProgram(values.name, oknoG))
                                        {
                                            Console.WriteLine("FindTitlesInProgram > true");
                                            foreach (ItemsGroup ig in oknoG.itemsGroups)
                                            {
                                                try
                                                {
                                                    if (ig.groupTitle == values.groupName)
                                                    {
                                                        ig.layoutPanel.Controls.Add(oknoG.ctnPanelAuxiliary.Duplication());
                                                    }
                                                }
                                                catch (Exception exig)
                                                {
                                                    Console.WriteLine(exig.ToString());
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("FindTitlesInProgram > false");
                                            WebContentControls.CtnPanel panel = new WebContentControls.CtnPanel(values, oknoG, oknoG.tchangerColors);
                                        }
                                    }
                                    position++;
                                    Console.WriteLine("content[position]: " + content[position]);
                                    if (content[position] == "ContentId_2")
                                    {
                                        position++;
                                        Console.WriteLine("content[position]: " + content[position]);
                                        values.contentId2 = content[position];
                                    }
                                    else
                                    {
                                        position--;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString() + Environment.NewLine);
                        }
                    }
                    position++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Start>\n" + path);
                Console.WriteLine(ex.ToString());
                oknoG.panelLoading.Hide();
            }
        }

        public bool FindFileNameInDirIcon(string filename)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon");

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Name == filename)
                {
                    return true;
                }
            }
            return false;
        }
        public bool FindFileNameInDirIconBackup(string filename)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup");

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Name == filename)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool FindTitlesInProgram(string name, OknoG okno)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            name = name.ToLower().Replace("\n", "").Replace("\r", "").Replace("\t", "");
            if(okno == null)
            {
                return false;
            }
            if (name == null)
            {
                return false;
            }
            try
            {
                foreach (Control c in okno.flowLayoutPanelAll.Controls)
                {
                    try
                    {
                        Application.DoEvents();
                        if (c.Tag != null)
                        {
                            WebContentControls.CtnPanel ctn = (WebContentControls.CtnPanel)c.Tag;
                            if (ctn.values.name.ToLower().Contains(name.ToLower()))
                            {
                                okno.ctnPanelAuxiliary = ctn;
                                return true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
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
            Console.WriteLine("{FindTitlesInProgram} time: " + elapsedTime);
            return false;
        }

        public static bool Async_FindTitlesInProgram(string name, OknoG okno)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            name = name.ToLower().Replace("\n", "").Replace("\r", "").Replace("\t", "");
            if(okno == null)
            {
                return false;
            }
            if (name == null)
            {
                return false;
            }
            bool re = false;
            try
            {
                
                okno.BeginInvoke(new Action(() => {
                    foreach (Control c in okno.flowLayoutPanelAll.Controls)
                    {
                        try
                        {
                            Application.DoEvents();
                            if (c.Tag != null)
                            {
                                WebContentControls.CtnPanel ctn = (WebContentControls.CtnPanel)c.Tag;
                                if (ctn.values.name.ToLower().Contains(name.ToLower()))
                                {
                                    okno.ctnPanelAuxiliary = ctn;
                                    re= true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }));
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
            Console.WriteLine("{FindTitlesInProgram} time: " + elapsedTime);
            return re;
        }
        
        public static void AddTitleswithProgram(WebContent.Values va, OknoG okno)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            if(va == null)
            {
                return;
            }

            try
            {
                
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
            Console.WriteLine("{AddTitleswithProgram} time: " + elapsedTime);
            return ;
        }

        public static bool FindFileNameInDirPage(string filename)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page");

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Name == filename)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
