using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Prism.Mvvm;
using Prism.Navigation;

using PrismMasterDetailApp.Models;

namespace PrismMasterDetailApp.ViewModels
{
	/// <summary>
	/// ビューモデルクラスです。
	/// </summary>
	public class MasterDetailRootPageViewModel : BindableBase
	{
		/// <summary>
		/// 現在日時（ViewModel生成時の）を取得または設定します。
		/// </summary>
		/// <value>The current date time.</value>
		public DateTime CurrentDateTime { get; set; }

		/// <summary>
		/// ナビゲーションサービス
		/// </summary>
		private INavigationService NavigationService { get; }

		/// <summary>
		/// メニューリストを取得します。
		/// </summary>
		/// <value>マスターページのメニュー項目リスト</value>
		public ObservableCollection<MenuItem> Menus { get; }

		/// <summary>
		/// 選択中メニュー
		/// </summary>
		private MenuItem _selectedMenu = null;

		/// <summary>
		/// 選択中メニューは取得または設定します。
		/// </summary>
		/// <value>The selected menu.</value>
		public MenuItem SelectedMenu
		{
			get
			{
				return this._selectedMenu;
			}
			set
			{
				this.SetProperty(ref this._selectedMenu, value);

				// ページ遷移
				this.NavigationService.NavigateAsync($"NavigationPage/{value.PageName}");
			}
		}

		/// <summary>
		/// コンストラクタです。
		/// </summary>
		/// <param name="navigationService">
		/// ナビゲーションサービスオブジェクト。DIでインジェクションされます。
		/// </param>
		public MasterDetailRootPageViewModel(INavigationService navigationService)
		{
			this.NavigationService = navigationService;

			this.Menus = new ObservableCollection<MenuItem>(MenuItem.LoadMenu());

			this.CurrentDateTime = DateTime.Now;
		}
	}
}
