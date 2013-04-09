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
                textBoxHexFile.Text = openFileDialog.FileName.ToString();
            }
            buttonNextPage1.Enabled = File.Exists(textBoxHexFile.Text);
        }

        /// <summary>
        /// Calibration tasks.
        /// </summary>
        protected override void DoTasks()
        {
            Reset();
            RunBootloader();
            this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += Environment.NewLine + Environment.NewLine + "Click Next to continue..."; })));
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
            processInfo.Arguments = "\"-f=" + textBoxHexFile.Text + "\"" +
                                    " -d=PIC24FJ64GA102 " +
                                    "\"-k=" + serialPort.PortName + "\"" +
                                    " -r=115200 --writef --ht=10000 --polltime=100 --timeout=3000 -o";
            processInfo.UseShellExecute = false;
            Process process = Process.Start(processInfo);
            process.WaitForExit();
            serialPort.Open();
            if (process.ExitCode == 0)
            {
                this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Compelte."; })));
            }
            else
            {
                this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += "Failed."; })));
            }
        }
    }
}
