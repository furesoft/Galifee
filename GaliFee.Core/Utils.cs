using System;
using System.IO;
using System.Text;

namespace GaliFee.Core
{
    public static class Utils
    {
        public static string GetTempPath()
        {
            var tmpDir = Path.GetTempPath();
            var generated = Utils.RandomString();

            return Path.Combine(tmpDir, generated);
        }

        internal static string RandomString()
        {
            var rndm = new Random();
            string chars = "abcdefghijklmopqrstuvwxyzabcdefghijklmnopqrstuvwxyz_-";
            var length = rndm.Next(5, 10);

            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[rndm.Next(0, chars.Length)]);
            }

            return sb.ToString();
        }
    }
}