using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Windows.Input;

namespace UseTimePicker.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private TimeSpan timeValue = new TimeSpan(10, 30, 20);
		public TimeSpan TimeValue
		{
			get
			{
				return this.timeValue;
			}
			set
			{
				this.SetProperty(ref timeValue, value);
			}
		}

		public ICommand SetTimeCommand { get; }

		public MainPageViewModel()
		{
			this.SetTimeCommand = new DelegateCommand(() => { this.TimeValue = new TimeSpan(21, 45, 0);});
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

