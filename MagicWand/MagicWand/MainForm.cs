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

using WMPLib;

namespace MagicWand
{

    public partial class MainForm : Form
    {
        VideoSourcePlayer videoPlayer = null;
        MotionDetector motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(),
            new MotionAreaHighlighting());

        private bool bIsMotionDetectionOn = false;
        private bool bIsColorFilteringOn = false;
        private bool bIsBlobCountingOn = false;
        private bool bOpsStopped = true;
        private AForge.Imaging.Filters.HSLFiltering userhslFilter = new AForge.Imaging.Filters.HSLFiltering();
        //private AForge.Imaging.Filters.BlobsFiltering bf = null;

        private Color selectedColor = Color.Empty;

        private System.DateTime dtOfAction;

        private List<CPanelAttributes> listGridPanels = new List<CPanelAttributes>();

        private List<string> listBlobOwnerHistory = new List<string>(iBlobOwnerDeciderCount+50);
        static int iBlobOwnerDeciderCount = 30;

        public MainForm()
        {
            InitializeComponent();
            
            /*
            bf = new AForge.Imaging.Filters.BlobsFiltering();
            bf.CoupledSizeFiltering = true;
            bf.MinHeight = 70;
            bf.MinWidth = 70;
             * */

            this.pnlMagicCursor.Parent = this;

            SetZOrdersofAllControls();

            LoadGrid();
            
            listBlobOwnerHistory.Capacity = iBlobOwnerDeciderCount;
        }

        private void LoadGrid()
        {
            //we have 7 panels in the grid. load them one by one
            CPanelAttributes p1 = new CPanelAttributes(this.pnlOne, this.pnlOne.Name, 1);
            CPanelAttributes p2 = new CPanelAttributes(this.pnlTwo, this.pnlTwo.Name, 2);
            CPanelAttributes p3 = new CPanelAttributes(this.pnlThree, this.pnlThree.Name, 3);
            CPanelAttributes p4 = new CPanelAttributes(this.pnlFour, this.pnlFour.Name, 4);
            CPanelAttributes p5 = new CPanelAttributes(this.pnlFive, this.pnlFive.Name, 5);
            CPanelAttributes p6 = new CPanelAttributes(this.pnlSix, this.pnlSix.Name, 6);
            CPanelAttributes p7 = new CPanelAttributes(this.pnlSeven, this.pnlSeven.Name, 7);

            //calculate center points, critical to sense proper intersect of the magic wand
            //and the grid panels
            p1.panelCenter.X = pnlOne.Size.Width / 2;
            p1.panelCenter.Y = pnlOne.Size.Height / 2;

            p2.panelCenter.X = (pnlOne.Size.Width + pnlTwo.Size.Width / 2);
            p2.panelCenter.Y = pnlTwo.Size.Height / 2;

            p3.panelCenter.X = (pnlOne.Size.Width + pnlTwo.Size.Width + pnlThree.Size.Width / 2);
            p3.panelCenter.Y = pnlThree.Size.Height / 2;

            p4.panelCenter.X = pnlFour.Size.Width / 2;
            p4.panelCenter.Y = pnlOne.Size.Height + pnlFour.Size.Height / 2;

            p5.panelCenter.X = (pnlFour.Size.Width + pnlFive.Size.Width / 2);
            p5.panelCenter.Y = pnlTwo.Size.Height + pnlFive.Size.Height / 2;

            p6.panelCenter.X = (pnlFour.Size.Width + pnlFive.Size.Width + pnlSix.Size.Width / 2);
            p6.panelCenter.Y = pnlThree.Size.Height + pnlSix.Size.Height / 2;

            p7.panelCenter.X = pnlSeven.Size.Width / 2;
            //not divved by 2 since the magic wand coordinates start from main form 0,0!
            p7.panelCenter.Y = pnlTwo.Size.Height + pnlFive.Size.Height + pnlSeven.Size.Height;

            //populate data structure
            listGridPanels.Add(p1);
            listGridPanels.Add(p2); listGridPanels.Add(p3);
            listGridPanels.Add(p4); listGridPanels.Add(p5); listGridPanels.Add(p6);
            listGridPanels.Add(p7);
        }

