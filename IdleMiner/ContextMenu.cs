using System;
using System.Windows.Forms;
using IdleMiner.Properties;

namespace IdleMiner
{
    class ContextMenu
    {
        private bool isAboutLoaded = false;
        private bool isSettingsLoaded = false;

        public ContextMenuStrip Create()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Settings
            item = new ToolStripMenuItem();
            item.Text = "Settings";
            item.Click += new EventHandler(Settings_Click);
            //item.Image = Resources.Settings;
            menu.Items.Add(item);

            // About
            item = new ToolStripMenuItem();
            item.Text = "About";
            item.Click += new EventHandler(About_Click);
            //item.Image = Resources.About;
            menu.Items.Add(item);

            // Separator
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Exit
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new EventHandler(Exit_Click);
            //item.Image = Resources.Exit;
            menu.Items.Add(item);

            return menu;
        }

        void Settings_Click(object sender, EventArgs e)
        {
            if (!isSettingsLoaded)
            {
                isSettingsLoaded = true;
                new SettingsForm().ShowDialog();
                isSettingsLoaded = false;
            }
        }

        void About_Click(object sender, EventArgs e)
        {
            if (!isAboutLoaded)
            {
                isAboutLoaded = true;
                new AboutBox().ShowDialog();
                isAboutLoaded = false;
            }
        }

        void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
