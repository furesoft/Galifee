using Avalonia.Controls;

namespace GaliFee.Core.Interfaces
{
    public interface IVisualComponent
    {
        /// <summary>
        /// Will be invoked if installer is not in silent mode.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        Control GetVisualControl(SetupContext context);
    }
}