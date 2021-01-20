using Galifrei.Core;
using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;

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