using Avalonia.Controls;
using Galifee.Core;
using System.Threading.Tasks;

namespace Galifee.Components
{
    public class DownloaderComponent : ISetupComponent, IVisualComponent
    {
        public string Filename { get; set; }

        public Task AfterInstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task AfterUninstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task BeforeInstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task BeforeUninstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public Control GetVisualControl(SetupContext context)
        {
            return new UI.DownloaderUIPanel(this);
        }
    }
}