using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Tao.OpenGl;
using System.Globalization;

namespace x_BIMU_Terminal
{
    /// <summary>
    /// 3D Cuboid form class.
    /// </summary>
    public partial class Form3DQuaternion : Form
    {
        #region Variables and properties

        /// <summary>
        /// Form update timer.
        /// </summary>
        private Timer formUpdateTimer;

        /// <summary>
        /// Array of image file paths.
        /// </summary>
        private string[] imageFiles;

        /// <summary>
        /// Array of textures
        /// </summary>
        private uint[] textures;

        /// <summary>
        /// Dimensions of cuboid.
        /// </summary>
        private float halfXdimension, halfYdimension, halfZdimension;

        /// <summary>
        /// Intermediate quaternion used to zero camera view.
        /// </summary>
        private float[] intQuaternion = new float[] { 1.0f, 0.0f, 0.0f, 0.0f };

        /// <summary>
        /// Quaternion describing sensor relative to Earth.
        /// </summary>
        public float[] quaternion;

        /// <summary>
        /// Quaternion describing sensor relative to Earth.
        /// </summary>
        public float[] Quaternion
        {
            get
            {
                return quaternion;
            }
            set
            {
                quaternion = NormaliseQuaternion(value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Form3DQuaternion"/> class.
        /// </summary>
        public Form3DQuaternion()
            : this(new string[] { "3DQuaternion/Right.png", "3DQuaternion/Left.png", "3DQuaternion/Back.png", "3DQuaternion/Front.png", "3DQuaternion/Top.png", "3DQuaternion/Bottom.png" }, new float[] { 6, 4, 2 })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form3DQuaternion"/> class.
        /// </summary>
        /// <param name="imageFilePaths">
        /// File paths of images used for 6 faces of cuboid. Index order is: Right (+X), Left (-X), Back (+Y), Front (-Y), Top (+Z), and Bottom (-Z).
        /// </param>
        public Form3DQuaternion(string[] imageFilePaths)
            : this(imageFilePaths, new float[] { 6, 4, 2 })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form3DQuaternion"/> class.
        /// </summary>
        /// <param name="imageFilePaths">
        /// File paths of images used for 6 faces of cuboid. Index order is: Right (+X), Left (-X), Back (+Y), Front (-Y), Top (+Z), and Bottom (-Z).
        /// </param>
        /// <param name="dimensions">
        /// Dimensions of the cuboid.
        /// </param>
        public Form3DQuaternion(string[] imageFilePaths, float[] dimensions)
        {
            InitializeComponent();
            Quaternion = new float[] { 1, 0, 0, 0 };
            imageFiles = imageFilePaths;
            halfXdimension = dimensions[0] / 2;
            halfYdimension = dimensions[1] / 2;
            halfZdimension = dimensions[2] / 2;
            formUpdateTimer = new Timer();
            formUpdateTimer.Interval = 20;
            formUpdateTimer.Tick += new EventHandler(formUpdateTimer_Tick);
        }

        #endregion

        #region Form events

        /// <summary>
        /// simpleOpenGlControl MouseClick to display context menu
        /// </summary>
        private void simpleOpenGlControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu regContextMenu = new ContextMenu();
                regContextMenu.MenuItems.Add(new MenuItem("Centre View"));
                regContextMenu.MenuItems.Add(new MenuItem("Cancel Centred View"));
                regContextMenu.MenuItems[0].Click += new EventHandler(delegate { intQuaternion = new float[] { quaternion[0], -quaternion[1], -quaternion[2], -quaternion[3] }; });
                regContextMenu.MenuItems[1].Click += new EventHandler(delegate { intQuaternion = new float[] { 1.0f, 0.0f, 0.0f, 0.0f }; });
                regContextMenu.Show(simpleOpenGlControl, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// Form visible changed event to start/stop form update formUpdateTimer.
        /// </summary>
        private void Form3DQuaternion_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                formUpdateTimer.Start();
            }
            else
            {
                formUpdateTimer.Stop();
            }
        }

        /// <summary>
        /// Form closing event to minimise form instead of close.
        /// </summary>
        private void Form3DQuaternion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        /// <summary>
        /// Timer tick event to refresh graphics.
        /// </summary>
        private void formUpdateTimer_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                simpleOpenGlControl.Refresh();
            }
        }

