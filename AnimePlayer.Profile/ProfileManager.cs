using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AnimePlayer.Profile
{
    public static class ProfileManager
    {
        public static List<string> defaultLists = new()
        {
            "Oglądane",
            "Zakończone",
            "W oczekiwaniu",
            "Porzucone",
            "Planowane"
        };

        public static List<ProfileIAnimeList> profileIAnimeLists = new();

        private static ProfileClass CurrentProfile;
        public static string PathToProfiles = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Profiles\\";

        public static string GetPathCurrentProfile()
        {
            if(CurrentProfile == null)
            {
                return null;
            }
            return PathToProfiles + CurrentProfile.Name + "\\";
        }

        private static ProfileIAnimeList GetWatchingAnimeList()
        {
            try
            {
                //coming soon
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}
