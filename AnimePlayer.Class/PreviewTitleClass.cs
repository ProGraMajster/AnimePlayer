using System;
using System.Collections.Generic;

namespace AnimePlayer.Class
{
    [Serializable]
    public class PreviewTitleClass
    {
        public string Title { get; set; }
        public List<string> LinkToIcon { get; set; }
        public List<string> LinksToDownloadContent { get; set; }
        public string S_ID { get; set; }
        public Guid Guid { get; set; }
        public string FileCrator { get; set; }
    }
}