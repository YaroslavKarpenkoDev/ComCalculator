using ComCalculator.Core;
using ComCalculator.Utils;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComCalculator.ViewModels
{
	public class CalcPageViewModel : ViewModelBase
	{
		public CalcPageViewModel(INavigationService navigationService) : base(navigationService)
		{
			LoadSettings();
		}
		public CalcPageViewModel()
		{

		}
		#region Properyies&Fields

		#region UnitsVisibles
		private bool isGasUnitEnable;
		public bool IsGasUnitEnable
		{
			get
			{
				return isGasUnitEnable;
			}
			set
			{
				isGasUnitEnable = value;
			}
		}

		private bool isWaterUnitEnable;
		public bool IsWaterUnitEnable
		{
			get
			{
				return isWaterUnitEnable;
			}
			set
			{
				isWaterUnitEnable = value;
			}
		}

		private bool isHotWaterUnitEnable;
		public bool IsHotWaterUnitEnable
		{
			get
			{
				return isHotWaterUnitEnable;
			}
			set
			{
				isHotWaterUnitEnable = value;
			}
		}

		private bool isHeatingUnitEnable;
		public bool IsHeatingUnitEnable
		{
			get
			{
				return isHeatingUnitEnable;
			}
			set
			{
				isHeatingUnitEnable = value;
			}
		}

		private bool publicServiceUnitEnable;
		public bool IsPublicServiceUnitEnable
		{
			get
			{
				return publicServiceUnitEnable;
			}
			set
			{
				publicServiceUnitEnable = value;
			}
		}
		#endregion UnitsVisibles

		#region CountersValues
		private string gasCounterOldValue;
		public string GasCounterOldValue
		{
			get
			{
				return gasCounterOldValue;
			}
			set
			{
				gasCounterOldValue = value;
			}
		}

		private string gasCounterNewValue;
		public string GasCounterNewValue
		{
			get
			{
				return gasCounterNewValue;
			}
			set
			{
				gasCounterNewValue = value;
			}
		}

		private string waterCounterOldValue;
		public string WaterCounterOldValue
		{
			get
			{
				return waterCounterOldValue;
			}
			set
			{
				waterCounterOldValue = value;
			}
		}

		private string waterCounterNewValue;
		public string WaterCounterNewValue
		{
			get
			{
				return waterCounterNewValue;
			}
			set
			{
				waterCounterNewValue = value;
			}
		}

		private string hotWaterCounterOldValue;
		public string HotWaterCounterOldValue
		{
			get
			{
				return hotWaterCounterOldValue;
			}
			set
			{
				hotWaterCounterOldValue = value;
			}
		}

		private string hotWaterCounterNewValue;
		public string HotWaterCounterNewValue
		{
			get
			{
				return hotWaterCounterNewValue;
			}
			set
			{
				hotWaterCounterNewValue = value;
			}
		}

		private string eletricityCounterOldValue;
		public string EletricityCounterOldValue
		{
			get
			{
				return eletricityCounterOldValue;
			}
			set
			{
				eletricityCounterOldValue = value;
			}
		}

		private string eletricityCounterNewValue;
		public string EletricityCounterNewValue
		{
			get
			{
				return eletricityCounterNewValue;
			}
			set
			{
				eletricityCounterNewValue = value;
			}
		}

		private string publicServiceCounterOldValue;
		public string PublicServiceCounterOldValue
		{
			get
			{
				return publicServiceCounterOldValue;
			}
			set
			{
				publicServiceCounterOldValue = value;
			}
		}

		private string publicServiceCounterNewValue;
		public string PublicServiceCounterNewValue
		{
			get
			{
				return publicServiceCounterNewValue;
			}
			set
			{
				publicServiceCounterNewValue = value;
			}
		}
		#endregion CountersValues

		#region Coefitients&Prises
		private string gasCoef;
		public string GasCoef
		{
			get
			{
				return gasCoef;
			}
			set
			{
				gasCoef = value;
			}
		}

		private string waterCoef;
		public string WaterCoef
		{
			get
			{
				return waterCoef;
			}
			set
			{
				waterCoef = value;
			}
		}

		private string hotWaterCoef;
		public string HotWaterCoef
		{
			get
			{
				return hotWaterCoef;
			}
			set
			{
				hotWaterCoef = value;
			}
		}

		private string electricityCoef;
		public string ElectricityCoef
		{
			get
			{
				return electricityCoef;
			}
			set
			{
				electricityCoef = value;
			}
		}

		private string heatingCost;
		public string HeatingCost
		{
			get
			{
				return heatingCost;
			}
			set
			{
				heatingCost = value;
			}
		}

		private string publicServiceCost;
		public string PublicServiceCost
		{
			get
			{
				return publicServiceCost;
			}
			set
			{
				publicServiceCost = value;
			}
		}
		#endregion Coefitients&Prises

		#region Results
		private string gasResult;
		public string GasResult
		{
			get
			{
				return gasResult;
			}
			set
			{
				gasResult = value;
			}
		}
		private string waterResult;
		public string WaterResult
		{
			get
			{
				return waterResult;
			}
			set
			{
				waterResult = value;
			}
		}

		private string hotWaterResult;
		public string HotWaterResult
		{
			get
			{
				return hotWaterResult;
			}
			set
			{
				hotWaterResult = value;
			}
		}

		private string electricityResult;
		public string ElectricityResult
		{
			get
			{
				return electricityResult;
			}
			set
			{
				electricityResult = value;
			}
		}
		#endregion


		#endregion
		#region Lifecycle
		public override void OnNavigatedTo(INavigationParameters parameters)
		{
			base.OnNavigatedTo(parameters);
		}

		public override void Initialization()
		{
			base.Initialization();
			LoadSettings();
		}
		#endregion
		#region Methods
		public void StartEtimation()
		{
			GasResult = CalculationService.ToCalculate(CalculationService.ConvertToDouble(GasCounterNewValue),CalculationService.ConvertToDouble(GasCounterOldValue),CalculationService.ConvertToDouble(GasCoef)).ToString();
			WaterResult = CalculationService.ToCalculate(CalculationService.ConvertToDouble(WaterCounterNewValue), CalculationService.ConvertToDouble(WaterCounterOldValue), CalculationService.ConvertToDouble(WaterCoef)).ToString();
			HotWaterResult = CalculationService.ToCalculate(CalculationService.ConvertToDouble(HotWaterCounterNewValue), CalculationService.ConvertToDouble(HotWaterCounterOldValue), CalculationService.ConvertToDouble(HotWaterCoef)).ToString();
			AppSettings.GasPastValue = GasCounterNewValue;
			 AppSettings.HotWaterPastValue = HotWaterCounterNewValue;
			AppSettings.WaterPastValue = WaterCounterNewValue;
			 AppSettings.ElectricityPastValue = EletricityCounterNewValue;
		}

		private void LoadSettings()
		{
			IsGasUnitEnable = AppSettings.GasCounterPresence;
			IsWaterUnitEnable = AppSettings.WaterCounterPresence;
			IsHotWaterUnitEnable = AppSettings.HotWaterCounterPresence;
			IsHeatingUnitEnable = AppSettings.HeatingCounterPresence;
			IsPublicServiceUnitEnable = AppSettings.PublicServiceCounterPresence;
			GasCounterOldValue = AppSettings.GasPastValue;
			HotWaterCounterOldValue = AppSettings.HotWaterPastValue;
			WaterCounterOldValue = AppSettings.WaterPastValue;
			EletricityCounterOldValue = AppSettings.ElectricityPastValue;
		}
		#endregion
	}
}
