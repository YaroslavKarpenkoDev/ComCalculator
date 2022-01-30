using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ComCalculator.Utils
{
	public static partial class AppSettings
	{
        private const string GasPastValueKey = "gasPastVakue";
        public static readonly string GasPastValueDefault = "0";
        public static string GasPastValue
        {
            get => Preferences.Get(GasPastValueKey, GasPastValueDefault);
            set => Preferences.Set(GasPastValueKey, value);
        }

        private const string WaterPastValueKey = "waterPastValue";
        public static readonly string WaterPastValueDefault = "0";
        public static string WaterPastValue
        {
            get => Preferences.Get(WaterPastValueKey, WaterPastValueDefault);
            set => Preferences.Set(WaterPastValueKey, value);
        }

        private const string ElectricityPastValueKey = "electricityPastValue";
        public static readonly string ElectricityPastValueDefault = "0";
        public static string ElectricityPastValue
        {
            get => Preferences.Get(ElectricityPastValueKey, ElectricityPastValueDefault);
            set => Preferences.Set(ElectricityPastValueKey, value);
        }

        private const string HotWaterPastValuefKey = "hotWaterPastValue";
        public static readonly string HotWaterPastValueDefault = "0";
        public static string HotWaterPastValue
        {
            get => Preferences.Get(HotWaterPastValuefKey, HotWaterPastValueDefault);
            set => Preferences.Set(HotWaterPastValuefKey, value);
        }
    }
}
