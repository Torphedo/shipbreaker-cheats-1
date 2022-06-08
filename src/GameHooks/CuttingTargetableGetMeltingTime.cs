
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(CuttingTargetable), "GetMeltingTime")]
    public static class CuttingTargetableGetMeltingTIme
    {
        public static bool Prefix(ref float __result)
        {
            var meltTimeOverride = CheatSettings.StingerMeltTime;

            if (meltTimeOverride >= 0)
            {
                __result = meltTimeOverride;
                return false;
            }

            return true;
        }
    }
}
