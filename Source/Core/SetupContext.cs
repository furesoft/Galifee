﻿using System;
using System.Collections.Generic;

namespace Galifree.Core
{
    public class SetupContext
    {
        private Dictionary<string, object> _properties = new Dictionary<string, object>();

        public Terminal Shell = new Terminal();

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