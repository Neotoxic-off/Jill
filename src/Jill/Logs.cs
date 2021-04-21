using System;
using System.Collections.Generic;

namespace LOGS
{
    class Logs
    {
        public string ids(string id)
        {
            Console.WriteLine(id);
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
                { "games_add", "Game adding" },
                { "games_added", "Game added" },
                { "games_remove", "Game removing" },
                { "games_removed", "Game removed" },
                { "games_refresh", "Games refreshing" },
                { "games_refreshed", "Games refreshed" },

                { "mods_add", "Mod adding" },
                { "mods_added", "Mod added" },
                { "mods_remove", "Mod removing" },
                { "mods_removed", "Mod removed" },
                { "mods_refresh", "Mods refreshing" },
                { "mods_refreshed", "Mods refreshed" },

                { "no_game_path_load", "No game path to load" },
                { "no_game_name_load", "No game name to load" },
                { "game_path_not_found", "Game path not found" },
                { "mod_path_not_found", "Mod path not found" },

                { "no_mod_path_load", "No mod path to load" },
                { "no_mod_name_load", "No mod name to load" },

                { "add_mod_to_game", "Adding mod to game" },
                { "added_mod_to_game", "Added mod to game" }
            };

            return (list[id]);
        }
    }
}
