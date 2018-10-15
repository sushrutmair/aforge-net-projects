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

namespace Splash
{
    public partial class FrmSelectWebcam : Form
    {
        FilterInfoCollection videoDevices;
        public string device;

        public FrmSelectWebcam()
        {
            InitializeComponent();
        }
        
        void FrmSelectWebcam_Load(object sender, System.EventArgs e)
        {
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    this.comboBox1.Items.Add("<No video capture devices found>");
                    return;
                }

                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    this.comboBox1.Items.Add(device.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }

            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            device = videoDevices[comboBox1.SelectedIndex].MonikerString;
        }
    }
}
