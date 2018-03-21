using System.Collections.ObjectModel;
using Prism.Navigation;
using Xamarin.Forms;
using BlankApp6.ViewModels;

namespace UseAlexCarouselViewApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<PageInfo> CarouselPageInfo { get; set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";

            this.CarouselPageInfo = new ObservableCollection<PageInfo>
            {
                new PageInfo
                {
                    Name = "Page1",
                    ForeColor=Color.Yellow,
                    BackColor= Color.Red
                },
                new PageInfo
                {
                    Name = "Page2",
                    ForeColor=Color.Black,
                    BackColor= Color.Yellow
                },
                new PageInfo
                {
                    Name = "Page3",
                    ForeColor=Color.Gold,
                    BackColor= Color.Green
                }
            };
        }
    }
}
