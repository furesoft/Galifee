using Avalonia;
using Avalonia.Logging.Serilog;
using Galifee.Core;
using Galifee.Core.I18N;
using Galifee.Loaders;
using System;

namespace Galifee
{
    public static class Runtime
    {
        public static SetupContext Context = new SetupContext();

        public static void Run(string[] args)
        {
            var cli = new CommandlineArguments(args);

            var mode = (InstallMode)Enum.Parse(typeof(InstallMode), cli.GetValue<string>("mode"), true);

            Context.Properties.SetProperty("mode", mode);
            LanguageManager.Instance.RegisterLanguage("en_EN", new AssemblyResourceLoader("Galifee.Resources.en_EN.json", typeof(Runtime).Assembly));
            LanguageManager.Instance.SetLanguage("en_EN");

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