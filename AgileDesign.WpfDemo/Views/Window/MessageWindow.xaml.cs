using System.Windows;
using AgileDesignThemes.Wpf;
using AgileDesignThemes.Wpf.Enums;

namespace AgileDesign.WpfDemo.Views.Window
{
    /// <summary>
    /// MessageWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MessageWindow : System.Windows.Window
    {
        public MessageWindow()
        {
            InitializeComponent();
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
