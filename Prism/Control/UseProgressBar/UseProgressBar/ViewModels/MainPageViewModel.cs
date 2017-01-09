using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;

namespace UseProgressBar.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private double progress = 0;
		public double Progress
		{
			get
			{
				return this.progress;
			}
			set
			{
				this.SetProperty(ref this.progress, value);
			}
		}

		public ICommand PlusCommand
		{
			get;
		}

		public ICommand MinusCommand
		{
			get;
		}

		public MainPageViewModel()
		{
			this.PlusCommand = new DelegateCommand(() =>
			{
				this.Progress += 0.1;
			});

			this.MinusCommand = new DelegateCommand(() =>
			{
				this.Progress -= 0.1;
			});
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

