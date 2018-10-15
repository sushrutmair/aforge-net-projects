using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Splash
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {
            //load help info.

            this.txtBoxHelp.AppendText("Escape Key = Pauses painting.\r\n");
            this.txtBoxHelp.AppendText("Spacebar Key = Changes paint color. Keep on using spacebar to move through colors.\r\n");
        }
    }
}
