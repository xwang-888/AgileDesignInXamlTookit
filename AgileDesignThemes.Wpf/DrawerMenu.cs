using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AgileDesignThemes.Wpf
{
    public class DrawerMenu : Drawer
    {

        private static readonly double DefaultOpenPanelWidth = 200.0;
        private static readonly double DefaultCompactPanelWidth = 48.0;


        public static readonly DependencyProperty CompactPanelWidthProperty = DependencyProperty.Register(
            "CompactPanelWidth", typeof(double), typeof(DrawerMenu), new PropertyMetadata(DefaultCompactPanelWidth));
        /// <summary>
        /// 小导航栏的宽度
        /// </summary>
        public double CompactPanelWidth
        {
            get => (double)GetValue(CompactPanelWidthProperty);
            set => SetValue(CompactPanelWidthProperty, value);
        }
        public static readonly DependencyProperty OpenPanelWidthProperty = DependencyProperty.Register(
            "OpenPanelWidth", typeof(double), typeof(DrawerMenu), new PropertyMetadata(DefaultOpenPanelWidth));
        /// <summary>
        /// 导航栏打开的宽度
        /// </summary>
        public double OpenPanelWidth
        {
            get => (double)GetValue(OpenPanelWidthProperty);
            set => SetValue(OpenPanelWidthProperty, value);
        }

        public static readonly DependencyProperty DrawerMenuDisplayModelProperty = DependencyProperty.Register(
            "DrawerMenuDisplayModel", typeof(DrawerMenuDisplayModel), typeof(DrawerMenu), new PropertyMetadata(default(DrawerMenuDisplayModel)));

        public DrawerMenuDisplayModel DisplayModel
        {
            get => (DrawerMenuDisplayModel)GetValue(DrawerMenuDisplayModelProperty);
            set => SetValue(DrawerMenuDisplayModelProperty, value);
        }

        public override void OpenDrawerAnimation()
        {
            var animation = new DoubleAnimation(OpenPanelWidth, new Duration(TimeSpan.FromMilliseconds(200)))
            {
                EasingFunction = new PowerEase { EasingMode = EasingMode.EaseInOut }
            };
            BeginAnimation(ContentControl.WidthProperty, animation);
            base._isOpen = true;
        }
        public override void CloseDrawerAnimation()
        {
            var animation = new DoubleAnimation(OpenPanelWidth, CompactPanelWidth, new Duration(TimeSpan.FromMilliseconds(200)))
            {
                EasingFunction = new PowerEase { EasingMode = EasingMode.EaseInOut }
            };
            BeginAnimation(ContentControl.WidthProperty, animation);
            base._isOpen = false;
        }

    }

    public enum DrawerMenuDisplayModel
    {
        CompactInline,
        CompactOverlay,

    }
}
