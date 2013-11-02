namespace x_BIMU_Terminal
{
    partial class FormTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTool));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonCancelPage1 = new System.Windows.Forms.Button();
            this.panelPage1 = new System.Windows.Forms.Panel();
            this.labelTextPage1 = new System.Windows.Forms.Label();
            this.labelTitlePage1 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelPage2 = new System.Windows.Forms.Panel();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelTextPage2 = new System.Windows.Forms.Label();
            this.labelTitlePage2 = new System.Windows.Forms.Label();
            this.buttonCancelPage2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPage1.SuspendLayout();
            this.panelPage2.SuspendLayout();
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
            this.buttonCancelPage1.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelPage1
            // 
            this.panelPage1.Controls.Add(this.labelTextPage1);
            this.panelPage1.Controls.Add(this.labelTitlePage1);
            this.panelPage1.Controls.Add(this.buttonNext);
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
            this.labelTextPage1.Size = new System.Drawing.Size(81, 13);
            this.labelTextPage1.TabIndex = 5;
            this.labelTextPage1.Text = "labelTextPage1";
            // 
            // labelTitlePage1
            // 
            this.labelTitlePage1.AutoSize = true;
            this.labelTitlePage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePage1.Location = new System.Drawing.Point(6, 9);
            this.labelTitlePage1.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTitlePage1.Name = "labelTitlePage1";
            this.labelTitlePage1.Size = new System.Drawing.Size(161, 25);
            this.labelTitlePage1.TabIndex = 0;
            this.labelTitlePage1.Text = "labelTitlePage1";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(257, 297);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panelPage2
            // 
            this.panelPage2.Controls.Add(this.buttonFinish);
            this.panelPage2.Controls.Add(this.labelTextPage2);
            this.panelPage2.Controls.Add(this.labelTitlePage2);
            this.panelPage2.Controls.Add(this.buttonCancelPage2);
            this.panelPage2.Location = new System.Drawing.Point(496, 10);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(344, 332);
            this.panelPage2.TabIndex = 1;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Enabled = false;
            this.buttonFinish.Location = new System.Drawing.Point(257, 297);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 3;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTextPage2
            // 
            this.labelTextPage2.AutoSize = true;
            this.labelTextPage2.Location = new System.Drawing.Point(8, 77);
            this.labelTextPage2.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTextPage2.Name = "labelTextPage2";
            this.labelTextPage2.Size = new System.Drawing.Size(81, 13);
            this.labelTextPage2.TabIndex = 6;
            this.labelTextPage2.Text = "labelTextPage2";
            // 
            // labelTitlePage2
            // 
            this.labelTitlePage2.AutoSize = true;
            this.labelTitlePage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePage2.Location = new System.Drawing.Point(6, 9);
            this.labelTitlePage2.MaximumSize = new System.Drawing.Size(340, 0);
            this.labelTitlePage2.Name = "labelTitlePage2";
            this.labelTitlePage2.Size = new System.Drawing.Size(161, 25);
            this.labelTitlePage2.TabIndex = 0;
            this.labelTitlePage2.Text = "labelTitlePage2";
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
            this.buttonCancelPage2.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 342);
            this.Controls.Add(this.panelPage1);
            this.Controls.Add(this.panelPage2);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTool";
            this.Text = "FormTool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelPage1.ResumeLayout(false);
            this.panelPage1.PerformLayout();
            this.panelPage2.ResumeLayout(false);
            this.panelPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Button buttonCancelPage1;
        public System.Windows.Forms.Panel panelPage1;
        public System.Windows.Forms.Label labelTitlePage1;
        public System.Windows.Forms.Panel panelPage2;
        public System.Windows.Forms.Label labelTitlePage2;
        public System.Windows.Forms.Button buttonCancelPage2;
        public System.Windows.Forms.Label labelTextPage1;
        public System.Windows.Forms.Label labelTextPage2;
        public System.Windows.Forms.Button buttonNext;
        public System.Windows.Forms.Button buttonFinish;
    }
}