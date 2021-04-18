
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
            this.modToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logs_time = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.About = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infos = new System.Windows.Forms.ListView();
            this.Informations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.check_all = new System.Windows.Forms.Button();
            this.uncheck_all = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.preview = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TabPage();
            this.log_value = new System.Windows.Forms.RichTextBox();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.game_add = new System.Windows.Forms.ToolStripMenuItem();
            this.game_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mods_installed = new System.Windows.Forms.TabPage();
            this.mods_list = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Games = new System.Windows.Forms.TabPage();
            this.games_list = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.About.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Log.SuspendLayout();
            this.mods_installed.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Games.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.modToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modToolStripMenuItem
            // 
            this.modToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem1});
            this.modToolStripMenuItem.Name = "modToolStripMenuItem";
            this.modToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.modToolStripMenuItem.Text = "Mod";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
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
            this.splitContainer1.Size = new System.Drawing.Size(993, 664);
            this.splitContainer1.SplitterDistance = 509;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.About);
            this.tabControl2.Controls.Add(this.Log);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(480, 664);
            this.tabControl2.TabIndex = 0;
            // 
            // About
            // 
            this.About.Controls.Add(this.panel2);
            this.About.Controls.Add(this.infos);
            this.About.Controls.Add(this.panel1);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(472, 638);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 1);
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
            this.infos.Size = new System.Drawing.Size(472, 604);
            this.infos.TabIndex = 5;
            this.infos.UseCompatibleStateImageBehavior = false;
            this.infos.View = System.Windows.Forms.View.Details;
            // 
            // Informations
            // 
            this.Informations.Text = "Informations";
            this.Informations.Width = 243;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 229;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 34);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.check_all);
            this.panel4.Controls.Add(this.uncheck_all);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 34);
            this.panel4.TabIndex = 7;
            // 
            // check_all
            // 
            this.check_all.Location = new System.Drawing.Point(3, 6);
            this.check_all.Name = "check_all";
            this.check_all.Size = new System.Drawing.Size(98, 23);
            this.check_all.TabIndex = 1;
            this.check_all.Text = "Check all";
            this.check_all.UseVisualStyleBackColor = true;
            this.check_all.Click += new System.EventHandler(this.check_all_Click);
            // 
            // uncheck_all
            // 
            this.uncheck_all.Location = new System.Drawing.Point(107, 6);
            this.uncheck_all.Name = "uncheck_all";
            this.uncheck_all.Size = new System.Drawing.Size(98, 23);
            this.uncheck_all.TabIndex = 2;
            this.uncheck_all.Text = "Uncheck all";
            this.uncheck_all.UseVisualStyleBackColor = true;
            this.uncheck_all.Click += new System.EventHandler(this.uncheck_all_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.preview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(368, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 34);
            this.panel3.TabIndex = 7;
            // 
            // preview
            // 
            this.preview.Enabled = false;
            this.preview.Location = new System.Drawing.Point(3, 6);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(98, 23);
            this.preview.TabIndex = 0;
            this.preview.Text = "Preview";
            this.preview.UseVisualStyleBackColor = true;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // Log
            // 
            this.Log.Controls.Add(this.log_value);
            this.Log.Location = new System.Drawing.Point(4, 22);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(3);
            this.Log.Size = new System.Drawing.Size(472, 638);
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
            this.log_value.Size = new System.Drawing.Size(466, 632);
            this.log_value.TabIndex = 0;
            this.log_value.Text = "";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.game_add,
            this.game_remove});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // game_add
            // 
            this.game_add.Name = "game_add";
            this.game_add.Size = new System.Drawing.Size(180, 22);
            this.game_add.Text = "Add";
            // 
            // game_remove
            // 
            this.game_remove.Name = "game_remove";
            this.game_remove.Size = new System.Drawing.Size(180, 22);
            this.game_remove.Text = "Remove";
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            // 
            // mods_installed
            // 
            this.mods_installed.Controls.Add(this.mods_list);
            this.mods_installed.Location = new System.Drawing.Point(4, 22);
            this.mods_installed.Name = "mods_installed";
            this.mods_installed.Padding = new System.Windows.Forms.Padding(3);
            this.mods_installed.Size = new System.Drawing.Size(501, 638);
            this.mods_installed.TabIndex = 0;
            this.mods_installed.Text = "Mods Installed";
            this.mods_installed.UseVisualStyleBackColor = true;
            // 
            // mods_list
            // 
            this.mods_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mods_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mods_list.FormattingEnabled = true;
            this.mods_list.Location = new System.Drawing.Point(3, 3);
            this.mods_list.Name = "mods_list";
            this.mods_list.Size = new System.Drawing.Size(495, 632);
            this.mods_list.TabIndex = 0;
            this.mods_list.SelectedIndexChanged += new System.EventHandler(this.mods_list_SelectedIndexChanged_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mods_installed);
            this.tabControl1.Controls.Add(this.Games);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 664);
            this.tabControl1.TabIndex = 2;
            // 
            // Games
            // 
            this.Games.BackColor = System.Drawing.SystemColors.Window;
            this.Games.Controls.Add(this.games_list);
            this.Games.Location = new System.Drawing.Point(4, 22);
            this.Games.Name = "Games";
            this.Games.Padding = new System.Windows.Forms.Padding(3);
            this.Games.Size = new System.Drawing.Size(501, 638);
            this.Games.TabIndex = 1;
            this.Games.Text = "Games";
            // 
            // games_list
            // 
            this.games_list.BackColor = System.Drawing.SystemColors.Window;
            this.games_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.games_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.games_list.FormattingEnabled = true;
            this.games_list.Location = new System.Drawing.Point(3, 3);
            this.games_list.Name = "games_list";
            this.games_list.Size = new System.Drawing.Size(495, 632);
            this.games_list.TabIndex = 3;
            // 
            // Jill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 688);
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
            this.tabControl2.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Log.ResumeLayout(false);
            this.mods_installed.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Games.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.ToolStripMenuItem modToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.TabPage Log;
        private System.Windows.Forms.RichTextBox log_value;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logs_time;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.Button uncheck_all;
        private System.Windows.Forms.Button check_all;
        private System.Windows.Forms.ListView infos;
        private System.Windows.Forms.ColumnHeader Informations;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem game_add;
        private System.Windows.Forms.ToolStripMenuItem game_remove;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mods_installed;
        private System.Windows.Forms.CheckedListBox mods_list;
        private System.Windows.Forms.TabPage Games;
        private System.Windows.Forms.CheckedListBox games_list;
    }
}

