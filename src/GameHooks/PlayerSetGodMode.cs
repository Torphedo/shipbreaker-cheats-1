
using BBI.Unity.Game;
using Unity.Entities;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(Player), "SetGodMode")]
    public static class PlayerSetGodMode
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
}
