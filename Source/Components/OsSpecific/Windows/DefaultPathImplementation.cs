using Galifee.Core.Platforming;
using System;

namespace Galifee.Components.OsSpecific.Windows
{
    [PlattformImplementation(OSName.Windows)]
    public class DefaultPathImplementation : IDefaultPaths
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    }
}