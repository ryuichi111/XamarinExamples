using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Windows.Input;

namespace UseSwitch.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private Boolean toggledValue = false;
		public Boolean ToggledValue
		{
			get
			{
				return this.toggledValue;
			}
			set
			{
				this.SetProperty(ref this.toggledValue, value);
			}
		}

		public ICommand OnCommand { get; }
		public ICommand OffCommand { get; }

		public MainPageViewModel()
		{
			this.OnCommand = new DelegateCommand(() => { this.ToggledValue = true; });
			this.OffCommand = new DelegateCommand(() => { this.ToggledValue = false; });
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

