namespace AnimePlayer.Profile
{
    partial class ProfileSelectionPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.newFlowLayoutPanel1 = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.buttonProfileCreate = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelC4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelPass = new System.Windows.Forms.Panel();
            this.textBoxHelperQuestion = new System.Windows.Forms.TextBox();
            this.labelC7 = new System.Windows.Forms.Label();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.labelC6 = new System.Windows.Forms.Label();
            this.checkBoxPasswordState = new System.Windows.Forms.CheckBox();
            this.labelC5 = new System.Windows.Forms.Label();
            this.textBoxDescryption = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelC3 = new System.Windows.Forms.Label();
            this.buttonSetIcon = new System.Windows.Forms.Button();
            this.labelC2 = new System.Windows.Forms.Label();
            this.labelC1 = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelSelect.SuspendLayout();
            this.newFlowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 152);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybór profilu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSelect
            // 
            this.panelSelect.AutoScroll = true;
            this.panelSelect.Controls.Add(this.newFlowLayoutPanel1);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelect.Location = new System.Drawing.Point(0, 152);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(737, 150);
            this.panelSelect.TabIndex = 2;
            // 
            // newFlowLayoutPanel1
            // 
            this.newFlowLayoutPanel1.Controls.Add(this.buttonCreate);
            this.newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            this.newFlowLayoutPanel1.Size = new System.Drawing.Size(737, 150);
            this.newFlowLayoutPanel1.TabIndex = 0;
            this.newFlowLayoutPanel1.SizeChanged += new System.EventHandler(this.newFlowLayoutPanel1_SizeChanged);
            this.newFlowLayoutPanel1.VisibleChanged += new System.EventHandler(this.newFlowLayoutPanel1_VisibleChanged);
            this.newFlowLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.newFlowLayoutPanel1_ControlAdded);
            this.newFlowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.newFlowLayoutPanel1_ControlRemoved);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonCreate.FlatAppearance.BorderSize = 0;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreate.Location = new System.Drawing.Point(3, 3);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 100);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "+";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 159);
            this.panel3.TabIndex = 0;
            this.panel3.SizeChanged += new System.EventHandler(this.panel3_SizeChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kontynuuj bez profilu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.panelSelect);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(737, 461);
            this.panel.TabIndex = 1;
            // 
            // panelCreate
            // 
            this.panelCreate.AutoScroll = true;
            this.panelCreate.AutoSize = true;
            this.panelCreate.Controls.Add(this.buttonProfileCreate);
            this.panelCreate.Controls.Add(this.buttonBack);
            this.panelCreate.Controls.Add(this.dateTimePicker1);
            this.panelCreate.Controls.Add(this.labelC4);
            this.panelCreate.Controls.Add(this.groupBox1);
            this.panelCreate.Controls.Add(this.textBoxName);
            this.panelCreate.Controls.Add(this.labelC3);
            this.panelCreate.Controls.Add(this.buttonSetIcon);
            this.panelCreate.Controls.Add(this.labelC2);
            this.panelCreate.Controls.Add(this.labelC1);
            this.panelCreate.Controls.Add(this.pictureBoxIcon);
            this.panelCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreate.Location = new System.Drawing.Point(0, 0);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(737, 461);
            this.panelCreate.TabIndex = 1;
            this.panelCreate.Visible = false;
            this.panelCreate.SizeChanged += new System.EventHandler(this.panelCreate_SizeChanged);
            // 
            // buttonProfileCreate
            // 
            this.buttonProfileCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfileCreate.Location = new System.Drawing.Point(196, 636);
            this.buttonProfileCreate.Name = "buttonProfileCreate";
            this.buttonProfileCreate.Size = new System.Drawing.Size(300, 25);
            this.buttonProfileCreate.TabIndex = 14;
            this.buttonProfileCreate.Text = "Utwóz";
            this.buttonProfileCreate.UseVisualStyleBackColor = true;
            this.buttonProfileCreate.Click += new System.EventHandler(this.buttonProfileCreate_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(3, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 25);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "<- Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 24);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // labelC4
            // 
            this.labelC4.AutoSize = true;
            this.labelC4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC4.Location = new System.Drawing.Point(288, 257);
            this.labelC4.Name = "labelC4";
            this.labelC4.Size = new System.Drawing.Size(99, 19);
            this.labelC4.TabIndex = 11;
            this.labelC4.Text = "Rok urodzenia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelPass);
            this.groupBox1.Controls.Add(this.checkBoxPasswordState);
            this.groupBox1.Controls.Add(this.labelC5);
            this.groupBox1.Controls.Add(this.textBoxDescryption);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(193, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 307);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcjonalne";
            // 
            // panelPass
            // 
            this.panelPass.Controls.Add(this.textBoxHelperQuestion);
            this.panelPass.Controls.Add(this.labelC7);
            this.panelPass.Controls.Add(this.buttonShowPassword);
            this.panelPass.Controls.Add(this.maskedTextBoxPassword);
            this.panelPass.Controls.Add(this.labelC6);
            this.panelPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPass.Location = new System.Drawing.Point(3, 138);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(297, 166);
            this.panelPass.TabIndex = 11;
            this.panelPass.Visible = false;
            // 
            // textBoxHelperQuestion
            // 
            this.textBoxHelperQuestion.BackColor = System.Drawing.Color.Black;
            this.textBoxHelperQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHelperQuestion.ForeColor = System.Drawing.Color.White;
            this.textBoxHelperQuestion.Location = new System.Drawing.Point(15, 114);
            this.textBoxHelperQuestion.Multiline = true;
            this.textBoxHelperQuestion.Name = "textBoxHelperQuestion";
            this.textBoxHelperQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHelperQuestion.Size = new System.Drawing.Size(276, 44);
            this.textBoxHelperQuestion.TabIndex = 12;
            // 
            // labelC7
            // 
            this.labelC7.AutoSize = true;
            this.labelC7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC7.Location = new System.Drawing.Point(79, 92);
            this.labelC7.Name = "labelC7";
            this.labelC7.Size = new System.Drawing.Size(132, 19);
            this.labelC7.TabIndex = 15;
            this.labelC7.Text = "Pytanie pomocnicze";
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPassword.Location = new System.Drawing.Point(79, 54);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(111, 25);
            this.buttonShowPassword.TabIndex = 14;
            this.buttonShowPassword.Text = "Pokaż hasło";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.BackColor = System.Drawing.Color.Black;
            this.maskedTextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxPassword.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(32, 31);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.PasswordChar = '*';
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(220, 17);
            this.maskedTextBoxPassword.TabIndex = 13;
            // 
            // labelC6
            // 
            this.labelC6.AutoSize = true;
            this.labelC6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC6.Location = new System.Drawing.Point(112, 9);
            this.labelC6.Name = "labelC6";
            this.labelC6.Size = new System.Drawing.Size(44, 19);
            this.labelC6.TabIndex = 12;
            this.labelC6.Text = "Hasło";
            // 
            // checkBoxPasswordState
            // 
            this.checkBoxPasswordState.AutoSize = true;
            this.checkBoxPasswordState.Location = new System.Drawing.Point(82, 111);
            this.checkBoxPasswordState.Name = "checkBoxPasswordState";
            this.checkBoxPasswordState.Size = new System.Drawing.Size(115, 21);
            this.checkBoxPasswordState.TabIndex = 10;
            this.checkBoxPasswordState.Text = "Hasło do profilu";
            this.checkBoxPasswordState.UseVisualStyleBackColor = true;
            this.checkBoxPasswordState.CheckedChanged += new System.EventHandler(this.checkBoxPasswordState_CheckedChanged);
            // 
            // labelC5
            // 
            this.labelC5.AutoSize = true;
            this.labelC5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC5.Location = new System.Drawing.Point(96, 20);
            this.labelC5.Name = "labelC5";
            this.labelC5.Size = new System.Drawing.Size(85, 19);
            this.labelC5.TabIndex = 5;
            this.labelC5.Text = "Opis profilu";
            // 
            // textBoxDescryption
            // 
            this.textBoxDescryption.BackColor = System.Drawing.Color.Black;
            this.textBoxDescryption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescryption.ForeColor = System.Drawing.Color.White;
            this.textBoxDescryption.Location = new System.Drawing.Point(18, 43);
            this.textBoxDescryption.Multiline = true;
            this.textBoxDescryption.Name = "textBoxDescryption";
            this.textBoxDescryption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescryption.Size = new System.Drawing.Size(276, 44);
            this.textBoxDescryption.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Black;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(228, 226);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 19);
            this.textBoxName.TabIndex = 8;
            // 
            // labelC3
            // 
            this.labelC3.AutoSize = true;
            this.labelC3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC3.Location = new System.Drawing.Point(288, 204);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(98, 19);
            this.labelC3.TabIndex = 4;
            this.labelC3.Text = "Nazwa profilu";
            // 
            // buttonSetIcon
            // 
            this.buttonSetIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetIcon.Location = new System.Drawing.Point(288, 168);
            this.buttonSetIcon.Name = "buttonSetIcon";
            this.buttonSetIcon.Size = new System.Drawing.Size(100, 25);
            this.buttonSetIcon.TabIndex = 3;
            this.buttonSetIcon.Text = "Zmień";
            this.buttonSetIcon.UseVisualStyleBackColor = true;
            this.buttonSetIcon.Click += new System.EventHandler(this.buttonSetIcon_Click);
            // 
            // labelC2
            // 
            this.labelC2.AutoSize = true;
            this.labelC2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC2.Location = new System.Drawing.Point(274, 40);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(133, 19);
            this.labelC2.TabIndex = 2;
            this.labelC2.Text = "Zdejęcie profilowe";
            // 
            // labelC1
            // 
            this.labelC1.AutoSize = true;
            this.labelC1.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC1.Location = new System.Drawing.Point(265, 3);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(156, 24);
            this.labelC1.TabIndex = 1;
            this.labelC1.Text = "Tworzenie profilu";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(288, 62);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // ProfileSelectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelCreate);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ProfileSelectionPanel";
            this.Size = new System.Drawing.Size(737, 461);
            this.Load += new System.EventHandler(this.ProfileSelectionPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panelSelect.ResumeLayout(false);
            this.newFlowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanel1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Button buttonSetIcon;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelC5;
        private System.Windows.Forms.TextBox textBoxDescryption;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelC3;
        private System.Windows.Forms.Label labelC4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.Label labelC6;
        private System.Windows.Forms.CheckBox checkBoxPasswordState;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.TextBox textBoxHelperQuestion;
        private System.Windows.Forms.Label labelC7;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonProfileCreate;
    }
}
