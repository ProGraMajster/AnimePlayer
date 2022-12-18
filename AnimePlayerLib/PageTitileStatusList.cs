using AnimePlayer.Profile;
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
using System.IO;
using AnimePlayer.Core;

namespace AnimePlayerLibrary
{
    public partial class PageTitileStatusList : UserControl
    {
        ProfileClass _profileClass;
        public PageTitileStatusList(ProfileClass profileClass)
        {
            InitializeComponent();
            _profileClass = profileClass;
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            GC.Collect();
        }

        private void PageTitileStatusList_Load(object sender, EventArgs e)
        {
            try
            {
                if (_profileClass == null)
                {
                    return;
                }
                Thread thread = new(() =>
                {
                    List<ProfileIAnimeList> list = new List<ProfileIAnimeList>();
                    DirectoryInfo directoryInfo = new DirectoryInfo(ProfileManager.GetPathCurrentProfile() + "\\Lists");
                    foreach(var file in directoryInfo.GetFiles())
                    {
                        AnimePlayer.Profile.ProfileIAnimeList animeList =
                        (AnimePlayer.Profile.ProfileIAnimeList)SerializationAndDeserialization.DeserializationJson(
                            file.FullName, typeof(AnimePlayer.Profile.ProfileIAnimeList));
                        if(animeList != null)
                        {
                            list.Add(animeList);
                        }
                    }

                    foreach(var anime in list)
                    {
                        ControlTitleStatusList controlTitleStatusList = new(anime);
                        controlTitleStatusList.Name = "controlTitleStatusList_" + list.IndexOf(anime);
                        controlTitleStatusList.Dock = DockStyle.Fill;
                        TabPage tabPage = new TabPage();
                        tabPage.BackColor = Color.FromArgb(25, 25, 25);
                        tabPage.Text = anime.Name;
                        tabPage.ToolTipText= anime.Description;
                        tabPage.Controls.Add(controlTitleStatusList);
                        this.Invoke(() =>
                        {
                            tabControl1.TabPages.Add(tabPage);
                        });
                    }
                });
                thread.Name = "Thread_Load_ProfileAnimeList";
                thread.Start();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
