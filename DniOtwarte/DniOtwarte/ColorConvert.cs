using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DniOtwarte
{
    class ColorConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string s = (string)value;
            if (!string.IsNullOrEmpty(s))
            {
                if (s.Contains("-"))
                {
                    return Color.Red;
                }
                else
                {
                    return Color.Green;
                }
            }
            return Color.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
