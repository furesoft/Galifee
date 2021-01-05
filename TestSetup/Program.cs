using Galifee;
using Galifee.Core;

namespace TestSetup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var context = new SetupContext();
            context.RegisterComponent(null);

            Runtime.Run(args);
        }
    }
}