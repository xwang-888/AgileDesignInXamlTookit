using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AgileDesignThemes.Wpf.Panels
{
    public class HeaderSimpleItemsControl : SimpleItemsControl
    {
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            "Header", typeof(object), typeof(HeaderSimpleItemsControl), new PropertyMetadata(default(object)));
        /// <summary>
        /// header
        /// </summary>
        public object Header
        {
            get => (object)GetValue(HeaderProperty);
            set => SetValue(HeaderProperty, value);
        }
    }
}
