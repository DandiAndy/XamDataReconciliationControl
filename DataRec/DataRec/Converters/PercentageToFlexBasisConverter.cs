using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DataRec.Converters
{
    public class PercentageToFlexBasisConverter : IValueConverter
    {
        private readonly FlexBasis.FlexBasisTypeConverter _converter = new FlexBasis.FlexBasisTypeConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string stringValue)
            {
                return _converter.ConvertFromInvariantString(stringValue);
            }
            return new FlexBasis();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
