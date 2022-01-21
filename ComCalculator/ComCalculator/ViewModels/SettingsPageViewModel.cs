using ComCalculator.Utils;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ComCalculator.ViewModels
{
	public class SettingsPageViewModel : ViewModelBase
	{
		public SettingsPageViewModel(INavigationService navigationService) : base(navigationService)
		{
			LoadSettings();
		}
		#region Properies&Field
		private string _gasCoef;
		public string GasCoef
		{
			get
			{
				return _gasCoef;
			}
			set
			{
				_gasCoef = value;
				RaisePropertyChanged(nameof(GasCoef));
			}
		}

		private bool _isGasCoefEnabled;
		public bool IsGasCounterEnable
		{
			get
			{
				return _isGasCoefEnabled;
			}
			set
			{
				_isGasCoefEnabled = value;
				RaisePropertyChanged(nameof(IsGasCounterEnable));
			}
		}

		private string _electricityCoef;
		public string ElectricityCoef
		{
			get
			{
				return _electricityCoef;
			}
			set
			{
				_electricityCoef = value;
				RaisePropertyChanged(nameof(ElectricityCoef));
			}
		}

		private string _waterCoef;
		public string WaterCoef
		{
			get
			{
				return _waterCoef;
			}
			set
			{
				_waterCoef = value;
				RaisePropertyChanged(nameof(WaterCoef));
			}
		}

		private bool _isWaterCounterEnable;
		public bool IsWaterCounterEnable
		{
			get
			{
				return _isWaterCounterEnable;
			}
			set
			{
				_isWaterCounterEnable = value;
				RaisePropertyChanged(nameof(IsWaterCounterEnable));
			}
		}

		private string _hotWaterCoef;
		public string HotWaterCoef
		{
			get
			{
				return _hotWaterCoef;
			}
			set
			{
				_hotWaterCoef = value;
				RaisePropertyChanged(nameof(HotWaterCoef));
			}
		}

		private bool _isHotWaterEnable;
		public bool IsHotWaterCounterEnable
		{
			get
			{
				return _isHotWaterEnable;
			}
			set
			{
				_isHotWaterEnable = value;
				RaisePropertyChanged(nameof(IsHotWaterCounterEnable));
			}
		}

		private string _heatingCoast;
		public string HeatingCost
		{
			get
			{
				return _heatingCoast;
			}
			set
			{
				_heatingCoast = value;
				RaisePropertyChanged(nameof(HeatingCost));
			}
		}

		private bool _isHeatingEnable;
		public bool IsHeatingEnable
		{
			get
			{
				return _isHeatingEnable;
			}
			set
			{
				_isHeatingEnable = value;
				RaisePropertyChanged(nameof(IsHeatingEnable));
			}
		}

		private string _publicServiceCost;
		public string PublicServiceCost
		{
			get
			{
				return _publicServiceCost;
			}
			set
			{
				_publicServiceCost = value;
				RaisePropertyChanged(nameof(PublicServiceCost));
			}
		}

		private bool _isPublicServiceEnable;
		public bool IsPublicServiceEnable
		{
			get
			{
				return _isPublicServiceEnable;
			}
			set
			{
				_isPublicServiceEnable = value;
				RaisePropertyChanged(nameof(IsPublicServiceEnable));
			}
		}
		#endregion

		#region Commands
		public ICommand SaveCommand => new Command(SaveSettings);
		#endregion

		#region Lifecycle
		public override void OnNavigatedTo(INavigationParameters parameters)
		{
			base.OnNavigatedTo(parameters);

			
		}

		#endregion

		#region Methods
		public void SaveSettings()
		{
			AppSettings.GasCoefitient = calculationService.ConvertToInt(GasCoef);
			AppSettings.GasCounterPresence = IsGasCounterEnable;

			AppSettings.WaterCoefitient = calculationService.ConvertToInt(WaterCoef);
			AppSettings.WaterCounterPresence = IsWaterCounterEnable;

			AppSettings.HotWaterCoefitient = calculationService.ConvertToInt(HotWaterCoef);
			AppSettings.HotWaterCounterPresence = IsHotWaterCounterEnable;

			AppSettings.HeatingCoefitient = calculationService.ConvertToInt(HeatingCost);
			AppSettings.HeatingCounterPresence = IsHeatingEnable;

			AppSettings.PublicServiceCoefitient = calculationService.ConvertToInt(PublicServiceCost);
			AppSettings.PublicServiceCounterPresence = IsPublicServiceEnable;
		}
		public void LoadSettings()
		{
			IsGasCounterEnable = AppSettings.GasCounterPresence;
			GasCoef = AppSettings.GasCoefitient.ToString();

			IsWaterCounterEnable = AppSettings.WaterCounterPresence;
			WaterCoef = AppSettings.WaterCoefitient.ToString();

			IsHotWaterCounterEnable = AppSettings.HotWaterCounterPresence;
			HotWaterCoef = AppSettings.HotWaterCoefitient.ToString();

			IsHeatingEnable = AppSettings.HeatingCounterPresence;
			HeatingCost = AppSettings.HeatingCoefitient.ToString();

			IsPublicServiceEnable = AppSettings.PublicServiceCounterPresence;
			PublicServiceCost = AppSettings.PublicServiceCoefitient.ToString();
		}		
		#endregion
	}
}
