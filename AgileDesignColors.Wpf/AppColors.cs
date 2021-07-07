using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Markup;

[assembly: XmlnsDefinition("http://AppColors", "AgileDesignColors.Wpf")]
namespace AgileDesignColors.Wpf
{
    public enum PrimaryColors
    {
        Cyan,
        DaybreakBlue,
        DustRed,
        Lime,
        SunriseYellow,
        SunsetOrange,
        Volcano,
        CalendulaGold
    }
   
    public class AppColors
    {
        private ResourceDictionary _primaryColorsResourceDictionaryTemp;
        private bool isInited;
        private PrimaryColors _primaryColors;

        public PrimaryColors PrimaryColors
        {
            get => _primaryColors;
            set
            {
                if(_primaryColors!=value)
                {
                    _primaryColors = value;
                    if (_primaryColorsResourceDictionaryTemp != null)
                    {
                        Application.Current.Resources.MergedDictionaries.Remove(_primaryColorsResourceDictionaryTemp);
                    }
                    else if (Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source?.AbsoluteUri?.Contains(@"Themes/Recommended/Primary/AgileDesignColor") == true) is ResourceDictionary res)
                    {
                        Application.Current.Resources.MergedDictionaries.Remove(res);
                    }
                    _primaryColorsResourceDictionaryTemp = new ResourceDictionary()
                    {
                        Source = new Uri(
                                $@"pack://application:,,,/AgileDesignColors.Wpf;component/Themes/Recommended/Primary/AgileDesignColor.{value}.xaml")
                    };
                    Application.Current.Resources.MergedDictionaries.Add(_primaryColorsResourceDictionaryTemp);
                }
            }
        }

        private static AppColors _AppColors;
        public static AppColors Default => _AppColors ??= new AppColors();   

    }
}
