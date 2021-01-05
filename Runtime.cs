using Avalonia;
using Avalonia.Logging.Serilog;
using Furesoft.Core.CLI;

namespace Galifree
{
    public static class Runtime
    {
        public static void Run<App>(string[] args)
            where App : Application, new()
        {
            var cli = new CommandlineArguments(args);

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