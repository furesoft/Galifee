using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;
using System;

namespace Galifrei.Components.OsSpecific.Linux
{
    [PlatformImplementation(OSName.Linux)]
    public class DefaultPathImplementation : IDefaultPaths
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public string DefaultLinkExtension => ".desktop";

        public string DefaultInstallationPath => ""; //ToDo: find installation path for linux
    }
}