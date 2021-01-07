using System.Threading.Tasks;

namespace Galifee.Core
{
    public interface ISetupComponent
    {
        Task OnInstall(SetupContext context);

        Task OnUninstall(SetupContext context);

        Task OnUpgrade(SetupContext context);
    }
}