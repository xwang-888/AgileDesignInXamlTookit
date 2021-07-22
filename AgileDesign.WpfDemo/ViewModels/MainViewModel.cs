using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileDesign.WpfDemo.Configuration;
using AgileDesign.WpfDemo.Models;
using AgileDesign.WpfDemo.Views.Controls;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace AgileDesign.WpfDemo.ViewModels
{
    public class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {
            MenuItemList = new ObservableCollection<MenuItem>(InitializeFactory.Create<MenuItem>());
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
