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
			await NavigationService.NavigateAsync("MainTabbedPage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<MainTabbedPage, MainTabbedPageViewModel>();
			containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>();
			containerRegistry.RegisterForNavigation<StatisticPage, StatisticPageViewModel>();
			containerRegistry.RegisterForNavigation<CalcPage, CalcPageViewModel>();
		}
	}
}
