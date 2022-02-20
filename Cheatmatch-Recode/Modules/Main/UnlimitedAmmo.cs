using System.Drawing;
using System.Windows.Forms;

namespace Cheatmatch_Recode.Modules.Main
{
    internal static class UnlimitedAmmo
    {
        public static void Enable(Control control)
        {
            var module = control as Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox;

            switch (module != null && module.Checked)
            {
                case true:
                    Memory.Instructions.WriteBytes(Memory.Sdk.UnlimitedAmmo, "E8 14 1E 00 00");
                    Utils.Log.SendLog(module.Text + " was Enabled!", Color.DodgerBlue);
                    break;
                case false:
                    Memory.Instructions.RestoreBytes(Memory.Sdk.UnlimitedAmmo);
                    Utils.Log.SendLog(module.Text + " was Disabled!", Color.DodgerBlue);
                    break;
            }
        }
    }
}