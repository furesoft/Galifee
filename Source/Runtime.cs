using Avalonia;
using Avalonia.Logging.Serilog;
using Galifee.Core;
using System;

namespace Galifee
{
    internal static class Runtime
    {
        public static SetupContext Context = new SetupContext();

        public static void Run(string[] args)
        {
            var cli = new CommandlineArguments(args);

            InstallMode mode = InstallMode.Install;

            if (cli.GetValue<string>("mode") != null)
            {
                mode = (InstallMode)Enum.Parse(typeof(InstallMode), cli.GetValue<string>("mode"), true);
            }

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

                if (mode == InstallMode.Install)
                {
                    Context.Pipeline.Install(Context);
                }
                else if (mode == InstallMode.Uninstall)
                {
                    Context.Pipeline.Uninstall(Context);
                }
                else if (mode == InstallMode.Upgrade)
                {
                    Context.Pipeline.Upgrade(Context);
                }
            }
        }
    }
}