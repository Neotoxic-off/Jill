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
            public Games games { get; set; }
        }

        public class Games
        {
            public object[] name { get; set; }
            public object[] path { get; set; }
        }

    }
}
