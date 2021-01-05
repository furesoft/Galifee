using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Logging.Serilog;
using Galifree;
using Galifree.Core;
using System;

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