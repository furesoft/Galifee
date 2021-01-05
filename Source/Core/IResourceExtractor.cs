using System.IO;
using System.Threading.Tasks;

namespace Galifree.Core
{
    public interface IResourceExtractor
    {
        /// <summary>
        /// Extract a Resource Stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>#path to extracted Data Folder</returns>
        Task<string> Extract(Stream stream);
    }
}