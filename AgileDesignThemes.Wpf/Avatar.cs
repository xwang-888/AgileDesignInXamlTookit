using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace AgileDesignThemes.Wpf
{
    public class Avatar : ContentControl
    {
        static Avatar()
        {
            _effect.Freeze();
        }

        private static Effect _effect = new DropShadowEffect() { BlurRadius = 8, ShadowDepth = 1.5, Direction = 270, Color = Color.FromArgb(0xaa, 0, 0, 0), Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static readonly DependencyProperty AvatarEffectProperty = DependencyProperty.Register(
            "AvatarEffect", typeof(Effect), typeof(Avatar), new PropertyMetadata(_effect));

        public Effect AvatarEffect
        {
            get { return (Effect)GetValue(AvatarEffectProperty); }
            set { SetValue(AvatarEffectProperty, value); }
        }

        public static readonly DependencyProperty IConProperty = DependencyProperty.Register(
            "ICon", typeof(Brush), typeof(Avatar), new PropertyMetadata(null));

        public Brush ICon
        {
            get { return (Brush) GetValue(IConProperty); }
            set { SetValue(IConProperty, value); }
        }

        public static readonly DependencyProperty DataProperty = DependencyProperty.Register(
            "Data", typeof(string), typeof(Avatar), new PropertyMetadata(null));

        public string Data
        {
            get { return (string) GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }
    }
}
