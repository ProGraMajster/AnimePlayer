using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayerLibrary
{
    [Serializable]
    public class ClassItemOnStateList
    {
        public string Title { get; set; }
        public string Ep { get; set; }
        public string ListName { get; set; }
    }
    [Serializable]
    public class ItemList_ClassItemOnStateList
    {
        public ClassItemOnStateList[] StateLists { get; set; }

    }
}
