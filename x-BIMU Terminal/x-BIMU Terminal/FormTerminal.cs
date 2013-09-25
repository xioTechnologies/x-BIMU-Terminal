using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace x_BIMU_Terminal
{
    public partial class FormTerminal : Form
    {
        #region Variables and objects

        /// <summary>
        /// Timer to update terminal textbox at fixed interval.
        /// </summary>
        private System.Windows.Forms.Timer formUpdateTimer = new System.Windows.Forms.Timer();

        /// <summary>
        /// SerialPort to communicate with XBee module.
        /// </summary>
        private SerialPort serialPort = new SerialPort();

        /// <summary>
        /// Flag to indicate if recption of XStick channel value is active.
        /// </summary>
        private bool xStickRxActive = false;

        /// <summary>
        /// Buffer for decoding received XStick channel value.
        /// </summary>
        private string xStickRxBuffer = "";

        /// <summary>
        /// Received XStick channel value.
        /// </summary>
        private int xStickRxChannel = 0;

        /// <summary>
        /// SerialStreamDecoder to decode serial data stream into packets.
        /// </summary>
        private SerialDecoder serialDecoder = new SerialDecoder();

        /// <summary>
        /// Packet counter to calculate performance statics.
        /// </summary>
        private PacketCounter packetCounter = new PacketCounter();

        /// <summary>
        /// TextBoxBuffer containing text printed to terminal.
        /// </summary>
        private TextBoxBuffer textBoxBuffer = new TextBoxBuffer(4096);

        /// <summary>
        /// Form3DQuaternion to display orientation.
        /// </summary>
        private Form3DQuaternion form3DQuaternion = new Form3DQuaternion();

        /// <summary>
        /// Gyroscope Oscilloscope.
        /// </summary>
        private Oscilloscope gyroscopeOscilloscope = Oscilloscope.CreateScope("Oscilloscope/gyroscopeOscilloscope_settings.ini", "");

        /// <summary>
        /// Accelerometer Oscilloscope.
        /// </summary>
        private Oscilloscope accelerometerOscilloscope = Oscilloscope.CreateScope("Oscilloscope/accelerometerOscilloscope_settings.ini", "");

        /// <summary>
        /// Magnetometer Oscilloscope.
        /// </summary>
        private Oscilloscope magnetometerOscilloscope = Oscilloscope.CreateScope("Oscilloscope/magnetometerOscilloscope_settings.ini", "");

        /// <summary>
        /// Battery Oscilloscope.
        /// </summary>
        private Oscilloscope batteryOscilloscope = Oscilloscope.CreateScope("Oscilloscope/batteryOscilloscope_settings.ini", "");

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormTerminal()
        {
            InitializeComponent();
            //toolStripMenuItemTools.DropDownItems.Remove(toolStripMenuItemGyrAndAccCalibrationWizard);
            //toolStripMenuItemTools.DropDownItems.Remove(toolStripMenuItemMagneticCalibrationWizard);
        }

        #region Form load and close

        /// <summary>
        /// From load event.
        /// </summary>
        private void FormTerminal_Load(object sender, EventArgs e)
        {
            // Set form caption
            this.Text = Assembly.GetExecutingAssembly().GetName().Name + " (Port Closed)";

            // Refresh serial port list
            RefreshSerialPortList();

            // Anonymous function to handle quaternion packet received event
            serialDecoder.QuaternionReceived += new SerialDecoder.onQuaternionReceived(
                delegate(int[] i)
                {
                    form3DQuaternion.Quaternion = new float[] { i[0], i[1], i[2], i[3] };
                    packetCounter.Increment();
                }
            );

            // Anonymous function to handle sensor packet received event
            serialDecoder.SensorsReceived += new SerialDecoder.onSensorsReceived(
                delegate(int[] i)
                {
                    gyroscopeOscilloscope.AddScopeData(i[0], i[1], i[2]);
                    accelerometerOscilloscope.AddScopeData(i[3], i[4], i[5]);
                    magnetometerOscilloscope.AddScopeData(i[6], i[7], i[8]);
                    packetCounter.Increment();
                }
            );

            // Anonymous function to handle battery packet received event
            serialDecoder.BatteryReceived += new SerialDecoder.onBatteryReceived(
                delegate(int[] i)
                {
                    batteryOscilloscope.AddScopeData(i[0], 0, 0);
                    packetCounter.Increment();
                }
            );

            // Setup form update timer
            formUpdateTimer.Interval = 50;
            formUpdateTimer.Tick += new EventHandler(formUpdateTimer_Tick);
            formUpdateTimer.Start();
        }

        /// <summary>
        /// Form close event.
        /// </summary>
        private void FormTerminal_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseSerialPort();
        }

        #endregion

        #region Terminal textbox

        /// <summary>
        /// formUpdateTimer Tick event to update terminal textbox.
        /// </summary>
        void formUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Print textBoxBuffer to terminal
            if (textBox.Enabled && !textBoxBuffer.IsEmpty())
            {
                textBox.AppendText(textBoxBuffer.Get());
                if (textBox.Text.Length > textBox.MaxLength)    // discard first half of textBox when number of characters exceeds length
                {
                    textBox.Text = textBox.Text.Substring(textBox.Text.Length / 2, textBox.Text.Length - textBox.Text.Length / 2);
                }
            }
            else
            {
                textBoxBuffer.Clear();
            }

            // Update packet counter values
            toolStripStatusLabelPacketsReceived.Text = "Packets Recieved: " + packetCounter.PacketsReceived.ToString();
            toolStripStatusLabelPacketRate.Text = "Packets Per Second: " + packetCounter.PacketRate.ToString();
        }

        /// <summary>
        /// textBox KeyPress to send character to serial port.
        /// </summary>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendSerialPort(e.KeyChar);
            e.Handled = true;   // don't print character
        }

        #endregion

        #region Menu strip

        /// <summary>
        /// toolStripMenuItemSerialPort DropDownItemClicke event to select or close serial port.
        /// </summary>
        private void toolStripMenuItemSerialPort_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Close serial port and refresh list is refresh item clicked
            if (e.ClickedItem.Text == "Refresh List")
            {
                CloseSerialPort();
                RefreshSerialPortList();
                return;
            }

            // Close serial port if checked port name clicked
            if (((ToolStripMenuItem)e.ClickedItem).Checked)
            {
                CloseSerialPort();
                ((ToolStripMenuItem)e.ClickedItem).Checked = false;
                return;
            }

            // Open serial port if unchecked port name clicked
            foreach (ToolStripMenuItem toolStripMenuItem in ((ToolStripMenuItem)toolStripMenuItemSerialPort).DropDownItems)
            {
                toolStripMenuItem.Checked = false;
            }
            CloseSerialPort();
            if (OpenSerialPort(e.ClickedItem.Text))
            {
                ((ToolStripMenuItem)e.ClickedItem).Checked = true;
            }
        }

        /// <summary>
        /// toolStripMenuItemXStick DropDownItemClicked event to channel XStick channel.
        /// </summary>
        private void toolStripMenuItemXStick_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Serial port closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                xStickRxActive = true;
                Thread.Sleep(110);
                SendSerialPort("+++");  // enter command mode
                Thread.Sleep(110);
                SendSerialPort("ATCH" + Int32.Parse(Regex.Match(e.ClickedItem.Text, @"\d+").Value).ToString("X") + "\r");   // set channel
                Thread.Sleep(50);
                SendSerialPort("ATWR\r");   // save registers
                Thread.Sleep(50);
                SendSerialPort("ATFR\r");   // software reset
                Thread.Sleep(50);
                UpdateCaption();
                xStickRxActive = false;
            }
        }

        /// <summary>
        /// toolStripMenuItemQuaternion CheckStateChanged event to toggle show state of Form3DCuboid form.
        /// </summary>
        private void toolStripMenuItemQuaternion_CheckStateChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemQuaternion.Checked)
            {
                form3DQuaternion.Show();
            }
            else
            {
                form3DQuaternion.Hide();
            }
        }


        /// <summary>
        /// toolStripMenuItemGyroscope CheckStateChanged event to toggle show state of oscilloscope form.
        /// </summary>
        private void toolStripMenuItemGyroscope_CheckStateChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemGyroscope.Checked)
            {
                gyroscopeOscilloscope.ShowScope();
            }
            else
            {
                gyroscopeOscilloscope.HideScope();
            }
        }

        /// <summary>
        /// toolStripMenuItemAccelerometer CheckStateChanged event to toggle show state of oscilloscope form.
        /// </summary>
        private void toolStripMenuItemAccelerometer_CheckStateChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemAccelerometer.Checked)
            {
                accelerometerOscilloscope.ShowScope();
            }
            else
            {
                accelerometerOscilloscope.HideScope();
            }
        }

        /// <summary>
        /// toolStripMenuItemMagnetometer CheckStateChanged event to toggle show state of oscilloscope form.
        /// </summary>
        private void toolStripMenuItemMagnetometer_CheckStateChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemMagnetometer.Checked)
            {
                magnetometerOscilloscope.ShowScope();
            }
            else
            {
                magnetometerOscilloscope.HideScope();
            }
        }

        /// <summary>
        /// toolStripMenuItemBattery CheckStateChanged event to toggle show state of oscilloscope form.
        /// </summary>
        private void toolStripMenuItemBattery_CheckStateChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemBattery.Checked)
            {
                batteryOscilloscope.ShowScope();
            }
            else
            {
                batteryOscilloscope.HideScope();
            }
        }

        /// <summary>
        /// toolStripMenuItemCommands DropDownItemClicked to send command.
        /// </summary>
        private void toolStripMenuItemCommands_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string stringToSend = e.ClickedItem.Text.Split('\"')[1];
            stringToSend = stringToSend.Replace('↵', '\r');
            if (stringToSend.Contains('#'))
            {
                FormGetValue formGetValue = new FormGetValue();
                formGetValue.ShowDialog();
                stringToSend = stringToSend.Insert(stringToSend.IndexOf('#'), formGetValue.value);
                stringToSend = stringToSend.Remove(stringToSend.IndexOf('#'), 1);
            }
            SendSerialPort(stringToSend);
        }

        /// <summary>
        /// toolStripMenuItemGyrAndAccCalWizard Click event to start magnetic calibration wizard.
        /// </summary>
        private void toolStripMenuItemGyrAndAccCalWizard_Click(object sender, EventArgs e)
        {
            FormGyrAndAccCalWizard formGyrAndAccCalWizard = new FormGyrAndAccCalWizard();
            formGyrAndAccCalWizard.SendSerialPort += SendSerialPort;
            serialDecoder.OKReceived += formGyrAndAccCalWizard.OKReceived;
            serialDecoder.SensorsReceived += formGyrAndAccCalWizard.SensorsReceived;
            formGyrAndAccCalWizard.ShowDialog();
        }

        /// <summary>
        /// toolStripMenuItemMagCalWizard Click event to start magnetic calibration wizard.
        /// </summary>
        private void toolStripMenuItemMagCalWizard_Click(object sender, EventArgs e)
        {
            FormMagCalWizard formMagCalWizard = new FormMagCalWizard();
            formMagCalWizard.SendSerialPort += SendSerialPort;
            serialDecoder.OKReceived += formMagCalWizard.OKReceived;
            serialDecoder.SensorsReceived += formMagCalWizard.SensorsReceived;
            formMagCalWizard.ShowDialog();
        }

        /// <summary>
        /// toolStripMenuItemFirmwareUploadWizard Click event to start firmware upload wizard.
        /// </summary>
        private void toolStripMenuItemFirmwareUploadWizard_Click(object sender, EventArgs e)
        {
            FormFirmwareUploadWizard formFirmwareWizard = new FormFirmwareUploadWizard();
            formFirmwareWizard.serialPort = serialPort;
            formFirmwareWizard.SendSerialPort += SendSerialPort;
            serialDecoder.OKReceived += formFirmwareWizard.OKReceived;
            formFirmwareWizard.ShowDialog();
        }

        /// <summary>
        /// toolStripMenuItemFirmwareUploaderWizard Click event to start firmware uploader wizard.
        /// </summary>
        private void toolStripMenuItemFirmwareUploaderWizard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// toolStripMenuItemAbout Click event to display version details.
        /// </summary>
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Assembly.GetExecutingAssembly().GetName().Name + " " + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// toolStripMenuItemSourceCode Click event to open web browser.
        /// </summary>
        private void toolStripMenuItemSourceCode_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/xioTechnologies/x-BIMU-Terminal");
            }
            catch { }
        }

        #endregion

        #region Serial port

        /// <summary>
        /// Updates toolStripMenuItemSerialPort DropDownItems to include all available serial port.
        /// </summary>
        private void RefreshSerialPortList()
        {
            ToolStripItemCollection toolStripItemCollection = toolStripMenuItemSerialPort.DropDownItems;
            toolStripItemCollection.Clear();
            toolStripItemCollection.Add("Refresh List");
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                toolStripItemCollection.Add("COM" + Regex.Replace(portName.Substring("COM".Length, portName.Length - "COM".Length), "[^.0-9]", "\0"));
            }
        }

        /// <summary>
        /// Opens serial port. Displays error in MessageBox if unsuccessful.
        /// </summary>
        /// <param name="portName">
        /// Name of port to be opened.
        /// </param> 
        /// <returns>
        /// true if successful.
        /// </returns>
        private bool OpenSerialPort(string portName)
        {
            try
            {
                serialPort = new SerialPort(portName, 115200, Parity.None, 8, StopBits.One);
                serialPort.Handshake = Handshake.RequestToSend;
                serialPort.WriteTimeout = 100;  // set timeout else writes to port with RTS will freeze application
                serialPort.DtrEnable = true;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                serialPort.Open();
                UpdateCaption();
                packetCounter.Reset();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Updates form caption with Port number and XStick channel.
        /// </summary>
        private void UpdateCaption()
        {
            xStickRxActive = true;
            Thread.Sleep(110);
            SendSerialPort("+++");  // enter command mode
            Thread.Sleep(110);
            xStickRxChannel = 0;
            SendSerialPort("ATCH\r");   // read channel
            Thread.Sleep(50);
            SendSerialPort("ATFR\r");   // software reset
            Thread.Sleep(50);
            xStickRxActive = false;
            this.Text = Assembly.GetExecutingAssembly().GetName().Name + " (" + serialPort.PortName + ((xStickRxChannel == 0) ? "" : ", XStick Channel " + xStickRxChannel.ToString()) + ")";
        }

        /// <summary>
        /// Closes serial port.
        /// </summary>
        private void CloseSerialPort()
        {
            try
            {
                serialPort.Close();
            }
            catch { }
            this.Text = Assembly.GetExecutingAssembly().GetName().Name + " (Port Closed)";
        }

        /// <summary>
        /// Sends character to serial port.
        /// </summary>
        /// <param name="c">
        /// Character to send to serial port.
        /// </param>
        private void SendSerialPort(char c)
        {
            try
            {
                serialPort.Write(new char[] { c }, 0, 1);
            }
            catch { }
        }

        /// <summary>
        /// Sends string to serial port.
        /// </summary>
        /// <param name="s">
        /// String to send to serial port.
        /// </param>
        private void SendSerialPort(string s)
        {
            try
            {
                serialPort.Write(s.ToCharArray(), 0, s.Length);
            }
            catch { }
        }

        /// <summary>
        /// serialPort DataReceived event to print characters to terminal and process bytes through serialDecoder.
        /// </summary>
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Get bytes from serial port
            int bytesToRead = serialPort.BytesToRead;
            byte[] readBuffer = new byte[bytesToRead];
            serialPort.Read(readBuffer, 0, bytesToRead);

            // Process bytes one at a time
            foreach (byte b in readBuffer)
            {
                // Decode channel value if XStick communication active
                if (xStickRxActive)
                {
                    if ((char)b == '\r')   // attempt to decode channel value if new line character received
                    {
                        if (Regex.IsMatch(xStickRxBuffer, @"^[A-F0-9]+$") && xStickRxChannel == 0)
                        {
                            xStickRxChannel = Convert.ToInt32(xStickRxBuffer, 16);
                        }
                        xStickRxBuffer = "";
                    }
                    else
                    {
                        xStickRxBuffer += (char)b;
                    }
                }
                else
                {
                    // Parse bytes to textBoxBuffer and serialDecoder
                    if ((b < 0x20 || b > 0x7F) && b != '\r')    // replace non-printable characters with '.'
                    {
                        textBoxBuffer.Put('.');
                    }
                    else if (b == '\r')     // replace carriage return with '↵' and valid new line
                    {
                        textBoxBuffer.Put("↵" + Environment.NewLine);
                    }
                    else    // parse all other characters to textBoxBuffer
                    {
                        textBoxBuffer.Put((char)b);
                    }
                    serialDecoder.ProcessNewByte(b);    // process every byte through serialDecoder
                }
            }
        }

        #endregion
    }
}