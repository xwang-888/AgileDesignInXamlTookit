using System;
using System.Windows.Markup;

namespace AgileDesignThemes.Wpf
{
    public class PackIconDataMarkup : MarkupExtension
    {
        public PackIconDataMarkup()
        {
        }

        public PackIconDataMarkup(PackIconKind packIconKind)
        {
            PackIconKind = packIconKind;
        }

        [ConstructorArgument("PackIconKind")]
        public PackIconKind PackIconKind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return PackIcon._dataIndex.Value[PackIconKind];
        }
    }
}