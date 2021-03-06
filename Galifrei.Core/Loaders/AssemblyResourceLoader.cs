﻿using Galifrei.Core.Interfaces;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Galifrei.Core.Loaders
{
    public class AssemblyResourceLoader : IResourceLoader
    {
        public AssemblyResourceLoader(string fullname, Assembly assembly)
        {
            Fullname = fullname;
            Assembly = assembly;
        }

        public string Fullname { get; set; }

        public Assembly Assembly { get; }

        public string Filename => Path.GetFileName(Fullname);

        public Task<Stream> GetStream()
        {
            var strm = Assembly.GetManifestResourceStream(Fullname);

            if (strm != null)
            {
                return Task.FromResult(strm);
            }

            return Task.FromResult<Stream>(null);
        }
    }
}