using Galifee.Core.Context;

namespace Galifee.Core
{
    public class SetupContext
    {
        public PropertyStore Properties = new PropertyStore();
        public ComponentStore Components = new ComponentStore();
        public ResourceLoaderStore ResourceLoaders = new ResourceLoaderStore();

        public Terminal Shell = new Terminal();
    }
}