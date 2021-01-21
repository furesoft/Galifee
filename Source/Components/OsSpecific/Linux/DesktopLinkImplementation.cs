using Galifrei.Core;
using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;
using System.IO;
using System.Text;

namespace Galifrei.Components.OsSpecific.Linux
{
    [PlatformImplementation(OSName.Linux)]
    public class DesktopLinkImplementation : IDesktopLink
    {
        public void CreateDesktopLink(SetupContext context, string filename, string exec)
        {
            var contentSb = new StringBuilder();

            contentSb.AppendLine("[Desktop Entry]");
            contentSb.AppendLine("Name=").Append(context.Properties[NamingConstants.AppName]);
            contentSb.AppendLine("Exec=").Append(exec);
            contentSb.AppendLine("Terminal=").Append(context.Properties[NamingConstants.IsTerminal]);
            contentSb.AppendLine("Type=Application");

            File.WriteAllText(filename, contentSb.ToString());
        }
    }
}