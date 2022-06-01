using BBI.Unity.Game;

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

                return true; // TODO: Setting
            }
        }

        public static bool FreeUpgradesEnabled
        {
            get
            {
                if (!CheatsEnabled)
                {
                    return false;
                }

                // TODO: Setting
                return true; //GlobalOptions.Raw.GetBool("General.FreeUpgrades", false);
            }
        }

        public static bool NoDurabilityDrainEnabled
        {
            get
            {
                if (!CheatsEnabled)
                {
                    return false;
                }

                // TODO: Setting
                return true;
            }
        }

        public static bool UnlimitedTethersEnabled
        {
            get
            {
                if (!CheatsEnabled)
                {
                    return false;
                }

                return true; // TODO: Setting
            }
        }

        public static float SingerMeltTime
        {
            get
            {
                if (!CheatsEnabled)
                {
                    return -1;
                }

                return 1; // TODO: Setting
            }
        }

        public static bool InfiniteHeat
        {
            get
            {
                if (!CheatsEnabled)
                {
                    return false;
                }

                return true; // TODO: Setting
            }
        }

        public static int StingerCutGrade
        {
            get
            {
                if (!CheatsEnabled)
                {
                    return -1;
                }

                return 5; // TODO: Setting
            }
        }
    }
}