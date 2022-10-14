using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Reflection.Emit;
using System.Threading;
using System.Globalization;
using System.Reflection;
using System.Xml.Linq;
using static serial_test.csv_file_writer;


namespace serial_test
{
    public partial class Form1 : Form
    {
        public string com_info;
        public string m_data;
        public string received_data;
        
        public System.Windows.Forms.Timer tm;

        csv_file_writer csvfw = new csv_file_writer(
            @".", //\\192.168.0.12\Data\Bilgiislem\Suha\.service_folder\qc-sdr
            "qcsdr_data.csv",
            System.Net.Dns.GetHostName());

        public SerialPort _serialPort;
        public SerialPort _serialPort_weight;

        private delegate void SetTextDeleg(string text);
        public Form1()
        {
            InitializeComponent();

            label1.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        }
        private void checkConnection(System.Windows.Forms.Button button_connect, SerialPort _sp)
        {
            if (_sp.IsOpen)
            {
                button_connect.BackColor = Color.Blue;
                button_connect.ForeColor = Color.White;
            }
            else
            {
                button_connect.BackColor = Color.Red;
                button_connect.ForeColor = Color.White;
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
            
            _serialPort.Open();

            checkConnection(button_connect, _serialPort); // for color


            //Setup Timer
            tm = new System.Windows.Forms.Timer();
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1000; //in ms
            tm.Enabled = true;  //Start timer

        }
        void tm_Tick(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
                _serialPort.Open();

            button_read_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _serialPort.Close();

            checkConnection(button_connect, _serialPort);
        }
        private void si_DataReceived(string data) { textBox_data.Text = Math.Round(float.Parse(data.Trim(), CultureInfo.InvariantCulture.NumberFormat),3).ToString(); }
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

        /*private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_data.Text = "";
        }*/

        private void button_reset_Click(object sender, EventArgs e)
        {
            _serialPort.Write("S"); // sends reset command
            /*
             * Reset komutu ile gelen verı sıfırlanır ve yeni gelen veri
             * 0 değerinin üstüne koyarak artar
             * 
             * örneğin
             * 
             * 69.33 metre okundu
             * reset
             * 0
             * motor çalıştı
             * 4 metre okundu
             * 
             * eğer reset komutu gönderilmeseydi
             * okunan değer 73.33 olacaktı.
             */
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox_data.Text);
        }

        // WEIGHT SERIAL
        // BASKUL
        private void w_si_DataReceived(string data) {
            data = data.Trim();
            string[] _data = data.Split('\r');
            //if (_data[_data.Length - 2] == "")
            //{
            textBox_data_weight.Text = _data[_data.Length - 1].Trim(); //-1 num, if -2 has a value then make num negative
            //}

            //Console.WriteLine(data); // sondan altı veriyi al
            
        }
        private void w_sp_DataReceiver(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1500);
            string w_data = _serialPort_weight.ReadExisting();//_serialPort.ReadExisting();
            //_serialPort.Read(RECV_DATA_BUFFER, 0, 12);
            this.BeginInvoke(new SetTextDeleg(w_si_DataReceived), new object[] { w_data });
        }
        private void button_connect_weight_Click(object sender, EventArgs e)
        {
            com_info = textBox_com_weight.Text;

            _serialPort_weight = new SerialPort(
                com_info,
                9600,
                Parity.None,
                8,
                StopBits.One);
            _serialPort_weight.Handshake = Handshake.None;

            _serialPort_weight.Open(); // try catch gelecek

            checkConnection(button_connect_weight, _serialPort_weight); // for color
        }

        private void button_disconnect_weight_Click(object sender, EventArgs e)
        {
            _serialPort_weight.Close();

            checkConnection(button_connect_weight, _serialPort_weight);
        }

