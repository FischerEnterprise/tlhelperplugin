using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using Turbo.Plugins;

using Turbo.Plugins.TL.Helper.Data.Kadala;

namespace Turbo.Plugins.TL.Helper.UI {

    public partial class MainWindow : Form {

        private static MainWindow Instance = null;
        public static MainWindow GetInstance() {
            return Instance;
        }

        public Dictionary<string, string> Settings = new Dictionary<string, string>();

        public MainWindow(string settings) {
            Settings.Add("kadala_item", "Phylactery");
            Settings.Add("auto_potion", "enabled");
            Settings.Add("skill_lmb", "disabled");
            Settings.Add("skill_rmb", "disabled");
            Settings.Add("skill_1", "disabled");
            Settings.Add("skill_2", "disabled");
            Settings.Add("skill_3", "disabled");
            Settings.Add("skill_4", "disabled");
            Settings.Add("auto_open_rift", "disabled");
            Settings.Add("auto_empower_gr", "disabled");
            Settings.Add("close_rift_dialogs", "disabled");
            Settings.Add("auto_accept_rift", "disabled");
            Settings.Add("auto_start_game", "disabled");

            InitializeComponent();
            
            this.cb_KadalaItem.DataSource = new BindingList<string>(KadalaItems.GetNames());
            this.cb_KadalaItem.SelectedIndex = this.cb_KadalaItem.FindString("Phylactery");

            this.cb_Skill1.Checked = false;
            this.cb_Skill2.Checked = false;
            this.cb_Skill3.Checked = false;
            this.cb_Skill4.Checked = false;
            this.cb_Skill5.Checked = false;
            this.cb_Skill6.Checked = false;

            this.cb_SkillPotion.Checked = true;

            MainWindow.Instance = this;
        }

        public void UpdateSkills(string[] skills) {
            this.cb_Skill1.Text = skills[0];
            this.cb_Skill2.Text = skills[1];
            this.cb_Skill3.Text = skills[2];
            this.cb_Skill4.Text = skills[3];
            this.cb_Skill5.Text = skills[4];
            this.cb_Skill6.Text = skills[5];
        }

        private void cb_KadalaItem_SelectedIndexChanged(object sender, EventArgs e) {
            Settings["kadala_item"] = cb_KadalaItem.SelectedItem.ToString();
        }

        private void cb_Skill1_CheckedChanged(object sender, EventArgs e)
        {
            Settings["skill_lmb"] = this.cb_Skill1.Checked ? "enabled" : "disabled";
        }

        private void cb_Skill2_CheckedChanged(object sender, EventArgs e)
        {
            Settings["skill_rmb"] = this.cb_Skill2.Checked ? "enabled" : "disabled";
        }

        private void cb_Skill3_CheckedChanged(object sender, EventArgs e)
        {
            Settings["skill_1"] = this.cb_Skill3.Checked ? "enabled" : "disabled";
        }

        private void cb_Skill4_CheckedChanged(object sender, EventArgs e)
        {
            Settings["skill_2"] = this.cb_Skill4.Checked ? "enabled" : "disabled";
        }

        private void cb_Skill5_CheckedChanged(object sender, EventArgs e)
        {
            Settings["skill_3"] = this.cb_Skill5.Checked ? "enabled" : "disabled";
        }

        private void cb_Skill6_CheckedChanged(object sender, EventArgs e)
        {
            Settings["skill_4"] = this.cb_Skill6.Checked ? "enabled" : "disabled";
        }

        private void cb_SkillPotion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_SkillPotion.Checked) Settings["auto_potion"] = "enabled";
            else Settings["auto_potion"] = "disabled";
        }

        private void rb_AutoOpenDisabled_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_AutoOpenDisabled.Checked) Settings["auto_open_rift"] = "disabled";
        }

        private void rb_OpenRift_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_OpenRift.Checked) Settings["auto_open_rift"] = "rift";
        }

        private void rb_OpenGR_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_OpenGR.Checked) Settings["auto_open_rift"] = "gr";
        }

        private void cb_CloseRiftDialogs_CheckedChanged(object sender, EventArgs e)
        {
            Settings["close_rift_dialogs"] = this.cb_CloseRiftDialogs.Checked ? "enabled" : "disabled";
        }

        private void cb_AutoAcceptRifts_CheckedChanged(object sender, EventArgs e)
        {
            Settings["auto_accept_rift"] = this.cb_AutoAcceptRifts.Checked ? "enabled" : "disabled";
        }

        private void cb_EmpowerGR_CheckedChanged(object sender, EventArgs e)
        {
            Settings["auto_empower_gr"] = this.cb_EmpowerGR.Checked ? "enabled" : "disabled";
        }

        private void cb_AutoStartGame_CheckedChanged(object sender, EventArgs e)
        {
            Settings["auto_start_game"] = this.cb_AutoStartGame.Checked ? "enabled" : "disabled";
        }

    }

}