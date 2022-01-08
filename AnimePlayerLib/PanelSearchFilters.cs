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

namespace AnimePlayerLibrary
{
    public partial class PanelSearchFilters : UserControl
    {
        public Control _source;
        public Control _output;

        public bool use = false;
        public bool use_Species = false;

        public PanelSearchFilters(Control source, Control output, bool flag = true)
        {
            InitializeComponent();
            if(flag)
            {
                ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = this;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = panelSpecies;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonSpecies;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonClose;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = buttonReset;
                rc.CornerRadius = 15;
            }
        }

        // Jeszcze trzeba to skończyć...
        #region Species
        
        public string[] str_Species = { "akcja", "Cyberpunk", "Dramat", "Ecchi", "Eksperymentalne", "Fantasy", "Harem", "Hentai", "Historyczne", "Horror", "Komedia", "Kryminalne", "Magia", "Mecha", "Męski harem", "Muzyczne", "Nadprzyrodzone", "Obłęd", "Okruchy życia", "Parodia", "Przygodowe", "Psychologiczne", "Romans", "Sci-Fi", "Shoujo-ai", "Shounen-ai", "Space-opera", "Sportowe", "Steampunk", "Szkolne", "Sztuki walki", "Tajemnica", "Thriller", "Wojskowe", "Yaoi", "Yuri" };
        #endregion

        //private bool flags_findItem = false;

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(use == true)
            {
                use = false;
                buttonSave.Text = "Włącz filtry";
                return;
            }
            if(use == false)
            {
                use = true;
                buttonSave.Text = "Wyłącz filtry";
                return;
            }
        }


        private void checkBox_S_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonS_use_Click(object sender, EventArgs e)
        {
            if (use_Species == true)
            {
                use_Species = false;
                buttonS_use.Text = "Włącz filtr gatunków";
                return;
            }
            if (use_Species == false)
            {
                use_Species = true;
                buttonS_use.Text = "Wyłącz filtr gatunków";
                return;
            }
        }

        private void button_S_unsetAll_Click(object sender, EventArgs e)
        {
            checkBox_Action.Checked = false;
            checkBox_Adventure.Checked = false;
            checkBox_Comedy.Checked = false;
            checkBox_Criminal.Checked = false;
            checkBox_Cyberpunk.Checked = false;
            checkBox_Drama.Checked = false;
            checkBox_Ecchi.Checked = false;
            checkBox_Experimental.Checked = false; 
            checkBox_Fantasy.Checked = false;
            checkBox_Harem.Checked = false;
            checkBox_Hentai.Checked = false;
            checkBox_Historical.Checked = false;
            checkBox_Horror.Checked = false;
            checkBox_Madness.Checked = false;
            checkBox_Magic.Checked = false;
            checkBox_Male_harem.Checked = false;
            checkBox_Martial_arts.Checked = false;
            checkBox_Mecha.Checked = false;
            checkBox_Military.Checked = false;
            checkBox_Musical.Checked = false;
            checkBox_Mystery.Checked = false;
            checkBox_Parody.Checked = false;
            checkBox_Psychological.Checked = false;
            checkBox_Romance.Checked = false;
            checkBox_School.Checked = false;
            checkBox_Sci_Fi.Checked = false;
            checkBox_Shoujo_ai.Checked = false;
            checkBox_Shounen_ai.Checked = false;
            checkBox_Space_opera.Checked = false;
            checkBox_Sports.Checked = false;
            checkBox_Steampunk.Checked = false;
            checkBox_Supernatural.Checked = false;
            checkBox_TheCrumbsOfLife.Checked = false;
            checkBox_Thriller.Checked = false;
            checkBox_Yaoi.Checked = false;
            checkBox_Yuri.Checked = false;
        }

        private void button2_S_setAll_Click(object sender, EventArgs e)
        {
            checkBox_Action.Checked = true;
            checkBox_Adventure.Checked = true;
            checkBox_Comedy.Checked = true;
            checkBox_Criminal.Checked = true;
            checkBox_Cyberpunk.Checked = true;
            checkBox_Drama.Checked = true;
            checkBox_Ecchi.Checked = true;
            checkBox_Experimental.Checked = true;
            checkBox_Fantasy.Checked = true;
            checkBox_Harem.Checked = true;
            checkBox_Hentai.Checked = true;
            checkBox_Historical.Checked = true;
            checkBox_Horror.Checked = true;
            checkBox_Madness.Checked = true;
            checkBox_Magic.Checked = true;
            checkBox_Male_harem.Checked = true;
            checkBox_Martial_arts.Checked = true;
            checkBox_Mecha.Checked = true;
            checkBox_Military.Checked = true;
            checkBox_Musical.Checked = true;
            checkBox_Mystery.Checked = true;
            checkBox_Parody.Checked = true;
            checkBox_Psychological.Checked = true;
            checkBox_Romance.Checked = true;
            checkBox_School.Checked = true;
            checkBox_Sci_Fi.Checked = true;
            checkBox_Shoujo_ai.Checked = true;
            checkBox_Shounen_ai.Checked = true;
            checkBox_Space_opera.Checked = true;
            checkBox_Sports.Checked = true;
            checkBox_Steampunk.Checked = true;
            checkBox_Supernatural.Checked = true;
            checkBox_TheCrumbsOfLife.Checked = true;
            checkBox_Thriller.Checked = true;
            checkBox_Yaoi.Checked = true;
            checkBox_Yuri.Checked = true;
        }
    }
}
