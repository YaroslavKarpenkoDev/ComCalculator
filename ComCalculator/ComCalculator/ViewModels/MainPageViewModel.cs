using ComCalculator.Utils;
using ComCalculator.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ComCalculator.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{

		}

		public ICommand NavigateToSettingsCommand => new Command(NavigateToSettings);
		public ICommand NavigateToCalcCommand => new Command(NavigateToCalc);
		public ICommand NavigateToStatisticCommand => new Command(NavigateToStatistic);

		public async void NavigateToSettings()
		{
			await NavigationService.NavigateAsync($"{nameof(SettingsPage)}");
		}
		public async void NavigateToCalc()
		{
			await NavigationService.NavigateAsync($"{nameof(CalcPage)}");
		}
		public async void NavigateToStatistic()
		{
			await NavigationService.NavigateAsync($"{nameof(StatisticPage)}");
		}
	}
}
