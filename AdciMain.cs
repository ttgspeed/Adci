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
        private SerialPort srpt = new SerialPort(settings.getComPort());
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
                ioStatus.Text = "Listening on " + settings.getComPort();
                ioBaudRate.Text = "Baud Rate: " + settings.getBaudRate();
            }
        }

        private void beginSerialReading()
        {
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
            catch
            {
                MessageBox.Show("There was an error opening the serial port.");
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
                if (data.Length == 2)
                {
                    //add the data to the GUI list
                    this.ioBox.BeginInvoke((MethodInvoker)delegate() { this.ioBox.Items.Add(new ListViewItem(data));});
                    this.ioBox.BeginInvoke((MethodInvoker)delegate() { this.dcGraph.Series["PH"].Points.AddXY(data[0], data[1]);});
                    
                    //add the data to a linkedlist (for CSV export)
                    dropCount.AddLast(data[0]);
                    phValue.AddLast(data[1]);
                }
            }
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

                for(int i = 0; i < dropCount.Count; i++)
                    CSVData.AddLast(new string[] {dropCount.ElementAt(i),phValue.ElementAt(i)});

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
            ioBox.Clear();
            foreach(var series in dcGraph.Series) {
                series.Points.Clear();
            }
        }
    }
}
