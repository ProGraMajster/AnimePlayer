using AnimePlayer.ControlsWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer
{
    public partial class FormBrowser : Form
    {
        ZetaIpc.Runtime.Server.IpcServer ipcServer;
        public FormBrowser(bool startServer)
        {
            InitializeComponent();
            /*
            if(startServer)
            {
                ipcServer = new ZetaIpc.Runtime.Server.IpcServer();
                ipcServer.Start(65500);
                ipcServer.ReceivedRequest += IpcServer_ReceivedRequest;
                ipcServer.Start();
            }
            */
            try
            {
                var item = browserTabPage1.newFlowLayoutPanelPages.Controls.OfType<BrowserTabPageItem>().First();
                item.pictureBoxItemIcon.Image = this.Icon.ToBitmap();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void IpcServer_ReceivedRequest(object sender, ZetaIpc.Runtime.Server.ReceivedRequestEventArgs e)
        {

        }

        public void CommandPraser(string text)
        {
            try
            {
                if(text.StartsWith("Open_a_new_tab_on_the_site"))
                {
                    if (!text.Contains("|"))
                        return;
                    string[] vs = text.Split('|');
                    if(vs[1] == "ContentID")
                    {
                        OpenANewTabOnTheSite(AnimePlayer.Class.AppFolders.PagesItems +vs[2]+".txt");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }



        public void OpenANewTabOnTheSite(string text)
        {
            browserTabPage1.AddPage("NewPage", null, new PageItem());
        }
    }
}
