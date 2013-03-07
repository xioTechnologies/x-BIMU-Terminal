namespace x_BIMU_Terminal
{
    partial class FormTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTerminal));
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSerialPort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemXStick = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetChannel23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVisualiseData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuaternion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGyroscope = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAccelerometer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMagnetometer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBattery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.enterCommandModeCrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCommandModeEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDeviceIDInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printRegisterValuesPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setXBeeChannelCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTXOnlyTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setQuaternionSendRateQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSensorSendRateSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBatterySendRateBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBinaryPacketModeMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAHRSGainGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAHRSModeMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSleepTimerLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGyrAndAccCalibrationWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMagneticCalibrationWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFirmwareUploaderWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemwwwxiocouk = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_packetsRecieved = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_packetsReceived = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPacketRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip_packetsRecieved.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Black;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Cyan;
            this.textBox.Location = new System.Drawing.Point(0, 24);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(584, 318);
            this.textBox.TabIndex = 1;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSerialPort,
            this.toolStripMenuItemXStick,
            this.toolStripMenuItemVisualiseData,
            this.toolStripMenuItemCommands,
            this.toolStripMenuItemTools,
            this.toolStripMenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(584, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItemSerialPort
            // 
            this.toolStripMenuItemSerialPort.Name = "toolStripMenuItemSerialPort";
            this.toolStripMenuItemSerialPort.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItemSerialPort.Text = "Serial Port";
            this.toolStripMenuItemSerialPort.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItemSerialPort_DropDownItemClicked);
            // 
            // toolStripMenuItemXStick
            // 
            this.toolStripMenuItemXStick.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSetChannel12,
            this.toolStripMenuItemSetChannel13,
            this.toolStripMenuItemSetChannel14,
            this.toolStripMenuItemSetChannel15,
            this.toolStripMenuItemSetChannel16,
            this.toolStripMenuItemSetChannel17,
            this.toolStripMenuItemSetChannel18,
            this.toolStripMenuItemSetChannel19,
            this.toolStripMenuItemSetChannel20,
            this.toolStripMenuItemSetChannel21,
            this.toolStripMenuItemSetChannel22,
            this.toolStripMenuItemSetChannel23});
            this.toolStripMenuItemXStick.Name = "toolStripMenuItemXStick";
            this.toolStripMenuItemXStick.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItemXStick.Text = "XStick";
            this.toolStripMenuItemXStick.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItemXStick_DropDownItemClicked);
            // 
            // toolStripMenuItemSetChannel12
            // 
            this.toolStripMenuItemSetChannel12.Name = "toolStripMenuItemSetChannel12";
            this.toolStripMenuItemSetChannel12.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel12.Text = "Set Channel 12 (Blue)";
            // 
            // toolStripMenuItemSetChannel13
            // 
            this.toolStripMenuItemSetChannel13.Name = "toolStripMenuItemSetChannel13";
            this.toolStripMenuItemSetChannel13.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel13.Text = "Set Channel 13 (Violet)";
            // 
            // toolStripMenuItemSetChannel14
            // 
            this.toolStripMenuItemSetChannel14.Name = "toolStripMenuItemSetChannel14";
            this.toolStripMenuItemSetChannel14.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel14.Text = "Set Channel 14 (Magneta)";
            // 
            // toolStripMenuItemSetChannel15
            // 
            this.toolStripMenuItemSetChannel15.Name = "toolStripMenuItemSetChannel15";
            this.toolStripMenuItemSetChannel15.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel15.Text = "Set Channel 15 (Rose)";
            // 
            // toolStripMenuItemSetChannel16
            // 
            this.toolStripMenuItemSetChannel16.Name = "toolStripMenuItemSetChannel16";
            this.toolStripMenuItemSetChannel16.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel16.Text = "Set Channel 16 (Red)";
            // 
            // toolStripMenuItemSetChannel17
            // 
            this.toolStripMenuItemSetChannel17.Name = "toolStripMenuItemSetChannel17";
            this.toolStripMenuItemSetChannel17.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel17.Text = "Set Channel 17 (Orange)";
            // 
            // toolStripMenuItemSetChannel18
            // 
            this.toolStripMenuItemSetChannel18.Name = "toolStripMenuItemSetChannel18";
            this.toolStripMenuItemSetChannel18.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel18.Text = "Set Channel 18 (Yellow)";
            // 
            // toolStripMenuItemSetChannel19
            // 
            this.toolStripMenuItemSetChannel19.Name = "toolStripMenuItemSetChannel19";
            this.toolStripMenuItemSetChannel19.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel19.Text = "Set Channel 19 (Chartreuse)";
            // 
            // toolStripMenuItemSetChannel20
            // 
            this.toolStripMenuItemSetChannel20.Name = "toolStripMenuItemSetChannel20";
            this.toolStripMenuItemSetChannel20.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel20.Text = "Set Channel 20 (Green)";
            // 
            // toolStripMenuItemSetChannel21
            // 
            this.toolStripMenuItemSetChannel21.Name = "toolStripMenuItemSetChannel21";
            this.toolStripMenuItemSetChannel21.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel21.Text = "Set Channel 21 (Spring Green)";
            // 
            // toolStripMenuItemSetChannel22
            // 
            this.toolStripMenuItemSetChannel22.Name = "toolStripMenuItemSetChannel22";
            this.toolStripMenuItemSetChannel22.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel22.Text = "Set Channel 22 (Cyan)";
            // 
            // toolStripMenuItemSetChannel23
            // 
            this.toolStripMenuItemSetChannel23.Name = "toolStripMenuItemSetChannel23";
            this.toolStripMenuItemSetChannel23.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemSetChannel23.Text = "Set Channel 23 (Azure)";
            // 
            // toolStripMenuItemVisualiseData
            // 
            this.toolStripMenuItemVisualiseData.CheckOnClick = true;
            this.toolStripMenuItemVisualiseData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQuaternion,
            this.toolStripMenuItemGyroscope,
            this.toolStripMenuItemAccelerometer,
            this.toolStripMenuItemMagnetometer,
            this.toolStripMenuItemBattery});
            this.toolStripMenuItemVisualiseData.Name = "toolStripMenuItemVisualiseData";
            this.toolStripMenuItemVisualiseData.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItemVisualiseData.Text = "Visualise Data";
            // 
            // toolStripMenuItemQuaternion
            // 
            this.toolStripMenuItemQuaternion.CheckOnClick = true;
            this.toolStripMenuItemQuaternion.Name = "toolStripMenuItemQuaternion";
            this.toolStripMenuItemQuaternion.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItemQuaternion.Text = "Quaternion";
            this.toolStripMenuItemQuaternion.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemQuaternion_CheckStateChanged);
            // 
            // toolStripMenuItemGyroscope
            // 
            this.toolStripMenuItemGyroscope.CheckOnClick = true;
            this.toolStripMenuItemGyroscope.Name = "toolStripMenuItemGyroscope";
            this.toolStripMenuItemGyroscope.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItemGyroscope.Text = "Gyroscope";
            this.toolStripMenuItemGyroscope.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemGyroscope_CheckStateChanged);
            // 
            // toolStripMenuItemAccelerometer
            // 
            this.toolStripMenuItemAccelerometer.CheckOnClick = true;
            this.toolStripMenuItemAccelerometer.Name = "toolStripMenuItemAccelerometer";
            this.toolStripMenuItemAccelerometer.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItemAccelerometer.Text = "Accelerometer";
            this.toolStripMenuItemAccelerometer.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemAccelerometer_CheckStateChanged);
            // 
            // toolStripMenuItemMagnetometer
            // 
            this.toolStripMenuItemMagnetometer.CheckOnClick = true;
            this.toolStripMenuItemMagnetometer.Name = "toolStripMenuItemMagnetometer";
            this.toolStripMenuItemMagnetometer.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItemMagnetometer.Text = "Magnetometer";
            this.toolStripMenuItemMagnetometer.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemMagnetometer_CheckStateChanged);
            // 
            // toolStripMenuItemBattery
            // 
            this.toolStripMenuItemBattery.CheckOnClick = true;
            this.toolStripMenuItemBattery.Name = "toolStripMenuItemBattery";
            this.toolStripMenuItemBattery.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItemBattery.Text = "Battery";
            this.toolStripMenuItemBattery.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemBattery_CheckStateChanged);
            // 
            // toolStripMenuItemCommands
            // 
            this.toolStripMenuItemCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterCommandModeCrToolStripMenuItem,
            this.exitCommandModeEToolStripMenuItem,
            this.setDeviceIDInToolStripMenuItem,
            this.printRegisterValuesPToolStripMenuItem,
            this.setXBeeChannelCHToolStripMenuItem,
            this.setTXOnlyTToolStripMenuItem,
            this.setQuaternionSendRateQToolStripMenuItem,
            this.setSensorSendRateSToolStripMenuItem,
            this.setBatterySendRateBToolStripMenuItem,
            this.setBinaryPacketModeMPToolStripMenuItem,
            this.setAHRSGainGToolStripMenuItem,
            this.setAHRSModeMToolStripMenuItem,
            this.setSleepTimerLToolStripMenuItem});
            this.toolStripMenuItemCommands.Name = "toolStripMenuItemCommands";
            this.toolStripMenuItemCommands.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItemCommands.Text = "Commands";
            this.toolStripMenuItemCommands.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItemCommands_DropDownItemClicked);
            // 
            // enterCommandModeCrToolStripMenuItem
            // 
            this.enterCommandModeCrToolStripMenuItem.Name = "enterCommandModeCrToolStripMenuItem";
            this.enterCommandModeCrToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.enterCommandModeCrToolStripMenuItem.Text = "Enter Command Mode - \"---\"";
            // 
            // exitCommandModeEToolStripMenuItem
            // 
            this.exitCommandModeEToolStripMenuItem.Name = "exitCommandModeEToolStripMenuItem";
            this.exitCommandModeEToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.exitCommandModeEToolStripMenuItem.Text = "Exit Command Mode - \"EX↵\"";
            // 
            // setDeviceIDInToolStripMenuItem
            // 
            this.setDeviceIDInToolStripMenuItem.Name = "setDeviceIDInToolStripMenuItem";
            this.setDeviceIDInToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setDeviceIDInToolStripMenuItem.Text = "Reset Device - \"RD↵\"";
            // 
            // printRegisterValuesPToolStripMenuItem
            // 
            this.printRegisterValuesPToolStripMenuItem.Name = "printRegisterValuesPToolStripMenuItem";
            this.printRegisterValuesPToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.printRegisterValuesPToolStripMenuItem.Text = "Print General Registers - \"PG↵\"";
            // 
            // setXBeeChannelCHToolStripMenuItem
            // 
            this.setXBeeChannelCHToolStripMenuItem.Name = "setXBeeChannelCHToolStripMenuItem";
            this.setXBeeChannelCHToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setXBeeChannelCHToolStripMenuItem.Text = "Set XBee Channel \"CH,#↵\"";
            // 
            // setTXOnlyTToolStripMenuItem
            // 
            this.setTXOnlyTToolStripMenuItem.Name = "setTXOnlyTToolStripMenuItem";
            this.setTXOnlyTToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setTXOnlyTToolStripMenuItem.Text = "Set XBee Low Power Mode - \"LP,#↵\"";
            // 
            // setQuaternionSendRateQToolStripMenuItem
            // 
            this.setQuaternionSendRateQToolStripMenuItem.Name = "setQuaternionSendRateQToolStripMenuItem";
            this.setQuaternionSendRateQToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setQuaternionSendRateQToolStripMenuItem.Text = "Set Quaternion Send Rate \"QR,#↵\"";
            // 
            // setSensorSendRateSToolStripMenuItem
            // 
            this.setSensorSendRateSToolStripMenuItem.Name = "setSensorSendRateSToolStripMenuItem";
            this.setSensorSendRateSToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setSensorSendRateSToolStripMenuItem.Text = "Set Sensor Send Rate \"SR,#↵\"";
            // 
            // setBatterySendRateBToolStripMenuItem
            // 
            this.setBatterySendRateBToolStripMenuItem.Name = "setBatterySendRateBToolStripMenuItem";
            this.setBatterySendRateBToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setBatterySendRateBToolStripMenuItem.Text = "Set Battery Send Rate \"BR,#↵\"";
            // 
            // setBinaryPacketModeMPToolStripMenuItem
            // 
            this.setBinaryPacketModeMPToolStripMenuItem.Name = "setBinaryPacketModeMPToolStripMenuItem";
            this.setBinaryPacketModeMPToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setBinaryPacketModeMPToolStripMenuItem.Text = "Set Binary Packet Mode - \"BP,#↵\"";
            // 
            // setAHRSGainGToolStripMenuItem
            // 
            this.setAHRSGainGToolStripMenuItem.Name = "setAHRSGainGToolStripMenuItem";
            this.setAHRSGainGToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setAHRSGainGToolStripMenuItem.Text = "Set AHRS Gain - \"AG,#↵\"";
            // 
            // setAHRSModeMToolStripMenuItem
            // 
            this.setAHRSModeMToolStripMenuItem.Name = "setAHRSModeMToolStripMenuItem";
            this.setAHRSModeMToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setAHRSModeMToolStripMenuItem.Text = "Set AHRS No Magnetometer Mode - \"AM,#↵\"";
            // 
            // setSleepTimerLToolStripMenuItem
            // 
            this.setSleepTimerLToolStripMenuItem.Name = "setSleepTimerLToolStripMenuItem";
            this.setSleepTimerLToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setSleepTimerLToolStripMenuItem.Text = "Set Sleep Timer - \"ST,#↵\"";
            // 
            // toolStripMenuItemTools
            // 
            this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGyrAndAccCalibrationWizard,
            this.toolStripMenuItemMagneticCalibrationWizard,
            this.toolStripMenuItemFirmwareUploaderWizard});
            this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
            this.toolStripMenuItemTools.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemTools.Text = "Tools";
            // 
            // toolStripMenuItemGyrAndAccCalibrationWizard
            // 
            this.toolStripMenuItemGyrAndAccCalibrationWizard.Name = "toolStripMenuItemGyrAndAccCalibrationWizard";
            this.toolStripMenuItemGyrAndAccCalibrationWizard.Size = new System.Drawing.Size(335, 22);
            this.toolStripMenuItemGyrAndAccCalibrationWizard.Text = "Gyroscope And Accelerometer Calibration Wizard";
            this.toolStripMenuItemGyrAndAccCalibrationWizard.Click += new System.EventHandler(this.toolStripMenuItemGyrAndAccCalWizard_Click);
            // 
            // toolStripMenuItemMagneticCalibrationWizard
            // 
            this.toolStripMenuItemMagneticCalibrationWizard.Name = "toolStripMenuItemMagneticCalibrationWizard";
            this.toolStripMenuItemMagneticCalibrationWizard.Size = new System.Drawing.Size(335, 22);
            this.toolStripMenuItemMagneticCalibrationWizard.Text = "Magnetic Calibration Wizard";
            this.toolStripMenuItemMagneticCalibrationWizard.Click += new System.EventHandler(this.toolStripMenuItemMagCalWizard_Click);
            // 
            // toolStripMenuItemFirmwareUploaderWizard
            // 
            this.toolStripMenuItemFirmwareUploaderWizard.Name = "toolStripMenuItemFirmwareUploaderWizard";
            this.toolStripMenuItemFirmwareUploaderWizard.Size = new System.Drawing.Size(335, 22);
            this.toolStripMenuItemFirmwareUploaderWizard.Text = "Firmware Uploader Wizard";
            this.toolStripMenuItemFirmwareUploaderWizard.Click += new System.EventHandler(this.toolStripMenuItemFirmwareUploaderWizard_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemwwwxiocouk});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemAbout.Text = "About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemwwwxiocouk
            // 
            this.toolStripMenuItemwwwxiocouk.Name = "toolStripMenuItemwwwxiocouk";
            this.toolStripMenuItemwwwxiocouk.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemwwwxiocouk.Text = "www.x-io.co.uk";
            this.toolStripMenuItemwwwxiocouk.Click += new System.EventHandler(this.toolStripMenuItemwwwxiocouk_Click);
            // 
            // statusStrip_packetsRecieved
            // 
            this.statusStrip_packetsRecieved.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_packetsReceived,
            this.toolStripStatusLabelPacketRate});
            this.statusStrip_packetsRecieved.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip_packetsRecieved.Location = new System.Drawing.Point(0, 342);
            this.statusStrip_packetsRecieved.Name = "statusStrip_packetsRecieved";
            this.statusStrip_packetsRecieved.Size = new System.Drawing.Size(584, 20);
            this.statusStrip_packetsRecieved.TabIndex = 2;
            this.statusStrip_packetsRecieved.Text = "Packets Received:";
            // 
            // toolStripStatusLabel_packetsReceived
            // 
            this.toolStripStatusLabel_packetsReceived.Name = "toolStripStatusLabel_packetsReceived";
            this.toolStripStatusLabel_packetsReceived.Size = new System.Drawing.Size(204, 15);
            this.toolStripStatusLabel_packetsReceived.Text = "toolStripStatusLabel_packetsReceived";
            // 
            // toolStripStatusLabelPacketRate
            // 
            this.toolStripStatusLabelPacketRate.Name = "toolStripStatusLabelPacketRate";
            this.toolStripStatusLabelPacketRate.Size = new System.Drawing.Size(170, 15);
            this.toolStripStatusLabelPacketRate.Text = "toolStripStatusLabelPacketRate";
            // 
            // FormTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.statusStrip_packetsRecieved);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormTerminal";
            this.Text = "FormTerminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTerminal_FormClosed);
            this.Load += new System.EventHandler(this.FormTerminal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip_packetsRecieved.ResumeLayout(false);
            this.statusStrip_packetsRecieved.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSerialPort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVisualiseData;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBattery;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGyroscope;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccelerometer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMagnetometer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuaternion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemwwwxiocouk;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMagneticCalibrationWizard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommands;
        private System.Windows.Forms.ToolStripMenuItem enterCommandModeCrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printRegisterValuesPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDeviceIDInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setQuaternionSendRateQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSensorSendRateSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBatterySendRateBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAHRSModeMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAHRSGainGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSleepTimerLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTXOnlyTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitCommandModeEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setXBeeChannelCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGyrAndAccCalibrationWizard;
        private System.Windows.Forms.StatusStrip statusStrip_packetsRecieved;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_packetsReceived;
        private System.Windows.Forms.ToolStripMenuItem setBinaryPacketModeMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPacketRate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemXStick;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetChannel21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFirmwareUploaderWizard;
    }
}

