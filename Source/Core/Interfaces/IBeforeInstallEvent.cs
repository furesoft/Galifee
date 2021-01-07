using System.Threading.Tasks;

namespace Galifee.Core.Interfaces
{
    public interface IBeforeInstallEvent
    {
        Task BeforeInstall(SetupContext context);

        Task BeforeUninstall(SetupContext context);
    }
}