        private void SetZOrdersofAllControls()
        {            
            //magic cursor topmost
            this.pnlMagicCursor.BringToFront();

            //video stream at the end (backmost)
            this.panel1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVideoSrcSelect webcamSelector = new FrmVideoSrcSelect();

            if (webcamSelector.ShowDialog(this) == DialogResult.OK)
            {
                bOpsStopped = false;
                //set the source
                //VideoCaptureDevice videoSource = new VideoCaptureDevice("@device:pnp:\\\\?\\usb#vid_0c45&pid_6270#5&2e042cf2&0&2#{65e8773d-8f56-11d0-a3b9-00a0c9223196}\\global");
                VideoCaptureDevice videoSource = new VideoCaptureDevice(webcamSelector.device);
                
                this.videoPlayer.AutoSizeControl = true;
                
                videoPlayer.VideoSource = (IVideoSource)videoSource;
                videoPlayer.Start();

                this.button2.Enabled = true;

                this.lblInfotext.Text = "Webcam selected. Rendering video stream...";

                this.pnlMagicCursor.Enabled = true;
                this.pnlMagicCursor.Visible = true;

                this.pnlOne.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                this.pnlTwo.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                this.pnlThree.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                this.pnlFour.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                this.pnlFive.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                this.pnlSix.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                this.pnlSeven.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            }
        }

        
        void videoPlayer_NewFrame(object sender, ref System.Drawing.Bitmap image)
        {
            //do something, we got a new frame from the video source.
            lock (this)
            {
                if (bIsMotionDetectionOn)
                {
                    if (motionDetector != null)
                    {
                        float motionLevel = motionDetector.ProcessFrame(image);
                    }
                }

                if (bIsColorFilteringOn)
                {
                    //try filtering for a color
                                        
                    AForge.Imaging.Filters.HSLFiltering hslFilter = new AForge.Imaging.Filters.HSLFiltering();
                    
                    // set color ranges to keep
                    if (this.userhslFilter != null)
                    {
                        //hslFilter = this.userhslFilter;
                        
                        // apply the filter
                        //hslFilter.ApplyInPlace(image);


                        
                        hslFilter.Hue = new IntRange(335, 0);//335,0 = nice saturated red
                        //hslFilter.Hue = new IntRange(45, 65);//yellow
                        //hslFilter.Hue = new IntRange(170, 190);//light blue
                        //hslFilter.Saturation = new DoubleRange(0.5, 1);
                        hslFilter.Saturation = new DoubleRange(0.5, 1).ToIntRange(false);
                        //hslFilter.Luminance = new DoubleRange(0.1, 1);
                        hslFilter.Luminance = new DoubleRange(0.1, 1).ToIntRange(false) ;
                        hslFilter.ApplyInPlace(image);

                        /*
                        hslFilter.Hue.Max = Convert.ToInt32(selectedColor.GetHue());
                        hslFilter.Hue.Min = Convert.ToInt32(selectedColor.GetHue());
                        hslFilter.Luminance.Max = Convert.ToDouble(selectedColor.GetBrightness());
                        hslFilter.Luminance.Min = 0.01;
                        hslFilter.Saturation.Max = Convert.ToDouble(selectedColor.GetSaturation());
                        hslFilter.Saturation.Min = 0.01;
                        */
                                                
                        
                        /*
                        AForge.Imaging.Filters.ColorFiltering colorFiltering = new AForge.Imaging.Filters.ColorFiltering();
                        colorFiltering.Red = new IntRange(150,255);
                        colorFiltering.Green = new IntRange(0, 70);
                        colorFiltering.Blue = new IntRange(0, 70);
                        colorFiltering.ApplyInPlace(image);
                        */
                        /*
                        AForge.Imaging.Filters.EuclideanColorFiltering euclidClrFltr = new AForge.Imaging.Filters.EuclideanColorFiltering();
                        //euclidClrFltr.CenterColor = Color.FromArgb(200, 0, 0);
                        euclidClrFltr.CenterColor = Color.Empty;
                        euclidClrFltr.CenterColor = Color.FromName(selectedColor.Name);
                        euclidClrFltr.Radius = 100;
                        euclidClrFltr.ApplyInPlace(image);
                         * */
                    }
                                        
                }

                if (this.bIsBlobCountingOn)
                {
                    //grayscale the filtered image.
                    AForge.Imaging.Filters.Grayscale grayscaling = new AForge.Imaging.Filters.Grayscale(
                        0.2125, 0.7154, 0.0721);
                    image = grayscaling.Apply(image);

                    //blob detection
                    ProcessBlobs(image);
                }
            }
        }

