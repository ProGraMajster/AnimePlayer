using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using AnimePlayer.ControlsWinForms;
using AnimePlayer.Class;
using AnimePlayer.Core;
using System.Threading;

namespace AnimePlayer
{
    public partial class FormBrowser : Form
    {
        ZetaIpc.Runtime.Server.IpcServer ipcServer;
        ZetaIpc.Runtime.Client.IpcClient ipcClient;
        public FormBrowser(bool startServer= true)
        {
            InitializeComponent();
            ipcClient = new ZetaIpc.Runtime.Client.IpcClient();
            if (startServer)
            {
                ipcServer = new ZetaIpc.Runtime.Server.IpcServer();
                ipcServer.ReceivedRequest += IpcServer_ReceivedRequest;
                ipcServer.Start();
            }
            try
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Tick+=Timer_Tick;
                timer.Start();
                var item = browserTabPage1.newFlowLayoutPanelPages.Controls.OfType<BrowserTabPageItem>().First();
                item.pictureBoxItemIcon.Image = this.Icon.ToBitmap();
                browserTabPage1.eventHandler =ButtonFindInApp_Click;                
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                browserTabPage1.eventHandler =ButtonFindInApp_Click;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void ButtonFindInApp_Click(object sender, EventArgs e)
        {
             BrowserTabPageSearchResult searchResult = new BrowserTabPageSearchResult();
            searchResult.Dock = DockStyle.Fill;
            searchResult.Name = "searchResult";
            BrowserTabPageHomePage page = (BrowserTabPageHomePage)((Button)sender).Tag;
            browserTabPage1.AddPage("Wynik wyszukiwania frazy:"+page.textBoxMain.Text,
                null,
                searchResult);
            Thread thread = new Thread(() =>
            {
                Find(searchResult);
            });
            thread.Name = "ThreadSearch";
            thread.Start();
        }
        
        public void Find(BrowserTabPageSearchResult searchResult)
        {
            //List<Control> controls = new List<Control>();
            for(int i = 0; i < 1000; i++)
            {
                PanelSearchResult panelSearchResult = new PanelSearchResult();
                panelSearchResult.labelDes.Text = "Przykładowy opis";
                panelSearchResult.linkLabelTitle.Text = "Przykładowy tytuł_"+i;
                Thread.Sleep(500);
                searchResult.Invoke(() =>
                {
                    searchResult.newFlowLayoutPanel.Controls.Add(panelSearchResult);
                });
            }
        }

        private void IpcServer_ReceivedRequest(object sender, ZetaIpc.Runtime.Server.ReceivedRequestEventArgs e)
        {
            CommandPraser(e.Request);
            e.Response = "Code:1";
            e.Handled=true;
        }

        public void CommandPraser(string text)
        {
            try
            {
                if(text.StartsWith("Code"))
                {
                }
                else
                {
                    IpcMessage ipcMessage = (IpcMessage)SerializationAndDeserialization.DeserializationJsonFromString(text, typeof(IpcMessage));
                    if(ipcMessage == null)
                    {
                        return;
                    }
                    if(ipcMessage.RequestType == "POST")
                    {

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void RequestPOST(IpcMessage ipcMessage)
        {
            try
            {
                if (ipcMessage.MessageString.StartsWith("CreateControl"))
                {
                    
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                ipcClient.Initialize(ipcMessage.FromThePort);
                ipcClient.Send("Error{;}RequestPOST{;}"+ex.Message);
            }
        }


        public void OpenANewTabOnTheSite(string text)
        {
           // browserTabPage1.AddPage("NewPage", null, new PageItem());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
