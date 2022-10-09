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
                if (GameSession.CurrentSessionType == GameSession.SessionType.WeeklyShip)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool FreeUpgradesEnabled
        {
            get
            {
                if (GlobalOptions.Raw.GetBool("General.FreeUpgrades", false))
                {
                    return true; 
                }
                else 
                {
                    return false;
                }
            }
        }

        public static bool InfiniteDurability
        {
            get
            {
                if (GlobalOptions.Raw.GetBool("General.InfiniteDurability", false) && CheatsEnabled)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool UnlimitedTethersEnabled
        {
            get
            {
                if (GlobalOptions.Raw.GetBool("General.InfiniteTethers", false) && CheatsEnabled)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool AlwaysAcceptSalvage
        {
            get
            {
                if (GlobalOptions.Raw.GetBool("General.AlwaysAcceptSalvage", false) && CheatsEnabled)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
                if (GlobalOptions.Raw.GetBool("General.GodMode", false) && CheatsEnabled)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool TroutModeEnabled
        {
            get
            {
                if (GlobalOptions.Raw.GetBool("General.TroutMode", false) && CheatsEnabled)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool NoClipEnabled
        {
            get
            {
                if (GlobalOptions.Raw.GetBool("General.NoClip", false) && CheatsEnabled)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}