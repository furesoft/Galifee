using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Galifrei.Components;

namespace Galifrei.UI
{
    public class DownloaderUIPanel : UserControl
    {
        public DownloaderUIPanel(DownloaderComponent downloaderComponent)
        {
            this.InitializeComponent();
            DownloaderComponent = downloaderComponent;
        }

        public DownloaderUIPanel()
        {
        }

        public DownloaderComponent DownloaderComponent { get; }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}