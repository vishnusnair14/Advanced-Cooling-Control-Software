using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Advanced_Cooling_Control_Software
{
    public partial class DecodeCommands : Form
    {
        Process process;
        public DecodeCommands()
        {
            InitializeComponent();
            OpenCommand_MaplinkLabel.Visible = true;
            CloseCommand_MaplinkLabel.Visible = false;
        }

        private void DecodeCommands_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DecodeCommand_button_Click(object sender, EventArgs e)
        {
            Decode decode = new Decode();
            if (CommandFilePath_textBox.Text.Length != 0)
            {
                DecodeMsg_textBox.Text = decode.SearchCmdInDict(Command_textBox.Text.ToUpper(), CommandFilePath_textBox.Text);
            }
            else
            {
                DecodeMsg_textBox.Text = decode.SearchCmdInDict(Command_textBox.Text.ToUpper());
            }
            Command_textBox.Text = "";
        }

        private void OpenCommand_MaplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string st;
            if (CommandFilePath_textBox.Text.Length == 0)
            {
                st = Environment.CurrentDirectory + @"\codes.txt";
            }
            else
            {
                st = CommandFilePath_textBox.Text;
            }

            // DecodeMsg_textBox.Text = st;

            process = Process.Start(st);
            OpenCommand_MaplinkLabel.Visible = false;
            CloseCommand_MaplinkLabel.Visible = true;


        }

        private void CloseCommand_MaplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                process.Kill();
                OpenCommand_MaplinkLabel.Visible = true;
                CloseCommand_MaplinkLabel.Visible = false;
            }
            catch
            {
                OpenCommand_MaplinkLabel.Visible = true;
                CloseCommand_MaplinkLabel.Visible = false;
            }
        }
    }
}
