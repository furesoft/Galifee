using Galifee.Core;
using Galifee.Core.Platforming;
using GaliFee.Core.Interfaces;

namespace Galifee.Components.OsSpecific.Linux
{
    [PlatformImplementation(OSName.Linux)]
    public class DesktopLinkImplementation : IDesktopLink
    {
        public void CreateDesktopLink(SetupContext context, string filename)
        {
            throw new System.NotImplementedException();
        }
    }
}