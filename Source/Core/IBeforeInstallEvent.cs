using Avalonia.Controls;
using System.Threading.Tasks;

namespace Galifee.Core
{
    public interface IBeforeInstallEvent
    {
        Task BeforeInstall(SetupContext context);

        Task BeforeUninstall(SetupContext context);
    }
}