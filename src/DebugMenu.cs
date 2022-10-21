using System;
using System.Collections;
using System.Collections.Generic;
using BBI.Unity.Game;
using Carbon.Core;
using Carbon.Core.Events;
using Carbon.Core.Services;
using Carbon.Core.Unity;
using Carbon.Localization.Core;
using Unity.Entities;
using UnityEngine;

namespace Torphedo.Shipbreaker.Cheats
{
    internal class DebugMenu : DebuggerServiceBase, IUse<LocalizationService>, IUse<IEventSystem>
    {
        private Player mPlayer;
        private PlayerMotion mPlayerMotion;

        public override string Name
        {
            get
            {
                return "Torph's Cheats";
            }
        }

        public override void DrawGUI()
        {
            if (mPlayer == null) mPlayer = GameObject.FindObjectOfType<Player>();
            if (mPlayerMotion == null) mPlayerMotion = Player.FindPlayerMotion(mPlayer);

            BoolButton("General.FreeUpgrades", "Free Upgrades");
            BoolButton("General.InfiniteDurability", "Infinite Durability");
            BoolButton("General.InfiniteTethers", "Infinite Tethers");
            BoolButton("General.AlwaysAcceptSalvage", "Always Accept Salvage");
            BoolButton("General.GodMode", "God Mode", enabled => Player.SetGodMode(mPlayer.Entity, World.DefaultGameObjectInjectionWorld.EntityManager, enabled));
            BoolButton("General.TroutMode", "Trout Mode", enabled => Player.SetTroutMode(mPlayer.Entity, World.DefaultGameObjectInjectionWorld.EntityManager, enabled));
            BoolButton("General.NoClip", "No Clip", enabled => Player.SetNoClipMode(mPlayer.PlayerCollider, mPlayerMotion, enabled));

            BoolButton("General.NoCutterHeat", "Infinite Cutter Heat");
            FloatField("General.StingerMeltTime", "Stinger Melt Time", -1f);
            FloatField("General.StingerCutGrade", "Stinger Cut Grade", 1f);
        }

        private void BoolButton(string setting, string label, Action<bool> callback = null)
        {
            var settingValue = GlobalOptions.Raw.GetBool(setting, false);
            if (DebugServiceUtils.DebugButton($"Turn {(settingValue ? "off" : "on")} {label}", DebugServiceUtils.sEmptyLayoutOptions))
            {
                GlobalOptions.Raw.SetBool(setting, !settingValue);
                if (callback != null) callback(!settingValue);
            }
        }

        private void FloatField(string setting, string label, float defaultValue)
        {
            var settingValue = GlobalOptions.Raw.GetFloat(setting, defaultValue);
            var originalValue = settingValue;
            LabeledFloatField(label, ref settingValue);
            if (originalValue != settingValue)
            {
                GlobalOptions.Raw.TrySetValue(setting, settingValue.ToString());
            }
        }

        // BBI's LabeledFloatField doesn't allow negative values -.-
        // Copied, minor change to the regex
        public static void LabeledFloatField(string displayName, ref float floatValue)
        {
            string stringValue = floatValue.ToString();
            DebugServiceUtils.LabeledTextField(displayName, ref stringValue);
            stringValue = System.Text.RegularExpressions.Regex.Replace(stringValue, "[^0-9.\\-]", "");
            if (float.TryParse(stringValue, out float result))
            {
                floatValue = result;
            }
        }

        #region Required Inheritance Stuff

        private LocalizationService mLocalizationService;
        private IEventSystem mEventSystem;

        // Token: 0x060043D1 RID: 17361 RVA: 0x00028801 File Offset: 0x00026A01
        void IUse<LocalizationService>.Bind(LocalizationService service)
        {
            this.mLocalizationService = service;
        }

        // Token: 0x060043D2 RID: 17362 RVA: 0x0002880A File Offset: 0x00026A0A
        void IUse<LocalizationService>.Unbind(LocalizationService service)
        {
            this.mLocalizationService = null;
        }

        // Token: 0x060043D3 RID: 17363 RVA: 0x00028813 File Offset: 0x00026A13
        void IUse<IEventSystem>.Bind(IEventSystem service)
        {
            this.mEventSystem = service;
        }

        // Token: 0x060043D4 RID: 17364 RVA: 0x0002881C File Offset: 0x00026A1C
        void IUse<IEventSystem>.Unbind(IEventSystem service)
        {
            this.mEventSystem = null;
        }

        #endregion
    }

}
