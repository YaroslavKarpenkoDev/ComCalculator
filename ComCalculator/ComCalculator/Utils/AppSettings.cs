using ComCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ComCalculator.Utils
{
	public static partial class AppSettings
	{
        //gas
        private const string GasCoefKey = "gasCoef";
        public static readonly int GasCoefDefault = 0;
        public static int GasCoefitient
        {
            get => Preferences.Get(GasCoefKey, GasCoefDefault);
            set => Preferences.Set(GasCoefKey, value);
        }

        private const string GasCounterPresenceKey = "gasCounterPresence";
        public static readonly bool GasCounterPresenceDefault = false;
        public static bool GasCounterPresence
        {
            get => Preferences.Get(GasCounterPresenceKey, GasCounterPresenceDefault);
            set => Preferences.Set(GasCounterPresenceKey, value);
        }

        //water
        private const string WaterCoefKey = "waterCoef";
        public static readonly int WaterCoefDefault = 0;
        public static int WaterCoefitient
        {
            get => Preferences.Get(WaterCoefKey, WaterCoefDefault);
            set => Preferences.Set(WaterCoefKey, value);
        }

        private const string WaterCounterPresenceKey = "waterCounterPresence";
        public static readonly bool WaterCounterPresenceDefault = false;
        public static bool WaterCounterPresence
        {
            get => Preferences.Get(WaterCounterPresenceKey, WaterCounterPresenceDefault);
            set => Preferences.Set(WaterCounterPresenceKey, value);
        }

        //electricity
        private const string ElectricityCoefKey = "electricityCoef";
        public static readonly int ElectricityCoefDefault = 0;
        public static int ElectricityCoefitient
        {
            get => Preferences.Get(ElectricityCoefKey, ElectricityCoefDefault);
            set => Preferences.Set(ElectricityCoefKey, value);
        }

        private const string ElectricityCounterPresenceKey = "electricityCounterPresence";
        public static readonly bool ElectricityCounterPresenceDefault = false;
        public static bool ElectricityCounterPresence
        {
            get => Preferences.Get(ElectricityCounterPresenceKey, ElectricityCounterPresenceDefault);
            set => Preferences.Set(ElectricityCounterPresenceKey, value);
        }

        //hot water
        private const string HotWaterCoefKey = "hotWaterCoef";
        public static readonly int HotWaterCoefDefault = 0;
        public static int HotWaterCoefitient
        {
            get => Preferences.Get(HotWaterCoefKey, HotWaterCoefDefault);
            set => Preferences.Set(HotWaterCoefKey, value);
        }

        private const string HotWaterCounterPresenceKey = "hotWaterCounterPresence";
        public static readonly bool HotWaterCounterPresenceDefault = false;
        public static bool HotWaterCounterPresence
        {
            get => Preferences.Get(HotWaterCounterPresenceKey, HotWaterCounterPresenceDefault);
            set => Preferences.Set(HotWaterCounterPresenceKey, value);
        }


        //heating
        private const string HeatingCoefKey = "heatingCoef";
        public static readonly int HeatingCoefDefault = 0;
        public static int HeatingCoefitient
        {
            get => Preferences.Get(HeatingCoefKey, HeatingCoefDefault);
            set => Preferences.Set(HeatingCoefKey, value);
        }

        private const string HeatingCounterPresenceKey = "heatingCounterPresence";
        public static readonly bool HeatingCounterPresenceDefault = false;
        public static bool HeatingCounterPresence
        {
            get => Preferences.Get(HeatingCounterPresenceKey, HeatingCounterPresenceDefault);
            set => Preferences.Set(HeatingCounterPresenceKey, value);
        }

        //pbulic service
        private const string PublicServiceCoefKey = "publicServiceCoef";
        public static readonly int PublicServiceCoefDefault = 0;
        public static int PublicServiceCoefitient
        {
            get => Preferences.Get(PublicServiceCoefKey, PublicServiceCoefDefault);
            set => Preferences.Set(PublicServiceCoefKey, value);
        }

        private const string PublicServiceCounterPresenceKey = "publicServiceCounterPresence";
        public static readonly bool PublicServiceCounterPresenceDefault = false;
        public static bool PublicServiceCounterPresence
        {
            get => Preferences.Get(PublicServiceCounterPresenceKey, PublicServiceCounterPresenceDefault);
            set => Preferences.Set(PublicServiceCounterPresenceKey, value);
        }
    }
}
