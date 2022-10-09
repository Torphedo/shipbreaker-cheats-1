using BBI.Unity.Game;
using UnityEngine;
using Unity.Entities;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(Player), "SetGodMode")]
    public static class GodMode
    {
        public static bool Prefix(Entity entity, EntityManager entityManager)
        {
            if (CheatSettings.GodModeEnabled)
            {
                entityManager.AddComponentData<Invulnerable>(entity, default(Invulnerable));
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(Player), "SetNoClipMode")]
    public static class NoClip
    {
        public static bool Prefix(Collider collider, PlayerMotion playerMotion, bool enabled)
        {
            if (CheatSettings.NoClipEnabled)
            {
                if (collider != null)
                {
                    collider.isTrigger = true;
                }
                if (playerMotion != null)
                {
                    playerMotion.SetSquishyCollide(false);
                }
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(Player), "SetTroutMode")]
    public static class TroutMode
    {
        public static bool Prefix(Entity entity, EntityManager entityManager)
        {
            if (CheatSettings.TroutModeEnabled)
            {
                entityManager.RemoveComponent<ReceiveForceOnDecompression>(entity);
                return false;
            }
            return true;
        }
    }
}