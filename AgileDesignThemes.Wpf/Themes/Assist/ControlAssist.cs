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



        public static readonly DependencyProperty IconProperty = DependencyProperty.RegisterAttached(
            "Icon", typeof(PackIconKind), typeof(ControlAssist), new PropertyMetadata(default));
        public static readonly DependencyProperty IconGeometryProperty = DependencyProperty.RegisterAttached(
            "IconGeometry", typeof(string), typeof(ControlAssist), new PropertyMetadata(null));
        /// <summary>
        /// 设置控件的Icon图标
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SetIconGeometry(DependencyObject element, string value) => element.SetValue(IconGeometryProperty, value);
        public static string GetIconGeometry(DependencyObject element) => (string)element.GetValue(IconGeometryProperty);
        /// <summary>
        /// 设置控件的Icon图标
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SetIcon(DependencyObject element, PackIconKind value) => element.SetValue(IconProperty, value);


        public static PackIconKind GetIcon(DependencyObject element) => (PackIconKind)element.GetValue(IconProperty);

        public static readonly DependencyProperty HintTextProperty = DependencyProperty.RegisterAttached(
            "HintText", typeof(string), typeof(ControlAssist), new PropertyMetadata(default(string)));
        public static string GetHintText(DependencyObject element) => (string)element.GetValue(HintTextProperty);
        /// <summary>
        /// 设置控件的提示文字
        /// </summary>
        public static void SetHintText(DependencyObject element, string value) => element.SetValue(HintTextProperty, value);

        #region Header
        public static readonly DependencyProperty HeaderHorizontalAlignmentProperty = DependencyProperty.RegisterAttached("HeaderHorizontalAlignment", typeof(HorizontalAlignment), typeof(ControlAssist), new PropertyMetadata(HorizontalAlignment.Center));

        public static readonly DependencyProperty HeaderVerticalAlignmentProperty = DependencyProperty.RegisterAttached("HeaderVerticalAlignment", typeof(VerticalAlignment), typeof(ControlAssist), new PropertyMetadata(VerticalAlignment.Center));

        /// <summary>
        /// 设置Header的水平轴
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SetHeaderHorizontalAlignment(DependencyObject element, HorizontalAlignment value) =>
            element.SetValue(HeaderHorizontalAlignmentProperty, value);
        public static HorizontalAlignment GetHeaderHorizontalAlignment(DependencyObject element) =>
            (HorizontalAlignment)element.GetValue(HeaderHorizontalAlignmentProperty);
        /// <summary>
        /// 设置Header的垂直轴
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SetHeaderVerticalAlignment(DependencyObject element, VerticalAlignment value) =>
            element.SetValue(HeaderVerticalAlignmentProperty, value);
        public static VerticalAlignment GetHeaderVerticalAlignment(DependencyObject element) =>
            (VerticalAlignment)element.GetValue(HeaderHorizontalAlignmentProperty);
        #endregion

    }

}
