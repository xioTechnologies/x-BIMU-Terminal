using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace x_BIMU_Terminal
{
    /// <summary>
    /// Magnetoemter Calibration Tool.
    /// </summary>
    public partial class FormToolMagneticCalibration : FormTool
    {
        /// <summary>
        /// StreamWriter to streaming calibration dataset to file.
        /// </summary>
        private StreamWriter streamWriter;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormToolMagneticCalibration()
        {
            InitializeComponent();
            Initialise();
        }

        /// <summary>
        /// Calibration tasks.
        /// </summary>
        protected override void DoTasks()
        {
            SetupRegisters();
            CollectData();
            WaitForAlgorithm();
            UpdateRegisters();
        }

        /// <summary>
        /// Set up registers for calibration.
        /// </summary>
        private void SetupRegisters()
        {
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text = "Setting up registers for calibration..."; })));
            ExicuteCommand("---");          // enter comamnd mode
            ExicuteCommand("UN,12345\r");   // unlock calibration registers
            ExicuteCommand("LP,0\r");       // XBee low power mode disabled
            ExicuteCommand("QR,6\r");       // quaternion send rate = 32 Hz
            ExicuteCommand("SR,7\r");       // sensor send rate = 64 Hz
            ExicuteCommand("BR,1\r");       // battery send rate = 1 Hz
            ExicuteCommand("ST,0\r");       // sleep timer disabled
            ExicuteCommand("MSXX,10000\r"); // remove current magnetic calibration parameters
            ExicuteCommand("MSXY,0\r");
            ExicuteCommand("MSXZ,0\r");
            ExicuteCommand("MSYX,0\r");
            ExicuteCommand("MSYY,10000\r");
            ExicuteCommand("MSYZ,0\r");
            ExicuteCommand("MSZX,0\r");
            ExicuteCommand("MSZY,0\r");
            ExicuteCommand("MSZZ,10000\r");
            ExicuteCommand("MHX,0\r");
            ExicuteCommand("MHY,0\r");
            ExicuteCommand("MHZ,0\r");
            ExicuteCommand("EX\r");    // exit command mode
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Compelte."; })));
        }

        /// <summary>
        /// Collect calibraiton dataset.
        /// </summary>
        private void CollectData()
        {
            streamWriter = new System.IO.StreamWriter("MagCalData.csv", false);
            System.Media.SystemSounds.Asterisk.Play();
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please perform rotation (0%)..."; })));
            const int period = 300;
            for (int i = 0; i < period; i++)
            {
                Thread.Sleep(100);
                this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate
                {
                    labelTextPage2.Text = labelTextPage2.Text.Substring(0, labelTextPage2.Text.IndexOf('(') + 1) +
                                          ((int)(100.0f * ((float)i / (float)(period - 1)))).ToString() + "%" +
                                          labelTextPage2.Text.Substring(labelTextPage2.Text.IndexOf(')'), labelTextPage2.Text.Length - labelTextPage2.Text.IndexOf(')'));
                    this.Refresh();
                })));
            }
            Thread.Sleep(3000);
            streamWriter.Close();
            streamWriter = null;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Compelte."; })));
        }

        /// <summary>
        /// Updates variables with new sensor data.
        /// </summary>
        /// <param name="i">
        /// Array of sensor data.
        /// </param>
        public void SensorsReceived(int[] i)
        {
            if (streamWriter != null)
            {
                streamWriter.WriteLine(i[0].ToString() + "," + i[1].ToString() + "," + i[2].ToString() + "," +
                                       i[3].ToString() + "," + i[4].ToString() + "," + i[5].ToString() + "," +
                                       i[6].ToString() + "," + i[7].ToString() + "," + i[8].ToString());
            }
        }

        /// <summary>
        /// Waits for external calibration algorithm to update the results file.
        /// </summary>
        private void WaitForAlgorithm()
        {
            System.Media.SystemSounds.Asterisk.Play();
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please run algorithm..."; })));
            System.IO.FileInfo file = new System.IO.FileInfo("MagCalResults.csv");
            DateTime fiveSecondsAgo = new DateTime();
            fiveSecondsAgo = DateTime.Now;
            fiveSecondsAgo.Subtract(new TimeSpan(0, 0, 5));
            while (file.LastWriteTime < fiveSecondsAgo)
            {
                file = new System.IO.FileInfo("MagCalResults.csv");
                Thread.Sleep(100);
            }
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Compelte."; })));
        }

        /// <summary>
        /// Calculate calibration parameters and updates registers.
        /// </summary>
        private void UpdateRegisters()
        {
            // Read calibrate results file
            StreamReader streamReader = new StreamReader("MagCalResults.csv");
            string[] vars = streamReader.ReadLine().Split(',');
            streamReader.Close();

            // Write calibrate parameters to file
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Updating registers..."; })));
            ExicuteCommand("---");          // enter comamnd mode
            ExicuteCommand("UN,12345\r");   // unlock calibration registers
            ExicuteCommand("MSXX," + ((Int32)(float.Parse(vars[0]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MSXY," + ((Int32)(float.Parse(vars[1]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MSXZ," + ((Int32)(float.Parse(vars[2]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MSYX," + ((Int32)(float.Parse(vars[3]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MSYY," + ((Int32)(float.Parse(vars[4]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MSYZ," + ((Int32)(float.Parse(vars[5]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MSZX," + ((Int32)(float.Parse(vars[6]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MSZY," + ((Int32)(float.Parse(vars[7]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MSZZ," + ((Int32)(float.Parse(vars[8]) * 10000.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MHX," + ((Int32)(float.Parse(vars[9]) * 10.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MHY," + ((Int32)(float.Parse(vars[10]) * 10.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("MHZ," + ((Int32)(float.Parse(vars[11]) * 10.0f + 0.5f)).ToString() + "\r");
            ExicuteCommand("EX\r");     // exit command mode
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Compelte."; })));
        }

        /// <summary>
        /// FormToolMagneticCalibration FormClosing event to close file.
        /// </summary>
        private void FormToolMagneticCalibration_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                streamWriter.Close();
            }
            catch { }
        }
    }
}
