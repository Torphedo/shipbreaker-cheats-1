
using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(ScalpelController), "IsValidTargetable")]
    public static class ScalpelControllerIsValidTargetable
    {
        public static bool Prefix(ref bool __result, StructurePart part)
        {
            var cutGrade = CheatSettings.StingerCutGrade;
            if (cutGrade < 0)
            {
                // Cheat is not active.  Continue to standard logic.
                return true;
            }

            if (cutGrade < part.CuttingTargetable.PowerRating)
            {
                // Material is higher grade than the cheated cut grade.
                __result = false;
                return false;
            }

            // Re-implemented logic from base game.
            // TODO: This introduces some incompatibility when cheats are enabled if the base game (or another mod) wants to change this logic.
            // We should use transpilation to replace the call to this.mData.PowerRating instead.

            if (part?.CuttingTargetable?.IsScalpelCuttable() != true || !EntityBlueprintComponent.IsValid(part.EntityBlueprintComponent) || (part.Group != null && !EntityBlueprintComponent.IsValid(part.Group.EntityBlueprintComponent)))
            {
                __result = false;
                return false;
            }

            __result = true;
            return false;
        }
    }
}