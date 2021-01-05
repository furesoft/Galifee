using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Galifee.Core
{
    public class SetupContext
    {
        private Dictionary<string, object> _properties = new Dictionary<string, object>();
        private List<IResourceLoader> _resourceLoaders = new List<IResourceLoader>();

        private List<ISetupComponent> _components = new List<ISetupComponent>();
        private Dictionary<ISetupComponent, int> _componentIndices = new Dictionary<ISetupComponent, int>();

        public string GetTempPath()
        {
            var tmpDir = Path.GetTempPath();
            var generated = Utils.RandomString();

            return Path.Combine(tmpDir, generated);
        }

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

        public void RegisterComponent(ISetupComponent component)
        {
            _components.Add(component);
            _componentIndices.Add(component, _componentIndices.Count);
        }

        public void RegisterComponentAfterIndex(ISetupComponent component, int index)
        {
            _components.Insert(index, component);
            _componentIndices.Add(p, _componentIndices.Count);
        }

        public int GetIndexOfComponent(ISetupComponent component)
        {
            return _componentIndices[component];
        }
    }
}