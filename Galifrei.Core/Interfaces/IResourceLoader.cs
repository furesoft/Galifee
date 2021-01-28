using System.IO;
using System.Threading.Tasks;

namespace Galifrei.Core.Interfaces
{
    public interface IResourceLoader
    {
        string Filename { get; }

        public Task<Stream> GetStream();
    }
}