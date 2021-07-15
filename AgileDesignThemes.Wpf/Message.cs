using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using AgileDesignThemes.Wpf.Enums;

namespace AgileDesignThemes.Wpf
{
    /// <summary>
    /// 全局消息通知
    /// </summary>
    public class Message : ContentControl
    {

        private static readonly double DefaultSeconds = 5.0;

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text", typeof(string), typeof(Message), new PropertyMetadata(default(string)));
        /// <summary>
        /// 显示的文本
        /// </summary>
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty MessageTypeProperty = DependencyProperty.Register(
            "MessageType", typeof(MessageType), typeof(Message), new PropertyMetadata(default(MessageType)));
        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType MessageType
        {
            get => (MessageType)GetValue(MessageTypeProperty);
            set => SetValue(MessageTypeProperty, value);
        }

        public static readonly DependencyProperty SecondsProperty = DependencyProperty.Register(
            "Seconds", typeof(double), typeof(Message), new PropertyMetadata(DefaultSeconds));
        /// <summary>
        /// 持续时间
        /// </summary>
        public double Seconds
        {
            get => (double)GetValue(SecondsProperty);
            set => SetValue(SecondsProperty, value);
        }
    }

   

}