        private void button_copy_weight_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox_data_weight.Text);
        }

        private void button_read_weight_Click(object sender, EventArgs e)
        {

            if (_serialPort_weight.IsOpen != true)
            {
                _serialPort_weight.Open();
            }

            textBox_data_weight.Text = "";

            _serialPort_weight.DataReceived += new SerialDataReceivedEventHandler(w_sp_DataReceiver);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_meter.Text = textBox_data.Text.Replace('.', ',');

            //label_meter.ForeColor = Color.Green;

        }
        private double formula(double b, double m, double k, double r)
        {
            return b * m * (k - r);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox_result.Text = formula(
                double.Parse(textBox_unitg.Text),
                double.Parse(textBox_totalw.Text),
                double.Parse(textBox_meter.Text),
                double.Parse(textBox_rolik.Text)).ToString();

            textBox_net_weight.Text = (double.Parse(textBox_totalw.Text) - double.Parse(textBox_rolik.Text)).ToString();

            csvfw.add_row(
                textBox_rolik.Text,
                textBox_totalw.Text,
                textBox_unitg.Text,
                textBox_meter.Text,
                textBox_result.Text);
        }

        private void button_copy_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox_result.Text);
        }

        private void button_rolik_Click(object sender, EventArgs e)
        {
            textBox_rolik.Text = textBox_data_weight.Text.Replace('.', ',');
        }

        private void button_weight_Click(object sender, EventArgs e)
        {
            textBox_totalw.Text = textBox_data_weight.Text.Replace('.', ',');
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_unitg.Text = "0";
            textBox_result.Text = "0";
            textBox_meter.Text = "0";
            textBox_totalw.Text = "0";
            textBox_rolik.Text = "0";
        }

        private void button_net_weight_copy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText((double.Parse(textBox_totalw.Text) - double.Parse(textBox_rolik.Text)).ToString());
        }

        private void button_meter_copy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox_meter.Text);
        }
        private bool off_details_flag = false;
        private void textBox_commget_TextChanged(object sender, EventArgs e)
        {
            if (textBox_commget.Text == "off_details")
            {
                if (!off_details_flag)
                {
                    off_details_flag = true;
                    textBox_commget.ForeColor = Color.LightGreen;
                    // worked

                    groupBox1.Visible = false;
                    groupBox4.Visible = false;

                    button_read.Visible = false;
                    button_reset.Visible = false;
                    button_read_weight.Visible = false;

                    textBox_data.Location = new Point(6, textBox_data.Location.Y);
                    button_save.Location = new Point(6, button_save.Location.Y);

                    textBox_data_weight.Location = new Point(6, textBox_data_weight.Location.Y);
                    button_rolik.Location = new Point(6, button_rolik.Location.Y);
                    button_weight.Location = new Point(6, button_weight.Location.Y);

                    groupBox2.Size = new Size(groupBox2.Size.Width - groupBox1.Size.Width, groupBox2.Size.Height);
                    groupBox3.Size = new Size(groupBox3.Size.Width - groupBox1.Size.Width, groupBox3.Size.Height);

                    groupBox5.Location = new Point(groupBox5.Location.X - groupBox3.Location.X - 70, groupBox5.Location.Y);

                    this.Size = new Size(this.Size.Width - 81, this.Size.Height);

                    textBox_commget.Size = new Size(textBox_commget.Size.Width - 81, textBox_commget.Size.Height);
                }
                else
                {
                    textBox_commget.ForeColor = Color.LightPink;
                }
            }else if (textBox_commget.Text == "on_details")
            {
                if (off_details_flag)
                {
                    off_details_flag = false; // ture ?
                    textBox_commget.ForeColor = Color.LightGreen;

                    groupBox1.Visible = default_details_bool[0];
                    groupBox4.Visible = default_details_bool[1];
                    button_read.Visible = default_details_bool[2];
                    button_reset.Visible = default_details_bool[3];
                    button_read_weight.Visible = default_details_bool[4];
                    textBox_data.Location = defaults_details_point[0];
                    button_save.Location = defaults_details_point[1];
                    textBox_data_weight.Location = defaults_details_point[2];
                    button_rolik.Location = defaults_details_point[3];
                    button_weight.Location = defaults_details_point[4];
                    groupBox2.Size = default_details_size[0];
                    groupBox3.Size = default_details_size[1];
                    groupBox5.Location = defaults_details_point[5];
                    this.Size = default_details_size[2];
                    textBox_commget.Size = default_details_size[3];

                }
                else
                {
                    textBox_commget.ForeColor = Color.LightPink;
                }
            }
            else
            {
                textBox_commget.ForeColor = Color.Red;
            }
        }

        public bool[] default_details_bool = new bool[5];
        public Point[] defaults_details_point = new Point[7];
        public Size[] default_details_size = new Size[4];
        private void Form1_Load(object sender, EventArgs e)
        {

            default_details_bool[0] = groupBox1.Visible;
            default_details_bool[1] = groupBox4.Visible;
            default_details_bool[2] = button_read.Visible;
            default_details_bool[3] = button_reset.Visible;
            default_details_bool[4] = button_read_weight.Visible;
            defaults_details_point[0] = textBox_data.Location;
            defaults_details_point[1] = button_save.Location;
            defaults_details_point[2] = textBox_data_weight.Location;
            defaults_details_point[3] = button_rolik.Location;
            defaults_details_point[4] = button_weight.Location;
            default_details_size[0] = groupBox2.Size;
            default_details_size[1] = groupBox3.Size;
            defaults_details_point[5] = groupBox5.Location;
            default_details_size[2] = this.Size;
            default_details_size[3] = textBox_commget.Size;
        }
    }
}

/*
 * 00
 *  12.100
 * 00
 *  12.200
 * 00
 *  12.100
 *  
 *  00\r\n12.100
 */

//https://koddefteri.net/c-sharp/c-sharp-ile-seri-port-kullanimi.html
//https://www.c-sharpcorner.com/uploadfile/eclipsed4utoo/communicating-with-serial-port-in-C-Sharp/