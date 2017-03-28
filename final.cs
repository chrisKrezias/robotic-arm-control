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
using System.Windows.Forms.VisualStyles;

namespace rompotiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetAvailablePorts();
        }

        void GetAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    textBox1.Text = "Select Port Settings";
                }
                else
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    Send1.Enabled = true;
                    Send2.Enabled = true;
                    Send3R.Enabled = true;
                    Send4R.Enabled = true;
                    Send5R.Enabled = true;
                    Send1L.Enabled = true;
                    Send2L.Enabled = true;
                    Send3L.Enabled = true;
                    Send4L.Enabled = true;
                    Send5L.Enabled = true;
                    ledon.Enabled=true;
                    ledoff.Enabled = true;
                    teach.Enabled = true;
                    Move.Enabled = true;
                    OpenPort.Enabled = false;
                    ClosePort.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox1.Text = "Unauthorized Access";
            }
        }

        private void ClosePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            Send1.Enabled = false;
            Send2.Enabled = false;
            Send3R.Enabled = false;
            Send4R.Enabled = false;
            Send5R.Enabled = false;
            Send1L.Enabled = false;
            Send2L.Enabled = false;
            Send3L.Enabled = false;
            Send4L.Enabled = false;
            Send5L.Enabled = false;
            ledon.Enabled = false;
            ledoff.Enabled = false;
            teach.Enabled = false;
            Move.Enabled = false;
            OpenPort.Enabled = true;
            ClosePort.Enabled = false;
        }

        private void Send1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("A");
        }

        private void Send2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("B");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("C");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("D");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("E");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("F");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("a");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.WriteLine("b");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("c");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("d");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("e");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("f");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            serialPort1.WriteLine("F");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            serialPort1.WriteLine("f");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void teach_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("G");
        }

        private void Move_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("g");
        }
    }
}
