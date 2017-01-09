using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Windows.Input;

namespace UseEntry.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private string labelText = "";
		public string LabelText
		{
			get
			{
				return this.labelText;
			}
			set
			{
				this.SetProperty(ref this.labelText, value);
			}
		}

		private string entryText = "";
		public string EntryText
		{
			get
			{
				return this.entryText;
			}
			set
			{
				this.SetProperty(ref this.entryText, value);
			}
		}

		public ICommand OkCommand { get; }
		public ICommand SetTextCommand { get; }

		public MainPageViewModel()
		{
			this.OkCommand = new DelegateCommand(this.Ok);
			this.SetTextCommand = new DelegateCommand(this.SetText);
		}

		private void Ok()
		{
			this.LabelText = this.EntryText;
		}

		private void SetText()
		{
			this.EntryText = DateTime.Now.ToString("yyyy/MM/dd H:m:s");
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

