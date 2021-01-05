using Avalonia.Controls;
using Galifee.Core;

namespace Galifee.Components
{
    public class DownloaderComponent : ISetupComponent
    {
        public string Filename { get; set; }

        public void AfterInstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public void AfterUninstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public void BeforeInstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public void BeforeUninstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public Control GetVisualControl(SetupContext context)
        {
            return new UI.DownloaderUIPanel(this);
        }
    }
}