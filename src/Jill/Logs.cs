using System.Collections.Generic;

namespace LOGS
{
    class Logs
    {
        public string ids(string id)
        {
            Dictionary<string, string> list = new Dictionary<string, string>()
            {
                { "ready", "Ready" },
                { "mods_load", "Mods loading" },
                { "mods_loaded", "Mods loaded" },

                { "ini_load", "INI loading" },
                { "ini_loaded", "INI loaded" },

                { "preview_load", "Preview loading" },
                { "preview_loaded", "Preview loaded" },
                { "preview_not_loaded", "Preview not loaded" },

                { "infos_load", "Informations loading" },
                { "infos_loaded", "Informations loaded" },

                { "check_all_load", "Checking all mods" },
                { "check_all_loaded", "Checked all mods" },

                { "uncheck_all_load", "Unchecking all mods" },
                { "uncheck_all_loaded", "Unchecked all mods" },

                { "settings_load", "Settings loading" },
                { "settings_loaded", "Settings loaded" },

                { "games_load", "Games loading" },
                { "games_loaded", "Games loaded" },
            };

            return (list[id]);
        }
    }
}
