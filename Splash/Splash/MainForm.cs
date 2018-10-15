using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

//
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;
using AForge.Vision.Motion;

using System.Threading;
using System.Windows.Input;

//for serial comm with the Sanguino
using System.IO.Ports;

namespace Splash
{
    public partial class MainForm : Form
    {
        VideoSourcePlayer videoPlayer = null;

        private bool bStartDrawing = false;
        private bool bDoneOnce = false;
        
        private IntPoint histposOfBlob;
        
        private Bitmap paperBMP;

        private Color currBrushColor = Color.Red;
        private int iBrushColor = 1;

        private SolidBrush brush;
        private int iWidthOfBrush = 20;
        private int iHeightOfBrush = 20;
        private int iFlickerGuardBand = 0;
        private int iFlickerGuardBandPadding = 100;

        private string strMairduinoPort;
        private SerialPort MairduinoCommPort;
        private string currColorCode = "r";

        public MainForm()
        {            
            InitializeComponent();

            histposOfBlob.X = this.pnlPaper.Location.X;
            histposOfBlob.Y = this.pnlPaper.Location.Y;

            iFlickerGuardBand = this.iWidthOfBrush + iFlickerGuardBandPadding;

            brush = new SolidBrush(currBrushColor);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //we will store all graphics painted by the user in a
            //bitmap in memory so that we can restore it when the
            //main form gets focus again.
                        
            this.paperBMP = new Bitmap(this.pnlPaper.ClientRectangle.Width,
                this.pnlPaper.ClientRectangle.Height, 
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(paperBMP);
            g.Clear(Color.White);

            this.pnlRedColor.BorderStyle = BorderStyle.Fixed3D;
            this.pnlRedColor.BackColor = Color.DarkRed;
            iBrushColor = 1;
            
        }

        void pnlPaper_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        void MainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;            
            graphicsObj.DrawImage(paperBMP, this.pnlPaper.Location.X,
                this.pnlPaper.Location.Y, paperBMP.Width, paperBMP.Height);
            graphicsObj.Dispose();
                        
        }

        void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {            
            if(this.videoPlayer.IsRunning)
            {
                MessageBox.Show("Please click Stop from Basic Controls menu!");
                e.Cancel = false;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelectWebcam webcam = new FrmSelectWebcam();
            if (DialogResult.OK == webcam.ShowDialog(this))
            {
                VideoCaptureDevice videoSource = new VideoCaptureDevice(webcam.device);

                this.videoPlayer.AutoSizeControl = true;

                videoPlayer.VideoSource = (IVideoSource)videoSource;
                videoPlayer.Start();

                this.startDrawingToolStripMenuItem.Enabled = true;
                Thread.Sleep(100);
                                
                /*
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SuspendLayout();
                this.ResumeLayout(true);
                 * */

            }
        }

        void MainForm_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //a key was pressed. See if it is one of interest to us...
            switch (e.KeyChar)
            {
                case ((char)Keys.Space):
                    {
                        //spacebar was pressed. Move to the next color
                        ChangeCurrentBrushColor();
                        
                        break;
                    }

                case ((char)Keys.Escape):
                    {
                        //toggle painting
                        if (this.bStartDrawing)
                        {
                            this.txtBoxInfo.ForeColor = Color.Red;
                            this.txtBoxInfo.Text = "Drawing has been paused.";
                            this.txtBoxInfo.ForeColor = Color.Black;
                            this.bStartDrawing = false;
                        }
                        else
                        {
                            this.bStartDrawing = true;
                            this.txtBoxInfo.Text = "Drawing restarted.";
                        }
                        break;
                    }

                case 'x':
                    {
                        //eraser
                        Graphics g = Graphics.FromImage(paperBMP);
                        g.Clear(Color.White);
                        this.Invalidate(true);

                        break;
                    }
                default: break;

            }//switch (e.KeyChar)
           
        }

