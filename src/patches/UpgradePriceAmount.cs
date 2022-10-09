using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(UpgradePrice), "Amount", MethodType.Getter)]
    public static class UpgradePriceAmount
    {
        public static bool Prefix(ref int __result)
        {
            if (CheatSettings.FreeUpgradesEnabled)
            {
                __result = 0;
                return false;
            }

            return true;
        }
    }
}
