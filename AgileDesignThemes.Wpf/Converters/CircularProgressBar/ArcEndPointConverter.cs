using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

#region << 版 本 注 释 >>
/*----------------------------------------------------------------
// 文件名：ArcEndPointConverter
// 文件功能描述：
//
// 
// 创建者：xWang
// 时间：2021/6/9 16:11:13
//
// 修改人：
// 时间：
// 修改说明：
//----------------------------------------------------------------*/
#endregion

namespace AgileDesignThemes.Wpf.Converters.CircularProgressBar
{
    public class ArcEndPointConverter : IMultiValueConverter
    {
        /// <summary>
        /// CircularProgressBar draws two arcs to support a full circle at 100 %.
        /// With one arc at 100 % the start point is identical the end point, so nothing is drawn.
        /// Midpoint at half of current percentage is the endpoint of the first arc
        /// and the start point of the second arc.
        /// </summary>
        public const string ParameterMidPoint = "MidPoint";

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = values[0].ExtractDouble();
            var value = values[1].ExtractDouble();
            var minimum = values[2].ExtractDouble();
            var maximum = values[3].ExtractDouble();

            if (new[] { actualWidth, value, minimum, maximum }.AnyNan())
                return Binding.DoNothing;

            if (values.Length == 5)
            {
                var fullIndeterminateScaling = values[4].ExtractDouble();
                if (!double.IsNaN(fullIndeterminateScaling) && fullIndeterminateScaling > 0.0)
                {
                    value = (maximum - minimum) * fullIndeterminateScaling;
                }
            }

            var percent = maximum <= minimum ? 1.0 : (value - minimum) / (maximum - minimum);
            if (Equals(parameter, ParameterMidPoint))
                percent /= 2;

            var degrees = 360 * percent;
            var radians = degrees * (Math.PI / 180);

            var centre = new Point(actualWidth / 2, actualWidth / 2);
            var hypotenuseRadius = (actualWidth / 2);

            var adjacent = Math.Cos(radians) * hypotenuseRadius;
            var opposite = Math.Sin(radians) * hypotenuseRadius;

            return new Point(centre.X + opposite, centre.Y - adjacent);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
