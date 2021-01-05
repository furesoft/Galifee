using Galifee.Core;
using System.IO;
using System.Threading.Tasks;

namespace Galifee.Loaders
{
    public class FileResourceLoader : IResourceLoader
    {
        public string Filename { get; set; }

        public Task<Stream> GetStream()
        {
            return Task.FromResult((Stream)File.OpenRead(Filename));
        }
    }
}