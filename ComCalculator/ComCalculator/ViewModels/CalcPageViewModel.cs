using ComCalculator.Core;
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
				RaisePropertyChanged(nameof(IsGasUnitEnable));
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
				RaisePropertyChanged(nameof(IsWaterUnitEnable));
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
				RaisePropertyChanged(nameof(IsHotWaterUnitEnable));
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
				RaisePropertyChanged(nameof(IsHeatingUnitEnable));
			}
		}

		private bool publicServiceUnitEnable;
		public bool IspublicServiceUnitEnable
		{
			get
			{
				return publicServiceUnitEnable;
			}
			set
			{
				publicServiceUnitEnable = value;
				RaisePropertyChanged(nameof(IspublicServiceUnitEnable));
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
				RaisePropertyChanged(nameof(GasCounterOldValue));
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
				RaisePropertyChanged(nameof(GasCounterNewValue));
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
				RaisePropertyChanged(nameof(WaterCounterOldValue));
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
				RaisePropertyChanged(nameof(WaterCounterNewValue));
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
				RaisePropertyChanged(nameof(HotWaterCounterOldValue));
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
				RaisePropertyChanged(nameof(HotWaterCounterNewValue));
			}
		}

		private string heatingCounterOldValue;
		public string HeatingCounterOldValue
		{
			get
			{
				return heatingCounterOldValue;
			}
			set
			{
				heatingCounterOldValue = value;
				RaisePropertyChanged(nameof(HeatingCounterOldValue));
			}
		}

		private string heatingCounterNewValue;
		public string HeatingCounterNewValue
		{
			get
			{
				return heatingCounterNewValue;
			}
			set
			{
				heatingCounterNewValue = value;
				RaisePropertyChanged(nameof(HeatingCounterNewValue));
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
				RaisePropertyChanged(nameof(PublicServiceCounterOldValue));
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
				RaisePropertyChanged(nameof(PublicServiceCounterNewValue));
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
				RaisePropertyChanged(nameof(GasCoef));
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
				RaisePropertyChanged(nameof(WaterCoef));
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
				RaisePropertyChanged(nameof(HotWaterCoef));
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
				RaisePropertyChanged(nameof(HeatingCost));
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
				RaisePropertyChanged(nameof(PublicServiceCost));
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
				RaisePropertyChanged(nameof(GasResult));
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
				RaisePropertyChanged(nameof(WaterResult));
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
				RaisePropertyChanged(nameof(HotWaterResult));
			}
		}
		#endregion

		#endregion

		#region Methods
		public void StartEtimation()
		{
			GasResult = calculationService.ToCalculate(calculationService.ConvertToDouble(GasCounterNewValue),calculationService.ConvertToDouble(GasCounterOldValue),calculationService.ConvertToDouble(GasCoef)).ToString();
			WaterResult = calculationService.ToCalculate(calculationService.ConvertToDouble(WaterCounterNewValue), calculationService.ConvertToDouble(WaterCounterOldValue), calculationService.ConvertToDouble(WaterCoef)).ToString();
			HotWaterResult = calculationService.ToCalculate(calculationService.ConvertToDouble(HotWaterCounterNewValue), calculationService.ConvertToDouble(HotWaterCounterOldValue), calculationService.ConvertToDouble(HotWaterCoef)).ToString();
		}
		#endregion
	}
}
