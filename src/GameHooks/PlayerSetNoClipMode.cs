
using BBI.Unity.Game;
using UnityEngine;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(Player), "SetNoClipMode")]
    public static class PlayerSetNoClipMode
    {
        public static bool Prefix(Collider collider, PlayerMotion playerMotion, bool enabled)
        {
            if (CheatSettings.NoClipEnabled)
            {
                if (collider != null)
                {
                    collider.isTrigger = CheatSettings.NoClipEnabled;
                }
                if (playerMotion != null)
                {
                    playerMotion.SetSquishyCollide(!CheatSettings.NoClipEnabled);
                }
                return false;
            }
            return true;
        }
    }
}
