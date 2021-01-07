using Galifee;
using Galifee.LanguageResources;
using Galifee.Core;
using Galifee.Core.AppBuilder;
using Galifee.Core.Loaders;

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