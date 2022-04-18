using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Core
{
    public static class SerializationAndDeserialization
    {
        public static object Deserialization(string path)
        {

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            IFormatter formattter = new BinaryFormatter();
            object obj = formattter.Deserialize(stream);
            return obj;
        }

        public static void Serialization(object obj, string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();
            stream.Dispose();
        }
    }
}
