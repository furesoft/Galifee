using Avalonia.Controls;
using System.Threading.Tasks;

namespace Galifee.Core
{
    public interface ISetupComponent
    {
        Task BeforeInstall(SetupContext context);

        Task BeforeUninstall(SetupContext context);

        Task AfterInstall(SetupContext context);

        Task AfterUninstall(SetupContext context);

        /// <summary>
        /// Will be invoked if installer is not in silent mode.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        Control GetVisualControl(SetupContext context);
    }
}