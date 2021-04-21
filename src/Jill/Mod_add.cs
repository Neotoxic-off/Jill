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
    public partial class Mod_add : Form
    {
        Ids ids = new Ids();
        Settings.Rootobject settings = null;

        public Mod_add()
        {
            InitializeComponent();
        }

        private int count_char(string str, char c)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
                if (str[i] == c)
                    count++;

            return (count);
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (mod_path.SelectedPath.Length >= 1)
            {
                if (Directory.Exists(mod_path.SelectedPath) == true)
                {
                    string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";
                    settings = JsonConvert.DeserializeObject<Settings.Rootobject>(File.ReadAllText(path));
                    settings.mods.Add(new Settings.Mods(mod_name.Text, mod_path.SelectedPath));

                    if (File.Exists(path) == true)
                        File.Delete(path);
                    File.WriteAllText(path, JsonConvert.SerializeObject(settings));
                    Close();
                    return;
                }
                MessageBox.Show("Mod path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mod_name.Text.Length < 1)
            {
                MessageBox.Show("Mod name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            mod_path.ShowDialog();
            mod_name.Text = mod_path.SelectedPath.Split('\\')[count_char(mod_path.SelectedPath, '\\')];
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mod_add_Load(object sender, EventArgs e)
        {

        }
    }
}
