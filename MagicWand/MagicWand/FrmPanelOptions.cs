using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicWand
{
    public partial class FrmPanelOptions : Form
    {
        public string strSelectedFilePath  = null;
        public string strDisplayImagePath = null;

        public FrmPanelOptions()
        {
            InitializeComponent();

            radioBtnPlayVideo.Checked = false;
            radioBtnRunApp.Checked = false;
        }

        private void radioBtnPlayVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPlayVideo.Checked)
            {
                this.btnBrowse.Enabled = true;
            }
        }

        private void radioBtnRunApp_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnRunApp.Checked)
                this.btnBrowse.Enabled = true;
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Multiselect = false;
            if (DialogResult.OK == f.ShowDialog(this))
            {
                //file selected by user. store its path
                this.strSelectedFilePath = f.FileName;
            }
        }

        private void btnPanelImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Multiselect = false;
            if (DialogResult.OK == f.ShowDialog(this))
                this.strDisplayImagePath = f.FileName;
        }
    }
}
