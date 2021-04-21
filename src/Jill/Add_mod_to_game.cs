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

        public Add_mod_to_game(CheckedListBox.CheckedItemCollection mods)
        {
            InitializeComponent();
            for (int i = 0; i < mods.Count; i++)
                mods_list.Items.Add(mods[i]);
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
            game_name.SelectedIndex = 0;
        }

        private int get_index(string name)
        {
            int i = 0;

            for (; i < settings.games.Count; i++)
                if (settings.games[i].name == name)
                    return (i);

            return (-1);
        }

        private void apply_Click(object sender, EventArgs e)
        {
            string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";
            int index = get_index(game_name.SelectedItem.ToString());

            if (index > -1)
            {
                for (int i = 0; i < mods_list.Items.Count; i++)
                {
                    settings.games[index].mods.Add(mods_list.Items[i].ToString());
                }

                if (File.Exists(path) == true)
                    File.Delete(path);
                File.WriteAllText(path, JsonConvert.SerializeObject(settings));
                Close();
            } else
            {
                MessageBox.Show("No game selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return;
        }
    }
}
