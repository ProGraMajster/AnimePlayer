using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayer.ControlsWinForms;
using AnimePlayer.Profile;

namespace AnimePlayerLibrary
{
    public partial class ControlTitleStatusList : UserControl
    {
        readonly NewFlowLayoutPanel newFlowLayoutPanel;
        public ProfileIAnimeList ProfileIAnimeList;
        public ControlTitleStatusList(ProfileIAnimeList profileIAnimeList)
        {
            InitializeComponent();
            ProfileIAnimeList= profileIAnimeList;
            newFlowLayoutPanel = new NewFlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                Name = "newFlowLayoutPanel_Titles",
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            newFlowLayoutPanel.Resize += NewFlowLayoutPanel_Resize;
            panelDock.Controls.Add(newFlowLayoutPanel);
            newFlowLayoutPanel.Show();
        }

        private void NewFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            if(!bWresiezItem.IsBusy)
            {
                bWresiezItem.RunWorkerAsync();
            }
        }

        private void BWresiezItem_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                foreach(ControlTitleStatusList_Item i in newFlowLayoutPanel.Controls.OfType<ControlTitleStatusList_Item>())
                {
                    this.BeginInvoke(new Action(() => i.SetWidth(newFlowLayoutPanel.Width - 35)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ControlTitleStatusList_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Thread thread = new(() =>
                    {
                        List<ControlTitleStatusList_Item> controlTitleStatusList_Items = new List<ControlTitleStatusList_Item>();
                        foreach (ItemToList itemList in ProfileIAnimeList.itemToLists)
                        {
                            ControlTitleStatusList_Item controlTitleStatusList_Item = new ControlTitleStatusList_Item(itemList);
                            controlTitleStatusList_Items.Add(controlTitleStatusList_Item);
                        }

                        this.Invoke(() =>
                        {
                            foreach (var item in controlTitleStatusList_Items)
                            {
                                newFlowLayoutPanel1.Controls.Add(item);
                            }
                        });
                    });
                    thread.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
