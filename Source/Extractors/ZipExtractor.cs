﻿using Galifee.Core;
using Galifee.Core.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace Galifee.Extractors
{
    public class ZipExtractor : IResourceExtractor
    {
        public Task<string> Extract(Stream stream, SetupContext context)
        {
            var path = Utils.GetTempPath();

            return Task.FromResult(path);
        }
    }
}