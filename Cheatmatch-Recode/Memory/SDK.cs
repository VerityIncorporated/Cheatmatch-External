namespace Cheatmatch_Recode.Memory
{
    internal static class Sdk
    {
        public static readonly Sig GodMode = new Sig
        {
            Name = "GodMode", 
            Signature = "40 ? 57 48 83 EC ? 80 3D 43 8B 09 01", 
            Bytes = "40 53"
        };
        
        public static readonly Sig NoSpread = new Sig
        {
            Name = "NoSpread", 
            Signature = "F3 0F ? ? ? ? ? ? 33 D2 48 8D ? ? ? ? ? E8", 
            Bytes = "F3 0F 10 B7 50 01 00 00"
        };
        
        public static readonly Sig UnlimitedAmmo = new Sig
        {
            Name = "UnlimitedAmmo",
            Signature = "E8 ? ? ? ? 48 8B ? ? ? ? ? 0F 28 ? ? ? ? ? 0F 28 ? ? ? ? ? 44 0F ? ? ? ? ? ? 44 0F ? ? ? ? ? ? 44 0F ? ? ? ? ? ? 48 8D ? ? ? ? ? 41 ? 41 ? 41 ? 41 ? 5F 5E 5D C3 E8 ? ? ? ? CC", 
            Bytes = "E8 14 D3 FF FF"
        };
        
        public static readonly Sig NoSlowDown = new Sig
        {
            Name = "NoSlowDown", 
            Signature = "80 BF 4C 01 00 00 ? 74",
            Bytes = "80 BF 4C 01 00 00 00"
        };

        public static readonly Sig AntiShieldGun = new Sig
        {
            Name = "AntiShieldGun",
            Signature = "80 BF F4 00 00 00 ? 0F 85",
            Bytes = "80 BF F4 00 00 00 00"
        };

        public static readonly Sig AntiShieldPunch = new Sig
        {
            Name = "AntiShieldPunch",
            Signature = "80 BF F4 00 00 00 ? 48 89",
            Bytes = "80 BF F4 00 00 00 00"
        };

        public static readonly Sig Melee = new Sig
        {
            Name = "Melee",
            Signature = "C6 87 4B 01 00 00",
            Bytes = "C6 87 4B 01 00 00 01"
        };


        public static readonly Sig MeleeStress = new Sig
        {
            Name = "MeleeStress",
            Signature = "E8 ? ? ? ? F3 0F ? ? ? ? ? ? 45 33 ? 48 8B ? ? ? ? ? 48 8B ? E8 ? ? ? ? 48 8B",
            Bytes = "E8 6C A1 0D 00"
        };


        public static readonly Sig MeleeAnimation = new Sig
        {
            Name = "MeleeAnimation",
            Signature = "E8 ? ? ? ? 48 85 ? 74 ? 33 D2 48 8B ? E8 ? ? ? ? 48 8B ? ? ? ? ? 84 C0",
            Bytes = "E8 7A 62 F9 00"
        };

        public static readonly Sig FreezePlayers = new Sig
        {
            Name = "FreezePlayers", 
            Signature = "48 89 ? ? ? 55 48 8D ? ? ? 48 81 EC ? ? ? ? 80 3D F7 DA 08 01",
            Bytes = "48 89 5C 24 20"
        };
        
        public static readonly Sig FreezePlayersAndTp = new Sig
        {
            Name = "FreezePlayersAndTP", 
            Signature = "E8 ? ? ? ? 4C 8B ? ? ? ? ? ? 48 85 ? 0F 84 ? ? ? ? F2 0F ? ? 48 8D ? ? 8B 40 ? 45 33 ? 48 8B ? F2 0F ? ? ? 89 45 ? E8 ? ? ? ? 44 0F ? ? ? ? 44 0F",
            Bytes = "E8 1E 63 55 00"
        };
        
        public static readonly Pointer X = new Pointer()
        {
            Name = "X",
            Address = "UnityPlayer.dll+0195C740,30,58,0,0,88,18",
            DefaultValue = "0"
        };

        public static readonly Pointer Y = new Pointer()
        {
            Name = "Y",
            Address = "UnityPlayer.dll+0195C740,30,58,0,0,88,14",
            DefaultValue = "0"
        };

        public static readonly Pointer Z = new Pointer()
        {
            Name = "Z",
            Address = "UnityPlayer.dll+0195C740,30,58,0,0,88,10",
            DefaultValue = "0"
        };
    }
}