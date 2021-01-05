﻿using Avalonia;
using Avalonia.Logging.Serilog;
using Galifree.Core;

namespace Galifree
{
    public static class Runtime
    {
        public static void Run(string[] args)
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