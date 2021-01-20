using Galifrei.Core;
using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;
using System;
using System.IO;

namespace Galifrei.Implementations.Linux
{
    [PlatformImplementation(OSName.Linux)]
    public class RuntimeInfoImplementation : IRuntimeInfo
    {
        public bool IsApplicationInstalled(SetupContext context)
        {
            return File.Exists(Path.Combine(context.Paths.DefaultInstallationPath, context.Properties[NamingConstants.AppName].ToString()));
        }
    }
}