using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region << 版 本 注 释 >>
/*----------------------------------------------------------------
// 文件名：LocalEx
// 文件功能描述：
//
// 
// 创建者：xWang
// 时间：2021/6/9 16:11:43
//
// 修改人：
// 时间：
// 修改说明：
//----------------------------------------------------------------*/
#endregion

namespace AgileDesignThemes.Wpf.Converters.CircularProgressBar
{
    internal static class LocalEx
    {
        public static double ExtractDouble(this object val)
        {
            var d = val as double? ?? double.NaN;
            return double.IsInfinity(d) ? double.NaN : d;
        }


        public static bool AnyNan(this IEnumerable<double> vals)
        {
            return vals.Any(double.IsNaN);
        }
    }
}
