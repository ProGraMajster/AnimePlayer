using AnimePlayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary.UI
{
    public partial class PanelItemViewTypeList : UserControl
    {
        public PreviewTitleClass previewTitleClass;
        private int UsedLinkIcon = 0;

        PageItemData pageItemData;

        public PanelItemViewTypeList(PreviewTitleClass preview)
        {
            InitializeComponent();
            previewTitleClass = preview;
            if(previewTitleClass == null )
            {
                return;
            }
            Thread thread = new Thread(() =>
            {
                pageItemData = ContentManagerLibary.GetPageItemDataWithContentFolderFromTitle(previewTitleClass.Title);
                if(pageItemData == null )
                {
                    this.Invoke(() =>
                    {
                        labelType.Text = "";
                        labelDate.Text = "";
                    });
                    return;
                }
                this.Invoke(() =>
                {
                    labelType.Text = pageItemData.TitleInformation.Type + " ("+pageItemData.TitleInformation.NumberOfEpisodes+" Odcinków)";
                    labelDate.Text= pageItemData.TitleInformation.DateOfIssue.ToString() + " - "+pageItemData.TitleInformation.EndOfIssue.ToString();
                    foreach (var item in pageItemData.TitleInformation.Species)
                    {
                        LinkLabel linkLabel = new()
                        {
                            TextAlign = ContentAlignment.MiddleCenter,
                            AutoSize = true,
                            BackColor = Color.FromArgb(45,45,45),
                            ActiveLinkColor = Color.Red,
                            LinkColor = Color.DeepSkyBlue
                        };
                        linkLabel.Text = item;
                        newFlowLayoutPanel1.Controls.Add(linkLabel);
                    }
                });
            });
            thread.Start();
            labelTitle.Text = previewTitleClass.Title;
            pictureBoxItem.ImageLocation = previewTitleClass.LinkToIcon[0];
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
