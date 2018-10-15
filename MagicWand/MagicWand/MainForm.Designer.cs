
//
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;

namespace MagicWand
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.videoPlayer = new AForge.Controls.VideoSourcePlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSeven = new System.Windows.Forms.Panel();
            this.pnlSix = new System.Windows.Forms.Panel();
            this.pnlFive = new System.Windows.Forms.Panel();
            this.pnlFour = new System.Windows.Forms.Panel();
            this.pnlThree = new System.Windows.Forms.Panel();
            this.pnlMagicCursor = new System.Windows.Forms.Panel();
            this.pnlOne = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxMotionDetAlgo = new System.Windows.Forms.ComboBox();
            this.chkBoxBlodCnt = new System.Windows.Forms.CheckBox();
            this.checkBoxClrFltr = new System.Windows.Forms.CheckBox();
            this.checkBoxMtnDet = new System.Windows.Forms.CheckBox();
            this.lblInfotext = new System.Windows.Forms.Label();
            this.pnlTwo = new System.Windows.Forms.Panel();
            this.chkBoxShowVideo = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicWandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Webcam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(39, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // videoPlayer
            // 
            this.videoPlayer.Location = new System.Drawing.Point(0, 0);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(0, 0);
            this.videoPlayer.TabIndex = 2;
            this.videoPlayer.VideoSource = null;
            this.videoPlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoPlayer_NewFrame);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.pnlSeven);
            this.panel1.Controls.Add(this.pnlSix);
            this.panel1.Controls.Add(this.pnlFive);
            this.panel1.Controls.Add(this.pnlFour);
            this.panel1.Controls.Add(this.pnlThree);
            this.panel1.Controls.Add(this.pnlMagicCursor);
            this.panel1.Controls.Add(this.pnlOne);
            this.panel1.Controls.Add(this.videoPlayer);
            this.panel1.Location = new System.Drawing.Point(36, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 515);
            this.panel1.TabIndex = 3;
            // 
            // pnlSeven
            // 
            this.pnlSeven.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSeven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeven.Location = new System.Drawing.Point(2, 390);
            this.pnlSeven.Name = "pnlSeven";
            this.pnlSeven.Size = new System.Drawing.Size(644, 125);
            this.pnlSeven.TabIndex = 13;
            // 
            // pnlSix
            // 
            this.pnlSix.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlSix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSix.Location = new System.Drawing.Point(431, 196);
            this.pnlSix.Name = "pnlSix";
            this.pnlSix.Size = new System.Drawing.Size(215, 194);
            this.pnlSix.TabIndex = 12;
            // 
            // pnlFive
            // 
            this.pnlFive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFive.Location = new System.Drawing.Point(216, 196);
            this.pnlFive.Name = "pnlFive";
            this.pnlFive.Size = new System.Drawing.Size(215, 194);
            this.pnlFive.TabIndex = 11;
            // 
            // pnlFour
            // 
            this.pnlFour.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFour.Location = new System.Drawing.Point(1, 196);
            this.pnlFour.Name = "pnlFour";
            this.pnlFour.Size = new System.Drawing.Size(215, 194);
            this.pnlFour.TabIndex = 10;
            // 
            // pnlThree
            // 
            this.pnlThree.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThree.Location = new System.Drawing.Point(431, 2);
            this.pnlThree.Name = "pnlThree";
            this.pnlThree.Size = new System.Drawing.Size(215, 194);
            this.pnlThree.TabIndex = 9;
            // 
            // pnlMagicCursor
            // 
            this.pnlMagicCursor.BackColor = System.Drawing.Color.Transparent;
            this.pnlMagicCursor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMagicCursor.BackgroundImage")));
            this.pnlMagicCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMagicCursor.Enabled = false;
            this.pnlMagicCursor.Location = new System.Drawing.Point(613, 468);
            this.pnlMagicCursor.Name = "pnlMagicCursor";
            this.pnlMagicCursor.Size = new System.Drawing.Size(35, 42);
            this.pnlMagicCursor.TabIndex = 7;
            this.pnlMagicCursor.Visible = false;
            // 
            // pnlOne
            // 
            this.pnlOne.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOne.Location = new System.Drawing.Point(1, 2);
            this.pnlOne.Name = "pnlOne";
            this.pnlOne.Size = new System.Drawing.Size(215, 194);
            this.pnlOne.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbBoxMotionDetAlgo);
            this.groupBox2.Controls.Add(this.chkBoxBlodCnt);
            this.groupBox2.Controls.Add(this.checkBoxClrFltr);
            this.groupBox2.Controls.Add(this.checkBoxMtnDet);
            this.groupBox2.Location = new System.Drawing.Point(154, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Vision Processing Feature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Motion Det. Algorithm:";
            // 
            // cmbBoxMotionDetAlgo
            // 
            this.cmbBoxMotionDetAlgo.FormattingEnabled = true;
            this.cmbBoxMotionDetAlgo.Items.AddRange(new object[] {
            "Two Frames Difference Detector (default)",
            "Simple Background Modeling Detector",
            "Custom Frame Difference Detector"});
            this.cmbBoxMotionDetAlgo.Location = new System.Drawing.Point(121, 42);
            this.cmbBoxMotionDetAlgo.Name = "cmbBoxMotionDetAlgo";
            this.cmbBoxMotionDetAlgo.Size = new System.Drawing.Size(228, 21);
            this.cmbBoxMotionDetAlgo.TabIndex = 7;
            this.cmbBoxMotionDetAlgo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMotionDetAlgo_SelectedIndexChanged);
            // 
            // chkBoxBlodCnt
            // 
            this.chkBoxBlodCnt.AutoSize = true;
            this.chkBoxBlodCnt.Location = new System.Drawing.Point(218, 18);
            this.chkBoxBlodCnt.Name = "chkBoxBlodCnt";
            this.chkBoxBlodCnt.Size = new System.Drawing.Size(91, 17);
            this.chkBoxBlodCnt.TabIndex = 6;
            this.chkBoxBlodCnt.Text = "Blob counting";
            this.chkBoxBlodCnt.UseVisualStyleBackColor = true;
            this.chkBoxBlodCnt.CheckedChanged += new System.EventHandler(this.chkBoxBlodCnt_CheckedChanged);
            // 
            // checkBoxClrFltr
            // 
            this.checkBoxClrFltr.AutoSize = true;
            this.checkBoxClrFltr.Location = new System.Drawing.Point(121, 18);
            this.checkBoxClrFltr.Name = "checkBoxClrFltr";
            this.checkBoxClrFltr.Size = new System.Drawing.Size(89, 17);
            this.checkBoxClrFltr.TabIndex = 1;
            this.checkBoxClrFltr.Tag = "";
            this.checkBoxClrFltr.Text = "Color Filtering";
            this.checkBoxClrFltr.UseVisualStyleBackColor = true;
            this.checkBoxClrFltr.CheckedChanged += new System.EventHandler(this.checkBoxClrFltr_CheckedChanged);
            // 
            // checkBoxMtnDet
            // 
            this.checkBoxMtnDet.AutoSize = true;
            this.checkBoxMtnDet.Location = new System.Drawing.Point(10, 19);
            this.checkBoxMtnDet.Name = "checkBoxMtnDet";
            this.checkBoxMtnDet.Size = new System.Drawing.Size(107, 17);
            this.checkBoxMtnDet.TabIndex = 0;
            this.checkBoxMtnDet.Text = "Motion Detection";
            this.checkBoxMtnDet.UseVisualStyleBackColor = true;
            this.checkBoxMtnDet.CheckedChanged += new System.EventHandler(this.checkBoxMtnDet_CheckedChanged);
            // 
            // lblInfotext
            // 
            this.lblInfotext.AutoSize = true;
            this.lblInfotext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblInfotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfotext.Location = new System.Drawing.Point(36, 643);
            this.lblInfotext.Name = "lblInfotext";
            this.lblInfotext.Size = new System.Drawing.Size(197, 16);
            this.lblInfotext.TabIndex = 6;
            this.lblInfotext.Text = "Look for informational text here...";
            // 
            // pnlTwo
            // 
            this.pnlTwo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTwo.Location = new System.Drawing.Point(252, 124);
            this.pnlTwo.Name = "pnlTwo";
            this.pnlTwo.Size = new System.Drawing.Size(215, 194);
            this.pnlTwo.TabIndex = 8;
            // 
            // chkBoxShowVideo
            // 
            this.chkBoxShowVideo.AutoSize = true;
            this.chkBoxShowVideo.Location = new System.Drawing.Point(518, 60);
            this.chkBoxShowVideo.Name = "chkBoxShowVideo";
            this.chkBoxShowVideo.Size = new System.Drawing.Size(83, 17);
            this.chkBoxShowVideo.TabIndex = 9;
            this.chkBoxShowVideo.Text = "Show Video";
            this.chkBoxShowVideo.UseVisualStyleBackColor = true;
            this.chkBoxShowVideo.CheckedChanged += new System.EventHandler(this.chkBoxShowVideo_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "App Options";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(682, 24);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(35, 13);
            this.lblAbout.TabIndex = 11;
            this.lblAbout.Text = "About";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicControlsToolStripMenuItem,
            this.applicationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicControlsToolStripMenuItem
            // 
            this.basicControlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWebCamToolStripMenuItem,
            this.stopWebCamToolStripMenuItem});
            this.basicControlsToolStripMenuItem.Name = "basicControlsToolStripMenuItem";
            this.basicControlsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.basicControlsToolStripMenuItem.Text = "Basic Controls";
            // 
            // startWebCamToolStripMenuItem
            // 
            this.startWebCamToolStripMenuItem.Name = "startWebCamToolStripMenuItem";
            this.startWebCamToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.startWebCamToolStripMenuItem.Text = "Start WebCam";
            // 
            // stopWebCamToolStripMenuItem
            // 
            this.stopWebCamToolStripMenuItem.Name = "stopWebCamToolStripMenuItem";
            this.stopWebCamToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.stopWebCamToolStripMenuItem.Text = "Stop WebCam";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magicWandToolStripMenuItem,
            this.splashToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // magicWandToolStripMenuItem
            // 
            this.magicWandToolStripMenuItem.Name = "magicWandToolStripMenuItem";
            this.magicWandToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.magicWandToolStripMenuItem.Text = "Magic Wand";
            // 
            // splashToolStripMenuItem
            // 
            this.splashToolStripMenuItem.Name = "splashToolStripMenuItem";
            this.splashToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.splashToolStripMenuItem.Text = "Splash";
            this.splashToolStripMenuItem.Click += new System.EventHandler(this.splashToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(717, 672);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chkBoxShowVideo);
            this.Controls.Add(this.pnlTwo);
            this.Controls.Add(this.lblInfotext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Magic Wand for Som";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxClrFltr;
        private System.Windows.Forms.CheckBox checkBoxMtnDet;
        private System.Windows.Forms.CheckBox chkBoxBlodCnt;
        private System.Windows.Forms.Label lblInfotext;
        private System.Windows.Forms.Panel pnlOne;
        private System.Windows.Forms.Panel pnlMagicCursor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxMotionDetAlgo;
        private System.Windows.Forms.Panel pnlTwo;
        private System.Windows.Forms.Panel pnlThree;
        private System.Windows.Forms.Panel pnlFour;
        private System.Windows.Forms.Panel pnlSeven;
        private System.Windows.Forms.Panel pnlSix;
        private System.Windows.Forms.Panel pnlFive;
        private System.Windows.Forms.CheckBox chkBoxShowVideo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magicWandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

