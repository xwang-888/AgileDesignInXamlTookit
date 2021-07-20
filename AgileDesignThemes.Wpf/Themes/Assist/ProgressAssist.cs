using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace AgileDesignThemes.Wpf.Themes.Assist
{
    public class ProgressAssist
    {
        public static readonly DependencyProperty IndicatorValueVisibleProperty
            = DependencyProperty.RegisterAttached("IndicatorValueVisible", typeof(bool), typeof(ProgressAssist), new FrameworkPropertyMetadata(default(bool)));

        public static bool GetIndicatorValueVisible(DependencyObject element) => (bool)element.GetValue(IndicatorValueVisibleProperty);
        /// <summary>
        /// 是否显示进度值
        /// </summary>
        /// <param name="element"></param>
        /// <param name="isIndicatorVisible"></param>
        public static void SetIndicatorValueVisible(DependencyObject element, bool isIndicatorVisible) => element.SetValue(IndicatorValueVisibleProperty, isIndicatorVisible);
    }
}
