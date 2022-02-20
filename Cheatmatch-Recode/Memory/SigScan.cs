using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using static Colorful.Console;

namespace Cheatmatch_Recode.Memory
{
    internal static class SigScan
    {
        private const string ProcName = "Redmatch 2";
        private const string ModuleName = "GameAssembly.dll";
        
        public static async Task ScanSig(Sig sig)
        {
            try
            {
                Utils.Log.SendLog("Finding " + sig.Name + "...", Color.Green);
                var aoBScanResults = await Memory.Mem.AoBScan(GetBase(), GetLast(), sig.Signature);
                var bScanResults = aoBScanResults as long[] ?? aoBScanResults.ToArray();
                var mathedResult = bScanResults.FirstOrDefault() - GetBase();
                var firstAoBScanResultwithoutmc = mathedResult.ToString("X2");
                var firstAoBScanResult = ModuleName + "+" + firstAoBScanResultwithoutmc;
                switch (bScanResults.Count())
                {
                    case 0:
                        Utils.Log.SendLog(sig.Name + " not found.", Color.Red);
                        sig.Address = "NotFound";
                        break;
                    default:
                        Utils.Log.SendLog(sig.Name + " found!", Color.Green);
                        sig.Address = firstAoBScanResult;
                        break;
                }
            }
            catch
            {
                WriteLine("Error occured scanning sigs", Color.Red);
            }
        }
        
        private static long GetBase()
        {
            try
            {
                var processModule = Process.GetProcessesByName(ProcName)[0].Modules[2];
                if (!processModule.ModuleName.Contains("GameAssembly"))
                {

                    foreach (ProcessModule procModule in Process.GetProcessesByName(ProcName)[0].Modules)
                    {
                        if (procModule.ModuleName.ToLower().Contains("gameassembly"))
                        {
                            processModule = procModule;
                        }
                    }
                }

                return (long)processModule.BaseAddress;
            }
            catch
            {
                Utils.Log.SendLog("Error occured getting module base for help", Color.Red);
            }

            return 0;
        }
        
        private static long GetLast()
        {
            try
            {
                var processModule = Process.GetProcessesByName(ProcName)[0].Modules[2];
                if (!processModule.ModuleName.Contains("GameAssembly"))
                {

                    foreach (ProcessModule procModule in Process.GetProcessesByName(ProcName)[0].Modules)
                    {
                        if (procModule.ModuleName.ToLower().Contains("gameassembly"))
                        {
                            processModule = procModule;
                        }
                    }
                }

                return (long)processModule.BaseAddress + processModule.ModuleMemorySize;
            }
            catch
            {
                Utils.Log.SendLog("Error occured getting module base for help", Color.Red);
            }

            return 0;
        }
    }
}
