using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileDesign.WpfDemo.Models;
using AgileDesign.WpfDemo.Views.Controls;

namespace AgileDesign.WpfDemo.Configuration
{
    public  class InitializeFactory
    {

        public static IEnumerable<T> Create<T>() where T : class
        {
            var type = typeof(T);
            IEnumerable<T> list = null;
            switch (type.Name)
            {
                case nameof(MenuItem):
                    list = (IEnumerable<T>)CreateMenuItem(); 
                    break;
            }

            return list;
        }

        private static IEnumerable<MenuItem> CreateMenuItem()
        {
            return new List<MenuItem>()
            {
                new(){Header = "Button",Icon ="Button" ,Content = new ButtonsUc()},
                new(){Header = "TextBox",Icon ="TextBox", Content = new TextBoxUc()},
                new(){Header = "ComboBox",Icon = "ChevronUpBox",Content = new ComboBoxUc()},
                new(){Header = "ProgressBar",Icon ="ProgressCheck", Content = new ProgressBarUc()},
                new(){Header = "Message", Icon = "Message",Content = new MessageUc()},
                new(){Header = "Label",Icon ="Label", Content = new LabelUc()},
                new(){Header = "CheckBox",Icon = "CheckBox",Content = new CheckBoxsUc()},
                new(){Header = "RadioButton",Icon = "RadioButtonChecked",Content = new RadioButtonUc()},
                new(){Header = "ToggleButton",Icon = "ToggleSwitch",Content = new ToggleButtonsUc()},
                new(){Header = "GroupBox", Icon = "Group",Content = new GroupBoxsUc()},
                new(){Header = "Slider",Icon = "AlphaSCircle",Content = new SliderUc()},
                new(){Header = "Theme", Icon = "Theme",Content = new ThemeUc()},
                new(){Header = "Drwaer",Icon = "Style",Content = new DrawerUc()},
                new(){Header = "ListBox",Icon = "ViewList",Content = null},
                new(){Header = "DataGrid",Icon = "TableLarge",Content = null},
                new(){Header = "TabControl",Icon = "Table",Content =new TabControlUC()},
                new(){Header = "TreeView",Icon = "FileTree",Content = null},
            };
        }
    }
}
