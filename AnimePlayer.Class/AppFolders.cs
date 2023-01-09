using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    public static class AppFolders
    {
        public static readonly string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\";
        public static readonly string Temp = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Temp\\";
        public static readonly string PreviewItems = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\PreviewItems\\";
        public static readonly string Community = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Community\\";
        public static readonly string Logs = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Logs\\";
        public static readonly string News = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\News\\";
        public static readonly string Web = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Web\\";
        public static readonly string PagesItems = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\PagesItems\\";
        public static readonly string VideosItems = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\VideosItems\\";
        public static readonly string Icons  = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Icons\\";
        public static readonly string IconsBackup = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\IconsBackup\\";
        public static readonly string Updater = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Updater\\";
        public static readonly string Settings= Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Settings\\";
        public static readonly string ItemGroups = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\ItemGroups\\";
        public static readonly string TitleComments = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
            "\\AnimePlayer\\TitleComments\\";
        //========================
        public static readonly string Profiles = AppFolder + "Profiles\\";

        //============== New downloaded content folders ====================
        public static readonly string UpdatedContentFolder = Updater +
            "UpdatedContentFolder\\";
        public static readonly string UpdatedRepoPath = UpdatedContentFolder +
            "AnimePlayer.Content-master\\APC\\";
        public static readonly string UpdatedPreviewItems = UpdatedRepoPath + "PreviewItems\\";
        public static readonly string UpdatedPagesItems = UpdatedRepoPath + "PagesItems\\";
        public static readonly string UpdatedCommunity = UpdatedRepoPath + "Community\\";
        public static readonly string UpdatedWeb = UpdatedRepoPath + "Web\\";
        public static readonly string UpdatedVideosItems = UpdatedRepoPath + "VideosItems\\";
        public static readonly string UpdatedItemGroups = UpdatedRepoPath + "ItemGroups\\";
        
        public static readonly string UpdatedDefined = UpdatedRepoPath + "Defined\\";
            public static readonly string UpdatedDefined_PlaceAndTime = UpdatedDefined + "PlaceAndTime\\";
            public static readonly string UpdatedDefined_Species = UpdatedDefined + "Species\\";
            public static readonly string UpdatedDefined_TargetGroups = UpdatedDefined + "TargetGroups\\";
            public static readonly string UpdatedDefined_TypesOfCharacters = UpdatedDefined + "TypesOfCharacters\\";

    }
}
