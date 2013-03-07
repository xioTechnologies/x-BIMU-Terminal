namespace x_BIMU_Terminal
{
    partial class FormWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWizard));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonCancelPage1 = new System.Windows.Forms.Button();
            this.buttonNextPage1 = new System.Windows.Forms.Button();
            this.panelPage1 = new System.Windows.Forms.Panel();
            this.labelTextPage1 = new System.Windows.Forms.Label();
            this.labelTitlePage1 = new System.Windows.Forms.Label();
            this.panelPage2 = new System.Windows.Forms.Panel();
            this.labelTextPage2 = new System.Windows.Forms.Label();
            this.labelTitlePage2 = new System.Windows.Forms.Label();
            this.buttonNextPage2 = new System.Windows.Forms.Button();
            this.buttonCancelPage2 = new System.Windows.Forms.Button();
            this.panelPage3 = new System.Windows.Forms.Panel();
            this.labelTextPage3 = new System.Windows.Forms.Label();
            this.labelTitlePage3 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPage1.SuspendLayout();
            this.panelPage2.SuspendLayout();
            this.panelPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(140, 342);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonCancelPage1
            // 
            this.buttonCancelPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelPage1.Location = new System.Drawing.Point(176, 297);
            this.buttonCancelPage1.Name = "buttonCancelPage1";
            this.buttonCancelPage1.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelPage1.TabIndex = 1;
            this.buttonCancelPage1.Text = "Cancel";
            this.buttonCancelPage1.UseVisualStyleBackColor = true;
            this.buttonCancelPage1.Click += new System.EventHandler(this.buttonCancelOrFinish_Click);
            // 
            // buttonNextPage1
            // 
            this.buttonNextPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextPage1.Location = new System.Drawing.Point(257, 297);
            this.buttonNextPage1.Name = "buttonNextPage1";
            this.buttonNextPage1.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPage1.TabIndex = 2;
            this.buttonNextPage1.Text = "Next";
            this.buttonNextPage1.UseVisualStyleBackColor = true;
            this.buttonNextPage1.Click += new System.EventHandler(this.buttonNextPage1_Click);
            // 
            // panelPage1
            // 
            this.panelPage1.Controls.Add(this.labelTextPage1);
            this.panelPage1.Controls.Add(this.labelTitlePage1);
            this.panelPage1.Controls.Add(this.buttonNextPage1);
            this.panelPage1.Controls.Add(this.buttonCancelPage1);
            this.panelPage1.Location = new System.Drawing.Point(146, 10);
            this.panelPage1.Name = "panelPage1";
            this.panelPage1.Size = new System.Drawing.Size(344, 332);
            this.panelPage1.TabIndex = 0;
            // 
            // labelTextPage1
            // 
            this.labelTextPage1.AutoSize = true;
            this.labelTextPage1.Location = new System.Drawing.Point(8, 77);
            this.labelTextPage1.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTextPage1.Name = "labelTextPage1";
            this.labelTextPage1.Size = new System.Drawing.Size(64, 13);
            this.labelTextPage1.TabIndex = 5;
            this.labelTextPage1.Text = "Page 1 text.";
            // 
            // labelTitlePage1
            // 
            this.labelTitlePage1.AutoSize = true;
            this.labelTitlePage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePage1.Location = new System.Drawing.Point(6, 9);
            this.labelTitlePage1.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTitlePage1.Name = "labelTitlePage1";
            this.labelTitlePage1.Size = new System.Drawing.Size(312, 25);
            this.labelTitlePage1.TabIndex = 0;
            this.labelTitlePage1.Text = "Page 1 - Welcome And Options";
            // 
            // panelPage2
            // 
            this.panelPage2.Controls.Add(this.labelTextPage2);
            this.panelPage2.Controls.Add(this.labelTitlePage2);
            this.panelPage2.Controls.Add(this.buttonNextPage2);
            this.panelPage2.Controls.Add(this.buttonCancelPage2);
            this.panelPage2.Location = new System.Drawing.Point(496, 10);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(344, 332);
            this.panelPage2.TabIndex = 1;
            // 
            // labelTextPage2
            // 
            this.labelTextPage2.AutoSize = true;
            this.labelTextPage2.Location = new System.Drawing.Point(8, 77);
            this.labelTextPage2.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTextPage2.Name = "labelTextPage2";
            this.labelTextPage2.Size = new System.Drawing.Size(64, 13);
            this.labelTextPage2.TabIndex = 6;
            this.labelTextPage2.Text = "Page 2 text.";
            // 
            // labelTitlePage2
            // 
            this.labelTitlePage2.AutoSize = true;
            this.labelTitlePage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePage2.Location = new System.Drawing.Point(6, 9);
            this.labelTitlePage2.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTitlePage2.Name = "labelTitlePage2";
            this.labelTitlePage2.Size = new System.Drawing.Size(237, 25);
            this.labelTitlePage2.TabIndex = 0;
            this.labelTitlePage2.Text = "Page 2 - Doing Tasks...";
            // 
            // buttonNextPage2
            // 
            this.buttonNextPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextPage2.Enabled = false;
            this.buttonNextPage2.Location = new System.Drawing.Point(257, 297);
            this.buttonNextPage2.Name = "buttonNextPage2";
            this.buttonNextPage2.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPage2.TabIndex = 2;
            this.buttonNextPage2.Text = "Next";
            this.buttonNextPage2.UseVisualStyleBackColor = true;
            this.buttonNextPage2.Click += new System.EventHandler(this.buttonNextPage2_Click);
            // 
            // buttonCancelPage2
            // 
            this.buttonCancelPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelPage2.Location = new System.Drawing.Point(176, 297);
            this.buttonCancelPage2.Name = "buttonCancelPage2";
            this.buttonCancelPage2.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelPage2.TabIndex = 1;
            this.buttonCancelPage2.Text = "Cancel";
            this.buttonCancelPage2.UseVisualStyleBackColor = true;
            this.buttonCancelPage2.Click += new System.EventHandler(this.buttonCancelOrFinish_Click);
            // 
            // panelPage3
            // 
            this.panelPage3.Controls.Add(this.labelTextPage3);
            this.panelPage3.Controls.Add(this.labelTitlePage3);
            this.panelPage3.Controls.Add(this.buttonFinish);
            this.panelPage3.Location = new System.Drawing.Point(846, 10);
            this.panelPage3.Name = "panelPage3";
            this.panelPage3.Size = new System.Drawing.Size(344, 332);
            this.panelPage3.TabIndex = 2;
            // 
            // labelTextPage3
            // 
            this.labelTextPage3.AutoSize = true;
            this.labelTextPage3.Location = new System.Drawing.Point(8, 77);
            this.labelTextPage3.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTextPage3.Name = "labelTextPage3";
            this.labelTextPage3.Size = new System.Drawing.Size(64, 13);
            this.labelTextPage3.TabIndex = 6;
            this.labelTextPage3.Text = "Page 3 text.";
            // 
            // labelTitlePage3
            // 
            this.labelTitlePage3.AutoSize = true;
            this.labelTitlePage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePage3.Location = new System.Drawing.Point(6, 9);
            this.labelTitlePage3.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTitlePage3.Name = "labelTitlePage3";
            this.labelTitlePage3.Size = new System.Drawing.Size(263, 25);
            this.labelTitlePage3.TabIndex = 0;
            this.labelTitlePage3.Text = "Page 3 - Wizard Complete";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Location = new System.Drawing.Point(257, 297);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 2;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonCancelOrFinish_Click);
            // 
            // FormWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 342);
            this.Controls.Add(this.panelPage3);
            this.Controls.Add(this.panelPage1);
            this.Controls.Add(this.panelPage2);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWizard";
            this.Text = "FormWizard";
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

        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Button buttonCancelPage1;
        public System.Windows.Forms.Button buttonNextPage1;
        public System.Windows.Forms.Panel panelPage1;
        public System.Windows.Forms.Label labelTitlePage1;
        public System.Windows.Forms.Panel panelPage2;
        public System.Windows.Forms.Label labelTitlePage2;
        public System.Windows.Forms.Button buttonNextPage2;
        public System.Windows.Forms.Button buttonCancelPage2;
        public System.Windows.Forms.Panel panelPage3;
        public System.Windows.Forms.Label labelTitlePage3;
        public System.Windows.Forms.Button buttonFinish;
        public System.Windows.Forms.Label labelTextPage1;
        public System.Windows.Forms.Label labelTextPage2;
        public System.Windows.Forms.Label labelTextPage3;
    }
}