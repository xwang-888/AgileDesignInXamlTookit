using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AgileDesignThemes.Wpf.Themes.Assist
{
    public class ToggleButtonAssist
    {
        public static readonly DependencyProperty OnContentProperty = DependencyProperty.RegisterAttached(
            "OnContent", typeof(object), typeof(ToggleButtonAssist), new PropertyMetadata(null));
        public static object GetOnContent(DependencyObject element) => (object)element.GetValue(OnContentProperty);
        /// <summary>
        /// 设置ToggleButton IsChecked=true的时候的显示文字
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SetOnContent(DependencyObject element, object value) => element.SetValue(OnContentProperty, value);
    }
}
