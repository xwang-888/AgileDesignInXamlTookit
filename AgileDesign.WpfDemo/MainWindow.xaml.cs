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

namespace AgileDesign.WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source.AbsoluteUri
                .Contains(@"Themes/Recommended/Primary/AgileDesignColor")) is ResourceDictionary res)
            {
                Application.Current.Resources.MergedDictionaries.Remove(res);
                res = new ResourceDictionary(){Source =  new Uri(@"pack://application:,,,/AgileDesignColors.Wpf;component/Themes/Recommended/Primary/AgileDesignColor.Lime.xaml") };
                Application.Current.Resources.MergedDictionaries.Add(res);
            }
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source.AbsoluteUri
                .Contains(@"Themes/Recommended/Primary/AgileDesignColor")) is ResourceDictionary res)
            {
                Application.Current.Resources.MergedDictionaries.Remove(res);
                res = new ResourceDictionary() { Source = new Uri(@"pack://application:,,,/AgileDesignColors.Wpf;component/Themes/Recommended/Primary/AgileDesignColor.Volcano.xaml") };
                Application.Current.Resources.MergedDictionaries.Add(res);
            }
        }
    }
}
