using Galifrei.Core;
using Galifrei.Core.Platforming;
using GaliFee.Core.Interfaces;

namespace Galifrei.Components.OsSpecific.Linux
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