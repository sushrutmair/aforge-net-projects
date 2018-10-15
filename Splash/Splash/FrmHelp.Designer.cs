namespace Splash
{
    partial class FrmHelp
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
            this.txtBoxHelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxHelp
            // 
            this.txtBoxHelp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxHelp.Location = new System.Drawing.Point(12, 12);
            this.txtBoxHelp.Multiline = true;
            this.txtBoxHelp.Name = "txtBoxHelp";
            this.txtBoxHelp.Size = new System.Drawing.Size(424, 238);
            this.txtBoxHelp.TabIndex = 0;
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 262);
            this.Controls.Add(this.txtBoxHelp);
            this.MaximizeBox = false;
            this.Name = "FrmHelp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Splash! Help";
            this.Load += new System.EventHandler(this.FrmHelp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxHelp;
    }
}