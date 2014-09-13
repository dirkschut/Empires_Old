using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Empires.Game
{
    public class Game
    {
        public GameData data;

        private String path;

        public Game()
        {
            this.data = new GameData();
            this.path = "";
        }

        public Game(String path)
        {
            this.path = path;
            load();
        }

        public void save()
        {
            String json = JsonConvert.SerializeObject(data);

            if (path == "")
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\saves\\" + data.name + ".esav";
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

        public void load()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                String json = "";
                json = sr.ReadLine();
                data = JsonConvert.DeserializeObject<GameData>(json);
            }
        }
    }
}
