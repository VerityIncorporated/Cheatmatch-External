using System.Drawing;
using System.Windows.Forms;

namespace Cheatmatch_Recode.Modules.Misc
{
    internal static class FreezePlayers
    {
        public static void Enable(Control control)
        {
            var module = control as Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox;

            switch (module != null && module.Checked)
            {
                case true:
                    Memory.Instructions.ReturnBytes(Memory.Sdk.FreezePlayers);
                    Utils.Log.SendLog(module.Text + " was Enabled!", Color.DodgerBlue);
                    break;
                case false:
                    Memory.Instructions.RestoreBytes(Memory.Sdk.FreezePlayers);
                    Utils.Log.SendLog(module.Text + " was Disabled!", Color.DodgerBlue);
                    break;
            }
        }
    }
}