using Galifrei.Core;
using Galifrei.Core.Platforming;
using GaliFee.Core.Interfaces;

namespace Galifrei.Components.OsSpecific.Windows
{
    [PlatformImplementation(OSName.Windows)]
    public class DesktopLinkImplementation : IDesktopLink
    {
        public void CreateDesktopLink(SetupContext context, string filename)
        {
        }
    }
}