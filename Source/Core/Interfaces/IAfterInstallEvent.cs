using System.Threading.Tasks;

namespace Galifee.Core.Interfaces
{
    public interface IAfterInstallEvent
    {
        Task AfterInstall(SetupContext context);

        Task AfterUninstall(SetupContext context);
    }
}