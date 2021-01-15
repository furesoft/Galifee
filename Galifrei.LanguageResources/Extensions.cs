using Galifrei.Core.AppBuilder;
using Galifrei.Core.I18N;
using Galifrei.Core.Loaders;

namespace Galifrei.LanguageResources
{
    public static class Extensions
    {
        public static void LoadLanguageResources(this LanguageManager manager)
        {
            var assembly = typeof(Extensions).Assembly;

            manager.RegisterLanguage("de_DE", new AssemblyResourceLoader("Galifrei.LanguageResources.Resources.de_DE.json", assembly));
        }

        public static ISetupAppBuilder LoadDefaultLanguages(this ISetupAppBuilder builder)
        {
            LanguageManager.Instance.LoadLanguageResources();

            return builder;
        }
    }
}