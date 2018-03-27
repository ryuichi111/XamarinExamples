using Syncfusion.SfCalendar.XForms;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace UseSfCalendarWithPrism.Converters
{
    /// <summary>
    /// SelectionModeコンバータクラスです。
    /// </summary>
    public class SelectionModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SelectionMode result = SelectionMode.SingleSelection;

            if ("SingleSelection" == value.ToString())
                result = SelectionMode.SingleSelection;
            else if ("MultiSelection" == value.ToString())
                result = SelectionMode.MultiSelection;
            else if ("RangeSelection" == value.ToString())
                result = SelectionMode.RangeSelection;
            else if ("MultiRangeSelection" == value.ToString())
                result = SelectionMode.MultiRangeSelection;

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
