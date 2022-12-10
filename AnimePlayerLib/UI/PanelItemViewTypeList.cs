using AnimePlayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary.UI
{
    public partial class PanelItemViewTypeList : UserControl
    {
        public PreviewTitleClass previewTitleClass;
        private int UsedLinkIcon = 0;


        public PanelItemViewTypeList(PreviewTitleClass preview)
        {
            InitializeComponent();
            previewTitleClass = preview;
        }

        private void pictureBoxItem_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    UsedLinkIcon++;
                    pictureBoxItem.ImageLocation = previewTitleClass.LinkToIcon[UsedLinkIcon];
                #if DEBUG
                    Debug.WriteLine(e.Error.ToString() + "\n UsedLinkIcon:" + UsedLinkIcon);
                #endif
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
