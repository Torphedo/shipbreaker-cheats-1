
using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(CuttingToolController), "AddHeat")]
    public static class CuttingToolControllerAddHeat
    {
        public static bool Prefix()
        {
            if (CheatSettings.InfiniteHeat)
            {
                return false;
            }

            return true;
        }
    }
}
