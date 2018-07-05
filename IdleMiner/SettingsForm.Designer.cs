namespace IdleMiner
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.idleTimeLabel = new System.Windows.Forms.Label();
            this.minerLocationTextBox = new System.Windows.Forms.TextBox();
            this.minerLocationLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.minerLocationBrowseButton = new System.Windows.Forms.Button();
            this.idleGroupBox = new System.Windows.Forms.GroupBox();
            this.idleAmdCheckBox = new System.Windows.Forms.CheckBox();
            this.idleNvidiaCheckBox = new System.Windows.Forms.CheckBox();
            this.idleCpuCheckBox = new System.Windows.Forms.CheckBox();
            this.idleAmdBrowseButton = new System.Windows.Forms.Button();
            this.idleNvidiaBrowseButton = new System.Windows.Forms.Button();
            this.idleCpuBrowseButton = new System.Windows.Forms.Button();
            this.idleAmdTextBox = new System.Windows.Forms.TextBox();
            this.idleNvidiaTextBox = new System.Windows.Forms.TextBox();
            this.idleCpuTextBox = new System.Windows.Forms.TextBox();
            this.configBrowseButton = new System.Windows.Forms.Button();
            this.configTextBox = new System.Windows.Forms.TextBox();
            this.configLabel = new System.Windows.Forms.Label();
            this.activeGroupBox = new System.Windows.Forms.GroupBox();
            this.activeCpuUsageUnitsLabel = new System.Windows.Forms.Label();
            this.activeCpuUsageLabel = new System.Windows.Forms.Label();
            this.activeCpuUsageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activeAmdCheckBox = new System.Windows.Forms.CheckBox();
            this.activeNvidiaCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCpuCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCpuTextBox = new System.Windows.Forms.TextBox();
            this.activeAmdBrowseButton = new System.Windows.Forms.Button();
            this.activeNvidiaTextBox = new System.Windows.Forms.TextBox();
            this.activeNvidiaBrowseButton = new System.Windows.Forms.Button();
            this.activeAmdTextBox = new System.Windows.Forms.TextBox();
            this.activeCpuBrowseButton = new System.Windows.Forms.Button();
            this.idleTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idleTimeUnitsLabel = new System.Windows.Forms.Label();
            this.poolBrowseButton = new System.Windows.Forms.Button();
            this.poolTextBox = new System.Windows.Forms.TextBox();
            this.poolLabel = new System.Windows.Forms.Label();
            this.idleGroupBox.SuspendLayout();
            this.activeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCpuUsageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idleTimeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(322, 354);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(403, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // idleTimeLabel
            // 
            this.idleTimeLabel.AutoSize = true;
            this.idleTimeLabel.Location = new System.Drawing.Point(19, 86);
            this.idleTimeLabel.Name = "idleTimeLabel";
            this.idleTimeLabel.Size = new System.Drawing.Size(50, 13);
            this.idleTimeLabel.TabIndex = 2;
            this.idleTimeLabel.Text = "Idle Time";
            // 
            // minerLocationTextBox
            // 
            this.minerLocationTextBox.Location = new System.Drawing.Point(108, 6);
            this.minerLocationTextBox.Name = "minerLocationTextBox";
            this.minerLocationTextBox.ReadOnly = true;
            this.minerLocationTextBox.Size = new System.Drawing.Size(302, 20);
            this.minerLocationTextBox.TabIndex = 2;
            // 
            // minerLocationLabel
            // 
            this.minerLocationLabel.AutoSize = true;
            this.minerLocationLabel.Location = new System.Drawing.Point(19, 9);
            this.minerLocationLabel.Name = "minerLocationLabel";
            this.minerLocationLabel.Size = new System.Drawing.Size(88, 13);
            this.minerLocationLabel.TabIndex = 6;
            this.minerLocationLabel.Text = "Miner Application";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "exe";
            // 
            // minerLocationBrowseButton
            // 
            this.minerLocationBrowseButton.Location = new System.Drawing.Point(416, 4);
            this.minerLocationBrowseButton.Name = "minerLocationBrowseButton";
            this.minerLocationBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.minerLocationBrowseButton.TabIndex = 3;
            this.minerLocationBrowseButton.Text = "Browse";
            this.minerLocationBrowseButton.UseVisualStyleBackColor = true;
            this.minerLocationBrowseButton.Click += new System.EventHandler(this.MinerLocationBrowseButton_Click);
            // 
            // idleGroupBox
            // 
            this.idleGroupBox.Controls.Add(this.idleAmdCheckBox);
            this.idleGroupBox.Controls.Add(this.idleNvidiaCheckBox);
            this.idleGroupBox.Controls.Add(this.idleCpuCheckBox);
            this.idleGroupBox.Controls.Add(this.idleAmdBrowseButton);
            this.idleGroupBox.Controls.Add(this.idleNvidiaBrowseButton);
            this.idleGroupBox.Controls.Add(this.idleCpuBrowseButton);
            this.idleGroupBox.Controls.Add(this.idleAmdTextBox);
            this.idleGroupBox.Controls.Add(this.idleNvidiaTextBox);
            this.idleGroupBox.Controls.Add(this.idleCpuTextBox);
            this.idleGroupBox.Location = new System.Drawing.Point(12, 110);
            this.idleGroupBox.Name = "idleGroupBox";
            this.idleGroupBox.Size = new System.Drawing.Size(467, 101);
            this.idleGroupBox.TabIndex = 9;
            this.idleGroupBox.TabStop = false;
            this.idleGroupBox.Text = "Idle Settings";
            // 
            // idleAmdCheckBox
            // 
            this.idleAmdCheckBox.AutoSize = true;
            this.idleAmdCheckBox.Location = new System.Drawing.Point(10, 73);
            this.idleAmdCheckBox.Name = "idleAmdCheckBox";
            this.idleAmdCheckBox.Size = new System.Drawing.Size(50, 17);
            this.idleAmdCheckBox.TabIndex = 13;
            this.idleAmdCheckBox.Text = "AMD";
            this.idleAmdCheckBox.UseVisualStyleBackColor = true;
            this.idleAmdCheckBox.CheckedChanged += new System.EventHandler(this.IdleAmdCheckBox_CheckedChanged);
            // 
            // idleNvidiaCheckBox
            // 
            this.idleNvidiaCheckBox.AutoSize = true;
            this.idleNvidiaCheckBox.Location = new System.Drawing.Point(10, 47);
            this.idleNvidiaCheckBox.Name = "idleNvidiaCheckBox";
            this.idleNvidiaCheckBox.Size = new System.Drawing.Size(62, 17);
            this.idleNvidiaCheckBox.TabIndex = 10;
            this.idleNvidiaCheckBox.Text = "NVIDIA";
            this.idleNvidiaCheckBox.UseVisualStyleBackColor = true;
            this.idleNvidiaCheckBox.CheckedChanged += new System.EventHandler(this.IdleNvidiaCheckBox_CheckedChanged);
            // 
            // idleCpuCheckBox
            // 
            this.idleCpuCheckBox.AutoSize = true;
            this.idleCpuCheckBox.Location = new System.Drawing.Point(10, 19);
            this.idleCpuCheckBox.Name = "idleCpuCheckBox";
            this.idleCpuCheckBox.Size = new System.Drawing.Size(48, 17);
            this.idleCpuCheckBox.TabIndex = 7;
            this.idleCpuCheckBox.Text = "CPU";
            this.idleCpuCheckBox.UseVisualStyleBackColor = true;
            this.idleCpuCheckBox.CheckedChanged += new System.EventHandler(this.IdleCpuCheckBox_CheckedChanged);
            // 
            // idleAmdBrowseButton
            // 
            this.idleAmdBrowseButton.Enabled = false;
            this.idleAmdBrowseButton.Location = new System.Drawing.Point(404, 69);
            this.idleAmdBrowseButton.Name = "idleAmdBrowseButton";
            this.idleAmdBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.idleAmdBrowseButton.TabIndex = 15;
            this.idleAmdBrowseButton.Text = "Browse";
            this.idleAmdBrowseButton.UseVisualStyleBackColor = true;
            this.idleAmdBrowseButton.Click += new System.EventHandler(this.IdleAmdBrowseButton_Click);
            // 
            // idleNvidiaBrowseButton
            // 
            this.idleNvidiaBrowseButton.Enabled = false;
            this.idleNvidiaBrowseButton.Location = new System.Drawing.Point(404, 43);
            this.idleNvidiaBrowseButton.Name = "idleNvidiaBrowseButton";
            this.idleNvidiaBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.idleNvidiaBrowseButton.TabIndex = 12;
            this.idleNvidiaBrowseButton.Text = "Browse";
            this.idleNvidiaBrowseButton.UseVisualStyleBackColor = true;
            this.idleNvidiaBrowseButton.Click += new System.EventHandler(this.IdleNvidiaBrowseButton_Click);
            // 
            // idleCpuBrowseButton
            // 
            this.idleCpuBrowseButton.Enabled = false;
            this.idleCpuBrowseButton.Location = new System.Drawing.Point(404, 17);
            this.idleCpuBrowseButton.Name = "idleCpuBrowseButton";
            this.idleCpuBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.idleCpuBrowseButton.TabIndex = 9;
            this.idleCpuBrowseButton.Text = "Browse";
            this.idleCpuBrowseButton.UseVisualStyleBackColor = true;
            this.idleCpuBrowseButton.Click += new System.EventHandler(this.IdleCpuBrowseButton_Click);
            // 
            // idleAmdTextBox
            // 
            this.idleAmdTextBox.Enabled = false;
            this.idleAmdTextBox.Location = new System.Drawing.Point(96, 71);
            this.idleAmdTextBox.Name = "idleAmdTextBox";
            this.idleAmdTextBox.ReadOnly = true;
            this.idleAmdTextBox.Size = new System.Drawing.Size(302, 20);
            this.idleAmdTextBox.TabIndex = 14;
            // 
            // idleNvidiaTextBox
            // 
            this.idleNvidiaTextBox.Enabled = false;
            this.idleNvidiaTextBox.Location = new System.Drawing.Point(96, 45);
            this.idleNvidiaTextBox.Name = "idleNvidiaTextBox";
            this.idleNvidiaTextBox.ReadOnly = true;
            this.idleNvidiaTextBox.Size = new System.Drawing.Size(302, 20);
            this.idleNvidiaTextBox.TabIndex = 11;
            // 
            // idleCpuTextBox
            // 
            this.idleCpuTextBox.Enabled = false;
            this.idleCpuTextBox.Location = new System.Drawing.Point(96, 19);
            this.idleCpuTextBox.Name = "idleCpuTextBox";
            this.idleCpuTextBox.ReadOnly = true;
            this.idleCpuTextBox.Size = new System.Drawing.Size(302, 20);
            this.idleCpuTextBox.TabIndex = 8;
            // 
            // configBrowseButton
            // 
            this.configBrowseButton.Location = new System.Drawing.Point(416, 30);
            this.configBrowseButton.Name = "configBrowseButton";
            this.configBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.configBrowseButton.TabIndex = 6;
            this.configBrowseButton.Text = "Browse";
            this.configBrowseButton.UseVisualStyleBackColor = true;
            this.configBrowseButton.Click += new System.EventHandler(this.ConfigBrowseButton_Click);
            // 
            // configTextBox
            // 
            this.configTextBox.Location = new System.Drawing.Point(108, 32);
            this.configTextBox.Name = "configTextBox";
            this.configTextBox.ReadOnly = true;
            this.configTextBox.Size = new System.Drawing.Size(302, 20);
            this.configTextBox.TabIndex = 5;
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Location = new System.Drawing.Point(19, 35);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(56, 13);
            this.configLabel.TabIndex = 0;
            this.configLabel.Text = "Config File";
            // 
            // activeGroupBox
            // 
            this.activeGroupBox.Controls.Add(this.activeCpuUsageUnitsLabel);
            this.activeGroupBox.Controls.Add(this.activeCpuUsageLabel);
            this.activeGroupBox.Controls.Add(this.activeCpuUsageNumericUpDown);
            this.activeGroupBox.Controls.Add(this.activeAmdCheckBox);
            this.activeGroupBox.Controls.Add(this.activeNvidiaCheckBox);
            this.activeGroupBox.Controls.Add(this.activeCpuCheckBox);
            this.activeGroupBox.Controls.Add(this.activeCpuTextBox);
            this.activeGroupBox.Controls.Add(this.activeAmdBrowseButton);
            this.activeGroupBox.Controls.Add(this.activeNvidiaTextBox);
            this.activeGroupBox.Controls.Add(this.activeNvidiaBrowseButton);
            this.activeGroupBox.Controls.Add(this.activeAmdTextBox);
            this.activeGroupBox.Controls.Add(this.activeCpuBrowseButton);
            this.activeGroupBox.Location = new System.Drawing.Point(12, 217);
            this.activeGroupBox.Name = "activeGroupBox";
            this.activeGroupBox.Size = new System.Drawing.Size(467, 127);
            this.activeGroupBox.TabIndex = 10;
            this.activeGroupBox.TabStop = false;
            this.activeGroupBox.Text = "Active Settings";
            // 
            // activeCpuUsageUnitsLabel
            // 
            this.activeCpuUsageUnitsLabel.AutoSize = true;
            this.activeCpuUsageUnitsLabel.Enabled = false;
            this.activeCpuUsageUnitsLabel.Location = new System.Drawing.Point(166, 45);
            this.activeCpuUsageUnitsLabel.Name = "activeCpuUsageUnitsLabel";
            this.activeCpuUsageUnitsLabel.Size = new System.Drawing.Size(15, 13);
            this.activeCpuUsageUnitsLabel.TabIndex = 29;
            this.activeCpuUsageUnitsLabel.Text = "%";
            // 
            // activeCpuUsageLabel
            // 
            this.activeCpuUsageLabel.AutoSize = true;
            this.activeCpuUsageLabel.Enabled = false;
            this.activeCpuUsageLabel.Location = new System.Drawing.Point(7, 45);
            this.activeCpuUsageLabel.Name = "activeCpuUsageLabel";
            this.activeCpuUsageLabel.Size = new System.Drawing.Size(63, 13);
            this.activeCpuUsageLabel.TabIndex = 28;
            this.activeCpuUsageLabel.Text = "CPU Usage";
            // 
            // activeCpuUsageNumericUpDown
            // 
            this.activeCpuUsageNumericUpDown.Enabled = false;
            this.activeCpuUsageNumericUpDown.Location = new System.Drawing.Point(96, 43);
            this.activeCpuUsageNumericUpDown.Name = "activeCpuUsageNumericUpDown";
            this.activeCpuUsageNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.activeCpuUsageNumericUpDown.TabIndex = 27;
            this.activeCpuUsageNumericUpDown.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // activeAmdCheckBox
            // 
            this.activeAmdCheckBox.AutoSize = true;
            this.activeAmdCheckBox.Location = new System.Drawing.Point(10, 97);
            this.activeAmdCheckBox.Name = "activeAmdCheckBox";
            this.activeAmdCheckBox.Size = new System.Drawing.Size(50, 17);
            this.activeAmdCheckBox.TabIndex = 24;
            this.activeAmdCheckBox.Text = "AMD";
            this.activeAmdCheckBox.UseVisualStyleBackColor = true;
            this.activeAmdCheckBox.CheckedChanged += new System.EventHandler(this.ActiveAmdCheckBox_CheckedChanged);
            // 
            // activeNvidiaCheckBox
            // 
            this.activeNvidiaCheckBox.AutoSize = true;
            this.activeNvidiaCheckBox.Location = new System.Drawing.Point(10, 71);
            this.activeNvidiaCheckBox.Name = "activeNvidiaCheckBox";
            this.activeNvidiaCheckBox.Size = new System.Drawing.Size(62, 17);
            this.activeNvidiaCheckBox.TabIndex = 21;
            this.activeNvidiaCheckBox.Text = "NVIDIA";
            this.activeNvidiaCheckBox.UseVisualStyleBackColor = true;
            this.activeNvidiaCheckBox.CheckedChanged += new System.EventHandler(this.ActiveNvidiaCheckBox_CheckedChanged);
            // 
            // activeCpuCheckBox
            // 
            this.activeCpuCheckBox.AutoSize = true;
            this.activeCpuCheckBox.Location = new System.Drawing.Point(10, 19);
            this.activeCpuCheckBox.Name = "activeCpuCheckBox";
            this.activeCpuCheckBox.Size = new System.Drawing.Size(48, 17);
            this.activeCpuCheckBox.TabIndex = 18;
            this.activeCpuCheckBox.Text = "CPU";
            this.activeCpuCheckBox.UseVisualStyleBackColor = true;
            this.activeCpuCheckBox.CheckedChanged += new System.EventHandler(this.ActiveCpuCheckBox_CheckedChanged);
            // 
            // activeCpuTextBox
            // 
            this.activeCpuTextBox.Enabled = false;
            this.activeCpuTextBox.Location = new System.Drawing.Point(96, 17);
            this.activeCpuTextBox.Name = "activeCpuTextBox";
            this.activeCpuTextBox.ReadOnly = true;
            this.activeCpuTextBox.Size = new System.Drawing.Size(302, 20);
            this.activeCpuTextBox.TabIndex = 19;
            // 
            // activeAmdBrowseButton
            // 
            this.activeAmdBrowseButton.Enabled = false;
            this.activeAmdBrowseButton.Location = new System.Drawing.Point(404, 93);
            this.activeAmdBrowseButton.Name = "activeAmdBrowseButton";
            this.activeAmdBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.activeAmdBrowseButton.TabIndex = 26;
            this.activeAmdBrowseButton.Text = "Browse";
            this.activeAmdBrowseButton.UseVisualStyleBackColor = true;
            this.activeAmdBrowseButton.Click += new System.EventHandler(this.ActiveAmdBrowseButton_Click);
            // 
            // activeNvidiaTextBox
            // 
            this.activeNvidiaTextBox.Enabled = false;
            this.activeNvidiaTextBox.Location = new System.Drawing.Point(96, 69);
            this.activeNvidiaTextBox.Name = "activeNvidiaTextBox";
            this.activeNvidiaTextBox.ReadOnly = true;
            this.activeNvidiaTextBox.Size = new System.Drawing.Size(302, 20);
            this.activeNvidiaTextBox.TabIndex = 22;
            // 
            // activeNvidiaBrowseButton
            // 
            this.activeNvidiaBrowseButton.Enabled = false;
            this.activeNvidiaBrowseButton.Location = new System.Drawing.Point(404, 67);
            this.activeNvidiaBrowseButton.Name = "activeNvidiaBrowseButton";
            this.activeNvidiaBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.activeNvidiaBrowseButton.TabIndex = 23;
            this.activeNvidiaBrowseButton.Text = "Browse";
            this.activeNvidiaBrowseButton.UseVisualStyleBackColor = true;
            this.activeNvidiaBrowseButton.Click += new System.EventHandler(this.ActiveNvidiaBrowseButton_Click);
            // 
            // activeAmdTextBox
            // 
            this.activeAmdTextBox.Enabled = false;
            this.activeAmdTextBox.Location = new System.Drawing.Point(96, 95);
            this.activeAmdTextBox.Name = "activeAmdTextBox";
            this.activeAmdTextBox.ReadOnly = true;
            this.activeAmdTextBox.Size = new System.Drawing.Size(302, 20);
            this.activeAmdTextBox.TabIndex = 25;
            // 
            // activeCpuBrowseButton
            // 
            this.activeCpuBrowseButton.Enabled = false;
            this.activeCpuBrowseButton.Location = new System.Drawing.Point(404, 15);
            this.activeCpuBrowseButton.Name = "activeCpuBrowseButton";
            this.activeCpuBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.activeCpuBrowseButton.TabIndex = 20;
            this.activeCpuBrowseButton.Text = "Browse";
            this.activeCpuBrowseButton.UseVisualStyleBackColor = true;
            this.activeCpuBrowseButton.Click += new System.EventHandler(this.ActiveCpuBrowseButton_Click);
            // 
            // idleTimeNumericUpDown
            // 
            this.idleTimeNumericUpDown.Location = new System.Drawing.Point(108, 84);
            this.idleTimeNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.idleTimeNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.idleTimeNumericUpDown.Name = "idleTimeNumericUpDown";
            this.idleTimeNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.idleTimeNumericUpDown.TabIndex = 4;
            this.idleTimeNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // idleTimeUnitsLabel
            // 
            this.idleTimeUnitsLabel.AutoSize = true;
            this.idleTimeUnitsLabel.Location = new System.Drawing.Point(178, 86);
            this.idleTimeUnitsLabel.Name = "idleTimeUnitsLabel";
            this.idleTimeUnitsLabel.Size = new System.Drawing.Size(47, 13);
            this.idleTimeUnitsLabel.TabIndex = 12;
            this.idleTimeUnitsLabel.Text = "seconds";
            // 
            // poolBrowseButton
            // 
            this.poolBrowseButton.Location = new System.Drawing.Point(416, 56);
            this.poolBrowseButton.Name = "poolBrowseButton";
            this.poolBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.poolBrowseButton.TabIndex = 15;
            this.poolBrowseButton.Text = "Browse";
            this.poolBrowseButton.UseVisualStyleBackColor = true;
            this.poolBrowseButton.Click += new System.EventHandler(this.PoolBrowseButton_Click);
            // 
            // poolTextBox
            // 
            this.poolTextBox.Location = new System.Drawing.Point(108, 58);
            this.poolTextBox.Name = "poolTextBox";
            this.poolTextBox.ReadOnly = true;
            this.poolTextBox.Size = new System.Drawing.Size(302, 20);
            this.poolTextBox.TabIndex = 14;
            // 
            // poolLabel
            // 
            this.poolLabel.AutoSize = true;
            this.poolLabel.Location = new System.Drawing.Point(19, 61);
            this.poolLabel.Name = "poolLabel";
            this.poolLabel.Size = new System.Drawing.Size(47, 13);
            this.poolLabel.TabIndex = 13;
            this.poolLabel.Text = "Pool File";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 389);
            this.Controls.Add(this.poolBrowseButton);
            this.Controls.Add(this.poolTextBox);
            this.Controls.Add(this.poolLabel);
            this.Controls.Add(this.idleTimeUnitsLabel);
            this.Controls.Add(this.idleTimeNumericUpDown);
            this.Controls.Add(this.activeGroupBox);
            this.Controls.Add(this.idleGroupBox);
            this.Controls.Add(this.minerLocationBrowseButton);
            this.Controls.Add(this.minerLocationTextBox);
            this.Controls.Add(this.configBrowseButton);
            this.Controls.Add(this.minerLocationLabel);
            this.Controls.Add(this.idleTimeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.configTextBox);
            this.Controls.Add(this.configLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "IdleMiner Settings";
            this.idleGroupBox.ResumeLayout(false);
            this.idleGroupBox.PerformLayout();
            this.activeGroupBox.ResumeLayout(false);
            this.activeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCpuUsageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idleTimeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label idleTimeLabel;
        private System.Windows.Forms.TextBox minerLocationTextBox;
        private System.Windows.Forms.Label minerLocationLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button minerLocationBrowseButton;
        private System.Windows.Forms.GroupBox idleGroupBox;
        private System.Windows.Forms.TextBox idleAmdTextBox;
        private System.Windows.Forms.TextBox idleNvidiaTextBox;
        private System.Windows.Forms.TextBox idleCpuTextBox;
        private System.Windows.Forms.TextBox configTextBox;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.GroupBox activeGroupBox;
        private System.Windows.Forms.NumericUpDown idleTimeNumericUpDown;
        private System.Windows.Forms.Button idleAmdBrowseButton;
        private System.Windows.Forms.Button idleNvidiaBrowseButton;
        private System.Windows.Forms.Button idleCpuBrowseButton;
        private System.Windows.Forms.Button configBrowseButton;
        private System.Windows.Forms.Label idleTimeUnitsLabel;
        private System.Windows.Forms.CheckBox idleAmdCheckBox;
        private System.Windows.Forms.CheckBox idleNvidiaCheckBox;
        private System.Windows.Forms.CheckBox idleCpuCheckBox;
        private System.Windows.Forms.CheckBox activeAmdCheckBox;
        private System.Windows.Forms.CheckBox activeNvidiaCheckBox;
        private System.Windows.Forms.CheckBox activeCpuCheckBox;
        private System.Windows.Forms.TextBox activeCpuTextBox;
        private System.Windows.Forms.Button activeAmdBrowseButton;
        private System.Windows.Forms.TextBox activeNvidiaTextBox;
        private System.Windows.Forms.Button activeNvidiaBrowseButton;
        private System.Windows.Forms.TextBox activeAmdTextBox;
        private System.Windows.Forms.Button activeCpuBrowseButton;
        private System.Windows.Forms.Button poolBrowseButton;
        private System.Windows.Forms.TextBox poolTextBox;
        private System.Windows.Forms.Label poolLabel;
        private System.Windows.Forms.Label activeCpuUsageLabel;
        private System.Windows.Forms.NumericUpDown activeCpuUsageNumericUpDown;
        private System.Windows.Forms.Label activeCpuUsageUnitsLabel;
    }
}