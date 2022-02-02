using ComCalculator.Core;
using ComCalculator.ViewModels;
using ComCalculator.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace ComCalculator
{
	public partial class App
	{
		public App(IPlatformInitializer initializer)
			: base(initializer)
		{
		}		
		protected override async void OnInitialized()
		{
			InitializeComponent();
			Sharpnado.Tabs.Initializer.Initialize(false, false);
			Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);
			Sharpnado.MaterialFrame.Initializer.Initialize(loggerEnable: false, debugLogEnable: false);
			await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(Views.MainPage)}");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
			containerRegistry.RegisterForNavigation<MainTabbedPage, MainTabbedPageViewModel>();
			containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>();
			containerRegistry.RegisterForNavigation<StatisticPage, StatisticPageViewModel>();
			containerRegistry.RegisterForNavigation<CalcPage, CalcPageViewModel>();
		}
	}
}
