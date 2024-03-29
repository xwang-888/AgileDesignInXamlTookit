﻿using System;
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
            this.DataContext = new MessageUcViewModel();
        }
    }
}
