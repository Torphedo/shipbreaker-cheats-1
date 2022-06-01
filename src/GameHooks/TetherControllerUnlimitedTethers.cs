
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(TetherController), "UnlimitedTethers", MethodType.Getter)]
    public static class TetherControllerUnlimitedTethers
    {
        public static bool Prefix(ref bool __result)
        {
            if (CheatSettings.UnlimitedTethersEnabled)
            {
                __result = true;
                return false;
            }

            return true;
        }
    }
}
