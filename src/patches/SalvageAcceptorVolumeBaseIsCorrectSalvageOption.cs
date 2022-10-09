using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(SalvageAcceptorVolumeBase), "IsCorrectSalvageOption")]
    public static class SalvageAcceptorVolumeBaseIsCorrectSalvageOption
    {
        public static bool Prefix(ref bool __result)
        {
            if (CheatSettings.AlwaysAcceptSalvage)
            {
                __result = true;
                return false;
            }
            return true;
        }
    }
}