        private void ProcessBlobs(Bitmap image)
        {
            //erode unwanted pixels. Note - erosion is time consuming
            //AForge.Imaging.Filters.Erosion3x3 erode = new AForge.Imaging.Filters.Erosion3x3();
            //erode.ApplyInPlace(image);

            AForge.Imaging.BlobCounter blobCounter = new AForge.Imaging.BlobCounter(image);
            blobCounter.ProcessImage(image);
            
            Rectangle[] rectsInImage = blobCounter.GetObjectsRectangles();
            this.lblInfotext.Text = rectsInImage.Length + " blobs found.";
            
            /*
            foreach (Rectangle rect in rectsInImage)
            {
                //Use this piece of code to filter out blobs based on size. Very heavy 
                //piece of code! Use caution!
                bf.ApplyInPlace(image);
            }
             * */
            
            //get the biggest blob
            AForge.Imaging.Filters.ExtractBiggestBlob biggestBlob = new AForge.Imaging.Filters.ExtractBiggestBlob();
            Bitmap bigstBlobImage = biggestBlob.Apply(image);
            IntPoint posBiggBlob = biggestBlob.BlobPosition;

            this.lblInfotext.Text += "  Biggest blob's coordinates: " + posBiggBlob.ToString();

            //pnlMagicCursor.Location = new Point(posBiggBlob.X, posBiggBlob.Y);
            pnlMagicCursor.Location = new System.Drawing.Point(posBiggBlob.X, posBiggBlob.Y);

            GetBlobsPanel(posBiggBlob);
        }
        
        private void GetBlobsPanel(IntPoint posOfBlob)
        {
            //iterate thru each grid panel to find which one is the blob occupying
            string strPanelName = GetGridBlobIntersect(posOfBlob);
            //MessageBox.Show("gbi: " + strPanelName);

            //tbd - remove this
            PerformAction(strPanelName);
            //
            
            if (strPanelName != null)
            {
                listBlobOwnerHistory.Add(strPanelName);
                int iCount = 0;
                if (listBlobOwnerHistory.Count > iBlobOwnerDeciderCount)
                {
                    //match with history. past iBlobOwnerDeciderCount panels should be the same
                    //to qualify a panel action trigger
                    foreach (string strTmp in listBlobOwnerHistory)
                    {
                        if (strTmp == strPanelName)
                        {
                            iCount++;
                            //if (iCount == iBlobOwnerDeciderCount) 
                            //    break;
                        }
                        else
                            break;
                    }

                }

                if (listBlobOwnerHistory.Count == iBlobOwnerDeciderCount + 20)
                    listBlobOwnerHistory.Clear();

                if (iCount == iBlobOwnerDeciderCount)
                {
                    //time to perform an action for this panel
                    PerformAction(strPanelName);
                }
            }
    
        }

        private string GetGridBlobIntersect(IntPoint posOfBlob)
        {
            //MessageBox.Show("GetGridBlobIntersect: " + posOfBlob.ToString());
            string strPanel = "";

            foreach (CPanelAttributes cp in listGridPanels)
            {
                if (cp.IsBlobOnMe(posOfBlob))
                    return cp.strpanelName;
            }

            return strPanel;
        }

