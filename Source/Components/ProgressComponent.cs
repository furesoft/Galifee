using Avalonia.Controls;
using Galifrei.Core;
using Galifrei.Core.Interfaces;
using Galifrei.UI;
using System.Threading.Tasks;

namespace Galifrei.Components
{
    public class ProgressComponent : IVisualComponent, ISetupComponent
    {
        public Control GetVisualControl(SetupContext context)
        {
            return new ProgressUIPanel(context);
        }

        public Task OnInstall(SetupContext context)
        {
            return Task.Run(async () =>
            {
                for (int i = 0; i < 100; i++)
                {
                    context.CurrentProgress.Description = string.Format("Extracting File {0} of {1}", i, 100);
                    context.CurrentProgress.Step(i);
                    await Task.Delay(1000);
                }

                context.Pipeline.Install(context);
            });
        }

        public Task OnUninstall(SetupContext context)
        {
            return Task.Run(() =>
            {
                context.Pipeline.Uninstall(context);
            });
        }

        public Task OnUpgrade(SetupContext context)
        {
            return Task.Run(() =>
            {
                context.Pipeline.Upgrade(context);
            });
        }
    }
}