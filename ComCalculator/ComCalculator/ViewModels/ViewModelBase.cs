using ComCalculator.Core;
using Prism.Commands;
using Prism.Common;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Navigation;
using Acr.UserDialogs;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComCalculator.ViewModels
{
	public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
	{
		protected INavigationService NavigationService { get; private set; }

		protected ICalculationService CalculationService;
		public ViewModelBase(INavigationService navigationService)
		{
			NavigationService = navigationService;
			CalculationService = new CalculationService();
		}
		public ViewModelBase()
		{

		}

		public virtual void Initialize(INavigationParameters parameters)
		{

		}

		public virtual void OnNavigatedFrom(INavigationParameters parameters)
		{

		}

		public virtual void OnNavigatedTo(INavigationParameters parameters)
		{

		}

		public virtual void Destroy()
		{

		}	
		
		public virtual void Initialization()
		{

		}
	}
}
