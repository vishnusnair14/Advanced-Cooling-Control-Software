using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Advanced_Cooling_Control_Software
{
    public partial class SentCommandToArduino : Form
    {
        readonly SerialPort serialport1;
        public SentCommandToArduino(SerialPort serialPort)
        {
            serialport1 = serialPort;
            InitializeComponent();
            if (serialport1.IsOpen)
            {
                Connection_label.Text = "Connected: " + serialport1.PortName + " @ " + serialport1.BaudRate;
                Status_label.Text = "ONLINE";
                Status_label.BackColor = Color.Green;
                Status_label.ForeColor = Color.White;
            }
            else
            {
                Connection_label.Text = "[NOT CONNECTED]";
                Status_label.Text = "OFFLINE";
                Status_label.BackColor = Color.Red;
                Status_label.ForeColor = Color.Yellow;
            }
        }

        private void SentCommand_button_Click(object sender, EventArgs e)
        {
            Decode_groupBox.Text = "Decoded Message";
            decodeMsg_textBox.Text = "";
            if (serialport1.IsOpen)
            {
                try
                {
                    serialport1.WriteLine(Command_textBox.Text);
                }
                catch
                {
                    // do nothing
                }
            }
        }

        private void GetInfo_button_Click(object sender, EventArgs e)
        {
            Decode_groupBox.Text = "Information";
            decodeMsg_textBox.Text = "$(get_info)";
        }
    }
}
