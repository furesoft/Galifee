using Avalonia.Markup.Xaml;
using System;

namespace Galifee.Core.I18N
{
    public class LanguageNames : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return LanguageManager.Instance.GetNames();
        }
    }
}