using Avalonia.Controls;

namespace Galifee.Core
{
    public interface ISetupComponent
    {
        void BeforeInstall(SetupContext context);

        void BeforeUninstall(SetupContext context);

        void AfterInstall(SetupContext context);

        void AfterUninstall(SetupContext context);

        /// <summary>
        /// Will be invoked if installer is not in silent mode.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        Control GetVisualControl(SetupContext context);
    }
}