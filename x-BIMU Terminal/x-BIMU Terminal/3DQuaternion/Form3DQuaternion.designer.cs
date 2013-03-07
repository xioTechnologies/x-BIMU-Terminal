namespace x_BIMU_Terminal
{
    partial class Form3DQuaternion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3DQuaternion));
            this.simpleOpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl
            // 
            this.simpleOpenGlControl.AccumBits = ((byte)(0));
            this.simpleOpenGlControl.AutoCheckErrors = false;
            this.simpleOpenGlControl.AutoFinish = false;
            this.simpleOpenGlControl.AutoMakeCurrent = true;
            this.simpleOpenGlControl.AutoSwapBuffers = true;
            this.simpleOpenGlControl.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl.ColorBits = ((byte)(32));
            this.simpleOpenGlControl.DepthBits = ((byte)(16));
            this.simpleOpenGlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleOpenGlControl.Location = new System.Drawing.Point(0, 0);
            this.simpleOpenGlControl.Name = "simpleOpenGlControl";
            this.simpleOpenGlControl.Size = new System.Drawing.Size(584, 362);
            this.simpleOpenGlControl.StencilBits = ((byte)(0));
            this.simpleOpenGlControl.TabIndex = 0;
            this.simpleOpenGlControl.Load += new System.EventHandler(this.simpleOpenGlControl_Load);
            this.simpleOpenGlControl.SizeChanged += new System.EventHandler(this.simpleOpenGlControl_SizeChanged);
            this.simpleOpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl_Paint);
            this.simpleOpenGlControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl_MouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelX,
            this.toolStripStatusLabelY,
            this.toolStripStatusLabelZ});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelX
            // 
            this.toolStripStatusLabelX.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelX.Name = "toolStripStatusLabelX";
            this.toolStripStatusLabelX.Size = new System.Drawing.Size(189, 17);
            this.toolStripStatusLabelX.Spring = true;
            this.toolStripStatusLabelX.Text = "toolStripStatusLabelX";
            // 
            // toolStripStatusLabelY
            // 
            this.toolStripStatusLabelY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabelY.Name = "toolStripStatusLabelY";
            this.toolStripStatusLabelY.Size = new System.Drawing.Size(189, 17);
            this.toolStripStatusLabelY.Spring = true;
            this.toolStripStatusLabelY.Text = "toolStripStatusLabelY";
            // 
            // toolStripStatusLabelZ
            // 
            this.toolStripStatusLabelZ.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabelZ.Name = "toolStripStatusLabelZ";
            this.toolStripStatusLabelZ.Size = new System.Drawing.Size(189, 17);
            this.toolStripStatusLabelZ.Spring = true;
            this.toolStripStatusLabelZ.Text = "toolStripStatusLabelZ";
            // 
            // Form3DQuaternion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.simpleOpenGlControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3DQuaternion";
            this.Text = "3D Cuboid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3DQuaternion_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Form3DQuaternion_VisibleChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelY;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelZ;
    }
}