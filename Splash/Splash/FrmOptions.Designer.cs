namespace Splash
{
    partial class FrmOptions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOptionsOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBoxCOMPorts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mairduino Options";
            // 
            // cmbBoxCOMPorts
            // 
            this.cmbBoxCOMPorts.FormattingEnabled = true;
            this.cmbBoxCOMPorts.Location = new System.Drawing.Point(68, 23);
            this.cmbBoxCOMPorts.Name = "cmbBoxCOMPorts";
            this.cmbBoxCOMPorts.Size = new System.Drawing.Size(131, 21);
            this.cmbBoxCOMPorts.TabIndex = 2;
            this.cmbBoxCOMPorts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbBoxCOMPorts_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // btnOptionsOK
            // 
            this.btnOptionsOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOptionsOK.Location = new System.Drawing.Point(251, 286);
            this.btnOptionsOK.Name = "btnOptionsOK";
            this.btnOptionsOK.Size = new System.Drawing.Size(75, 23);
            this.btnOptionsOK.TabIndex = 1;
            this.btnOptionsOK.Text = "OK";
            this.btnOptionsOK.UseVisualStyleBackColor = true;
            this.btnOptionsOK.Click += new System.EventHandler(this.btnOptionsOK_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 321);
            this.Controls.Add(this.btnOptionsOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOptionsOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxCOMPorts;
    }
}