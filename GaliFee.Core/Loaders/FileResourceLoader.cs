using GaliFee.Core.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace GaliFee.Core.Loaders
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