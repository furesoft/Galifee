using Avalonia.Metadata;
using System.IO;

[assembly: XmlnsDefinition("http://furesoft.ml/schemas/galifee", "GaliFee.Core.I18N")]

namespace GaliFee.Core
{
    public static class Extensions
    {
        public static FileInfo GetFile(this DirectoryInfo info, string filename)
        {
            return new FileInfo(Path.Combine(info.FullName, filename));
        }
    }
}