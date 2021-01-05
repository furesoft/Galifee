using Galifee;
using Galifee.Core;
using Galifee.Loaders;

namespace TestSetup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var context = new SetupContext();
            context.Components.RegisterComponent(null);
            context.ResourceLoaders.RegisterResource(new AssemblyResourceLoader("TestSetup.SetupData.zip", typeof(Program).Assembly));

            Runtime.Run(args);
        }
    }
}