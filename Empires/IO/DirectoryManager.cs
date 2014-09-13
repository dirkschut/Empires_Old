using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Empires.IO
{
    class DirectoryManager
    {
        public static void CheckCreate(String path)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\" + path))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\" + path);
            }
        }
    }
}
