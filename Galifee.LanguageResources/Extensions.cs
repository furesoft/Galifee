using Galifee.Core.AppBuilder;
using Galifee.Core.I18N;
using Galifee.Core.Loaders;

namespace Galifee.LanguageResources
{
    public static class Extensions
    {
        public static void LoadLanguageResources(this LanguageManager manager)
        {
            var assembly = typeof(Extensions).Assembly;

            manager.RegisterLanguage("de_DE", new AssemblyResourceLoader("Galifee.LanguageResources.Resources.de_DE.json", assembly));
        }

        public static ISetupAppBuilder LoadDefaultLanguages(this ISetupAppBuilder builder)
        {
            LanguageManager.Instance.LoadLanguageResources();

            return builder;
        }
    }
}