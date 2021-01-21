namespace Galifrei.Core.Interfaces
{
    public interface IDefaultPaths
    {
        string DesktopPath { get; }
        string DefaultLinkExtension { get; }

        string DefaultApplicationExtension { get; }

        string DefaultInstallationPath { get; }
    }
}