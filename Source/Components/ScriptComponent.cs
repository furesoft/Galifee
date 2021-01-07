using GaliFee.Core;
using GaliFee.Core.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace Galifee.Components
{
    public class ScriptComponent : ISetupComponent, IBeforeInstallEvent
    {
        public IResourceLoader Loader { get; set; }

        public async Task BeforeInstall(SetupContext context)
        {
            JsEvaluator.Init();

            var result = await Evaluate();
        }

        public async Task BeforeUninstall(SetupContext context)
        {
            JsEvaluator.Init();

            var result = await Evaluate();
        }

        private async Task<object> Evaluate()
        {
            var sr = new StreamReader(await Loader.GetStream());

            var content = sr.ReadToEnd();

            var result = JsEvaluator.Evaluate(content);

            return Task.FromResult(result);
        }

        public Task OnInstall(SetupContext context)
        {
            return Task.CompletedTask;
        }

        public Task OnUninstall(SetupContext context)
        {
            return Task.CompletedTask;
        }

        public Task OnUpgrade(SetupContext context)
        {
            return Task.CompletedTask;
        }
    }
}