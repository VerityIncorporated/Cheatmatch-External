using Cheatmatch_Recode.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using Cheatmatch_Recode.Memory;
using static System.Console;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Cheatmatch_Recode
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            CursorVisible = false;


            Title = @"Cheatmatch Recoded | Developed by Verity#0001";
            Utils.Log.SendLog("Welcome " + Environment.UserName, Color.DodgerBlue);
            findProc:
            var process = Process.GetProcessesByName("RedMatch 2");
            if(process.Length == 0)
            {
                Clear();
                Utils.Log.SendLog("Welcome " + Environment.UserName, Color.DodgerBlue);
                Utils.Log.SendLog("Redmatch 2 isn't running!", Color.DodgerBlue);
                Thread.Sleep(2000);
                goto findProc;
            }

            Memory.Memory.Mem.OpenProcess(process[0].ProcessName);

            Scan();

            RunGUI();
        }

        private static async Task Scan()
        {
            Utils.Log.SendLog("Loading modules, please wait.", Color.DodgerBlue);
            await SigScan.ScanSig(Sdk.GodMode);
            await SigScan.ScanSig(Sdk.NoSpread);
            await SigScan.ScanSig(Sdk.UnlimitedAmmo);
            await SigScan.ScanSig(Sdk.NoSlowDown);
            await SigScan.ScanSig(Sdk.FreezePlayers);
            await SigScan.ScanSig(Sdk.FreezePlayersAndTp);
            await SigScan.ScanSig(Sdk.AntiShieldGun);
            await SigScan.ScanSig(Sdk.AntiShieldPunch);
            await SigScan.ScanSig(Sdk.FreezePlayersAndTp);
            await SigScan.ScanSig(Sdk.AntiShieldGun);
            await SigScan.ScanSig(Sdk.AntiShieldPunch);
            await SigScan.ScanSig(Sdk.Melee);
            await SigScan.ScanSig(Sdk.MeleeStress);
            await SigScan.ScanSig(Sdk.MeleeAnimation);
        }

        private static void RunGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}