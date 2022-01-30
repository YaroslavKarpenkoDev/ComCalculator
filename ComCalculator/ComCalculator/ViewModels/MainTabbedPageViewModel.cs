using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComCalculator.ViewModels
{
	public class MainTabbedPageViewModel : ViewModelBase
	{
		public MainTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
		{
			
		}
		#region Properties&Fields
		private int selectedIndex = 0;
		private SettingsPageViewModel settingsPage;
		private StatisticPageViewModel statisticPage;
		private CalcPageViewModel calcPage;
		public int SelectedIndex
		{
			get => selectedIndex;
			set
			{
				if (value == 1)
				{
					CalculatePage.Initialization();
				}
				selectedIndex = value;
			}
		}
		public CalcPageViewModel CalculatePage
		{
			get
			{
				if (calcPage == null)
				{
					calcPage = new CalcPageViewModel(NavigationService);
				}
				return calcPage;
			}
		}
		public SettingsPageViewModel PageOfSettings
		{
			get
			{
				if (settingsPage == null)
				{
					settingsPage = new SettingsPageViewModel(NavigationService);
				}
				return settingsPage;
			}
		}
		public StatisticPageViewModel PageOfStatistic
		{
			get
			{
				if (statisticPage == null)
				{
					statisticPage = new StatisticPageViewModel(NavigationService);
				}
				return statisticPage;
			}
		}
		#endregion

		#region LifeCycle
		public override void OnNavigatedTo(INavigationParameters parameters)
		{
			base.OnNavigatedTo(parameters);
		}
		#endregion
	}
}
