namespace AnimePlayer.Updater
{
    partial class UpdaterSettingsPanel
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
            this.checkBoxUpdateOpenApp = new System.Windows.Forms.CheckBox();
            this.checkBoxBackUpdate = new System.Windows.Forms.CheckBox();
            this.labelUpdateTimerInterval = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Panel();
            this.buttonSaveUpdaterSetting = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.checkBoxDevVersion = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.S.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxUpdateOpenApp
            // 
            this.checkBoxUpdateOpenApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUpdateOpenApp.Location = new System.Drawing.Point(3, 19);
            this.checkBoxUpdateOpenApp.Name = "checkBoxUpdateOpenApp";
            this.checkBoxUpdateOpenApp.Size = new System.Drawing.Size(260, 35);
            this.checkBoxUpdateOpenApp.TabIndex = 0;
            this.checkBoxUpdateOpenApp.Text = "Sprawdż czy jest dostępna aktualizacja";
            this.checkBoxUpdateOpenApp.UseVisualStyleBackColor = true;
            this.checkBoxUpdateOpenApp.CheckedChanged += new System.EventHandler(this.checkBoxUpdateOpenApp_CheckedChanged);
            // 
            // checkBoxBackUpdate
            // 
            this.checkBoxBackUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxBackUpdate.Location = new System.Drawing.Point(3, 54);
            this.checkBoxBackUpdate.Name = "checkBoxBackUpdate";
            this.checkBoxBackUpdate.Size = new System.Drawing.Size(260, 53);
            this.checkBoxBackUpdate.TabIndex = 1;
            this.checkBoxBackUpdate.Text = "Sprawdzaj w tle czy jest dostępna aktualizacja (gdy aplikacja jest uruchomiona)";
            this.checkBoxBackUpdate.UseVisualStyleBackColor = true;
            this.checkBoxBackUpdate.CheckedChanged += new System.EventHandler(this.checkBoxBackUpdate_CheckedChanged);
            // 
            // labelUpdateTimerInterval
            // 
            this.labelUpdateTimerInterval.AutoEllipsis = true;
            this.labelUpdateTimerInterval.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelUpdateTimerInterval.Location = new System.Drawing.Point(0, 0);
            this.labelUpdateTimerInterval.Name = "labelUpdateTimerInterval";
            this.labelUpdateTimerInterval.Size = new System.Drawing.Size(143, 81);
            this.labelUpdateTimerInterval.TabIndex = 2;
            this.labelUpdateTimerInterval.Text = "Co ile (w milisekundach)\r\nDomyślnie ustawiony(Minimalna wartość) to: 1800000 czyl" +
    "i 30 minut";
            // 
            // S
            // 
            this.S.Controls.Add(this.buttonSaveUpdaterSetting);
            this.S.Controls.Add(this.numericUpDown1);
            this.S.Controls.Add(this.labelUpdateTimerInterval);
            this.S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S.Location = new System.Drawing.Point(3, 142);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(260, 81);
            this.S.TabIndex = 3;
            // 
            // buttonSaveUpdaterSetting
            // 
            this.buttonSaveUpdaterSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSaveUpdaterSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSaveUpdaterSetting.FlatAppearance.BorderSize = 0;
            this.buttonSaveUpdaterSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveUpdaterSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSaveUpdaterSetting.Location = new System.Drawing.Point(143, 42);
            this.buttonSaveUpdaterSetting.Name = "buttonSaveUpdaterSetting";
            this.buttonSaveUpdaterSetting.Size = new System.Drawing.Size(117, 39);
            this.buttonSaveUpdaterSetting.TabIndex = 4;
            this.buttonSaveUpdaterSetting.Text = "Zapisz ustawienia sekcji";
            this.buttonSaveUpdaterSetting.UseVisualStyleBackColor = false;
            this.buttonSaveUpdaterSetting.Click += new System.EventHandler(this.buttonSaveUpdaterSetting_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDown1.Location = new System.Drawing.Point(143, 0);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1800000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1800000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1800000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.S);
            this.groupBoxMain.Controls.Add(this.checkBoxDevVersion);
            this.groupBoxMain.Controls.Add(this.checkBoxBackUpdate);
            this.groupBoxMain.Controls.Add(this.checkBoxUpdateOpenApp);
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMain.ForeColor = System.Drawing.Color.White;
            this.groupBoxMain.Location = new System.Drawing.Point(5, 5);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(266, 226);
            this.groupBoxMain.TabIndex = 4;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Ustawienia aktualizacji";
            // 
            // checkBoxDevVersion
            // 
            this.checkBoxDevVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxDevVersion.Location = new System.Drawing.Point(3, 107);
            this.checkBoxDevVersion.Name = "checkBoxDevVersion";
            this.checkBoxDevVersion.Size = new System.Drawing.Size(260, 35);
            this.checkBoxDevVersion.TabIndex = 4;
            this.checkBoxDevVersion.Text = "Pobieraj wersjie z kanału deweloperskiego";
            this.checkBoxDevVersion.UseVisualStyleBackColor = true;
            this.checkBoxDevVersion.CheckedChanged += new System.EventHandler(this.checkBoxDevVersion_CheckedChanged);
            // 
            // UpdaterSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.groupBoxMain);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UpdaterSettingsPanel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(276, 236);
            this.ForeColorChanged += new System.EventHandler(this.UpdaterSettingsPanel_ForeColorChanged);
            this.S.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox checkBoxUpdateOpenApp;
        private CheckBox checkBoxBackUpdate;
        private Label labelUpdateTimerInterval;
        private Panel S;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBoxMain;
        private ToolTip toolTip1;
        public Button buttonSaveUpdaterSetting;
        private CheckBox checkBoxDevVersion;
    }
}
