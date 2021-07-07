using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace AgileDesignThemes.Wpf
{
    public class PackIconDataMarkup :MarkupExtension
    {
        private PackIconKind _packIconKind;
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return PackIcon._dataIndex.Value[PackIconKind];
        }

        [ConstructorArgument("PackIconKind")]
        public PackIconKind PackIconKind
        {
            get => this._packIconKind;
            set => this._packIconKind = value != null ? value : throw new ArgumentNullException(nameof(value));
        }
    }
}
