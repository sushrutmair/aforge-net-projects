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
    public partial class FrmFilteredColorSelect : Form
    {
        public Color selectedColor = Color.Empty;

        public FrmFilteredColorSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radiobtnGreen.Checked)
            {
                this.selectedColor = Color.Green;
                return;
            }

            if (this.radiobtnRed.Checked)
            {
                this.selectedColor = Color.Red;
                return;
            }

            if (this.radioBtnYellow.Checked)
            {
                this.selectedColor = Color.Yellow;
                return;
            }
            
        }
    }
}
