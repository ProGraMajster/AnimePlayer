using AnimePlayerLibrary;
using System;
using System.Windows.Forms;
using System.IO;
using AnimePlayer.CNM;

namespace AnimePlayer
{
    public partial class PageSettings : UserControl
    {
        private FormMainPlayer FormMainPlayer;
        public PageSettings(FormMainPlayer okno)
        {
            InitializeComponent();
            FormMainPlayer = okno;
            this.Dock = DockStyle.Fill;
            checkBoxRoundedEdges.Checked = AnimePlayer.Properties.Settings.Default.RoundingControl;
            labelServer.Text = "Serwer danych nr.: " + okno.server;
            timerRefreshValue.Start();
            labelAppRamUsage_View.Text = okno.labelAppRamUsage.Text;
            if (AnimePlayer.Properties.Settings.Default.RoundingControl)
            {
                ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonClose;
                rc.CornerRadius = 15;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void checkBoxRoundedEdges_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                AnimePlayer.Properties.Settings.Default.RoundingControl = checkBoxRoundedEdges.Checked;
                AnimePlayer.Properties.Settings.Default.Save();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonSetThemeFile_Click(object sender, EventArgs e)
        {
            if(openFileDialogThemeFile.ShowDialog() == DialogResult.OK)
            {
                FormMainPlayer.panelLoading.Show();
                FormMainPlayer.panelLoading.BringToFront();
                Application.DoEvents();
                try
                {
                    FormMainPlayer.labelLoadingDetails.Text = "Ładowanie motywu...";
                    Application.DoEvents();
                    FormMainPlayer.usedThemeColors = true;
                    File.WriteAllText("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\theme.txt", openFileDialogThemeFile.FileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                FormMainPlayer.panelLoading.Hide();
            }
        }

        private void buttonThemeReset_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Czy napewno?","Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.No)
                {
                    return;
                }
                FormMainPlayer.panelLoading.Show();
                FormMainPlayer.panelLoading.BringToFront();
                FormMainPlayer.labelLoadingDetails.Text = "Ładowanie motywu...";
                Application.DoEvents();
                if (File.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\theme.txt"))
                {
                    File.Delete("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\theme.txt");
                }
                Application.Restart();
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
            FormMainPlayer.panelLoading.Hide();
        }

        private void timerRefreshValue_Tick(object sender, EventArgs e)
        {
            labelAppRamUsage_View.Text = FormMainPlayer.labelAppRamUsage.Text;
        }
    }
}