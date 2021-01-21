using Galifrei.Core;
using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;
using System.IO;
using System.Threading.Tasks;

namespace Galifrei.Components
{
    public class CreateDesktopLinkAction : ISetupComponent
    {
        public CreateDesktopLinkAction(string path, string exec)
        {
            Exec = exec;
            Path = path;
        }

        public string Exec { get; }
        public string Path { get; }

        public Task OnInstall(SetupContext context)
        {
            var linkCreator = Platform.New<IDesktopLink>();

            linkCreator.CreateDesktopLink(context, System.IO.Path.Combine(
                context.Properties.Bind(Path),
                GetLinkFilename(context))
            , Exec);

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
            return context.Properties[NamingConstants.AppName] + "." + context.Paths.DefaultLinkExtension;
        }
    }
}