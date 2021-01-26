using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Galifrei.Core;

namespace Galifrei.UI
{
    public class ProgressUIPanel : UserControl
    {
        public ProgressUIPanel(SetupContext context)
        {
            DataContext = context.CurrentProgress;
        }

        public ProgressUIPanel()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}