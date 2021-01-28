namespace Galifrei.Core.Interfaces
{
    public interface IAutostartLink
    {
        void Invoke(IResourceLoader loader, string filename);
    }
}