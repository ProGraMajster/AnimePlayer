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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPlayer));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelStartPage = new System.Windows.Forms.Panel();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panePolecane = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPolecane = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSTNewsMain = new System.Windows.Forms.Panel();
            this.label_InfoText_news = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new AnimePlayerLibrary.RoundedPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxStartPagefinditem = new System.Windows.Forms.TextBox();
            this.buttonStartPageFinditem = new System.Windows.Forms.Button();
            this.labelSatusWorkingApp = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonMenuOpen = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.labelLoadingA = new System.Windows.Forms.Label();
            this.labelLoadingDetails = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxGithub = new System.Windows.Forms.PictureBox();
            this.pictureBoxSite = new System.Windows.Forms.PictureBox();
            this.buttonSite = new System.Windows.Forms.Button();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.buttonRestartApp = new System.Windows.Forms.Button();
            this.panelSep = new System.Windows.Forms.Panel();
            this.buttonMoreBtnMenu = new System.Windows.Forms.Button();
            this.buttonShowTitleStatusList = new System.Windows.Forms.Button();
            this.buttonDefined = new System.Windows.Forms.Button();
            this.buttonViewFindintems = new System.Windows.Forms.Button();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonHomePage = new System.Windows.Forms.Button();
            this.buttonMenuClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMoreButtons = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.newFlowLayoutPanel1 = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button_MoreBtn_Open_Settings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2button_MoreBtn_Open_Player = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button4button2button_MoreBtn_Open_FindItem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button5button2button_MoreBtn_Open_Lists = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonCommunity = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button2button_MoreBtn_Open_GitHub = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button7button2button_MoreBtn_Open_twojeanimepl = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonAllNewsContnet = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonCloseMoreButtons = new System.Windows.Forms.Button();
            this.panelAllitem = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFinditem = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.flowLayoutPanelAll = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panelTopFinder = new System.Windows.Forms.Panel();
            this.labelEnableFiltres = new System.Windows.Forms.Label();
            this.roundedPanel2 = new AnimePlayerLibrary.RoundedPanel();
            this.labelFindSatus = new System.Windows.Forms.Label();
            this.buttonfinditemReset = new System.Windows.Forms.Button();
            this.buttonfinditemF = new System.Windows.Forms.Button();
            this.buttonFindItem = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.textBoxFinditem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFinditemPageClose = new System.Windows.Forms.Button();
            this.panelNotifiError = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerAnimationError = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerGetSTNews = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerAppPer = new System.Windows.Forms.Timer(this.components);
            this.panel18 = new System.Windows.Forms.Panel();
            this.labelAppRamUsage = new System.Windows.Forms.Label();
            this.backgroundWorkerLoadItems = new System.ComponentModel.BackgroundWorker();
            this.panelCommands = new System.Windows.Forms.Panel();
            this.textBoxCommandOutput = new System.Windows.Forms.TextBox();
            this.textBoxCommandInput = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panelStartPage.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panePolecane.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSTNewsMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSite)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMoreButtons.SuspendLayout();
            this.panel10.SuspendLayout();
            this.newFlowLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelAllitem.SuspendLayout();
            this.panelTopFinder.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panelNotifiError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel18.SuspendLayout();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "WMP_OverlayApp";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // panelStartPage
            // 
            this.panelStartPage.AutoScroll = true;
            this.panelStartPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelStartPage.Controls.Add(this.panelGroup);
            this.panelStartPage.Controls.Add(this.panePolecane);
            this.panelStartPage.Controls.Add(this.panelSTNewsMain);
            this.panelStartPage.Controls.Add(this.panel8);
            this.panelStartPage.Controls.Add(this.panelTop);
            this.panelStartPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStartPage.Location = new System.Drawing.Point(0, 0);
            this.panelStartPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelStartPage.Name = "panelStartPage";
            this.panelStartPage.Size = new System.Drawing.Size(1090, 624);
            this.panelStartPage.TabIndex = 6;
            this.panelStartPage.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelStartPage_ControlAdded);
            // 
            // panelGroup
            // 
            this.panelGroup.Controls.Add(this.flowLayoutPanel2);
            this.panelGroup.Controls.Add(this.panel4);
            this.panelGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGroup.Location = new System.Drawing.Point(0, 881);
            this.panelGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(1073, 342);
            this.panelGroup.TabIndex = 4;
            this.panelGroup.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1073, 307);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(16, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 278);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Location = new System.Drawing.Point(0, 230);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 48);
            this.button3.TabIndex = 1;
            this.button3.Text = "Name";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panel4.Size = new System.Drawing.Size(1073, 35);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "TitleGroup";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panePolecane
            // 
            this.panePolecane.Controls.Add(this.flowLayoutPanelPolecane);
            this.panePolecane.Controls.Add(this.panel1);
            this.panePolecane.Dock = System.Windows.Forms.DockStyle.Top;
            this.panePolecane.Location = new System.Drawing.Point(0, 539);
            this.panePolecane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panePolecane.Name = "panePolecane";
            this.panePolecane.Size = new System.Drawing.Size(1073, 342);
            this.panePolecane.TabIndex = 3;
            // 
            // flowLayoutPanelPolecane
            // 
            this.flowLayoutPanelPolecane.AutoScroll = true;
            this.flowLayoutPanelPolecane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanelPolecane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPolecane.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanelPolecane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanelPolecane.Name = "flowLayoutPanelPolecane";
            this.flowLayoutPanelPolecane.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelPolecane.Size = new System.Drawing.Size(1073, 307);
            this.flowLayoutPanelPolecane.TabIndex = 5;
            this.flowLayoutPanelPolecane.WrapContents = false;
            this.flowLayoutPanelPolecane.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanelControlAdded);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panel1.Size = new System.Drawing.Size(1073, 35);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Polecane";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSTNewsMain
            // 
            this.panelSTNewsMain.Controls.Add(this.label_InfoText_news);
            this.panelSTNewsMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSTNewsMain.Location = new System.Drawing.Point(0, 130);
            this.panelSTNewsMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSTNewsMain.Name = "panelSTNewsMain";
            this.panelSTNewsMain.Size = new System.Drawing.Size(1073, 409);
            this.panelSTNewsMain.TabIndex = 4;
            // 
            // label_InfoText_news
            // 
            this.label_InfoText_news.AutoSize = true;
            this.label_InfoText_news.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_InfoText_news.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_InfoText_news.ForeColor = System.Drawing.Color.White;
            this.label_InfoText_news.Location = new System.Drawing.Point(0, 0);
            this.label_InfoText_news.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_InfoText_news.Name = "label_InfoText_news";
            this.label_InfoText_news.Size = new System.Drawing.Size(117, 28);
            this.label_InfoText_news.TabIndex = 1;
            this.label_InfoText_news.Text = "Aktualności";
            this.label_InfoText_news.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 105);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1073, 25);
            this.panel8.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.roundedPanel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(12);
            this.panelTop.Size = new System.Drawing.Size(1073, 105);
            this.panelTop.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.ColorEdges = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundedPanel1.Controls.Add(this.panel7);
            this.roundedPanel1.Controls.Add(this.labelSatusWorkingApp);
            this.roundedPanel1.Controls.Add(this.buttonProfile);
            this.roundedPanel1.Controls.Add(this.buttonMenuOpen);
            this.roundedPanel1.Controls.Add(this.label);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.ExBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.roundedPanel1.Location = new System.Drawing.Point(12, 12);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(12);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(23, 7, 23, 7);
            this.roundedPanel1.RadiusArcPanel = 15F;
            this.roundedPanel1.Size = new System.Drawing.Size(1049, 81);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Resize += new System.EventHandler(this.Panel_Resize);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.buttonStartPageFinditem);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel7.Location = new System.Drawing.Point(221, 7);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(6, 23, 6, 17);
            this.panel7.Size = new System.Drawing.Size(584, 67);
            this.panel7.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBoxStartPagefinditem);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(6, 23);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panel9.Size = new System.Drawing.Size(484, 27);
            this.panel9.TabIndex = 5;
            // 
            // textBoxStartPagefinditem
            // 
            this.textBoxStartPagefinditem.AutoCompleteCustomSource.AddRange(new string[] {
            "TEST"});
            this.textBoxStartPagefinditem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxStartPagefinditem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxStartPagefinditem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxStartPagefinditem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartPagefinditem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStartPagefinditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStartPagefinditem.ForeColor = System.Drawing.Color.White;
            this.textBoxStartPagefinditem.Location = new System.Drawing.Point(0, 6);
            this.textBoxStartPagefinditem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStartPagefinditem.Name = "textBoxStartPagefinditem";
            this.textBoxStartPagefinditem.Size = new System.Drawing.Size(484, 16);
            this.textBoxStartPagefinditem.TabIndex = 3;
            this.textBoxStartPagefinditem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStartPagefinditem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSPfinditem_KeyDown);
            // 
            // buttonStartPageFinditem
            // 
            this.buttonStartPageFinditem.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartPageFinditem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStartPageFinditem.FlatAppearance.BorderSize = 0;
            this.buttonStartPageFinditem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonStartPageFinditem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonStartPageFinditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartPageFinditem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartPageFinditem.ForeColor = System.Drawing.Color.White;
            this.buttonStartPageFinditem.Location = new System.Drawing.Point(490, 23);
            this.buttonStartPageFinditem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStartPageFinditem.Name = "buttonStartPageFinditem";
            this.buttonStartPageFinditem.Size = new System.Drawing.Size(88, 27);
            this.buttonStartPageFinditem.TabIndex = 4;
            this.buttonStartPageFinditem.Text = "Szukaj";
            this.buttonStartPageFinditem.UseVisualStyleBackColor = false;
            this.buttonStartPageFinditem.Click += new System.EventHandler(this.ButtonStartPageFinditem_Click);
            // 
            // labelSatusWorkingApp
            // 
            this.labelSatusWorkingApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSatusWorkingApp.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSatusWorkingApp.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSatusWorkingApp.Location = new System.Drawing.Point(805, 7);
            this.labelSatusWorkingApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSatusWorkingApp.Name = "labelSatusWorkingApp";
            this.labelSatusWorkingApp.Size = new System.Drawing.Size(77, 67);
            this.labelSatusWorkingApp.TabIndex = 2;
            this.labelSatusWorkingApp.Text = "Satus działania:";
            this.labelSatusWorkingApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSatusWorkingApp.Visible = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Location = new System.Drawing.Point(882, 7);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(61, 67);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profil";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Visible = false;
            this.buttonProfile.Click += new System.EventHandler(this.ButtonProfile_Click);
            // 
            // buttonMenuOpen
            // 
            this.buttonMenuOpen.BackgroundImage = global::AnimePlayer.Properties.Resources.white_menu_icon_12;
            this.buttonMenuOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenuOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMenuOpen.FlatAppearance.BorderSize = 0;
            this.buttonMenuOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonMenuOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonMenuOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuOpen.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMenuOpen.ForeColor = System.Drawing.Color.White;
            this.buttonMenuOpen.Location = new System.Drawing.Point(943, 7);
            this.buttonMenuOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMenuOpen.Name = "buttonMenuOpen";
            this.buttonMenuOpen.Size = new System.Drawing.Size(83, 67);
            this.buttonMenuOpen.TabIndex = 1;
            this.buttonMenuOpen.UseVisualStyleBackColor = true;
            this.buttonMenuOpen.Click += new System.EventHandler(this.ButtonMenuOpen_Click);
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Left;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.Window;
            this.label.Location = new System.Drawing.Point(23, 7);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(198, 67);
            this.label.TabIndex = 0;
            this.label.Text = "Anime Player";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLoading
            // 
            this.panelLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLoading.Controls.Add(this.labelLoadingA);
            this.panelLoading.Controls.Add(this.labelLoadingDetails);
            this.panelLoading.Controls.Add(this.labelLoading);
            this.panelLoading.Controls.Add(this.pictureBoxLoading);
            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.Location = new System.Drawing.Point(0, 0);
            this.panelLoading.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(1090, 624);
            this.panelLoading.TabIndex = 2;
            this.panelLoading.VisibleChanged += new System.EventHandler(this.PanelLoading_VisibleChanged);
            // 
            // labelLoadingA
            // 
            this.labelLoadingA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.labelLoadingA.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLoadingA.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoadingA.ForeColor = System.Drawing.Color.White;
            this.labelLoadingA.Location = new System.Drawing.Point(0, 0);
            this.labelLoadingA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadingA.Name = "labelLoadingA";
            this.labelLoadingA.Size = new System.Drawing.Size(1090, 32);
            this.labelLoadingA.TabIndex = 2;
            this.labelLoadingA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadingDetails
            // 
            this.labelLoadingDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.labelLoadingDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelLoadingDetails.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoadingDetails.ForeColor = System.Drawing.Color.White;
            this.labelLoadingDetails.Location = new System.Drawing.Point(0, 592);
            this.labelLoadingDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadingDetails.Name = "labelLoadingDetails";
            this.labelLoadingDetails.Size = new System.Drawing.Size(1090, 32);
            this.labelLoadingDetails.TabIndex = 1;
            this.labelLoadingDetails.Text = ":";
            this.labelLoadingDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.labelLoading.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoading.ForeColor = System.Drawing.Color.White;
            this.labelLoading.Location = new System.Drawing.Point(467, 286);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(145, 38);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "Ładowanie";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLoading.VisibleChanged += new System.EventHandler(this.LabelLoading_VisibleChanged);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLoading.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLoading.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(1090, 624);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoading.TabIndex = 3;
            this.pictureBoxLoading.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.buttonExitApp);
            this.panelMenu.Controls.Add(this.buttonRestartApp);
            this.panelMenu.Controls.Add(this.panelSep);
            this.panelMenu.Controls.Add(this.buttonMoreBtnMenu);
            this.panelMenu.Controls.Add(this.buttonShowTitleStatusList);
            this.panelMenu.Controls.Add(this.buttonDefined);
            this.panelMenu.Controls.Add(this.buttonViewFindintems);
            this.panelMenu.Controls.Add(this.buttonPlayer);
            this.panelMenu.Controls.Add(this.buttonSetting);
            this.panelMenu.Controls.Add(this.buttonHomePage);
            this.panelMenu.Controls.Add(this.buttonMenuClose);
            this.panelMenu.Location = new System.Drawing.Point(875, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(12);
            this.panelMenu.Size = new System.Drawing.Size(233, 624);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBoxGithub);
            this.panel5.Controls.Add(this.pictureBoxSite);
            this.panel5.Controls.Add(this.buttonSite);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(12, 566);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 46);
            this.panel5.TabIndex = 4;
            // 
            // pictureBoxGithub
            // 
            this.pictureBoxGithub.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxGithub.Image = global::AnimePlayer.Properties.Resources.GitHub_Mark_Light_120px_plus;
            this.pictureBoxGithub.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGithub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxGithub.Name = "pictureBoxGithub";
            this.pictureBoxGithub.Size = new System.Drawing.Size(47, 46);
            this.pictureBoxGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGithub.TabIndex = 0;
            this.pictureBoxGithub.TabStop = false;
            this.pictureBoxGithub.Click += new System.EventHandler(this.PictureBoxGithub_Click);
            // 
            // pictureBoxSite
            // 
            this.pictureBoxSite.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxSite.Image = global::AnimePlayer.Properties.Resources.siteIcon;
            this.pictureBoxSite.Location = new System.Drawing.Point(68, 0);
            this.pictureBoxSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxSite.Name = "pictureBoxSite";
            this.pictureBoxSite.Size = new System.Drawing.Size(47, 46);
            this.pictureBoxSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSite.TabIndex = 2;
            this.pictureBoxSite.TabStop = false;
            this.pictureBoxSite.Click += new System.EventHandler(this.PictureBoxSite_Click);
            // 
            // buttonSite
            // 
            this.buttonSite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSite.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSite.FlatAppearance.BorderSize = 0;
            this.buttonSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSite.ForeColor = System.Drawing.Color.White;
            this.buttonSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSite.Location = new System.Drawing.Point(115, 0);
            this.buttonSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSite.Name = "buttonSite";
            this.buttonSite.Size = new System.Drawing.Size(94, 46);
            this.buttonSite.TabIndex = 4;
            this.buttonSite.Text = "Twojanimepl";
            this.buttonSite.UseVisualStyleBackColor = true;
            this.buttonSite.Click += new System.EventHandler(this.ButtonSite_Click);
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExitApp.FlatAppearance.BorderSize = 0;
            this.buttonExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitApp.ForeColor = System.Drawing.Color.White;
            this.buttonExitApp.Location = new System.Drawing.Point(12, 417);
            this.buttonExitApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(209, 46);
            this.buttonExitApp.TabIndex = 3;
            this.buttonExitApp.Text = "Zamknij aplikacje";
            this.buttonExitApp.UseVisualStyleBackColor = true;
            this.buttonExitApp.Click += new System.EventHandler(this.ButtonExitApp_Click);
            // 
            // buttonRestartApp
            // 
            this.buttonRestartApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRestartApp.FlatAppearance.BorderSize = 0;
            this.buttonRestartApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestartApp.ForeColor = System.Drawing.Color.White;
            this.buttonRestartApp.Location = new System.Drawing.Point(12, 371);
            this.buttonRestartApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRestartApp.Name = "buttonRestartApp";
            this.buttonRestartApp.Size = new System.Drawing.Size(209, 46);
            this.buttonRestartApp.TabIndex = 6;
            this.buttonRestartApp.Text = "Zrestartuj aplikacjie";
            this.buttonRestartApp.UseVisualStyleBackColor = true;
            this.buttonRestartApp.Click += new System.EventHandler(this.ButtonRestartApp_Click);
            // 
            // panelSep
            // 
            this.panelSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSep.Location = new System.Drawing.Point(12, 366);
            this.panelSep.Name = "panelSep";
            this.panelSep.Size = new System.Drawing.Size(209, 5);
            this.panelSep.TabIndex = 9;
            // 
            // buttonMoreBtnMenu
            // 
            this.buttonMoreBtnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMoreBtnMenu.FlatAppearance.BorderSize = 0;
            this.buttonMoreBtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoreBtnMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMoreBtnMenu.Location = new System.Drawing.Point(12, 320);
            this.buttonMoreBtnMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMoreBtnMenu.Name = "buttonMoreBtnMenu";
            this.buttonMoreBtnMenu.Size = new System.Drawing.Size(209, 46);
            this.buttonMoreBtnMenu.TabIndex = 8;
            this.buttonMoreBtnMenu.Text = "Więcej..";
            this.toolTip.SetToolTip(this.buttonMoreBtnMenu, "Statusy: Oglądam, Planeuj,, Wstrzymane itp.");
            this.buttonMoreBtnMenu.UseVisualStyleBackColor = true;
            this.buttonMoreBtnMenu.Click += new System.EventHandler(this.ButtonMoreBtnMenu_Click);
            // 
            // buttonShowTitleStatusList
            // 
            this.buttonShowTitleStatusList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowTitleStatusList.FlatAppearance.BorderSize = 0;
            this.buttonShowTitleStatusList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowTitleStatusList.ForeColor = System.Drawing.Color.White;
            this.buttonShowTitleStatusList.Location = new System.Drawing.Point(12, 274);
            this.buttonShowTitleStatusList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonShowTitleStatusList.Name = "buttonShowTitleStatusList";
            this.buttonShowTitleStatusList.Size = new System.Drawing.Size(209, 46);
            this.buttonShowTitleStatusList.TabIndex = 7;
            this.buttonShowTitleStatusList.Text = "Listy anime";
            this.toolTip.SetToolTip(this.buttonShowTitleStatusList, "Statusy: Oglądam, Planeuj,, Wstrzymane itp.");
            this.buttonShowTitleStatusList.UseVisualStyleBackColor = true;
            this.buttonShowTitleStatusList.Visible = false;
            this.buttonShowTitleStatusList.Click += new System.EventHandler(this.ButtonShowTitleStatusList_Click);
            // 
            // buttonDefined
            // 
            this.buttonDefined.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDefined.FlatAppearance.BorderSize = 0;
            this.buttonDefined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefined.ForeColor = System.Drawing.Color.White;
            this.buttonDefined.Location = new System.Drawing.Point(12, 228);
            this.buttonDefined.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDefined.Name = "buttonDefined";
            this.buttonDefined.Size = new System.Drawing.Size(209, 46);
            this.buttonDefined.TabIndex = 10;
            this.buttonDefined.Text = "Definicje";
            this.toolTip.SetToolTip(this.buttonDefined, "Definicje tagów");
            this.buttonDefined.UseVisualStyleBackColor = true;
            this.buttonDefined.Click += new System.EventHandler(this.ButtonDefined_Click);
            // 
            // buttonViewFindintems
            // 
            this.buttonViewFindintems.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonViewFindintems.FlatAppearance.BorderSize = 0;
            this.buttonViewFindintems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewFindintems.ForeColor = System.Drawing.Color.White;
            this.buttonViewFindintems.Location = new System.Drawing.Point(12, 182);
            this.buttonViewFindintems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonViewFindintems.Name = "buttonViewFindintems";
            this.buttonViewFindintems.Size = new System.Drawing.Size(209, 46);
            this.buttonViewFindintems.TabIndex = 5;
            this.buttonViewFindintems.Text = "Wyszukiwarka";
            this.buttonViewFindintems.UseVisualStyleBackColor = true;
            this.buttonViewFindintems.Click += new System.EventHandler(this.ButtonViewFindintems_Click);
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlayer.FlatAppearance.BorderSize = 0;
            this.buttonPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayer.ForeColor = System.Drawing.Color.White;
            this.buttonPlayer.Location = new System.Drawing.Point(12, 136);
            this.buttonPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(209, 46);
            this.buttonPlayer.TabIndex = 2;
            this.buttonPlayer.Text = "Odtwarzacz";
            this.buttonPlayer.UseVisualStyleBackColor = true;
            this.buttonPlayer.Click += new System.EventHandler(this.ButtonPlayer_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.Location = new System.Drawing.Point(12, 90);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(209, 46);
            this.buttonSetting.TabIndex = 1;
            this.buttonSetting.Text = "Ustawienia";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Visible = false;
            this.buttonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // buttonHomePage
            // 
            this.buttonHomePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHomePage.FlatAppearance.BorderSize = 0;
            this.buttonHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomePage.ForeColor = System.Drawing.Color.White;
            this.buttonHomePage.Location = new System.Drawing.Point(12, 44);
            this.buttonHomePage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonHomePage.Name = "buttonHomePage";
            this.buttonHomePage.Size = new System.Drawing.Size(209, 46);
            this.buttonHomePage.TabIndex = 11;
            this.buttonHomePage.Text = "Strona główna";
            this.buttonHomePage.UseVisualStyleBackColor = true;
            this.buttonHomePage.Click += new System.EventHandler(this.ButtonHomePage_Click);
            // 
            // buttonMenuClose
            // 
            this.buttonMenuClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuClose.ForeColor = System.Drawing.Color.Red;
            this.buttonMenuClose.Location = new System.Drawing.Point(12, 12);
            this.buttonMenuClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMenuClose.Name = "buttonMenuClose";
            this.buttonMenuClose.Size = new System.Drawing.Size(209, 32);
            this.buttonMenuClose.TabIndex = 0;
            this.buttonMenuClose.Text = "X";
            this.buttonMenuClose.UseVisualStyleBackColor = true;
            this.buttonMenuClose.Click += new System.EventHandler(this.ButtonMenuClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelStartPage);
            this.panel2.Controls.Add(this.panelMoreButtons);
            this.panel2.Controls.Add(this.panelAllitem);
            this.panel2.Controls.Add(this.panelLoading);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 624);
            this.panel2.TabIndex = 5;
            // 
            // panelMoreButtons
            // 
            this.panelMoreButtons.Controls.Add(this.panel10);
            this.panelMoreButtons.Controls.Add(this.panel6);
            this.panelMoreButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMoreButtons.Location = new System.Drawing.Point(0, 0);
            this.panelMoreButtons.Name = "panelMoreButtons";
            this.panelMoreButtons.Size = new System.Drawing.Size(1090, 624);
            this.panelMoreButtons.TabIndex = 2;
            this.panelMoreButtons.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.newFlowLayoutPanel1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 38);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.panel10.Size = new System.Drawing.Size(1090, 586);
            this.panel10.TabIndex = 1;
            // 
            // newFlowLayoutPanel1
            // 
            this.newFlowLayoutPanel1.Controls.Add(this.panel11);
            this.newFlowLayoutPanel1.Controls.Add(this.panel12);
            this.newFlowLayoutPanel1.Controls.Add(this.panel13);
            this.newFlowLayoutPanel1.Controls.Add(this.panel14);
            this.newFlowLayoutPanel1.Controls.Add(this.panel17);
            this.newFlowLayoutPanel1.Controls.Add(this.panel15);
            this.newFlowLayoutPanel1.Controls.Add(this.panel16);
            this.newFlowLayoutPanel1.Controls.Add(this.panel19);
            this.newFlowLayoutPanel1.Controls.Add(this.panel20);
            this.newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            this.newFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.newFlowLayoutPanel1.Size = new System.Drawing.Size(1050, 566);
            this.newFlowLayoutPanel1.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.button_MoreBtn_Open_Settings);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(8, 8);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(1);
            this.panel11.Size = new System.Drawing.Size(200, 120);
            this.panel11.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 56);
            this.label5.TabIndex = 2;
            // 
            // button_MoreBtn_Open_Settings
            // 
            this.button_MoreBtn_Open_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_MoreBtn_Open_Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_MoreBtn_Open_Settings.FlatAppearance.BorderSize = 0;
            this.button_MoreBtn_Open_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MoreBtn_Open_Settings.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MoreBtn_Open_Settings.ForeColor = System.Drawing.Color.White;
            this.button_MoreBtn_Open_Settings.Location = new System.Drawing.Point(1, 89);
            this.button_MoreBtn_Open_Settings.Name = "button_MoreBtn_Open_Settings";
            this.button_MoreBtn_Open_Settings.Size = new System.Drawing.Size(198, 30);
            this.button_MoreBtn_Open_Settings.TabIndex = 1;
            this.button_MoreBtn_Open_Settings.Text = "Przejdź";
            this.button_MoreBtn_Open_Settings.UseVisualStyleBackColor = false;
            this.button_MoreBtn_Open_Settings.Click += new System.EventHandler(this.Button_MoreBtn_Open_Settings_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ustawienia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.button2button_MoreBtn_Open_Player);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(214, 8);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(1);
            this.panel12.Size = new System.Drawing.Size(200, 120);
            this.panel12.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 56);
            this.label6.TabIndex = 2;
            this.label6.Text = "Odtwarzacz plików lokalnych";
            // 
            // button2button_MoreBtn_Open_Player
            // 
            this.button2button_MoreBtn_Open_Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2button_MoreBtn_Open_Player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2button_MoreBtn_Open_Player.FlatAppearance.BorderSize = 0;
            this.button2button_MoreBtn_Open_Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2button_MoreBtn_Open_Player.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2button_MoreBtn_Open_Player.ForeColor = System.Drawing.Color.White;
            this.button2button_MoreBtn_Open_Player.Location = new System.Drawing.Point(1, 89);
            this.button2button_MoreBtn_Open_Player.Name = "button2button_MoreBtn_Open_Player";
            this.button2button_MoreBtn_Open_Player.Size = new System.Drawing.Size(198, 30);
            this.button2button_MoreBtn_Open_Player.TabIndex = 1;
            this.button2button_MoreBtn_Open_Player.Text = "Przejdź";
            this.button2button_MoreBtn_Open_Player.UseVisualStyleBackColor = false;
            this.button2button_MoreBtn_Open_Player.Click += new System.EventHandler(this.Button2button_MoreBtn_Open_Player_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Odtwarzacz";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel13.Controls.Add(this.label8);
            this.panel13.Controls.Add(this.button4button2button_MoreBtn_Open_FindItem);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(420, 8);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(1);
            this.panel13.Size = new System.Drawing.Size(200, 120);
            this.panel13.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 56);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wyszukiwarka dostępnych tytułów";
            // 
            // button4button2button_MoreBtn_Open_FindItem
            // 
            this.button4button2button_MoreBtn_Open_FindItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4button2button_MoreBtn_Open_FindItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4button2button_MoreBtn_Open_FindItem.FlatAppearance.BorderSize = 0;
            this.button4button2button_MoreBtn_Open_FindItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4button2button_MoreBtn_Open_FindItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4button2button_MoreBtn_Open_FindItem.ForeColor = System.Drawing.Color.White;
            this.button4button2button_MoreBtn_Open_FindItem.Location = new System.Drawing.Point(1, 89);
            this.button4button2button_MoreBtn_Open_FindItem.Name = "button4button2button_MoreBtn_Open_FindItem";
            this.button4button2button_MoreBtn_Open_FindItem.Size = new System.Drawing.Size(198, 30);
            this.button4button2button_MoreBtn_Open_FindItem.TabIndex = 1;
            this.button4button2button_MoreBtn_Open_FindItem.Text = "Przejdź";
            this.button4button2button_MoreBtn_Open_FindItem.UseVisualStyleBackColor = false;
            this.button4button2button_MoreBtn_Open_FindItem.Click += new System.EventHandler(this.Button4button2button_MoreBtn_Open_FindItem_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Wyszukiwarka";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel14.Controls.Add(this.label10);
            this.panel14.Controls.Add(this.button5button2button_MoreBtn_Open_Lists);
            this.panel14.Controls.Add(this.label11);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(626, 8);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(1);
            this.panel14.Size = new System.Drawing.Size(200, 120);
            this.panel14.TabIndex = 3;
            this.panel14.Visible = false;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 56);
            this.label10.TabIndex = 2;
            this.label10.Text = "Listy: \r\nOglądam, Planeuj,, Wstrzymane, Porzucone, itp.";
            // 
            // button5button2button_MoreBtn_Open_Lists
            // 
            this.button5button2button_MoreBtn_Open_Lists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5button2button_MoreBtn_Open_Lists.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5button2button_MoreBtn_Open_Lists.FlatAppearance.BorderSize = 0;
            this.button5button2button_MoreBtn_Open_Lists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5button2button_MoreBtn_Open_Lists.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5button2button_MoreBtn_Open_Lists.ForeColor = System.Drawing.Color.White;
            this.button5button2button_MoreBtn_Open_Lists.Location = new System.Drawing.Point(1, 89);
            this.button5button2button_MoreBtn_Open_Lists.Name = "button5button2button_MoreBtn_Open_Lists";
            this.button5button2button_MoreBtn_Open_Lists.Size = new System.Drawing.Size(198, 30);
            this.button5button2button_MoreBtn_Open_Lists.TabIndex = 1;
            this.button5button2button_MoreBtn_Open_Lists.Text = "Przejdź";
            this.button5button2button_MoreBtn_Open_Lists.UseVisualStyleBackColor = false;
            this.button5button2button_MoreBtn_Open_Lists.Click += new System.EventHandler(this.Button5button2button_MoreBtn_Open_Lists_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Listy anime";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel17.Controls.Add(this.label16);
            this.panel17.Controls.Add(this.buttonCommunity);
            this.panel17.Controls.Add(this.label17);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(832, 8);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(1);
            this.panel17.Size = new System.Drawing.Size(200, 120);
            this.panel17.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 56);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ludzie, Grupy...";
            // 
            // buttonCommunity
            // 
            this.buttonCommunity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCommunity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCommunity.FlatAppearance.BorderSize = 0;
            this.buttonCommunity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommunity.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCommunity.ForeColor = System.Drawing.Color.White;
            this.buttonCommunity.Location = new System.Drawing.Point(1, 89);
            this.buttonCommunity.Name = "buttonCommunity";
            this.buttonCommunity.Size = new System.Drawing.Size(198, 30);
            this.buttonCommunity.TabIndex = 1;
            this.buttonCommunity.Text = "Przejdź";
            this.buttonCommunity.UseVisualStyleBackColor = false;
            this.buttonCommunity.Click += new System.EventHandler(this.ButtonCommunity_Click);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(198, 32);
            this.label17.TabIndex = 0;
            this.label17.Text = "Społeczność";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel15.Controls.Add(this.label12);
            this.panel15.Controls.Add(this.button2button_MoreBtn_Open_GitHub);
            this.panel15.Controls.Add(this.label13);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(8, 134);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(1);
            this.panel15.Size = new System.Drawing.Size(200, 120);
            this.panel15.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 56);
            this.label12.TabIndex = 2;
            this.label12.Text = "Kod źródłowy aplikacji";
            // 
            // button2button_MoreBtn_Open_GitHub
            // 
            this.button2button_MoreBtn_Open_GitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2button_MoreBtn_Open_GitHub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2button_MoreBtn_Open_GitHub.FlatAppearance.BorderSize = 0;
            this.button2button_MoreBtn_Open_GitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2button_MoreBtn_Open_GitHub.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2button_MoreBtn_Open_GitHub.ForeColor = System.Drawing.Color.White;
            this.button2button_MoreBtn_Open_GitHub.Location = new System.Drawing.Point(1, 89);
            this.button2button_MoreBtn_Open_GitHub.Name = "button2button_MoreBtn_Open_GitHub";
            this.button2button_MoreBtn_Open_GitHub.Size = new System.Drawing.Size(198, 30);
            this.button2button_MoreBtn_Open_GitHub.TabIndex = 1;
            this.button2button_MoreBtn_Open_GitHub.Text = "Przejdź";
            this.button2button_MoreBtn_Open_GitHub.UseVisualStyleBackColor = false;
            this.button2button_MoreBtn_Open_GitHub.Click += new System.EventHandler(this.Button2button_MoreBtn_Open_GitHub_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "GitHub";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel16.Controls.Add(this.label14);
            this.panel16.Controls.Add(this.button7button2button_MoreBtn_Open_twojeanimepl);
            this.panel16.Controls.Add(this.label15);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(214, 134);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(1);
            this.panel16.Size = new System.Drawing.Size(200, 120);
            this.panel16.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 56);
            this.label14.TabIndex = 2;
            this.label14.Text = "Strona internetowa Twojeanimepl";
            // 
            // button7button2button_MoreBtn_Open_twojeanimepl
            // 
            this.button7button2button_MoreBtn_Open_twojeanimepl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7button2button_MoreBtn_Open_twojeanimepl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7button2button_MoreBtn_Open_twojeanimepl.FlatAppearance.BorderSize = 0;
            this.button7button2button_MoreBtn_Open_twojeanimepl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7button2button_MoreBtn_Open_twojeanimepl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7button2button_MoreBtn_Open_twojeanimepl.ForeColor = System.Drawing.Color.White;
            this.button7button2button_MoreBtn_Open_twojeanimepl.Location = new System.Drawing.Point(1, 89);
            this.button7button2button_MoreBtn_Open_twojeanimepl.Name = "button7button2button_MoreBtn_Open_twojeanimepl";
            this.button7button2button_MoreBtn_Open_twojeanimepl.Size = new System.Drawing.Size(198, 30);
            this.button7button2button_MoreBtn_Open_twojeanimepl.TabIndex = 1;
            this.button7button2button_MoreBtn_Open_twojeanimepl.Text = "Przejdź";
            this.button7button2button_MoreBtn_Open_twojeanimepl.UseVisualStyleBackColor = false;
            this.button7button2button_MoreBtn_Open_twojeanimepl.Click += new System.EventHandler(this.Button7button2button_MoreBtn_Open_twojeanimepl_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 32);
            this.label15.TabIndex = 0;
            this.label15.Text = "Twojeanimepl";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel19.Controls.Add(this.label18);
            this.panel19.Controls.Add(this.button2);
            this.panel19.Controls.Add(this.label19);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(420, 134);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(1);
            this.panel19.Size = new System.Drawing.Size(200, 120);
            this.panel19.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(198, 56);
            this.label18.TabIndex = 2;
            this.label18.Text = "Twórz tręsci dla tej aplikacji. Zestaw aplikacji dla ludzi którzy chcą pomoć w ro" +
    "zwijaniu player\'a";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Przejdź";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(1, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(198, 32);
            this.label19.TabIndex = 0;
            this.label19.Text = "Narzędzia";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel20.Controls.Add(this.label20);
            this.panel20.Controls.Add(this.buttonAllNewsContnet);
            this.panel20.Controls.Add(this.label21);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(626, 134);
            this.panel20.Name = "panel20";
            this.panel20.Padding = new System.Windows.Forms.Padding(1);
            this.panel20.Size = new System.Drawing.Size(200, 120);
            this.panel20.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(1, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(198, 56);
            this.label20.TabIndex = 2;
            this.label20.Text = "Wiadmości itp.";
            // 
            // buttonAllNewsContnet
            // 
            this.buttonAllNewsContnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAllNewsContnet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAllNewsContnet.FlatAppearance.BorderSize = 0;
            this.buttonAllNewsContnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllNewsContnet.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAllNewsContnet.ForeColor = System.Drawing.Color.White;
            this.buttonAllNewsContnet.Location = new System.Drawing.Point(1, 89);
            this.buttonAllNewsContnet.Name = "buttonAllNewsContnet";
            this.buttonAllNewsContnet.Size = new System.Drawing.Size(198, 30);
            this.buttonAllNewsContnet.TabIndex = 1;
            this.buttonAllNewsContnet.Text = "Przejdź";
            this.buttonAllNewsContnet.UseVisualStyleBackColor = false;
            this.buttonAllNewsContnet.Click += new System.EventHandler(this.ButtonAllNewsContnet_Click);
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(1, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(198, 32);
            this.label21.TabIndex = 0;
            this.label21.Text = "Aktualności";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonCloseMoreButtons);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.panel6.Size = new System.Drawing.Size(1090, 38);
            this.panel6.TabIndex = 0;
            // 
            // buttonCloseMoreButtons
            // 
            this.buttonCloseMoreButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseMoreButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseMoreButtons.ForeColor = System.Drawing.Color.Red;
            this.buttonCloseMoreButtons.Location = new System.Drawing.Point(1039, 10);
            this.buttonCloseMoreButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCloseMoreButtons.MaximumSize = new System.Drawing.Size(41, 29);
            this.buttonCloseMoreButtons.Name = "buttonCloseMoreButtons";
            this.buttonCloseMoreButtons.Size = new System.Drawing.Size(41, 28);
            this.buttonCloseMoreButtons.TabIndex = 6;
            this.buttonCloseMoreButtons.Text = "X";
            this.buttonCloseMoreButtons.UseVisualStyleBackColor = true;
            this.buttonCloseMoreButtons.Click += new System.EventHandler(this.ButtonCloseMoreButtons_Click);
            // 
            // panelAllitem
            // 
            this.panelAllitem.Controls.Add(this.flowLayoutPanelFinditem);
            this.panelAllitem.Controls.Add(this.flowLayoutPanelAll);
            this.panelAllitem.Controls.Add(this.panelTopFinder);
            this.panelAllitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllitem.Location = new System.Drawing.Point(0, 0);
            this.panelAllitem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelAllitem.Name = "panelAllitem";
            this.panelAllitem.Size = new System.Drawing.Size(1090, 624);
            this.panelAllitem.TabIndex = 0;
            // 
            // flowLayoutPanelFinditem
            // 
            this.flowLayoutPanelFinditem.AutoScroll = true;
            this.flowLayoutPanelFinditem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFinditem.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanelFinditem.Name = "flowLayoutPanelFinditem";
            this.flowLayoutPanelFinditem.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.flowLayoutPanelFinditem.Size = new System.Drawing.Size(1090, 524);
            this.flowLayoutPanelFinditem.TabIndex = 0;
            // 
            // flowLayoutPanelAll
            // 
            this.flowLayoutPanelAll.AutoScroll = true;
            this.flowLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAll.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanelAll.Name = "flowLayoutPanelAll";
            this.flowLayoutPanelAll.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.flowLayoutPanelAll.Size = new System.Drawing.Size(1090, 524);
            this.flowLayoutPanelAll.TabIndex = 0;
            // 
            // panelTopFinder
            // 
            this.panelTopFinder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelTopFinder.Controls.Add(this.labelEnableFiltres);
            this.panelTopFinder.Controls.Add(this.roundedPanel2);
            this.panelTopFinder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopFinder.Location = new System.Drawing.Point(0, 0);
            this.panelTopFinder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTopFinder.Name = "panelTopFinder";
            this.panelTopFinder.Padding = new System.Windows.Forms.Padding(12);
            this.panelTopFinder.Size = new System.Drawing.Size(1090, 100);
            this.panelTopFinder.TabIndex = 0;
            // 
            // labelEnableFiltres
            // 
            this.labelEnableFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.labelEnableFiltres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelEnableFiltres.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnableFiltres.ForeColor = System.Drawing.SystemColors.Window;
            this.labelEnableFiltres.Location = new System.Drawing.Point(12, 68);
            this.labelEnableFiltres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnableFiltres.MaximumSize = new System.Drawing.Size(117, 35);
            this.labelEnableFiltres.Name = "labelEnableFiltres";
            this.labelEnableFiltres.Size = new System.Drawing.Size(117, 20);
            this.labelEnableFiltres.TabIndex = 6;
            this.labelEnableFiltres.Text = "Filtry włączone";
            this.labelEnableFiltres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEnableFiltres.Visible = false;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.ColorEdges = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundedPanel2.Controls.Add(this.labelFindSatus);
            this.roundedPanel2.Controls.Add(this.buttonfinditemReset);
            this.roundedPanel2.Controls.Add(this.buttonfinditemF);
            this.roundedPanel2.Controls.Add(this.buttonFindItem);
            this.roundedPanel2.Controls.Add(this.panel21);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Controls.Add(this.buttonFinditemPageClose);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.ExBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.roundedPanel2.Location = new System.Drawing.Point(12, 12);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(12, 30, 12, 20);
            this.roundedPanel2.RadiusArcPanel = 20F;
            this.roundedPanel2.Size = new System.Drawing.Size(1066, 76);
            this.roundedPanel2.TabIndex = 0;
            // 
            // labelFindSatus
            // 
            this.labelFindSatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFindSatus.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFindSatus.ForeColor = System.Drawing.Color.White;
            this.labelFindSatus.Location = new System.Drawing.Point(901, 30);
            this.labelFindSatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFindSatus.Name = "labelFindSatus";
            this.labelFindSatus.Size = new System.Drawing.Size(61, 26);
            this.labelFindSatus.TabIndex = 4;
            this.labelFindSatus.Text = "Szukanie";
            this.labelFindSatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFindSatus.Visible = false;
            // 
            // buttonfinditemReset
            // 
            this.buttonfinditemReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonfinditemReset.FlatAppearance.BorderSize = 0;
            this.buttonfinditemReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonfinditemReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonfinditemReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfinditemReset.ForeColor = System.Drawing.Color.White;
            this.buttonfinditemReset.Location = new System.Drawing.Point(813, 30);
            this.buttonfinditemReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonfinditemReset.Name = "buttonfinditemReset";
            this.buttonfinditemReset.Size = new System.Drawing.Size(88, 26);
            this.buttonfinditemReset.TabIndex = 3;
            this.buttonfinditemReset.Text = "Reset";
            this.buttonfinditemReset.UseVisualStyleBackColor = true;
            this.buttonfinditemReset.Click += new System.EventHandler(this.ButtonfinditemReset_Click);
            // 
            // buttonfinditemF
            // 
            this.buttonfinditemF.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonfinditemF.FlatAppearance.BorderSize = 0;
            this.buttonfinditemF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonfinditemF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonfinditemF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfinditemF.ForeColor = System.Drawing.Color.White;
            this.buttonfinditemF.Location = new System.Drawing.Point(744, 30);
            this.buttonfinditemF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonfinditemF.Name = "buttonfinditemF";
            this.buttonfinditemF.Size = new System.Drawing.Size(69, 26);
            this.buttonfinditemF.TabIndex = 6;
            this.buttonfinditemF.Text = "Filtry";
            this.buttonfinditemF.UseVisualStyleBackColor = true;
            this.buttonfinditemF.Visible = false;
            this.buttonfinditemF.Click += new System.EventHandler(this.ButtonfinditemF_Click);
            // 
            // buttonFindItem
            // 
            this.buttonFindItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFindItem.FlatAppearance.BorderSize = 0;
            this.buttonFindItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonFindItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonFindItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindItem.ForeColor = System.Drawing.Color.White;
            this.buttonFindItem.Location = new System.Drawing.Point(656, 30);
            this.buttonFindItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFindItem.Name = "buttonFindItem";
            this.buttonFindItem.Size = new System.Drawing.Size(88, 26);
            this.buttonFindItem.TabIndex = 2;
            this.buttonFindItem.Text = "Szukaj";
            this.buttonFindItem.UseVisualStyleBackColor = true;
            this.buttonFindItem.Click += new System.EventHandler(this.ButtonFindItem_Click);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.textBoxFinditem);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(216, 30);
            this.panel21.Name = "panel21";
            this.panel21.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel21.Size = new System.Drawing.Size(440, 26);
            this.panel21.TabIndex = 7;
            // 
            // textBoxFinditem
            // 
            this.textBoxFinditem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxFinditem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFinditem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxFinditem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFinditem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxFinditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFinditem.ForeColor = System.Drawing.Color.White;
            this.textBoxFinditem.Location = new System.Drawing.Point(0, 5);
            this.textBoxFinditem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFinditem.Name = "textBoxFinditem";
            this.textBoxFinditem.PlaceholderText = "Szukaj";
            this.textBoxFinditem.Size = new System.Drawing.Size(440, 16);
            this.textBoxFinditem.TabIndex = 1;
            this.textBoxFinditem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFinditem.TextChanged += new System.EventHandler(this.TextBoxFinditem_TextChanged);
            this.textBoxFinditem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxFinditem_KeyDown);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Twojeanimepl - Wyszukiwarka";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFinditemPageClose
            // 
            this.buttonFinditemPageClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonFinditemPageClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFinditemPageClose.FlatAppearance.BorderSize = 0;
            this.buttonFinditemPageClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinditemPageClose.ForeColor = System.Drawing.Color.Red;
            this.buttonFinditemPageClose.Location = new System.Drawing.Point(962, 30);
            this.buttonFinditemPageClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFinditemPageClose.Name = "buttonFinditemPageClose";
            this.buttonFinditemPageClose.Size = new System.Drawing.Size(92, 26);
            this.buttonFinditemPageClose.TabIndex = 0;
            this.buttonFinditemPageClose.Text = "Zamknij kartę";
            this.buttonFinditemPageClose.UseVisualStyleBackColor = false;
            this.buttonFinditemPageClose.Click += new System.EventHandler(this.ButtonFinditemPageClose_Click);
            // 
            // panelNotifiError
            // 
            this.panelNotifiError.Controls.Add(this.labelError);
            this.panelNotifiError.Controls.Add(this.pictureBox3);
            this.panelNotifiError.Location = new System.Drawing.Point(0, 0);
            this.panelNotifiError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelNotifiError.Name = "panelNotifiError";
            this.panelNotifiError.Size = new System.Drawing.Size(233, 59);
            this.panelNotifiError.TabIndex = 6;
            // 
            // labelError
            // 
            this.labelError.AutoEllipsis = true;
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(66, 0);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(167, 59);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "Error code:";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // timerAnimationError
            // 
            this.timerAnimationError.Interval = 1;
            this.timerAnimationError.Tick += new System.EventHandler(this.TimerAnimationError_Tick);
            // 
            // backgroundWorkerGetSTNews
            // 
            this.backgroundWorkerGetSTNews.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerGetSTNews_DoWork);
            // 
            // timerAppPer
            // 
            this.timerAppPer.Interval = 1000;
            this.timerAppPer.Tick += new System.EventHandler(this.TimerAppPer_Tick);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.labelAppRamUsage);
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(170, 35);
            this.panel18.TabIndex = 7;
            this.panel18.Visible = false;
            // 
            // labelAppRamUsage
            // 
            this.labelAppRamUsage.AutoSize = true;
            this.labelAppRamUsage.ForeColor = System.Drawing.Color.White;
            this.labelAppRamUsage.Location = new System.Drawing.Point(3, 12);
            this.labelAppRamUsage.Name = "labelAppRamUsage";
            this.labelAppRamUsage.Size = new System.Drawing.Size(110, 15);
            this.labelAppRamUsage.TabIndex = 0;
            this.labelAppRamUsage.Text = "labelAppRamUsage";
            // 
            // backgroundWorkerLoadItems
            // 
            this.backgroundWorkerLoadItems.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerLoadItems_DoWork);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.textBoxCommandOutput);
            this.panelCommands.Controls.Add(this.textBoxCommandInput);
            this.panelCommands.Controls.Add(this.label22);
            this.panelCommands.Location = new System.Drawing.Point(355, 216);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(357, 133);
            this.panelCommands.TabIndex = 8;
            this.panelCommands.Visible = false;
            // 
            // textBoxCommandOutput
            // 
            this.textBoxCommandOutput.BackColor = System.Drawing.Color.Black;
            this.textBoxCommandOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCommandOutput.ForeColor = System.Drawing.Color.White;
            this.textBoxCommandOutput.Location = new System.Drawing.Point(11, 27);
            this.textBoxCommandOutput.Multiline = true;
            this.textBoxCommandOutput.Name = "textBoxCommandOutput";
            this.textBoxCommandOutput.ReadOnly = true;
            this.textBoxCommandOutput.Size = new System.Drawing.Size(340, 65);
            this.textBoxCommandOutput.TabIndex = 2;
            // 
            // textBoxCommandInput
            // 
            this.textBoxCommandInput.AutoCompleteCustomSource.AddRange(new string[] {
            "videoplayerweb open loaclfile type youtube;"});
            this.textBoxCommandInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxCommandInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCommandInput.BackColor = System.Drawing.Color.Black;
            this.textBoxCommandInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCommandInput.ForeColor = System.Drawing.Color.White;
            this.textBoxCommandInput.Location = new System.Drawing.Point(11, 101);
            this.textBoxCommandInput.Name = "textBoxCommandInput";
            this.textBoxCommandInput.Size = new System.Drawing.Size(340, 23);
            this.textBoxCommandInput.TabIndex = 1;
            this.textBoxCommandInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCommandInput_KeyDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(11, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Konsola poleceń";
            // 
            // FormMainPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1090, 624);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCommands);
            this.Controls.Add(this.panelNotifiError);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1106, 629);
            this.Name = "FormMainPlayer";
            this.Text = "AnimePlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainPlayer_FormClosing);
            this.Load += new System.EventHandler(this.FormMainPlayer_Load);
            this.ResizeBegin += new System.EventHandler(this.FormMainPlayer_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormMainPlayer_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormMainPlayer_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.FormMainPlayer_Resize);
            this.panelStartPage.ResumeLayout(false);
            this.panelGroup.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panePolecane.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSTNewsMain.ResumeLayout(false);
            this.panelSTNewsMain.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSite)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelMoreButtons.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.newFlowLayoutPanel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelAllitem.ResumeLayout(false);
            this.panelTopFinder.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panelNotifiError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panelCommands.ResumeLayout(false);
            this.panelCommands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelTop;
        private AnimePlayerLibrary.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panePolecane;
        public System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Button buttonMenuClose;
        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Button buttonSetting;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Panel panelNotifiError;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label labelError;
        public System.Windows.Forms.Timer timerAnimationError;
        public System.Windows.Forms.Label labelSatusWorkingApp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxGithub;
        private System.Windows.Forms.PictureBox pictureBoxSite;
        private System.Windows.Forms.Button buttonSite;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonViewFindintems;
        public System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Button buttonRestartApp;
        public NewFlowLayoutPanel flowLayoutPanelPolecane;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Label labelLoadingDetails;
        public System.Windows.Forms.Panel panelStartPage;
        public System.Windows.Forms.Label labelLoadingA;
        public System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Panel panelSTNewsMain;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGetSTNews;
        public System.Windows.Forms.TextBox textBoxStartPagefinditem;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Button buttonStartPageFinditem;
        public System.Windows.Forms.Button buttonMenuOpen;
        public RoundedPanel roundedPanel2;
        public System.Windows.Forms.Panel panelTopFinder;
        public System.Windows.Forms.Label labelEnableFiltres;
        public System.Windows.Forms.Button buttonFinditemPageClose;
        public System.Windows.Forms.Button buttonFindItem;
        public System.Windows.Forms.TextBox textBoxFinditem;
        public System.Windows.Forms.Button buttonfinditemReset;
        public System.Windows.Forms.Label labelFindSatus;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buttonfinditemF;
        public System.Windows.Forms.Panel panelAllitem;
        private System.Windows.Forms.Button buttonShowTitleStatusList;
        private System.Windows.Forms.ToolTip toolTip;
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
        private System.Windows.Forms.Timer timerAppPer;
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
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadItems;
        private Panel panelCommands;
        private TextBox textBoxCommandOutput;
        private TextBox textBoxCommandInput;
        public Label label22;
        private Panel panelGroup;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button button3;
        private Panel panel4;
        private Label label3;
        public Button buttonProfile;
        private Panel panel21;
        private Button buttonDefined;
        private Button buttonHomePage;
        public NewFlowLayoutPanel flowLayoutPanelFinditem;
        private NewFlowLayoutPanel flowLayoutPanelAll;
    }
}
