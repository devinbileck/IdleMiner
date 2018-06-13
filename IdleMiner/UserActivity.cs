using System;
using System.Runtime.InteropServices;

namespace IdleMiner
{
    class UserActivity
    {
        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        public static int GetIdleTime()
        {
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;
            int idleTime = 0;
            int envTicks = Environment.TickCount;
            if (GetLastInputInfo(ref lastInputInfo))
            {
                int lastInputTick = (int)lastInputInfo.dwTime;
                idleTime = envTicks - lastInputTick;
            }
            return ((idleTime > 0) ? (idleTime / 1000) : idleTime);
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct LASTINPUTINFO
        {
            public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dwTime;
        }
    }
}
