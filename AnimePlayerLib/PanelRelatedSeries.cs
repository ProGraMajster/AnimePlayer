using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayerLibrary;

namespace AnimePlayerLibrary
{
    public enum TypeRelatedSeries : int
    {
        Sequel = 0,
        Prequel = 1,
        Main_history = 2,
        Side_story = 3,
        Summary = 4,
        Other = 5
    }

    public partial class PanelRelatedSeries : UserControl
    {
        public PanelRelatedSeries(Panel panelOutputContent, Panel panelSource, TypeRelatedSeries typeRelated)
        {
            InitializeComponent();
            if(typeRelated == TypeRelatedSeries.Sequel)
            {
                labelTypetitle.Text = "Sequel";
            }
            else if(typeRelated == TypeRelatedSeries.Prequel)
            {
                labelTypetitle.Text = "Sequel";
            }
            else if(typeRelated == TypeRelatedSeries.Main_history)
            {
                labelTypetitle.Text = "Główna historia";
            }
            else if(typeRelated == TypeRelatedSeries.Side_story)
            {
                labelTypetitle.Text = "Historia poboczna";
            }
            else if(typeRelated == TypeRelatedSeries.Summary)
            {
                labelTypetitle.Text = "Podsumowanie";
            }
            else if (typeRelated == TypeRelatedSeries.Other)
            {
                labelTypetitle.Text = "Inne";
            }
            panelOutputContent.Controls.Add(this);
            panelContent.Controls.Add(panelSource);
            panelSource.Location = new System.Drawing.Point(0,0);
            panelSource.Dock = DockStyle.Fill;

        }
    }
}
