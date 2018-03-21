using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UseStepper.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private double stepperValue;
		public double StepperValue
		{
			get
			{
				return this.stepperValue;
			}
			set
			{
				this.SetProperty(ref this.stepperValue, value);
			}
		}

		private double stepperMax = 100;
		public double StepperMax
		{
			get
			{
				return this.stepperMax;
			}
			set
			{
				this.SetProperty(ref this.stepperMax, value);
			}
		}

		private double stepperMin = -50;
		public double StepperMin
		{
			get
			{
				return this.stepperMin;
			}
			set
			{
				this.SetProperty(ref this.stepperMin, value);
			}
		}

		public MainPageViewModel()
		{

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

