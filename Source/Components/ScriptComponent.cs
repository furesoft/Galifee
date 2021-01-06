using Galifee.Core;
using System.IO;
using System.Threading.Tasks;

namespace Galifee.Components
{
    public class ScriptComponent : ISetupComponent, IBeforeInstallEvent
    {
        public string Filename { get; set; }

        public Task BeforeInstall(SetupContext context)
        {
            JsEvaluator.Init();

            return Task.CompletedTask;
        }

        public Task BeforeUninstall(SetupContext context)
        {
            JsEvaluator.Init();

            context.TmpDir.GetFile(Filename);

            return Task.CompletedTask;
        }

        public Task OnInstall(SetupContext context)
        {
            return Task.CompletedTask;
        }

        public Task OnUninstall(SetupContext context)
        {
            return Task.CompletedTask;
        }
    }
}