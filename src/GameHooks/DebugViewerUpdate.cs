
using BBI.Unity.Game;
using BBI.Core.Utility;
using Unity.Entities;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(DebugViewer), "Update")]
    public static class DebugViewerUpdate
    {
        public static bool Prefix()
        {
            bool mShowRaceControls = false;
            if (LynxControls.Instance.GetInputWasPressed(GameplayActions.GameplayActionSet.ShowDebugControls))
            {
                mShowRaceControls = !mShowRaceControls;
            }
            if (LynxControls.Instance.GetInputWasPressed(GameplayActions.GameplayActionSet.ToggleDebugMenu))
            {
                CertificationService.Instance.TryIncreaseCertification(false);
            }
            return true;
        }
    }
}
