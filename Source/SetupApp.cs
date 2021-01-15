using Galifrei.Core;

namespace Galifrei
{
    public class SetupApp
    {
        public SetupApp(SetupContext context)
        {
            Context = context;
        }

        public SetupContext Context { get; set; }

        public void Run(string[] args)
        {
            Runtime.Context = Context;

            Runtime.Run(args);
        }
    }
}