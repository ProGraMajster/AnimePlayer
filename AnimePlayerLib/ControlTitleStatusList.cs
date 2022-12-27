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
using AnimePlayer.ControlsWinForms;
using AnimePlayer.Profile;

namespace AnimePlayerLibrary
{
    public partial class ControlTitleStatusList : UserControl
    {
        readonly NewFlowLayoutPanel newFlowLayoutPanel;
        public ProfileIAnimeList ProfileIAnimeList;

        public bool EditMode = false;
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

        private void newFlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                foreach(Control control in newFlowLayoutPanel1.Controls)
                {
                    control.Size = new Size((newFlowLayoutPanel1.Width-30), control.Height);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        private void newFlowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                foreach (Control control in newFlowLayoutPanel1.Controls)
                {
                    control.Size = new Size((newFlowLayoutPanel1.Width - 30), control.Height);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonEditList_Click(object sender, EventArgs e)
        {
            try
            {
                if(EditMode)
                {
                    EditMode = false;
                    panelEdit.Hide();
                    buttonEditList.Text = "Edytuj";
                    foreach (ControlTitleStatusList_Item controlTitle in newFlowLayoutPanel1.Controls.OfType<ControlTitleStatusList_Item>())
                    {
                        controlTitle.HideCheckBox();
                    }
                }
                else
                {
                    EditMode = true;
                    panelEdit.Show();
                    buttonEditList.Text = "X";
                    foreach (ControlTitleStatusList_Item controlTitle in newFlowLayoutPanel1.Controls.OfType<ControlTitleStatusList_Item>())
                    {
                        controlTitle.ShowCheckBox();
                    }
                }
                
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ControlTitleStatusList_Item controlTitle in newFlowLayoutPanel1.Controls.OfType<ControlTitleStatusList_Item>())
                {
                    if(controlTitle.State)
                    {
                        controlTitle.Hide();
                        controlTitle.Dispose();
                    }
                }
                //TODO:
                //Usuwanie z listy i zapis
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
