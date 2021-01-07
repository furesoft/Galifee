using Galifee.Core.AppBuilder;
using Galifee.Core.I18N;
using Galifee.Core.Loaders;

namespace Galifee
{
    public static class ISetupAppBuilderExtensions
    {
        public static SetupApp Build(this ISetupAppBuilder builder)
        {
            if (LanguageManager.Instance.CurrentLanguage == null)
            {
                LanguageManager.Instance.RegisterLanguage("en_EN", new AssemblyResourceLoader("Galifee.Resources.en_EN.json", typeof(Runtime).Assembly));
                LanguageManager.Instance.SetLanguage("en_EN");
            }

            return new SetupApp(builder.Context);
        }
    }
}