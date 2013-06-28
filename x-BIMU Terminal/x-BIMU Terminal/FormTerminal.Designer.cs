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
            this.enterCommandModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCommandModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printGeneralRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setXBeeChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setXBeeLowPowerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setQuaternionSendRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSensorSendRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBatterySendRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBinaryPacketModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAHRSGainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAHRSModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSleepTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGyrAndAccCalibrationWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMagneticCalibrationWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFirmwareUploadWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSourceCode = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPacketsReceived = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPacketRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.printCommandListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoryResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.enterCommandModeToolStripMenuItem,
            this.exitCommandModeToolStripMenuItem,
            this.printCommandListToolStripMenuItem,
            this.factoryResetToolStripMenuItem,
            this.deviceResetToolStripMenuItem,
            this.printGeneralRegistersToolStripMenuItem,
            this.setXBeeChannelToolStripMenuItem,
            this.setXBeeLowPowerModeToolStripMenuItem,
            this.setQuaternionSendRateToolStripMenuItem,
            this.setSensorSendRateToolStripMenuItem,
            this.setBatterySendRateToolStripMenuItem,
            this.setBinaryPacketModeToolStripMenuItem,
            this.setAHRSGainToolStripMenuItem,
            this.setAHRSModeToolStripMenuItem,
            this.setSleepTimerToolStripMenuItem});
            this.toolStripMenuItemCommands.Name = "toolStripMenuItemCommands";
            this.toolStripMenuItemCommands.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItemCommands.Text = "Commands";
            this.toolStripMenuItemCommands.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItemCommands_DropDownItemClicked);
            // 
            // enterCommandModeToolStripMenuItem
            // 
            this.enterCommandModeToolStripMenuItem.Name = "enterCommandModeToolStripMenuItem";
            this.enterCommandModeToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.enterCommandModeToolStripMenuItem.Text = "Enter Command Mode - \"---\"";
            // 
            // exitCommandModeToolStripMenuItem
            // 
            this.exitCommandModeToolStripMenuItem.Name = "exitCommandModeToolStripMenuItem";
            this.exitCommandModeToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.exitCommandModeToolStripMenuItem.Text = "Exit Command Mode - \"EX↵\"";
            // 
            // deviceResetToolStripMenuItem
            // 
            this.deviceResetToolStripMenuItem.Name = "deviceResetToolStripMenuItem";
            this.deviceResetToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.deviceResetToolStripMenuItem.Text = "Reset Device - \"RD↵\"";
            // 
            // printGeneralRegistersToolStripMenuItem
            // 
            this.printGeneralRegistersToolStripMenuItem.Name = "printGeneralRegistersToolStripMenuItem";
            this.printGeneralRegistersToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.printGeneralRegistersToolStripMenuItem.Text = "Print General Registers - \"PG↵\"";
            // 
            // setXBeeChannelToolStripMenuItem
            // 
            this.setXBeeChannelToolStripMenuItem.Name = "setXBeeChannelToolStripMenuItem";
            this.setXBeeChannelToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setXBeeChannelToolStripMenuItem.Text = "Set XBee Channel \"CH,#↵\"";
            // 
            // setXBeeLowPowerModeToolStripMenuItem
            // 
            this.setXBeeLowPowerModeToolStripMenuItem.Name = "setXBeeLowPowerModeToolStripMenuItem";
            this.setXBeeLowPowerModeToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setXBeeLowPowerModeToolStripMenuItem.Text = "Set XBee Low Power Mode - \"LP,#↵\"";
            // 
            // setQuaternionSendRateToolStripMenuItem
            // 
            this.setQuaternionSendRateToolStripMenuItem.Name = "setQuaternionSendRateToolStripMenuItem";
            this.setQuaternionSendRateToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setQuaternionSendRateToolStripMenuItem.Text = "Set Quaternion Send Rate \"QR,#↵\"";
            // 
            // setSensorSendRateToolStripMenuItem
            // 
            this.setSensorSendRateToolStripMenuItem.Name = "setSensorSendRateToolStripMenuItem";
            this.setSensorSendRateToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setSensorSendRateToolStripMenuItem.Text = "Set Sensor Send Rate \"SR,#↵\"";
            // 
            // setBatterySendRateToolStripMenuItem
            // 
            this.setBatterySendRateToolStripMenuItem.Name = "setBatterySendRateToolStripMenuItem";
            this.setBatterySendRateToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setBatterySendRateToolStripMenuItem.Text = "Set Battery Send Rate \"BR,#↵\"";
            // 
            // setBinaryPacketModeToolStripMenuItem
            // 
            this.setBinaryPacketModeToolStripMenuItem.Name = "setBinaryPacketModeToolStripMenuItem";
            this.setBinaryPacketModeToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setBinaryPacketModeToolStripMenuItem.Text = "Set Binary Packet Mode - \"BP,#↵\"";
            // 
            // setAHRSGainToolStripMenuItem
            // 
            this.setAHRSGainToolStripMenuItem.Name = "setAHRSGainToolStripMenuItem";
            this.setAHRSGainToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setAHRSGainToolStripMenuItem.Text = "Set AHRS Gain - \"AG,#↵\"";
            // 
            // setAHRSModeToolStripMenuItem
            // 
            this.setAHRSModeToolStripMenuItem.Name = "setAHRSModeToolStripMenuItem";
            this.setAHRSModeToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setAHRSModeToolStripMenuItem.Text = "Set AHRS No Magnetometer Mode - \"AM,#↵\"";
            // 
            // setSleepTimerToolStripMenuItem
            // 
            this.setSleepTimerToolStripMenuItem.Name = "setSleepTimerToolStripMenuItem";
            this.setSleepTimerToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.setSleepTimerToolStripMenuItem.Text = "Set Sleep Timer - \"ST,#↵\"";
            // 
            // toolStripMenuItemTools
            // 
            this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGyrAndAccCalibrationWizard,
            this.toolStripMenuItemMagneticCalibrationWizard,
            this.toolStripMenuItemFirmwareUploadWizard});
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
            // toolStripMenuItemFirmwareUploadWizard
            // 
            this.toolStripMenuItemFirmwareUploadWizard.Name = "toolStripMenuItemFirmwareUploadWizard";
            this.toolStripMenuItemFirmwareUploadWizard.Size = new System.Drawing.Size(335, 22);
            this.toolStripMenuItemFirmwareUploadWizard.Text = "Firmware Upload Wizard";
            this.toolStripMenuItemFirmwareUploadWizard.Click += new System.EventHandler(this.toolStripMenuItemFirmwareUploadWizard_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemSourceCode});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemAbout.Text = "About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemSourceCode
            // 
            this.toolStripMenuItemSourceCode.Name = "toolStripMenuItemSourceCode";
            this.toolStripMenuItemSourceCode.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemSourceCode.Text = "Source Code";
            this.toolStripMenuItemSourceCode.Click += new System.EventHandler(this.toolStripMenuItemSourceCode_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPacketsReceived,
            this.toolStripStatusLabelPacketRate});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 342);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(584, 20);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabelPacketsReceived
            // 
            this.toolStripStatusLabelPacketsReceived.Name = "toolStripStatusLabelPacketsReceived";
            this.toolStripStatusLabelPacketsReceived.Size = new System.Drawing.Size(199, 15);
            this.toolStripStatusLabelPacketsReceived.Text = "toolStripStatusLabelPacketsReceived";
            // 
            // toolStripStatusLabelPacketRate
            // 
            this.toolStripStatusLabelPacketRate.Name = "toolStripStatusLabelPacketRate";
            this.toolStripStatusLabelPacketRate.Size = new System.Drawing.Size(170, 15);
            this.toolStripStatusLabelPacketRate.Text = "toolStripStatusLabelPacketRate";
            // 
            // printCommandListToolStripMenuItem
            // 
            this.printCommandListToolStripMenuItem.Name = "printCommandListToolStripMenuItem";
            this.printCommandListToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.printCommandListToolStripMenuItem.Text = "Print Command List - \"CL↵\"";
            // 
            // factoryResetToolStripMenuItem
            // 
            this.factoryResetToolStripMenuItem.Name = "factoryResetToolStripMenuItem";
            this.factoryResetToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.factoryResetToolStripMenuItem.Text = "Factory Reset - \"FR,#↵\"";
            // 
            // FormTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormTerminal";
            this.Text = "FormTerminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTerminal_FormClosed);
            this.Load += new System.EventHandler(this.FormTerminal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMagneticCalibrationWizard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommands;
        private System.Windows.Forms.ToolStripMenuItem enterCommandModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printGeneralRegistersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setQuaternionSendRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSensorSendRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBatterySendRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAHRSModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAHRSGainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSleepTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setXBeeLowPowerModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitCommandModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setXBeeChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGyrAndAccCalibrationWizard;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPacketsReceived;
        private System.Windows.Forms.ToolStripMenuItem setBinaryPacketModeToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFirmwareUploadWizard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSourceCode;
        private System.Windows.Forms.ToolStripMenuItem printCommandListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoryResetToolStripMenuItem;
    }
}

