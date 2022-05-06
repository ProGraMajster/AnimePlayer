namespace AnimePlayer
{
    partial class FormBrowser
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
            this.browserTabPage1 = new AnimePlayer.ControlsWinForms.BrowserTabPage();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // browserTabPage1
            // 
            this.browserTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.browserTabPage1.Dock = System.Windows.Forms.DockStyle.Top;
            this.browserTabPage1.Location = new System.Drawing.Point(0, 0);
            this.browserTabPage1.Name = "browserTabPage1";
            this.browserTabPage1.RadiusControls = 10;
            this.browserTabPage1.Size = new System.Drawing.Size(800, 42);
            this.browserTabPage1.TabIndex = 0;
            this.browserTabPage1.UseRoundingControl = true;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 42);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 408);
            this.panelContent.TabIndex = 1;
            // 
            // FormMainEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.browserTabPage1);
            this.Name = "FormMainEx";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsWinForms.BrowserTabPage browserTabPage1;
        public Panel panelContent;
    }
}