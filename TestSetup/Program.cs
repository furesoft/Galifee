using Galifee;
using Galifee.LanguageResources;
using Galifee.Core;
using Galifee.Core.AppBuilder;
using Galifee.Core.Loaders;
using Galifee.Components;

namespace TestSetup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var app = SetupAppBuilder.Configure()
                .SetProperty(NamingConstants.AppName, "TestApplication")
                .SetProperty(NamingConstants.AppVersion, "1.0.0")
                .AddResource(new AssemblyResourceLoader("TestSetup.SetupData.zip", typeof(Program).Assembly))
                .AddAction(new CreateDesktopLinkAction())
                .AddComponent(new DownloaderComponent())
                .LoadDefaultLanguages()
                .EnableAutoLanguage()
                .Build();

            app.Run(args);
        }
    }
}