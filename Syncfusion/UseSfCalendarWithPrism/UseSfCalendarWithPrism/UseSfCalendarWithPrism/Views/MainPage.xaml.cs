using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UseSfCalendarWithPrism.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            this.calendar.Locale = new System.Globalization.CultureInfo("ja-JP");

            MessagingCenter.Subscribe<object>(this, "Forward", (sender) => {
                DependencyService.Get<ICalendarDirection>().Forward();
            });

            MessagingCenter.Subscribe<object>(this, "Backward", (sender) => {
                DependencyService.Get<ICalendarDirection>().Backward();
            });
        }
    }
}