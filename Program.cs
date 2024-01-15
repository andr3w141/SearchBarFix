
namespace SearchBarFix
{
    class Program
    {
        internal static void Main(string[] args)
        {

            Console.WriteLine("Opening ctfmon...");
            #region Start the ctfmon for Windows Explorer

            Utils ctfmon = new Utils();
            ctfmon.Path = @"C:\Windows\System32\ctfmon.exe";
            ctfmon.CurrentProcess.StartInfo.FileName = ctfmon.Path;
            ctfmon.CurrentProcess.StartInfo.UseShellExecute = true;
            ctfmon.CurrentProcess.StartInfo.Verb = "runas";
            ctfmon.CurrentProcess.Start();

            #endregion

            Console.WriteLine("Restarting explorer...");
            #region Restart Windows Explorer for search bar

            Utils explorer = new Utils();
            string explorer_process_name = "explorer";
            explorer.Path = @"C:\Windows\explorer.exe";
            explorer.CurrentProcess = explorer.GetProcess(explorer_process_name);
            explorer.RestartProcess(explorer.CurrentProcess);
            #endregion

        }
    }
}