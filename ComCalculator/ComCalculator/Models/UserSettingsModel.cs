using System;
using System.Collections.Generic;
using System.Text;

namespace ComCalculator.Models
{
	public class UserSettingsModel
	{
		public string GasCoef { get; set; }
		public bool IsGasCounterEnable { get; set; }
		public string ElectricityCoef { get; set; }
		public string WaterCoef { get; set; }
		public bool IsWaterCounterEnable { get; set; }
		public string HotWaterCoef { get; set; }
		public bool IsHotWaterCounterEnable { get; set; }
		public string HeatingCost { get; set; }
		public bool IsHeatingEnable { get; set; }
		public string PublicServiceCost { get; set; }
		public bool IsPublicServiceEnable { get; set; }
		public string GasCounterOldValue { get; set; }
		public string GasCounterNewValue { get; set; }
		public string WaterCounterOldValue { get; set; }
		public string WaterCounterNewValue { get; set; }
		public string HotWaterCounterOldValue { get; set; }
		public string HeatingCounterOldValue { get; set; }
		public string HeatingCounterNewValue { get; set; }
	}
}
