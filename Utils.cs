using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SearchBarFix
{
    internal class Utils
    {
        private string path;
        private Process process;

        public string Path { get { return path; } set { path = value; } }

        public Process CurrentProcess { get { return process; } set { process = value; } }
        public Utils() 
        {
            Path = @"";
            CurrentProcess = new Process();
        }

        public void StartProcess(string path)
        {
            Process.Start(path);
        }

        public void RestartProcess(Process process)
        {
            Thread.Sleep(1000);
            process.Kill();
            process.WaitForExit();
            Process.Start(path);
        }

        public Process GetProcess(string name) 
        {
            return Process.GetProcessesByName(name).FirstOrDefault();
        }
    }
}
