using Galifrei.Core.Interfaces;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Galifrei.Core.Loaders
{
    public class StringResourceLoader : IResourceLoader
    {
        public StringResourceLoader(string filename, string content)
        {
            Filename = filename;
            Content = content;
        }

        public string Filename { get; set; }
        public string Content { get; set; }

        public Task<Stream> GetStream()
        {
            return Task.FromResult((Stream)new MemoryStream(Encoding.UTF8.GetBytes(Content)));
        }
    }
}