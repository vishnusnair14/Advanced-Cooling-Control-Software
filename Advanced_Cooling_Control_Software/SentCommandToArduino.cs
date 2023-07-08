using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Advanced_Cooling_Control_Software
{
    public partial class SentCommandToArduino : Form
    {
        readonly SerialPort serialport1;
        public static bool SentCommandDirectly_checkState = false;

        public SentCommandToArduino(SerialPort serialPort)
        {
            serialport1 = serialPort;
            InitializeComponent();
            if (serialport1.IsOpen)
            {
                Sent_textBox.Text = "Connected: " + serialport1.PortName + " @" + serialport1.BaudRate;
                Status_label.Text = "ONLINE";
                Sent_textBox.BackColor = SystemColors.MenuHighlight;
                Sent_textBox.ForeColor = SystemColors.Window;
                Status_label.BackColor = Color.Green;
                Status_label.ForeColor = Color.White;
            }
            else
            {
                Sent_textBox.Text = "[NOT CONNECTED]";
                Sent_textBox.BackColor = Color.Crimson;
                Sent_textBox.ForeColor = SystemColors.Window;
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
                if (Command_textBox.Text.Length != 0)
                {

                    //Sent_textBox.Text = "[ CONNECTED ]";
                    try
                    {
                        Sent_textBox.Text = "Command sent successfull";
                        Sent_textBox.BackColor = SystemColors.MenuHighlight;
                        Sent_textBox.ForeColor = SystemColors.Window;
                        serialport1.WriteLine(Command_textBox.Text);
                    }
                    catch
                    {
                        // do nothing
                    }
                }
                else
                {
                    Sent_textBox.Text = "No command specified!";
                    Sent_textBox.BackColor = Color.Crimson;
                    Sent_textBox.ForeColor = SystemColors.Window;
                }
            }
            else
            {
                Sent_textBox.Text = "[NOT CONNECTED!]";
                Sent_textBox.BackColor = Color.Crimson;
                Sent_textBox.ForeColor = SystemColors.Window;
            }
        }

        private void GetInfo_button_Click(object sender, EventArgs e)
        {
            Decode_groupBox.Text = "Information";
            decodeMsg_textBox.Text = "$(get_info)";
        }

        private void Command_textBox_TextChanged(object sender, EventArgs e)
        {
            Sent_textBox.Text = "";
            Sent_textBox.BackColor = SystemColors.Control;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SentCommandDirectly_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SentCommandDirectly_checkState = SentCommandDirectly_checkBox.Checked;
        }
    }
}
