namespace x_BIMU_Terminal
{
    partial class FormFirmwareUploadWizard
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
            this.label_hexFile = new System.Windows.Forms.Label();
            this.textBox_hexFile = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPage1.SuspendLayout();
            this.panelPage2.SuspendLayout();
            this.panelPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPage1
            // 
            this.panelPage1.Controls.Add(this.label_hexFile);
            this.panelPage1.Controls.Add(this.textBox_hexFile);
            this.panelPage1.Controls.Add(this.button_browse);
            this.panelPage1.Controls.SetChildIndex(this.button_browse, 0);
            this.panelPage1.Controls.SetChildIndex(this.textBox_hexFile, 0);
            this.panelPage1.Controls.SetChildIndex(this.label_hexFile, 0);
            this.panelPage1.Controls.SetChildIndex(this.buttonCancelPage1, 0);
            this.panelPage1.Controls.SetChildIndex(this.buttonNextPage1, 0);
            this.panelPage1.Controls.SetChildIndex(this.labelTitlePage1, 0);
            this.panelPage1.Controls.SetChildIndex(this.labelTextPage1, 0);
            // 
            // labelTitlePage1
            // 
            this.labelTitlePage1.Size = new System.Drawing.Size(247, 25);
            this.labelTitlePage1.Text = "Firmware Upload Wizard";
            // 
            // labelTitlePage2
            // 
            this.labelTitlePage2.Size = new System.Drawing.Size(254, 25);
            this.labelTitlePage2.Text = "Performing Upload Tasks";
            // 
            // labelTitlePage3
            // 
            this.labelTitlePage3.Size = new System.Drawing.Size(271, 25);
            this.labelTitlePage3.Text = "Firmware Upload Complete";
            // 
            // labelTextPage1
            // 
            this.labelTextPage1.Size = new System.Drawing.Size(193, 13);
            this.labelTextPage1.Text = "Welcome to the firnware uplaod wizard.";
            // 
            // labelTextPage3
            // 
            this.labelTextPage3.Size = new System.Drawing.Size(195, 13);
            this.labelTextPage3.Text = "The firmware upload wizard is complete.";
            // 
            // label_hexFile
            // 
            this.label_hexFile.AutoSize = true;
            this.label_hexFile.Location = new System.Drawing.Point(3, 172);
            this.label_hexFile.Name = "label_hexFile";
            this.label_hexFile.Size = new System.Drawing.Size(48, 13);
            this.label_hexFile.TabIndex = 6;
            this.label_hexFile.Text = "Hex File:";
            // 
            // textBox_hexFile
            // 
            this.textBox_hexFile.Location = new System.Drawing.Point(57, 169);
            this.textBox_hexFile.Name = "textBox_hexFile";
            this.textBox_hexFile.Size = new System.Drawing.Size(244, 20);
            this.textBox_hexFile.TabIndex = 7;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(307, 167);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(25, 23);
            this.button_browse.TabIndex = 8;
            this.button_browse.Text = "...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // FormFirmwareUploadWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 342);
            this.Name = "FormFirmwareUploadWizard";
            this.Text = "Magnetometer Calibration Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelPage1.ResumeLayout(false);
            this.panelPage1.PerformLayout();
            this.panelPage2.ResumeLayout(false);
            this.panelPage2.PerformLayout();
            this.panelPage3.ResumeLayout(false);
            this.panelPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_hexFile;
        private System.Windows.Forms.TextBox textBox_hexFile;
        private System.Windows.Forms.Button button_browse;

    }
}