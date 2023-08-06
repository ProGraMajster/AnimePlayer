using AnimePlayer.ControlsWinForms;
using AnimePlayerLibrary;
using System.Windows.Forms;

namespace AnimePlayer
{
    partial class FormMainPlayer
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPlayer));
            notifyIcon1 = new NotifyIcon(components);
            panelStartPage = new Panel();
            panelSTNewsMain = new Panel();
            label_InfoText_news = new Label();
            panel8 = new Panel();
            panelTop = new Panel();
            roundedPanel1 = new RoundedPanel();
            panel7 = new Panel();
            panel9 = new Panel();
            textBoxStartPagefinditem = new TextBox();
            buttonStartPageFinditem = new Button();
            panel22 = new Panel();
            pictureBoxProfileIcon = new PictureBox();
            label23 = new Label();
            labelSatusWorkingApp = new Label();
            buttonMenuOpen = new Button();
            label = new Label();
            panelLoading = new Panel();
            labelLoadingA = new Label();
            labelLoadingDetails = new Label();
            labelLoading = new Label();
            pictureBoxLoading = new PictureBox();
            panelMenu = new Panel();
            panel5 = new Panel();
            pictureBoxGithub = new PictureBox();
            pictureBoxSite = new PictureBox();
            buttonSite = new Button();
            buttonExitApp = new Button();
            buttonRestartApp = new Button();
            panelSep = new Panel();
            buttonMoreBtnMenu = new Button();
            buttonHelp = new Button();
            buttonShowTitleStatusList = new Button();
            buttonDefined = new Button();
            buttonViewFindintems = new Button();
            buttonPlayer = new Button();
            buttonSetting = new Button();
            buttonHomePage = new Button();
            buttonMenuClose = new Button();
            panel2 = new Panel();
            panelMoreButtons = new Panel();
            panel10 = new Panel();
            newFlowLayoutPanel1 = new NewFlowLayoutPanel();
            panel11 = new Panel();
            label5 = new Label();
            button_MoreBtn_Open_Settings = new Button();
            label1 = new Label();
            panel12 = new Panel();
            label6 = new Label();
            button2button_MoreBtn_Open_Player = new Button();
            label7 = new Label();
            panel13 = new Panel();
            label8 = new Label();
            button4button2button_MoreBtn_Open_FindItem = new Button();
            label9 = new Label();
            panel14 = new Panel();
            label10 = new Label();
            button5button2button_MoreBtn_Open_Lists = new Button();
            label11 = new Label();
            panel17 = new Panel();
            label16 = new Label();
            buttonCommunity = new Button();
            label17 = new Label();
            panel15 = new Panel();
            label12 = new Label();
            button2button_MoreBtn_Open_GitHub = new Button();
            label13 = new Label();
            panel16 = new Panel();
            label14 = new Label();
            button7button2button_MoreBtn_Open_twojeanimepl = new Button();
            label15 = new Label();
            panel19 = new Panel();
            label18 = new Label();
            button2 = new Button();
            label19 = new Label();
            panel20 = new Panel();
            label20 = new Label();
            buttonAllNewsContnet = new Button();
            label21 = new Label();
            panel6 = new Panel();
            buttonCloseMoreButtons = new Button();
            panelAllitem = new Panel();
            flowLayoutPanelFinditem = new NewFlowLayoutPanel();
            flowLayoutPanelAll = new NewFlowLayoutPanel();
            panel23 = new Panel();
            panel24 = new Panel();
            comboBoxViewtype = new ComboBox();
            label24 = new Label();
            panelTopFinder = new Panel();
            labelEnableFiltres = new Label();
            roundedPanel2 = new RoundedPanel();
            labelFindSatus = new Label();
            buttonfinditemReset = new Button();
            buttonfinditemF = new Button();
            buttonFindItem = new Button();
            panel21 = new Panel();
            textBoxFinditem = new TextBox();
            label4 = new Label();
            buttonFinditemPageClose = new Button();
            panelNotifiError = new Panel();
            labelError = new Label();
            pictureBox3 = new PictureBox();
            timerAnimationError = new Timer(components);
            toolTip = new ToolTip(components);
            timerAppPer = new Timer(components);
            panel18 = new Panel();
            labelAppRamUsage = new Label();
            panelCommands = new Panel();
            textBoxCommandOutput = new TextBox();
            textBoxCommandInput = new TextBox();
            label22 = new Label();
            timerFindWaitnig = new Timer(components);
            panelStartPage.SuspendLayout();
            panelSTNewsMain.SuspendLayout();
            panelTop.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileIcon).BeginInit();
            panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            panelMenu.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGithub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSite).BeginInit();
            panel2.SuspendLayout();
            panelMoreButtons.SuspendLayout();
            panel10.SuspendLayout();
            newFlowLayoutPanel1.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel17.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel6.SuspendLayout();
            panelAllitem.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panelTopFinder.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel21.SuspendLayout();
            panelNotifiError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel18.SuspendLayout();
            panelCommands.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "WMP_OverlayApp";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            // 
            // panelStartPage
            // 
            panelStartPage.AutoScroll = true;
            panelStartPage.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            panelStartPage.Controls.Add(panelSTNewsMain);
            panelStartPage.Controls.Add(panel8);
            panelStartPage.Controls.Add(panelTop);
            panelStartPage.Dock = DockStyle.Fill;
            panelStartPage.Location = new System.Drawing.Point(0, 0);
            panelStartPage.Margin = new Padding(4, 3, 4, 3);
            panelStartPage.Name = "panelStartPage";
            panelStartPage.Size = new System.Drawing.Size(1090, 624);
            panelStartPage.TabIndex = 6;
            panelStartPage.ControlAdded += PanelStartPage_ControlAdded;
            // 
            // panelSTNewsMain
            // 
            panelSTNewsMain.Controls.Add(label_InfoText_news);
            panelSTNewsMain.Dock = DockStyle.Top;
            panelSTNewsMain.Location = new System.Drawing.Point(0, 130);
            panelSTNewsMain.Margin = new Padding(4, 3, 4, 3);
            panelSTNewsMain.Name = "panelSTNewsMain";
            panelSTNewsMain.Size = new System.Drawing.Size(1090, 409);
            panelSTNewsMain.TabIndex = 4;
            panelSTNewsMain.Visible = false;
            // 
            // label_InfoText_news
            // 
            label_InfoText_news.AutoSize = true;
            label_InfoText_news.Dock = DockStyle.Top;
            label_InfoText_news.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_InfoText_news.ForeColor = System.Drawing.Color.White;
            label_InfoText_news.Location = new System.Drawing.Point(0, 0);
            label_InfoText_news.Margin = new Padding(4, 0, 4, 0);
            label_InfoText_news.Name = "label_InfoText_news";
            label_InfoText_news.Size = new System.Drawing.Size(117, 28);
            label_InfoText_news.TabIndex = 1;
            label_InfoText_news.Text = "Aktualności";
            label_InfoText_news.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new System.Drawing.Point(0, 105);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(1090, 25);
            panel8.TabIndex = 3;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(roundedPanel1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(12);
            panelTop.Size = new System.Drawing.Size(1090, 105);
            panelTop.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            roundedPanel1.ColorEdges = System.Drawing.SystemColors.ActiveCaptionText;
            roundedPanel1.Controls.Add(panel7);
            roundedPanel1.Controls.Add(panel22);
            roundedPanel1.Controls.Add(labelSatusWorkingApp);
            roundedPanel1.Controls.Add(buttonMenuOpen);
            roundedPanel1.Controls.Add(label);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.ExBackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            roundedPanel1.Location = new System.Drawing.Point(12, 12);
            roundedPanel1.Margin = new Padding(12);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(23, 7, 23, 7);
            roundedPanel1.RadiusArcPanel = 15F;
            roundedPanel1.Size = new System.Drawing.Size(1066, 81);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Resize += Panel_Resize;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(buttonStartPageFinditem);
            panel7.Dock = DockStyle.Fill;
            panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel7.Location = new System.Drawing.Point(221, 7);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(6, 23, 6, 17);
            panel7.Size = new System.Drawing.Size(582, 67);
            panel7.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Controls.Add(textBoxStartPagefinditem);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new System.Drawing.Point(6, 23);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 6, 0, 0);
            panel9.Size = new System.Drawing.Size(482, 27);
            panel9.TabIndex = 5;
            // 
            // textBoxStartPagefinditem
            // 
            textBoxStartPagefinditem.AutoCompleteCustomSource.AddRange(new string[] { "TEST" });
            textBoxStartPagefinditem.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxStartPagefinditem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxStartPagefinditem.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            textBoxStartPagefinditem.BorderStyle = BorderStyle.None;
            textBoxStartPagefinditem.Dock = DockStyle.Fill;
            textBoxStartPagefinditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxStartPagefinditem.ForeColor = System.Drawing.Color.White;
            textBoxStartPagefinditem.Location = new System.Drawing.Point(0, 6);
            textBoxStartPagefinditem.Margin = new Padding(4, 3, 4, 3);
            textBoxStartPagefinditem.Name = "textBoxStartPagefinditem";
            textBoxStartPagefinditem.Size = new System.Drawing.Size(482, 16);
            textBoxStartPagefinditem.TabIndex = 3;
            textBoxStartPagefinditem.TextAlign = HorizontalAlignment.Center;
            textBoxStartPagefinditem.KeyDown += TextBoxSPfinditem_KeyDown;
            // 
            // buttonStartPageFinditem
            // 
            buttonStartPageFinditem.BackColor = System.Drawing.Color.Transparent;
            buttonStartPageFinditem.Dock = DockStyle.Right;
            buttonStartPageFinditem.FlatAppearance.BorderSize = 0;
            buttonStartPageFinditem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            buttonStartPageFinditem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 65, 65);
            buttonStartPageFinditem.FlatStyle = FlatStyle.Flat;
            buttonStartPageFinditem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonStartPageFinditem.ForeColor = System.Drawing.Color.White;
            buttonStartPageFinditem.Location = new System.Drawing.Point(488, 23);
            buttonStartPageFinditem.Margin = new Padding(4, 3, 4, 3);
            buttonStartPageFinditem.Name = "buttonStartPageFinditem";
            buttonStartPageFinditem.Size = new System.Drawing.Size(88, 27);
            buttonStartPageFinditem.TabIndex = 4;
            buttonStartPageFinditem.Text = "Szukaj";
            buttonStartPageFinditem.UseVisualStyleBackColor = true;
            buttonStartPageFinditem.Click += ButtonStartPageFinditem_Click;
            // 
            // panel22
            // 
            panel22.Controls.Add(pictureBoxProfileIcon);
            panel22.Controls.Add(label23);
            panel22.Dock = DockStyle.Right;
            panel22.Location = new System.Drawing.Point(803, 7);
            panel22.Name = "panel22";
            panel22.Size = new System.Drawing.Size(80, 67);
            panel22.TabIndex = 5;
            panel22.Visible = false;
            // 
            // pictureBoxProfileIcon
            // 
            pictureBoxProfileIcon.Dock = DockStyle.Fill;
            pictureBoxProfileIcon.Location = new System.Drawing.Point(0, 15);
            pictureBoxProfileIcon.Name = "pictureBoxProfileIcon";
            pictureBoxProfileIcon.Size = new System.Drawing.Size(80, 52);
            pictureBoxProfileIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfileIcon.TabIndex = 6;
            pictureBoxProfileIcon.TabStop = false;
            pictureBoxProfileIcon.Paint += pictureBoxProfileIcon_Paint;
            // 
            // label23
            // 
            label23.Dock = DockStyle.Top;
            label23.ForeColor = System.Drawing.Color.White;
            label23.Location = new System.Drawing.Point(0, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(80, 15);
            label23.TabIndex = 7;
            label23.Text = "Profil";
            label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSatusWorkingApp
            // 
            labelSatusWorkingApp.Dock = DockStyle.Right;
            labelSatusWorkingApp.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSatusWorkingApp.ForeColor = System.Drawing.SystemColors.Window;
            labelSatusWorkingApp.Location = new System.Drawing.Point(883, 7);
            labelSatusWorkingApp.Margin = new Padding(4, 0, 4, 0);
            labelSatusWorkingApp.Name = "labelSatusWorkingApp";
            labelSatusWorkingApp.Size = new System.Drawing.Size(77, 67);
            labelSatusWorkingApp.TabIndex = 2;
            labelSatusWorkingApp.Text = "Satus działania:";
            labelSatusWorkingApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelSatusWorkingApp.Visible = false;
            // 
            // buttonMenuOpen
            // 
            buttonMenuOpen.BackgroundImage = Properties.Resources.white_menu_icon_12;
            buttonMenuOpen.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMenuOpen.Dock = DockStyle.Right;
            buttonMenuOpen.FlatAppearance.BorderSize = 0;
            buttonMenuOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            buttonMenuOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            buttonMenuOpen.FlatStyle = FlatStyle.Flat;
            buttonMenuOpen.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonMenuOpen.ForeColor = System.Drawing.Color.White;
            buttonMenuOpen.Location = new System.Drawing.Point(960, 7);
            buttonMenuOpen.Margin = new Padding(4, 3, 4, 3);
            buttonMenuOpen.Name = "buttonMenuOpen";
            buttonMenuOpen.Size = new System.Drawing.Size(83, 67);
            buttonMenuOpen.TabIndex = 1;
            buttonMenuOpen.UseVisualStyleBackColor = true;
            buttonMenuOpen.Click += ButtonMenuOpen_Click;
            // 
            // label
            // 
            label.Dock = DockStyle.Left;
            label.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label.ForeColor = System.Drawing.Color.White;
            label.Location = new System.Drawing.Point(23, 7);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(198, 67);
            label.TabIndex = 0;
            label.Text = "Anime Player";
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLoading
            // 
            panelLoading.BackgroundImageLayout = ImageLayout.Stretch;
            panelLoading.Controls.Add(labelLoadingA);
            panelLoading.Controls.Add(labelLoadingDetails);
            panelLoading.Controls.Add(labelLoading);
            panelLoading.Controls.Add(pictureBoxLoading);
            panelLoading.Dock = DockStyle.Fill;
            panelLoading.Location = new System.Drawing.Point(0, 0);
            panelLoading.Margin = new Padding(4, 3, 4, 3);
            panelLoading.Name = "panelLoading";
            panelLoading.Size = new System.Drawing.Size(1090, 624);
            panelLoading.TabIndex = 2;
            panelLoading.VisibleChanged += PanelLoading_VisibleChanged;
            // 
            // labelLoadingA
            // 
            labelLoadingA.BackColor = System.Drawing.Color.FromArgb(100, 20, 20, 20);
            labelLoadingA.Dock = DockStyle.Top;
            labelLoadingA.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLoadingA.ForeColor = System.Drawing.Color.White;
            labelLoadingA.Location = new System.Drawing.Point(0, 0);
            labelLoadingA.Margin = new Padding(4, 0, 4, 0);
            labelLoadingA.Name = "labelLoadingA";
            labelLoadingA.Size = new System.Drawing.Size(1090, 32);
            labelLoadingA.TabIndex = 2;
            labelLoadingA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadingDetails
            // 
            labelLoadingDetails.BackColor = System.Drawing.Color.FromArgb(100, 20, 20, 20);
            labelLoadingDetails.Dock = DockStyle.Bottom;
            labelLoadingDetails.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLoadingDetails.ForeColor = System.Drawing.Color.White;
            labelLoadingDetails.Location = new System.Drawing.Point(0, 592);
            labelLoadingDetails.Margin = new Padding(4, 0, 4, 0);
            labelLoadingDetails.Name = "labelLoadingDetails";
            labelLoadingDetails.Size = new System.Drawing.Size(1090, 32);
            labelLoadingDetails.TabIndex = 1;
            labelLoadingDetails.Text = ":";
            labelLoadingDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoading
            // 
            labelLoading.AutoSize = true;
            labelLoading.BackColor = System.Drawing.Color.FromArgb(100, 20, 20, 20);
            labelLoading.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLoading.ForeColor = System.Drawing.Color.White;
            labelLoading.Location = new System.Drawing.Point(467, 286);
            labelLoading.Margin = new Padding(4, 0, 4, 0);
            labelLoading.Name = "labelLoading";
            labelLoading.Size = new System.Drawing.Size(145, 38);
            labelLoading.TabIndex = 0;
            labelLoading.Text = "Ładowanie";
            labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelLoading.VisibleChanged += LabelLoading_VisibleChanged;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLoading.Dock = DockStyle.Fill;
            pictureBoxLoading.Location = new System.Drawing.Point(0, 0);
            pictureBoxLoading.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new System.Drawing.Size(1090, 624);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLoading.TabIndex = 3;
            pictureBoxLoading.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            panelMenu.Controls.Add(panel5);
            panelMenu.Controls.Add(buttonExitApp);
            panelMenu.Controls.Add(buttonRestartApp);
            panelMenu.Controls.Add(panelSep);
            panelMenu.Controls.Add(buttonMoreBtnMenu);
            panelMenu.Controls.Add(buttonHelp);
            panelMenu.Controls.Add(buttonShowTitleStatusList);
            panelMenu.Controls.Add(buttonDefined);
            panelMenu.Controls.Add(buttonViewFindintems);
            panelMenu.Controls.Add(buttonPlayer);
            panelMenu.Controls.Add(buttonSetting);
            panelMenu.Controls.Add(buttonHomePage);
            panelMenu.Controls.Add(buttonMenuClose);
            panelMenu.Location = new System.Drawing.Point(875, 0);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(12);
            panelMenu.Size = new System.Drawing.Size(233, 624);
            panelMenu.TabIndex = 1;
            panelMenu.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBoxGithub);
            panel5.Controls.Add(pictureBoxSite);
            panel5.Controls.Add(buttonSite);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new System.Drawing.Point(12, 566);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(209, 46);
            panel5.TabIndex = 4;
            // 
            // pictureBoxGithub
            // 
            pictureBoxGithub.Dock = DockStyle.Left;
            pictureBoxGithub.Image = Properties.Resources.GitHub_Mark_Light_120px_plus;
            pictureBoxGithub.Location = new System.Drawing.Point(0, 0);
            pictureBoxGithub.Margin = new Padding(4, 3, 4, 3);
            pictureBoxGithub.Name = "pictureBoxGithub";
            pictureBoxGithub.Size = new System.Drawing.Size(47, 46);
            pictureBoxGithub.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGithub.TabIndex = 0;
            pictureBoxGithub.TabStop = false;
            pictureBoxGithub.Click += PictureBoxGithub_Click;
            // 
            // pictureBoxSite
            // 
            pictureBoxSite.Dock = DockStyle.Right;
            pictureBoxSite.Image = Properties.Resources.siteIcon;
            pictureBoxSite.Location = new System.Drawing.Point(68, 0);
            pictureBoxSite.Margin = new Padding(4, 3, 4, 3);
            pictureBoxSite.Name = "pictureBoxSite";
            pictureBoxSite.Size = new System.Drawing.Size(47, 46);
            pictureBoxSite.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSite.TabIndex = 2;
            pictureBoxSite.TabStop = false;
            pictureBoxSite.Click += PictureBoxSite_Click;
            // 
            // buttonSite
            // 
            buttonSite.BackgroundImageLayout = ImageLayout.None;
            buttonSite.Dock = DockStyle.Right;
            buttonSite.FlatAppearance.BorderSize = 0;
            buttonSite.FlatStyle = FlatStyle.Flat;
            buttonSite.ForeColor = System.Drawing.Color.White;
            buttonSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSite.Location = new System.Drawing.Point(115, 0);
            buttonSite.Margin = new Padding(4, 3, 4, 3);
            buttonSite.Name = "buttonSite";
            buttonSite.Size = new System.Drawing.Size(94, 46);
            buttonSite.TabIndex = 4;
            buttonSite.Text = "Twojanimepl";
            buttonSite.UseVisualStyleBackColor = true;
            buttonSite.Click += ButtonSite_Click;
            // 
            // buttonExitApp
            // 
            buttonExitApp.Dock = DockStyle.Top;
            buttonExitApp.FlatAppearance.BorderSize = 0;
            buttonExitApp.FlatStyle = FlatStyle.Flat;
            buttonExitApp.ForeColor = System.Drawing.Color.White;
            buttonExitApp.Location = new System.Drawing.Point(12, 463);
            buttonExitApp.Margin = new Padding(4, 3, 4, 3);
            buttonExitApp.Name = "buttonExitApp";
            buttonExitApp.Size = new System.Drawing.Size(209, 46);
            buttonExitApp.TabIndex = 3;
            buttonExitApp.Text = "Zamknij aplikacje";
            buttonExitApp.UseVisualStyleBackColor = true;
            buttonExitApp.Click += ButtonExitApp_Click;
            // 
            // buttonRestartApp
            // 
            buttonRestartApp.Dock = DockStyle.Top;
            buttonRestartApp.FlatAppearance.BorderSize = 0;
            buttonRestartApp.FlatStyle = FlatStyle.Flat;
            buttonRestartApp.ForeColor = System.Drawing.Color.White;
            buttonRestartApp.Location = new System.Drawing.Point(12, 417);
            buttonRestartApp.Margin = new Padding(4, 3, 4, 3);
            buttonRestartApp.Name = "buttonRestartApp";
            buttonRestartApp.Size = new System.Drawing.Size(209, 46);
            buttonRestartApp.TabIndex = 6;
            buttonRestartApp.Text = "Zrestartuj aplikacjie";
            buttonRestartApp.UseVisualStyleBackColor = true;
            buttonRestartApp.Visible = false;
            buttonRestartApp.Click += ButtonRestartApp_Click;
            // 
            // panelSep
            // 
            panelSep.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            panelSep.Dock = DockStyle.Top;
            panelSep.Location = new System.Drawing.Point(12, 412);
            panelSep.Name = "panelSep";
            panelSep.Size = new System.Drawing.Size(209, 5);
            panelSep.TabIndex = 9;
            // 
            // buttonMoreBtnMenu
            // 
            buttonMoreBtnMenu.Dock = DockStyle.Top;
            buttonMoreBtnMenu.FlatAppearance.BorderSize = 0;
            buttonMoreBtnMenu.FlatStyle = FlatStyle.Flat;
            buttonMoreBtnMenu.ForeColor = System.Drawing.Color.White;
            buttonMoreBtnMenu.Location = new System.Drawing.Point(12, 366);
            buttonMoreBtnMenu.Margin = new Padding(4, 3, 4, 3);
            buttonMoreBtnMenu.Name = "buttonMoreBtnMenu";
            buttonMoreBtnMenu.Size = new System.Drawing.Size(209, 46);
            buttonMoreBtnMenu.TabIndex = 8;
            buttonMoreBtnMenu.Text = "Więcej..";
            toolTip.SetToolTip(buttonMoreBtnMenu, "Statusy: Oglądam, Planeuj,, Wstrzymane itp.");
            buttonMoreBtnMenu.UseVisualStyleBackColor = true;
            buttonMoreBtnMenu.Click += ButtonMoreBtnMenu_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Dock = DockStyle.Top;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.ForeColor = System.Drawing.Color.White;
            buttonHelp.Location = new System.Drawing.Point(12, 320);
            buttonHelp.Margin = new Padding(4, 3, 4, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new System.Drawing.Size(209, 46);
            buttonHelp.TabIndex = 12;
            buttonHelp.Text = "Pomoc";
            toolTip.SetToolTip(buttonHelp, "Statusy: Oglądam, Planeuj,, Wstrzymane itp.");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonShowTitleStatusList
            // 
            buttonShowTitleStatusList.Dock = DockStyle.Top;
            buttonShowTitleStatusList.FlatAppearance.BorderSize = 0;
            buttonShowTitleStatusList.FlatStyle = FlatStyle.Flat;
            buttonShowTitleStatusList.ForeColor = System.Drawing.Color.White;
            buttonShowTitleStatusList.Location = new System.Drawing.Point(12, 274);
            buttonShowTitleStatusList.Margin = new Padding(4, 3, 4, 3);
            buttonShowTitleStatusList.Name = "buttonShowTitleStatusList";
            buttonShowTitleStatusList.Size = new System.Drawing.Size(209, 46);
            buttonShowTitleStatusList.TabIndex = 7;
            buttonShowTitleStatusList.Text = "Listy anime";
            toolTip.SetToolTip(buttonShowTitleStatusList, "Statusy: Oglądam, Planeuj,, Wstrzymane itp.");
            buttonShowTitleStatusList.UseVisualStyleBackColor = true;
            buttonShowTitleStatusList.Click += ButtonShowTitleStatusList_Click;
            // 
            // buttonDefined
            // 
            buttonDefined.Dock = DockStyle.Top;
            buttonDefined.FlatAppearance.BorderSize = 0;
            buttonDefined.FlatStyle = FlatStyle.Flat;
            buttonDefined.ForeColor = System.Drawing.Color.White;
            buttonDefined.Location = new System.Drawing.Point(12, 228);
            buttonDefined.Margin = new Padding(4, 3, 4, 3);
            buttonDefined.Name = "buttonDefined";
            buttonDefined.Size = new System.Drawing.Size(209, 46);
            buttonDefined.TabIndex = 10;
            buttonDefined.Text = "Definicje";
            toolTip.SetToolTip(buttonDefined, "Definicje tagów");
            buttonDefined.UseVisualStyleBackColor = true;
            buttonDefined.Click += ButtonDefined_Click;
            // 
            // buttonViewFindintems
            // 
            buttonViewFindintems.Dock = DockStyle.Top;
            buttonViewFindintems.FlatAppearance.BorderSize = 0;
            buttonViewFindintems.FlatStyle = FlatStyle.Flat;
            buttonViewFindintems.ForeColor = System.Drawing.Color.White;
            buttonViewFindintems.Location = new System.Drawing.Point(12, 182);
            buttonViewFindintems.Margin = new Padding(4, 3, 4, 3);
            buttonViewFindintems.Name = "buttonViewFindintems";
            buttonViewFindintems.Size = new System.Drawing.Size(209, 46);
            buttonViewFindintems.TabIndex = 5;
            buttonViewFindintems.Text = "Wyszukiwarka";
            buttonViewFindintems.UseVisualStyleBackColor = true;
            buttonViewFindintems.Click += ButtonViewFindintems_Click;
            // 
            // buttonPlayer
            // 
            buttonPlayer.Dock = DockStyle.Top;
            buttonPlayer.FlatAppearance.BorderSize = 0;
            buttonPlayer.FlatStyle = FlatStyle.Flat;
            buttonPlayer.ForeColor = System.Drawing.Color.White;
            buttonPlayer.Location = new System.Drawing.Point(12, 136);
            buttonPlayer.Margin = new Padding(4, 3, 4, 3);
            buttonPlayer.Name = "buttonPlayer";
            buttonPlayer.Size = new System.Drawing.Size(209, 46);
            buttonPlayer.TabIndex = 2;
            buttonPlayer.Text = "Odtwarzacz";
            buttonPlayer.UseVisualStyleBackColor = true;
            buttonPlayer.Click += ButtonPlayer_Click;
            // 
            // buttonSetting
            // 
            buttonSetting.Dock = DockStyle.Top;
            buttonSetting.FlatAppearance.BorderSize = 0;
            buttonSetting.FlatStyle = FlatStyle.Flat;
            buttonSetting.ForeColor = System.Drawing.Color.White;
            buttonSetting.Location = new System.Drawing.Point(12, 90);
            buttonSetting.Margin = new Padding(4, 3, 4, 3);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new System.Drawing.Size(209, 46);
            buttonSetting.TabIndex = 1;
            buttonSetting.Text = "Ustawienia";
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Visible = false;
            buttonSetting.Click += ButtonSetting_Click;
            // 
            // buttonHomePage
            // 
            buttonHomePage.Dock = DockStyle.Top;
            buttonHomePage.FlatAppearance.BorderSize = 0;
            buttonHomePage.FlatStyle = FlatStyle.Flat;
            buttonHomePage.ForeColor = System.Drawing.Color.White;
            buttonHomePage.Location = new System.Drawing.Point(12, 44);
            buttonHomePage.Margin = new Padding(4, 3, 4, 3);
            buttonHomePage.Name = "buttonHomePage";
            buttonHomePage.Size = new System.Drawing.Size(209, 46);
            buttonHomePage.TabIndex = 11;
            buttonHomePage.Text = "Strona główna";
            buttonHomePage.UseVisualStyleBackColor = true;
            buttonHomePage.Click += ButtonHomePage_Click;
            // 
            // buttonMenuClose
            // 
            buttonMenuClose.Dock = DockStyle.Top;
            buttonMenuClose.FlatStyle = FlatStyle.Flat;
            buttonMenuClose.ForeColor = System.Drawing.Color.Red;
            buttonMenuClose.Location = new System.Drawing.Point(12, 12);
            buttonMenuClose.Margin = new Padding(4, 3, 4, 3);
            buttonMenuClose.Name = "buttonMenuClose";
            buttonMenuClose.Size = new System.Drawing.Size(209, 32);
            buttonMenuClose.TabIndex = 0;
            buttonMenuClose.Text = "X";
            buttonMenuClose.UseVisualStyleBackColor = true;
            buttonMenuClose.Click += ButtonMenuClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelStartPage);
            panel2.Controls.Add(panelAllitem);
            panel2.Controls.Add(panelMoreButtons);
            panel2.Controls.Add(panelLoading);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1090, 624);
            panel2.TabIndex = 5;
            panel2.ControlAdded += panel2_ControlAdded;
            // 
            // panelMoreButtons
            // 
            panelMoreButtons.Controls.Add(panel10);
            panelMoreButtons.Controls.Add(panel6);
            panelMoreButtons.Dock = DockStyle.Fill;
            panelMoreButtons.Location = new System.Drawing.Point(0, 0);
            panelMoreButtons.Name = "panelMoreButtons";
            panelMoreButtons.Size = new System.Drawing.Size(1090, 624);
            panelMoreButtons.TabIndex = 2;
            panelMoreButtons.Visible = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(newFlowLayoutPanel1);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new System.Drawing.Point(0, 38);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 20, 20, 0);
            panel10.Size = new System.Drawing.Size(1090, 586);
            panel10.TabIndex = 1;
            // 
            // newFlowLayoutPanel1
            // 
            newFlowLayoutPanel1.Controls.Add(panel11);
            newFlowLayoutPanel1.Controls.Add(panel12);
            newFlowLayoutPanel1.Controls.Add(panel13);
            newFlowLayoutPanel1.Controls.Add(panel14);
            newFlowLayoutPanel1.Controls.Add(panel17);
            newFlowLayoutPanel1.Controls.Add(panel15);
            newFlowLayoutPanel1.Controls.Add(panel16);
            newFlowLayoutPanel1.Controls.Add(panel19);
            newFlowLayoutPanel1.Controls.Add(panel20);
            newFlowLayoutPanel1.Dock = DockStyle.Fill;
            newFlowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            newFlowLayoutPanel1.Padding = new Padding(5);
            newFlowLayoutPanel1.Size = new System.Drawing.Size(1050, 566);
            newFlowLayoutPanel1.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel11.Controls.Add(label5);
            panel11.Controls.Add(button_MoreBtn_Open_Settings);
            panel11.Controls.Add(label1);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new System.Drawing.Point(8, 8);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(1);
            panel11.Size = new System.Drawing.Size(200, 120);
            panel11.TabIndex = 0;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(1, 33);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(198, 56);
            label5.TabIndex = 2;
            // 
            // button_MoreBtn_Open_Settings
            // 
            button_MoreBtn_Open_Settings.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            button_MoreBtn_Open_Settings.Dock = DockStyle.Bottom;
            button_MoreBtn_Open_Settings.FlatAppearance.BorderSize = 0;
            button_MoreBtn_Open_Settings.FlatStyle = FlatStyle.Flat;
            button_MoreBtn_Open_Settings.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_MoreBtn_Open_Settings.ForeColor = System.Drawing.Color.White;
            button_MoreBtn_Open_Settings.Location = new System.Drawing.Point(1, 89);
            button_MoreBtn_Open_Settings.Name = "button_MoreBtn_Open_Settings";
            button_MoreBtn_Open_Settings.Size = new System.Drawing.Size(198, 30);
            button_MoreBtn_Open_Settings.TabIndex = 1;
            button_MoreBtn_Open_Settings.Text = "Przejdź";
            button_MoreBtn_Open_Settings.UseVisualStyleBackColor = false;
            button_MoreBtn_Open_Settings.Click += Button_MoreBtn_Open_Settings_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(1, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(198, 32);
            label1.TabIndex = 0;
            label1.Text = "Ustawienia";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            panel12.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel12.Controls.Add(label6);
            panel12.Controls.Add(button2button_MoreBtn_Open_Player);
            panel12.Controls.Add(label7);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new System.Drawing.Point(214, 8);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(1);
            panel12.Size = new System.Drawing.Size(200, 120);
            panel12.TabIndex = 1;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(1, 33);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(198, 56);
            label6.TabIndex = 2;
            label6.Text = "Odtwarzacz plików lokalnych";
            // 
            // button2button_MoreBtn_Open_Player
            // 
            button2button_MoreBtn_Open_Player.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            button2button_MoreBtn_Open_Player.Dock = DockStyle.Bottom;
            button2button_MoreBtn_Open_Player.FlatAppearance.BorderSize = 0;
            button2button_MoreBtn_Open_Player.FlatStyle = FlatStyle.Flat;
            button2button_MoreBtn_Open_Player.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2button_MoreBtn_Open_Player.ForeColor = System.Drawing.Color.White;
            button2button_MoreBtn_Open_Player.Location = new System.Drawing.Point(1, 89);
            button2button_MoreBtn_Open_Player.Name = "button2button_MoreBtn_Open_Player";
            button2button_MoreBtn_Open_Player.Size = new System.Drawing.Size(198, 30);
            button2button_MoreBtn_Open_Player.TabIndex = 1;
            button2button_MoreBtn_Open_Player.Text = "Przejdź";
            button2button_MoreBtn_Open_Player.UseVisualStyleBackColor = false;
            button2button_MoreBtn_Open_Player.Click += Button2button_MoreBtn_Open_Player_Click;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(1, 1);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(198, 32);
            label7.TabIndex = 0;
            label7.Text = "Odtwarzacz";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel13.Controls.Add(label8);
            panel13.Controls.Add(button4button2button_MoreBtn_Open_FindItem);
            panel13.Controls.Add(label9);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new System.Drawing.Point(420, 8);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(1);
            panel13.Size = new System.Drawing.Size(200, 120);
            panel13.TabIndex = 2;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(1, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(198, 56);
            label8.TabIndex = 2;
            label8.Text = "Wyszukiwarka dostępnych tytułów";
            // 
            // button4button2button_MoreBtn_Open_FindItem
            // 
            button4button2button_MoreBtn_Open_FindItem.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            button4button2button_MoreBtn_Open_FindItem.Dock = DockStyle.Bottom;
            button4button2button_MoreBtn_Open_FindItem.FlatAppearance.BorderSize = 0;
            button4button2button_MoreBtn_Open_FindItem.FlatStyle = FlatStyle.Flat;
            button4button2button_MoreBtn_Open_FindItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button4button2button_MoreBtn_Open_FindItem.ForeColor = System.Drawing.Color.White;
            button4button2button_MoreBtn_Open_FindItem.Location = new System.Drawing.Point(1, 89);
            button4button2button_MoreBtn_Open_FindItem.Name = "button4button2button_MoreBtn_Open_FindItem";
            button4button2button_MoreBtn_Open_FindItem.Size = new System.Drawing.Size(198, 30);
            button4button2button_MoreBtn_Open_FindItem.TabIndex = 1;
            button4button2button_MoreBtn_Open_FindItem.Text = "Przejdź";
            button4button2button_MoreBtn_Open_FindItem.UseVisualStyleBackColor = false;
            button4button2button_MoreBtn_Open_FindItem.Click += Button4button2button_MoreBtn_Open_FindItem_Click;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(1, 1);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(198, 32);
            label9.TabIndex = 0;
            label9.Text = "Wyszukiwarka";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            panel14.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel14.Controls.Add(label10);
            panel14.Controls.Add(button5button2button_MoreBtn_Open_Lists);
            panel14.Controls.Add(label11);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new System.Drawing.Point(626, 8);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(1);
            panel14.Size = new System.Drawing.Size(200, 120);
            panel14.TabIndex = 3;
            panel14.Visible = false;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(1, 33);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(198, 56);
            label10.TabIndex = 2;
            label10.Text = "Listy: \r\nOglądam, Planeuj,, Wstrzymane, Porzucone, itp.";
            // 
            // button5button2button_MoreBtn_Open_Lists
            // 
            button5button2button_MoreBtn_Open_Lists.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            button5button2button_MoreBtn_Open_Lists.Dock = DockStyle.Bottom;
            button5button2button_MoreBtn_Open_Lists.FlatAppearance.BorderSize = 0;
            button5button2button_MoreBtn_Open_Lists.FlatStyle = FlatStyle.Flat;
            button5button2button_MoreBtn_Open_Lists.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button5button2button_MoreBtn_Open_Lists.ForeColor = System.Drawing.Color.White;
            button5button2button_MoreBtn_Open_Lists.Location = new System.Drawing.Point(1, 89);
            button5button2button_MoreBtn_Open_Lists.Name = "button5button2button_MoreBtn_Open_Lists";
            button5button2button_MoreBtn_Open_Lists.Size = new System.Drawing.Size(198, 30);
            button5button2button_MoreBtn_Open_Lists.TabIndex = 1;
            button5button2button_MoreBtn_Open_Lists.Text = "Przejdź";
            button5button2button_MoreBtn_Open_Lists.UseVisualStyleBackColor = false;
            button5button2button_MoreBtn_Open_Lists.Click += Button5button2button_MoreBtn_Open_Lists_Click;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Top;
            label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(1, 1);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(198, 32);
            label11.TabIndex = 0;
            label11.Text = "Listy anime";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            panel17.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel17.Controls.Add(label16);
            panel17.Controls.Add(buttonCommunity);
            panel17.Controls.Add(label17);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new System.Drawing.Point(832, 8);
            panel17.Name = "panel17";
            panel17.Padding = new Padding(1);
            panel17.Size = new System.Drawing.Size(200, 120);
            panel17.TabIndex = 6;
            // 
            // label16
            // 
            label16.Dock = DockStyle.Fill;
            label16.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.ForeColor = System.Drawing.Color.White;
            label16.Location = new System.Drawing.Point(1, 33);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(198, 56);
            label16.TabIndex = 2;
            label16.Text = "Ludzie, Grupy...";
            // 
            // buttonCommunity
            // 
            buttonCommunity.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            buttonCommunity.Dock = DockStyle.Bottom;
            buttonCommunity.FlatAppearance.BorderSize = 0;
            buttonCommunity.FlatStyle = FlatStyle.Flat;
            buttonCommunity.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCommunity.ForeColor = System.Drawing.Color.White;
            buttonCommunity.Location = new System.Drawing.Point(1, 89);
            buttonCommunity.Name = "buttonCommunity";
            buttonCommunity.Size = new System.Drawing.Size(198, 30);
            buttonCommunity.TabIndex = 1;
            buttonCommunity.Text = "Przejdź";
            buttonCommunity.UseVisualStyleBackColor = false;
            buttonCommunity.Click += ButtonCommunity_Click;
            // 
            // label17
            // 
            label17.Dock = DockStyle.Top;
            label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.ForeColor = System.Drawing.Color.White;
            label17.Location = new System.Drawing.Point(1, 1);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(198, 32);
            label17.TabIndex = 0;
            label17.Text = "Społeczność";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            panel15.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel15.Controls.Add(label12);
            panel15.Controls.Add(button2button_MoreBtn_Open_GitHub);
            panel15.Controls.Add(label13);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new System.Drawing.Point(8, 134);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(1);
            panel15.Size = new System.Drawing.Size(200, 120);
            panel15.TabIndex = 4;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Fill;
            label12.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.Color.White;
            label12.Location = new System.Drawing.Point(1, 33);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(198, 56);
            label12.TabIndex = 2;
            label12.Text = "Kod źródłowy aplikacji";
            // 
            // button2button_MoreBtn_Open_GitHub
            // 
            button2button_MoreBtn_Open_GitHub.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            button2button_MoreBtn_Open_GitHub.Dock = DockStyle.Bottom;
            button2button_MoreBtn_Open_GitHub.FlatAppearance.BorderSize = 0;
            button2button_MoreBtn_Open_GitHub.FlatStyle = FlatStyle.Flat;
            button2button_MoreBtn_Open_GitHub.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2button_MoreBtn_Open_GitHub.ForeColor = System.Drawing.Color.White;
            button2button_MoreBtn_Open_GitHub.Location = new System.Drawing.Point(1, 89);
            button2button_MoreBtn_Open_GitHub.Name = "button2button_MoreBtn_Open_GitHub";
            button2button_MoreBtn_Open_GitHub.Size = new System.Drawing.Size(198, 30);
            button2button_MoreBtn_Open_GitHub.TabIndex = 1;
            button2button_MoreBtn_Open_GitHub.Text = "Przejdź";
            button2button_MoreBtn_Open_GitHub.UseVisualStyleBackColor = false;
            button2button_MoreBtn_Open_GitHub.Click += Button2button_MoreBtn_Open_GitHub_Click;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Top;
            label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(1, 1);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(198, 32);
            label13.TabIndex = 0;
            label13.Text = "GitHub";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            panel16.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel16.Controls.Add(label14);
            panel16.Controls.Add(button7button2button_MoreBtn_Open_twojeanimepl);
            panel16.Controls.Add(label15);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new System.Drawing.Point(214, 134);
            panel16.Name = "panel16";
            panel16.Padding = new Padding(1);
            panel16.Size = new System.Drawing.Size(200, 120);
            panel16.TabIndex = 5;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Fill;
            label14.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.ForeColor = System.Drawing.Color.White;
            label14.Location = new System.Drawing.Point(1, 33);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(198, 56);
            label14.TabIndex = 2;
            label14.Text = "Strona internetowa Twojeanimepl";
            // 
            // button7button2button_MoreBtn_Open_twojeanimepl
            // 
            button7button2button_MoreBtn_Open_twojeanimepl.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            button7button2button_MoreBtn_Open_twojeanimepl.Dock = DockStyle.Bottom;
            button7button2button_MoreBtn_Open_twojeanimepl.FlatAppearance.BorderSize = 0;
            button7button2button_MoreBtn_Open_twojeanimepl.FlatStyle = FlatStyle.Flat;
            button7button2button_MoreBtn_Open_twojeanimepl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button7button2button_MoreBtn_Open_twojeanimepl.ForeColor = System.Drawing.Color.White;
            button7button2button_MoreBtn_Open_twojeanimepl.Location = new System.Drawing.Point(1, 89);
            button7button2button_MoreBtn_Open_twojeanimepl.Name = "button7button2button_MoreBtn_Open_twojeanimepl";
            button7button2button_MoreBtn_Open_twojeanimepl.Size = new System.Drawing.Size(198, 30);
            button7button2button_MoreBtn_Open_twojeanimepl.TabIndex = 1;
            button7button2button_MoreBtn_Open_twojeanimepl.Text = "Przejdź";
            button7button2button_MoreBtn_Open_twojeanimepl.UseVisualStyleBackColor = false;
            button7button2button_MoreBtn_Open_twojeanimepl.Click += Button7button2button_MoreBtn_Open_twojeanimepl_Click;
            // 
            // label15
            // 
            label15.Dock = DockStyle.Top;
            label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.ForeColor = System.Drawing.Color.White;
            label15.Location = new System.Drawing.Point(1, 1);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(198, 32);
            label15.TabIndex = 0;
            label15.Text = "Twojeanimepl";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            panel19.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel19.Controls.Add(label18);
            panel19.Controls.Add(button2);
            panel19.Controls.Add(label19);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new System.Drawing.Point(420, 134);
            panel19.Name = "panel19";
            panel19.Padding = new Padding(1);
            panel19.Size = new System.Drawing.Size(200, 120);
            panel19.TabIndex = 7;
            // 
            // label18
            // 
            label18.Dock = DockStyle.Fill;
            label18.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.ForeColor = System.Drawing.Color.White;
            label18.Location = new System.Drawing.Point(1, 33);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(198, 56);
            label18.TabIndex = 2;
            label18.Text = "Twórz tręsci dla tej aplikacji. Zestaw aplikacji dla ludzi którzy chcą pomoć w rozwijaniu player'a";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(1, 89);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(198, 30);
            button2.TabIndex = 1;
            button2.Text = "Przejdź";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // label19
            // 
            label19.Dock = DockStyle.Top;
            label19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label19.ForeColor = System.Drawing.Color.White;
            label19.Location = new System.Drawing.Point(1, 1);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(198, 32);
            label19.TabIndex = 0;
            label19.Text = "Narzędzia";
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            panel20.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            panel20.Controls.Add(label20);
            panel20.Controls.Add(buttonAllNewsContnet);
            panel20.Controls.Add(label21);
            panel20.Dock = DockStyle.Top;
            panel20.Location = new System.Drawing.Point(626, 134);
            panel20.Name = "panel20";
            panel20.Padding = new Padding(1);
            panel20.Size = new System.Drawing.Size(200, 120);
            panel20.TabIndex = 8;
            // 
            // label20
            // 
            label20.Dock = DockStyle.Fill;
            label20.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label20.ForeColor = System.Drawing.Color.White;
            label20.Location = new System.Drawing.Point(1, 33);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(198, 56);
            label20.TabIndex = 2;
            label20.Text = "Wiadmości itp.";
            // 
            // buttonAllNewsContnet
            // 
            buttonAllNewsContnet.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            buttonAllNewsContnet.Dock = DockStyle.Bottom;
            buttonAllNewsContnet.FlatAppearance.BorderSize = 0;
            buttonAllNewsContnet.FlatStyle = FlatStyle.Flat;
            buttonAllNewsContnet.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAllNewsContnet.ForeColor = System.Drawing.Color.White;
            buttonAllNewsContnet.Location = new System.Drawing.Point(1, 89);
            buttonAllNewsContnet.Name = "buttonAllNewsContnet";
            buttonAllNewsContnet.Size = new System.Drawing.Size(198, 30);
            buttonAllNewsContnet.TabIndex = 1;
            buttonAllNewsContnet.Text = "Przejdź";
            buttonAllNewsContnet.UseVisualStyleBackColor = false;
            buttonAllNewsContnet.Click += ButtonAllNewsContnet_Click;
            // 
            // label21
            // 
            label21.Dock = DockStyle.Top;
            label21.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label21.ForeColor = System.Drawing.Color.White;
            label21.Location = new System.Drawing.Point(1, 1);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(198, 32);
            label21.TabIndex = 0;
            label21.Text = "Aktualności";
            label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonCloseMoreButtons);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 10, 10, 0);
            panel6.Size = new System.Drawing.Size(1090, 38);
            panel6.TabIndex = 0;
            // 
            // buttonCloseMoreButtons
            // 
            buttonCloseMoreButtons.Dock = DockStyle.Right;
            buttonCloseMoreButtons.FlatStyle = FlatStyle.Flat;
            buttonCloseMoreButtons.ForeColor = System.Drawing.Color.Red;
            buttonCloseMoreButtons.Location = new System.Drawing.Point(1039, 10);
            buttonCloseMoreButtons.Margin = new Padding(4, 3, 4, 3);
            buttonCloseMoreButtons.MaximumSize = new System.Drawing.Size(41, 29);
            buttonCloseMoreButtons.Name = "buttonCloseMoreButtons";
            buttonCloseMoreButtons.Size = new System.Drawing.Size(41, 28);
            buttonCloseMoreButtons.TabIndex = 6;
            buttonCloseMoreButtons.Text = "X";
            buttonCloseMoreButtons.UseVisualStyleBackColor = true;
            buttonCloseMoreButtons.Click += ButtonCloseMoreButtons_Click;
            // 
            // panelAllitem
            // 
            panelAllitem.Controls.Add(flowLayoutPanelFinditem);
            panelAllitem.Controls.Add(flowLayoutPanelAll);
            panelAllitem.Controls.Add(panel23);
            panelAllitem.Controls.Add(panelTopFinder);
            panelAllitem.Dock = DockStyle.Fill;
            panelAllitem.Location = new System.Drawing.Point(0, 0);
            panelAllitem.Margin = new Padding(4, 3, 4, 3);
            panelAllitem.Name = "panelAllitem";
            panelAllitem.Size = new System.Drawing.Size(1090, 624);
            panelAllitem.TabIndex = 0;
            // 
            // flowLayoutPanelFinditem
            // 
            flowLayoutPanelFinditem.AutoScroll = true;
            flowLayoutPanelFinditem.Dock = DockStyle.Fill;
            flowLayoutPanelFinditem.Location = new System.Drawing.Point(0, 127);
            flowLayoutPanelFinditem.Name = "flowLayoutPanelFinditem";
            flowLayoutPanelFinditem.Padding = new Padding(12, 2, 12, 2);
            flowLayoutPanelFinditem.Size = new System.Drawing.Size(1090, 497);
            flowLayoutPanelFinditem.TabIndex = 0;
            // 
            // flowLayoutPanelAll
            // 
            flowLayoutPanelAll.AutoScroll = true;
            flowLayoutPanelAll.Dock = DockStyle.Fill;
            flowLayoutPanelAll.Location = new System.Drawing.Point(0, 127);
            flowLayoutPanelAll.Name = "flowLayoutPanelAll";
            flowLayoutPanelAll.Padding = new Padding(12, 2, 12, 2);
            flowLayoutPanelAll.Size = new System.Drawing.Size(1090, 497);
            flowLayoutPanelAll.TabIndex = 0;
            flowLayoutPanelAll.SizeChanged += flowLayoutPanelAll_SizeChanged;
            // 
            // panel23
            // 
            panel23.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            panel23.Controls.Add(panel24);
            panel23.Dock = DockStyle.Top;
            panel23.Location = new System.Drawing.Point(0, 100);
            panel23.Name = "panel23";
            panel23.Padding = new Padding(0, 0, 25, 0);
            panel23.Size = new System.Drawing.Size(1090, 27);
            panel23.TabIndex = 0;
            // 
            // panel24
            // 
            panel24.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            panel24.Controls.Add(comboBoxViewtype);
            panel24.Controls.Add(label24);
            panel24.Dock = DockStyle.Right;
            panel24.Location = new System.Drawing.Point(862, 0);
            panel24.Name = "panel24";
            panel24.Padding = new Padding(0, 2, 0, 0);
            panel24.Size = new System.Drawing.Size(203, 27);
            panel24.TabIndex = 0;
            // 
            // comboBoxViewtype
            // 
            comboBoxViewtype.BackColor = System.Drawing.Color.Black;
            comboBoxViewtype.Dock = DockStyle.Right;
            comboBoxViewtype.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxViewtype.FlatStyle = FlatStyle.Flat;
            comboBoxViewtype.ForeColor = System.Drawing.Color.White;
            comboBoxViewtype.FormattingEnabled = true;
            comboBoxViewtype.Items.AddRange(new object[] { "Siatka", "Lista" });
            comboBoxViewtype.Location = new System.Drawing.Point(82, 2);
            comboBoxViewtype.Name = "comboBoxViewtype";
            comboBoxViewtype.Size = new System.Drawing.Size(121, 23);
            comboBoxViewtype.TabIndex = 1;
            comboBoxViewtype.SelectedIndexChanged += comboBoxViewtype_SelectedIndexChanged;
            // 
            // label24
            // 
            label24.Dock = DockStyle.Left;
            label24.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label24.ForeColor = System.Drawing.Color.White;
            label24.Location = new System.Drawing.Point(0, 2);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(72, 25);
            label24.TabIndex = 0;
            label24.Text = "Widok";
            label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTopFinder
            // 
            panelTopFinder.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            panelTopFinder.Controls.Add(labelEnableFiltres);
            panelTopFinder.Controls.Add(roundedPanel2);
            panelTopFinder.Dock = DockStyle.Top;
            panelTopFinder.Location = new System.Drawing.Point(0, 0);
            panelTopFinder.Margin = new Padding(4, 3, 4, 3);
            panelTopFinder.Name = "panelTopFinder";
            panelTopFinder.Padding = new Padding(12);
            panelTopFinder.Size = new System.Drawing.Size(1090, 100);
            panelTopFinder.TabIndex = 0;
            // 
            // labelEnableFiltres
            // 
            labelEnableFiltres.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            labelEnableFiltres.Dock = DockStyle.Bottom;
            labelEnableFiltres.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEnableFiltres.ForeColor = System.Drawing.SystemColors.Window;
            labelEnableFiltres.Location = new System.Drawing.Point(12, 68);
            labelEnableFiltres.Margin = new Padding(4, 0, 4, 0);
            labelEnableFiltres.MaximumSize = new System.Drawing.Size(117, 35);
            labelEnableFiltres.Name = "labelEnableFiltres";
            labelEnableFiltres.Size = new System.Drawing.Size(117, 20);
            labelEnableFiltres.TabIndex = 6;
            labelEnableFiltres.Text = "Filtry włączone";
            labelEnableFiltres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelEnableFiltres.Visible = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            roundedPanel2.ColorEdges = System.Drawing.SystemColors.ActiveCaptionText;
            roundedPanel2.Controls.Add(labelFindSatus);
            roundedPanel2.Controls.Add(buttonfinditemReset);
            roundedPanel2.Controls.Add(buttonfinditemF);
            roundedPanel2.Controls.Add(buttonFindItem);
            roundedPanel2.Controls.Add(panel21);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(buttonFinditemPageClose);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.ExBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            roundedPanel2.Location = new System.Drawing.Point(12, 12);
            roundedPanel2.Margin = new Padding(4, 3, 4, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Padding = new Padding(12, 30, 12, 20);
            roundedPanel2.RadiusArcPanel = 20F;
            roundedPanel2.Size = new System.Drawing.Size(1066, 76);
            roundedPanel2.TabIndex = 0;
            // 
            // labelFindSatus
            // 
            labelFindSatus.Dock = DockStyle.Fill;
            labelFindSatus.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFindSatus.ForeColor = System.Drawing.Color.White;
            labelFindSatus.Location = new System.Drawing.Point(901, 30);
            labelFindSatus.Margin = new Padding(4, 0, 4, 0);
            labelFindSatus.Name = "labelFindSatus";
            labelFindSatus.Size = new System.Drawing.Size(61, 26);
            labelFindSatus.TabIndex = 4;
            labelFindSatus.Text = "Szukanie";
            labelFindSatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelFindSatus.Visible = false;
            // 
            // buttonfinditemReset
            // 
            buttonfinditemReset.Dock = DockStyle.Left;
            buttonfinditemReset.FlatAppearance.BorderSize = 0;
            buttonfinditemReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            buttonfinditemReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            buttonfinditemReset.FlatStyle = FlatStyle.Flat;
            buttonfinditemReset.ForeColor = System.Drawing.Color.White;
            buttonfinditemReset.Location = new System.Drawing.Point(813, 30);
            buttonfinditemReset.Margin = new Padding(4, 3, 4, 3);
            buttonfinditemReset.Name = "buttonfinditemReset";
            buttonfinditemReset.Size = new System.Drawing.Size(88, 26);
            buttonfinditemReset.TabIndex = 3;
            buttonfinditemReset.Text = "Reset";
            buttonfinditemReset.UseVisualStyleBackColor = true;
            buttonfinditemReset.Click += ButtonfinditemReset_Click;
            // 
            // buttonfinditemF
            // 
            buttonfinditemF.Dock = DockStyle.Left;
            buttonfinditemF.FlatAppearance.BorderSize = 0;
            buttonfinditemF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            buttonfinditemF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            buttonfinditemF.FlatStyle = FlatStyle.Flat;
            buttonfinditemF.ForeColor = System.Drawing.Color.White;
            buttonfinditemF.Location = new System.Drawing.Point(744, 30);
            buttonfinditemF.Margin = new Padding(4, 3, 4, 3);
            buttonfinditemF.Name = "buttonfinditemF";
            buttonfinditemF.Size = new System.Drawing.Size(69, 26);
            buttonfinditemF.TabIndex = 6;
            buttonfinditemF.Text = "Filtry";
            buttonfinditemF.UseVisualStyleBackColor = true;
            buttonfinditemF.Visible = false;
            buttonfinditemF.Click += ButtonfinditemF_Click;
            // 
            // buttonFindItem
            // 
            buttonFindItem.Dock = DockStyle.Left;
            buttonFindItem.FlatAppearance.BorderSize = 0;
            buttonFindItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            buttonFindItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            buttonFindItem.FlatStyle = FlatStyle.Flat;
            buttonFindItem.ForeColor = System.Drawing.Color.White;
            buttonFindItem.Location = new System.Drawing.Point(656, 30);
            buttonFindItem.Margin = new Padding(4, 3, 4, 3);
            buttonFindItem.Name = "buttonFindItem";
            buttonFindItem.Size = new System.Drawing.Size(88, 26);
            buttonFindItem.TabIndex = 2;
            buttonFindItem.Text = "Szukaj";
            buttonFindItem.UseVisualStyleBackColor = true;
            buttonFindItem.Click += ButtonFindItem_Click;
            // 
            // panel21
            // 
            panel21.Controls.Add(textBoxFinditem);
            panel21.Dock = DockStyle.Left;
            panel21.Location = new System.Drawing.Point(216, 30);
            panel21.Name = "panel21";
            panel21.Padding = new Padding(0, 0, 0, 5);
            panel21.Size = new System.Drawing.Size(440, 26);
            panel21.TabIndex = 7;
            // 
            // textBoxFinditem
            // 
            textBoxFinditem.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFinditem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxFinditem.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            textBoxFinditem.BorderStyle = BorderStyle.None;
            textBoxFinditem.Dock = DockStyle.Bottom;
            textBoxFinditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxFinditem.ForeColor = System.Drawing.Color.White;
            textBoxFinditem.Location = new System.Drawing.Point(0, 5);
            textBoxFinditem.Margin = new Padding(4, 3, 4, 3);
            textBoxFinditem.Name = "textBoxFinditem";
            textBoxFinditem.PlaceholderText = "Szukaj";
            textBoxFinditem.Size = new System.Drawing.Size(440, 16);
            textBoxFinditem.TabIndex = 1;
            textBoxFinditem.TextAlign = HorizontalAlignment.Center;
            textBoxFinditem.TextChanged += TextBoxFinditem_TextChanged;
            textBoxFinditem.KeyDown += TextBoxFinditem_KeyDown;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.Window;
            label4.Location = new System.Drawing.Point(12, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(204, 26);
            label4.TabIndex = 5;
            label4.Text = "AnimePlayer - Wyszukiwarka";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFinditemPageClose
            // 
            buttonFinditemPageClose.BackColor = System.Drawing.Color.Transparent;
            buttonFinditemPageClose.Dock = DockStyle.Right;
            buttonFinditemPageClose.FlatAppearance.BorderSize = 0;
            buttonFinditemPageClose.FlatStyle = FlatStyle.Flat;
            buttonFinditemPageClose.ForeColor = System.Drawing.Color.Red;
            buttonFinditemPageClose.Location = new System.Drawing.Point(962, 30);
            buttonFinditemPageClose.Margin = new Padding(4, 3, 4, 3);
            buttonFinditemPageClose.Name = "buttonFinditemPageClose";
            buttonFinditemPageClose.Size = new System.Drawing.Size(92, 26);
            buttonFinditemPageClose.TabIndex = 0;
            buttonFinditemPageClose.Text = "Zamknij kartę";
            buttonFinditemPageClose.UseVisualStyleBackColor = false;
            buttonFinditemPageClose.Click += ButtonFinditemPageClose_Click;
            // 
            // panelNotifiError
            // 
            panelNotifiError.Controls.Add(labelError);
            panelNotifiError.Controls.Add(pictureBox3);
            panelNotifiError.Location = new System.Drawing.Point(0, 0);
            panelNotifiError.Margin = new Padding(4, 3, 4, 3);
            panelNotifiError.Name = "panelNotifiError";
            panelNotifiError.Size = new System.Drawing.Size(233, 59);
            panelNotifiError.TabIndex = 6;
            // 
            // labelError
            // 
            labelError.AutoEllipsis = true;
            labelError.Dock = DockStyle.Fill;
            labelError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelError.ForeColor = System.Drawing.Color.Red;
            labelError.Location = new System.Drawing.Point(66, 0);
            labelError.Margin = new Padding(4, 0, 4, 0);
            labelError.Name = "labelError";
            labelError.Size = new System.Drawing.Size(167, 59);
            labelError.TabIndex = 1;
            labelError.Text = "Error code:";
            labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Location = new System.Drawing.Point(0, 0);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(66, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // timerAnimationError
            // 
            timerAnimationError.Interval = 1;
            timerAnimationError.Tick += TimerAnimationError_Tick;
            // 
            // timerAppPer
            // 
            timerAppPer.Interval = 1000;
            timerAppPer.Tick += TimerAppPer_Tick;
            // 
            // panel18
            // 
            panel18.Controls.Add(labelAppRamUsage);
            panel18.Location = new System.Drawing.Point(0, 0);
            panel18.Name = "panel18";
            panel18.Size = new System.Drawing.Size(170, 35);
            panel18.TabIndex = 7;
            panel18.Visible = false;
            // 
            // labelAppRamUsage
            // 
            labelAppRamUsage.AutoSize = true;
            labelAppRamUsage.ForeColor = System.Drawing.Color.White;
            labelAppRamUsage.Location = new System.Drawing.Point(3, 12);
            labelAppRamUsage.Name = "labelAppRamUsage";
            labelAppRamUsage.Size = new System.Drawing.Size(110, 15);
            labelAppRamUsage.TabIndex = 0;
            labelAppRamUsage.Text = "labelAppRamUsage";
            // 
            // panelCommands
            // 
            panelCommands.Controls.Add(textBoxCommandOutput);
            panelCommands.Controls.Add(textBoxCommandInput);
            panelCommands.Controls.Add(label22);
            panelCommands.Location = new System.Drawing.Point(355, 216);
            panelCommands.Name = "panelCommands";
            panelCommands.Size = new System.Drawing.Size(357, 133);
            panelCommands.TabIndex = 8;
            panelCommands.Visible = false;
            // 
            // textBoxCommandOutput
            // 
            textBoxCommandOutput.BackColor = System.Drawing.Color.Black;
            textBoxCommandOutput.BorderStyle = BorderStyle.None;
            textBoxCommandOutput.ForeColor = System.Drawing.Color.White;
            textBoxCommandOutput.Location = new System.Drawing.Point(11, 27);
            textBoxCommandOutput.Multiline = true;
            textBoxCommandOutput.Name = "textBoxCommandOutput";
            textBoxCommandOutput.ReadOnly = true;
            textBoxCommandOutput.Size = new System.Drawing.Size(340, 65);
            textBoxCommandOutput.TabIndex = 2;
            // 
            // textBoxCommandInput
            // 
            textBoxCommandInput.AutoCompleteCustomSource.AddRange(new string[] { "videoplayerweb open loaclfile type youtube;" });
            textBoxCommandInput.AutoCompleteMode = AutoCompleteMode.Append;
            textBoxCommandInput.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxCommandInput.BackColor = System.Drawing.Color.Black;
            textBoxCommandInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxCommandInput.ForeColor = System.Drawing.Color.White;
            textBoxCommandInput.Location = new System.Drawing.Point(11, 101);
            textBoxCommandInput.Name = "textBoxCommandInput";
            textBoxCommandInput.Size = new System.Drawing.Size(340, 23);
            textBoxCommandInput.TabIndex = 1;
            textBoxCommandInput.KeyDown += TextBoxCommandInput_KeyDown;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = System.Drawing.Color.White;
            label22.Location = new System.Drawing.Point(11, 9);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(94, 15);
            label22.TabIndex = 0;
            label22.Text = "Konsola poleceń";
            // 
            // FormMainPlayer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            ClientSize = new System.Drawing.Size(1090, 624);
            Controls.Add(panel18);
            Controls.Add(panel2);
            Controls.Add(panelCommands);
            Controls.Add(panelMenu);
            Controls.Add(panelNotifiError);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1106, 629);
            Name = "FormMainPlayer";
            Text = "AnimePlayer";
            FormClosing += FormMainPlayer_FormClosing;
            Load += FormMainPlayer_Load;
            ResizeBegin += FormMainPlayer_ResizeBegin;
            ResizeEnd += FormMainPlayer_ResizeEnd;
            SizeChanged += FormMainPlayer_SizeChanged;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            Resize += FormMainPlayer_Resize;
            panelStartPage.ResumeLayout(false);
            panelSTNewsMain.ResumeLayout(false);
            panelSTNewsMain.PerformLayout();
            panelTop.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileIcon).EndInit();
            panelLoading.ResumeLayout(false);
            panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            panelMenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGithub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSite).EndInit();
            panel2.ResumeLayout(false);
            panelMoreButtons.ResumeLayout(false);
            panel10.ResumeLayout(false);
            newFlowLayoutPanel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panelAllitem.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panelTopFinder.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panelNotifiError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panelCommands.ResumeLayout(false);
            panelCommands.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private Panel panelTop;
        private RoundedPanel roundedPanel1;
        private Label label;
        public Panel panelLoading;
        private Button buttonMenuClose;
        private Button buttonPlayer;
        private Button buttonSetting;
        public Panel panel2;
        private Button buttonExitApp;
        private Panel panelNotifiError;
        private PictureBox pictureBox3;
        public Label labelError;
        public Timer timerAnimationError;
        public Label labelSatusWorkingApp;
        private Panel panel5;
        private PictureBox pictureBoxGithub;
        private PictureBox pictureBoxSite;
        private Button buttonSite;
        private Panel panel7;
        private Panel panel8;
        private Button buttonViewFindintems;
        public Label labelLoading;
        private Button buttonRestartApp;
        public Panel panelMenu;
        public Label labelLoadingDetails;
        public Panel panelStartPage;
        public Label labelLoadingA;
        public PictureBox pictureBoxLoading;
        private Panel panelSTNewsMain;
        public TextBox textBoxStartPagefinditem;
        private Panel panel9;
        public Button buttonStartPageFinditem;
        public Button buttonMenuOpen;
        public RoundedPanel roundedPanel2;
        public Panel panelTopFinder;
        public Label labelEnableFiltres;
        public Button buttonFinditemPageClose;
        public Button buttonFindItem;
        public TextBox textBoxFinditem;
        public Button buttonfinditemReset;
        public Label labelFindSatus;
        public Label label4;
        public Button buttonfinditemF;
        public Panel panelAllitem;
        private Button buttonShowTitleStatusList;
        private ToolTip toolTip;
        private Label label1;
        private Label label_InfoText_news;
        private Button buttonMoreBtnMenu;
        private Panel panelSep;
        private Panel panelMoreButtons;
        private Panel panel6;
        private Panel panel10;
        private NewFlowLayoutPanel newFlowLayoutPanel1;
        private Panel panel11;
        private Label label5;
        private Button button_MoreBtn_Open_Settings;
        private Panel panel12;
        private Label label6;
        private Button button2button_MoreBtn_Open_Player;
        private Label label7;
        private Panel panel13;
        private Label label8;
        private Button button4button2button_MoreBtn_Open_FindItem;
        private Label label9;
        private Panel panel14;
        private Label label10;
        private Button button5button2button_MoreBtn_Open_Lists;
        private Label label11;
        private Panel panel15;
        private Label label12;
        private Button button2button_MoreBtn_Open_GitHub;
        private Label label13;
        private Panel panel16;
        private Label label14;
        private Button button7button2button_MoreBtn_Open_twojeanimepl;
        private Label label15;
        private Button buttonCloseMoreButtons;
        private Panel panel17;
        private Label label16;
        private Button buttonCommunity;
        private Label label17;
        private Timer timerAppPer;
        private Panel panel18;
        public Label labelAppRamUsage;
        private Panel panel19;
        private Label label18;
        private Button button2;
        private Label label19;
        private Panel panel20;
        private Label label20;
        private Button buttonAllNewsContnet;
        private Label label21;
        private Panel panelCommands;
        private TextBox textBoxCommandOutput;
        private TextBox textBoxCommandInput;
        public Label label22;
        private Panel panel21;
        private Button buttonDefined;
        private Button buttonHomePage;
        public NewFlowLayoutPanel flowLayoutPanelFinditem;
        private Panel panel22;
        private PictureBox pictureBoxProfileIcon;
        private Label label23;
        private Button buttonHelp;
        private Panel panel23;
        private Panel panel24;
        private ComboBox comboBoxViewtype;
        private Label label24;
        private Timer timerFindWaitnig;
        public NewFlowLayoutPanel flowLayoutPanelAll;
    }
}
