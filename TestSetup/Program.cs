using Galifee;
using Galifee.LanguageResources;
using GaliFee.Core;
using GaliFee.Core.AppBuilder;
using GaliFee.Core.Loaders;

namespace TestSetup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var app = SetupAppBuilder.Configure()
                .SetProperty(NamingConstants.AppName, "TestApplication")
                .AddResource(new AssemblyResourceLoader("TestSetup.SetupData.zip", typeof(Program).Assembly))
                .AddComponent(null)
                .LoadDefaultLanguages()
                .EnableAutoLanguage()
                .Build();

            app.Run(args);
        }
    }
}