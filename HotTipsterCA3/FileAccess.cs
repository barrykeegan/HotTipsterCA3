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

        
        public TipResults ReadResultsCollectionFromFile(string fileName)
        {
            TipResults trc = null;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                trc = (TipResults)bf.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            return trc;
        }

        public TipResult ReadSingleResultFromFile(string fileName)
        {
            TipResult tr = null;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                tr = (TipResult)bf.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            return tr;
        }

        public bool WriteResultsCollectionToFile(string fileName, TipResults tr)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, tr);
            }
            catch (SerializationException e)
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

        public bool WriteSingleResultToFile(string fileName, TipResult tr)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, tr);
            }
            catch (SerializationException e)
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
