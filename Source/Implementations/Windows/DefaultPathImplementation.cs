using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;
using System;

namespace Galifrei.Implementations.Windows
{
    [PlatformImplementation(OSName.Windows)]
    public class DefaultPathImplementation : IDefaultPaths
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public string DefaultLinkExtension => ".lnk";

        public string DefaultInstallationPath => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

        public string DefaultApplicationExtension => ".exe";

        public string AutoStartPath => @$"C:\Users\{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Roaming\Microsoft\Windows\Start Menu\Programs\Startup";
    }
}