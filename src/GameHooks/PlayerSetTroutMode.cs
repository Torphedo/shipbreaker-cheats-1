
using BBI.Unity.Game;
using Unity.Entities;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(Player), "SetTroutMode")]
    public static class PlayerSetTroutMode
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
