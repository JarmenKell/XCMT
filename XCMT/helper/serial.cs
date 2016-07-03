using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using XCMT.Code;

namespace XCMT.helper
{
    public class xdata
    {
        public static void Deserialize()
        {
                FileStream fs = new FileStream("configs.xdata", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                tickmain.apps = (anwendung[])formatter.Deserialize(fs);
                fs.Close();
        }

        public static void Serialize()
        {
            FileStream fs = new FileStream("configs.xdata", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, tickmain.apps);
            fs.Close();
        }
    }
}