using Galifrei.Core;

namespace GaliFee.Core.Interfaces
{
    public interface IRuntimeInfo
    {
        bool IsApplicationInstalled(SetupContext context);
    }
}