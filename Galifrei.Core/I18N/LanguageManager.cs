using Galifrei.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Galifrei.Core.I18N
{
    public class LanguageManager
    {
        private Dictionary<string, Language> _languages = new Dictionary<string, Language>();

        public IEnumerable<string> GetNames()
        {
            return _languages.Values.Select(_ => _["name"]);
        }

        public Language CurrentLanguage;

        public static LanguageManager Instance = new LanguageManager();

        public async void RegisterLanguage(string id, IResourceLoader contentLoader)
        {
            if (!_languages.ContainsKey(id))
            {
                _languages.Add(id, LoadLanguageFromStream(await contentLoader.GetStream()));
            }
        }

        public void SetLanguageFromName(string name)
        {
            foreach (var l in _languages)
            {
                var lang = l.Value;

                var lName = lang["name"];

                if (lName == name)
                {
                    SetLanguage(l.Key);
                }
            }
        }

        private Language LoadLanguageFromStream(Stream stream)
        {
            var sr = new StreamReader(stream);
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Language>(sr.ReadToEnd());
            sr.Close();

            return obj;
        }

        public void SetLanguage(string id)
        {
            if (_languages.ContainsKey(id))
            {
                CurrentLanguage = _languages[id];
            }
        }

        public string GetValue(string key)
        {
            if (CurrentLanguage != null)
            {
                if (CurrentLanguage.ContainsKey(key))
                {
                    return CurrentLanguage[key];
                }
                else
                {
                    return $"[default: '{key}']";
                }
            }

            return "No Language set";
        }

        public bool Contains(string id)
        {
            return _languages.ContainsKey(id);
        }
    }
}