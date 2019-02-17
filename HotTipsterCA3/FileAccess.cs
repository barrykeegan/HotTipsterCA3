using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace HotTipsterCA3
{
    public class FileAccess
    {
        public bool FileExists(string fileName)
        {
            if(File.Exists(fileName))
            {
                return true;
            }
            return false;
        }

        public bool WriteFile(string fileName, TipResult tr)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, tr);
            }
            catch(SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            if (File.Exists(fileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
