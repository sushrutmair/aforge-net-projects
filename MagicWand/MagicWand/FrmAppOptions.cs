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
    public partial class FrmAppOptions : Form
    {
        public string strFilePath = null;
        public int iPanelNumber = 0;
        public string strPanelDisplayImagePath = null;

        public FrmAppOptions()
        {
            InitializeComponent();
        }

        void panel1_Click(object sender, System.EventArgs e)
        {
            FrmPanelOptions actionForm= new FrmPanelOptions();
            if (actionForm.ShowDialog() == DialogResult.OK)
            {
                iPanelNumber = 1;
                strFilePath = actionForm.strSelectedFilePath;
                strPanelDisplayImagePath = actionForm.strDisplayImagePath;

                this.panel1.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            }
        }

        void panel7_Click(object sender, System.EventArgs e)
        {
            FrmPanelOptions actionForm = new FrmPanelOptions();
            if (actionForm.ShowDialog() == DialogResult.OK)
            {
                iPanelNumber = 7;
                strFilePath = actionForm.strSelectedFilePath;
                strPanelDisplayImagePath = actionForm.strDisplayImagePath;

                this.panel7.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            }
        }

        void panel6_Click(object sender, System.EventArgs e)
        {
            FrmPanelOptions actionForm = new FrmPanelOptions();
            if (actionForm.ShowDialog() == DialogResult.OK)
            {
                iPanelNumber = 6;
                strFilePath = actionForm.strSelectedFilePath;
                strPanelDisplayImagePath = actionForm.strDisplayImagePath;

                this.panel6.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            }
        }

        void panel5_Click(object sender, System.EventArgs e)
        {
            FrmPanelOptions actionForm = new FrmPanelOptions();
            if (actionForm.ShowDialog() == DialogResult.OK)
            {
                iPanelNumber = 5;
                strFilePath = actionForm.strSelectedFilePath;
                strPanelDisplayImagePath = actionForm.strDisplayImagePath;
                
                this.panel5.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            }
        }

        void panel4_Click(object sender, System.EventArgs e)
        {
            FrmPanelOptions actionForm = new FrmPanelOptions();
            if (actionForm.ShowDialog() == DialogResult.OK)
            {
                iPanelNumber = 4;
                strFilePath = actionForm.strSelectedFilePath;
                strPanelDisplayImagePath = actionForm.strDisplayImagePath;

                this.panel4.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            }
        }

        void panel3_Click(object sender, System.EventArgs e)
        {
            FrmPanelOptions actionForm = new FrmPanelOptions();
            if (actionForm.ShowDialog() == DialogResult.OK)
            {
                iPanelNumber = 3;
                strFilePath = actionForm.strSelectedFilePath;
                strPanelDisplayImagePath = actionForm.strDisplayImagePath;

                this.panel3.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            }
        }

        void panel2_Click(object sender, System.EventArgs e)
        {
            FrmPanelOptions actionForm = new FrmPanelOptions();
            if (actionForm.ShowDialog() == DialogResult.OK)
            {
                iPanelNumber = 2;
                strFilePath = actionForm.strSelectedFilePath;
                strPanelDisplayImagePath = actionForm.strDisplayImagePath;

                this.panel2.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            }
        }
    }
}
