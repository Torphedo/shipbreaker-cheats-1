using BBI.Unity.Game;
using UnityEngine;
using Unity.Entities;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(Player), "SetGodMode")]
    public static class GodMode
    {
        public static void Prefix(ref bool enabled)
        {
            enabled = CheatSettings.GodModeEnabled;
        }
    }

    [HarmonyPatch(typeof(Player), "SetNoClipMode")]
    public static class NoClip
    {
        public static void Prefix(ref bool enabled)
        {
            enabled = CheatSettings.NoClipEnabled;
        }
    }

    [HarmonyPatch(typeof(Player), "SetTroutMode")]
    public static class TroutMode
    {
        public static void Prefix(ref bool enabled)
        {
            enabled = CheatSettings.TroutModeEnabled;
        }
    }
}