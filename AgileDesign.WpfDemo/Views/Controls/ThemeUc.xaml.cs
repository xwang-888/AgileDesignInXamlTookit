using AgileDesignColors.Wpf;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgileDesign.WpfDemo.Views.Controls
{
    /// <summary>
    /// ThemeUc.xaml 的交互逻辑
    /// </summary>
    public partial class ThemeUc : UserControl
    {
        public ThemeUc()
        {
            InitializeComponent();
        }

        private void CalendulaGoldButton_Click(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.CalendulaGold;
        }
        private void CyanButton_Click(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.Cyan;
        }
        private void SunriseYellowButton_Click(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.SunriseYellow;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var btn = sender as ToggleButton;
            if (btn.IsChecked == true)
                AppColors.Instance.Theme = Theme.Dark;
            else
                AppColors.Instance.Theme = Theme.Light;
        }

        private void LimeButton_Click(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.Lime;
        }
        private void SunsetOrangeButton_Click(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.SunsetOrange;
        }
        private void VolcanoButton_Click(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.Volcano;
        }
        private void DustRedButton_Click(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.DustRed;
        }
        private void DaybreakBlueButton_Click(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.DaybreakBlue;
        }
    }
}
