using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDS
{
    class Ids
    {
        public string ids(string id)
        {
            Dictionary<string, string> path = new Dictionary<string, string>()
            {
                { "mods", "Mods"},
                { "modinfo", "modinfo.ini" },
                { "settings", "Settings"},
                { "configuration", "configuration.json" },
            };

            return (path[id]);
        }
    }
}
