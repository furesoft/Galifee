using System.Threading.Tasks;

namespace GaliFee.Core.Interfaces
{
    public interface IAfterInstallEvent
    {
        Task AfterInstall(SetupContext context);

        Task AfterUninstall(SetupContext context);
    }
}