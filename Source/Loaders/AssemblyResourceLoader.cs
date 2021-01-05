using Galifee.Core;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Galifee.Loaders
{
    public class AssemblyResourceLoader : IResourceLoader
    {
        public AssemblyResourceLoader(string fullname, ref Assembly assembly)
        {
            Fullname = fullname;
            Assembly = assembly;
        }

        public string Fullname { get; set; }

        public Assembly Assembly { get; }

        public async Task<Stream> GetStream()
        {
            var strm = Assembly.GetManifestResourceStream(Fullname);

            if (strm != null)
            {
                return strm;
            }

            return null;
        }
    }
}