        private void PerformAction(string strPanelName)
        {
            //first get the correct CPanelAttributes object
            CPanelAttributes obj = FindPanelObjectInList(strPanelName);
            obj.PerformMyAction();

            /*
            //call its action
            if (obj != null)
            {
                //get the system time.
                if (dtOfAction == null)
                {
                    dtOfAction = new DateTime();
                    dtOfAction = DateTime.Now;
                    obj.PerformMyAction();
                }
                else
                {
                    DateTime dtTmp = DateTime.Now;
                    if(10 == dtTmp.Subtract(dtOfAction).Seconds)
                    {
                        //ten secs elapsed since last action was in effect. allow
                        //newer actions now.
                        obj.PerformMyAction();
                        dtOfAction = DateTime.Now;
                    }
                    
                }
            }
             * */
        }

        private CPanelAttributes FindPanelObjectInList(string strPanelName)
        {
            foreach (CPanelAttributes p in this.listGridPanels)
            {
                if (p.strpanelName == strPanelName)
                    return p;
            }

            return null;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CloseVideoSource();
        }

        private void CloseVideoSource()
        {
            if (!bOpsStopped)
            {
                videoPlayer.SignalToStop();

                if (videoPlayer.IsRunning)
                {
                    videoPlayer.WaitForStop();
                    Thread.Sleep(150);
                    videoPlayer.Stop();
                }

                if (motionDetector != null)
                    motionDetector.Reset();

                bOpsStopped = true;

                this.lblInfotext.Text.ToUpper();
                this.lblInfotext.Text = "You can safely exit the App now.";
                this.lblInfotext.Text.ToLower();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bOpsStopped)
                MessageBox.Show("Please click 'Stop' before exiting...");
        }

