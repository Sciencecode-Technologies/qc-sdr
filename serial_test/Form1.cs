using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Reflection.Emit;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace serial_test
{
    public partial class Form1 : Form
    {

        public string com_info;
        public string m_data;
        public string received_data;

        public SerialPort _serialPort;
        public byte[] RECV_DATA_BUFFER = new byte[12];

        private delegate void SetTextDeleg(string text);

        public Form1()
        {
            InitializeComponent();
        }
        private void checkConnection()
        {
            if (_serialPort.IsOpen)
            {
                button_connect.BackColor = Color.Blue;
            }
            else
            {
                button_connect.BackColor = Color.Red;
            }
        }
        private void button_connect_Click(object sender, EventArgs e)
        {
            com_info = textBox_com.Text;

            _serialPort = new SerialPort(
                com_info,
                9600,
                Parity.None,
                8,
                StopBits.One); // None?
            _serialPort.Handshake = Handshake.None;

            _serialPort.Open(); // try catch gelecek

            checkConnection(); // for color
        }

        private void textBox_com_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _serialPort.Close();

            checkConnection();
        }
        private void si_DataReceived(string data) { textBox_data.Text = Math.Round(float.Parse(data.Trim(), CultureInfo.InvariantCulture.NumberFormat)).ToString(); }
        private void sp_DataReceiver(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            string data = _serialPort.ReadExisting();//_serialPort.ReadExisting();
            //_serialPort.Read(RECV_DATA_BUFFER, 0, 12);
            if (data != "")
            {
                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
            }
        }
        private void button_read_Click(object sender, EventArgs e)
        {
                
            _serialPort.Write("R");

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceiver);
            // reading data event

                //textBox_data.Text = received_data;
         
            //textBox_data.Text =  System.Text.Encoding.Default.GetString(RECV_DATA_BUFFER);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_data.Text = "";
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            _serialPort.Write("S"); // sends reset command
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox_data.Text);
        }
    }
}

//https://koddefteri.net/c-sharp/c-sharp-ile-seri-port-kullanimi.html
//https://www.c-sharpcorner.com/uploadfile/eclipsed4utoo/communicating-with-serial-port-in-C-Sharp/