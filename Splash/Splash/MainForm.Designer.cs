namespace Splash
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.videoPlayer = new AForge.Controls.VideoSourcePlayer();
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.txtBoxInfo = new System.Windows.Forms.TextBox();
            this.pnlRedColor = new System.Windows.Forms.Panel();
            this.pnlGreenColor = new System.Windows.Forms.Panel();
            this.pnlBlueColor = new System.Windows.Forms.Panel();
            this.chkBoxMairduino = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.pnlDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem,
            this.drawToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.controlsToolStripMenuItem.Text = "Basic Controls";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.startToolStripMenuItem.Text = "Start!";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Stop";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startDrawingToolStripMenuItem,
            this.stopDrawingToolStripMenuItem});
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.drawToolStripMenuItem.Text = "Draw";
            // 
            // startDrawingToolStripMenuItem
            // 
            this.startDrawingToolStripMenuItem.Enabled = false;
            this.startDrawingToolStripMenuItem.Name = "startDrawingToolStripMenuItem";
            this.startDrawingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.startDrawingToolStripMenuItem.Text = "Start Drawing!";
            this.startDrawingToolStripMenuItem.Click += new System.EventHandler(this.startDrawingToolStripMenuItem_Click);
            // 
            // stopDrawingToolStripMenuItem
            // 
            this.stopDrawingToolStripMenuItem.Enabled = false;
            this.stopDrawingToolStripMenuItem.Name = "stopDrawingToolStripMenuItem";
            this.stopDrawingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.stopDrawingToolStripMenuItem.Text = "Stop Drawing";
            this.stopDrawingToolStripMenuItem.Click += new System.EventHandler(this.stopDrawingToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.Info;
            this.pnlDraw.Controls.Add(this.videoPlayer);
            this.pnlDraw.Location = new System.Drawing.Point(0, 24);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(700, 530);
            this.pnlDraw.TabIndex = 1;
            // 
            // videoPlayer
            // 
            this.videoPlayer.Location = new System.Drawing.Point(0, 0);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(0, 0);
            this.videoPlayer.TabIndex = 0;
            this.videoPlayer.VideoSource = null;
            this.videoPlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoPlayer_NewFrame);
            // 
            // pnlPaper
            // 
            this.pnlPaper.BackColor = System.Drawing.Color.White;
            this.pnlPaper.Location = new System.Drawing.Point(0, 24);
            this.pnlPaper.Name = "pnlPaper";
            this.pnlPaper.Size = new System.Drawing.Size(700, 530);
            this.pnlPaper.TabIndex = 1;
            this.pnlPaper.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaper_Paint);
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBoxInfo.Location = new System.Drawing.Point(4, 564);
            this.txtBoxInfo.Multiline = true;
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.Size = new System.Drawing.Size(696, 37);
            this.txtBoxInfo.TabIndex = 2;
            // 
            // pnlRedColor
            // 
            this.pnlRedColor.BackColor = System.Drawing.Color.DarkRed;
            this.pnlRedColor.Location = new System.Drawing.Point(710, 35);
            this.pnlRedColor.Name = "pnlRedColor";
            this.pnlRedColor.Size = new System.Drawing.Size(51, 45);
            this.pnlRedColor.TabIndex = 3;
            // 
            // pnlGreenColor
            // 
            this.pnlGreenColor.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlGreenColor.Location = new System.Drawing.Point(710, 90);
            this.pnlGreenColor.Name = "pnlGreenColor";
            this.pnlGreenColor.Size = new System.Drawing.Size(51, 45);
            this.pnlGreenColor.TabIndex = 4;
            // 
            // pnlBlueColor
            // 
            this.pnlBlueColor.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlBlueColor.Location = new System.Drawing.Point(710, 147);
            this.pnlBlueColor.Name = "pnlBlueColor";
            this.pnlBlueColor.Size = new System.Drawing.Size(51, 45);
            this.pnlBlueColor.TabIndex = 5;
            // 
            // chkBoxMairduino
            // 
            this.chkBoxMairduino.AutoSize = true;
            this.chkBoxMairduino.Location = new System.Drawing.Point(4, 607);
            this.chkBoxMairduino.Name = "chkBoxMairduino";
            this.chkBoxMairduino.Size = new System.Drawing.Size(493, 17);
            this.chkBoxMairduino.TabIndex = 6;
            this.chkBoxMairduino.Text = "Make My Mairduino Dance! (All LED should turn on for 3 secs to indicate Mairduino" +
                " sensed Splash)";
            this.chkBoxMairduino.UseVisualStyleBackColor = true;
            this.chkBoxMairduino.CheckedChanged += new System.EventHandler(this.chkBoxMairduino_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 655);
            this.Controls.Add(this.chkBoxMairduino);
            this.Controls.Add(this.pnlBlueColor);
            this.Controls.Add(this.pnlGreenColor);
            this.Controls.Add(this.pnlRedColor);
            this.Controls.Add(this.pnlPaper);
            this.Controls.Add(this.txtBoxInfo);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDraw.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Panel pnlPaper;
        private System.Windows.Forms.TextBox txtBoxInfo;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRedColor;
        private System.Windows.Forms.Panel pnlGreenColor;
        private System.Windows.Forms.Panel pnlBlueColor;
        private System.Windows.Forms.CheckBox chkBoxMairduino;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

