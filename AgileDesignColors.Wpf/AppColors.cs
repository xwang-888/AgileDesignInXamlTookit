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

    public enum Theme
    {
        Dark,
        Light
    }

    public class AppColors : ResourceDictionary
    {
        private PrimaryColors _primaryColors;
        private ResourceDictionary _primaryColorsResourceDictionaryTemp;
        private ResourceDictionary _themeResourceDictionaryTemp;

        public PrimaryColors PrimaryColors
        {
            get => _primaryColors;
            set
            {
                if (_primaryColors == value) return;
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

        private Theme _theme;
        public Theme Theme
        {
            get => _theme;
            set
            {
                if (_theme == value) return;

                _theme = value;
                if (_themeResourceDictionaryTemp != null)
                    Application.Current.Resources.MergedDictionaries.Remove(_themeResourceDictionaryTemp);
                else if (Application.Current.Resources.MergedDictionaries.FirstOrDefault(a =>
                             a.Source?.AbsoluteUri.Contains("Themes/Recommended/State/AgileDesignTheme") == true) is
                { } res)
                    Application.Current.Resources.MergedDictionaries.Remove(res);
                _themeResourceDictionaryTemp = new ResourceDictionary()
                {
                    Source = new Uri($@"pack://application:,,,/AgileDesignColors.Wpf;component/Themes/Recommended/State/AgileDesignTheme.{value}.xaml")
                };
                Application.Current.Resources.MergedDictionaries.Add(_themeResourceDictionaryTemp);
            }
        }

        public static AppColors Instance = new();
    }
}