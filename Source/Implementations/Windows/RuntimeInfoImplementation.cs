using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;
using System;

namespace Galifrei.Implementations.Windows
{
    [PlatformImplementation(OSName.Windows)]
    public class RuntimeInfoImplementation : IRuntimeInfo
    {
        public bool IsApplicationInstalled(Core.SetupContext context)
        {
            throw new NotImplementedException();
        }
    }
}