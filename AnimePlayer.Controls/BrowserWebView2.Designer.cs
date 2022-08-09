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
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelCda = new System.Windows.Forms.Panel();
            this.labelCdaDownloadProgres = new System.Windows.Forms.Label();
            this.progressBarCdaDownload = new System.Windows.Forms.ProgressBar();
            this.buttonCdaDwonload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCdaQualityVideo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCdaUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelCda.SuspendLayout();
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
            this.textBoxLink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxLink_KeyDown);
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
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
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
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
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
            this.buttonReundo.Click += new System.EventHandler(this.ButtonReundo_Click);
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
            this.buttonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
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
            this.webView.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.WebView_CoreWebView2InitializationCompleted);
            this.webView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.WebView_NavigationStarting);
            this.webView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WebView_NavigationCompleted);
            this.webView.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.WebView_SourceChanged);
            this.webView.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.WebView_ContentLoading);
            this.webView.Click += new System.EventHandler(this.WebView_Click);
            // 
            // timerRe
            // 
            this.timerRe.Tick += new System.EventHandler(this.TimerRe_Tick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(10, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ustawienia przeglądarki WebView2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Location = new System.Drawing.Point(633, 21);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(10);
            this.panelMenu.Size = new System.Drawing.Size(248, 311);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelCda);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 158);
            this.panel4.TabIndex = 2;
            // 
            // panelCda
            // 
            this.panelCda.Controls.Add(this.labelCdaDownloadProgres);
            this.panelCda.Controls.Add(this.progressBarCdaDownload);
            this.panelCda.Controls.Add(this.buttonCdaDwonload);
            this.panelCda.Controls.Add(this.label3);
            this.panelCda.Controls.Add(this.comboBoxCdaQualityVideo);
            this.panelCda.Controls.Add(this.label2);
            this.panelCda.Controls.Add(this.textBoxCdaUrl);
            this.panelCda.Controls.Add(this.label1);
            this.panelCda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCda.ForeColor = System.Drawing.Color.White;
            this.panelCda.Location = new System.Drawing.Point(0, 0);
            this.panelCda.Name = "panelCda";
            this.panelCda.Size = new System.Drawing.Size(228, 158);
            this.panelCda.TabIndex = 0;
            this.panelCda.Visible = false;
            this.panelCda.VisibleChanged += new System.EventHandler(this.PanelCda_VisibleChanged);
            // 
            // labelCdaDownloadProgres
            // 
            this.labelCdaDownloadProgres.AutoEllipsis = true;
            this.labelCdaDownloadProgres.AutoSize = true;
            this.labelCdaDownloadProgres.Location = new System.Drawing.Point(0, 125);
            this.labelCdaDownloadProgres.Name = "labelCdaDownloadProgres";
            this.labelCdaDownloadProgres.Size = new System.Drawing.Size(10, 15);
            this.labelCdaDownloadProgres.TabIndex = 7;
            this.labelCdaDownloadProgres.Text = ":";
            // 
            // progressBarCdaDownload
            // 
            this.progressBarCdaDownload.Location = new System.Drawing.Point(4, 143);
            this.progressBarCdaDownload.Name = "progressBarCdaDownload";
            this.progressBarCdaDownload.Size = new System.Drawing.Size(221, 15);
            this.progressBarCdaDownload.TabIndex = 6;
            // 
            // buttonCdaDwonload
            // 
            this.buttonCdaDwonload.ForeColor = System.Drawing.Color.Black;
            this.buttonCdaDwonload.Location = new System.Drawing.Point(126, 99);
            this.buttonCdaDwonload.Name = "buttonCdaDwonload";
            this.buttonCdaDwonload.Size = new System.Drawing.Size(75, 23);
            this.buttonCdaDwonload.TabIndex = 5;
            this.buttonCdaDwonload.Text = "Pobierz";
            this.buttonCdaDwonload.UseVisualStyleBackColor = true;
            this.buttonCdaDwonload.Click += new System.EventHandler(this.ButtonCdaDwonload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jakość:";
            // 
            // comboBoxCdaQualityVideo
            // 
            this.comboBoxCdaQualityVideo.FormattingEnabled = true;
            this.comboBoxCdaQualityVideo.Items.AddRange(new object[] {
            "360p",
            "480p",
            "720p",
            "1080p"});
            this.comboBoxCdaQualityVideo.Location = new System.Drawing.Point(9, 99);
            this.comboBoxCdaQualityVideo.Name = "comboBoxCdaQualityVideo";
            this.comboBoxCdaQualityVideo.Size = new System.Drawing.Size(86, 23);
            this.comboBoxCdaQualityVideo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres URL:";
            // 
            // textBoxCdaUrl
            // 
            this.textBoxCdaUrl.Location = new System.Drawing.Point(9, 55);
            this.textBoxCdaUrl.Name = "textBoxCdaUrl";
            this.textBoxCdaUrl.Size = new System.Drawing.Size(216, 23);
            this.textBoxCdaUrl.TabIndex = 1;
            this.textBoxCdaUrl.TextChanged += new System.EventHandler(this.TextBoxCdaUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pobieracz cda";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(10, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Histria przeglądarki WebView2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(10, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Zamknij menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // BrowserWebView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.panel1);
            this.Name = "BrowserWebView2";
            this.Size = new System.Drawing.Size(881, 590);
            this.SizeChanged += new System.EventHandler(this.BrowserWebView2_SizeChanged);
            this.Resize += new System.EventHandler(this.BrowserWebView2_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelCda.ResumeLayout(false);
            this.panelCda.PerformLayout();
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
        private Button button1;
        private Panel panelMenu;
        private Panel panel4;
        private Button button2;
        private Panel panelCda;
        private Label label2;
        private TextBox textBoxCdaUrl;
        private Label label1;
        private Button buttonCdaDwonload;
        private Label label3;
        private ComboBox comboBoxCdaQualityVideo;
        private Button button4;
        private Label labelCdaDownloadProgres;
        private ProgressBar progressBarCdaDownload;
    }
}
