using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using AgileDesignThemes.Wpf.Themes.Assist;

namespace AgileDesignThemes.Wpf
{
    public class AgileTabControl : TabControl
    {
        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register(
            "Type", typeof(TabControlType), typeof(AgileTabControl), new PropertyMetadata(default(TabControlType)));

        public TabControlType Type
        {
            get => (TabControlType)GetValue(TypeProperty);
            set => SetValue(TypeProperty, value);
        }
    }
    public enum TabControlType
    {
        Line,
        Card,
    }
}
