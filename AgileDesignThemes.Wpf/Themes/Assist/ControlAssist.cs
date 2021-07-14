using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using AgileDesignThemes.Wpf.Enums;

namespace AgileDesignThemes.Wpf.Themes.Assist
{
    public static class ControlAssist
    {
        private static readonly CornerRadius DefaultCornerRadius = new(2);

        #region 控制控件的圆角半径。
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
          "CornerRadius", typeof(CornerRadius), typeof(ControlAssist), new PropertyMetadata(DefaultCornerRadius));
        public static CornerRadius GetCornerRadius(DependencyObject element) => (CornerRadius)element.GetValue(CornerRadiusProperty);
        /// <summary>
        /// 控制控件的圆角半径
        /// Controls the corner radius of the surrounding box.
        /// </summary>
        public static void SetCornerRadius(DependencyObject element, CornerRadius value) => element.SetValue(CornerRadiusProperty, value);
        #endregion
        #region 控制控件的阴影。
        public static readonly DependencyProperty ShadowDepthProperty = DependencyProperty.RegisterAttached(
            "ShadowDepth", typeof(ShadowDepth), typeof(ControlAssist), new PropertyMetadata(ShadowDepth.Depth0));
        public static ShadowDepth GetShadowDepth(DependencyObject element) => (ShadowDepth)element.GetValue(ShadowDepthProperty);
        /// <summary>
        /// 控制控件的阴影
        /// </summary>
        public static void SetShadowDepth(DependencyObject element, ShadowDepth value) => element.SetValue(ShadowDepthProperty, value);
        #endregion



        public static readonly DependencyProperty IconGeometryProperty = DependencyProperty.RegisterAttached(
            "IconGeometry", typeof(string), typeof(ControlAssist), new PropertyMetadata(null));
        public static string GetIconGeometry(DependencyObject element) => (string)element.GetValue(IconGeometryProperty);
        /// <summary>
        /// 设置控件的Icon图标
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SetIconGeometry(DependencyObject element, string value) => element.SetValue(IconGeometryProperty, value);

        public static readonly DependencyProperty HintTextProperty = DependencyProperty.RegisterAttached(
            "HintText", typeof(string), typeof(ControlAssist), new PropertyMetadata(default(string)));
        public static string GetHintText(DependencyObject element) => (string)element.GetValue(HintTextProperty);
        /// <summary>
        /// 设置控件的提示文字
        /// </summary>
        public static void SetHintText(DependencyObject element, string value) => element.SetValue(HintTextProperty, value);

    }
   
}
