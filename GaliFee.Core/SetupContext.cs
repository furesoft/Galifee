using Galifee.Components;
using Galifee.Core.I18N;
using Galifee.Core.Interfaces;
using Galifee.Core.Platforming;
using Galifee.Core.SetupContextStorages;
using System.IO;

namespace Galifee.Core
{
    public class SetupContext
    {
        public PropertyStore Properties = new PropertyStore();
        public ComponentStore Components = new ComponentStore();
        public ResourceLoaderStore ResourceLoaders = new ResourceLoaderStore();

        public InstallActionPipeline Pipeline = new InstallActionPipeline();

        public Terminal Shell = new Terminal();

        public IDefaultPaths Paths;
        private string _tmpDir;

        public string TempDirectory => _tmpDir;

        public DirectoryInfo TmpDir => new DirectoryInfo(_tmpDir);

        public SetupContext()
        {
            Paths = Platform.New<IDefaultPaths>();

            _tmpDir = Utils.GetTempPath();
        }

        public void ExecuteComponentInstall(ISetupComponent component)
        {
            // if component is IVisualComponent and not in silent mode then add ui
            component.OnInstall(this);
        }

        public void ExecuteComponentUninstall(ISetupComponent component)
        {
            // if component is IVisualComponent and not in silent mode then add ui
            component.OnUninstall(this);
        }

        public void ExecuteComponentUpgrade(ISetupComponent component)
        {
            // if component is IVisualComponent and not in silent mode then add ui
            component.OnUninstall(this);
        }
    }
}