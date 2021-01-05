using System.IO;
using System.Threading.Tasks;

namespace Galifee.Core
{
    public interface IResourceLoader
    {
        public Task<Stream> GetStream();
    }
}