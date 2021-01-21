using Galifrei.Core;
using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;

namespace Galifrei.Components.OsSpecific.Windows
{
    [PlatformImplementation(OSName.Windows)]
    public class DesktopLinkImplementation : IDesktopLink
    {
        public void CreateDesktopLink(SetupContext context, string filename, string exec)
        {
        }
    }
}