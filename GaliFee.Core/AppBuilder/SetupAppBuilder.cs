namespace Galifee.Core.AppBuilder
{
    public class SetupAppBuilder : ISetupAppBuilder
    {
        private SetupContext _context;
        public SetupContext Context => _context;

        public SetupAppBuilder()
        {
            _context = new SetupContext();
        }

        public static ISetupAppBuilder Configure()
        {
            return new SetupAppBuilder();
        }
    }
}