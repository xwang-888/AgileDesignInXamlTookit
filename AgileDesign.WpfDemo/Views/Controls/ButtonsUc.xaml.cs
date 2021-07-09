using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AgileDesign.WpfDemo.ViewModels;
using AgileDesignColors.Wpf;

namespace AgileDesign.WpfDemo.Views.Controls
{
    /// <summary>
    /// ButtonsUc.xaml 的交互逻辑
    /// </summary>
    public partial class ButtonsUc : UserControl
    {
        public ButtonsUc()
        {
            InitializeComponent();
            this.DataContext = new ButtonsUcViewModel();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.CalendulaGold;
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.Cyan;
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            AppColors.Instance.PrimaryColors = PrimaryColors.DaybreakBlue;
        }
    }
}
