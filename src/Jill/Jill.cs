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
        bool errors = false;
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
            log_value.ScrollToCaret();

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

            if (type == "missing path")
            {
                MessageBox.Show(content, type, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (type == "informations")
            {
                MessageBox.Show(content, type, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            UILogs("mod_path_not_found", $"{settings.mods[i].path}").Wait();
                            if (errors == false)
                                errors = true;
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
        private Task load_modinfos(string path)
        {
            string full_path = $"{path}\\{ids.ids("modinfo")}";

            mod = new Mod.Rootobject();
            infos.Items.Clear();

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

                add_value(mod.name, "Name").Wait();
                add_value(mod.version, "Version").Wait();
                add_value(mod.description, "Description").Wait();
                add_value(mod.category, "Category").Wait();
                add_value($"{mod.screenshot}", "Preview").Wait();
                add_value(mod.author, "Author").Wait();
                UILogs("infos_loaded", path).Wait();
            } else
                add_value("No mod information to load", "Mod's informations").Wait();
            
            return (Task.CompletedTask);
        }
        private Task load_gameinfos()
        {
            infos.Items.Clear();

            add_value(settings.games[games_list.SelectedIndex].name, "Name").Wait();
            add_value(settings.games[games_list.SelectedIndex].path, "Path").Wait();

            for (int i = 0; i < settings.games[games_list.SelectedIndex].mods.Count; i++)
            {
                if (i == 0)
                {
                    add_value("", "").Wait();
                    add_value(settings.games[games_list.SelectedIndex].mods[i], "Mods").Wait();
                } else
                {
                    add_value(settings.games[games_list.SelectedIndex].mods[i], "").Wait();
                }
            }

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
                            UILogs("game_path_not_found", $"{settings.games[i].path}").Wait();
                            if (errors == false)
                                errors = true;
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
        private Task remove_game()
        {
            UILogs("games_remove", null).Wait();
            Game_remove game = new Game_remove();
            game.ShowDialog();
            game.Dispose();
            UILogs("games_removed", null).Wait();

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
        private Task remove_mod()
        {
            UILogs("mods_remove", null).Wait();
            Mod_remove mod = new Mod_remove();
            mod.ShowDialog();
            mod.Dispose();
            UILogs("mods_removed", null).Wait();

            return (Task.CompletedTask);
        }
        private Task add_mod_to_game()
        {
            UILogs("add_mod_to_game", null).Wait();
            Add_mod_to_game add_mod_to_game = new Add_mod_to_game();
            add_mod_to_game.ShowDialog();
            add_mod_to_game.Dispose();
            UILogs("added_mod_to_game", null).Wait();

            return (Task.CompletedTask);
        }
        private Task remove_mod_to_game()
        {
            UILogs("remove_mod_to_game", null).Wait();
            Remove_to_game remove_mod_to_game = new Remove_to_game();
            remove_mod_to_game.ShowDialog();
            remove_mod_to_game.Dispose();
            UILogs("removed_mod_to_game", null).Wait();

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
            remove_game().Wait();
            load_settings().Wait();
            load_games().Wait();
        }
        private void mods_add_Click(object sender, EventArgs e)
        {
            add_mod().Wait();
            load_settings().Wait();
            load_mods().Wait();
        }
        private void mods_remove_Click(object sender, EventArgs e)
        {
            remove_mod().Wait();
            load_settings().Wait();
            load_mods().Wait();
        }
        private void add_to_game_Click_1(object sender, EventArgs e)
        {
            add_mod_to_game().Wait();
            load_settings().Wait();
            load_games().Wait();
        }
        private void remove_to_game_Click_1(object sender, EventArgs e)
        {
            remove_mod_to_game().Wait();
            load_settings().Wait();
            load_games().Wait();
        }
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boxer($"Version: {settings.version}\n", "informations").Wait();
        }
        private void preview_Click_1(object sender, EventArgs e)
        {
            Preview preview = new Preview($"{settings.mods[mods_list.SelectedIndex].path}\\{mod.screenshot}");
            UILogs("preview_load", null);
            preview.ShowDialog();
            preview.Dispose();
            UILogs("preview_loaded", null);
        }
        private void mods_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (mods_list.SelectedIndex > -1)
            {
                preview.Enabled = true;
                load_modinfos($"{settings.mods[mods_list.SelectedIndex].path}");
            } else
            {
                preview.Enabled = false;
            }
        }
        private void games_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (games_list.SelectedIndex > -1)
                load_gameinfos().Wait();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load_settings().Wait();
            load_games().Wait();
            load_mods().Wait();

            if (errors == true)
                boxer("You have some game / mods not loaded due to path not found for more informations check the 'logs'", "missing path").Wait();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UILogs("mods_install", null).Wait();
            UILogs("mods_installed", null).Wait();
        }
    }
}
