using System.Collections.Generic;

namespace Galifee.Core.Context
{
    public class ComponentStore
    {
        private List<ISetupComponent> _components = new List<ISetupComponent>();
        private Dictionary<ISetupComponent, int> _componentIndices = new Dictionary<ISetupComponent, int>();

        public void RegisterComponent(ISetupComponent component)
        {
            _components.Add(component);
            _componentIndices.Add(component, _componentIndices.Count);
        }

        public void RegisterComponentAfterIndex(ISetupComponent component, int index)
        {
            _components.Insert(index, component);
            _componentIndices.Add(component, _componentIndices.Count);
        }

        public int GetIndexOfComponent(ISetupComponent component)
        {
            return _componentIndices[component];
        }
    }
}