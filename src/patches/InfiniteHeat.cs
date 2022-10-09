using BBI.Unity.Game;
using Carbon.Core;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(CuttingToolController), "AddHeat")]
    public static class InfiniteHeat
    {
        public static bool Prefix()
        {
            if (GlobalOptions.Raw.GetBool("General.NoCutterHeat", false) && CheatSettings.CheatsEnabled)
            {
                // Skip AddHeat() function if enabled
                return false;
            }

            return true;
        }
    }
}
