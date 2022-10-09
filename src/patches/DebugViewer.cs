using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(BBI.Core.Utility.DebugViewer), "Update")]
    public static class DebugViewer
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
