using GaliFee.Core;
using GaliFee.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Galifee.Components
{
    public abstract class IDependencyResolver
    {
        protected Dictionary<string, IDependency> _dependencies = new Dictionary<string, IDependency>();

        public bool IsInstalled(string name)
        {
            return _dependencies[name].IsInstalled();
        }

        protected void RegisterDependency(string name, IDependency dependency)
        {
            _dependencies.Add(name, dependency);
        }

        public string[] ListDependencies()
        {
            return _dependencies.Keys.ToArray();
        }

        public void Install(string name, SetupContext context)
        {
            _dependencies[name].Install(context);
        }
    }
}