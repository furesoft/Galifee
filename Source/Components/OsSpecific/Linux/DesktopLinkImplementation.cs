using Galifee.Core;
using Galifee.Core.Platforming;
using GaliFee.Core.Interfaces;

namespace Galifee.Components.OsSpecific.Linux
{
    [PlattformImplementation(OSName.Linux)]
    public class DesktopLinkImplementation : IDesktopLink
    {
        public void CreateDesktopLink(SetupContext context)
        {
        }
    }
}