        private void checkBoxMtnDet_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxMtnDet.Checked)
                this.bIsMotionDetectionOn = true;
            else
                this.bIsMotionDetectionOn = false;
        }

        private void checkBoxClrFltr_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxClrFltr.Checked)
            {
                this.bIsColorFilteringOn = true;
                                
                //get what color is to be detected. Rest will be blacked out
                FrmFilteredColorSelect colorSelector = new FrmFilteredColorSelect();
                if (DialogResult.OK == colorSelector.ShowDialog(this))
                {
                    StoreSelectedColor(colorSelector.selectedColor);
                }
                
            }
            else
                this.bIsColorFilteringOn = false;
        }

        private void StoreSelectedColor(Color c)
        {
            //this.userhslFilter.Saturation = new DoubleRange(0.5, 1);
            //this.userhslFilter.Luminance = new DoubleRange(0.1, 1);
            this.userhslFilter.Saturation = new DoubleRange(0.5, 1).ToIntRange(false);
            this.userhslFilter.Luminance = new DoubleRange(0.1, 1).ToIntRange(false);

            if (c == Color.Red)
            {
                this.userhslFilter.Hue = new IntRange(335, 0); return;
            }

            if (c == Color.Green)
            {
                this.userhslFilter.Hue = new IntRange(110, 130); return;
            }

            if (c == Color.Yellow)
            {
                this.userhslFilter.Hue = new IntRange(50,65); return;
            }
        }

        private void chkBoxBlodCnt_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBoxBlodCnt.Checked)
                this.bIsBlobCountingOn = true;
            else
                this.bIsBlobCountingOn = false;
        }

        private void cmbBoxMotionDetAlgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented yet!");

            //SimpleBackgroundModelingDetector s = new SimpleBackgroundModelingDetector(true);
            //motionDetector.MotionProcessingAlgorithm = s as IMotionProcessing;
        }

        private void chkBoxShowVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBoxShowVideo.Checked)
                ShowVideo(false);
            else
                ShowVideo(true);

        }


        private void lblAbout_Click(object sender, System.EventArgs e)
        {
            FrmAbout fabt = new FrmAbout();
            fabt.ShowDialog();
        }

        private void ShowVideo(bool p)
        {
            ToggleGridPanels(p);            
        }

        private void ToggleGridPanels(bool b)
        {
            foreach (CPanelAttributes p in this.listGridPanels)
                p.ToggleMe(b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //app options
            FrmAppOptions OptionsForm = new FrmAppOptions();
            if (OptionsForm.ShowDialog(this) == DialogResult.OK)
                UpdateGridPanel(OptionsForm);
        }

        private void UpdateGridPanel(FrmAppOptions options)
        {
            //find the panel in the data structure
            int iPanelIndex = FindPanelIndexInGrid(options.iPanelNumber);

            if (iPanelIndex >= 0)
            {
                //update panel image
                Bitmap bmp = new Bitmap(options.strPanelDisplayImagePath);
                Image.GetThumbnailImageAbort myCBK = new Image.GetThumbnailImageAbort(thumCbk);
                Image img = bmp.GetThumbnailImage(180, 180, myCBK, IntPtr.Zero);
                this.listGridPanels[iPanelIndex].thePanel.BackgroundImage = img as Bitmap;

                //attach action (file to play)
                this.listGridPanels[iPanelIndex].strAssociatedAction = options.strFilePath;
            }
        }

        public bool thumCbk()
        {
            return false;
        }


        private int FindPanelIndexInGrid(int p)
        {
            int iRet = -1;

            foreach (CPanelAttributes cpa in listGridPanels)
            {
                iRet++;
                if (cpa.iNumInUI == p)
                    return iRet;
            }

            return iRet;
        }

        private void splashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            //Load the Splash application overlay. set panels to white to mimic a
            //drawing board.
            foreach (CPanelAttributes cpa in listGridPanels)
            {
                cpa.thePanel.SendToBack();
                cpa.thePanel.Visible = false;
                cpa.thePanel.Enabled = false;
            }

            this.pnlDraw.Enabled = true;
            this.pnlDraw.Visible = true;
            this.pnlDraw.BringToFront();
            this.panel1.SendToBack(); this.panel1.Visible = false;

            System.Drawing.Graphics g;
            g = this.pnlDraw.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 7);
            Point pt1 = new Point();
            pt1.X = 30;// this.pnlMagicCursor.Location.X;
            pt1.Y = 10;// this.pnlMagicCursor.Location.Y;
            Point pt2 = new Point();
            pt2.X = 200;// pt1.X + 5;
            pt2.Y = 10;// pt1.Y + 5;
            g.DrawLine(myPen, pt1, pt2);
             * */
        }
    }

    public class CPanelActions
    {
        CPanelActions() { }

        public string strFilePath;
        public int iPanelNumber;

    }

    public class CPanelAttributes
    {
        public CPanelAttributes() { }
        public CPanelAttributes(Panel p, string name, int iNumInUI) {
            this.strpanelName = name;
            this.thePanel = p;
            this.iNumInUI = iNumInUI;
        }

        public IntPoint panelCenter;
        public string strpanelName;
        public string strAssociatedAction;
        public Panel thePanel;
        public int iNumInUI;
        static public WMPLib.WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();

        //public CPanelActions myAction;

        public void PerformMyAction()
        {
            if (this.strAssociatedAction == null)
            {
                if (this.thePanel.BackColor.ToKnownColor() == KnownColor.ButtonFace)
                    this.thePanel.BackColor = Color.DarkCyan;
                else
                    this.thePanel.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            }
            else
            {
               //play the attached file
                if (mediaPlayer != null)
                {
                    if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
                        mediaPlayer.controls.stop();
                    mediaPlayer.URL = this.strAssociatedAction;
                    mediaPlayer.controls.play();
                }
            }
        }

        public void ToggleMe(bool b)
        {
            this.thePanel.Visible = b;
            this.thePanel.Enabled = b;
        }

        public bool IsBlobOnMe(IntPoint posOfBlob)
        {
            bool bRet = false;

            if (posOfBlob.DistanceTo(this.panelCenter) <= 40)
            {
                //MessageBox.Show("IsBlobOnMe, posOfBlob.DistanceTo: " + (posOfBlob.DistanceTo(this.panelCenter)).ToString());
                bRet = true;
            }

            return bRet;
        }
    }
}
