using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Galifree.Core
{
    public class SetupContext
    {
        private Dictionary<string, object> _properties = new Dictionary<string, object>();
        private List<IResourceLoader> _resourceLoaders = new List<IResourceLoader>();

        public Terminal Shell = new Terminal();

        public void RegisterResource(IResourceLoader loader)
        {
            _resourceLoaders.Add(loader);
        }

        public Task<Stream> ExecuteLoaderAsync(int index)
        {
            return _resourceLoaders[index].GetStream();
        }

        public object GetProperty(string key)
        {
            if (_properties.ContainsKey(key))
            {
                return _properties[key];
            }

            return null;
        }

        public void RegisterComponent(object p)
        {
            throw new NotImplementedException();
        }
    }
}