using AnimePlayer.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AnimePlayer.Profile
{
    public static class ProfileManager
    {
        public enum DefaultAnimeList:int
        {
            Watching = 0,
            Ended=1,
            OnHold=2,
            Dropped=3,
            PlanToWatch =4
        }

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

        public static void Init(ProfileClass profileClass)
        {
            try
            {
                if(profileClass == null)
                {
                    return;
                }
                CurrentProfile = profileClass;
                if(!Directory.Exists(PathToProfiles+CurrentProfile.Name))
                {
                    Directory.CreateDirectory(PathToProfiles+CurrentProfile.Name);
                }
                if(!Directory.Exists(PathToProfiles+CurrentProfile.Name+"\\Lists"))
                {
                    Directory.CreateDirectory(PathToProfiles+CurrentProfile.Name + "\\Lists");
                }
                if(ChecikingAllDefaultLists()== false)
                {

                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static bool ChecikingAllDefaultLists()
        {
            try
            {
                if (CurrentProfile == null)
                {
                    return false;
                }
                if (!Directory.Exists(PathToProfiles + CurrentProfile.Name + "\\Lists"))
                {
                    return false;
                }
                ProfileIAnimeList animeList = null;
                foreach(string name in defaultLists)
                {
                    if (File.Exists(PathToProfiles + CurrentProfile.Name + "\\Lists\\" + name + ".dat"))
                    {

                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return false;
        }

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
