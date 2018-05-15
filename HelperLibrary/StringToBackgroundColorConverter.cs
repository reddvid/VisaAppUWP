using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace HelperLibrary
{
    public class StringToBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string s = (string)value;
            if (s == "Visa required")
                return new SolidColorBrush(Color.FromArgb(255, 162, 33, 33));
            else if (s == "Visa on arrival")
                return new SolidColorBrush(Color.FromArgb(255, 50, 102, 177));
            else if (s == "e-Visa")
                return new SolidColorBrush(Color.FromArgb(255, 176, 146, 3));
            else if (s == "Visa-free")
                return new SolidColorBrush(Color.FromArgb(255, 43, 137, 60)); // Green
            else
                return new SolidColorBrush(Color.FromArgb(0, 153, 153, 153));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
