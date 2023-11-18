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
    public partial class PanelEpisodeScrapedOff : UserControl
    {
        public ScrapedOffClass ScrapedOffClass;
        public PanelEpisodeScrapedOff(ScrapedOffClass scrapedOffClass)
        {
            InitializeComponent();
            ScrapedOffClass = scrapedOffClass;
        }

        private void PanelEpisodeScrapedOff_Load(object sender, EventArgs e)
        {
            try
            {
                if (ScrapedOffClass.S.Contains("pl.png"))
                {
                    labelSubtitle.Text = "Polski";
                    pictureBoxSubtitle.ImageLocation = ScrapedOffClass.S;
                }
                else if (ScrapedOffClass.S.Contains("en.png"))
                {
                    labelSubtitle.Text = "Angielski";
                    pictureBoxSubtitle.ImageLocation = ScrapedOffClass.S;
                }
                else if (ScrapedOffClass.S.Contains("jp.png"))
                {
                    labelSubtitle.Text = "Japoński";
                    pictureBoxSubtitle.ImageLocation = ScrapedOffClass.S;
                }

                if (ScrapedOffClass.A.Contains("jp.png"))
                {
                    labelAudio.Text = "Japoński";
                    pictureBoxAudio.ImageLocation = ScrapedOffClass.A;
                }
                else if (ScrapedOffClass.A.Contains("pl.png"))
                {
                    labelAudio.Text = "Polski";
                    pictureBoxAudio.ImageLocation = ScrapedOffClass.A;
                }
                else if (ScrapedOffClass.A.Contains("en.png"))
                {
                    labelAudio.Text = "Angielski";
                    pictureBoxAudio.ImageLocation = ScrapedOffClass.A;
                }

                pictureBoxT.ImageLocation = ScrapedOffClass.Translator;
                if (ScrapedOffClass.Translator.Contains("frixysubsIcon"))
                {
                    //imgT.Source = ImageSource.FromFile("frixysubsicon.png");
                }
                else if (ScrapedOffClass.Translator.Contains("fumetsuIcon"))
                {
                    //imgT.Source = ImageSource.FromFile("fumetsuicon.png");
                }
                else if (ScrapedOffClass.Translator.Contains("0"))
                {
                    //imgT.Source = ImageSource.FromFile("zero.png");
                }
                else if (ScrapedOffClass.Translator.Contains("demosubsIcon"))
                {
                    //imgT.Source = ImageSource.FromFile("demosubsicon.png");
                }
                else if (ScrapedOffClass.Translator.Contains("maousubsIcon"))
                {
                    //imgT.Source = ImageSource.FromFile("maousubsicon.png");
                }
                else if (ScrapedOffClass.Translator.Contains("shishasubsIcon"))
                {
                    //imgT.Source = ImageSource.FromFile("shishasubsicon.png");
                }
                else if (ScrapedOffClass.Translator.Contains("tokyosubsIcon"))
                {
                    //imgT.Source = ImageSource.FromFile("tokyosubsicon.png");
                }
                else if (ScrapedOffClass.Translator.Contains("wbijamIcon"))
                {
                    //imgT.Source = ImageSource.FromFile("wbijamicon.png");
                }
                else
                {
                   // imgT.Source = ScrapedOffClass.Translator;
                }

                Uri myUri = new Uri(ScrapedOffClass.LinkToIFrame);
                labelService.Text = myUri.Host.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
