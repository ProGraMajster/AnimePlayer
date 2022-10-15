using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AnimePlayer.Class;

namespace AnimePlayerLibrary.UI
{
    public partial class HelpPage : UserControl
    {
        public Delegate DelegateLoadContentToForm;
        public HelpPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!Directory.Exists(AppFolders.UpdatedContentFolder))
                {
                    Directory.CreateDirectory(AppFolders.UpdatedContentFolder);
                }
                AnimePlayer.Core.OpenLinks.Start(AppFolders.UpdatedContentFolder);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DelegateLoadContentToForm.DynamicInvoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
