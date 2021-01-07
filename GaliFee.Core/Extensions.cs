using Avalonia.Metadata;
using System.IO;

[assembly: XmlnsDefinition("http://furesoft.ml/schemas/galifee", "Galifee.Core.I18N")]

namespace Galifee.Core
{
    public static class Extensions
    {
        public static FileInfo GetFile(this DirectoryInfo info, string filename)
        {
            return new FileInfo(Path.Combine(info.FullName, filename));
        }
    }
}