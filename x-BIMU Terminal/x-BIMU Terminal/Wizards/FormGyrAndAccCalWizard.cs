using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace x_BIMU_Terminal
{
    /// <summary>
    /// Gyroscope and accelerometer calibration wizard class.
    /// </summary>
    public partial class FormGyrAndAccCalWizard : FormWizard
    {
        /// <summary>
        /// Nested MeanAccumulator class.
        /// </summary>
        class MeanAccumulator
        {
            /// <summary>
            /// Running sum of accumulated samples.
            /// </summary>
            float accumulator = 0f;

            /// <summary>
            ///  Number accumulated samples.
            /// </summary>
            int numSamples = 0;

            /// <summary>
            /// Accumulator enabled flag.
            /// </summary>
            public bool Enabled { get; set; }

            /// <summary>
            /// Constructor.
            /// </summary>
            public MeanAccumulator()
            {
            }

            /// <summary>
            /// Adds value to accumulator if Enabled flag set else sample will be discarded.
            /// </summary>
            /// <param name="value"></param>
            public void Add(float value)
            {
                if (Enabled)
                {
                    accumulator += value;
                    numSamples++;
                }
            }

            /// <summary>
            /// Gets mean of accumulated samples.
            /// </summary>
            /// <returns></returns>
            public float GetMean()
            {
                return accumulator / (float)numSamples;
            }
        }

        /// <summary>
        /// Received accelerometer x axis value.
        /// </summary>
        private float accX;

        /// <summary>
        /// Received accelerometer y axis value.
        /// </summary>
        private float accY;

        /// <summary>
        /// Received accelerometer z axis value.
        /// </summary>
        private float accZ;

        /// <summary>
        /// Received gyroscope x axis value.
        /// </summary>
        private float gyrX;

        /// <summary>
        /// Received gyroscope y axis value.
        /// </summary>
        private float gyrY;

        /// <summary>
        /// Received gyroscope z axis value.
        /// </summary>
        private float gyrZ;

        /// <summary>
        /// MeanAccumulator for sample accelerometer x axis at +1 g
        /// </summary>
        private MeanAccumulator meanAccumXPos1g = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for sample accelerometer x axis at -1 g
        /// </summary>
        private MeanAccumulator meanAccumXNeg1g = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for sample accelerometer y axis at +1 g
        /// </summary>
        private MeanAccumulator meanAccumYPos1g = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for sample accelerometer y axis at -1 g
        /// </summary>
        private MeanAccumulator meanAccumYNeg1g = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for sample accelerometer z axis at +1 g
        /// </summary>
        private MeanAccumulator meanAccumZPos1g = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for sample accelerometer z axis at -1 g
        /// </summary>
        private MeanAccumulator meanAccumZNeg1g = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope x axis at 0 dps
        /// </summary>
        private MeanAccumulator meanAccumX0dps = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope y axis at 0 dps
        /// </summary>
        private MeanAccumulator meanAccumY0dps = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope z axis at 0 dps
        /// </summary>
        private MeanAccumulator meanAccumZ0dps = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope x axis at +200 dps
        /// </summary>
        private MeanAccumulator meanAccumXPos200dps = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope x axis at -200 dps
        /// </summary>
        private MeanAccumulator meanAccumXNeg200dps = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope y axis at +200 dps
        /// </summary>
        private MeanAccumulator meanAccumYPos200dps = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope y axis at -200 dps
        /// </summary>
        private MeanAccumulator meanAccumYNeg200dps = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope z axis at +200 dps
        /// </summary>
        private MeanAccumulator meanAccumZPos200dps = new MeanAccumulator();

        /// <summary>
        /// MeanAccumulator for gyroscope z axis at -200 dps
        /// </summary>
        private MeanAccumulator meanAccumZNeg200dps = new MeanAccumulator();

        /// <summary>
        /// Construcctor.
        /// </summary>
        public FormGyrAndAccCalWizard()
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
            UpdateRegisters();
        }

        /// <summary>
        /// Sets up registers for gyroscope and accelerometer calibration.
        /// </summary>
        private void SetupRegisters()
        {
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text = "Setting up registers for calibration..."; })));
            ExicuteCommand("---");          // enter command mode
            ExicuteCommand("UN,12345\r");   // unlock calibration registers
            ExicuteCommand("LP,0\r");       // XBee low power mode disabled
            ExicuteCommand("QR,6\r");       // quaternion send rate = 32 Hz
            ExicuteCommand("SR,7\r");       // sensor send rate = 64 Hz
            ExicuteCommand("BR,1\r");       // battery send rate = 1 Hz
            ExicuteCommand("ST,0\r");       // sleep timer disabled
            ExicuteCommand("GSX,10000\r");  // set sensor output units to lsb
            ExicuteCommand("GSY,10000\r");
            ExicuteCommand("GSZ,10000\r");
            ExicuteCommand("GBX,0\r");
            ExicuteCommand("GBY,0\r");
            ExicuteCommand("GBZ,0\r");
            ExicuteCommand("ASX,10000\r");
            ExicuteCommand("ASY,10000\r");
            ExicuteCommand("ASZ,10000\r");
            ExicuteCommand("ABX,0\r");
            ExicuteCommand("ABY,0\r");
            ExicuteCommand("ABZ,0\r");
            ExicuteCommand("EX\r");    // exit command mode
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Compelte."; })));
        }

        /// <summary>
        /// Collect calibration datasets.
        /// </summary>
        private void CollectData()
        {
            // Sample X axis at +1g and XYZ axes at 0 dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply +1g to X axis..."; })));
            WaitForAccelerometer(2048f, 0f, 0f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumXPos1g.Enabled = true;
            meanAccumX0dps.Enabled = true;
            meanAccumY0dps.Enabled = true;
            meanAccumZ0dps.Enabled = true;
            Wait();
            meanAccumXPos1g.Enabled = false;
            meanAccumX0dps.Enabled = false;
            meanAccumY0dps.Enabled = false;
            meanAccumZ0dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample X axis at -1g and XYZ axes at 0 dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply -1g to X axis..."; })));
            WaitForAccelerometer(-2048f, 0f, 0f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumXNeg1g.Enabled = true;
            meanAccumX0dps.Enabled = true;
            meanAccumY0dps.Enabled = true;
            meanAccumZ0dps.Enabled = true;
            Wait();
            meanAccumXNeg1g.Enabled = false;
            meanAccumX0dps.Enabled = false;
            meanAccumY0dps.Enabled = false;
            meanAccumZ0dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample Y axis at +1g and XYZ axes at 0 dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply +1g to Y axis..."; })));
            WaitForAccelerometer(0f, 2048f, 0f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumYPos1g.Enabled = true;
            meanAccumX0dps.Enabled = true;
            meanAccumY0dps.Enabled = true;
            meanAccumZ0dps.Enabled = true;
            Wait();
            meanAccumYPos1g.Enabled = false;
            meanAccumX0dps.Enabled = false;
            meanAccumY0dps.Enabled = false;
            meanAccumZ0dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample Y axis at -1g and XYZ axes at 0 dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply -1g to Y axis..."; })));
            WaitForAccelerometer(0f, -2048f, 0f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumYNeg1g.Enabled = true;
            meanAccumX0dps.Enabled = true;
            meanAccumY0dps.Enabled = true;
            meanAccumZ0dps.Enabled = true;
            Wait();
            meanAccumYNeg1g.Enabled = false;
            meanAccumX0dps.Enabled = false;
            meanAccumY0dps.Enabled = false;
            meanAccumZ0dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample Z axis at +1g and XYZ axes at 0 dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply +1g to Z axis..."; })));
            WaitForAccelerometer(0f, 0f, 2048f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumZPos1g.Enabled = true;
            meanAccumX0dps.Enabled = true;
            meanAccumY0dps.Enabled = true;
            meanAccumZ0dps.Enabled = true;
            Wait();
            meanAccumZPos1g.Enabled = false;
            meanAccumX0dps.Enabled = false;
            meanAccumY0dps.Enabled = false;
            meanAccumZ0dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample Z axis at -1g and XYZ axes at 0 dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply -1g to Z axis..."; })));
            WaitForAccelerometer(0f, 0f, -2048f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumZNeg1g.Enabled = true;
            meanAccumX0dps.Enabled = true;
            meanAccumY0dps.Enabled = true;
            meanAccumZ0dps.Enabled = true;
            Wait();
            meanAccumZNeg1g.Enabled = false;
            meanAccumX0dps.Enabled = false;
            meanAccumY0dps.Enabled = false;
            meanAccumZ0dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample X axis at +200dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply +200dps to X axis..."; })));
            WaitForGyroscope(3280f, 0f, 0f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumXPos200dps.Enabled = true;
            Wait();
            meanAccumXPos200dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample X axis at -200dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply -200dps to X axis..."; })));
            WaitForGyroscope(-3280f, 0f, 0f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumXNeg200dps.Enabled = true;
            Wait();
            meanAccumXNeg200dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample Y axis at +200dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply +200dps to Y axis..."; })));
            WaitForGyroscope(0f, 3280f, 0f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumYPos200dps.Enabled = true;
            Wait();
            meanAccumYPos200dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample Y axis at -200dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply -200dps to Y axis..."; })));
            WaitForGyroscope(0f, -3280f, 0f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumYNeg200dps.Enabled = true;
            Wait();
            meanAccumYNeg200dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample Z axis at +200dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply +200dps to Z axis..."; })));
            WaitForGyroscope(0f, 0f, 3280f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumZPos200dps.Enabled = true;
            Wait();
            meanAccumZPos200dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));

            // Sample Z axis at -200dps
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Please apply -200dps to Z axis..."; })));
            WaitForGyroscope(0f, 0f, -3280f);
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Sampling..."; })));
            meanAccumZNeg200dps.Enabled = true;
            Wait();
            meanAccumZNeg200dps.Enabled = false;
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Complete."; })));
        }

        /// <summary>
        /// Calculate calibration parameters and updates registers.
        /// </summary>
        private void UpdateRegisters()
        {
            // Calculate register values
            int GSX = (int)((meanAccumXPos200dps.GetMean() - meanAccumXNeg200dps.GetMean()) / 0.4f);    // 0.001lsb/dps
            int GSY = (int)((meanAccumYPos200dps.GetMean() - meanAccumYNeg200dps.GetMean()) / 0.4f);
            int GSZ = (int)((meanAccumZPos200dps.GetMean() - meanAccumZNeg200dps.GetMean()) / 0.4f);
            int GBX = (int)(meanAccumX0dps.GetMean() * 10f);    // 0.1lsb
            int GBY = (int)(meanAccumY0dps.GetMean() * 10f);
            int GBZ = (int)(meanAccumZ0dps.GetMean() * 10f);
            int ASX = (int)((meanAccumXPos1g.GetMean() - meanAccumXNeg1g.GetMean()) / 0.2f);    // 0.1lsb/g
            int ASY = (int)((meanAccumYPos1g.GetMean() - meanAccumYNeg1g.GetMean()) / 0.2f);
            int ASZ = (int)((meanAccumZPos1g.GetMean() - meanAccumZNeg1g.GetMean()) / 0.2f);
            int ABX = (int)((meanAccumXPos1g.GetMean() + meanAccumXNeg1g.GetMean()) / 0.2f);    // 0.1lsb
            int ABY = (int)((meanAccumYPos1g.GetMean() + meanAccumYNeg1g.GetMean()) / 0.2f);
            int ABZ = (int)((meanAccumZPos1g.GetMean() + meanAccumZNeg1g.GetMean()) / 0.2f);

            // Write registers
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Updating registers..."; })));
            ExicuteCommand("---");          // enter command mode
            ExicuteCommand("UN,12345\r");   // unlock calibration registers
            ExicuteCommand("GSX," + GSX.ToString() + "\r");
            ExicuteCommand("GSY," + GSY.ToString() + "\r");
            ExicuteCommand("GSZ," + GSZ.ToString() + "\r");
            ExicuteCommand("GBX," + GBX.ToString() + "\r");
            ExicuteCommand("GBY," + GBY.ToString() + "\r");
            ExicuteCommand("GBZ," + GBZ.ToString() + "\r");
            ExicuteCommand("ASX," + ASX.ToString() + "\r");
            ExicuteCommand("ASY," + ASY.ToString() + "\r");
            ExicuteCommand("ASZ," + ASZ.ToString() + "\r");
            ExicuteCommand("ABX," + ABX.ToString() + "\r");
            ExicuteCommand("ABY," + ABY.ToString() + "\r");
            ExicuteCommand("ABZ," + ABZ.ToString() + "\r");
            ExicuteCommand("EX\r");         // exit command mode
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
            // Update value detection variables
            gyrX = i[0];
            gyrY = i[1];
            gyrZ = i[2];
            accX = i[3];
            accY = i[4];
            accZ = i[5];

            // Update accumulators
            meanAccumXPos1g.Add(accX);
            meanAccumXPos1g.Add(accX);
            meanAccumXNeg1g.Add(accX);
            meanAccumYPos1g.Add(accY);
            meanAccumYNeg1g.Add(accY);
            meanAccumZPos1g.Add(accZ);
            meanAccumZNeg1g.Add(accZ);
            meanAccumX0dps.Add(gyrX);
            meanAccumY0dps.Add(gyrY);
            meanAccumZ0dps.Add(gyrZ);
            meanAccumXPos200dps.Add(gyrX);
            meanAccumXNeg200dps.Add(gyrX);
            meanAccumYPos200dps.Add(gyrY);
            meanAccumYNeg200dps.Add(gyrY);
            meanAccumZPos200dps.Add(gyrZ);
            meanAccumZNeg200dps.Add(gyrZ);
        }

        /// <summary>
        /// Provides delay while accumulators store calibration dataset.
        /// </summary>
        private void Wait()
        {
            //int timer = 0;
            //while (timer++ < 50)
            //{
            //    Thread.Sleep(100);
            //}
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Waits for accelerometer reach target orientation.
        /// </summary>
        /// <param name="x">
        /// Target x value in lsb.
        /// </param>
        /// <param name="y">
        /// Target y value in lsb.
        /// </param>
        /// <param name="z">
        /// Target z value in lsb.
        /// </param>
        private void WaitForAccelerometer(float x, float y, float z)
        {
            int counter = 0;
            System.Media.SystemSounds.Asterisk.Play();
            while (counter++ < 20)
            {
                Thread.Sleep(100);
                if (accX > x + 500f || accX < x - 500f ||
                    accY > y + 500f || accY < y - 500f ||
                    accZ > z + 500f || accZ < z - 500f)
                {
                    counter = 0;
                }
            }
        }

        /// <summary>
        /// Waits for gyroscope reach target rate.
        /// </summary>
        /// <param name="x">
        /// Target x value in lsb.
        /// </param>
        /// <param name="y">
        /// Target y value in lsb.
        /// </param>
        /// <param name="z">
        /// Target z value in lsb.
        /// </param>
        private void WaitForGyroscope(float x, float y, float z)
        {
            int counter = 0;
            System.Media.SystemSounds.Asterisk.Play();
            while (counter++ < 10)
            {
                Thread.Sleep(100);
                if (gyrX > x + 500f || gyrX < x - 500f ||
                    gyrY > y + 500f || gyrY < y - 500f ||
                    gyrZ > z + 500f || gyrZ < z - 500f)
                {
                    counter = 0;
                }
            }
        }
    }
}