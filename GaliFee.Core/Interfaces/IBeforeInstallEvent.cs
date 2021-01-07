using System.Threading.Tasks;

namespace GaliFee.Core.Interfaces
{
    public interface IBeforeInstallEvent
    {
        Task BeforeInstall(SetupContext context);

        Task BeforeUninstall(SetupContext context);
    }
}