using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bored.Converters
{

    public class IntToSingularAndPlural : IValueConverter, IMarkupExtension
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var intValue = (int)value;

            if (intValue < 0) return "NEGATIVE";
            if (intValue == 0) return "ZERO";
            if (intValue == 1) return "ONE";

            return "MANY";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }


}
