namespace x_BIMU_Terminal
{
    partial class FormToolUploadFirmware
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
            this.labelHexFile = new System.Windows.Forms.Label();
            this.textBoxHexFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPage1.SuspendLayout();
            this.panelPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPage1
            // 
            this.panelPage1.Controls.Add(this.labelHexFile);
            this.panelPage1.Controls.Add(this.textBoxHexFile);
            this.panelPage1.Controls.Add(this.buttonBrowse);
            this.panelPage1.Controls.SetChildIndex(this.buttonBrowse, 0);
            this.panelPage1.Controls.SetChildIndex(this.textBoxHexFile, 0);
            this.panelPage1.Controls.SetChildIndex(this.labelHexFile, 0);
            this.panelPage1.Controls.SetChildIndex(this.buttonCancelPage1, 0);
            this.panelPage1.Controls.SetChildIndex(this.buttonNext, 0);
            this.panelPage1.Controls.SetChildIndex(this.labelTitlePage1, 0);
            this.panelPage1.Controls.SetChildIndex(this.labelTextPage1, 0);
            // 
            // labelTitlePage1
            // 
            this.labelTitlePage1.Size = new System.Drawing.Size(174, 25);
            this.labelTitlePage1.Text = "Upload Firmware";
            // 
            // labelTitlePage2
            // 
            this.labelTitlePage2.Size = new System.Drawing.Size(174, 25);
            this.labelTitlePage2.Text = "Upload Firmware";
            // 
            // labelTextPage1
            // 
            this.labelTextPage1.Size = new System.Drawing.Size(324, 52);
            this.labelTextPage1.Text = "Please select firmware Hex file to upload.\r\n\r\nWarning - Firmware can only be uplo" +
                "aded using the serial breakout board.";
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            // 
            // labelHexFile
            // 
            this.labelHexFile.AutoSize = true;
            this.labelHexFile.Location = new System.Drawing.Point(8, 177);
            this.labelHexFile.Name = "labelHexFile";
            this.labelHexFile.Size = new System.Drawing.Size(48, 13);
            this.labelHexFile.TabIndex = 9;
            this.labelHexFile.Text = "Hex File:";
            // 
            // textBoxHexFile
            // 
            this.textBoxHexFile.Location = new System.Drawing.Point(62, 174);
            this.textBoxHexFile.Name = "textBoxHexFile";
            this.textBoxHexFile.Size = new System.Drawing.Size(244, 20);
            this.textBoxHexFile.TabIndex = 10;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(312, 172);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowse.TabIndex = 11;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // FormToolUploadFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 342);
            this.Name = "FormToolUploadFirmware";
            this.Text = "Upload Firmware";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelPage1.ResumeLayout(false);
            this.panelPage1.PerformLayout();
            this.panelPage2.ResumeLayout(false);
            this.panelPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHexFile;
        private System.Windows.Forms.TextBox textBoxHexFile;
        private System.Windows.Forms.Button buttonBrowse;
    }
}