using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComCalculator.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalcUnit : Frame
	{
		public CalcUnit()
		{
			InitializeComponent();
		}
		#region BindableProperties
		public static BindableProperty TitleProperty = BindableProperty.Create(
			propertyName: nameof(Title),
			returnType: typeof(string),
			declaringType: typeof(CalcUnit),
			defaultValue: "Title",
			defaultBindingMode: BindingMode.TwoWay,
			propertyChanged: TitlePropertyChanged);

		public static BindableProperty CurrentValueProperty = BindableProperty.Create(
			propertyName: nameof(CurrentValue),
			returnType: typeof(string),
			declaringType: typeof(CalcUnit),
			defaultValue: "Current",
			defaultBindingMode: BindingMode.TwoWay,
			propertyChanged: CurrentValuePropertyChanged);

		public static BindableProperty PerviousValueProperty = BindableProperty.Create(
			propertyName: nameof(PreviousValue),
			returnType: typeof(string),
			declaringType: typeof(CalcUnit),
			defaultValue: "Current",
			defaultBindingMode: BindingMode.TwoWay,
			propertyChanged: PerviousValuePropertyChanged);

		public static BindableProperty CoefValueProperty = BindableProperty.Create(
			propertyName: nameof(CoefValue),
			returnType: typeof(string),
			declaringType: typeof(CalcUnit),
			defaultValue: "Current",
			defaultBindingMode: BindingMode.TwoWay,
			propertyChanged: CoefValuePropertyChanged);

		public static BindableProperty ResultValueProperty = BindableProperty.Create(
			propertyName: nameof(ResultValue),
			returnType: typeof(string),
			declaringType: typeof(CalcUnit),
			defaultValue: "Current",
			defaultBindingMode: BindingMode.TwoWay,
			propertyChanged: ResultValuePropertyChanged);
		#endregion

		#region Properties
		public string Title
		{
			get => (string)GetValue(TitleProperty);
			set => SetValue(TitleProperty, value);
		}

		public string CurrentValue
		{
			get => (string)GetValue(CurrentValueProperty);
			set => SetValue(CurrentValueProperty, value);
		}

		public string PreviousValue
		{
			get => (string)GetValue(PerviousValueProperty);
			set => SetValue(PerviousValueProperty, value);
		}

		public string CoefValue
		{
			get => (string)GetValue(CoefValueProperty);
			set => SetValue(CoefValueProperty, value);
		}

		public string ResultValue
		{
			get => (string)GetValue(ResultValueProperty);
			set => SetValue(ResultValueProperty, value);
		}
		#endregion
		#region PropertyChanged
		private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			if (bindable is CalcUnit e)
			{
				if (newValue != null)
				{
					e.TitleLabel.Text = (string)newValue;				
				}
			}
		}

		private static void CurrentValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			if (bindable is CalcUnit e)
			{
				if (newValue != null)
				{
					e.CurrentValueEntry.Text = (string)newValue;
				}
			}
		}

		private static void PerviousValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			if (bindable is CalcUnit e)
			{
				if (newValue != null)
				{
					e.PreviousValueEntry.Text = (string)newValue;
				}
			}
		}
		private static void CoefValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			if (bindable is CalcUnit e)
			{
				if (newValue != null)
				{
					e.CoefLabel.Text = (string)newValue;
				}
			}
		}
		private static void ResultValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			if (bindable is CalcUnit e)
			{
				if (newValue != null)
				{
					e.ResultLabel.Text = (string)newValue;
				}
			}
		}
		#endregion
	}
}