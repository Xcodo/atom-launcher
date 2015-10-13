using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace AtomLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            var argsSb = new StringBuilder();
            if (args != null && args.Length >= 1)
            {
                foreach (var s in args)
                {
                    argsSb.Append("\"");
                    argsSb.Append(s);
                    argsSb.Append("\" ");
                }
                argsSb.Remove(argsSb.Length - 1, 1);
            }

            var startInfo = new ProcessStartInfo();
            startInfo.FileName = "atom.cmd";
            if (argsSb.Length > 0)
            {
                startInfo.Arguments = argsSb.ToString();
            }
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            var atomProcess = new Process();
            atomProcess.StartInfo = startInfo;
            if (!atomProcess.Start())
            {
                var errorSb = new StringBuilder();
                errorSb.AppendLine("Atom could not be started sucessfully.");
                errorSb.AppendLine("");
                errorSb.AppendLine("Command was:");
                errorSb.Append(startInfo.FileName);
                errorSb.Append(" ");
                errorSb.Append(startInfo.Arguments);
                MessageBox.Show(errorSb.ToString(), "AtomLauncher error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SendDebugMessage(startInfo);
            }
            Application.Exit();
        }

        [Conditional("DEBUG")]
        static void SendDebugMessage(ProcessStartInfo startInfo)
        {
            var debugSb = new StringBuilder();
            debugSb.AppendLine("Atom started with command:");
            debugSb.Append(startInfo.FileName);
            debugSb.Append(" ");
            debugSb.Append(startInfo.Arguments);
            MessageBox.Show(debugSb.ToString(), "AtomLauncher debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
