using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            
            return true;
        }
    }
}
