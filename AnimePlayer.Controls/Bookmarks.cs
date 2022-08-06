using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    public partial class Bookmarks : UserControl
    {
        public string Link;
        public string Title;
        public Bitmap Icon;
        public Bookmarks(string link, string title, Bitmap icon)
        {
            InitializeComponent();
            Link=link;
            Title=title;
            Icon=icon;
        }
        public Bookmarks()
        {
            InitializeComponent();
        }
    }
}
