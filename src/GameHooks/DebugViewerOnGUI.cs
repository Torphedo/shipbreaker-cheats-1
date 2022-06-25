
using BBI.Unity.Game;
using BBI.Core.Utility;
using Carbon.Core.Events;
using System;
using UnityEngine;
using Unity.Entities;
using HarmonyLib;

namespace Torphedo.Shipbreaker.Cheats
{
    [HarmonyPatch(typeof(DebugViewer), "OnGUI")]
    public static class DebugViewerOnGUI
    {
        public static bool Prefix(Entity entity, EntityManager entityManager)
        {
			/*  TODO: Find a way to patch in these GUILayout lines in
                preparation for adding keybinds in the future      */

			// bool mShowRaceControls = false;

			// if (DebugViewer.mShowDebugControls)
			// {
			// 	GUILayout.Label("F1 - Refill Oxygen", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F2 - Refill Thrusters", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F3 - Glass Mode", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F4 - Frame Rate Counter", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F5 - Mega Cut Player", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F6 - Mega Cut All", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F9 - Save Game", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F10 - Load Game", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("I - Invert Axes", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("Alt + Z - Glass Mode", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("Shift + Esc - Return to Front End", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F5 - Mega Cutter", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F6 - Complete Current Certification", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F7 - Toggle Wireframe", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F10 - Show Modded Controls", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("Left Arrow - Pause Time", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("Right Arrow - Reset Game Speed", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("Up Arrow - Increase Game Speed by 0.1x", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("Down Arrow - Decrease Game Speed by 0.1x", Array.Empty<GUILayoutOption>());
			// }
			// if (this.mShowRaceControls)
			// {
			// 	GUILayout.Label(" ", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F3 - Glass Mode", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F4 - Frame Rate Counter", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F7 - Toggle Wireframe", Array.Empty<GUILayoutOption>());
			// 	GUILayout.Label("F10 - Show Modded Controls", Array.Empty<GUILayoutOption>());
			// }
			return true;
        }
    }
}
