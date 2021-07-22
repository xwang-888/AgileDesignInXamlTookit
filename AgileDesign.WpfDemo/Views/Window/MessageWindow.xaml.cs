using System.Windows;
using AgileDesign.WpfDemo.ViewModels;
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
            this.DataContext = new MessageUcViewModel();
        }
    }
}
