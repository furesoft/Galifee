using System.Collections.Generic;

namespace Galifrei.Core.SetupContextStorages
{
    public class PropertyStore
    {
        private Dictionary<string, object> _properties = new Dictionary<string, object>();

        public object GetProperty(string key)
        {
            if (_properties.ContainsKey(key))
            {
                return _properties[key];
            }

            return null;
        }

        public object this[string key]
        {
            get
            {
                return GetProperty(key);
            }
            set
            {
                SetProperty(key, value);
            }
        }

        public T GetProperty<T>(string key)
        {
            var value = GetProperty(key);

            if (value != null)
            {
                return (T)value;
            }

            return default;
        }

        public string Bind(string src)
        {
            return SmartFormat.Smart.Format(src, _properties);
        }

        public void SetProperty(string key, object value)
        {
            if (_properties.ContainsKey(key))
            {
                _properties[key] = value;
            }
            else
            {
                _properties.Add(key, value);
            }
        }
    }
}