using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace AgileDesignThemes.Wpf.Converters
{
    public  class GroupBoxHeaderCornerRadiusConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is CornerRadius cornerRadius)) return null;
            return new CornerRadius(cornerRadius.TopLeft, cornerRadius.TopRight, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
