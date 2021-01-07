using Galifee.Core;
using Galifee.Core.Platforming;
using GaliFee.Core.Interfaces;
using System;

namespace Galifee.Implementations.Linux
{
    [PlatformImplementation(OSName.Linux)]
    public class RuntimeInfoImplementation : IRuntimeInfo
    {
        public bool IsApplicationInstalled(SetupContext context)
        {
            throw new NotImplementedException();
        }
    }
}