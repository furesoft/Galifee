using System.Diagnostics;
using System.Threading.Tasks;

namespace Galifree.Core
{
    public class Terminal
    {
        public string Evaluate(string command)
        {
            var psi = new ProcessStartInfo();
            var tcs = new TaskCompletionSource<string>();

            psi.UseShellExecute = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;

            var ps = Process.Start(psi);
            ps.StandardInput.Write(command + "\n");
            ps.StandardInput.Flush();
            ps.EnableRaisingEvents = true;

            ps.Exited += (s, e) =>
            {
                tcs.SetResult(ps.StandardOutput.ReadToEnd());
            };

            ps.WaitForExit();

            return tcs.Task.Result;
        }
    }
}