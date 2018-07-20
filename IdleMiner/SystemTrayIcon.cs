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

            // Allow the icon to react to mouse clicks
            notifyIcon.MouseClick += new MouseEventHandler(MouseClick);
        }

        public void Dispose()
        {
            // When the application closes, this will remove the icon from the system tray immediately
            notifyIcon.Dispose();
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Pause/resume mining
                if (Program.MiningPaused == false)
                {
                    Program.MiningPaused = true;
                    notifyIcon.Icon = Resources.Logo_Icon_Paused;
                }
                else
                {
                    Program.MiningPaused = false;
                    notifyIcon.Icon = Resources.Logo_Icon;
                }
            }
        }
    }
}
