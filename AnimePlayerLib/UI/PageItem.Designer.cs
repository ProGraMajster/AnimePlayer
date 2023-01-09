using AnimePlayer.ControlsWinForms;
using AnimePlayerLibrary;
using System.Windows.Forms;
using NewFlowLayoutPanel = AnimePlayer.ControlsWinForms.NewFlowLayoutPanel;

namespace AnimePlayerLibrary.UI
{
    partial class PageItem
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelChangeState = new System.Windows.Forms.LinkLabel();
            this.labelotherTitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelStudio = new System.Windows.Forms.Label();
            this.labelNE = new System.Windows.Forms.Label();
            this.labelLE = new System.Windows.Forms.Label();
            this.labelMPAA = new System.Windows.Forms.Label();
            this.labelDateE = new System.Windows.Forms.Label();
            this.labelDateS = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_7 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.labeliNe = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelEpisode = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_comments = new System.Windows.Forms.Panel();
            this.panel_com_dockWebview = new System.Windows.Forms.Panel();
            this.button_Load_Comments = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelRelatedSeries = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRelatedSeries = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelOtherTags = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelArchetype = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPlaceAndTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTypesOfCharacters = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTargetGroups = new System.Windows.Forms.Label();
            this.labeliGD = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelChangeStatus = new System.Windows.Forms.Panel();
            this.panelViewIcon = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonViewIconClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelNoDataSite = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelAdultContentMessage = new System.Windows.Forms.Panel();
            this.buttonAyes = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonAno = new System.Windows.Forms.Button();
            this.buttonBackA = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panelNoAccess = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel_comments.SuspendLayout();
            this.panelRelatedSeries.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelViewIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelNoDataSite.SuspendLayout();
            this.panelAdultContentMessage.SuspendLayout();
            this.panelNoAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.linkLabelChangeState);
            this.panel1.Controls.Add(this.labelotherTitle);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.button);
            this.panel1.Controls.Add(this.pictureBoxIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(23);
            this.panel1.Size = new System.Drawing.Size(922, 277);
            this.panel1.TabIndex = 0;
            // 
            // linkLabelChangeState
            // 
            this.linkLabelChangeState.AutoSize = true;
            this.linkLabelChangeState.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelChangeState.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabelChangeState.Location = new System.Drawing.Point(218, 237);
            this.linkLabelChangeState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelChangeState.Name = "linkLabelChangeState";
            this.linkLabelChangeState.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.linkLabelChangeState.Size = new System.Drawing.Size(215, 19);
            this.linkLabelChangeState.TabIndex = 5;
            this.linkLabelChangeState.TabStop = true;
            this.linkLabelChangeState.Text = "Zmień status (Aktualny: brak)";
            this.linkLabelChangeState.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangeState_LinkClicked);
            // 
            // labelotherTitle
            // 
            this.labelotherTitle.AutoEllipsis = true;
            this.labelotherTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelotherTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelotherTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelotherTitle.ForeColor = System.Drawing.Color.White;
            this.labelotherTitle.Location = new System.Drawing.Point(210, 70);
            this.labelotherTitle.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelotherTitle.Name = "labelotherTitle";
            this.labelotherTitle.Padding = new System.Windows.Forms.Padding(12, 12, 12, 3);
            this.labelotherTitle.Size = new System.Drawing.Size(572, 148);
            this.labelotherTitle.TabIndex = 3;
            this.labelotherTitle.Text = "OtherTitle";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(210, 23);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(12);
            this.labelTitle.Size = new System.Drawing.Size(70, 47);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button.Dock = System.Windows.Forms.DockStyle.Right;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(782, 23);
            this.button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button.MaximumSize = new System.Drawing.Size(117, 52);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(117, 52);
            this.button.TabIndex = 2;
            this.button.Text = "Zamknij stronę";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(23, 23);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(187, 231);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Click += new System.EventHandler(this.PictureBoxIcon_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.labelDes);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 527);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 548);
            this.panel3.TabIndex = 0;
            // 
            // labelDes
            // 
            this.labelDes.AutoEllipsis = true;
            this.labelDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelDes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDes.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDes.ForeColor = System.Drawing.Color.White;
            this.labelDes.Location = new System.Drawing.Point(337, 52);
            this.labelDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDes.Name = "labelDes";
            this.labelDes.Padding = new System.Windows.Forms.Padding(12);
            this.labelDes.Size = new System.Drawing.Size(585, 496);
            this.labelDes.TabIndex = 6;
            this.labelDes.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12);
            this.label1.Size = new System.Drawing.Size(79, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opis";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 548);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 497);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.labelStudio);
            this.panel8.Controls.Add(this.labelNE);
            this.panel8.Controls.Add(this.labelLE);
            this.panel8.Controls.Add(this.labelMPAA);
            this.panel8.Controls.Add(this.labelDateE);
            this.panel8.Controls.Add(this.labelDateS);
            this.panel8.Controls.Add(this.labelStatus);
            this.panel8.Controls.Add(this.labelType);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(172, 3);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(161, 491);
            this.panel8.TabIndex = 1;
            // 
            // labelStudio
            // 
            this.labelStudio.AutoEllipsis = true;
            this.labelStudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStudio.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudio.ForeColor = System.Drawing.Color.White;
            this.labelStudio.Location = new System.Drawing.Point(0, 235);
            this.labelStudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudio.Name = "labelStudio";
            this.labelStudio.Padding = new System.Windows.Forms.Padding(12);
            this.labelStudio.Size = new System.Drawing.Size(161, 162);
            this.labelStudio.TabIndex = 9;
            this.labelStudio.Text = "N/A";
            // 
            // labelNE
            // 
            this.labelNE.AutoEllipsis = true;
            this.labelNE.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNE.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNE.ForeColor = System.Drawing.Color.White;
            this.labelNE.Location = new System.Drawing.Point(0, 188);
            this.labelNE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNE.Name = "labelNE";
            this.labelNE.Padding = new System.Windows.Forms.Padding(12);
            this.labelNE.Size = new System.Drawing.Size(161, 47);
            this.labelNE.TabIndex = 12;
            this.labelNE.Text = "N/A";
            this.labelNE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLE
            // 
            this.labelLE.AutoEllipsis = true;
            this.labelLE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelLE.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLE.ForeColor = System.Drawing.Color.White;
            this.labelLE.Location = new System.Drawing.Point(0, 397);
            this.labelLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLE.Name = "labelLE";
            this.labelLE.Padding = new System.Windows.Forms.Padding(12);
            this.labelLE.Size = new System.Drawing.Size(161, 47);
            this.labelLE.TabIndex = 11;
            this.labelLE.Text = "N/A";
            this.labelLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMPAA
            // 
            this.labelMPAA.AutoEllipsis = true;
            this.labelMPAA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMPAA.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMPAA.ForeColor = System.Drawing.Color.White;
            this.labelMPAA.Location = new System.Drawing.Point(0, 444);
            this.labelMPAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMPAA.Name = "labelMPAA";
            this.labelMPAA.Padding = new System.Windows.Forms.Padding(12);
            this.labelMPAA.Size = new System.Drawing.Size(161, 47);
            this.labelMPAA.TabIndex = 10;
            this.labelMPAA.Text = "N/A";
            this.labelMPAA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateE
            // 
            this.labelDateE.AutoEllipsis = true;
            this.labelDateE.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDateE.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateE.ForeColor = System.Drawing.Color.White;
            this.labelDateE.Location = new System.Drawing.Point(0, 141);
            this.labelDateE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateE.Name = "labelDateE";
            this.labelDateE.Padding = new System.Windows.Forms.Padding(12);
            this.labelDateE.Size = new System.Drawing.Size(161, 47);
            this.labelDateE.TabIndex = 8;
            this.labelDateE.Text = "N/A";
            this.labelDateE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateS
            // 
            this.labelDateS.AutoEllipsis = true;
            this.labelDateS.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDateS.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateS.ForeColor = System.Drawing.Color.White;
            this.labelDateS.Location = new System.Drawing.Point(0, 94);
            this.labelDateS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateS.Name = "labelDateS";
            this.labelDateS.Padding = new System.Windows.Forms.Padding(12);
            this.labelDateS.Size = new System.Drawing.Size(161, 47);
            this.labelDateS.TabIndex = 7;
            this.labelDateS.Text = "N/A";
            this.labelDateS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoEllipsis = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStatus.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(0, 47);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(12);
            this.labelStatus.Size = new System.Drawing.Size(161, 47);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "N/A";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelType
            // 
            this.labelType.AutoEllipsis = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelType.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(0, 0);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Padding = new System.Windows.Forms.Padding(12);
            this.labelType.Size = new System.Drawing.Size(161, 47);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "N/A";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label_6);
            this.panel7.Controls.Add(this.label_7);
            this.panel7.Controls.Add(this.label_5);
            this.panel7.Controls.Add(this.labeliNe);
            this.panel7.Controls.Add(this.label_4);
            this.panel7.Controls.Add(this.label_3);
            this.panel7.Controls.Add(this.label_2);
            this.panel7.Controls.Add(this.label_1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(4, 3);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 491);
            this.panel7.TabIndex = 0;
            // 
            // label_6
            // 
            this.label_6.AutoEllipsis = true;
            this.label_6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_6.ForeColor = System.Drawing.Color.White;
            this.label_6.Location = new System.Drawing.Point(0, 397);
            this.label_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_6.Name = "label_6";
            this.label_6.Padding = new System.Windows.Forms.Padding(12);
            this.label_6.Size = new System.Drawing.Size(160, 47);
            this.label_6.TabIndex = 9;
            this.label_6.Text = "Długość odcinka";
            this.label_6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_7
            // 
            this.label_7.AutoEllipsis = true;
            this.label_7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_7.ForeColor = System.Drawing.Color.White;
            this.label_7.Location = new System.Drawing.Point(0, 444);
            this.label_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_7.Name = "label_7";
            this.label_7.Padding = new System.Windows.Forms.Padding(12);
            this.label_7.Size = new System.Drawing.Size(160, 47);
            this.label_7.TabIndex = 10;
            this.label_7.Text = "MPAA";
            this.label_7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_5
            // 
            this.label_5.AutoEllipsis = true;
            this.label_5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_5.ForeColor = System.Drawing.Color.White;
            this.label_5.Location = new System.Drawing.Point(0, 235);
            this.label_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_5.Name = "label_5";
            this.label_5.Padding = new System.Windows.Forms.Padding(12);
            this.label_5.Size = new System.Drawing.Size(160, 47);
            this.label_5.TabIndex = 8;
            this.label_5.Text = "Studio";
            this.label_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labeliNe
            // 
            this.labeliNe.AutoEllipsis = true;
            this.labeliNe.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeliNe.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeliNe.ForeColor = System.Drawing.Color.White;
            this.labeliNe.Location = new System.Drawing.Point(0, 188);
            this.labeliNe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeliNe.Name = "labeliNe";
            this.labeliNe.Padding = new System.Windows.Forms.Padding(12);
            this.labeliNe.Size = new System.Drawing.Size(160, 47);
            this.labeliNe.TabIndex = 11;
            this.labeliNe.Text = "Liczba odcinków";
            this.labeliNe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_4
            // 
            this.label_4.AutoEllipsis = true;
            this.label_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_4.ForeColor = System.Drawing.Color.White;
            this.label_4.Location = new System.Drawing.Point(0, 141);
            this.label_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_4.Name = "label_4";
            this.label_4.Padding = new System.Windows.Forms.Padding(12);
            this.label_4.Size = new System.Drawing.Size(160, 47);
            this.label_4.TabIndex = 7;
            this.label_4.Text = "Koniec emisji";
            this.label_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_3
            // 
            this.label_3.AutoEllipsis = true;
            this.label_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_3.ForeColor = System.Drawing.Color.White;
            this.label_3.Location = new System.Drawing.Point(0, 94);
            this.label_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_3.Name = "label_3";
            this.label_3.Padding = new System.Windows.Forms.Padding(12);
            this.label_3.Size = new System.Drawing.Size(160, 47);
            this.label_3.TabIndex = 6;
            this.label_3.Text = "Data emisji";
            this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_2
            // 
            this.label_2.AutoEllipsis = true;
            this.label_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_2.ForeColor = System.Drawing.Color.White;
            this.label_2.Location = new System.Drawing.Point(0, 47);
            this.label_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_2.Name = "label_2";
            this.label_2.Padding = new System.Windows.Forms.Padding(12);
            this.label_2.Size = new System.Drawing.Size(160, 47);
            this.label_2.TabIndex = 5;
            this.label_2.Text = "Status";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_1
            // 
            this.label_1.AutoEllipsis = true;
            this.label_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_1.ForeColor = System.Drawing.Color.White;
            this.label_1.Location = new System.Drawing.Point(0, 0);
            this.label_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_1.Name = "label_1";
            this.label_1.Padding = new System.Windows.Forms.Padding(12);
            this.label_1.Size = new System.Drawing.Size(160, 47);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "Typ";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12);
            this.label2.Size = new System.Drawing.Size(337, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informacje";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowLayoutPanelEpisode);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 1764);
            this.panel5.Margin = new System.Windows.Forms.Padding(12);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel5.Size = new System.Drawing.Size(922, 300);
            this.panel5.TabIndex = 4;
            // 
            // flowLayoutPanelEpisode
            // 
            this.flowLayoutPanelEpisode.AutoScroll = true;
            this.flowLayoutPanelEpisode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.flowLayoutPanelEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEpisode.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanelEpisode.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanelEpisode.Location = new System.Drawing.Point(0, 101);
            this.flowLayoutPanelEpisode.Name = "flowLayoutPanelEpisode";
            this.flowLayoutPanelEpisode.Size = new System.Drawing.Size(922, 187);
            this.flowLayoutPanelEpisode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(12);
            this.label5.Size = new System.Drawing.Size(122, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wybierz odcinek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(12);
            this.label3.Size = new System.Drawing.Size(95, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Odcinki";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel6.Controls.Add(this.panel_comments);
            this.panel6.Controls.Add(this.panelRelatedSeries);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panelChangeStatus);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(939, 590);
            this.panel6.TabIndex = 2;
            // 
            // panel_comments
            // 
            this.panel_comments.Controls.Add(this.panel_com_dockWebview);
            this.panel_comments.Controls.Add(this.button_Load_Comments);
            this.panel_comments.Controls.Add(this.label8);
            this.panel_comments.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_comments.Location = new System.Drawing.Point(0, 2462);
            this.panel_comments.Margin = new System.Windows.Forms.Padding(12);
            this.panel_comments.Name = "panel_comments";
            this.panel_comments.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel_comments.Size = new System.Drawing.Size(922, 521);
            this.panel_comments.TabIndex = 7;
            this.panel_comments.Visible = false;
            // 
            // panel_com_dockWebview
            // 
            this.panel_com_dockWebview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_com_dockWebview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_com_dockWebview.Location = new System.Drawing.Point(0, 60);
            this.panel_com_dockWebview.Name = "panel_com_dockWebview";
            this.panel_com_dockWebview.Size = new System.Drawing.Size(922, 449);
            this.panel_com_dockWebview.TabIndex = 6;
            // 
            // button_Load_Comments
            // 
            this.button_Load_Comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_Load_Comments.FlatAppearance.BorderSize = 0;
            this.button_Load_Comments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Load_Comments.ForeColor = System.Drawing.Color.White;
            this.button_Load_Comments.Location = new System.Drawing.Point(135, 27);
            this.button_Load_Comments.Name = "button_Load_Comments";
            this.button_Load_Comments.Size = new System.Drawing.Size(75, 23);
            this.button_Load_Comments.TabIndex = 7;
            this.button_Load_Comments.Text = "Załaduj";
            this.button_Load_Comments.UseVisualStyleBackColor = false;
            this.button_Load_Comments.Visible = false;
            this.button_Load_Comments.Click += new System.EventHandler(this.Button_Load_Comments_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(12);
            this.label8.Size = new System.Drawing.Size(133, 48);
            this.label8.TabIndex = 5;
            this.label8.Text = "Komentarze";
            // 
            // panelRelatedSeries
            // 
            this.panelRelatedSeries.Controls.Add(this.flowLayoutPanelRelatedSeries);
            this.panelRelatedSeries.Controls.Add(this.label6);
            this.panelRelatedSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRelatedSeries.Location = new System.Drawing.Point(0, 2064);
            this.panelRelatedSeries.Margin = new System.Windows.Forms.Padding(12);
            this.panelRelatedSeries.Name = "panelRelatedSeries";
            this.panelRelatedSeries.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panelRelatedSeries.Size = new System.Drawing.Size(922, 398);
            this.panelRelatedSeries.TabIndex = 6;
            this.panelRelatedSeries.Visible = false;
            // 
            // flowLayoutPanelRelatedSeries
            // 
            this.flowLayoutPanelRelatedSeries.AutoScroll = true;
            this.flowLayoutPanelRelatedSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.flowLayoutPanelRelatedSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRelatedSeries.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanelRelatedSeries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanelRelatedSeries.Name = "flowLayoutPanelRelatedSeries";
            this.flowLayoutPanelRelatedSeries.Padding = new System.Windows.Forms.Padding(14, 2, 14, 2);
            this.flowLayoutPanelRelatedSeries.Size = new System.Drawing.Size(922, 326);
            this.flowLayoutPanelRelatedSeries.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(12);
            this.label6.Size = new System.Drawing.Size(163, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "Powiązane serie";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 1075);
            this.panel9.Margin = new System.Windows.Forms.Padding(12);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 23, 0, 23);
            this.panel9.Size = new System.Drawing.Size(922, 689);
            this.panel9.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel10.Controls.Add(this.labelOtherTags);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.labelArchetype);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.labelPlaceAndTime);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.labelTypesOfCharacters);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.labelTargetGroups);
            this.panel10.Controls.Add(this.labeliGD);
            this.panel10.Controls.Add(this.labelSpecies);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 23);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(922, 643);
            this.panel10.TabIndex = 5;
            // 
            // labelOtherTags
            // 
            this.labelOtherTags.AutoEllipsis = true;
            this.labelOtherTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOtherTags.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOtherTags.ForeColor = System.Drawing.Color.White;
            this.labelOtherTags.Location = new System.Drawing.Point(0, 510);
            this.labelOtherTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOtherTags.Name = "labelOtherTags";
            this.labelOtherTags.Padding = new System.Windows.Forms.Padding(12);
            this.labelOtherTags.Size = new System.Drawing.Size(922, 45);
            this.labelOtherTags.TabIndex = 16;
            this.labelOtherTags.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 463);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(12);
            this.label13.Size = new System.Drawing.Size(922, 47);
            this.label13.TabIndex = 15;
            this.label13.Text = "Pozostałe tagi:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelArchetype
            // 
            this.labelArchetype.AutoEllipsis = true;
            this.labelArchetype.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelArchetype.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArchetype.ForeColor = System.Drawing.Color.White;
            this.labelArchetype.Location = new System.Drawing.Point(0, 418);
            this.labelArchetype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArchetype.Name = "labelArchetype";
            this.labelArchetype.Padding = new System.Windows.Forms.Padding(12);
            this.labelArchetype.Size = new System.Drawing.Size(922, 45);
            this.labelArchetype.TabIndex = 14;
            this.labelArchetype.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(12);
            this.label11.Size = new System.Drawing.Size(922, 47);
            this.label11.TabIndex = 13;
            this.label11.Text = "Pierwowzór:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlaceAndTime
            // 
            this.labelPlaceAndTime.AutoEllipsis = true;
            this.labelPlaceAndTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPlaceAndTime.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaceAndTime.ForeColor = System.Drawing.Color.White;
            this.labelPlaceAndTime.Location = new System.Drawing.Point(0, 325);
            this.labelPlaceAndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlaceAndTime.Name = "labelPlaceAndTime";
            this.labelPlaceAndTime.Padding = new System.Windows.Forms.Padding(12);
            this.labelPlaceAndTime.Size = new System.Drawing.Size(922, 46);
            this.labelPlaceAndTime.TabIndex = 12;
            this.labelPlaceAndTime.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(12);
            this.label9.Size = new System.Drawing.Size(922, 47);
            this.label9.TabIndex = 11;
            this.label9.Text = "Miejsce i czas:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTypesOfCharacters
            // 
            this.labelTypesOfCharacters.AutoEllipsis = true;
            this.labelTypesOfCharacters.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTypesOfCharacters.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypesOfCharacters.ForeColor = System.Drawing.Color.White;
            this.labelTypesOfCharacters.Location = new System.Drawing.Point(0, 232);
            this.labelTypesOfCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypesOfCharacters.Name = "labelTypesOfCharacters";
            this.labelTypesOfCharacters.Padding = new System.Windows.Forms.Padding(12);
            this.labelTypesOfCharacters.Size = new System.Drawing.Size(922, 46);
            this.labelTypesOfCharacters.TabIndex = 10;
            this.labelTypesOfCharacters.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(12);
            this.label7.Size = new System.Drawing.Size(922, 47);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rodzaje postaci";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTargetGroups
            // 
            this.labelTargetGroups.AutoEllipsis = true;
            this.labelTargetGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTargetGroups.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTargetGroups.ForeColor = System.Drawing.Color.White;
            this.labelTargetGroups.Location = new System.Drawing.Point(0, 140);
            this.labelTargetGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTargetGroups.Name = "labelTargetGroups";
            this.labelTargetGroups.Padding = new System.Windows.Forms.Padding(12);
            this.labelTargetGroups.Size = new System.Drawing.Size(922, 45);
            this.labelTargetGroups.TabIndex = 8;
            this.labelTargetGroups.Text = "N/A";
            // 
            // labeliGD
            // 
            this.labeliGD.AutoEllipsis = true;
            this.labeliGD.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeliGD.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeliGD.ForeColor = System.Drawing.Color.White;
            this.labeliGD.Location = new System.Drawing.Point(0, 93);
            this.labeliGD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeliGD.Name = "labeliGD";
            this.labeliGD.Padding = new System.Windows.Forms.Padding(12);
            this.labeliGD.Size = new System.Drawing.Size(922, 47);
            this.labeliGD.TabIndex = 7;
            this.labeliGD.Text = "Grupy docelowe:";
            this.labeliGD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoEllipsis = true;
            this.labelSpecies.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSpecies.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpecies.ForeColor = System.Drawing.Color.White;
            this.labelSpecies.Location = new System.Drawing.Point(0, 47);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Padding = new System.Windows.Forms.Padding(12);
            this.labelSpecies.Size = new System.Drawing.Size(922, 46);
            this.labelSpecies.TabIndex = 6;
            this.labelSpecies.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(12);
            this.label4.Size = new System.Drawing.Size(922, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gatunki:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelChangeStatus
            // 
            this.panelChangeStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChangeStatus.Location = new System.Drawing.Point(0, 277);
            this.panelChangeStatus.Name = "panelChangeStatus";
            this.panelChangeStatus.Padding = new System.Windows.Forms.Padding(5);
            this.panelChangeStatus.Size = new System.Drawing.Size(922, 250);
            this.panelChangeStatus.TabIndex = 6;
            this.panelChangeStatus.Visible = false;
            // 
            // panelViewIcon
            // 
            this.panelViewIcon.Controls.Add(this.pictureBox2);
            this.panelViewIcon.Controls.Add(this.buttonViewIconClose);
            this.panelViewIcon.Location = new System.Drawing.Point(136, 15);
            this.panelViewIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelViewIcon.Name = "panelViewIcon";
            this.panelViewIcon.Size = new System.Drawing.Size(666, 560);
            this.panelViewIcon.TabIndex = 6;
            this.panelViewIcon.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(625, 560);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonViewIconClose
            // 
            this.buttonViewIconClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonViewIconClose.FlatAppearance.BorderSize = 0;
            this.buttonViewIconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewIconClose.ForeColor = System.Drawing.Color.White;
            this.buttonViewIconClose.Location = new System.Drawing.Point(625, 0);
            this.buttonViewIconClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonViewIconClose.MaximumSize = new System.Drawing.Size(41, 29);
            this.buttonViewIconClose.Name = "buttonViewIconClose";
            this.buttonViewIconClose.Size = new System.Drawing.Size(41, 29);
            this.buttonViewIconClose.TabIndex = 6;
            this.buttonViewIconClose.Text = "X";
            this.buttonViewIconClose.UseVisualStyleBackColor = true;
            this.buttonViewIconClose.Click += new System.EventHandler(this.ButtonViewIconClose_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // panelNoDataSite
            // 
            this.panelNoDataSite.Controls.Add(this.label10);
            this.panelNoDataSite.Controls.Add(this.buttonBack);
            this.panelNoDataSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoDataSite.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelNoDataSite.Location = new System.Drawing.Point(0, 0);
            this.panelNoDataSite.Name = "panelNoDataSite";
            this.panelNoDataSite.Size = new System.Drawing.Size(939, 590);
            this.panelNoDataSite.TabIndex = 7;
            this.panelNoDataSite.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Już wkrótce...";
            // 
            // buttonBack
            // 
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(20, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(102, 24);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "<- Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelAdultContentMessage
            // 
            this.panelAdultContentMessage.Controls.Add(this.buttonAyes);
            this.panelAdultContentMessage.Controls.Add(this.label14);
            this.panelAdultContentMessage.Controls.Add(this.buttonAno);
            this.panelAdultContentMessage.Controls.Add(this.buttonBackA);
            this.panelAdultContentMessage.Controls.Add(this.label12);
            this.panelAdultContentMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdultContentMessage.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAdultContentMessage.ForeColor = System.Drawing.Color.White;
            this.panelAdultContentMessage.Location = new System.Drawing.Point(0, 0);
            this.panelAdultContentMessage.Name = "panelAdultContentMessage";
            this.panelAdultContentMessage.Size = new System.Drawing.Size(939, 590);
            this.panelAdultContentMessage.TabIndex = 7;
            this.panelAdultContentMessage.Visible = false;
            // 
            // buttonAyes
            // 
            this.buttonAyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyes.ForeColor = System.Drawing.Color.White;
            this.buttonAyes.Location = new System.Drawing.Point(20, 168);
            this.buttonAyes.Name = "buttonAyes";
            this.buttonAyes.Size = new System.Drawing.Size(110, 30);
            this.buttonAyes.TabIndex = 5;
            this.buttonAyes.Text = "Tak";
            this.buttonAyes.UseVisualStyleBackColor = true;
            this.buttonAyes.Click += new System.EventHandler(this.buttonAyes_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(540, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "(Jeśli jesteś pełnoletni(a) i nie chcesz widzieć tego komunikatu utwórz profil i " +
    "ustaw swój wiek.)";
            // 
            // buttonAno
            // 
            this.buttonAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAno.ForeColor = System.Drawing.Color.White;
            this.buttonAno.Location = new System.Drawing.Point(170, 168);
            this.buttonAno.Name = "buttonAno";
            this.buttonAno.Size = new System.Drawing.Size(110, 30);
            this.buttonAno.TabIndex = 3;
            this.buttonAno.Text = "Nie";
            this.buttonAno.UseVisualStyleBackColor = true;
            this.buttonAno.Click += new System.EventHandler(this.buttonAno_Click);
            // 
            // buttonBackA
            // 
            this.buttonBackA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackA.ForeColor = System.Drawing.Color.White;
            this.buttonBackA.Location = new System.Drawing.Point(20, 20);
            this.buttonBackA.Name = "buttonBackA";
            this.buttonBackA.Size = new System.Drawing.Size(110, 30);
            this.buttonBackA.TabIndex = 2;
            this.buttonBackA.Text = "<- Powrót";
            this.buttonBackA.UseVisualStyleBackColor = true;
            this.buttonBackA.Click += new System.EventHandler(this.buttonBackA_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(20, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(536, 48);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ten tytuł zawiera materiały przeznaczone dla osób pełnoletnich. \r\nCzy oświadczasz" +
    ", że ukończyłeś(aś) 18 lat?";
            // 
            // panelNoAccess
            // 
            this.panelNoAccess.Controls.Add(this.label15);
            this.panelNoAccess.Controls.Add(this.label16);
            this.panelNoAccess.Controls.Add(this.buttonBack2);
            this.panelNoAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoAccess.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelNoAccess.ForeColor = System.Drawing.Color.White;
            this.panelNoAccess.Location = new System.Drawing.Point(0, 0);
            this.panelNoAccess.Name = "panelNoAccess";
            this.panelNoAccess.Size = new System.Drawing.Size(939, 590);
            this.panelNoAccess.TabIndex = 8;
            this.panelNoAccess.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(20, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(272, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tytuł aktualnie jest niedostepny";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(20, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Powód: ograniczenie wiekowe";
            // 
            // buttonBack2
            // 
            this.buttonBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack2.ForeColor = System.Drawing.Color.White;
            this.buttonBack2.Location = new System.Drawing.Point(20, 20);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(110, 30);
            this.buttonBack2.TabIndex = 2;
            this.buttonBack2.Text = "<- Powrót";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // PageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelAdultContentMessage);
            this.Controls.Add(this.panelNoDataSite);
            this.Controls.Add(this.panelNoAccess);
            this.Controls.Add(this.panelViewIcon);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PageItem";
            this.Size = new System.Drawing.Size(939, 590);
            this.Load += new System.EventHandler(this.PageItem_Load);
            this.Resize += new System.EventHandler(this.PageItem_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel_comments.ResumeLayout(false);
            this.panel_comments.PerformLayout();
            this.panelRelatedSeries.ResumeLayout(false);
            this.panelRelatedSeries.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panelViewIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelNoDataSite.ResumeLayout(false);
            this.panelNoDataSite.PerformLayout();
            this.panelAdultContentMessage.ResumeLayout(false);
            this.panelAdultContentMessage.PerformLayout();
            this.panelNoAccess.ResumeLayout(false);
            this.panelNoAccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button;
        public System.Windows.Forms.PictureBox pictureBoxIcon;
        public System.Windows.Forms.Label labelotherTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.Label label_7;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labeliGD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labelSpecies;
        public System.Windows.Forms.Label labelOtherTags;
        public System.Windows.Forms.Label labelArchetype;
        public System.Windows.Forms.Label labelPlaceAndTime;
        public System.Windows.Forms.Label labelTypesOfCharacters;
        public System.Windows.Forms.Label labelTargetGroups;
        public System.Windows.Forms.Label labelStudio;
        public System.Windows.Forms.Label labelLE;
        public System.Windows.Forms.Label labelMPAA;
        public System.Windows.Forms.Label labelDateE;
        public System.Windows.Forms.Label labelDateS;
        public System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.Label labelType;
        public System.Windows.Forms.Label labelNE;
        private System.Windows.Forms.Label labeliNe;
        public System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonViewIconClose;
        public System.Windows.Forms.Panel panelViewIcon;
        private System.Windows.Forms.Label label6;
        public NewFlowLayoutPanel flowLayoutPanelRelatedSeries;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.LinkLabel linkLabelChangeState;
        private Panel panel_comments;
        private Panel panel_com_dockWebview;
        private Label label8;
        public Button button_Load_Comments;
        public Panel panelRelatedSeries;
        public FlowLayoutPanel flowLayoutPanelEpisode;
        private Panel panelNoDataSite;
        private Button buttonBack;
        private Label label10;
        private Panel panelAdultContentMessage;
        private Button buttonAyes;
        private Label label14;
        private Button buttonAno;
        private Button buttonBackA;
        private Label label12;
        private Panel panelNoAccess;
        private Label label15;
        private Label label16;
        private Button buttonBack2;
        private Panel panelChangeStatus;
    }
}
