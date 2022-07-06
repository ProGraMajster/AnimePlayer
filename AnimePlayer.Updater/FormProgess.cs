using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace AnimePlayer.Updater
{
    public partial class FormProgess : Form
    {
        public WebClient webClient;
        public bool downloaded = false;
        public FormProgess()
        {
            InitializeComponent();
            webClient = new WebClient();
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                progressBar1.Value = 0;

                if (e.Cancelled)
                {
                    this.Invoke(() =>
                    {
                        label1.Text ="Pobieranie zostało anulowane";
                    });
                    return;
                }

                if (e.Error != null) // We have an error! Retry a few times, then abort.
                {
                    MessageBox.Show("Wystąpił błąd podczas próby pobrania pliku");
                    this.Invoke(() =>
                    {
                        label1.Text ="Wystąpił błąd podczas próby pobrania pliku";
                    });
                    return;
                }

                this.Invoke(() =>
                {
                    label1.Text ="Plik został pomyślnie pobrany";
                });
                downloaded = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
