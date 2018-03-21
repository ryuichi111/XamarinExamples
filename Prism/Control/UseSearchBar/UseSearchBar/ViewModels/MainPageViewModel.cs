using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;

namespace UseSearchBar.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private string message;
		public string Message
		{
			get
			{
				return this.message;
			}
			set
			{
				this.SetProperty(ref this.message, value);
			}
		}


		private string searchText = "";
		public string SearchText
		{
			get
			{
				return this.searchText;
			}
			set
			{
				this.SetProperty(ref this.searchText, value);
			}
		}

		public ICommand SearchCommand
		{
			get;
		}

		public MainPageViewModel()
		{
			this.SearchCommand = new DelegateCommand(() =>
			 {
				 this.Message = "click search " + this.searchText;
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

