using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETTINGS
{
    class Settings
    {
        public class Rootobject
        {
            public string version { get; set; }
            public List<Game> games { get; set; }
            public List<Mods> mods { get; set; }
        }

        public class Game
        {
            public string name { get; set; }
            public string path { get; set; }
            public List<string> mods { get; set; }

            public Game(string name, string path)
            {
                this.name = name;
                this.path = path;
                this.mods = new List<string>();
            }
        }

        public class Mods
        {
            public string name { get; set; }
            public string path { get; set; }

            public Mods(string name, string path)
            {
                this.name = name;
                this.path = path;
            }
        }
    }
}
