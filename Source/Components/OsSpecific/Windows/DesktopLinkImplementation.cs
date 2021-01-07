using Galifee.Core;
using Galifee.Core.Platforming;
using GaliFee.Core.Interfaces;

namespace Galifee.Components.OsSpecific.Windows
{
    [PlatformImplementation(OSName.Windows)]
    public class DesktopLinkImplementation : IDesktopLink
    {
        public void CreateDesktopLink(SetupContext context, string filename)
        {
        }
    }
}