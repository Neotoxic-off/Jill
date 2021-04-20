﻿using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

using SETTINGS;
using IDS;

namespace Jill
{
    public partial class Game_add : Form
    {
        Ids ids = new Ids();
        Settings.Rootobject settings = null;

        public Game_add()
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

        private void browse_Click(object sender, EventArgs e)
        {
            game_path.ShowDialog();
            game_name.Text = game_path.SelectedPath.Split('\\')[count_char(game_path.SelectedPath, '\\')];
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (game_path.SelectedPath.Length >= 1)
            {
                if (Directory.Exists(game_path.SelectedPath) == true)
                {
                    string path = $"{ids.ids("settings")}\\{ids.ids("configuration")}";
                    settings = JsonConvert.DeserializeObject<Settings.Rootobject>(File.ReadAllText(path));
                    settings.games.Add(new Settings.Game(game_name.Text, game_path.SelectedPath));

                    if (File.Exists(path) == true)
                        File.Delete(path);
                    File.WriteAllText(path, JsonConvert.SerializeObject(settings));
                    Close();
                    return;
                }
                MessageBox.Show("Game path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (game_name.Text.Length < 1)
            {
                MessageBox.Show("Game name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}