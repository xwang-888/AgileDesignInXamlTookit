using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileDesign.WpfDemo.Models;
using AgileDesign.WpfDemo.Views.Controls;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace AgileDesign.WpfDemo.ViewModels
{
    public class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {
            MenuItemList = new ObservableCollection<MenuItem>()
            {
                new(){Header = "Theme", Content = new ThemeUc()},
                new(){Header = "Button", Content = new ButtonsUc()},
                new(){Header = "TextBox", Content = new TextBoxUc()},
                new(){Header = "ProgressBar", Content = new ProgressBarUc()},
                new(){Header = "ToggleButton", Content = new ToggleButtonsUc()},
                new(){Header = "GroupBox", Content = new GroupBoxsUc()},
                new(){Header = "Drwaer", Content = new DrawerUc()}
            };
            SelectedMenuItem = MenuItemList.First();
        }

        private ObservableCollection<MenuItem> _menuItemList;
        private MenuItem _selectedMenuItem;

        public ObservableCollection<MenuItem> MenuItemList
        {
            get => _menuItemList;
            set { _menuItemList = value; OnPropertyChanged(); }
        }
        public MenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                _selectedMenuItem = value;
                OnPropertyChanged();
            }
        }

    }
}
