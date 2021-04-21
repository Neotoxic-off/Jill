using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SETTINGS;
using IDS;
using Newtonsoft.Json;
using System.IO;

namespace Jill
{
    public partial class Game_remove : Form
    {
        Ids ids = new Ids();
        Settings.Rootobject settings = null;

        public Game_remove()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";

            for (int i = 0; i < settings.games.Count; i++)
            {
                if (settings.games[i].name == game_list.Text)
                    settings.games.RemoveAt(i);

                if (File.Exists(path) == true)
                    File.Delete(path);
                File.WriteAllText(path, JsonConvert.SerializeObject(settings));
            }
            Close();
            return;
        }

        private Task boxer(string content, string type)
        {
            MessageBox.Show(content, type, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return (Task.CompletedTask);
        }

        private void Game_remove_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(ids.ids("settings")) == true)
            {
                if (File.Exists($"{ids.ids("settings")}\\{ids.ids("configuration")}") == true)
                {
                    settings = JsonConvert.DeserializeObject<Settings.Rootobject>(File.ReadAllText($"{ids.ids("settings")}\\{ids.ids("configuration")}"));
                    for (int i = 0; i < settings.games.Count; i++)
                        game_list.Items.Add(settings.games[i].name);
                    game_list.SelectedIndex = 0;
                }
                else
                {
                    boxer($"Configuration file '{ids.ids("configuration")}' not found", "error").Wait();
                }
            }
            else
            {
                boxer($"Directory '{ids.ids("settings")}' not found", "error").Wait();
            }
        }
    }
}
