namespace MagicWand
{
    partial class FrmPanelOptions
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
            this.btnActFrmOK = new System.Windows.Forms.Button();
            this.radioBtnPlayVideo = new System.Windows.Forms.RadioButton();
            this.radioBtnRunApp = new System.Windows.Forms.RadioButton();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPanelImage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActFrmOK
            // 
            this.btnActFrmOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActFrmOK.Location = new System.Drawing.Point(124, 188);
            this.btnActFrmOK.Name = "btnActFrmOK";
            this.btnActFrmOK.Size = new System.Drawing.Size(75, 23);
            this.btnActFrmOK.TabIndex = 1;
            this.btnActFrmOK.Text = "OK";
            this.btnActFrmOK.UseVisualStyleBackColor = true;
            // 
            // radioBtnPlayVideo
            // 
            this.radioBtnPlayVideo.AutoSize = true;
            this.radioBtnPlayVideo.Location = new System.Drawing.Point(14, 18);
            this.radioBtnPlayVideo.Name = "radioBtnPlayVideo";
            this.radioBtnPlayVideo.Size = new System.Drawing.Size(277, 17);
            this.radioBtnPlayVideo.TabIndex = 0;
            this.radioBtnPlayVideo.TabStop = true;
            this.radioBtnPlayVideo.Text = "Play music or video (Windows Media Player required):";
            this.radioBtnPlayVideo.UseVisualStyleBackColor = true;
            this.radioBtnPlayVideo.CheckedChanged += new System.EventHandler(this.radioBtnPlayVideo_CheckedChanged);
            // 
            // radioBtnRunApp
            // 
            this.radioBtnRunApp.AutoSize = true;
            this.radioBtnRunApp.Location = new System.Drawing.Point(14, 40);
            this.radioBtnRunApp.Name = "radioBtnRunApp";
            this.radioBtnRunApp.Size = new System.Drawing.Size(85, 17);
            this.radioBtnRunApp.TabIndex = 2;
            this.radioBtnRunApp.TabStop = true;
            this.radioBtnRunApp.Text = "Run an App:";
            this.radioBtnRunApp.UseVisualStyleBackColor = true;
            this.radioBtnRunApp.CheckedChanged += new System.EventHandler(this.radioBtnRunApp_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(111, 79);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.radioBtnRunApp);
            this.groupBox1.Controls.Add(this.radioBtnPlayVideo);
            this.groupBox1.Location = new System.Drawing.Point(14, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions setup:";
            // 
            // btnPanelImage
            // 
            this.btnPanelImage.Location = new System.Drawing.Point(14, 27);
            this.btnPanelImage.Name = "btnPanelImage";
            this.btnPanelImage.Size = new System.Drawing.Size(108, 23);
            this.btnPanelImage.TabIndex = 5;
            this.btnPanelImage.Text = "Set Display Image";
            this.btnPanelImage.UseVisualStyleBackColor = true;
            this.btnPanelImage.Click += new System.EventHandler(this.btnPanelImage_Click);
            // 
            // FrmPanelOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 223);
            this.Controls.Add(this.btnPanelImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActFrmOK);
            this.MaximizeBox = false;
            this.Name = "FrmPanelOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Panel Action";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActFrmOK;
        private System.Windows.Forms.RadioButton radioBtnPlayVideo;
        private System.Windows.Forms.RadioButton radioBtnRunApp;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPanelImage;
    }
}