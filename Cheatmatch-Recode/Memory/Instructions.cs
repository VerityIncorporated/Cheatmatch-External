namespace Cheatmatch_Recode.Memory
{
    internal static class Instructions
    {
        public static void NopBytes(Sig sig)
        {
            var noppedbytes = "";
            foreach(var ch in sig.Bytes)
            {
                if(char.IsWhiteSpace(ch))
                {
                    noppedbytes += "90 ";
                }
            }
            noppedbytes += "90";
            Memory.Mem.WriteMemory(sig.Address, "bytes", noppedbytes);
        }
        
        public static void ReturnBytes(Sig sig)
        {
            var retedbytes = "";
            var index = 0;
            foreach(var ch in sig.Bytes)
            {
                if (!char.IsWhiteSpace(ch)) continue;
                if (index == 0)
                {
                    retedbytes += "C3 ";
                }
                else
                {
                    retedbytes += "90 ";
                }
                index++;
            }
            retedbytes += "90";
            Memory.Mem.WriteMemory(sig.Address, "bytes", retedbytes);
        }
        
        public static void RestoreBytes(Sig sig)
        {
            Memory.Mem.WriteMemory(sig.Address, "bytes", sig.Bytes);
        }

        public static void WriteBytes(Sig sig, string bytes)
        {
            Memory.Mem.WriteMemory(sig.Address, "bytes", bytes);
        }
    }
}