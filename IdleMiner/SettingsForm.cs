using System;
using System.Windows.Forms;

namespace IdleMiner
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            minerLocationTextBox.Text = Program.Settings.MinerLocation;
            configTextBox.Text = Program.Settings.ConfigFile;
            poolTextBox.Text = Program.Settings.PoolFile;
            idleTimeNumericUpDown.Value = Program.Settings.IdleTime;
            idleCpuCheckBox.CheckState = Program.Settings.IdleCpuEnabled ? CheckState.Checked : CheckState.Unchecked;
            idleCpuTextBox.Text = Program.Settings.IdleCpuFile;
            idleNvidiaCheckBox.CheckState = Program.Settings.IdleNvidiaEnabled ? CheckState.Checked : CheckState.Unchecked;
            idleNvidiaTextBox.Text = Program.Settings.IdleNvidiaFile;
            idleAmdCheckBox.CheckState = Program.Settings.IdleAmdEnabled ? CheckState.Checked : CheckState.Unchecked;
            idleAmdTextBox.Text = Program.Settings.IdleAmdFile;
            activeCpuCheckBox.CheckState = Program.Settings.ActiveCpuEnabled ? CheckState.Checked : CheckState.Unchecked;
            activeCpuTextBox.Text = Program.Settings.ActiveCpuFile;
            activeNvidiaCheckBox.CheckState = Program.Settings.ActiveNvidiaEnabled ? CheckState.Checked : CheckState.Unchecked;
            activeNvidiaTextBox.Text = Program.Settings.ActiveNvidiaFile;
            activeAmdCheckBox.CheckState = Program.Settings.ActiveAmdEnabled ? CheckState.Checked : CheckState.Unchecked;
            activeAmdTextBox.Text = Program.Settings.ActiveAmdFile;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Program.Settings.MinerLocation = minerLocationTextBox.Text;
            Program.Settings.ConfigFile = configTextBox.Text;
            Program.Settings.PoolFile = poolTextBox.Text;
            Program.Settings.IdleTime = idleTimeNumericUpDown.Value;
            Program.Settings.IdleCpuEnabled = idleCpuCheckBox.CheckState == CheckState.Checked ? true : false;
            Program.Settings.IdleCpuFile = idleCpuTextBox.Text;
            Program.Settings.IdleNvidiaEnabled = idleNvidiaCheckBox.CheckState == CheckState.Checked ? true : false;
            Program.Settings.IdleNvidiaFile = idleNvidiaTextBox.Text;
            Program.Settings.IdleAmdEnabled = idleAmdCheckBox.CheckState == CheckState.Checked ? true : false;
            Program.Settings.IdleAmdFile = idleAmdTextBox.Text;
            Program.Settings.ActiveCpuEnabled = activeCpuCheckBox.CheckState == CheckState.Checked ? true : false;
            Program.Settings.ActiveCpuFile = activeCpuTextBox.Text;
            Program.Settings.ActiveNvidiaEnabled = activeNvidiaCheckBox.CheckState == CheckState.Checked ? true : false;
            Program.Settings.ActiveNvidiaFile = activeNvidiaTextBox.Text;
            Program.Settings.ActiveAmdEnabled = activeAmdCheckBox.CheckState == CheckState.Checked ? true : false;
            Program.Settings.ActiveAmdFile = activeAmdTextBox.Text;

            Program.Settings.ToJsonFile();

            Close();

            // Utilize the new settings
            Program.ModifiedSettings = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IdleCpuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                idleCpuTextBox.Enabled = true;
                idleCpuBrowseButton.Enabled = true;
            }
            else
            {
                idleCpuTextBox.Enabled = false;
                idleCpuBrowseButton.Enabled = false;
            }
        }

        private void IdleNvidiaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                idleNvidiaTextBox.Enabled = true;
                idleNvidiaBrowseButton.Enabled = true;
            }
            else
            {
                idleNvidiaTextBox.Enabled = false;
                idleNvidiaBrowseButton.Enabled = false;
            }
        }

        private void IdleAmdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                idleAmdTextBox.Enabled = true;
                idleAmdBrowseButton.Enabled = true;
            }
            else
            {
                idleAmdTextBox.Enabled = false;
                idleAmdBrowseButton.Enabled = false;
            }
        }

        private void ActiveCpuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                activeCpuTextBox.Enabled = true;
                activeCpuBrowseButton.Enabled = true;
            }
            else
            {
                activeCpuTextBox.Enabled = false;
                activeCpuBrowseButton.Enabled = false;
            }
        }

        private void ActiveNvidiaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                activeNvidiaTextBox.Enabled = true;
                activeNvidiaBrowseButton.Enabled = true;
            }
            else
            {
                activeNvidiaTextBox.Enabled = false;
                activeNvidiaBrowseButton.Enabled = false;
            }
        }

        private void ActiveAmdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                activeAmdTextBox.Enabled = true;
                activeAmdBrowseButton.Enabled = true;
            }
            else
            {
                activeAmdTextBox.Enabled = false;
                activeAmdBrowseButton.Enabled = false;
            }
        }

        private void MinerLocationBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                minerLocationTextBox.Text = openFileDialog.FileName;
            }
        }

        private void ConfigBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                configTextBox.Text = openFileDialog.FileName;
            }
        }
        
        private void PoolBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                poolTextBox.Text = openFileDialog.FileName;
            }
        }

        private void IdleCpuBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                idleCpuTextBox.Text = openFileDialog.FileName;
            }
        }

        private void IdleNvidiaBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                idleNvidiaTextBox.Text = openFileDialog.FileName;
            }
        }

        private void IdleAmdBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                idleAmdTextBox.Text = openFileDialog.FileName;
            }
        }

        private void ActiveCpuBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                activeCpuTextBox.Text = openFileDialog.FileName;
            }
        }

        private void ActiveNvidiaBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                activeNvidiaTextBox.Text = openFileDialog.FileName;
            }
        }

        private void ActiveAmdBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                activeAmdTextBox.Text = openFileDialog.FileName;
            }
        }
    }
}
