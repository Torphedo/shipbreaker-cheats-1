
using BepInEx;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [BepInPlugin("Torphedo.Shipbreaker.Cheats", "Cheats and debug options Shipbreaker", "1.0.0.0")]
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