using System.Drawing;
using System.Windows.Forms;

namespace Cheatmatch_Recode.Modules.Main
{
    internal static class FastMelee
    {
        public static void Enable(Control control)
        {
            var module = control as Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox;

            switch (module != null && module.Checked)
            {
                case true:
                    Memory.Instructions.WriteBytes(Memory.Sdk.Melee, "C6 87 4B 01 00 00 00");
                    Memory.Instructions.NopBytes(Memory.Sdk.MeleeStress);
                    Memory.Instructions.NopBytes(Memory.Sdk.MeleeAnimation);
                    Utils.Log.SendLog(module.Text + " was Enabled!", Color.DodgerBlue);
                    break;
                case false:
                    Memory.Instructions.RestoreBytes(Memory.Sdk.Melee);
                    Memory.Instructions.RestoreBytes(Memory.Sdk.MeleeStress);
                    Memory.Instructions.RestoreBytes(Memory.Sdk.MeleeAnimation);
                    Utils.Log.SendLog(module.Text + " was Disabled!", Color.DodgerBlue);
                    break;
            }
        }
    }
}