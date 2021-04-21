
namespace Jill
{
    partial class Jill
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jill));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logs_time = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mods_installed = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.mods_remove = new System.Windows.Forms.Button();
            this.mods_add = new System.Windows.Forms.Button();
            this.Games = new System.Windows.Forms.TabPage();
            this.games_list = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.game_add = new System.Windows.Forms.Button();
            this.game_remove = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.About = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infos = new System.Windows.Forms.ListView();
            this.Informations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.add_to_game = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TabPage();
            this.log_value = new System.Windows.Forms.RichTextBox();
            this.remove_to_game = new System.Windows.Forms.Button();
            this.mods_list = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mods_installed.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.Games.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.About.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autosaveToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // autosaveToolStripMenuItem
            // 
            this.autosaveToolStripMenuItem.Checked = true;
            this.autosaveToolStripMenuItem.CheckOnClick = true;
            this.autosaveToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autosaveToolStripMenuItem.Name = "autosaveToolStripMenuItem";
            this.autosaveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.autosaveToolStripMenuItem.Text = "Autosave";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logs_time});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // logs_time
            // 
            this.logs_time.Checked = true;
            this.logs_time.CheckOnClick = true;
            this.logs_time.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logs_time.Name = "logs_time";
            this.logs_time.Size = new System.Drawing.Size(180, 22);
            this.logs_time.Text = "Time";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1109, 665);
            this.splitContainer1.SplitterDistance = 568;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mods_installed);
            this.tabControl1.Controls.Add(this.Games);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 665);
            this.tabControl1.TabIndex = 2;
            // 
            // mods_installed
            // 
            this.mods_installed.Controls.Add(this.mods_list);
            this.mods_installed.Controls.Add(this.panel12);
            this.mods_installed.Controls.Add(this.panel9);
            this.mods_installed.Location = new System.Drawing.Point(4, 22);
            this.mods_installed.Name = "mods_installed";
            this.mods_installed.Padding = new System.Windows.Forms.Padding(3);
            this.mods_installed.Size = new System.Drawing.Size(560, 639);
            this.mods_installed.TabIndex = 0;
            this.mods_installed.Text = "Mods";
            this.mods_installed.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(3, 601);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(554, 1);
            this.panel12.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 602);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(554, 34);
            this.panel9.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.mods_remove);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(213, 34);
            this.panel10.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.mods_add);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(343, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(211, 34);
            this.panel11.TabIndex = 7;
            // 
            // mods_remove
            // 
            this.mods_remove.Location = new System.Drawing.Point(5, 6);
            this.mods_remove.Name = "mods_remove";
            this.mods_remove.Size = new System.Drawing.Size(98, 23);
            this.mods_remove.TabIndex = 1;
            this.mods_remove.Text = "Remove mod";
            this.mods_remove.UseVisualStyleBackColor = true;
            this.mods_remove.Click += new System.EventHandler(this.mods_remove_Click);
            // 
            // mods_add
            // 
            this.mods_add.Location = new System.Drawing.Point(107, 6);
            this.mods_add.Name = "mods_add";
            this.mods_add.Size = new System.Drawing.Size(98, 23);
            this.mods_add.TabIndex = 0;
            this.mods_add.Text = "Import mod";
            this.mods_add.UseVisualStyleBackColor = true;
            this.mods_add.Click += new System.EventHandler(this.mods_add_Click);
            // 
            // Games
            // 
            this.Games.BackColor = System.Drawing.SystemColors.Window;
            this.Games.Controls.Add(this.games_list);
            this.Games.Controls.Add(this.panel8);
            this.Games.Controls.Add(this.panel5);
            this.Games.Location = new System.Drawing.Point(4, 22);
            this.Games.Name = "Games";
            this.Games.Padding = new System.Windows.Forms.Padding(3);
            this.Games.Size = new System.Drawing.Size(560, 639);
            this.Games.TabIndex = 1;
            this.Games.Text = "Games";
            // 
            // games_list
            // 
            this.games_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.games_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.games_list.FormattingEnabled = true;
            this.games_list.Location = new System.Drawing.Point(3, 3);
            this.games_list.Name = "games_list";
            this.games_list.Size = new System.Drawing.Size(554, 598);
            this.games_list.TabIndex = 8;
            this.games_list.SelectedIndexChanged += new System.EventHandler(this.games_list_SelectedIndexChanged_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(3, 601);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(554, 1);
            this.panel8.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 602);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(554, 34);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.game_remove);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(111, 34);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.game_add);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(343, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 34);
            this.panel7.TabIndex = 7;
            // 
            // game_add
            // 
            this.game_add.Location = new System.Drawing.Point(107, 6);
            this.game_add.Name = "game_add";
            this.game_add.Size = new System.Drawing.Size(98, 23);
            this.game_add.TabIndex = 0;
            this.game_add.Text = "Import game";
            this.game_add.UseVisualStyleBackColor = true;
            this.game_add.Click += new System.EventHandler(this.game_add_Click);
            // 
            // game_remove
            // 
            this.game_remove.Location = new System.Drawing.Point(5, 6);
            this.game_remove.Name = "game_remove";
            this.game_remove.Size = new System.Drawing.Size(98, 23);
            this.game_remove.TabIndex = 1;
            this.game_remove.Text = "Remove game";
            this.game_remove.UseVisualStyleBackColor = true;
            this.game_remove.Click += new System.EventHandler(this.game_remove_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.About);
            this.tabControl2.Controls.Add(this.Log);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(537, 665);
            this.tabControl2.TabIndex = 0;
            // 
            // About
            // 
            this.About.Controls.Add(this.panel2);
            this.About.Controls.Add(this.infos);
            this.About.Controls.Add(this.panel1);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(529, 639);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 1);
            this.panel2.TabIndex = 6;
            // 
            // infos
            // 
            this.infos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Informations,
            this.Value});
            this.infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infos.GridLines = true;
            this.infos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.infos.HideSelection = false;
            this.infos.Location = new System.Drawing.Point(0, 0);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(529, 601);
            this.infos.TabIndex = 5;
            this.infos.UseCompatibleStateImageBehavior = false;
            this.infos.View = System.Windows.Forms.View.Details;
            // 
            // Informations
            // 
            this.Informations.Text = "";
            this.Informations.Width = 150;
            // 
            // Value
            // 
            this.Value.Text = "";
            this.Value.Width = 350;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 601);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 38);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.remove_to_game);
            this.panel4.Controls.Add(this.add_to_game);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 38);
            this.panel4.TabIndex = 7;
            // 
            // add_to_game
            // 
            this.add_to_game.Location = new System.Drawing.Point(3, 7);
            this.add_to_game.Name = "add_to_game";
            this.add_to_game.Size = new System.Drawing.Size(98, 23);
            this.add_to_game.TabIndex = 0;
            this.add_to_game.Text = "Add mod(s)";
            this.add_to_game.UseVisualStyleBackColor = true;
            this.add_to_game.Click += new System.EventHandler(this.add_to_game_Click);
            // 
            // preview
            // 
            this.preview.Enabled = false;
            this.preview.Location = new System.Drawing.Point(52, 7);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(98, 23);
            this.preview.TabIndex = 1;
            this.preview.Text = "Preview mod";
            this.preview.UseVisualStyleBackColor = true;
            this.preview.Click += new System.EventHandler(this.preview_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.preview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(267, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 38);
            this.panel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Install Mods";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Controls.Add(this.log_value);
            this.Log.Location = new System.Drawing.Point(4, 22);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(3);
            this.Log.Size = new System.Drawing.Size(529, 639);
            this.Log.TabIndex = 1;
            this.Log.Text = "Logs";
            this.Log.UseVisualStyleBackColor = true;
            // 
            // log_value
            // 
            this.log_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_value.Location = new System.Drawing.Point(3, 3);
            this.log_value.Name = "log_value";
            this.log_value.ReadOnly = true;
            this.log_value.Size = new System.Drawing.Size(523, 633);
            this.log_value.TabIndex = 0;
            this.log_value.Text = "";
            // 
            // remove_to_game
            // 
            this.remove_to_game.Location = new System.Drawing.Point(107, 7);
            this.remove_to_game.Name = "remove_to_game";
            this.remove_to_game.Size = new System.Drawing.Size(98, 23);
            this.remove_to_game.TabIndex = 2;
            this.remove_to_game.Text = "Remove mod(s)";
            this.remove_to_game.UseVisualStyleBackColor = true;
            this.remove_to_game.Click += new System.EventHandler(this.remove_to_game_Click);
            // 
            // mods_list
            // 
            this.mods_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mods_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mods_list.FormattingEnabled = true;
            this.mods_list.Location = new System.Drawing.Point(3, 3);
            this.mods_list.Name = "mods_list";
            this.mods_list.Size = new System.Drawing.Size(554, 598);
            this.mods_list.TabIndex = 9;
            this.mods_list.SelectedIndexChanged += new System.EventHandler(this.mods_list_SelectedIndexChanged_1);
            // 
            // Jill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 689);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Jill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mods_installed.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.Games.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Log.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Log;
        private System.Windows.Forms.RichTextBox log_value;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logs_time;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_to_game;
        private System.Windows.Forms.ListView infos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mods_installed;
        private System.Windows.Forms.TabPage Games;
        private System.Windows.Forms.ToolStripMenuItem autosaveToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button game_add;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button game_remove;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button mods_remove;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button mods_add;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Informations;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox games_list;
        private System.Windows.Forms.Button remove_to_game;
        private System.Windows.Forms.ListBox mods_list;
    }
}

