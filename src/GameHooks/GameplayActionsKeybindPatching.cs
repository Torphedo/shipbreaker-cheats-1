
using BBI.Unity.Game;
using HarmonyLib;
using System;
using InControl;
using UnityEngine;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(GameplayActions), "GameplayActions", MethodType.Getter)]
    public static class GameplayActionsKeybindPatches
    {
        // GameplayActions.mDefaultBindings.Add(new LynxControlBindingInfo(GameplayActions.GameplayActionSet.ToggleFramerate, InputControlType.None, new Key[] { Key.F4 }, Mouse.None));
    }
}
