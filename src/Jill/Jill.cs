using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using IniParser;
using IniParser.Model;

using Newtonsoft.Json;

using IDS;
using LOGS;
using MOD;
using SETTINGS;

namespace Jill
{
    public partial class Jill : Form
    {
        Ids ids = new Ids();
        Logs logs = new Logs();
        Mod.Rootobject mod = null;
        Settings.Rootobject settings = null;
        bool loaded = false;

        public Jill()
        {
            InitializeComponent();
        }

        private Task UILogs(string value, string path)
        {
            string display = "";
            string separator = "  |  ";

            if (logs_time.Checked == true)
                display += $"{DateTime.Now.ToString("T")}{separator}";
            display += $"{logs.ids(value)}";
            if (path != null)
                display += $"{separator}{path}";

            log_value.AppendText($"{display}\n");

            return (Task.CompletedTask);
        }

        private Task boxer(string content, string type)
        {
            if (type == "error")
            {
                MessageBox.Show(content, type, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (type == "game error")
            {
                MessageBox.Show(content, type, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (type == "mod error")
            {
                MessageBox.Show(content, type, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (Task.CompletedTask);
        }

        private Task load_mods()
        {
            UILogs("mods_refresh", null).Wait();

            mods_list.Items.Clear();

            if (loaded == true)
            {
                if (settings.mods.Count > 0)
                {
                    for (int i = 0; i < settings.mods.Count; i++)
                    {
                        if (Directory.Exists($"{settings.mods[i].path}") == true)
                        {
                            mods_list.Items.Add(settings.mods[i].name);
                        }
                        else
                        {
                            boxer($"Mods path not found:\n\nName: '{settings.mods[i].name}'\nPath: '{settings.mods[i].path}'", "mod error").Wait();
                        }
                    }
                }
                else
                {
                    UILogs("no_mod_name_load", null).Wait();
                }
            }
            UILogs("mods_refreshed", null).Wait();

            return (Task.CompletedTask);
        }

        private string is_checked(int index)
        {
            for (int i = 0; i < mods_list.CheckedItems.Count; i++)
            {
                if (mods_list.CheckedItems[i] == mods_list.Items[index])
                    return ("Activated");
            }
            return ("Not activated");
        }

        private Task load_modinfos(string path)
        {
            string full_path = $"{path}\\{ids.ids("modinfo")}";
            mod = new Mod.Rootobject();

            infos.Items.Clear();

            if (mods_list.SelectedIndex > -1)
            {
                if (File.Exists(full_path) == true)
                {
                    UILogs("ini_load", full_path).Wait();
                    FileIniDataParser parser = new FileIniDataParser();
                    IniData data = parser.ReadFile(full_path);
                    UILogs("ini_loaded", full_path).Wait();

                    UILogs("infos_load", path).Wait();

                    mod.name = data.GetKey("name");
                    mod.version = data.GetKey("version");
                    mod.description = data.GetKey("description");
                    mod.category = data.GetKey("category");
                    mod.screenshot = data.GetKey("screenshot");
                    mod.author = data.GetKey("author");

                    add_value(mod.name, "name").Wait();
                    add_value(mod.version, "version").Wait();
                    add_value(mod.description, "description").Wait();
                    add_value(mod.category, "category").Wait();
                    add_value($"{path}\\{mod.screenshot}", "preview").Wait();
                    add_value(mod.author, "author").Wait();

                    add_value($"{is_checked(mods_list.SelectedIndex)}", "status");
                    UILogs("infos_loaded", path).Wait();
                } else
                    add_value("No mod information to load", "Mod's informations").Wait();
            }
            
            return (Task.CompletedTask);
        }
        private Task load_gameinfos()
        {
            return (Task.CompletedTask);
        }
        private Task add_value(string value, string type)
        {
            if (value == null)
            {
                value = $"No {type} available";
            }

            if (type == "preview")
            {
                if (File.Exists(value) == false)
                {
                    value = "Preview file not found";
                    preview.Enabled = false;
                } else
                {
                    preview.Enabled = true;
                }
            }

            string[] row = { type, value };
            ListViewItem listViewItem = new ListViewItem(row);
            infos.Items.Add(listViewItem);

            return (Task.CompletedTask);
        }
        private void mods_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mods_list.SelectedIndex > -1)
                load_modinfos($"{settings.mods[mods_list.SelectedIndex].path}");
        }
        private void check_all_Click(object sender, EventArgs e)
        {
            UILogs("check_all_load", null).Wait();
            for (int i = 0; i < mods_list.Items.Count; i++)
            {
                mods_list.SetItemChecked(i, true);
            }
            UILogs("check_all_loaded", null).Wait();
        }
        private void uncheck_all_Click(object sender, EventArgs e)
        {
            UILogs("uncheck_all_load", null).Wait();
            for (int i = 0; i < mods_list.Items.Count; i++)
            {
                mods_list.SetItemChecked(i, false);
            }
            UILogs("uncheck_all_loaded", null).Wait();
        }
        private void preview_Click(object sender, EventArgs e)
        {
            Preview preview = new Preview($"{settings.mods[mods_list.SelectedIndex].path}\\{mod.screenshot}");
            UILogs("preview_load", null);
            preview.ShowDialog();
            preview.Dispose();
            UILogs("preview_loaded", null);
        }
        private Task load_settings()
        {
            UILogs("settings_load", null).Wait();
            settings = new Settings.Rootobject();

            if (Directory.Exists(ids.ids("settings")) == true)
            {
                if (File.Exists($"{ids.ids("settings")}\\{ids.ids("configuration")}") == true)
                {
                    settings = JsonConvert.DeserializeObject<Settings.Rootobject>(File.ReadAllText($"{ids.ids("settings")}\\{ids.ids("configuration")}"));
                    loaded = true;
                } else
                {
                    boxer($"Configuration file '{ids.ids("configuration")}' not found", "error").Wait();
                }
            } else
            {
                boxer($"Directory '{ids.ids("settings")}' not found", "error").Wait();
            }
            UILogs("settings_loaded", null).Wait();

            return (Task.CompletedTask);
        }
        private Task load_games()
        {
            UILogs("games_refresh", null).Wait();
            games_list.Items.Clear();

            if (loaded == true)
            {
                if (settings.games.Count > 0)
                {
                    for (int i = 0; i < settings.games.Count; i++)
                    {
                        if (Directory.Exists($"{settings.games[i].path}") == true)
                        {
                            games_list.Items.Add(settings.games[i].name);
                        }
                        else
                        {
                            boxer($"Game path not found:\n\nName: '{settings.games[i].name}'\nPath: '{settings.games[i].path}'", "game error").Wait();
                        }
                    }
                } else
                {
                    UILogs("no_game_name_load", null).Wait();
                }
            }
            UILogs("games_refreshed", null).Wait();

            return (Task.CompletedTask);
        }
        private Task add_game()
        {
            UILogs("games_add", null).Wait();
            Game_add game = new Game_add();
            game.ShowDialog();
            game.Dispose();
            UILogs("games_added", null).Wait();

            return (Task.CompletedTask);
        }
        private Task add_mod()
        {
            UILogs("mods_add", null).Wait();
            Mod_add mod = new Mod_add();
            mod.ShowDialog();
            mod.Dispose();
            UILogs("mods_added", null).Wait();

            return (Task.CompletedTask);
        }
        private void game_add_Click(object sender, EventArgs e)
        {
            add_game().Wait();
            load_settings().Wait();
            load_games().Wait();
        }
        private void game_remove_Click(object sender, EventArgs e)
        {

        }
        private void mods_add_Click(object sender, EventArgs e)
        {
            add_mod().Wait();
            load_settings().Wait();
            load_mods().Wait();
        }
        private void mods_remove_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load_settings().Wait();
            load_games().Wait();
            load_mods().Wait();
        }

        private void games_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
