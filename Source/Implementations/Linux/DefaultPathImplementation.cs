using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;
using System;

namespace Galifrei.Implementations.Linux
{
    [PlatformImplementation(OSName.Linux)]
    public class DefaultPathImplementation : IDefaultPaths
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public string DefaultLinkExtension => ".desktop";

        public string DefaultInstallationPath => "/usr/bin/";

        public string DefaultApplicationExtension => "";
    }
}