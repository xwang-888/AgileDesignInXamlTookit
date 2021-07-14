using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;
using AgileDesignThemes.Wpf.Enums;

namespace AgileDesignThemes.Wpf.Converters
{
    internal static class ShadowInfo
    {
        private static readonly IDictionary<ShadowDepth, DropShadowEffect?> ShadowEffectDictionary;

        static ShadowInfo()
        {
            var shadowEffectResource = new ResourceDictionary { Source = new Uri("pack://application:,,,/AgileDesignThemes.Wpf;component/Themes/ControlThemes/AgileDesignTheme.Shadows.xaml", UriKind.Absolute) };
            ShadowEffectDictionary = new Dictionary<ShadowDepth, DropShadowEffect?>
            {
                {ShadowDepth.Depth0,null},
                {ShadowDepth.Depth1,(DropShadowEffect)shadowEffectResource["EffectShadow1"]},
                {ShadowDepth.Depth2,(DropShadowEffect)shadowEffectResource["EffectShadow2"]},
                {ShadowDepth.Depth3,(DropShadowEffect)shadowEffectResource["EffectShadow3"]},
                {ShadowDepth.Depth4,(DropShadowEffect)shadowEffectResource["EffectShadow4"]},
                {ShadowDepth.Depth5,(DropShadowEffect)shadowEffectResource["EffectShadow5"]},
            };
        }
        
        public static DropShadowEffect? GetDropShadowEffect(ShadowDepth shadowDepth) => ShadowEffectDictionary[shadowDepth];

    }
}
