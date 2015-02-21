using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adci
{
    public partial class Calibration : Form
    {
        public Calibration()
        {
            InitializeComponent();
        }

        private void saveCalibration_Click(object sender, EventArgs e)
        {
            settings.setOffsetPH(System.Convert.ToInt16(phElectrode.Value - phControl.Value));
            this.Close();
        }

        public void setLastData(int data)
        {
            phElectrode.Value = data;
        }
    }
}
