using ComCalculator.Core;
using ComCalculator.Models;
using ComCalculator.Utils;
using ComCalculator.Views;
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
			userSettings = new UserSettingsModel();
		}
		#region Properies&Field
		public UserSettingsModel userSettings;
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
		public async void SaveSettings()
		{
			try
			{
				AppSettings.GasCoefitient = CalculationService.ConvertToInt(GasCoef);
				AppSettings.GasCounterPresence = IsGasCounterEnable;

				AppSettings.WaterCoefitient = CalculationService.ConvertToInt(WaterCoef);
				AppSettings.WaterCounterPresence = IsWaterCounterEnable;

				AppSettings.HotWaterCoefitient = CalculationService.ConvertToInt(HotWaterCoef);
				AppSettings.HotWaterCounterPresence = IsHotWaterCounterEnable;

				AppSettings.HeatingCoefitient = CalculationService.ConvertToInt(HeatingCost);
				AppSettings.HeatingCounterPresence = IsHeatingEnable;

				AppSettings.PublicServiceCoefitient = CalculationService.ConvertToInt(PublicServiceCost);
				AppSettings.PublicServiceCounterPresence = IsPublicServiceEnable;
			}
			catch (Exception ex)
			{
				throw;
			}

			CalcPage calcPage = new CalcPage();
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
