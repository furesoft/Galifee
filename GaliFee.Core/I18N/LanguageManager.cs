using GaliFee.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace GaliFee.Core.I18N
{
    public class LanguageManager
    {
        private Dictionary<string, Language> _languages = new Dictionary<string, Language>();

        public Language CurrentLanguage;

        public static LanguageManager Instance = new LanguageManager();

        public async void RegisterLanguage(string id, IResourceLoader contentLoader)
        {
            if (!_languages.ContainsKey(id))
            {
                _languages.Add(id, LoadLanguageFromStream(await contentLoader.GetStream()));
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