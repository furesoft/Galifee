using Galifee.Core.AppBuilder;
using Galifee.Core.I18N;
using Galifee.Core.Loaders;
using System.Linq;

namespace Galifee
{
    public static class ISetupAppBuilderExtensions
    {
        public static SetupApp Build(this ISetupAppBuilder builder)
        {
            if (!LanguageManager.Instance.Contains("en_EN"))
            {
                LanguageManager.Instance.RegisterLanguage("en_EN", new AssemblyResourceLoader("Galifee.Resources.en_EN.json", typeof(Runtime).Assembly));
            }

            if (LanguageManager.Instance.CurrentLanguage == null)
            {
                LanguageManager.Instance.SetLanguage("en_EN");
            }

            return new SetupApp(builder.Context);
        }
    }
}