using System.Threading.Tasks;

namespace Galifrei.Core.Interfaces
{
    public interface IBeforeInstallEvent
    {
        Task BeforeInstall(SetupContext context);

        Task BeforeUninstall(SetupContext context);
    }
}