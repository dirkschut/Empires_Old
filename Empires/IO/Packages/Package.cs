using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Empires.IO.Packages
{
    public class Package
    {
        private String path;

        public String name;
        public String author;
        public String version;
        public String packageID;

        public Package(String path)
        {
            this.path = path;
        }

        public Package()
        {
            this.path = "";
        }

        public String getPath()
        {
            return this.path;
        }

        public void save()
        {
            String json = JsonConvert.SerializeObject(this);

            if (path == "")
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\packages\\" + name + ".epkg";
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(json);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
