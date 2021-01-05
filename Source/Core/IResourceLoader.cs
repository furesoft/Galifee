using System.IO;
using System.Threading.Tasks;

namespace Galifree.Core
{
    public interface IResourceLoader
    {
        public Task<Stream> GetStream();
    }
}