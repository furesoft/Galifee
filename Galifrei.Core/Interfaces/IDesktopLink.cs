namespace Galifrei.Core.Interfaces
{
    public interface IDesktopLink
    {
        IResourceLoader CreateDesktopLink(SetupContext context, string filename, string exec);
    }
}