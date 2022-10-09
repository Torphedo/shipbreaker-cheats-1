using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(CuttingTargetable), "GetMeltingTime")]
    public static class CuttingTargetableGetMeltingTIme
    {
        public static bool Prefix(ref float __result)
        {
            if (CheatSettings.StingerMeltTime >= 0)
            {
                // Cheat enabled, use custom melt time
                __result = CheatSettings.StingerMeltTime;
                return false;
            }
            // Cheat disabled, use original game logic
            return true;
        }
    }
}
