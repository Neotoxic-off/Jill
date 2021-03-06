using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

using IDS;
using SETTINGS;
using System.IO;

namespace Jill
{
    public partial class Add_mod_to_game : Form
    {
        Ids ids = new Ids();
        Settings.Rootobject settings = null;

        public Add_mod_to_game()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_mod_to_game_Load(object sender, EventArgs e)
        {
            string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";
            settings = JsonConvert.DeserializeObject<Settings.Rootobject>(File.ReadAllText(path));

            for (int i = 0; i < settings.games.Count; i++)
            {
                game_name.Items.Add(settings.games[i].name);
            }
            for (int i = 0; i < settings.mods.Count; i++)
            {
                mods_list.Items.Add(settings.mods[i].name);
            }

            game_name.SelectedIndex = 0;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";

            for (int i = 0; i < mods_list.CheckedItems.Count; i++)
            {
                settings.games[game_name.SelectedIndex].mods.Add(mods_list.CheckedItems[i].ToString());
            }

            if (File.Exists(path) == true)
                File.Delete(path);
            File.WriteAllText(path, JsonConvert.SerializeObject(settings));
            Close();
            
            return;
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
