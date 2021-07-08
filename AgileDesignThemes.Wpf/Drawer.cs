using System.Windows;
using System.Windows.Controls;

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

        public static readonly DependencyProperty IsSwitchButtonProperty =
            DependencyProperty.RegisterAttached("IsSwitchButton", typeof(bool), typeof(Drawer), new PropertyMetadata(false,(d,p)=> {
                if(d is Button button)
                {
                    if(p.NewValue is bool ret)
                    {
                        if(ret)
                        {
                            button.Click += SwitchButton_Click;
                        }
                        else
                        {

                        }
                    }
                }
            }));

        private static void SwitchButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
