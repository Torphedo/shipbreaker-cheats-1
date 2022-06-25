
using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(PlayableArea), "GetPlayableAreaState")]
    public static class PlayableAreaGetPlayableAreaState
    {
        public static bool Prefix(ref PlayableArea.PlayableAreaState __result)
        {
            // Always tell the game the player is in a safe zone
            __result = PlayableArea.PlayableAreaState.Safe;
            return false;
        }
    }
}
