using System;
using System.Windows.Markup;

namespace AgileDesignThemes.Wpf
{
    /// <summary>
    /// PackIcon Markup
    /// </summary>
    /// <remarks><b>Demo:</b> <i>Content = "{packIcon:PackIconExtension Kind = {x:static packIcon:PackIconKind.Abacus}}"</i></remarks>
    public class PackIconExtension : MarkupExtension
    {
        public PackIconExtension()
        {
        }

        public PackIconExtension(PackIconKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")]
        public PackIconKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new PackIcon() { Kind = Kind };
        }
    }
}