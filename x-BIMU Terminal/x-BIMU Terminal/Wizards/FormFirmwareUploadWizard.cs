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
using System.IO.Ports;
using System.Diagnostics;

namespace x_BIMU_Terminal
{
    /// <summary>
    /// Firmware upload wizard.
    /// </summary>
    public partial class FormFirmwareUploadWizard : FormWizard
    {
        /// <summary>
        /// SerialPort object used by terminal.
        /// </summary>
        public SerialPort serialPort { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormFirmwareUploadWizard()
        {
            InitializeComponent();
            Initialise();
            buttonNextPage1.Enabled = false;
        }

        /// <summary>
        /// button_browse Click event to open file select dialog.
        /// </summary>
        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Firmware Hex File";
            openFileDialog.Filter = "Hex Files|*.hex";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_hexFile.Text = openFileDialog.FileName.ToString();
            }
            if (File.Exists(textBox_hexFile.Text))
            {
                buttonNextPage1.Enabled = true;
            }
        }

        /// <summary>
        /// Calibration tasks.
        /// </summary>
        protected override void DoTasks()
        {
            Reset();
            RunBootloader();
        }

        /// <summary>
        /// Sends command to reset x-BIMU.
        /// </summary>
        private void Reset()
        {
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text = "Resetting..."; })));
            ExicuteCommand("---");      // enter comamnd mode
            ExicuteCommand("RD\r");     // reset device command
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Compelte."; })));
        }

        /// <summary>
        /// Run bootloader.
        /// </summary>
        private void RunBootloader()
        {
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + "Running bootloader..."; })));
            serialPort.Close();
            ProcessStartInfo processInfo = new ProcessStartInfo("ds30LoaderConsole.exe");
            processInfo.Arguments = "\"-f=C:\\MyFiles\\x-io\\Products\\x-BIMU\\x-BIMU-Firmware\\x-BIMU Firmware\\x-BIMU Firmware.hex\"" +
                                    " -d=PIC24FJ64GA102 " +
                                    "\"-k=" + serialPort.PortName + "\"" +
                                    " -r=115200 --writef --ht=10000 --polltime=100 --timeout=3000 -o";
            processInfo.UseShellExecute = false;
            Process process = Process.Start(processInfo);
            process.WaitForExit();
            process.Close();
            serialPort.Open();
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Compelte."; })));
        }
    }
}
