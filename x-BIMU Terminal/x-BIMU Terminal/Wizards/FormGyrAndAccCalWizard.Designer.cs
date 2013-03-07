namespace x_BIMU_Terminal
{
    partial class FormGyrAndAccCalWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGyrAndAccCalWizard));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPage1.SuspendLayout();
            this.panelPage2.SuspendLayout();
            this.panelPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitlePage1
            // 
            this.labelTitlePage1.Size = new System.Drawing.Size(310, 50);
            this.labelTitlePage1.Text = "Gyroscope And Accelerometer Calibration Wizard";
            // 
            // labelTitlePage2
            // 
            this.labelTitlePage2.Size = new System.Drawing.Size(289, 25);
            this.labelTitlePage2.Text = "Performing Calibration Tasks";
            // 
            // labelTitlePage3
            // 
            this.labelTitlePage3.Size = new System.Drawing.Size(212, 25);
            this.labelTitlePage3.Text = "Calibration Complete";
            // 
            // labelTextPage1
            // 
            this.labelTextPage1.Size = new System.Drawing.Size(323, 91);
            this.labelTextPage1.Text = resources.GetString("labelTextPage1.Text");
            // 
            // labelTextPage3
            // 
            this.labelTextPage3.Size = new System.Drawing.Size(336, 91);
            this.labelTextPage3.Text = resources.GetString("labelTextPage3.Text");
            // 
            // FormGyrAndAccCalWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 342);
            this.Name = "FormGyrAndAccCalWizard";
            this.Text = "FormGyrAndAccCalWizard";
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

    }
}