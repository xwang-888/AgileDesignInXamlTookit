using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AgileDesignThemes.Wpf.Converters
{
    public class ProgressBarWaveEllipseConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is not double width) return 0;
            if (values[1] is not double height) return 0;
            var newWidth = width / 2;
            var newHeight = height / 2;

            switch (parameter)
            {
                case "RadiusX":
                    return newWidth;
                case "RadiusY":
                    return newHeight;
                default:
                    return new Point(newWidth, newHeight);
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ProgressBarWaveValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is not double maximum) return 0;
            if (values[1] is not double proValue) return 0;
            var scale = 1 - proValue / maximum;
            var t = 200 - (-20);
            var y = t * scale + (-20);
            return y;

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
