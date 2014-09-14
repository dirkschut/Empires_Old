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

        public PackageData data = new PackageData();

        public static Random rand = new Random();

        public Package(String path)
        {
            this.path = path;
            load();
        }

        public Package()
        {
            this.path = "";
        }

        public String getPath()
        {
            return this.path;
        }

        public void load()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                String json = "";
                json = sr.ReadToEnd();
                data = JsonConvert.DeserializeObject<PackageData>(json);
            }
        }

        public void save()
        {
            String json = JsonConvert.SerializeObject(data, Formatting.Indented);

            if (path == "")
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\packages\\" + data.name + ".epkg";
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

        public String getRandomObjectName()
        {
            if (data.objectNames.Count > 0)
            {
                return data.objectNames[rand.Next(0, data.objectNames.Count)];
            }
            else
            {
                return "";
            }
        }
    }
}