        private void ChangeCurrentBrushColor()
        {
            //1 = red, 2 = green, 3 = blue
            switch (iBrushColor)
            {
                case 1:
                    {
                        //current color is red. Move to green 2.
                        currBrushColor = Color.Green;
                        pnlGreenColor.BackColor = Color.Green;
                        pnlGreenColor.BorderStyle = BorderStyle.Fixed3D;
                        iBrushColor = 2;
                        currColorCode = "g";
                        
                        //reset other colors
                        pnlRedColor.BackColor = Color.DarkRed;
                        pnlRedColor.BorderStyle = BorderStyle.None;
                        pnlBlueColor.BackColor = Color.DarkBlue;
                        pnlBlueColor.BorderStyle = BorderStyle.None;

                        break;
                    }

                case 2:
                    {
                        //current color is green. move to blue 3.
                        currBrushColor = Color.Blue;
                        pnlBlueColor.BackColor = Color.Blue;
                        pnlBlueColor.BorderStyle = BorderStyle.Fixed3D;
                        iBrushColor = 3;
                        currColorCode = "b";

                        //reset other colors
                        pnlRedColor.BackColor = Color.DarkRed;
                        pnlRedColor.BorderStyle = BorderStyle.None;
                        pnlGreenColor.BackColor = Color.DarkGreen;
                        pnlGreenColor.BorderStyle = BorderStyle.None;
                        
                        break;
                    }

                case 3:
                    {
                        //current color is blue. move to red 1.
                        currBrushColor = Color.Red;
                        this.pnlRedColor.BackColor = Color.Red;
                        this.pnlRedColor.BorderStyle = BorderStyle.Fixed3D;
                        iBrushColor = 1;
                        currColorCode = "r";

                        //reset other colors
                        pnlGreenColor.BackColor = Color.DarkGreen;
                        pnlGreenColor.BorderStyle = BorderStyle.None;
                        pnlBlueColor.BackColor = Color.DarkBlue;
                        pnlBlueColor.BorderStyle = BorderStyle.None;

                        break;
                    }
            }
        }

        void videoPlayer_NewFrame(object sender, ref System.Drawing.Bitmap image)
        {
            //track position of the 'pen' and draw selected control on the paper
            //panel accordingly.
            lock (this)
            {
                ApplyFilter(image);

                if (!bDoneOnce)
                {
                    //do one time activites that make sense to do only now
                    this.txtBoxInfo.Text = "Webcam video stream ready. Click Start Drawing now!";
                    this.SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, false);
                    
                    bDoneOnce = true;
                }

                if (this.bStartDrawing)
                {                    
                    image = DisplayAndTrackDrawingTool(image);
                }
            }
        }

        private void ApplyFilter(Bitmap bmp)
        {
            AForge.Imaging.Filters.ColorFiltering colorFiltering = new AForge.Imaging.Filters.ColorFiltering();
            colorFiltering.Red = new IntRange(150, 255);
            colorFiltering.Green = new IntRange(0, 70);
            colorFiltering.Blue = new IntRange(0, 70);
            colorFiltering.ApplyInPlace(bmp);

        }

        private Bitmap DisplayAndTrackDrawingTool(Bitmap image)
        {
            //grayscale the image
            AForge.Imaging.Filters.Grayscale grayscaling = new AForge.Imaging.Filters.Grayscale(
                        0.2125, 0.7154, 0.0721);
            image = grayscaling.Apply(image);

            //mirror the image
            AForge.Imaging.Filters.Mirror mirrImg = new AForge.Imaging.Filters.Mirror(false, true);
            mirrImg.ApplyInPlace(image);

            //get biggest blob
            AForge.Imaging.BlobCounter blobCounter = new AForge.Imaging.BlobCounter(image);
            blobCounter.ProcessImage(image);

            Rectangle[] rectsInImage = blobCounter.GetObjectsRectangles();
            this.txtBoxInfo.Text = rectsInImage.Length + " blobs found.";

            AForge.Imaging.Filters.ExtractBiggestBlob biggestBlob = new AForge.Imaging.Filters.ExtractBiggestBlob();
            Bitmap bigstBlobImage = biggestBlob.Apply(image);
            IntPoint posBiggBlob = biggestBlob.BlobPosition;
            this.txtBoxInfo.Text = "Biggest Blob at: " + posBiggBlob.ToString();

            //SetCursor(posBiggBlob);

            GenerateGraphics(posBiggBlob);

            return image;
        }

        private void SetCursor(IntPoint posBiggBlob)
        {
            //
        }

