using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Adci
{
    public partial class AdciMain : Form
    {
        private bool isTracking = false;
        private SerialPort srpt;
        private LinkedList<string> dropCount = new LinkedList<string>(); 
        private LinkedList<string> phValue = new LinkedList<string>();
        private LinkedList<string[]> CSVData = new LinkedList<string[]>();

        public AdciMain()
        {
            InitializeComponent();
        }

        private void Adci_Load(object sender, EventArgs e)
        {
            CSVData.AddLast(new string[] {"Drop Count", "PH Value"});
            dcGraph.Series["PH"].Points.AddXY(0,0);
            columnPH.Width = -2;
            columnDC.Width = -2;
        }

        private void beginTracking_Click(object sender, EventArgs e)
        {
            if (isTracking)
            {
                isTracking = false;
                beginTracking.Text = "Begin Tracking";
                ioStatus.Text = "Disconnected";
                ioBaudRate.Text = "Baud Rate: " + settings.getBaudRate();
                srpt.Close();
            }
            else
            {
                isTracking = true;
                Thread thread = new Thread(new ThreadStart(beginSerialReading));
                thread.IsBackground = true;
                thread.Start();
                beginTracking.Text = "Stop Tracking";
                ioStatus.Text = "Listening on " + settings.getComPort();
                ioBaudRate.Text = "Baud Rate: " + settings.getBaudRate();
            }
        }

        private void beginSerialReading()
        {
            srpt = new SerialPort(settings.getComPort());
            srpt.BaudRate = settings.getBaudRate();
            srpt.Parity = Parity.None;
            srpt.StopBits = StopBits.One;
            srpt.DataBits = 8;
            srpt.Handshake = Handshake.None;

            srpt.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                srpt.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("There was an error opening the serial port: "+e.ToString());
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            handleData(indata);
        }

        private void handleData(String input)
        {
            if (input.Contains(","))
            {
                string[] data = input.Split((new Char [] {',' }));
                data[1] = formatPH(System.Convert.ToInt16(data[1])).ToString();
                if (data.Length == 2)
                {
                    //add the data to the GUI list
                    this.ioBox.BeginInvoke((MethodInvoker)delegate() { this.ioBox.Items.Add(new ListViewItem(data));});
                    this.ioBox.BeginInvoke((MethodInvoker)delegate() { this.dcGraph.Series["PH"].Points.AddXY(data[0], data[1]); });
                    
                    //add the data to a linkedlist (as string for CSV export)
                    CSVData.AddLast(new string[] { data[0], data[1]});
                }
            }
        }

        private int formatPH(int rawPH)
        {
            return (rawPH - settings.getOffsetPH());
        }

        private void ldSettings_Click(object sender, EventArgs e)
        {
            EditSettings sfm = new EditSettings();
            sfm.Show();
        }

        private void exportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"AdciData.csv";
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < CSVData.Count(); i++)
                    sb.AppendLine(string.Join(",", CSVData.ElementAt(i)));

                File.WriteAllText(filePath, sb.ToString());

                MessageBox.Show("Data saved successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error saving the file... "+ex.ToString());
            }
        }

        private void resetData_Click(object sender, EventArgs e)
        {
            dropCount.Clear();
            phValue.Clear();
            CSVData.Clear();
            ioBox.Items.Clear();
            foreach(var series in dcGraph.Series)
            {
                series.Points.Clear();
            }
            dcGraph.Series["PH"].Points.AddXY(0, 0);
        }

        private void ldCalibrate_Click(object sender, EventArgs e)
        {
            try {
                int lastPH = System.Convert.ToInt16(CSVData.ElementAt(CSVData.Count - 1)[1]);
                Calibration cfm = new Calibration();
                cfm.setLastData(lastPH);
                cfm.Show();
            }
            catch
            {
                MessageBox.Show("Please capture one value before calibrating");
            }
        }
    }
}
