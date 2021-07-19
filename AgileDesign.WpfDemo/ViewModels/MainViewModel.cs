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
                new(){Header = "Button",Icon ="Button" ,Content = new ButtonsUc()},
                new(){Header = "TextBox",Icon ="TextBox", Content = new TextBoxUc()},
                new(){Header = "Label",Icon ="Label", Content = new LabelUc()},
                new(){Header = "ProgressBar",Icon ="ProgressCheck", Content = new ProgressBarUc()},
                new(){Header = "ToggleButton",Icon = "ToggleSwitch",Content = new ToggleButtonsUc()},
                new(){Header = "CheckBox",Icon = "CheckBox",Content = new CheckBoxsUc()},
                new(){Header = "RadioButton",Icon = "RadioButtonChecked",Content = new RadioButtonUc()},
                new(){Header = "GroupBox", Icon = "Group",Content = new GroupBoxsUc()},
                new(){Header = "Message", Icon = "Message",Content = new MessageUc()},
                new(){Header = "Theme", Icon = "Theme",Content = new ThemeUc()},
                new(){Header = "Drwaer",Icon = "Style",Content = new DrawerUc()},
                new(){Header = "ComboBox",Icon = "ChevronUpBox",Content = null},
                new(){Header = "ListBox",Icon = "ViewList",Content = null},
                new(){Header = "DataGrid",Icon = "TableLarge",Content = null},
                new(){Header = "TableControl",Icon = "Table",Content =null},
                new(){Header = "TreeView",Icon = "FileTree",Content = null},
                new(){Header = "Slider",Icon = "AlphaSCircle",Content = new SliderUc()},
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
