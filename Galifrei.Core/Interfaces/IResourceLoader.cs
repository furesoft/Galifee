using System.IO;
using System.Threading.Tasks;

namespace Galifrei.Core.Interfaces
{
    public interface IResourceLoader
    {
        public Task<Stream> GetStream();
    }
}