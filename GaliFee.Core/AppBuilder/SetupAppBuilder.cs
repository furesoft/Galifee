namespace GaliFee.Core.AppBuilder
{
    public class SetupAppBuilder : ISetupAppBuilder
    {
        public SetupContext Context => new SetupContext();

        public static ISetupAppBuilder Configure()
        {
            return new SetupAppBuilder();
        }
    }
}