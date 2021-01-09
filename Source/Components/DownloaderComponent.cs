using Avalonia.Controls;
using Galifee.Core;
using Galifee.Core.Interfaces;
using System.Threading.Tasks;

namespace Galifee.Components
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