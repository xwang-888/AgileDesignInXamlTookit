using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AgileDesignThemes.Wpf
{
    public class Drawer : ContentControl
    {
        public static bool GetIsSwitchButton(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsSwitchButtonProperty);
        }

        public static void SetIsSwitchButton(DependencyObject obj, bool value)
        {
            obj.SetValue(IsSwitchButtonProperty, value);
        }

        private Button _ChileButton;

        /// <param name="obj">要找的是obj的父控件</param>
        /// <param name="name">想找的父控件的Name属性</param>
        /// <returns>目标父控件</returns>
        public static T GetParentObject<T>(DependencyObject obj, string name) where T : FrameworkElement
        {
            DependencyObject parent = VisualTreeHelper.GetParent(obj);

            while (parent != null)
            {
                if (parent is T && (((T)parent).Name == name | string.IsNullOrEmpty(name)))
                {
                    return (T)parent;
                }

                // 在上一级父控件中没有找到指定名字的控件，就再往上一级找
                parent = VisualTreeHelper.GetParent(parent);
            }

            return null;
        }

        public static readonly DependencyProperty IsSwitchButtonProperty =
            DependencyProperty.RegisterAttached("IsSwitchButton", typeof(bool), typeof(Drawer), new PropertyMetadata(false, (d, p) =>
            {
                if (d is Button button)
                {
                    if (button.IsLoaded)
                    {
                        if (Drawer.GetParentObject<Drawer>((DependencyObject)button, null) is Drawer drawer)
                        {
                            if (p.NewValue is bool ret)
                            {
                                drawer.SetSwitchButto(button, ret);
                            }
                        }
                    }
                    else
                    {
                        button.Loaded += Button_Loaded;
                        void Button_Loaded(object sender, RoutedEventArgs e)
                        {
                            if (Drawer.GetParentObject<Drawer>((DependencyObject)button, null) is Drawer drawer)
                            {
                                if (p.NewValue is bool ret)
                                {
                                    drawer.SetSwitchButto(button, ret);
                                }
                            }
                            button.Loaded -= Button_Loaded;
                        }
                    }

                }
            }));


        public void SetSwitchButto(Button button, bool isSwitchButton)
        {
            button.Click += SwitchButton_Click;
        }

        private void SwitchButton_Click(object sender, RoutedEventArgs e)
        {
            if (_isOpen)
            {
                CloseDrawerAnimation();
            }
            else
            {
                OpenDrawerAnimation();
            }
        }

        protected bool _isOpen = true;
        private double _widthTemp, HeightTemp;
        public virtual void OpenDrawerAnimation()
        {
            var animation = new DoubleAnimation(_widthTemp, new Duration(TimeSpan.FromMilliseconds(200)))
            {
                EasingFunction = new PowerEase { EasingMode = EasingMode.EaseInOut }
            };
            BeginAnimation(ContentControl.WidthProperty, animation);
            _isOpen = true;
        }

        public virtual void CloseDrawerAnimation()
        {
            var minWidth = double.IsNaN(MinWidth) ? ActualWidth / 2d : MinWidth;
            _widthTemp = ActualWidth;
            var animation = new DoubleAnimation(_widthTemp, minWidth, new Duration(TimeSpan.FromMilliseconds(200)))
            {
                EasingFunction = new PowerEase { EasingMode = EasingMode.EaseInOut }
            };
            BeginAnimation(ContentControl.WidthProperty, animation);
            _isOpen = false;
        }



        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(Drawer), new PropertyMetadata(true, (d, p) =>
            {
                if (d is Drawer drawer)
                {
                    if (drawer.IsOpen)
                    {
                        drawer.OpenDrawerAnimation();
                    }
                    else
                    {
                        drawer.CloseDrawerAnimation();
                    }
                }
            }));


    }
}
