using System.Collections.Generic;

namespace Galifee.Core.SetupContextStorages
{
    public class ComponentStore
    {
        private List<IVisualComponent> _components = new List<IVisualComponent>();
        private Dictionary<IVisualComponent, int> _componentIndices = new Dictionary<IVisualComponent, int>();

        public void RegisterComponent(IVisualComponent component)
        {
            _components.Add(component);
            _componentIndices.Add(component, _componentIndices.Count);
        }

        public void RegisterComponentAfterIndex(IVisualComponent component, int index)
        {
            _components.Insert(index, component);
            _componentIndices.Add(component, _componentIndices.Count);
        }

        public int GetIndexOfComponent(IVisualComponent component)
        {
            return _componentIndices[component];
        }
    }
}