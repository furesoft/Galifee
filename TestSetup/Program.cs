using Galifee;
using Galifee.LanguageResources;
using GaliFee.Core;
using GaliFee.Core.I18N;
using GaliFee.Core.Loaders;

namespace TestSetup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Runtime.Init();

            var context = new SetupContext();
            context.Components.RegisterComponent(null);
            context.ResourceLoaders.RegisterResource(new AssemblyResourceLoader("TestSetup.SetupData.zip", typeof(Program).Assembly));

            LanguageManager.Instance.LoadLanguageResources();

            LanguageManager.Instance.SetLanguage("de_DE");
            Runtime.Run(args);
        }
    }
}