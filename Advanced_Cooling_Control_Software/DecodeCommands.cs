﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            if (Command_textBox.Text.Length != 0)
            {
                if (CommandFilePath_textBox.Text.Length != 0)
                {
                    if (File.Exists(CommandFilePath_textBox.Text))
                    {
                        try
                        {
                            DecodeMsg_textBox.Text = decode.SearchCmdInDict(Command_textBox.Text.ToUpper(), CommandFilePath_textBox.Text);
                            if (DecodeMsg_textBox.Text.Trim() != Decode.KeyNotfoundstr.Trim())
                            {
                                Status_textBox.Text = "command decode successfull";
                                Status_textBox.BackColor = SystemColors.MenuHighlight;
                                Status_textBox.ForeColor = SystemColors.Window;
                            }
                            else
                            {
                                Status_textBox.Text = Decode.KeyNotfoundstr;
                                Status_textBox.BackColor = Color.Crimson;
                                Status_textBox.ForeColor = SystemColors.Window;
                            }
                        }
                        catch
                        {
                            Status_textBox.Text = "unable to decode command!";
                            Status_textBox.BackColor = Color.Crimson;
                            Status_textBox.ForeColor = SystemColors.Window;
                        }
                    }
                    else
                    {
                        Status_textBox.Text = "Code file path not exists!";
                        Status_textBox.BackColor = Color.Crimson;
                        Status_textBox.ForeColor = SystemColors.Window;
                    }
                }
                else
                {
                    try
                    {
                        DecodeMsg_textBox.Text = decode.SearchCmdInDict(Command_textBox.Text.ToUpper());
                        if (DecodeMsg_textBox.Text.Trim() != Decode.KeyNotfoundstr.Trim())
                        {
                            Status_textBox.Text = "command decode successfull";
                            Status_textBox.BackColor = SystemColors.MenuHighlight;
                            Status_textBox.ForeColor = SystemColors.Window;
                        }
                        else
                        {
                            Status_textBox.Text = Decode.KeyNotfoundstr;
                            Status_textBox.BackColor = Color.Crimson;
                            Status_textBox.ForeColor = SystemColors.Window;
                        }
                    }
                    catch
                    {
                        Status_textBox.Text = "unable to decode command!";
                        Status_textBox.BackColor = Color.Crimson;
                        Status_textBox.ForeColor = SystemColors.Window;
                    }
                }
            }
            else
            {
                Status_textBox.Text = "No command specified!";
                Status_textBox.BackColor = Color.Crimson;
                Status_textBox.ForeColor = SystemColors.Window;
            }
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

        private void Command_textBox_TextChanged(object sender, EventArgs e)
        {
            Status_textBox.Text = "";
            Status_textBox.BackColor = Color.DarkGray;
            Status_textBox.ForeColor = SystemColors.Window;
            DecodeMsg_textBox.Text = "";
        }
    }
}
