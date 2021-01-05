using Galifee.Core.Platforming;
using System;

namespace Galifee.Components.OsSpecific.Linux
{
    [PlattformImplementation(OSName.Linux)]
    public class DefaultPathImplementation : IDefaultPaths
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    }
}