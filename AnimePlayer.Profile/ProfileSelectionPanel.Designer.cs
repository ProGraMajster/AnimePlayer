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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panelSelect = new System.Windows.Forms.Panel();
            newFlowLayoutPanel1 = new ControlsWinForms.NewFlowLayoutPanel();
            buttonCreate = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            panel = new System.Windows.Forms.Panel();
            panelCreate = new System.Windows.Forms.Panel();
            buttonProfileCreate = new System.Windows.Forms.Button();
            buttonBack = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            labelC4 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panelPass = new System.Windows.Forms.Panel();
            textBoxHelperQuestion = new System.Windows.Forms.TextBox();
            labelC7 = new System.Windows.Forms.Label();
            buttonShowPassword = new System.Windows.Forms.Button();
            maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            labelC6 = new System.Windows.Forms.Label();
            checkBoxPasswordState = new System.Windows.Forms.CheckBox();
            labelC5 = new System.Windows.Forms.Label();
            textBoxDescryption = new System.Windows.Forms.TextBox();
            textBoxName = new System.Windows.Forms.TextBox();
            labelC3 = new System.Windows.Forms.Label();
            buttonSetIcon = new System.Windows.Forms.Button();
            labelC2 = new System.Windows.Forms.Label();
            labelC1 = new System.Windows.Forms.Label();
            pictureBoxIcon = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            panelSelect.SuspendLayout();
            newFlowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel.SuspendLayout();
            panelCreate.SuspendLayout();
            groupBox1.SuspendLayout();
            panelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(737, 152);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 82);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(737, 70);
            label1.TabIndex = 0;
            label1.Text = "Wybór profilu";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSelect
            // 
            panelSelect.AutoScroll = true;
            panelSelect.Controls.Add(newFlowLayoutPanel1);
            panelSelect.Dock = System.Windows.Forms.DockStyle.Top;
            panelSelect.Location = new System.Drawing.Point(0, 152);
            panelSelect.Name = "panelSelect";
            panelSelect.Size = new System.Drawing.Size(737, 150);
            panelSelect.TabIndex = 2;
            // 
            // newFlowLayoutPanel1
            // 
            newFlowLayoutPanel1.Controls.Add(buttonCreate);
            newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            newFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            newFlowLayoutPanel1.Size = new System.Drawing.Size(737, 150);
            newFlowLayoutPanel1.TabIndex = 0;
            newFlowLayoutPanel1.SizeChanged += newFlowLayoutPanel1_SizeChanged;
            newFlowLayoutPanel1.VisibleChanged += newFlowLayoutPanel1_VisibleChanged;
            newFlowLayoutPanel1.ControlAdded += newFlowLayoutPanel1_ControlAdded;
            newFlowLayoutPanel1.ControlRemoved += newFlowLayoutPanel1_ControlRemoved;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCreate.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCreate.Location = new System.Drawing.Point(3, 3);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(100, 100);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "+";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 302);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(737, 154);
            panel3.TabIndex = 0;
            panel3.SizeChanged += panel3_SizeChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(3, 6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(177, 31);
            button1.TabIndex = 0;
            button1.Text = "Kontynuuj bez profilu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel
            // 
            panel.Controls.Add(panel3);
            panel.Controls.Add(panelSelect);
            panel.Controls.Add(panel1);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(737, 456);
            panel.TabIndex = 1;
            // 
            // panelCreate
            // 
            panelCreate.AutoScroll = true;
            panelCreate.AutoSize = true;
            panelCreate.Controls.Add(buttonProfileCreate);
            panelCreate.Controls.Add(buttonBack);
            panelCreate.Controls.Add(dateTimePicker1);
            panelCreate.Controls.Add(labelC4);
            panelCreate.Controls.Add(groupBox1);
            panelCreate.Controls.Add(textBoxName);
            panelCreate.Controls.Add(labelC3);
            panelCreate.Controls.Add(buttonSetIcon);
            panelCreate.Controls.Add(labelC2);
            panelCreate.Controls.Add(labelC1);
            panelCreate.Controls.Add(pictureBoxIcon);
            panelCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCreate.Location = new System.Drawing.Point(0, 0);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new System.Drawing.Size(737, 456);
            panelCreate.TabIndex = 1;
            panelCreate.Visible = false;
            panelCreate.SizeChanged += panelCreate_SizeChanged;
            // 
            // buttonProfileCreate
            // 
            buttonProfileCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonProfileCreate.Location = new System.Drawing.Point(196, 636);
            buttonProfileCreate.Name = "buttonProfileCreate";
            buttonProfileCreate.Size = new System.Drawing.Size(300, 25);
            buttonProfileCreate.TabIndex = 14;
            buttonProfileCreate.Text = "Utwórz";
            buttonProfileCreate.UseVisualStyleBackColor = true;
            buttonProfileCreate.Click += buttonProfileCreate_Click;
            // 
            // buttonBack
            // 
            buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBack.Location = new System.Drawing.Point(3, 5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(100, 25);
            buttonBack.TabIndex = 13;
            buttonBack.Text = "<- Powrót";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(288, 278);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(98, 24);
            dateTimePicker1.TabIndex = 12;
            // 
            // labelC4
            // 
            labelC4.AutoSize = true;
            labelC4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelC4.Location = new System.Drawing.Point(288, 257);
            labelC4.Name = "labelC4";
            labelC4.Size = new System.Drawing.Size(99, 19);
            labelC4.TabIndex = 11;
            labelC4.Text = "Rok urodzenia";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelPass);
            groupBox1.Controls.Add(checkBoxPasswordState);
            groupBox1.Controls.Add(labelC5);
            groupBox1.Controls.Add(textBoxDescryption);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(193, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(303, 307);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opcjonalne";
            groupBox1.Visible = false;
            // 
            // panelPass
            // 
            panelPass.Controls.Add(textBoxHelperQuestion);
            panelPass.Controls.Add(labelC7);
            panelPass.Controls.Add(buttonShowPassword);
            panelPass.Controls.Add(maskedTextBoxPassword);
            panelPass.Controls.Add(labelC6);
            panelPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelPass.Location = new System.Drawing.Point(3, 138);
            panelPass.Name = "panelPass";
            panelPass.Size = new System.Drawing.Size(297, 166);
            panelPass.TabIndex = 11;
            panelPass.Visible = false;
            // 
            // textBoxHelperQuestion
            // 
            textBoxHelperQuestion.BackColor = System.Drawing.Color.Black;
            textBoxHelperQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxHelperQuestion.ForeColor = System.Drawing.Color.White;
            textBoxHelperQuestion.Location = new System.Drawing.Point(15, 114);
            textBoxHelperQuestion.Multiline = true;
            textBoxHelperQuestion.Name = "textBoxHelperQuestion";
            textBoxHelperQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxHelperQuestion.Size = new System.Drawing.Size(276, 44);
            textBoxHelperQuestion.TabIndex = 12;
            // 
            // labelC7
            // 
            labelC7.AutoSize = true;
            labelC7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelC7.Location = new System.Drawing.Point(79, 92);
            labelC7.Name = "labelC7";
            labelC7.Size = new System.Drawing.Size(132, 19);
            labelC7.TabIndex = 15;
            labelC7.Text = "Pytanie pomocnicze";
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonShowPassword.Location = new System.Drawing.Point(79, 54);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new System.Drawing.Size(111, 25);
            buttonShowPassword.TabIndex = 14;
            buttonShowPassword.Text = "Pokaż hasło";
            buttonShowPassword.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPassword
            // 
            maskedTextBoxPassword.BackColor = System.Drawing.Color.Black;
            maskedTextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maskedTextBoxPassword.ForeColor = System.Drawing.Color.White;
            maskedTextBoxPassword.Location = new System.Drawing.Point(32, 31);
            maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Size = new System.Drawing.Size(220, 17);
            maskedTextBoxPassword.TabIndex = 13;
            // 
            // labelC6
            // 
            labelC6.AutoSize = true;
            labelC6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelC6.Location = new System.Drawing.Point(112, 9);
            labelC6.Name = "labelC6";
            labelC6.Size = new System.Drawing.Size(44, 19);
            labelC6.TabIndex = 12;
            labelC6.Text = "Hasło";
            // 
            // checkBoxPasswordState
            // 
            checkBoxPasswordState.AutoSize = true;
            checkBoxPasswordState.Location = new System.Drawing.Point(82, 112);
            checkBoxPasswordState.Name = "checkBoxPasswordState";
            checkBoxPasswordState.Size = new System.Drawing.Size(115, 21);
            checkBoxPasswordState.TabIndex = 10;
            checkBoxPasswordState.Text = "Hasło do profilu";
            checkBoxPasswordState.UseVisualStyleBackColor = true;
            checkBoxPasswordState.CheckedChanged += checkBoxPasswordState_CheckedChanged;
            // 
            // labelC5
            // 
            labelC5.AutoSize = true;
            labelC5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelC5.Location = new System.Drawing.Point(96, 20);
            labelC5.Name = "labelC5";
            labelC5.Size = new System.Drawing.Size(85, 19);
            labelC5.TabIndex = 5;
            labelC5.Text = "Opis profilu";
            // 
            // textBoxDescryption
            // 
            textBoxDescryption.BackColor = System.Drawing.Color.Black;
            textBoxDescryption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxDescryption.ForeColor = System.Drawing.Color.White;
            textBoxDescryption.Location = new System.Drawing.Point(18, 43);
            textBoxDescryption.Multiline = true;
            textBoxDescryption.Name = "textBoxDescryption";
            textBoxDescryption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxDescryption.Size = new System.Drawing.Size(276, 44);
            textBoxDescryption.TabIndex = 9;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = System.Drawing.Color.Black;
            textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxName.ForeColor = System.Drawing.Color.White;
            textBoxName.Location = new System.Drawing.Point(228, 226);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(220, 19);
            textBoxName.TabIndex = 8;
            // 
            // labelC3
            // 
            labelC3.AutoSize = true;
            labelC3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelC3.Location = new System.Drawing.Point(288, 204);
            labelC3.Name = "labelC3";
            labelC3.Size = new System.Drawing.Size(98, 19);
            labelC3.TabIndex = 4;
            labelC3.Text = "Nazwa profilu";
            // 
            // buttonSetIcon
            // 
            buttonSetIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSetIcon.Location = new System.Drawing.Point(288, 168);
            buttonSetIcon.Name = "buttonSetIcon";
            buttonSetIcon.Size = new System.Drawing.Size(100, 25);
            buttonSetIcon.TabIndex = 3;
            buttonSetIcon.Text = "Zmień";
            buttonSetIcon.UseVisualStyleBackColor = true;
            buttonSetIcon.Click += buttonSetIcon_Click;
            // 
            // labelC2
            // 
            labelC2.AutoSize = true;
            labelC2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelC2.Location = new System.Drawing.Point(274, 40);
            labelC2.Name = "labelC2";
            labelC2.Size = new System.Drawing.Size(133, 19);
            labelC2.TabIndex = 2;
            labelC2.Text = "Zdejęcie profilowe";
            // 
            // labelC1
            // 
            labelC1.AutoSize = true;
            labelC1.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelC1.Location = new System.Drawing.Point(265, 3);
            labelC1.Name = "labelC1";
            labelC1.Size = new System.Drawing.Size(156, 24);
            labelC1.TabIndex = 1;
            labelC1.Text = "Tworzenie profilu";
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new System.Drawing.Point(288, 62);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new System.Drawing.Size(100, 100);
            pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // ProfileSelectionPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            Controls.Add(panelCreate);
            Controls.Add(panel);
            Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.White;
            Name = "ProfileSelectionPanel";
            Size = new System.Drawing.Size(737, 456);
            Load += ProfileSelectionPanel_Load;
            panel1.ResumeLayout(false);
            panelSelect.ResumeLayout(false);
            newFlowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel.ResumeLayout(false);
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelPass.ResumeLayout(false);
            panelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
