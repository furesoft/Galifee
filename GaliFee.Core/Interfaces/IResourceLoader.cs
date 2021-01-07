using System.IO;
using System.Threading.Tasks;

namespace GaliFee.Core.Interfaces
{
    public interface IResourceLoader
    {
        public Task<Stream> GetStream();
    }
}