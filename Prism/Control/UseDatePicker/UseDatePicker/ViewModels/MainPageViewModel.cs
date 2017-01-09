using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Windows.Input;

namespace UseDatePicker.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private DateTime minDate = new DateTime(2010,1,1);
		public DateTime MinDate
		{
			get
			{
				return this.minDate;
			}
		}

		private DateTime maxDate = new DateTime(2050, 12, 31);
		public DateTime MaxDate
		{
			get
			{
				return this.maxDate;
			}
		}

		private DateTime selectedDate = DateTime.Now;
		public DateTime SelectedDate
		{
			get
			{
				return this.selectedDate;
			}
			set
			{
				this.SetProperty(ref this.selectedDate, value);
			}
		}

		public ICommand AddDayCommand { get; }
		public ICommand SubtractDayCommand { get; }

		public MainPageViewModel()
		{
			this.AddDayCommand = new DelegateCommand(this.AddDay);
			this.SubtractDayCommand = new DelegateCommand(this.SubtractDay);
		}

		private void AddDay()
		{
			this.SelectedDate = this.SelectedDate.AddDays(1);
		}

		private void SubtractDay()
		{
			this.SelectedDate = this.SelectedDate.AddDays(-1);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

