// VikingrStorage
// a Valheim mod skeleton using J�tunn
// 
// File:    VikingrStorage.cs
// Project: VikingrStorage

using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;

namespace VikingrStorage
{
    [BepInPlugin("org.bepinex.plugins.vikingr_storage", "Vikingr Storage", version)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class VikingrStoragePlugin : BaseUnityPlugin
    {
        public const string version = "0.0.1";
        
        // Use this class to add your own localization to the game
        // https://valheim-modding.github.io/Jotunn/tutorials/localization.html
        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private void Awake()
        {
            // Jotunn comes with MonoMod Detours enabled for hooking Valheim's code
            // https://github.com/MonoMod/MonoMod
            On.FejdStartup.Awake += FejdStartup_Awake;
            
            // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
            Jotunn.Logger.LogInfo("VikingrStorage has landed");
            
            // To learn more about Jotunn's features, go to
            // https://valheim-modding.github.io/Jotunn/tutorials/overview.html
        }

        private void FejdStartup_Awake(On.FejdStartup.orig_Awake orig, FejdStartup self)
        {
            // This code runs before Valheim's FejdStartup.Awake
            Jotunn.Logger.LogInfo("FejdStartup is going to awake");

            // Call this method so the original game method is invoked
            orig(self);

            // This code runs after Valheim's FejdStartup.Awake
            Jotunn.Logger.LogInfo("FejdStartup has awoken");
        }
    }
}

