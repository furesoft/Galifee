using Galifrei.Core.Interfaces;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Galifrei.Core.Loaders
{
    public class WebResourceLoader : IResourceLoader
    {
        public WebResourceLoader(string uRI)
        {
            URI = uRI;
        }

        public string URI { get; set; }

        public string Filename => new Uri(URI).LocalPath;

        public async Task<Stream> GetStream()
        {
            var wr = HttpWebRequest.Create(URI);

            return wr.GetResponse().GetResponseStream();
        }
    }
}