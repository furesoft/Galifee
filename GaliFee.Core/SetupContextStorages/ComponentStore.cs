using GaliFee.Core.Interfaces;
using System.Collections.Generic;

namespace GaliFee.Core.SetupContextStorages
{
    public class ComponentStore
    {
        private List<IVisualComponent> _components = new List<IVisualComponent>();
        private Dictionary<IVisualComponent, int> _componentIndices = new Dictionary<IVisualComponent, int>();

        public void RegisterComponent(IVisualComponent component)
        {
            if (component != null)
            {
                _components.Add(component);
                _componentIndices.Add(component, _componentIndices.Count);
            }
        }

        public void RegisterComponentAfterIndex(IVisualComponent component, int index)
        {
            if (component != null)
            {
                _components.Insert(index, component);
                _componentIndices.Add(component, _componentIndices.Count);
            }
        }

        public int GetIndexOfComponent(IVisualComponent component)
        {
            if (component != null)
            {
                return _componentIndices[component];
            }

            return -1;
        }
    }
}