        private void GenerateGraphics(IntPoint posOfBlob)
        {
            System.Drawing.Graphics g2;
            g2 = Graphics.FromImage(paperBMP);
            SolidBrush brush2 = new SolidBrush(currBrushColor);
            g2.FillEllipse(brush2, Convert.ToSingle(posOfBlob.X), Convert.ToSingle(posOfBlob.Y),
                Convert.ToSingle(this.iWidthOfBrush), Convert.ToSingle(this.iHeightOfBrush));

            histposOfBlob = posOfBlob;
            g2.Dispose();

            //now invalidate only the region we are interested in. We invalidate only the 
            //immediate area around the blob to reduce flickering.
            Rectangle rc = new Rectangle(posOfBlob.X, posOfBlob.Y, 
                iFlickerGuardBand, iFlickerGuardBand);
            //ask parent form to redraw our small region
            this.pnlPaper.SuspendLayout();            
            this.Invalidate(rc,true);            
            this.pnlPaper.ResumeLayout();

            CommandMairduino();
           
        }

        private void CloseVideoSource()
        {
            videoPlayer.SignalToStop();

            if (videoPlayer.IsRunning)
            {
                videoPlayer.WaitForStop();
                Thread.Sleep(150);
                videoPlayer.Stop();

                this.txtBoxInfo.Text = "You can exit Splash now.";
            }

                //if (motionDetector != null)
                //    motionDetector.Reset();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMairduinoComms();
            CloseVideoSource();
        }

        private void startDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bStartDrawing = true;
            this.stopDrawingToolStripMenuItem.Enabled = true;
            this.startDrawingToolStripMenuItem.Enabled = false;
        }

        private void stopDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bStartDrawing = false;
            this.startDrawingToolStripMenuItem.Enabled = true;
            this.stopDrawingToolStripMenuItem.Enabled = false;
        }

        private void chkBoxMairduino_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlPaper.Focus();

            if (this.chkBoxMairduino.Checked)
            {
                //start communications with the Mairduino!            
                try
                {
                    MairduinoCommPort = new SerialPort(strMairduinoPort, 9600, Parity.None, 8, StopBits.One);
                    MairduinoCommPort.Open();
                    txtBoxInfo.Text = "Mairduino comm port open. Ready to send commands...";

                    SendHandshakeToMairduino();
                }
                catch (Exception ex)
                {
                    txtBoxInfo.Text = "ERROR! " + ex.Message + ex.StackTrace;
                }
            }
            else
            {
                //stop Mairduino Comm
                CloseMairduinoComms();
            }
        }

        private void SendHandshakeToMairduino()
        {
            try
            {
                if (this.MairduinoCommPort != null)
                {
                    if (this.MairduinoCommPort.IsOpen)
                    {
                        //send the current color code to it
                        this.MairduinoCommPort.Write("h");
                    }
                }
            }
            catch (Exception ex)
            {
                txtBoxInfo.Text = "ERROR! " + ex.Message + ex.StackTrace;
            }
        }
        private void CloseMairduinoComms()
        {
            try
            {
                if (MairduinoCommPort != null)
                {
                    if (MairduinoCommPort.IsOpen)
                    {
                        MairduinoCommPort.Write("u");
                        Thread.Sleep(50);
                        MairduinoCommPort.DiscardInBuffer();
                        MairduinoCommPort.DiscardOutBuffer();
                        MairduinoCommPort.Close();

                        txtBoxInfo.Text = "Mairduino comms closed.";
                        this.chkBoxMairduino.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                txtBoxInfo.Text = "ERROR! " + ex.Message + ex.StackTrace;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the options dialog box
            try
            {
                FrmOptions Optionsform = new FrmOptions();
                if (DialogResult.OK == Optionsform.ShowDialog(this))
                {
                    //get Mairduino's serial port if available
                    if (Optionsform.strMairduinoPortName.Length > 0)
                    {
                        this.strMairduinoPort = Optionsform.strMairduinoPortName;
                        txtBoxInfo.Text = "Mairduino available on port: " + strMairduinoPort;

                    }
                }
            }
            catch (Exception ex)
            {
                txtBoxInfo.Text = "ERROR! " + ex.Message + ex.StackTrace;
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //show help
            FrmHelp help = new FrmHelp();

            help.Show(this);
        }

        private void CommandMairduino()
        {
            try
            {
                if (this.MairduinoCommPort != null)
                {
                    if (this.MairduinoCommPort.IsOpen)
                    {
                        //send the current color code to it
                        this.MairduinoCommPort.Write(this.currColorCode);
                    }
                }
            }
            catch (Exception ex)
            {
                txtBoxInfo.Text = "ERROR! " + ex.Message + ex.StackTrace;
            }
        }

    }
}
