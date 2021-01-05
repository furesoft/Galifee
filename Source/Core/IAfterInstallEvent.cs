using Avalonia.Controls;
using System.Threading.Tasks;

namespace Galifee.Core
{
    public interface IAfterInstallEvent
    {
        Task AfterInstall(SetupContext context);

        Task AfterUninstall(SetupContext context);
    }
}