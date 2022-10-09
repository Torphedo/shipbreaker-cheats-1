using BBI.Unity.Game;
using Carbon.Core;

namespace Torphedo.Shipbreaker.Cheats
{
    public static class CheatSettings
    {
        public static bool CheatsEnabled
        {
            get
            {
                return !(GameSession.CurrentSessionType == GameSession.SessionType.WeeklyShip);
            }
        }

        public static bool FreeUpgradesEnabled
        {
            get
            {
                return (GlobalOptions.Raw.GetBool("General.FreeUpgrades", false));
            }
        }

        public static bool InfiniteDurability
        {
            get
            {
                return (GlobalOptions.Raw.GetBool("General.InfiniteDurability", false) && CheatsEnabled);
            }
        }

        public static bool UnlimitedTethersEnabled
        {
            get
            {
                return (GlobalOptions.Raw.GetBool("General.InfiniteTethers", false) && CheatsEnabled);
            }
        }

        public static bool AlwaysAcceptSalvage
        {
            get
            {
                return (GlobalOptions.Raw.GetBool("General.AlwaysAcceptSalvage", false) && CheatsEnabled);
            }
        }

        public static float StingerMeltTime
        {
            get
            {
                if (CheatsEnabled)
                {
                    return GlobalOptions.Raw.GetFloat("General.StingerMeltTime", -1f);
                }
                else
                {
                    return -1;
                }
            }
        }

        public static float StingerCutGrade
        {
            get
            {
                if (CheatsEnabled)
                {
                    return GlobalOptions.Raw.GetFloat("General.StingerCutGrade", 1f);
                }
                else
                {
                    return 1f;
                }
            }
        }

        public static bool GodModeEnabled
        {
            get
            {
                return (GlobalOptions.Raw.GetBool("General.GodMode", false) && CheatsEnabled);
            }
        }
        public static bool TroutModeEnabled
        {
            get
            {
                return (GlobalOptions.Raw.GetBool("General.TroutMode", false) && CheatsEnabled);
            }
        }

        public static bool NoClipEnabled
        {
            get
            {
                return (GlobalOptions.Raw.GetBool("General.NoClip", false) && CheatsEnabled);
            }
        }
    }
}