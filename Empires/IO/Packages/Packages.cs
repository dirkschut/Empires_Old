using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Empires.IO.Packages
{
    class Packages
    {
        public static Package[] GetPackages()
        {
            Package[] packages;
            String[] packageFiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\packages\\", "*.epkg");
            packages = new Package[packageFiles.Length];

            for (int i = 0; i < packageFiles.Length; i++)
            {
                packages[i] = new Package(packageFiles[i]);
            }

            return packages;
        }
    }
}
