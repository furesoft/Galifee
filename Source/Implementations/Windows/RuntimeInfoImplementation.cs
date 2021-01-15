using Galifrei.Core;
using Galifrei.Core.Platforming;
using GaliFee.Core.Interfaces;
using System;

namespace Galifrei.Implementations.Windows
{
    [PlatformImplementation(OSName.Windows)]
    public class RuntimeInfoImplementation : IRuntimeInfo
    {
        public bool IsApplicationInstalled(SetupContext context)
        {
            throw new NotImplementedException();
        }
    }
}