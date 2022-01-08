using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayerLibrary
{
    public class ThemeChangerColors
    {
        public Color PageEpisode_BackColor { get; set; }
        public Color PageEpisode_ForeColor { get; set; }
        public Color PageEpisode_BackColor2 { get; set; }

        #region CtnPanel
        public Color CtnPanel_MainBackColor { get; set; }
        public Color CtnPanel_MainForeColor { get; set; }
        public Color CtnPanel_ButtonBackColor { get; set; }
        public Color CtnPanel_ButtonForeColor { get; set; }
        public Color CtnPanel_ButtonMouseDownBackColor { get; set; }
        public Color CtnPanel_ButtonMouseOverBackColor { get; set; }
        #endregion CtnPanel

        #region PageItem
        public Color PageItem_BackColor { get; set; }
        public Color PageItem_BackColor2 { get; set; }
        public Color PageItem_BackColor3 { get; set; }
        public Color PageItem_BackColor4 { get; set; }

        public Color PageItem_ForeColor { get; set; }
        #endregion PageItem
    }
}
