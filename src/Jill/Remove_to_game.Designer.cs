
namespace Jill
{
    partial class Remove_to_game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_to_game));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.game_name = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mods_list = new System.Windows.Forms.CheckedListBox();
            this.check_all = new System.Windows.Forms.Button();
            this.uncheck_all = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uncheck_all);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.check_all);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.apply);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 296);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Remove Mod(s) from Game ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.game_name);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Game ";
            // 
            // game_name
            // 
            this.game_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.game_name.FormattingEnabled = true;
            this.game_name.Location = new System.Drawing.Point(13, 26);
            this.game_name.Margin = new System.Windows.Forms.Padding(10);
            this.game_name.Name = "game_name";
            this.game_name.Size = new System.Drawing.Size(307, 21);
            this.game_name.TabIndex = 0;
            this.game_name.SelectedIndexChanged += new System.EventHandler(this.game_name_SelectedIndexChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(183, 267);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(264, 267);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 5;
            this.apply.Text = "Remove";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mods_list);
            this.groupBox3.Location = new System.Drawing.Point(6, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 149);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Mods ";
            // 
            // mods_list
            // 
            this.mods_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mods_list.FormattingEnabled = true;
            this.mods_list.Location = new System.Drawing.Point(13, 19);
            this.mods_list.Name = "mods_list";
            this.mods_list.Size = new System.Drawing.Size(307, 120);
            this.mods_list.TabIndex = 0;
            // 
            // check_all
            // 
            this.check_all.Location = new System.Drawing.Point(6, 267);
            this.check_all.Name = "check_all";
            this.check_all.Size = new System.Drawing.Size(75, 23);
            this.check_all.TabIndex = 7;
            this.check_all.Text = "Check all";
            this.check_all.UseVisualStyleBackColor = true;
            this.check_all.Click += new System.EventHandler(this.check_all_Click);
            // 
            // uncheck_all
            // 
            this.uncheck_all.Location = new System.Drawing.Point(87, 267);
            this.uncheck_all.Name = "uncheck_all";
            this.uncheck_all.Size = new System.Drawing.Size(75, 23);
            this.uncheck_all.TabIndex = 8;
            this.uncheck_all.Text = "Uncheck all";
            this.uncheck_all.UseVisualStyleBackColor = true;
            this.uncheck_all.Click += new System.EventHandler(this.uncheck_all_Click);
            // 
            // Remove_to_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(369, 320);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Remove_to_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove to game";
            this.Load += new System.EventHandler(this.Remove_to_game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox game_name;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox mods_list;
        private System.Windows.Forms.Button uncheck_all;
        private System.Windows.Forms.Button check_all;
    }
}