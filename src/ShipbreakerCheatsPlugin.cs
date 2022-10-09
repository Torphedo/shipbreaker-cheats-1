using BepInEx;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [BepInPlugin("Torphedo.Shipbreaker.Cheats", "A mod for Shipbreaker to enable cheats and debug options", "1.1.0")]
    public class CheatsPlugin : BaseUnityPlugin
    {
        void Awake()
        {
            this.ApplyPatches();
        }

        private void ApplyPatches()
        {
            var harmony = new Harmony("Torphedo.Shipbreaker.Cheats");
            harmony.PatchAll();
        }
    }
}