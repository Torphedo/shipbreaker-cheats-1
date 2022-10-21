using BBI.Unity.Game;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    /*
    // Not working, spams console
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
    */

    // Debug Menu
    [HarmonyPatch(typeof(GameSession), "InitializeServices")]
    public class GameSession_InitializeServices
    {
        public static void Prefix(ref Carbon.Core.Services.ServiceContext ___mSessionServices)
        {
            ___mSessionServices.AddService<DebugMenu>(new DebugMenu(), true);
        }
    }
}
