using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
