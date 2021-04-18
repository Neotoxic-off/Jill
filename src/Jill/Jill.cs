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

            return (Task.CompletedTask);
        }

        private Task load_mods()
        {
            string[] mods = Directory.GetDirectories(ids.ids("mods"));
            int count = mods.Length;

            mod = new Mod.Rootobject();
            for (int i = 0; i < count; i++)
            {
                mods_list.Items.Add(mods[i].Split('\\')[1]);
            }

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
            infos.Items.Clear();

            if (mods_list.SelectedIndex > -1)
            {
                if (File.Exists($"{path}\\{ids.ids("modinfo")}") == true)
                {
                    UILogs("ini_load", $"{path}\\{ids.ids("modinfo")}").Wait();
                    FileIniDataParser parser = new FileIniDataParser();
                    IniData data = parser.ReadFile($"{path}\\{ids.ids("modinfo")}");
                    UILogs("ini_loaded", $"{path}\\{ids.ids("modinfo")}").Wait();

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

        private void mods_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            load_modinfos($"{ids.ids("mods")}\\{mods_list.SelectedItem}");
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
            Preview preview = new Preview($"{ids.ids("mods")}\\{mods_list.SelectedItem}\\{mod.screenshot}");
            UILogs("preview_load", null);
            preview.ShowDialog();
            preview.Dispose();
            UILogs("preview_loaded", null);
        }

        private Task load_settings()
        {
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

            return (Task.CompletedTask);
        }
        private Task load_games()
        {
            if (loaded == true)
            {
                if (settings.games.name.Length > 0)
                {
                    for (int i = 0; i < settings.games.name.Length; i++)
                    {
                        games_list.Items.Add(settings.games.name[i]);
                    }
                }
            }

            return (Task.CompletedTask);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UILogs("settings_load", null);
            load_settings();
            UILogs("settings_loaded", null);

            UILogs("games_load", null);
            load_games();
            UILogs("games_loaded", null);

            UILogs("mods_load", null);
            load_mods().Wait();
            UILogs("mods_loaded", null);
        }
    }
}
