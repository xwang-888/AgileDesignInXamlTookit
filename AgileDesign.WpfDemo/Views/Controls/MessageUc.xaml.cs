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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Show(new MessageInfo(){Message = "This is a normal message.", MessageType =  MessageType.Info, Time = 3,Token = "Hello"});
        }

        private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Show(new MessageInfo() { Message = "This is a Error Message.", MessageType = MessageType.Error, Time = 3, Token = "Hello" });

        }
        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Show(new MessageInfo() { Message = "This is a Error Success.", MessageType = MessageType.Success, Time = 3, Token = "Hello" });

        }
        private void ButtonBase3_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Show(new MessageInfo() { Message = "This is a Error Warning.", MessageType = MessageType.Warning, Time = 3, Token = "Hello" });

        }
    }
}
