using System;
using System.Collections.Generic;

namespace Galifee.Core
{
    public class InstallActionPipeline
    {
        private List<IBeforeInstallEvent> _beforeEvents = new List<IBeforeInstallEvent>();
        private List<IAfterInstallEvent> _afterEvents = new List<IAfterInstallEvent>();

        private List<ISetupComponent> _components = new List<ISetupComponent>();

        public void Add(ISetupComponent component)
        {
            _components.Add(component);

            if (component is IBeforeInstallEvent b)
            {
                _beforeEvents.Add(b);
            }
            if (component is IAfterInstallEvent a)
            {
                _afterEvents.Add(a);
            }
        }

        public void Install(SetupContext context)
        {
            foreach (var item in _beforeEvents)
            {
                item.BeforeInstall(context);
            }

            foreach (var item in _components)
            {
                item.OnInstall(context);
            }

            foreach (var item in _afterEvents)
            {
                item.AfterInstall(context);
            }
        }

        public void Uninstall(SetupContext context)
        {
            foreach (var item in _beforeEvents)
            {
                item.BeforeUninstall(context);
            }

            foreach (var item in _components)
            {
                item.OnUninstall(context);
            }

            foreach (var item in _afterEvents)
            {
                item.AfterUninstall(context);
            }
        }

        internal void Upgrade(SetupContext context)
        {
            foreach (var item in _components)
            {
                item.OnUpgrade(context);
            }
        }
    }
}