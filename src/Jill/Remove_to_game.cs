using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;

using IDS;
using SETTINGS;

namespace Jill
{
    public partial class Remove_to_game : Form
    {
        Ids ids = new Ids();
        Settings.Rootobject settings = null;

        public Remove_to_game()
        {
            InitializeComponent();
        }

        private void Remove_to_game_Load(object sender, EventArgs e)
        {
            string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";
            settings = JsonConvert.DeserializeObject<Settings.Rootobject>(File.ReadAllText(path));

            for (int i = 0; i < settings.games.Count; i++)
            {
                game_name.Items.Add(settings.games[i].name);
            }
            game_name.SelectedIndex = 0;
        }

        private void game_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            mods_list.Items.Clear();

            for (int i = 0; i < settings.games[game_name.SelectedIndex].mods.Count; i++)
            {
                mods_list.Items.Add(settings.games[game_name.SelectedIndex].mods[i]);
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";

            for (int mods = 0; mods < settings.games[game_name.SelectedIndex].mods.Count; mods++)
            {
                for (int i = 0; i < mods_list.CheckedItems.Count; i++)
                {
                    if (settings.games[game_name.SelectedIndex].mods[mods] == mods_list.CheckedItems[i])
                        settings.games[game_name.SelectedIndex].mods.RemoveAt(mods);
                }
            }
            
            if (File.Exists(path) == true)
                File.Delete(path);
            File.WriteAllText(path, JsonConvert.SerializeObject(settings));

            Close();
            return;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void check_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mods_list.Items.Count; i++)
            {
                mods_list.SetItemChecked(i, true);
            }
        }

        private void uncheck_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mods_list.Items.Count; i++)
            {
                mods_list.SetItemChecked(i, false);
            }
        }
    }
}
