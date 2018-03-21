using Prism.Unity;
using PrismMasterDetailApp.Views;

using Xamarin.Forms.Xaml;
using Xamarin.Forms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismMasterDetailApp
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			// 初期ページは HomePage.xaml です。
			NavigationService.NavigateAsync("/MasterDetailRootPage/NavigationPage/HomePage");
		}

		protected override void RegisterTypes()
		{
			// 全てのページを登録します。
			Container.RegisterTypeForNavigation<MasterDetailRootPage>();
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MenuPage>();
			Container.RegisterTypeForNavigation<HomePage>();
			Container.RegisterTypeForNavigation<MyProfilePage>();
			Container.RegisterTypeForNavigation<SearchPage>();
		}
	}
}

