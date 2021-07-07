using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace AgileDesignThemes.Wpf
{
    public class Avatar : ContentControl
    {
        private static readonly Effect _effect = new DropShadowEffect
        {
            BlurRadius = 8, ShadowDepth = 1.5, Direction = 270, Color = Color.FromArgb(0xaa, 0, 0, 0), Opacity = .42,
            RenderingBias = RenderingBias.Performance
        };

        public static readonly DependencyProperty AvatarEffectProperty = DependencyProperty.Register(
            "AvatarEffect", typeof(Effect), typeof(Avatar), new PropertyMetadata(_effect));

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon", typeof(Brush), typeof(Avatar), new PropertyMetadata(null));

        public static readonly DependencyProperty DataProperty = DependencyProperty.Register(
            "Data", typeof(string), typeof(Avatar), new PropertyMetadata(null));

        static Avatar()
        {
            _effect.Freeze();
        }

        public Effect AvatarEffect
        {
            get => (Effect) GetValue(AvatarEffectProperty);
            set => SetValue(AvatarEffectProperty, value);
        }

        public Brush Icon
        {
            get => (Brush) GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public string Data
        {
            get => (string) GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }
    }
}