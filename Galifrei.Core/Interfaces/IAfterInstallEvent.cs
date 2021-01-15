using System.Threading.Tasks;

namespace Galifrei.Core.Interfaces
{
    public interface IAfterInstallEvent
    {
        Task AfterInstall(SetupContext context);

        Task AfterUninstall(SetupContext context);
    }
}