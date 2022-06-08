
using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(ToolDurabilityAsset.ToolDurabilityData), "DrainMultiplier", MethodType.Getter)]
    public static class ToolDurabilityDrainMultiplier
    {
        public static bool Prefix(ref float __result)
        {
            if (CheatSettings.InfiniteDurability)
            {
                __result = 0;
                return false;
            }

            return true;
        }
    }
}
