﻿using System;
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
    /// FormTool base class. Not intended to be initialised though can be for development purposes.
    /// </summary>
    public partial class FormTool : Form
    {
        /// <summary>
        /// Internal commandConfirmed flag.
        /// </summary>
        private bool commandConfirmed = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormTool()
        {
            InitializeComponent();
            //Initialise(); // include this if class to be initialised.
        }

        /// <summary>
        /// Initialisation method to rearrange form from a development layout to run-time layout.
        /// </summary>
        protected void Initialise()
        {
            this.Size = new Size(500, 370);
            panelPage1.Dock = DockStyle.Fill;
            panelPage2.Dock = DockStyle.Fill;
            panelPage2.Visible = false;
        }

        /// <summary>
        /// buttonNext Click to show second page and call DoTasks method in new thread.
        /// </summary>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            panelPage1.Visible = false;
            panelPage2.Visible = true;
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(delegate
            {
                try
                {
                    DoTasks();
                    this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { buttonCancelPage2.Enabled = false; })));
                    this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { buttonFinish.Enabled = true; })));
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// buttonCancelOrFinish Click to close form.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// DoTasks method. Intended to be overridden by child class.
        /// </summary>
        protected virtual void DoTasks()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate { labelTextPage2.Text += " " + c; })));
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Executes command by sending string and waiting for confirmation.
        /// </summary>
        /// <param name="command"></param>
        protected void ExicuteCommand(string command)
        {
            int retry = 10;
            commandConfirmed = false;
            do
            {
                OnSendSerialPort(command);
                Thread.Sleep(100);
            } while (!commandConfirmed && --retry > 0);
            if (retry == 0)
            {
                this.EndInvoke(this.BeginInvoke(new MethodInvoker(delegate
                {
                    MessageBox.Show("Commincation with x-BIMU failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                })));
            }
        }

        /// <summary>
        /// Command confirmation method to be called by owner when confirmation received.
        /// </summary>
        public void OKReceived()
        {
            commandConfirmed = true;
        }

        public delegate void onSendSerialPort(string e);
        public event onSendSerialPort SendSerialPort;
        protected virtual void OnSendSerialPort(string e) { if (SendSerialPort != null) SendSerialPort(e); }
    }
}