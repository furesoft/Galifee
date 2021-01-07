using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Galifee.Components;

namespace Galifee.UI
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