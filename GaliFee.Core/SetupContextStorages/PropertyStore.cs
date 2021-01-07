using System.Collections.Generic;

namespace GaliFee.Core.SetupContextStorages
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