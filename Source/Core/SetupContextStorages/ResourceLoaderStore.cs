using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Galifee.Core.SetupContextStorages
{
    public class ResourceLoaderStore
    {
        public void RegisterResource(IResourceLoader loader)
        {
            _resourceLoaders.Add(loader);
        }

        public Task<Stream> ExecuteLoaderAsync(int index)
        {
            return _resourceLoaders[index].GetStream();
        }

        private List<IResourceLoader> _resourceLoaders = new List<IResourceLoader>();
    }
}