        #endregion

        #region SimpleOpenGlControl methods

        /// <summary>
        /// Form load event to initialises OpenGL graphics.
        /// </summary>
        private void simpleOpenGlControl_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl.InitializeContexts();
            simpleOpenGlControl.SwapBuffers();
            simpleOpenGlControl_SizeChanged(sender, e);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glEnable(Gl.GL_TEXTURE_2D);						    // Enable Texture Mapping            
            Gl.glEnable(Gl.GL_NORMALIZE);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_DEPTH_TEST);						    // Enables Depth Testing
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glHint(Gl.GL_POLYGON_SMOOTH_HINT, Gl.GL_NICEST);     // Really Nice Point Smoothing
            textures = LoadTextureFromImage(imageFiles);
        }

        /// <summary>
        /// Loads textures from files.
        /// </summary>
        /// <param name="filesNames">
        /// File paths of texture image files.
        /// </param> 
        private uint[] LoadTextureFromImage(string[] filesNames)
        {
            int numOfPic = filesNames.Length;
            uint[] texture = new uint[numOfPic];
            Bitmap[] bitmap = new Bitmap[numOfPic];
            BitmapData[] bitmapdata = new BitmapData[numOfPic];
            for (int im = 0; im < numOfPic; im++)
            {
                if (File.Exists(filesNames[im]))
                {
                    bitmap[im] = new Bitmap(filesNames[im]);
                }
            }
            Gl.glGenTextures(numOfPic, texture);
            for (int i = 0; i < numOfPic; i++)
            {
                bitmap[i].RotateFlip(RotateFlipType.RotateNoneFlipY);
                Rectangle rect = new Rectangle(0, 0, bitmap[i].Width, bitmap[i].Height);
                bitmapdata[i] = bitmap[i].LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture[i]);
                Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_MODULATE);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);
                Glu.gluBuild2DMipmaps(Gl.GL_TEXTURE_2D, (int)Gl.GL_RGB, bitmap[i].Width, bitmap[i].Height, Gl.GL_BGR_EXT, Gl.GL_UNSIGNED_BYTE, bitmapdata[i].Scan0);
                bitmap[i].UnlockBits(bitmapdata[i]);
                bitmap[i].Dispose();
            }
            return texture;
        }

        /// <summary>
        /// Window resize event to adjusts perspective.
        /// </summary>
        private void simpleOpenGlControl_SizeChanged(object sender, EventArgs e)
        {
            int height = simpleOpenGlControl.Size.Height;
            int width = simpleOpenGlControl.Size.Width;
            Gl.glViewport(0, 0, width, height);
            Gl.glPushMatrix();
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(10, (float)width / (float)height, 1.0, 250);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glPopMatrix();
        }

        /// <summary>
        /// Redraw cuboid polygons.
        /// </summary>
        private void simpleOpenGlControl_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);    // Clear screen and DepthBuffer
            Gl.glLoadIdentity();
            Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_FILL);

            // Set camera view and distance
            Gl.glTranslatef(0, 0, -50.0f);
            Gl.glRotatef(-90, 1, 0, 0);

            // Update displayed Euler angles
            float[] euler = ConvertToEulerAngles(quaternion);
            toolStripStatusLabelX.Text = "X: " + String.Format("{0:0.0}", euler[0]) + "°";
            toolStripStatusLabelY.Text = "Y: " + String.Format("{0:0.0}", euler[1]) + "°";
            toolStripStatusLabelZ.Text = "Z: " + String.Format("{0:0.0}", euler[2]) + "°";

            // Apply transformation matrix to cuboid
            float[] rotationMatrix = ConvertToRotationMatrix(new float[] { quaternion[0] * intQuaternion[0] - quaternion[1] * intQuaternion[1] - quaternion[2] * intQuaternion[2] - quaternion[3] * intQuaternion[3],
                                                                           quaternion[0] * intQuaternion[1] + quaternion[1] * intQuaternion[0] + quaternion[2] * intQuaternion[3] - quaternion[3] * intQuaternion[2],
                                                                           quaternion[0] * intQuaternion[2] - quaternion[1] * intQuaternion[3] + quaternion[2] * intQuaternion[0] + quaternion[3] * intQuaternion[1],
                                                                           quaternion[0] * intQuaternion[3] + quaternion[1] * intQuaternion[2] - quaternion[2] * intQuaternion[1] + quaternion[3] * intQuaternion[0]});
            Gl.glPushMatrix();
            Gl.glMultMatrixf(new float[] { rotationMatrix[0], rotationMatrix[3], rotationMatrix[6], 0.0f,
                                           rotationMatrix[1], rotationMatrix[4], rotationMatrix[7], 0.0f,
                                           rotationMatrix[2], rotationMatrix[5], rotationMatrix[8], 0.0f,
                                           0.0f,              0.0f,              0.0f,              1.0f });    // transpose of rotation matrix

            // +'ve x face
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textures[0]);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(1, 0, 0); Gl.glTexCoord2f(0, 0); Gl.glVertex3f(halfXdimension, -halfYdimension, -halfZdimension);
            Gl.glNormal3f(1, 0, 0); Gl.glTexCoord2f(0, 1); Gl.glVertex3f(halfXdimension, -halfYdimension, halfZdimension);
            Gl.glNormal3f(1, 0, 0); Gl.glTexCoord2f(1, 1); Gl.glVertex3f(halfXdimension, halfYdimension, halfZdimension);
            Gl.glNormal3f(1, 0, 0); Gl.glTexCoord2f(1, 0); Gl.glVertex3f(halfXdimension, halfYdimension, -halfZdimension);
            Gl.glEnd();

            // -'ve x face
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textures[1]);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(-1, 0, 0); Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-halfXdimension, -halfYdimension, -halfZdimension);
            Gl.glNormal3f(-1, 0, 0); Gl.glTexCoord2f(1, 1); Gl.glVertex3f(-halfXdimension, -halfYdimension, halfZdimension);
            Gl.glNormal3f(-1, 0, 0); Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-halfXdimension, halfYdimension, halfZdimension);
            Gl.glNormal3f(-1, 0, 0); Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-halfXdimension, halfYdimension, -halfZdimension);
            Gl.glEnd();

            // +'ve y face
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textures[2]);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0, 1, 0); Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-halfXdimension, halfYdimension, -halfZdimension);
            Gl.glNormal3f(0, 1, 0); Gl.glTexCoord2f(1, 1); Gl.glVertex3f(-halfXdimension, halfYdimension, halfZdimension);
            Gl.glNormal3f(0, 1, 0); Gl.glTexCoord2f(0, 1); Gl.glVertex3f(halfXdimension, halfYdimension, halfZdimension);
            Gl.glNormal3f(0, 1, 0); Gl.glTexCoord2f(0, 0); Gl.glVertex3f(halfXdimension, halfYdimension, -halfZdimension);
            Gl.glEnd();

            // -'ve y face
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textures[3]);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0, -1, 0); Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-halfXdimension, -halfYdimension, -halfZdimension);
            Gl.glNormal3f(0, -1, 0); Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-halfXdimension, -halfYdimension, halfZdimension);
            Gl.glNormal3f(0, -1, 0); Gl.glTexCoord2f(1, 1); Gl.glVertex3f(halfXdimension, -halfYdimension, halfZdimension);
            Gl.glNormal3f(0, -1, 0); Gl.glTexCoord2f(1, 0); Gl.glVertex3f(halfXdimension, -halfYdimension, -halfZdimension);
            Gl.glEnd();

            // +'ve z face
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textures[4]);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0, 0, 1); Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-halfXdimension, -halfYdimension, halfZdimension);
            Gl.glNormal3f(0, 0, 1); Gl.glTexCoord2f(1, 0); Gl.glVertex3f(halfXdimension, -halfYdimension, halfZdimension);
            Gl.glNormal3f(0, 0, 1); Gl.glTexCoord2f(1, 1); Gl.glVertex3f(halfXdimension, halfYdimension, halfZdimension);
            Gl.glNormal3f(0, 0, 1); Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-halfXdimension, halfYdimension, halfZdimension);
            Gl.glEnd();

            // -'ve z face
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textures[5]);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0, 0, -1); Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-halfXdimension, -halfYdimension, -halfZdimension);
            Gl.glNormal3f(0, 0, -1); Gl.glTexCoord2f(1, 1); Gl.glVertex3f(halfXdimension, -halfYdimension, -halfZdimension);
            Gl.glNormal3f(0, 0, -1); Gl.glTexCoord2f(1, 0); Gl.glVertex3f(halfXdimension, halfYdimension, -halfZdimension);
            Gl.glNormal3f(0, 0, -1); Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-halfXdimension, halfYdimension, -halfZdimension);
            Gl.glEnd();

            Gl.glPopMatrix();
            Gl.glFlush();
        }

        #endregion

        #region Quaternion conversions

        /// <summary>
        /// Normalises quaternion to be of unit magnitude.
        /// </summary>
        /// <param name="quaternion">
        /// Quaternion.
        /// </param>
        /// <returns>
        /// Normlaise quaternion.
        /// </returns>
        private float[] NormaliseQuaternion(float[] quaternion)
        {
            float norm = (float)Math.Sqrt(quaternion[0] * quaternion[0] + quaternion[1] * quaternion[1] + quaternion[2] * quaternion[2] + quaternion[3] * quaternion[3]);
            quaternion[0] /= norm;
            quaternion[1] /= norm;
            quaternion[2] /= norm;
            quaternion[3] /= norm;
            return quaternion;
        }

        /// <summary>
        /// Converts data to rotation matrix.
        /// </summary>
        /// <returns>
        /// Rotation matrix. Index order is row major. See http://en.wikipedia.org/wiki/Row-major_order
        /// </returns> 
        private float[] ConvertToRotationMatrix(float[] quaternion)
        {
            float R11 = 2 * quaternion[0] * quaternion[0] - 1 + 2 * quaternion[1] * quaternion[1];
            float R12 = 2 * (quaternion[1] * quaternion[2] + quaternion[0] * quaternion[3]);
            float R13 = 2 * (quaternion[1] * quaternion[3] - quaternion[0] * quaternion[2]);
            float R21 = 2 * (quaternion[1] * quaternion[2] - quaternion[0] * quaternion[3]);
            float R22 = 2 * quaternion[0] * quaternion[0] - 1 + 2 * quaternion[2] * quaternion[2];
            float R23 = 2 * (quaternion[2] * quaternion[3] + quaternion[0] * quaternion[1]);
            float R31 = 2 * (quaternion[1] * quaternion[3] + quaternion[0] * quaternion[2]);
            float R32 = 2 * (quaternion[2] * quaternion[3] - quaternion[0] * quaternion[1]);
            float R33 = 2 * quaternion[0] * quaternion[0] - 1 + 2 * quaternion[3] * quaternion[3];
            return new float[] { R11, R12, R13,
                                 R21, R22, R23,
                                 R31, R32, R33 };
        }

        /// <summary>
        /// Converts data to ZYX Euler angles (in degrees).
        /// </summary>
        /// <param name="quaternion">
        /// Quaternion.
        /// </param>
        /// <returns>
        /// Euler angles [phi, theta, psi].
        /// </returns>
        private float[] ConvertToEulerAngles(float[] quaternion)
        {
            float phi = (float)Math.Atan2(2 * (quaternion[2] * quaternion[3] - quaternion[0] * quaternion[1]), 2 * quaternion[0] * quaternion[0] - 1 + 2 * quaternion[3] * quaternion[3]);
            float theta = (float)-Math.Atan((2.0 * (quaternion[1] * quaternion[3] + quaternion[0] * quaternion[2])) / Math.Sqrt(1.0 - Math.Pow((2.0 * quaternion[1] * quaternion[3] + 2.0 * quaternion[0] * quaternion[2]), 2.0)));
            float psi = (float)Math.Atan2(2 * (quaternion[1] * quaternion[2] - quaternion[0] * quaternion[3]), 2 * quaternion[0] * quaternion[0] - 1 + 2 * quaternion[1] * quaternion[1]);
            return new float[] { RadToDeg(phi), RadToDeg(theta), RadToDeg(psi) };
        }

        /// <summary>
        /// Converts from radians to degrees.
        /// </summary>
        /// <param name="radians">
        /// Angular quantity in radians.
        /// </param> 
        /// <returns>
        /// Angular quantity in degrees.
        /// </returns>
        private float RadToDeg(float radians)
        {
            return 57.2957795130823f * radians;
        }

        #endregion
    }
}