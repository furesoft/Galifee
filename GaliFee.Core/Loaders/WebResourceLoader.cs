using Galifee.Core.Interfaces;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Galifee.Loaders
{
    public class WebResourceLoader : IResourceLoader
    {
        public WebResourceLoader(string uRI)
        {
            URI = uRI;
        }

        public string URI { get; set; }

        public async Task<Stream> GetStream()
        {
            var wr = HttpWebRequest.Create(URI);

            return wr.GetResponse().GetResponseStream();
        }
    }
}