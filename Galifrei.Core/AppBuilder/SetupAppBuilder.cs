using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;

namespace Galifrei.Core.AppBuilder
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
            var builder = new SetupAppBuilder();

            var defaultPaths = Platform.New<IDefaultPaths>();
            builder.SetProperty(NamingConstants.InstallationPath, defaultPaths.DefaultInstallationPath);
            builder.SetProperty(NamingConstants.DesktopPath, defaultPaths.DesktopPath);

            return builder;
        }
    }
}