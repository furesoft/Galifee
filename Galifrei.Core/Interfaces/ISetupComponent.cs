using System.Threading.Tasks;

namespace Galifrei.Core.Interfaces
{
    public interface ISetupComponent
    {
        Task OnInstall(SetupContext context);

        Task OnUninstall(SetupContext context);

        Task OnUpgrade(SetupContext context);
    }
}