using System;
using System.Linq;
using System.Windows;

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
        private PrimaryColors _primaryColors;
        private ResourceDictionary _primaryColorsResourceDictionaryTemp;

        public PrimaryColors PrimaryColors
        {
            get => _primaryColors;
            set
            {
                if (_primaryColors != value)
                {
                    _primaryColors = value;
                    if (_primaryColorsResourceDictionaryTemp != null)
                        Application.Current.Resources.MergedDictionaries.Remove(_primaryColorsResourceDictionaryTemp);
                    else if (Application.Current.Resources.MergedDictionaries.FirstOrDefault(x =>
                            x.Source?.AbsoluteUri?.Contains(@"Themes/Recommended/Primary/AgileDesignColor") == true) is
                        { } res) Application.Current.Resources.MergedDictionaries.Remove(res);
                    _primaryColorsResourceDictionaryTemp = new ResourceDictionary
                    {
                        Source = new Uri(
                            $@"pack://application:,,,/AgileDesignColors.Wpf;component/Themes/Recommended/Primary/AgileDesignColor.{value}.xaml")
                    };
                    Application.Current.Resources.MergedDictionaries.Add(_primaryColorsResourceDictionaryTemp);
                }
            }
        }

        public static AppColors Instance = new();
    }
}