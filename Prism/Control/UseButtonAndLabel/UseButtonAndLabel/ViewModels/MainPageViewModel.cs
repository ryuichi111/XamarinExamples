using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;

namespace UseButtonAndLabel.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		
		private string message;

		/// <summary>
		/// メッセージ
		/// </summary>
		/// <remarks>
		/// Label.Textにバインドされます。
		/// </remarks>
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

		/// <summary>
		/// OKコマンド
		/// </summary>
		public ICommand OkCommand { get; }

		/// <summary>
		/// Cancelコマンド
		/// </summary>
		public ICommand CancelCommand { get; }

		public MainPageViewModel()
		{
			// OKコマンドに OK() メソッドを紐づけます。
			this.OkCommand = new DelegateCommand(this.Ok);

			// Cancelコマンドに ラムダ式で処理を紐づけます。
			this.CancelCommand = new DelegateCommand(
				() => { this.Message = "Cancel clicked"; } );
		}

		// OKコマンド発生時に呼び出されます。
		private void Ok()
		{
			this.Message = "OK clicked";
		}


		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

