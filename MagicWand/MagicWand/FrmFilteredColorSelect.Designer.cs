namespace MagicWand
{
    partial class FrmFilteredColorSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilteredColorSelect));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radiobtnRed = new System.Windows.Forms.RadioButton();
            this.radioBtnYellow = new System.Windows.Forms.RadioButton();
            this.radiobtnGreen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(154, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 84);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // radiobtnRed
            // 
            this.radiobtnRed.AutoSize = true;
            this.radiobtnRed.Location = new System.Drawing.Point(160, 102);
            this.radiobtnRed.Name = "radiobtnRed";
            this.radiobtnRed.Size = new System.Drawing.Size(45, 17);
            this.radiobtnRed.TabIndex = 2;
            this.radiobtnRed.TabStop = true;
            this.radiobtnRed.Text = "Red";
            this.radiobtnRed.UseVisualStyleBackColor = true;
            // 
            // radioBtnYellow
            // 
            this.radioBtnYellow.AutoSize = true;
            this.radioBtnYellow.Location = new System.Drawing.Point(160, 126);
            this.radioBtnYellow.Name = "radioBtnYellow";
            this.radioBtnYellow.Size = new System.Drawing.Size(56, 17);
            this.radioBtnYellow.TabIndex = 3;
            this.radioBtnYellow.TabStop = true;
            this.radioBtnYellow.Text = "Yellow";
            this.radioBtnYellow.UseVisualStyleBackColor = true;
            // 
            // radiobtnGreen
            // 
            this.radiobtnGreen.AutoSize = true;
            this.radiobtnGreen.Location = new System.Drawing.Point(160, 149);
            this.radiobtnGreen.Name = "radiobtnGreen";
            this.radiobtnGreen.Size = new System.Drawing.Size(54, 17);
            this.radiobtnGreen.TabIndex = 4;
            this.radiobtnGreen.TabStop = true;
            this.radiobtnGreen.Text = "Green";
            this.radiobtnGreen.UseVisualStyleBackColor = true;
            // 
            // FrmFilteredColorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 227);
            this.Controls.Add(this.radiobtnGreen);
            this.Controls.Add(this.radioBtnYellow);
            this.Controls.Add(this.radiobtnRed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FrmFilteredColorSelect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select the color you want";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radiobtnRed;
        private System.Windows.Forms.RadioButton radioBtnYellow;
        private System.Windows.Forms.RadioButton radiobtnGreen;
    }
}