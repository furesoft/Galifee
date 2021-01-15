using Galifrei.Core.AppBuilder;
using Galifrei.Core.I18N;
using Galifrei.Core.Loaders;

namespace Galifrei
{
    public static class ISetupAppBuilderExtensions
    {
        public static SetupApp Build(this ISetupAppBuilder builder)
        {
            if (!LanguageManager.Instance.Contains("en_EN"))
            {
                LanguageManager.Instance.RegisterLanguage("en_EN", new AssemblyResourceLoader("Galifrei.Resources.en_EN.json", typeof(Runtime).Assembly));
            }

            if (LanguageManager.Instance.CurrentLanguage == null)
            {
                LanguageManager.Instance.SetLanguage("en_EN");
            }

            return new SetupApp(builder.Context);
        }
    }
}