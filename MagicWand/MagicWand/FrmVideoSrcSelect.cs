using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

//
using AForge.Video.DirectShow;

namespace MagicWand
{
    public partial class FrmVideoSrcSelect : Form
    {
        FilterInfoCollection videoDevices;
        public string device;

        public FrmVideoSrcSelect()
        {
            InitializeComponent();
        }

        private void FrmVideoSrcSelect_Load(object sender, EventArgs e)
        {
            // enumerate video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
                throw new ApplicationException();

            // add all devices to combo
            foreach (FilterInfo device in videoDevices)
            {
                this.comboBox1.Items.Add(device.Name);
            }

            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            device = videoDevices[comboBox1.SelectedIndex].MonikerString;
        }
    }
}
