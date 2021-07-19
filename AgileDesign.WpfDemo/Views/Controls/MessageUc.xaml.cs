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
using AgileDesign.WpfDemo.Views.Window;
using AgileDesignThemes.Wpf;
using AgileDesignThemes.Wpf.Enums;

namespace AgileDesign.WpfDemo.Views.Controls
{
    /// <summary>
    /// MessageUc.xaml 的交互逻辑
    /// </summary>
    public partial class MessageUc : UserControl
    {
        public MessageUc()
        {
            InitializeComponent();
        }

        private void OpenWindow_OnClick(object sender, RoutedEventArgs e)
        {
            var main = new MessageWindow(){Width = 500, Height = 500};
            main.Show();
        }
        private void OpenDialogWindow_OnClick(object sender, RoutedEventArgs e)
        {
            var main = new MessageWindow() { Width = 500, Height = 500 };
            main.ShowDialog();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Info("This is a normal message.");
        }
        private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Error("This is a Error message.");
        }
        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Success("This is a Success message.");
        }
        private void ButtonBase3_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Warning("This is a Warning message.");
        }
    }
}
