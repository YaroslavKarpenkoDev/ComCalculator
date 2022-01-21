﻿using ComCalculator.Core;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComCalculator.ViewModels
{
	public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
	{
		protected INavigationService NavigationService { get; private set; }
		protected ICalculationService calculationService;
		public ViewModelBase(INavigationService navigationService)
		{
			NavigationService = navigationService;
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
	}
}
