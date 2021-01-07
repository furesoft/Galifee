using System.IO;
using System.Threading.Tasks;

namespace Galifee.Core.Interfaces
{
    public interface IResourceLoader
    {
        public Task<Stream> GetStream();
    }
}