using Galifee.Core.I18N;
using Galifee.Loaders;

namespace Galifee.LanguageResources
{
    public static class Extensions
    {
        public static void LoadLanguageResources(this LanguageManager manager)
        {
            var assembly = typeof(Extensions).Assembly;

            manager.RegisterLanguage("de_DE", new AssemblyResourceLoader("Galifee.LanguageResources.Resources.de_DE.json", assembly));
        }
    }
}