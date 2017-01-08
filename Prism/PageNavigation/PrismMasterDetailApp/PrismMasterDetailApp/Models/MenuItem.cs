using System;

namespace PrismMasterDetailApp.Models
{
	/// <summary>
	/// メニューアイテムクラスです。
	/// </summary>
	public class MenuItem
	{
		/// <summary>
		/// タイトルを取得または設定します。
		/// </summary>
		/// <value>メニュー表示名です。</value>
		public string Title { get; set; }

		/// <summary>
		/// ページ名を取得または設定します。
		/// </summary>
		/// <value>XAMLの物理ページ名です。</value>
		public string PageName { get; set; }

		/// <summary>
		/// メニューをロードします。
		/// </summary>
		/// <remarks>
		/// 固定でMenuItemを作成。
		/// </remarks>
		/// <returns>メニューリスト</returns>
		public static MenuItem[] LoadMenu()
		{
			MenuItem[] menuItems = new MenuItem[] {
				new MenuItem {
					Title = "Home",
					PageName = "HomePage"
				},
				new MenuItem {
					Title = "MyProfile",
					PageName = "MyProfilePage"
				},
				new MenuItem {
					Title = "Search",
					PageName = "SearchPage"
				},
			};

			return menuItems;
		}
	}
}
