using System;
using System.Windows.Forms;

namespace Cheatmatch_Recode.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            godmodeCheckBox.CheckedChanged += modulesCheckBox_CheckedChanged;
            unlimitedammoCheckBox.CheckedChanged += modulesCheckBox_CheckedChanged;
            nospreadCheckBox.CheckedChanged += modulesCheckBox_CheckedChanged;
            antishieldCheckBox.CheckedChanged += modulesCheckBox_CheckedChanged;
            fastmeleeCheckBox.CheckedChanged += modulesCheckBox_CheckedChanged;
            noslowdownCheckBox.CheckedChanged += modulesCheckBox_CheckedChanged;
            freezeplayersCheckBox.CheckedChanged += modulesCheckBox_CheckedChanged;
            freezeplayersandtpCheckBox.CheckedChanged += modulesCheckBox_CheckedChanged;
        }
        
        private void modulesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var module = sender as Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox;

            if (module == null) return;
            switch (module.Name)
            {
                case "godmodeCheckBox":
                    Modules.Main.Godmode.Enable(module);
                    break;
                case "unlimitedammoCheckBox":
                    Modules.Main.UnlimitedAmmo.Enable(module);
                    break;
                case "nospreadCheckBox":
                    Modules.Main.NoSpread.Enable(module);
                    break;
                case "antishieldCheckBox":
                    Modules.Main.AntiShield.Enable(module);
                    break;
                case "fastmeleeCheckBox":
                    Modules.Main.FastMelee.Enable(module);
                    break;
                case "noslowdownCheckBox":
                    Modules.Misc.NoSlowDown.Enable(module);
                    break;
                case "freezeplayersCheckBox":
                    Modules.Misc.FreezePlayers.Enable(module);
                    break;
                case "freezeplayersandtpCheckBox":
                    Modules.Misc.FreezePlayersAndTp.Enable(module);
                    break;
            }
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}