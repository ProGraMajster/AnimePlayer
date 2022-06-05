namespace AnimePlayer.Updater
{
    partial class FormUpdater
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timerReadSettingsFile = new System.Windows.Forms.Timer(this.components);
            this.timerCheckingForUpdates = new System.Windows.Forms.Timer(this.components);
            this.updaterSettingsPanel1 = new AnimePlayer.Updater.UpdaterSettingsPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Włącz podgląd logów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 178);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // timerReadSettingsFile
            // 
            this.timerReadSettingsFile.Interval = 10000;
            // 
            // updaterSettingsPanel1
            // 
            this.updaterSettingsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updaterSettingsPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.updaterSettingsPanel1.ForeColor = System.Drawing.Color.White;
            this.updaterSettingsPanel1.Location = new System.Drawing.Point(347, 0);
            this.updaterSettingsPanel1.Name = "updaterSettingsPanel1";
            this.updaterSettingsPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.updaterSettingsPanel1.Size = new System.Drawing.Size(276, 234);
            this.updaterSettingsPanel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(623, 234);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.updaterSettingsPanel1);
            this.Controls.Add(this.button1);
            this.Name = "FormUpdater";
            this.Text = "FormUpdater";
            this.Load += new System.EventHandler(this.FormUpdater_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timerReadSettingsFile;
        private System.Windows.Forms.Timer timerCheckingForUpdates;
        private UpdaterSettingsPanel updaterSettingsPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}