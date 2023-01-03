using System;
using System.Globalization;
using Xamarin.Forms;

namespace ComCalculator.Converters
{
    public class FactorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is double))
            {
                throw new InvalidOperationException("The target must be a double");
            }

            var dValue = (double)value;

            if (!double.TryParse((string)parameter, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var dParam))
            {
                throw new InvalidOperationException("The parameter must be a double");
            }

            return dValue * dParam;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}