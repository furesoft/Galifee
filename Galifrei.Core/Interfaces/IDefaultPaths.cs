namespace Galifrei.Core.Interfaces
{
    public interface IDefaultPaths
    {
        string DesktopPath { get; }
        string DefaultLinkExtension { get; }

        string DefaultInstallationPath { get; }
    }
}