using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Advanced_Cooling_Control_Software
{
    public partial class CommandContainer : Form
    {
        readonly SerialPort serialport1;
        public CommandContainer(SerialPort serialPort)
        {
            InitializeComponent();
            serialport1 = serialPort;
            SentCommandToArduino sentcommandstoarduino = new SentCommandToArduino(serialport1)
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            sentcommandstoarduino.Show();
        }

        private void SentCommandToArduino_MenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
            SentCommandToArduino sentcommandstoarduino = new SentCommandToArduino(serialport1)
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
            };
            sentcommandstoarduino.Show();
        }

        private void decodeCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
            DecodeCommands decodecommand = new DecodeCommands
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            decodecommand.Show();
        }
    }
}
