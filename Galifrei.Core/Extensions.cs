using Avalonia.Metadata;
using System.IO;
using System.Windows.Input;

[assembly: XmlnsDefinition("http://furesoft.ml/schemas/galifee", "Galifrei.Core.I18N")]
[assembly: XmlnsDefinition("http://furesoft.ml/schemas/galifee", "Galifrei.Core")]

namespace Galifrei.Core
{
    public static class Extensions
    {
        public static FileInfo GetFile(this DirectoryInfo info, string filename)
        {
            return new FileInfo(Path.Combine(info.FullName, filename));
        }

        public static ICommand Aggregate(this ICommand cmd, ICommand nextCommand)
        {
            return new DelegateCommand(_ =>
            {
                cmd.Execute(_);
                nextCommand.Execute(_);
            });
        }
    }
}