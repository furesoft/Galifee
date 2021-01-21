using Galifrei;
using Galifrei.LanguageResources;
using Galifrei.Components;
using Galifrei.Core;
using Galifrei.Core.AppBuilder;
using Galifrei.Core.Loaders;
using Galifrei.Popups;

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
                .AddAction(new CreateDesktopLinkAction("{ApplicationPath}", "TestApplication --WAll"))
                .AddComponent(new DownloaderComponent())
                .LoadDefaultLanguages()
                .EnableAutoLanguage()
                .EnableMessageOnClose()
                .Build();

            app.Run(args);
        }
    }
}