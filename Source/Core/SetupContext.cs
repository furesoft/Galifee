using Galifee.Components;
using Galifee.Core.Context;
using Galifee.Core.Platforming;

namespace Galifee.Core
{
    public class SetupContext
    {
        public PropertyStore Properties = new PropertyStore();
        public ComponentStore Components = new ComponentStore();
        public ResourceLoaderStore ResourceLoaders = new ResourceLoaderStore();

        public Terminal Shell = new Terminal();

        public IDefaultPaths Paths;

        public SetupContext()
        {
            Paths = Platform.New<IDefaultPaths>();
        }
    }
}