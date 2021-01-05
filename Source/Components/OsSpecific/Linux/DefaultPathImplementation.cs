using Galifee.Core.Platforming;

namespace Galifee.Components.OsSpecific.Linux
{
    [PlattformImplementation(OSName.Linux)]
    public class DefaultPathImplementation : IDefaultPaths
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    }
}