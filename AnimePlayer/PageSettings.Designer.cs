
using System.Windows.Forms;

namespace AnimePlayer
{
    partial class PageSettings
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonThemeReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buttonSetThemeFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxRoundedEdges = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogThemeFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelAppRamUsage_View = new System.Windows.Forms.Label();
            this.timerRefreshValue = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ustawienia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(752, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.MaximumSize = new System.Drawing.Size(70, 46);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 46);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Zamknij stronę";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonThemeReset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.buttonSetThemeFile);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBoxRoundedEdges);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(395, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wygląd";
            this.groupBox1.Visible = false;
            // 
            // buttonThemeReset
            // 
            this.buttonThemeReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonThemeReset.FlatAppearance.BorderSize = 0;
            this.buttonThemeReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemeReset.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThemeReset.ForeColor = System.Drawing.Color.White;
            this.buttonThemeReset.Location = new System.Drawing.Point(137, 99);
            this.buttonThemeReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonThemeReset.Name = "buttonThemeReset";
            this.buttonThemeReset.Size = new System.Drawing.Size(110, 33);
            this.buttonThemeReset.TabIndex = 10;
            this.buttonThemeReset.Text = "Reset motyw";
            this.buttonThemeReset.UseVisualStyleBackColor = false;
            this.buttonThemeReset.Visible = false;
            this.buttonThemeReset.Click += new System.EventHandler(this.ButtonThemeReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zmień motyw aplikacji wybierając plik motywu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(15, 47);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(167, 19);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Sugiestie w wyszukiwarce";
            this.toolTip.SetToolTip(this.checkBox2, "Zres");
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // buttonSetThemeFile
            // 
            this.buttonSetThemeFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonSetThemeFile.FlatAppearance.BorderSize = 0;
            this.buttonSetThemeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetThemeFile.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetThemeFile.ForeColor = System.Drawing.Color.White;
            this.buttonSetThemeFile.Location = new System.Drawing.Point(19, 99);
            this.buttonSetThemeFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSetThemeFile.Name = "buttonSetThemeFile";
            this.buttonSetThemeFile.Size = new System.Drawing.Size(110, 33);
            this.buttonSetThemeFile.TabIndex = 8;
            this.buttonSetThemeFile.Text = "Wybierz plik";
            this.buttonSetThemeFile.UseVisualStyleBackColor = false;
            this.buttonSetThemeFile.Visible = false;
            this.buttonSetThemeFile.Click += new System.EventHandler(this.ButtonSetThemeFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(387, 77);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Strona Główna";
            this.groupBox2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(15, 22);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Wiadomości na stronie głównej";
            this.toolTip.SetToolTip(this.checkBox1, "Zres");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoundedEdges
            // 
            this.checkBoxRoundedEdges.AutoSize = true;
            this.checkBoxRoundedEdges.Checked = true;
            this.checkBoxRoundedEdges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRoundedEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxRoundedEdges.Location = new System.Drawing.Point(15, 22);
            this.checkBoxRoundedEdges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxRoundedEdges.Name = "checkBoxRoundedEdges";
            this.checkBoxRoundedEdges.Size = new System.Drawing.Size(179, 19);
            this.checkBoxRoundedEdges.TabIndex = 0;
            this.checkBoxRoundedEdges.Text = "Zaokrąglone kanty kontrolek";
            this.toolTip.SetToolTip(this.checkBoxRoundedEdges, "Zres");
            this.checkBoxRoundedEdges.UseVisualStyleBackColor = true;
            this.checkBoxRoundedEdges.CheckedChanged += new System.EventHandler(this.CheckBoxRoundedEdges_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelAppRamUsage_View
            // 
            this.labelAppRamUsage_View.AutoSize = true;
            this.labelAppRamUsage_View.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAppRamUsage_View.ForeColor = System.Drawing.Color.White;
            this.labelAppRamUsage_View.Location = new System.Drawing.Point(362, 12);
            this.labelAppRamUsage_View.Margin = new System.Windows.Forms.Padding(0);
            this.labelAppRamUsage_View.Name = "labelAppRamUsage_View";
            this.labelAppRamUsage_View.Size = new System.Drawing.Size(158, 17);
            this.labelAppRamUsage_View.TabIndex = 11;
            this.labelAppRamUsage_View.Text = "APP_USAGE_RAM_VALUE";
            this.labelAppRamUsage_View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRefreshValue
            // 
            this.timerRefreshValue.Interval = 1000;
            this.timerRefreshValue.Tick += new System.EventHandler(this.TimerRefreshValue_Tick);
            // 
            // PageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.labelAppRamUsage_View);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClose);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PageSettings";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(834, 580);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox checkBoxRoundedEdges;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetThemeFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogThemeFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonThemeReset;
        private Label labelAppRamUsage_View;
        private System.Windows.Forms.Timer timerRefreshValue;
    }
}
