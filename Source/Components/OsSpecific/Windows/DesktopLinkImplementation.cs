using Galifee.Core;
using Galifee.Core.Platforming;
using GaliFee.Core.Interfaces;

namespace Galifee.Components.OsSpecific.Windows
{
    [PlattformImplementation(OSName.Windows)]
    public class DesktopLinkImplementation : IDesktopLink
    {
        public void CreateDesktopLink(SetupContext context, string filename)
        {
            throw new System.NotImplementedException();
        }
    }
}