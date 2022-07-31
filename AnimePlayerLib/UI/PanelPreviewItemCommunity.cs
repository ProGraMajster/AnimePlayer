using AnimePlayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary.UI
{
    public partial class PanelPreviewItemCommunity : UserControl
    {
        public PanelPreviewItemCommunity()
        {
            InitializeComponent();
        }
        public PanelPreviewItemCommunity(ItemCommunity itemCommunity)
        {
            InitializeComponent();
            try
            {
                this.Tag =itemCommunity;
                labelName.Text = itemCommunity.Name;
                pictureBox1.ImageLocation = itemCommunity.IconLinks[0];
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void PanelPreviewItemCommunity_Load(object sender, EventArgs e)
        {

        }
    }
}
