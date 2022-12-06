using AnimePlayer.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    CreateDefaultAnimeLists();
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
                Dictionary<string,bool> dict = new Dictionary<string, bool>()
                {
                    { "Oglądane",false },
                    { "Zakończone", false},
                    { "W oczekiwaniu",false },
                    { "Porzucone", false },
                    { "Planowane", false }
                };
                foreach(var item in dict)
                {
                    if (File.Exists(PathToProfiles + CurrentProfile.Name + "\\Lists\\" + item.Key + ".dat"))
                    {
                        var alist = SerializationAndDeserialization.DeserializationJson(
                            PathToProfiles + CurrentProfile.Name + "\\Lists\\" + item.Key + ".dat",
                            typeof(ProfileIAnimeList));
                        if(alist != null)
                        {
                            dict[item.Key] = true;
                        }
                    }
                }
                int max = dict.Count;
                int c = 0;
                foreach(bool val in dict.Values)
                {
                    if(val)
                    {
                        c++;
                    }
                }
                if(c >= max)
                {
                    return true;
                }
                else
                {
                    return false;
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

        public static void CreateDefaultAnimeLists()
        {
            try
            {
                foreach(string name in defaultLists)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.ToString());
            }
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
