using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dziennik
{
    

    class DataManager
    {
        public void SaveToFile(string fileName, string data)
        {
            File.WriteAllText(fileName, data);
        }

        public string ReadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName);
            }
            return "";
        }
    }
}
