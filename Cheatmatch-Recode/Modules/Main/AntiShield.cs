using System.Drawing;
using System.Windows.Forms;

namespace Cheatmatch_Recode.Modules.Main
{
    internal static class AntiShield
    {
        public static void Enable(Control control)
        {
            var module = control as Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox;

            switch (module != null && module.Checked)
            {
                case true:
                    Memory.Instructions.WriteBytes(Memory.Sdk.AntiShieldGun, "F6 87 F4 00 00 00 00");
                    Memory.Instructions.WriteBytes(Memory.Sdk.AntiShieldPunch, "F6 87 F4 00 00 00 00");
                    Utils.Log.SendLog(module.Text + " was Enabled!", Color.DodgerBlue);
                    break;
                case false:
                    Memory.Instructions.RestoreBytes(Memory.Sdk.AntiShieldGun);
                    Memory.Instructions.RestoreBytes(Memory.Sdk.AntiShieldPunch);
                    Utils.Log.SendLog(module.Text + " was Disabled!", Color.DodgerBlue);
                    break;
            }
        }
    }
}