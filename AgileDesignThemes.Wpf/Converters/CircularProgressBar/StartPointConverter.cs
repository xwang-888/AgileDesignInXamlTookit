using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;


#region << 版 本 注 释 >>
/*----------------------------------------------------------------
// 文件名：StartPointConverter
// 文件功能描述：
//
// 
// 创建者：xWang
// 时间：2021/6/9 16:12:41
//
// 修改人：
// 时间：
// 修改说明：
//----------------------------------------------------------------*/
#endregion

namespace AgileDesignThemes.Wpf.Converters.CircularProgressBar
{
    public class StartPointConverter : IValueConverter
    {
        [Obsolete]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double && ((double)value > 0.0))
            {
                return new Point((double)value / 2, 0);
            }

            return new Point();
        }

        [Obsolete]
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }

    }
}
