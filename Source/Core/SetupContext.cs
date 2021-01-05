using Galifee.Components;
using Galifee.Core.Platforming;
using Galifee.Core.SetupContextStorages;

namespace Galifee.Core
{
    public class SetupContext
    {
        public PropertyStore Properties = new PropertyStore();
        public ComponentStore Components = new ComponentStore();
        public ResourceLoaderStore ResourceLoaders = new ResourceLoaderStore();

        public Terminal Shell = new Terminal();

        public IDefaultPaths Paths;
        private string _tmpDir;

        public string TempDirectory => _tmpDir;

        public SetupContext()
        {
            Paths = Platform.New<IDefaultPaths>();

            _tmpDir = Utils.GetTempPath();
        }
    }
}