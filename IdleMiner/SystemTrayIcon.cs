using IdleMiner.Properties;
using System;
using System.Windows.Forms;

namespace IdleMiner
{
    class SystemTrayIcon : IDisposable
    {
        private NotifyIcon notifyIcon;

        public SystemTrayIcon()
        {
            notifyIcon = new NotifyIcon();
        }

        public void Display()
        {
            // Display the icon in the system tray
            notifyIcon.Icon = Resources.Logo_Icon;
            notifyIcon.Text = AssemblyInfo.Title;
            notifyIcon.Visible = true;

            // Attach a context menu
            notifyIcon.ContextMenuStrip = new ContextMenu().Create();
        }

        public void Dispose()
        {
            // When the application closes, this will remove the icon from the system tray immediately
            notifyIcon.Dispose();
        }

        public void ShowWarningIcon()
        {
            notifyIcon.Icon = Resources.Logo_Warning_Icon;
        }

        public void ShowNormalIcon()
        {
            notifyIcon.Icon = Resources.Logo_Icon;
        }
    }
}
