using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//for serial comm with the Sanguino
using System.IO.Ports;

namespace Splash
{
    public partial class FrmOptions : Form
    {
        private string[] mySerialPortNames;
        private bool bDoneOnce = false;
        public string strMairduinoPortName;
        
        public FrmOptions()
        {
            InitializeComponent();
        }

        private void FrmOptions_Load(object sender, EventArgs e)
        {
            //load Splash options

            //load Mairduino options. figure out the serial ports that are present
            mySerialPortNames = System.IO.Ports.SerialPort.GetPortNames();

        }
        
        void cmbBoxCOMPorts_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!bDoneOnce)
            {
                foreach (string str in mySerialPortNames)
                {
                    cmbBoxCOMPorts.Items.Add(str);
                }

                bDoneOnce = true;
            }
        }

        private void btnOptionsOK_Click(object sender, EventArgs e)
        {
            //apply the selected options
            if(bDoneOnce)
                strMairduinoPortName = cmbBoxCOMPorts.SelectedItem as string;
        }
    }
}
