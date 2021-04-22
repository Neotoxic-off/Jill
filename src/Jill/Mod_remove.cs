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
using System.IO;
using Newtonsoft.Json;

namespace Jill
{
    public partial class Mod_remove : Form
    {
        Ids ids = new Ids();
        Settings.Rootobject settings = null;

        public Mod_remove()
        {
            InitializeComponent();
        }

        private Task boxer(string content, string type)
        {
            MessageBox.Show(content, type, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return (Task.CompletedTask);
        }

        private void Mod_remove_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(ids.ids("settings")) == true)
            {
                if (File.Exists($"{ids.ids("settings")}\\{ids.ids("configuration")}") == true)
                {
                    settings = JsonConvert.DeserializeObject<Settings.Rootobject>(File.ReadAllText($"{ids.ids("settings")}\\{ids.ids("configuration")}"));
                    for (int i = 0; i < settings.mods.Count; i++)
                        mods_list.Items.Add(settings.mods[i].name);
                    if (mods_list.Items.Count > 0)
                        mods_list.SelectedIndex = 0;
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

        private void apply_Click(object sender, EventArgs e)
        {
            string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";

            for (int i = 0; i < settings.mods.Count; i++)
            {
                if (settings.mods[i].name == mods_list.Text)
                    settings.mods.RemoveAt(i);

                if (File.Exists(path) == true)
                    File.Delete(path);
                File.WriteAllText(path, JsonConvert.SerializeObject(settings));
            }
            Close();
            return;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
