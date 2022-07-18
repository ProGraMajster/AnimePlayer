using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    partial class BrowserWebView2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReundo = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.timerRe = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxLink);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonReundo);
            this.panel1.Controls.Add(this.buttonUndo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 21);
            this.panel1.TabIndex = 1;
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBoxLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLink.ForeColor = System.Drawing.Color.White;
            this.textBoxLink.Location = new System.Drawing.Point(99, 0);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(670, 18);
            this.textBoxLink.TabIndex = 0;
            this.textBoxLink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLink_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(769, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 21);
            this.panel2.TabIndex = 4;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(85, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(27, 21);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = ":";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(70, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(29, 21);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "↻";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReundo
            // 
            this.buttonReundo.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReundo.FlatAppearance.BorderSize = 0;
            this.buttonReundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReundo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReundo.ForeColor = System.Drawing.Color.White;
            this.buttonReundo.Location = new System.Drawing.Point(35, 0);
            this.buttonReundo.Name = "buttonReundo";
            this.buttonReundo.Size = new System.Drawing.Size(35, 21);
            this.buttonReundo.TabIndex = 2;
            this.buttonReundo.Text = "->";
            this.buttonReundo.UseVisualStyleBackColor = true;
            this.buttonReundo.Click += new System.EventHandler(this.buttonReundo_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUndo.FlatAppearance.BorderSize = 0;
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUndo.ForeColor = System.Drawing.Color.White;
            this.buttonUndo.Location = new System.Drawing.Point(0, 0);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(35, 21);
            this.buttonUndo.TabIndex = 1;
            this.buttonUndo.Text = "<-";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 21);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(881, 569);
            this.webView.Source = new System.Uri("https://www.google.com/webhp", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            this.webView.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webView_CoreWebView2InitializationCompleted);
            this.webView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView_NavigationStarting);
            this.webView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView_NavigationCompleted);
            this.webView.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.webView_SourceChanged);
            this.webView.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.webView_ContentLoading);
            // 
            // timerRe
            // 
            this.timerRe.Tick += new System.EventHandler(this.timerRe_Tick);
            // 
            // BrowserWebView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.webView);
            this.Controls.Add(this.panel1);
            this.Name = "BrowserWebView2";
            this.Size = new System.Drawing.Size(881, 590);
            this.Resize += new System.EventHandler(this.BrowserWebView2_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private TextBox textBoxLink;
        private Button buttonReundo;
        private Button buttonUndo;
        private Button buttonRefresh;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Timer timerRe;
        private Panel panel2;
        private Button buttonMenu;
    }
}
