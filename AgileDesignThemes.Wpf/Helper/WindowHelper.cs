using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AgileDesignThemes.Wpf.Helper
{
    public class WindowHelper
    {
        /// <summary>
        ///     获取当前应用中处于激活的一个窗口
        /// </summary>
        /// <returns></returns>
        public static Window GetActiveWindow() => Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
    }
}
