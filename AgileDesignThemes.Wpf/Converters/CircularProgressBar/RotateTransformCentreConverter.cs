using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;


#region << 版 本 注 释 >>
/*----------------------------------------------------------------
// 文件名：RotateTransformCentreConverter
// 文件功能描述：
//
// 
// 创建者：xWang
// 时间：2021/6/9 16:12:22
//
// 修改人：
// 时间：
// 修改说明：
//----------------------------------------------------------------*/
#endregion

namespace AgileDesignThemes.Wpf.Converters.CircularProgressBar
{
    public class RotateTransformCentreConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //value == actual width
            return (double)value / 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
