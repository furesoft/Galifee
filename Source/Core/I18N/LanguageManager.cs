using Galifee.Core.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace Galifee.Core.I18N
{
    public class LanguageManager
    {
        private Dictionary<string, Language> _languages = new Dictionary<string, Language>();

        public Language CurrentLanguage;

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
    }
}