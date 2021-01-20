using Avalonia.Controls;
using Galifrei.Core;
using Galifrei.Core.Interfaces;

namespace Galifrei.Components
{
    public class DownloaderComponent : IVisualComponent
    {
        public string Filename { get; set; }

        public Control GetVisualControl(SetupContext context)
        {
            return new UI.DownloaderUIPanel(this);
        }
    }
}