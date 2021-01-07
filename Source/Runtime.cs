using Avalonia;
using Avalonia.Logging.Serilog;
using Galifee.Core;
using System;

namespace Galifee
{
    public static class Runtime
    {
        public static SetupContext Context = new SetupContext();

        public static void Run(string[] args)
        {
            var cli = new CommandlineArguments(args);

            var mode = Enum.Parse(typeof(InstallMode), cli.GetValue<string>("mode"), true);

            Context.Properties.SetProperty("mode", mode);

            if (!cli.HasOption("silent"))
            {
                //run ui mode
                AppBuilder.Configure<App>()
                        .UsePlatformDetect()
                        .LogToDebug()
                        .StartWithClassicDesktopLifetime(args);
            }
            else
            {
                // run cmd mode
            }
        }
    }
}