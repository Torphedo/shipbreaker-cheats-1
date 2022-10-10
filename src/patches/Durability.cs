using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(ToolDurabilityAsset.ToolDurabilityData), "DrainMultiplier", MethodType.Getter)]
    public static class Durability
    {
        public static bool Prefix(ref float __result)
        {
            if (CheatSettings.InfiniteDurability)
            {
                __result = 0f;
                return false;
            }

            return true;
        }
    }
}
