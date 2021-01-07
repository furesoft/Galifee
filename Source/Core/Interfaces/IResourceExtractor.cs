using System.IO;
using System.Threading.Tasks;

namespace Galifee.Core.Interfaces
{
    public interface IResourceExtractor
    {
        /// <summary>
        /// Extract a Resource Stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>#path to extracted Data Folder</returns>
        Task<string> Extract(Stream stream, SetupContext context);
    }
}