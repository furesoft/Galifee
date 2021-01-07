using Galifee.Core;
using Galifee.Core.Interfaces;
using Galifee.Core.Platforming;
using GaliFee.Core.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Galifee.Components
{
    public class CreateDesktopLinkAction : ISetupComponent
    {
        public Task OnInstall(SetupContext context)
        {
            var linkCreator = Platform.New<IDesktopLink>();

            linkCreator.CreateDesktopLink(context, GetLinkFilename(context));

            return Task.CompletedTask;
        }

        public Task OnUninstall(SetupContext context)
        {
            File.Delete(GetLinkFilename(context));

            return Task.CompletedTask;
        }

        public async Task OnUpgrade(SetupContext context)
        {
            await OnUninstall(context);
            await OnInstall(context);
        }

        private string GetLinkFilename(SetupContext context)
        {
            var name = context.Properties[NamingConstants.AppName] + "." + context.Paths.DefaultLinkExtension;

            return Path.Combine(context.Paths.DesktopPath, name);
        }
    }
}