using System.IO;

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