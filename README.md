# IdleMiner

This program allows you to mine cryptocurrency while still being able to utilize your machine without having to manually start/stop the mining application.
It does this by defining `idle` and `active` settings. For example, it can mine at maximum hash rates (utilizing all CPU and GPU resources) while you are idle
and either disabled or reduced hash rates (minimal CPU and GPU resources) while you are active on the machine.

**Note:** Currently only the [xmr-stak](https://github.com/fireice-uk/xmr-stak) mining application is supported.

## Getting Started

**Note:** [xmr-stak](https://github.com/fireice-uk/xmr-stak) must already be downloaded and configured.

1. Download the latest IdleMiner [release](https://github.com/devinbileck/IdleMiner/releases/latest).
2. Extract the zip file into the same folder as xmr-stak.
3. Run IdleMiner.exe - It will show up in the Windows system tray (notification area) as a pickaxe icon.

![System Tray](https://image.ibb.co/n5jL1d/Idle_Miner_System_Tray.png "System Tray")

4. Right click on the icon and select the Settings option. Configure your settings as desired and click OK to begin mining.

![Settings Dialog](https://image.ibb.co/emRfd9/Idle_Miner_Settings.png "Settings Dialog")