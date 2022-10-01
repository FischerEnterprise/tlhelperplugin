namespace Turbo.Plugins.TL.Helper.UI
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // /// <summary>
        // /// Verwendete Ressourcen bereinigen.
        // /// </summary>
        // /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        // protected override void Dispose(bool disposing)
        // {
        //     if (disposing && (components != null))
        //     {
        //         components.Dispose();
        //     }
        //     base.Dispose(disposing);
        // }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Town = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_KadalaItem = new System.Windows.Forms.ComboBox();
            this.gb_Skills = new System.Windows.Forms.GroupBox();
            this.cb_SkillPotion = new System.Windows.Forms.CheckBox();
            this.cb_Skill6 = new System.Windows.Forms.CheckBox();
            this.cb_Skill5 = new System.Windows.Forms.CheckBox();
            this.cb_Skill4 = new System.Windows.Forms.CheckBox();
            this.cb_Skill3 = new System.Windows.Forms.CheckBox();
            this.cb_Skill2 = new System.Windows.Forms.CheckBox();
            this.cb_Skill1 = new System.Windows.Forms.CheckBox();
            this.gb_Rift = new System.Windows.Forms.GroupBox();
            this.cb_EmpowerGR = new System.Windows.Forms.CheckBox();
            this.rb_AutoOpenDisabled = new System.Windows.Forms.RadioButton();
            this.cb_AutoAcceptRifts = new System.Windows.Forms.CheckBox();
            this.cb_CloseRiftDialogs = new System.Windows.Forms.CheckBox();
            this.rb_OpenGR = new System.Windows.Forms.RadioButton();
            this.rb_OpenRift = new System.Windows.Forms.RadioButton();
            this.gb_Menu = new System.Windows.Forms.GroupBox();
            this.cb_AutoStartGame = new System.Windows.Forms.CheckBox();
            this.gb_Town.SuspendLayout();
            this.gb_Skills.SuspendLayout();
            this.gb_Rift.SuspendLayout();
            this.gb_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Town
            // 
            this.gb_Town.Controls.Add(this.label1);
            this.gb_Town.Controls.Add(this.cb_KadalaItem);
            this.gb_Town.Location = new System.Drawing.Point(12, 12);
            this.gb_Town.Name = "gb_Town";
            this.gb_Town.Size = new System.Drawing.Size(248, 54);
            this.gb_Town.TabIndex = 0;
            this.gb_Town.TabStop = false;
            this.gb_Town.Text = "Town";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kadala Item";
            // 
            // cb_KadalaItem
            // 
            this.cb_KadalaItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_KadalaItem.FormattingEnabled = true;
            this.cb_KadalaItem.Location = new System.Drawing.Point(75, 18);
            this.cb_KadalaItem.Name = "cb_KadalaItem";
            this.cb_KadalaItem.Size = new System.Drawing.Size(167, 21);
            this.cb_KadalaItem.TabIndex = 0;
            this.cb_KadalaItem.SelectedIndexChanged += new System.EventHandler(this.cb_KadalaItem_SelectedIndexChanged);
            // 
            // gb_Skills
            // 
            this.gb_Skills.Controls.Add(this.cb_SkillPotion);
            this.gb_Skills.Controls.Add(this.cb_Skill6);
            this.gb_Skills.Controls.Add(this.cb_Skill5);
            this.gb_Skills.Controls.Add(this.cb_Skill4);
            this.gb_Skills.Controls.Add(this.cb_Skill3);
            this.gb_Skills.Controls.Add(this.cb_Skill2);
            this.gb_Skills.Controls.Add(this.cb_Skill1);
            this.gb_Skills.Location = new System.Drawing.Point(12, 72);
            this.gb_Skills.Name = "gb_Skills";
            this.gb_Skills.Size = new System.Drawing.Size(248, 194);
            this.gb_Skills.TabIndex = 1;
            this.gb_Skills.TabStop = false;
            this.gb_Skills.Text = "Skills";
            // 
            // cb_SkillPotion
            // 
            this.cb_SkillPotion.AutoSize = true;
            this.cb_SkillPotion.Location = new System.Drawing.Point(6, 171);
            this.cb_SkillPotion.Name = "cb_SkillPotion";
            this.cb_SkillPotion.Size = new System.Drawing.Size(56, 17);
            this.cb_SkillPotion.TabIndex = 6;
            this.cb_SkillPotion.Text = "Potion";
            this.cb_SkillPotion.UseVisualStyleBackColor = true;
            this.cb_SkillPotion.CheckedChanged += new System.EventHandler(this.cb_SkillPotion_CheckedChanged);
            // 
            // cb_Skill6
            // 
            this.cb_Skill6.AutoSize = true;
            this.cb_Skill6.Location = new System.Drawing.Point(6, 135);
            this.cb_Skill6.Name = "cb_Skill6";
            this.cb_Skill6.Size = new System.Drawing.Size(62, 17);
            this.cb_Skill6.TabIndex = 5;
            this.cb_Skill6.Text = "No Skill";
            this.cb_Skill6.UseVisualStyleBackColor = true;
            this.cb_Skill6.CheckedChanged += new System.EventHandler(this.cb_Skill6_CheckedChanged);
            // 
            // cb_Skill5
            // 
            this.cb_Skill5.AutoSize = true;
            this.cb_Skill5.Location = new System.Drawing.Point(6, 112);
            this.cb_Skill5.Name = "cb_Skill5";
            this.cb_Skill5.Size = new System.Drawing.Size(62, 17);
            this.cb_Skill5.TabIndex = 4;
            this.cb_Skill5.Text = "No Skill";
            this.cb_Skill5.UseVisualStyleBackColor = true;
            this.cb_Skill5.CheckedChanged += new System.EventHandler(this.cb_Skill5_CheckedChanged);
            // 
            // cb_Skill4
            // 
            this.cb_Skill4.AutoSize = true;
            this.cb_Skill4.Location = new System.Drawing.Point(6, 89);
            this.cb_Skill4.Name = "cb_Skill4";
            this.cb_Skill4.Size = new System.Drawing.Size(62, 17);
            this.cb_Skill4.TabIndex = 3;
            this.cb_Skill4.Text = "No Skill";
            this.cb_Skill4.UseVisualStyleBackColor = true;
            this.cb_Skill4.CheckedChanged += new System.EventHandler(this.cb_Skill4_CheckedChanged);
            // 
            // cb_Skill3
            // 
            this.cb_Skill3.AutoSize = true;
            this.cb_Skill3.Location = new System.Drawing.Point(6, 66);
            this.cb_Skill3.Name = "cb_Skill3";
            this.cb_Skill3.Size = new System.Drawing.Size(62, 17);
            this.cb_Skill3.TabIndex = 2;
            this.cb_Skill3.Text = "No Skill";
            this.cb_Skill3.UseVisualStyleBackColor = true;
            this.cb_Skill3.CheckedChanged += new System.EventHandler(this.cb_Skill3_CheckedChanged);
            // 
            // cb_Skill2
            // 
            this.cb_Skill2.AutoSize = true;
            this.cb_Skill2.Location = new System.Drawing.Point(6, 43);
            this.cb_Skill2.Name = "cb_Skill2";
            this.cb_Skill2.Size = new System.Drawing.Size(62, 17);
            this.cb_Skill2.TabIndex = 1;
            this.cb_Skill2.Text = "No Skill";
            this.cb_Skill2.UseVisualStyleBackColor = true;
            this.cb_Skill2.CheckedChanged += new System.EventHandler(this.cb_Skill2_CheckedChanged);
            // 
            // cb_Skill1
            // 
            this.cb_Skill1.AutoSize = true;
            this.cb_Skill1.Location = new System.Drawing.Point(7, 20);
            this.cb_Skill1.Name = "cb_Skill1";
            this.cb_Skill1.Size = new System.Drawing.Size(62, 17);
            this.cb_Skill1.TabIndex = 0;
            this.cb_Skill1.Text = "No Skill";
            this.cb_Skill1.UseVisualStyleBackColor = true;
            this.cb_Skill1.CheckedChanged += new System.EventHandler(this.cb_Skill1_CheckedChanged);
            // 
            // gb_Rift
            // 
            this.gb_Rift.Controls.Add(this.cb_EmpowerGR);
            this.gb_Rift.Controls.Add(this.rb_AutoOpenDisabled);
            this.gb_Rift.Controls.Add(this.cb_AutoAcceptRifts);
            this.gb_Rift.Controls.Add(this.cb_CloseRiftDialogs);
            this.gb_Rift.Controls.Add(this.rb_OpenGR);
            this.gb_Rift.Controls.Add(this.rb_OpenRift);
            this.gb_Rift.Location = new System.Drawing.Point(266, 12);
            this.gb_Rift.Name = "gb_Rift";
            this.gb_Rift.Size = new System.Drawing.Size(123, 175);
            this.gb_Rift.TabIndex = 2;
            this.gb_Rift.TabStop = false;
            this.gb_Rift.Text = "Rift";
            // 
            // cb_EmpowerGR
            // 
            this.cb_EmpowerGR.AutoSize = true;
            this.cb_EmpowerGR.Location = new System.Drawing.Point(9, 88);
            this.cb_EmpowerGR.Name = "cb_EmpowerGR";
            this.cb_EmpowerGR.Size = new System.Drawing.Size(89, 17);
            this.cb_EmpowerGR.TabIndex = 8;
            this.cb_EmpowerGR.Text = "Empower GR";
            this.cb_EmpowerGR.UseVisualStyleBackColor = true;
            this.cb_EmpowerGR.CheckedChanged += new System.EventHandler(this.cb_EmpowerGR_CheckedChanged);
            // 
            // rb_AutoOpenDisabled
            // 
            this.rb_AutoOpenDisabled.AutoSize = true;
            this.rb_AutoOpenDisabled.Checked = true;
            this.rb_AutoOpenDisabled.Location = new System.Drawing.Point(9, 19);
            this.rb_AutoOpenDisabled.Name = "rb_AutoOpenDisabled";
            this.rb_AutoOpenDisabled.Size = new System.Drawing.Size(93, 17);
            this.rb_AutoOpenDisabled.TabIndex = 7;
            this.rb_AutoOpenDisabled.TabStop = true;
            this.rb_AutoOpenDisabled.Text = "No Auto Open";
            this.rb_AutoOpenDisabled.UseVisualStyleBackColor = true;
            this.rb_AutoOpenDisabled.CheckedChanged += new System.EventHandler(this.rb_AutoOpenDisabled_CheckedChanged);
            // 
            // cb_AutoAcceptRifts
            // 
            this.cb_AutoAcceptRifts.AutoSize = true;
            this.cb_AutoAcceptRifts.Location = new System.Drawing.Point(9, 149);
            this.cb_AutoAcceptRifts.Name = "cb_AutoAcceptRifts";
            this.cb_AutoAcceptRifts.Size = new System.Drawing.Size(109, 17);
            this.cb_AutoAcceptRifts.TabIndex = 6;
            this.cb_AutoAcceptRifts.Text = "Auto Accept Rifts";
            this.cb_AutoAcceptRifts.UseVisualStyleBackColor = true;
            this.cb_AutoAcceptRifts.CheckedChanged += new System.EventHandler(this.cb_AutoAcceptRifts_CheckedChanged);
            // 
            // cb_CloseRiftDialogs
            // 
            this.cb_CloseRiftDialogs.AutoSize = true;
            this.cb_CloseRiftDialogs.Location = new System.Drawing.Point(9, 126);
            this.cb_CloseRiftDialogs.Name = "cb_CloseRiftDialogs";
            this.cb_CloseRiftDialogs.Size = new System.Drawing.Size(109, 17);
            this.cb_CloseRiftDialogs.TabIndex = 5;
            this.cb_CloseRiftDialogs.Text = "Close Rift Dialogs";
            this.cb_CloseRiftDialogs.UseVisualStyleBackColor = true;
            this.cb_CloseRiftDialogs.CheckedChanged += new System.EventHandler(this.cb_CloseRiftDialogs_CheckedChanged);
            // 
            // rb_OpenGR
            // 
            this.rb_OpenGR.AutoSize = true;
            this.rb_OpenGR.Location = new System.Drawing.Point(9, 65);
            this.rb_OpenGR.Name = "rb_OpenGR";
            this.rb_OpenGR.Size = new System.Drawing.Size(95, 17);
            this.rb_OpenGR.TabIndex = 4;
            this.rb_OpenGR.Text = "Auto Open GR";
            this.rb_OpenGR.UseVisualStyleBackColor = true;
            this.rb_OpenGR.CheckedChanged += new System.EventHandler(this.rb_OpenGR_CheckedChanged);
            // 
            // rb_OpenRift
            // 
            this.rb_OpenRift.AutoSize = true;
            this.rb_OpenRift.Location = new System.Drawing.Point(9, 42);
            this.rb_OpenRift.Name = "rb_OpenRift";
            this.rb_OpenRift.Size = new System.Drawing.Size(95, 17);
            this.rb_OpenRift.TabIndex = 3;
            this.rb_OpenRift.Text = "Auto Open Rift";
            this.rb_OpenRift.UseVisualStyleBackColor = true;
            this.rb_OpenRift.CheckedChanged += new System.EventHandler(this.rb_OpenRift_CheckedChanged);
            // 
            // gb_Menu
            // 
            this.gb_Menu.Controls.Add(this.cb_AutoStartGame);
            this.gb_Menu.Location = new System.Drawing.Point(266, 193);
            this.gb_Menu.Name = "gb_Menu";
            this.gb_Menu.Size = new System.Drawing.Size(123, 73);
            this.gb_Menu.TabIndex = 9;
            this.gb_Menu.TabStop = false;
            this.gb_Menu.Text = "Menu";
            // 
            // cb_AutoStartGame
            // 
            this.cb_AutoStartGame.AutoSize = true;
            this.cb_AutoStartGame.Location = new System.Drawing.Point(9, 19);
            this.cb_AutoStartGame.Name = "cb_AutoStartGame";
            this.cb_AutoStartGame.Size = new System.Drawing.Size(104, 17);
            this.cb_AutoStartGame.TabIndex = 6;
            this.cb_AutoStartGame.Text = "Auto Start Game";
            this.cb_AutoStartGame.UseVisualStyleBackColor = true;
            this.cb_AutoStartGame.CheckedChanged += new System.EventHandler(this.cb_AutoStartGame_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 449);
            this.Controls.Add(this.gb_Menu);
            this.Controls.Add(this.gb_Rift);
            this.Controls.Add(this.gb_Skills);
            this.Controls.Add(this.gb_Town);
            this.Name = "MainWindow";
            this.Text = "TLHelper";
            this.gb_Town.ResumeLayout(false);
            this.gb_Town.PerformLayout();
            this.gb_Skills.ResumeLayout(false);
            this.gb_Skills.PerformLayout();
            this.gb_Rift.ResumeLayout(false);
            this.gb_Rift.PerformLayout();
            this.gb_Menu.ResumeLayout(false);
            this.gb_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Town;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_KadalaItem;
        private System.Windows.Forms.GroupBox gb_Skills;
        private System.Windows.Forms.CheckBox cb_SkillPotion;
        private System.Windows.Forms.CheckBox cb_Skill6;
        private System.Windows.Forms.CheckBox cb_Skill5;
        private System.Windows.Forms.CheckBox cb_Skill4;
        private System.Windows.Forms.CheckBox cb_Skill3;
        private System.Windows.Forms.CheckBox cb_Skill2;
        private System.Windows.Forms.CheckBox cb_Skill1;
        private System.Windows.Forms.GroupBox gb_Rift;
        private System.Windows.Forms.CheckBox cb_AutoAcceptRifts;
        private System.Windows.Forms.CheckBox cb_CloseRiftDialogs;
        private System.Windows.Forms.RadioButton rb_OpenGR;
        private System.Windows.Forms.RadioButton rb_OpenRift;
        private System.Windows.Forms.RadioButton rb_AutoOpenDisabled;
        private System.Windows.Forms.CheckBox cb_EmpowerGR;
        private System.Windows.Forms.GroupBox gb_Menu;
        private System.Windows.Forms.CheckBox cb_AutoStartGame;
    }
}

