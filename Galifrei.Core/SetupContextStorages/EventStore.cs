using System;
using System.Collections.Generic;

namespace Galifrei.Core.SetupContextStorages
{
    public class EventStore
    {
        private Dictionary<EventConstants, List<Action<object>>> _events = new Dictionary<EventConstants, List<Action<object>>>();

        public void Add(EventConstants ev, Action<object> handler)
        {
            if (_events.ContainsKey(ev))
            {
                _events[ev].Add(handler);
            }
            else
            {
                var handlers = new List<Action<object>>();
                handlers.Add(handler);

                _events.Add(ev, handlers);
            }
        }

        public void Invoke(EventConstants ev, object parameter)
        {
            if (_events.ContainsKey(ev))
            {
                foreach (var handler in _events[ev])
                {
                    handler?.Invoke(parameter);
                }
            }
        }
    }
}