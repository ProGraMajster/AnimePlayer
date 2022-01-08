using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace AnimePlayerLibrary
{
    public static class IO_Item
    {
        public static void FileSave(ClassItemTitleFristInformation @class)
        {
            try
            {
                //string code = "Name;\n" + @class.Title + ";\nIcon;\n" + @class.Icon + ";\nLink;\n" + @class.Link + ";\nContentId;\n" + @class.ContentId + ";\n";

                if(!Directory.Exists(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\TitleInformation"))
                {
                    Directory.CreateDirectory(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\TitleInformation");
                }

                SoapFormatter soapFormatter = new SoapFormatter();
                Stream stream = File.Open(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\TitleInformation", FileMode.Create);

                soapFormatter.Serialize(stream, @class);
                stream.Close();

                //File.WriteAllText(DefaultAppDir.DatabaseOftitles + @class.Title + "_item.txt", code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                FileLog.Write(ex.ToString());
            }
        }


        public static void FileSave(ItemList_ClassItemOnStateList @class)
        {
            try
            {
                //string code = "Name;\n" + @class.Title + ";\nIcon;\n" + @class.Icon + ";\nLink;\n" + @class.Link + ";\nContentId;\n" + @class.ContentId + ";\n";

                if(!Directory.Exists(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\List"))
                {
                    Directory.CreateDirectory(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\List");
                }

                SoapFormatter soapFormatter = new SoapFormatter();
                Stream stream = File.Open(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\List\list.dat", FileMode.Create);

                soapFormatter.Serialize(stream, @class);
                stream.Close();

                //File.WriteAllText(DefaultAppDir.DatabaseOftitles + @class.Title + "_item.txt", code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                FileLog.Write(ex.ToString());
            }
        }

        public static ClassItemTitleFristInformation FileRead(string path)
        {
            try
            {
                ClassItemTitleFristInformation cl = new ClassItemTitleFristInformation();
                string[] ar = File.ReadAllText(path).Split(';');
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = ar[i].Replace("\n", "").Replace("\r", "").Replace("\t", "");
                }
                cl.Title = ar[1];
                cl.Icon = ar[3];
                cl.Link = ar[5];
                cl.ContentId = ar[7];
                return cl;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                FileLog.Write(ex.ToString());
                return null;
            }
        }
    }
}
