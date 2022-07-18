using System.Windows.Forms;

namespace AnimePlayer
{
    partial class FormStarter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStarter));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRunApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonCheckUpdate = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.checkBoxef = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxOtherWindow = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.checkBoxOffline = new System.Windows.Forms.CheckBox();
            this.buttonCloseSettings = new System.Windows.Forms.Button();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.labelLoadingApp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxArgs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(782, 69);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "AnimePlayer";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRunApp
            // 
            this.buttonRunApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRunApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRunApp.FlatAppearance.BorderSize = 0;
            this.buttonRunApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunApp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRunApp.ForeColor = System.Drawing.Color.YellowGreen;
            this.buttonRunApp.Location = new System.Drawing.Point(10, 10);
            this.buttonRunApp.Name = "buttonRunApp";
            this.buttonRunApp.Size = new System.Drawing.Size(307, 41);
            this.buttonRunApp.TabIndex = 1;
            this.buttonRunApp.Text = "Kliknij by uruchomić";
            this.buttonRunApp.UseVisualStyleBackColor = false;
            this.buttonRunApp.Click += new System.EventHandler(this.buttonRunApp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonBrowser);
            this.panel1.Controls.Add(this.buttonSetting);
            this.panel1.Controls.Add(this.buttonCheckUpdate);
            this.panel1.Controls.Add(this.buttonRunApp);
            this.panel1.Location = new System.Drawing.Point(233, 163);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(327, 184);
            this.panel1.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.YellowGreen;
            this.buttonExit.Location = new System.Drawing.Point(10, 174);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(307, 41);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Zamknij";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrowser.FlatAppearance.BorderSize = 0;
            this.buttonBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowser.ForeColor = System.Drawing.Color.YellowGreen;
            this.buttonBrowser.Location = new System.Drawing.Point(10, 133);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(307, 41);
            this.buttonBrowser.TabIndex = 5;
            this.buttonBrowser.Text = "Przeglądarka";
            this.buttonBrowser.UseVisualStyleBackColor = false;
            this.buttonBrowser.Visible = false;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetting.ForeColor = System.Drawing.Color.YellowGreen;
            this.buttonSetting.Location = new System.Drawing.Point(10, 92);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(307, 41);
            this.buttonSetting.TabIndex = 3;
            this.buttonSetting.Text = "Ustawienia";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonCheckUpdate
            // 
            this.buttonCheckUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCheckUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheckUpdate.FlatAppearance.BorderSize = 0;
            this.buttonCheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckUpdate.ForeColor = System.Drawing.Color.YellowGreen;
            this.buttonCheckUpdate.Location = new System.Drawing.Point(10, 51);
            this.buttonCheckUpdate.Name = "buttonCheckUpdate";
            this.buttonCheckUpdate.Size = new System.Drawing.Size(307, 41);
            this.buttonCheckUpdate.TabIndex = 2;
            this.buttonCheckUpdate.Text = "Sprawdź aktualizacje";
            this.buttonCheckUpdate.UseVisualStyleBackColor = false;
            this.buttonCheckUpdate.Visible = false;
            this.buttonCheckUpdate.Click += new System.EventHandler(this.buttonCheckUpdate_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoEllipsis = true;
            this.labelVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.Location = new System.Drawing.Point(0, 25);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(351, 345);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Version lib";
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSettings.Controls.Add(this.label6);
            this.panelSettings.Controls.Add(this.textBoxArgs);
            this.panelSettings.Controls.Add(this.checkBoxef);
            this.panelSettings.Controls.Add(this.panel2);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.checkBoxOtherWindow);
            this.panelSettings.Controls.Add(this.label4);
            this.panelSettings.Controls.Add(this.label3);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.checkBoxLocal);
            this.panelSettings.Controls.Add(this.checkBoxOffline);
            this.panelSettings.Controls.Add(this.buttonCloseSettings);
            this.panelSettings.Controls.Add(this.checkBoxDebug);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 69);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(782, 370);
            this.panelSettings.TabIndex = 4;
            this.panelSettings.Visible = false;
            // 
            // checkBoxef
            // 
            this.checkBoxef.AutoSize = true;
            this.checkBoxef.Location = new System.Drawing.Point(265, 7);
            this.checkBoxef.Name = "checkBoxef";
            this.checkBoxef.Size = new System.Drawing.Size(160, 19);
            this.checkBoxef.TabIndex = 10;
            this.checkBoxef.Text = "Funkcja eksperymentalne";
            this.checkBoxef.UseVisualStyleBackColor = true;
            this.checkBoxef.CheckedChanged += new System.EventHandler(this.checkBoxef_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelVersion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(431, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 370);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wersje bibliotek dll aplikacji";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inny wygląd ramki okna i dodatkowe funkcjie. Uwaga jest to eksperymentalna funkcj" +
    "a, może działać nie prawidłowo!";
            // 
            // checkBoxOtherWindow
            // 
            this.checkBoxOtherWindow.AutoSize = true;
            this.checkBoxOtherWindow.Location = new System.Drawing.Point(12, 258);
            this.checkBoxOtherWindow.Name = "checkBoxOtherWindow";
            this.checkBoxOtherWindow.Size = new System.Drawing.Size(177, 19);
            this.checkBoxOtherWindow.TabIndex = 7;
            this.checkBoxOtherWindow.Text = "Niestandardowa ramka okna";
            this.checkBoxOtherWindow.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Włączając tą opcję aplikacja nie będzie korzystać z internetu.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "Włączając tą opcję aplikacja będzie ładować główną zawartość tylko z lokalnych pl" +
    "ików. Uwaga, aplikacja dalej będzie mogła korzystać z internetu!";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Włączając tą opcję aplikacja będzie zbierała pełne logi i da dostęp do specjalnyc" +
    "h funkcji";
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(12, 99);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(89, 19);
            this.checkBoxLocal.TabIndex = 3;
            this.checkBoxLocal.Text = "Tryb lokalny";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            // 
            // checkBoxOffline
            // 
            this.checkBoxOffline.AutoSize = true;
            this.checkBoxOffline.Location = new System.Drawing.Point(12, 192);
            this.checkBoxOffline.Name = "checkBoxOffline";
            this.checkBoxOffline.Size = new System.Drawing.Size(85, 19);
            this.checkBoxOffline.TabIndex = 2;
            this.checkBoxOffline.Text = "Tryb offline";
            this.checkBoxOffline.UseVisualStyleBackColor = true;
            // 
            // buttonCloseSettings
            // 
            this.buttonCloseSettings.FlatAppearance.BorderSize = 0;
            this.buttonCloseSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseSettings.Location = new System.Drawing.Point(12, 3);
            this.buttonCloseSettings.Name = "buttonCloseSettings";
            this.buttonCloseSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseSettings.TabIndex = 1;
            this.buttonCloseSettings.Text = "<- Wróć";
            this.buttonCloseSettings.UseVisualStyleBackColor = true;
            this.buttonCloseSettings.Click += new System.EventHandler(this.buttonCloseSettings_Click);
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(12, 32);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(123, 19);
            this.checkBoxDebug.TabIndex = 0;
            this.checkBoxDebug.Text = "Tryb debugowania";
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            // 
            // labelLoadingApp
            // 
            this.labelLoadingApp.AutoSize = true;
            this.labelLoadingApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLoadingApp.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoadingApp.Location = new System.Drawing.Point(0, 0);
            this.labelLoadingApp.Name = "labelLoadingApp";
            this.labelLoadingApp.Size = new System.Drawing.Size(164, 37);
            this.labelLoadingApp.TabIndex = 5;
            this.labelLoadingApp.Text = "Ładowanie...";
            this.labelLoadingApp.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxArgs
            // 
            this.textBoxArgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.textBoxArgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxArgs.ForeColor = System.Drawing.Color.White;
            this.textBoxArgs.Location = new System.Drawing.Point(12, 350);
            this.textBoxArgs.Name = "textBoxArgs";
            this.textBoxArgs.Size = new System.Drawing.Size(350, 16);
            this.textBoxArgs.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Argumenty startowe :";
            // 
            // FormStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 439);
            this.Controls.Add(this.labelLoadingApp);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "FormStarter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStarter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStarter_FormClosed);
            this.Load += new System.EventHandler(this.FormStarter_Load);
            this.panel1.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Button buttonRunApp;
        private Panel panel1;
        private Button buttonExit;
        private Button buttonSetting;
        private Button buttonCheckUpdate;
        private Label labelVersion;
        private Panel panelSettings;
        private Button buttonCloseSettings;
        private CheckBox checkBoxDebug;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBoxLocal;
        private CheckBox checkBoxOffline;
        private Label label1;
        private CheckBox checkBoxOtherWindow;
        private Label labelLoadingApp;
        private Panel panel2;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBoxef;
        private Button buttonBrowser;
        private TextBox textBoxArgs;
        private Label label6;
    }
}