using System.Drawing;
using System.Windows.Forms;

namespace Cheatmatch_Recode.Modules.Main
{
    internal static class NoSpread
    {
        public static void Enable(Control control)
        {
            var module = control as Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox;

            switch (module != null && module.Checked)
            {
                case true:
                    Memory.Instructions.NopBytes(Memory.Sdk.NoSpread);
                    Utils.Log.SendLog(module.Text + " was Enabled!", Color.DodgerBlue);
                    break;
                case false:
                    Memory.Instructions.RestoreBytes(Memory.Sdk.NoSpread);
                    Utils.Log.SendLog(module.Text + " was Disabled!", Color.DodgerBlue);
                    break;
            }
        }
    }
}