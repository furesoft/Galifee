using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Galifee.Core.I18N;

namespace Galifee.UI.Windows
{
    public class LanguageSelectorWindow : Window
    {
        public LanguageSelectorWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}