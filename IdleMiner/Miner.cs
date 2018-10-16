using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace IdleMiner
{
    class Miner
    {
        public enum States { Inactive, Active, Paused, Terminated };
        public States State { get; set; }

        [StructLayout(LayoutKind.Sequential)]
        struct STARTUPINFO
        {
            public Int32 cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public Int32 dwX;
            public Int32 dwY;
            public Int32 dwXSize;
            public Int32 dwYSize;
            public Int32 dwXCountChars;
            public Int32 dwYCountChars;
            public Int32 dwFillAttribute;
            public Int32 dwFlags;
            public Int16 wShowWindow;
            public Int16 cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        [DllImport("kernel32.dll")]
        static extern bool CreateProcess(
            string lpApplicationName,
            string lpCommandLine,
            IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes,
            bool bInheritHandles,
            uint dwCreationFlags,
            IntPtr lpEnvironment,
            string lpCurrentDirectory,
            [In] ref STARTUPINFO lpStartupInfo,
            out PROCESS_INFORMATION lpProcessInformation
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        const int STARTF_USESHOWWINDOW = 1;
        const int SW_SHOWNOACTIVATE = 4;
        const int SW_SHOWMINNOACTIVE = 7;

        private Process process;
        public string Command { get; set; }
        public string Arguments { get; set; }

        public Miner(string command = null, string arguments = null)
        {
            Command = command;
            Arguments = arguments;
        }

        public void Start()
        {
            if (IsRunning())
            {
                Stop();
            }

            STARTUPINFO si = new STARTUPINFO();
            si.cb = Marshal.SizeOf(si);
            si.dwFlags = STARTF_USESHOWWINDOW;
            si.wShowWindow = SW_SHOWMINNOACTIVE;

            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();

            CreateProcess(null, "\"" + Command + "\" " + Arguments, IntPtr.Zero, IntPtr.Zero, true, 0, IntPtr.Zero, null, ref si, out pi);
            process = Process.GetProcessById(pi.dwProcessId);

            CloseHandle(pi.hProcess);
            CloseHandle(pi.hThread);

            this.State = States.Active;
        }

        public void Stop()
        {
            try
            {
                if (process != null && process.HasExited == false)
                {
                    process.Kill();
                }
                else
                {
                    process = FindProcess();
                    if (process != null && process.HasExited == false)
                    {
                        process.Kill();
                    }
                }
            }
            catch (System.ComponentModel.Win32Exception)
            {
                
            }
        }

        public bool IsRunning()
        {
            if (FindProcess() != null)
            {
                return true;
            }
            return false;
        }

        public Process FindProcess()
        {
            if (!File.Exists(Command))
            {
                return null;
            }
            string fileName = Path.GetFileName(Command);
            Process[] processes = Process.GetProcessesByName(fileName.Substring(0, fileName.LastIndexOf('.')));
            if (processes.Length > 0)
            {
                return processes[0];
            }
            return null;
        }
    }
}
