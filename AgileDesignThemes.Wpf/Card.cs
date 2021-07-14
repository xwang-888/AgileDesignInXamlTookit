using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using AgileDesignThemes.Wpf.Enums;

namespace AgileDesignThemes.Wpf
{
    /// <summary>
    /// 卡片
    /// </summary>
    public class Card : ContentControl
    {
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius", typeof(CornerRadius), typeof(Card), new PropertyMetadata(default(CornerRadius)));
        /// <summary>
        /// 圆角
        /// </summary>
        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        public static readonly DependencyProperty ShadowDepthProperty = DependencyProperty.Register(
            "ShadowDepth", typeof(ShadowDepth), typeof(Card), new PropertyMetadata(default(ShadowDepth)));
        /// <summary>
        /// 阴影
        /// </summary>
        public ShadowDepth ShadowDepth
        {
            get => (ShadowDepth)GetValue(ShadowDepthProperty);
            set => SetValue(ShadowDepthProperty, value);
        }


    }
}
