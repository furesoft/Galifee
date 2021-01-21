namespace Galifrei.Core.Interfaces
{
    public interface IDesktopLink
    {
        void CreateDesktopLink(SetupContext context, string filename, string exec);
    }
}