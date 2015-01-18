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
    public partial class EditSettings : Form
    {
        public EditSettings()
        {
            InitializeComponent();
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                settings.setbaudRate(int.Parse(brSetting.Text));
            }
            catch
            {
                MessageBox.Show("Please enter an integer baud rate");
            }
                
            settings.setComPort(cpSetting.Text);

            this.Close();
        }

        private void EditSettings_Load(object sender, EventArgs e)
        {
            brSetting.Value = settings.getBaudRate();
            cpSetting.Text = settings.getComPort();
        }
    }
}
