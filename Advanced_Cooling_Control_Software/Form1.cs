using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Input;

namespace Advanced_Cooling_Control_Software
{
    public partial class Form1 : Form
    {
        string _serialData;
        sbyte IndexOfA, IndexOfB, IndexOfC, IndexOfD;
        sbyte IndexOfSemicolon, IndexOfHash;
        sbyte IndexOfX, IndexOfY, IndexOfZ, IndexOfE;

        float PWM;
        // set your application access password here:
        string AppAccessPasscode = "20222023v";
        string TEMP1, TEMP2, TEMP3, TEMP4;
        string DeviceRelayID, DeviceRelayState;
        string DTEMP_X, DTEMP_Y, DTEMP_Z, DTEMP_E;  //for dallas temperatures (X,Y,Z,E)
        string ArduinoPortDect;
        string _COMPORT, _BAUDRATE;

        public Form1()
        {
            InitializeComponent();
            ComPort_comboBox.Items.Clear();
            ComPort_comboBox.Items.AddRange(SerialPort.GetPortNames());

            Connect_button.Enabled = true;
            Disconnect_button.Enabled = false;
            Disconnect_button.BackColor = Color.LightSteelBlue;
            Disconnect_button.ForeColor = Color.White;

            PCP_Indicator1.BackColor = Color.Maroon;
            PCP_Indicator2.BackColor = Color.Maroon;
            PCP_Indicator3.BackColor = Color.Maroon;
            PCP_Indicator4.BackColor = Color.Maroon;

            PBT1_circularProgressBar.Value = 0;
            PBT2_circularProgressBar.Value = 0;
            CT1_circularProgressBar.Value = 0;
            CT2_circularProgressBar.Value = 0;
            SMT_X_circularProgressBar.Value = 0;
            SMT_Y_circularProgressBar.Value = 0;
            SMT_Z_circularProgressBar.Value = 0;
            SMT_E_circularProgressBar.Value = 0;
            ExhaustFanSpeed_trackBar.Value = 0;
            CoolingFanSpeed_trackBar.Value = 0;
            ExhaustFanSpeed_numericUpDown.Value = 0;
            CoolingFanSpeed_numericUpDown.Value = 0;

            HDCPOff_button.Enabled = false;
            HDCPOn_button.Enabled = false;
            HDCPDevicelist_Combobox.Enabled = false;
            HDCPMsgbox_label.Enabled = false;

            Conn_progressBar.Value = 0;

            MainPower_checkBox.Enabled = false;
            CabinLight_checkBox.Enabled = false;
            Peltier1_checkBox.Enabled = false;
            Peltier2_checkBox.Enabled = false;

            ExhaustFanSpeed_numericUpDown.Enabled = false;
            ExhaustFanSpeed_trackBar.Enabled = false;
            CoolingFanSpeed_numericUpDown.Enabled = false;
            CoolingFanSpeed_trackBar.Enabled = false;
            //slidingLabel.Text = "Advanced Cooling Control Software [vishnus_technologies(C) 2023] ";
        }

        private void ArduinoReset_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialPort1.IsOpen)
                {
                    BeginInvoke(new EventHandler(ClearBuffer_button_Click));
                    SerialMonitor_textbox.Text = "";
                    ConsoleLog_textbox.Text = "";
                    DIS1.BackColor = SystemColors.ControlDarkDark;
                    DIS1.ForeColor = Color.White;
                    DIS2.BackColor = SystemColors.ControlDarkDark;
                    DIS2.ForeColor = Color.White;
                    DIS3.BackColor = SystemColors.ControlDarkDark;
                    DIS3.ForeColor = Color.White;
                    DIS4.BackColor = SystemColors.ControlDarkDark;
                    DIS4.ForeColor = Color.White;
                    DIS5.BackColor = SystemColors.ControlDarkDark;
                    DIS5.ForeColor = Color.White;
                    DIS6.BackColor = SystemColors.ControlDarkDark;
                    DIS6.ForeColor = Color.White;

                    PBT1_circularProgressBar.Value = 0;
                    PBT1_circularProgressBar.Text = "";
                    PBT2_circularProgressBar.Value = 0;
                    PBT2_circularProgressBar.Text = "";
                    CT1_circularProgressBar.Value = 0;
                    CT1_circularProgressBar.Text = "";
                    CT2_circularProgressBar.Value = 0;
                    CT2_circularProgressBar.Text = "";
                }
                SerialPort1.WriteLine("r");  // arduino software reset code:  'r' 
            }
            catch
            {
                ConnectionMsgBox_label.Text = "COM Port not connected!";
            }
        }

        private void MainPower_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MainPower_checkBox.Checked == true)
            {
                PCP_Indicator1.BackColor = Color.DarkGreen;
                MainPower_checkBox.Text = "OFF";
            }
            else if (MainPower_checkBox.Checked == false)
            {
                PCP_Indicator1.BackColor = Color.Maroon;
                MainPower_checkBox.Text = "ON";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SerialPort1.Close();
            }
            catch
            {
                /* Do nothing */
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SerialPort1.Close();
            }
            catch
            {

            }
        }

        private string AutoDetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get().Cast<ManagementObject>())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino"))
                    {
                        return deviceId;
                    }
                }
            }
            catch
            {
                ConnectionMsgBox_label.Text = "Unable to detected Arduino";
            }
            return null;
        }

        private void CheckArduinoComPort_button_Click(object sender, EventArgs e)
        {
            ComPort_comboBox.Items.Clear();
            ComPort_comboBox.Items.AddRange(SerialPort.GetPortNames());
            ArduinoPortDect = AutoDetectArduinoPort();
            if (String.IsNullOrEmpty(ArduinoPortDect) != true)
            {
                ConnectionMsgBox_label.Text = "Arduino detected @" + ArduinoPortDect;
                ComPort_comboBox.Text = ArduinoPortDect;
                BaudRate_comboBox.Text = "9600";
                if (AutoConnect_checkBox.Checked)
                {
                    BeginInvoke(new EventHandler(Connect_button_Click));
                }
            }
            else
            {
                ConnectionMsgBox_label.Text = "Arduino device not detected";
            }
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(ClearBuffer_button_Click));
            ConnectionMsgBox_label.Enabled = true;
            HDCPMsgbox_label.Enabled = true;
            if (ComPort_comboBox.SelectedItem != null)
            {
                if (BaudRate_comboBox.SelectedItem != null)
                {
                    if (Passcode_textBox.Text != null)
                    {
                        if (Passcode_textBox.Text == AppAccessPasscode)
                        {
                            SerialPort1.PortName = ComPort_comboBox.SelectedItem.ToString();
                            SerialPort1.BaudRate = Convert.ToInt32(BaudRate_comboBox.SelectedItem);
                            _COMPORT = ComPort_comboBox.SelectedItem.ToString();
                            _BAUDRATE = BaudRate_comboBox.SelectedItem.ToString();
                            try
                            {
                                // connects to serial port:
                                SerialPort1.Open();
                                // first software reset:
                                BeginInvoke(new EventHandler(ArduinoReset_button_Click));

                                Conn_progressBar.Value = 100;
                                ConnectionMsgBox_label.Text = "Connected: " + _COMPORT + " @" + _BAUDRATE;
                                ConsoleLog_textbox.Text = "> [MSG: Connected to port @" + _COMPORT + "]" + Environment.NewLine;
                                SerialMonitor_groupBox.Text = SerialMonitor_groupBox.Text + " [ " + _COMPORT + " @" + _BAUDRATE + " ]";

                                Passcode_textBox.Text = "";
                                ComPort_comboBox.Enabled = false;
                                BaudRate_comboBox.Enabled = false;
                                Connect_button.Enabled = false;
                                Connect_button.BackColor = Color.LightSteelBlue;
                                Passcode_textBox.Enabled = false;
                                Disconnect_button.Enabled = true;
                                Disconnect_button.BackColor = Color.CornflowerBlue;
                                CheckArduinoComPort_button.Enabled = false;
                                CheckArduinoComPort_button.BackColor = Color.LightSteelBlue;

                                HDCPOff_button.Enabled = true;
                                HDCPOn_button.Enabled = true;
                                HDCPDevicelist_Combobox.Enabled = true;
                                HDCPMsgbox_label.Enabled = true;

                                MainPower_checkBox.Enabled = true;
                                CabinLight_checkBox.Enabled = true;
                                Peltier1_checkBox.Enabled = true;
                                Peltier2_checkBox.Enabled = true;

                                ExhaustFanSpeed_numericUpDown.Enabled = true;
                                ExhaustFanSpeed_trackBar.Enabled = true;
                                CoolingFanSpeed_numericUpDown.Enabled = true;
                                CoolingFanSpeed_trackBar.Enabled = true;

                                AutoConnect_checkBox.Enabled = false;
                            }
                            catch
                            {
                                MessageBox.Show("Unable to establish connection with Port: " + _COMPORT, "COM Error");
                            }
                        }
                        else
                        {
                            ConnectionMsgBox_label.Text = "Wrong passcode!";
                        }
                    }
                    else
                    {
                        ConnectionMsgBox_label.Text = "Please enter the passcode";
                    }
                }
                else
                {
                    ConnectionMsgBox_label.Text = "Please select Baud Rate";
                }
            }
            else
            {
                ConnectionMsgBox_label.Text = "Please select COM Port";
            }
        }


        private void Disconnect_button_Click(object sender, EventArgs e)
        {
            try
            {
                // set all PWM value to zero:
                SerialPort1.WriteLine("s0d");

                // Disconnect serial COM:
                SerialPort1.Close();

                Conn_progressBar.Value = 0;
                ConnectionMsgBox_label.Text = "Disconnected: " + _COMPORT;
                SerialMonitor_groupBox.Text = "Serial Monitor";

                PBT1_circularProgressBar.Value = 0;
                PBT1_circularProgressBar.Text = "";
                PBT2_circularProgressBar.Value = 0;
                PBT2_circularProgressBar.Text = "";
                CT1_circularProgressBar.Value = 0;
                CT1_circularProgressBar.Text = "";
                CT2_circularProgressBar.Value = 0;
                CT2_circularProgressBar.Text = "";
                SerialMonitor_textbox.Text = "";
                ConsoleLog_textbox.Text = "";

                // comment below line after debugging:
                Passcode_textBox.Text = "20222023v";

                ConnectionMsgBox_label.Enabled = true;
                ComPort_comboBox.Enabled = true;
                BaudRate_comboBox.Enabled = true;
                Connect_button.Enabled = true;
                Connect_button.BackColor = Color.CornflowerBlue;
                Passcode_textBox.Enabled = true;
                Disconnect_button.Enabled = false;
                Disconnect_button.BackColor = Color.LightSteelBlue;

                HDCPOff_button.Enabled = false;
                HDCPOn_button.Enabled = false;
                HDCPDevicelist_Combobox.Enabled = false;
                HDCPMsgbox_label.Enabled = false;
                CheckArduinoComPort_button.Enabled = true;
                CheckArduinoComPort_button.BackColor = Color.CornflowerBlue;

                MainPower_checkBox.Enabled = false;
                CabinLight_checkBox.Enabled = false;
                Peltier1_checkBox.Enabled = false;
                Peltier2_checkBox.Enabled = false;

                DIS1.BackColor = SystemColors.ControlDarkDark;
                DIS1.ForeColor = Color.White;
                DIS2.BackColor = SystemColors.ControlDarkDark;
                DIS2.ForeColor = Color.White;
                DIS3.BackColor = SystemColors.ControlDarkDark;
                DIS3.ForeColor = Color.White;
                DIS4.BackColor = SystemColors.ControlDarkDark;
                DIS4.ForeColor = Color.White;
                DIS5.BackColor = SystemColors.ControlDarkDark;
                DIS5.ForeColor = Color.White;
                DIS6.BackColor = SystemColors.ControlDarkDark;
                DIS6.ForeColor = Color.White;

                ExhaustFanSpeed_numericUpDown.Enabled = false;
                ExhaustFanSpeed_trackBar.Enabled = false;
                CoolingFanSpeed_numericUpDown.Enabled = false;
                CoolingFanSpeed_trackBar.Enabled = false;

                ExhaustFanSpeed_trackBar.Value = 0;
                CoolingFanSpeed_trackBar.Value = 0;
                ExhaustFanSpeed_numericUpDown.Value = 0;
                CoolingFanSpeed_numericUpDown.Value = 0;

                AutoConnect_checkBox.Checked =false;
                AutoConnect_checkBox.Enabled = true;

            }
            catch
            {
                ConnectionMsgBox_label.Text = "Unable to close conn. " + _COMPORT;
            }
        }

        private void SerialPort1_serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                _serialData = SerialPort1.ReadLine().Trim();
                BeginInvoke(new EventHandler(SerialDataDecoder));
            }
            catch
            {
                /* Do Nothing */
            }
        }

        /* SERIAL DATA DECODER SECTION */
        private void SerialDataDecoder(object sender, EventArgs e)
        {
            // writes serial data to console log:
            SerialMonitor_textbox.AppendText(_serialData + Environment.NewLine);

            // Temperature data decode section (peltier block, coolant temp):
            // example data: [T12A25B16C44D] or [T45.33A46.17B44.51C34.54D]
            if (_serialData.StartsWith("T"))
            {
                try
                {
                    IndexOfA = Convert.ToSByte(_serialData.IndexOf("A"));
                    IndexOfB = Convert.ToSByte(_serialData.IndexOf("B"));
                    IndexOfC = Convert.ToSByte(_serialData.IndexOf("C"));
                    IndexOfD = Convert.ToSByte(_serialData.IndexOf("D"));

                    TEMP1 = _serialData.Substring(1, IndexOfA - 1);
                    TEMP2 = _serialData.Substring(IndexOfA + 1, (IndexOfB - IndexOfA) - 1);
                    TEMP3 = _serialData.Substring(IndexOfB + 1, (IndexOfC - IndexOfB) - 1);
                    TEMP4 = _serialData.Substring(IndexOfC + 1, (IndexOfD - IndexOfC) - 1);

                    PBT1_circularProgressBar.Value = (int)Convert.ToDouble(TEMP1);
                    PBT1_circularProgressBar.Text = TEMP1 + "℃";
                    PBT2_circularProgressBar.Value = (int)Convert.ToDouble(TEMP2);
                    PBT2_circularProgressBar.Text = TEMP2 + "℃";

                    CT1_circularProgressBar.Value = (int)Convert.ToDouble(TEMP3);
                    CT1_circularProgressBar.Text = TEMP3 + "℃";
                    CT2_circularProgressBar.Value = (int)Convert.ToDouble(TEMP4);
                    CT2_circularProgressBar.Text = TEMP4 + "℃";

                    ConsoleLog_textbox.AppendText(Environment.NewLine + "Peltier temp:- CS: " + TEMP1 + " | HS: " + TEMP2 + Environment.NewLine
                        + "Coolant temp:- CS: " + TEMP3 + " | HS: " + TEMP4 + Environment.NewLine + Environment.NewLine);
                }
                catch
                {
                    /* Do Nothing */
                }
            }

            // Relay control data decode section:
            // example data: [R18:X#] or [R14:A#] or [R0:B#] 
            else if (_serialData.StartsWith("R"))
            {
                try
                {
                    IndexOfSemicolon = Convert.ToSByte(_serialData.IndexOf(":"));
                    IndexOfHash = Convert.ToSByte(_serialData.IndexOf("#"));

                    DeviceRelayID = _serialData.Substring(1, IndexOfSemicolon - 1);
                    DeviceRelayState = _serialData.Substring(IndexOfSemicolon + 1, (IndexOfHash - IndexOfSemicolon) - 1);

                    /*
                    Ae : "switched ON"
                    Be : "already switched ON"
                    Xf : "switched OFF"
                    Yf : "already switched OFF"  */

                    if (DeviceRelayState == "Ae")
                    {
                        if (DeviceRelayID == "0") ConsoleLog_textbox.AppendText("> Undefined device switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_textbox.AppendText("> MAIN POWER switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_textbox.AppendText("> PELTIER 1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_textbox.AppendText("> PELTIER 2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_textbox.AppendText("> FLOOD COOLANT FAN switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_textbox.AppendText("> CS PUMP switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_textbox.AppendText("> HS PUMP switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_textbox.AppendText("> CABIN EXHAUST1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_textbox.AppendText("> CABIN EXHAUST2 switched ON" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Be")
                    {
                        if (DeviceRelayID == "0") ConsoleLog_textbox.AppendText("> Undefined device already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_textbox.AppendText("> MAIN POWER already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_textbox.AppendText("> PELTIER 1 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_textbox.AppendText("> PELTIER 2 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_textbox.AppendText("> FLOOD COOLANT FAN already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_textbox.AppendText("> CS PUMP already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_textbox.AppendText("> HS PUMP already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_textbox.AppendText("> CABIN EXHAUST1 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_textbox.AppendText("> CABIN EXHAUST2 already switched ON" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Xf")
                    {
                        if (DeviceRelayID == "0") ConsoleLog_textbox.AppendText("> Undefined device switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_textbox.AppendText("> MAIN POWER switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_textbox.AppendText("> PELTIER 1 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_textbox.AppendText("> PELTIER 2 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_textbox.AppendText("> FLOOD COOLANT FAN switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_textbox.AppendText("> CS PUMP switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_textbox.AppendText("> HS PUMP switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_textbox.AppendText("> CABIN EXHAUST1 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_textbox.AppendText("> CABIN EXHAUST2 switched OFF" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Yf")
                    {
                        if (DeviceRelayID == "0") ConsoleLog_textbox.AppendText("> Undefined device already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_textbox.AppendText("> MAIN POWER already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_textbox.AppendText("> PELTIER 1 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_textbox.AppendText("> PELTIER 2 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_textbox.AppendText("> FLOOD COOLANT FAN already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_textbox.AppendText("> CS PUMP already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_textbox.AppendText("> HS PUMP already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_textbox.AppendText("> CABIN EXHAUST1 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_textbox.AppendText("> CABIN EXHAUST2 already switched OFF" + Environment.NewLine);
                    }

                }
                catch
                {
                    /* Do Nothing */
                }
            }

            // Dallas temperature data decode section (from X,Y,Z,E mot-sensors):
            // example data: [D22X35Y11Z32E] or [D14.55X23.56Y12.33Z14.12E]
            else if (_serialData.StartsWith("D"))
            {
                try
                {
                    IndexOfX = Convert.ToSByte(_serialData.IndexOf("X"));
                    IndexOfY = Convert.ToSByte(_serialData.IndexOf("Y"));
                    IndexOfZ = Convert.ToSByte(_serialData.IndexOf("Z"));
                    IndexOfE = Convert.ToSByte(_serialData.IndexOf("E"));

                    DTEMP_X = _serialData.Substring(1, IndexOfX - 1);   // x-axis motor temp
                    DTEMP_Y = _serialData.Substring(IndexOfX + 1, (IndexOfY - IndexOfX) - 1);   // y axis motor temp
                    DTEMP_Z = _serialData.Substring(IndexOfY + 1, (IndexOfZ - IndexOfY) - 1);   // z axis motor temp
                    DTEMP_E = _serialData.Substring(IndexOfZ + 1, (IndexOfE - IndexOfZ) - 1);   // extruder motor temp

                    SMT_X_circularProgressBar.Value = (int)Convert.ToDouble(DTEMP_X);
                    SMT_X_circularProgressBar.Text = DTEMP_X;
                    SMT_Y_circularProgressBar.Value = (int)Convert.ToDouble(DTEMP_Y);
                    SMT_Y_circularProgressBar.Text = DTEMP_Y;
                    SMT_Z_circularProgressBar.Value = (int)(Convert.ToDouble(DTEMP_Z));
                    SMT_Z_circularProgressBar.Text = DTEMP_Z;
                    SMT_E_circularProgressBar.Value = (int)Convert.ToDouble(DTEMP_E);
                    SMT_E_circularProgressBar.Text = DTEMP_E;
                }
                catch
                {
                    /* Do Nothing */
                }
            }

            // constant MCU-codes decode section (saves lots of Arduino-FLASH):
            // each MCU-Unique code indicates different messages from arduino, also does helps in changing UI appearence
            // example data: [M102] [K001] or [S304] etc...
            else if (_serialData.Equals("M101"))
            {
                ConsoleLog_textbox.AppendText("> [MCU I/O pin modes initiated]" + Environment.NewLine);
                DIS2.BackColor = Color.DarkBlue;
                DIS2.ForeColor = Color.White;
            }
            else if (_serialData.Equals("M102"))
            {
                ConsoleLog_textbox.AppendText("> [DS18B20 sensors initiated]" + Environment.NewLine);
                DIS6.BackColor = Color.DarkBlue;
                DIS6.ForeColor = Color.White;
            }
            else if (_serialData.Equals("M103"))
            {
                ConsoleLog_textbox.AppendText("> [Unable to initiated DS18B20 sensors]" + Environment.NewLine);
                DIS6.BackColor = Color.Maroon;
                DIS6.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("M104"))
            {
                ConsoleLog_textbox.AppendText("> [Serial COM started @" + _BAUDRATE + " successfully]" + Environment.NewLine);
                DIS1.BackColor = Color.DarkBlue;
                DIS1.ForeColor = Color.White;
            }
            else if (_serialData.Equals("P201"))
            {
                ConsoleLog_textbox.AppendText("> [Initializing PCF8574 module]" + Environment.NewLine);
                DIS4.BackColor = Color.Maroon;
                DIS4.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P202"))
            {
                ConsoleLog_textbox.AppendText("> [Successfully initialised PCF8574 module]" + Environment.NewLine);
                DIS4.BackColor = Color.DarkBlue;
                DIS4.ForeColor = Color.White;
            }
            else if (_serialData.Equals("P203"))
            {
                ConsoleLog_textbox.AppendText("> [PCF8574 I/O pins initiated]" + Environment.NewLine);
                DIS3.BackColor = Color.DarkBlue;
                DIS3.ForeColor = Color.White;
            }
            else if (_serialData.Equals("P204"))
            {
                ConsoleLog_textbox.AppendText("> [PCF8574 device error!]" + Environment.NewLine);
                DIS4.BackColor = Color.Maroon;
                DIS4.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("S101"))
            {
                ConsoleLog_textbox.AppendText("> [Auto initialised DS18B20 sensors]" + Environment.NewLine);
                DIS5.BackColor = Color.DarkBlue;
                DIS5.ForeColor = Color.White;
            }
            else if (_serialData.Equals("S102"))
            {
                ConsoleLog_textbox.AppendText("> [Pre-initialised DS18B20 sensors]" + Environment.NewLine);
                DIS5.BackColor = Color.Maroon;
                DIS5.ForeColor = Color.Yellow;
            }
        }

        private void CabinLight_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CabinLight_checkBox.Checked == true)
            {
                PCP_Indicator2.BackColor = Color.DarkGreen;
                CabinLight_checkBox.Text = "OFF";
            }
            else if (CabinLight_checkBox.Checked == false)
            {
                PCP_Indicator2.BackColor = Color.Maroon;
                CabinLight_checkBox.Text = "ON";
            }
        }

        private void ExhaustFanSpeed_trackBar_MouseDown(object sender, MouseEventArgs e)
        {
            InfoToolTip.Active = true;
            InfoToolTip.Show("Speed controller for Exhaust Fans: ARDUINO_PIN: ~9", ExhaustFanSpeed_trackBar);
        }

        private void ComPort_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionMsgBox_label.Text = "";
        }

        private void Peltier1_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier1_checkBox.Checked == true)
            {
                PCP_Indicator3.BackColor = Color.DarkGreen;
                Peltier1_checkBox.Text = "OFF";
            }
            else if (Peltier1_checkBox.Checked == false)
            {
                PCP_Indicator3.BackColor = Color.Maroon;
                Peltier1_checkBox.Text = "ON";
            }
        }

        private void Peltier2_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier2_checkBox.Checked == true)
            {
                PCP_Indicator4.BackColor = Color.DarkGreen;
                Peltier2_checkBox.Text = "OFF";
            }
            else if (Peltier2_checkBox.Checked == false)
            {
                PCP_Indicator4.BackColor = Color.Maroon;
                Peltier2_checkBox.Text = "ON";
            }
        }

        private void ClearBuffer_button_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.DiscardInBuffer();
                SerialPort1.DiscardOutBuffer();
            }
            catch
            {
                /* Do nothing */
            }
        }

        private void Hdcp_Devicelists_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDCPMsgbox_label.Text = "";
        }

        private void Hdcp_On_button_Click(object sender, EventArgs e)
        {
            if (HDCPDevicelist_Combobox.SelectedIndex == 0)
            {
                BeginInvoke(new EventHandler(HdcpGlobalOn_button_Click));
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 1)
            {
                DCS_indicator1.BackColor = Color.DarkGreen;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
                SerialPort1.WriteLine("A");
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 2)
            {
                DCS_indicator2.BackColor = Color.DarkGreen;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 3)
            {
                DCS_indicator3.BackColor = Color.DarkGreen;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 4)
            {
                DCS_indicator4.BackColor = Color.DarkGreen;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 5)
            {
                DCS_indicator5.BackColor = Color.DarkGreen;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 6)
            {
                DCS_indicator6.BackColor = Color.DarkGreen;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else
            {
                HDCPMsgbox_label.Text = "No devices selected!";
            }
        }

        public void Hdcp_Off_button_Click(object sender, EventArgs e)
        {
            if (HDCPDevicelist_Combobox.SelectedIndex == 0)
            {
                BeginInvoke(new EventHandler(HdcpGlobalOff_button_Click));
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 1)
            {
                DCS_indicator1.BackColor = Color.Maroon;
                SerialPort1.WriteLine("a");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 2)
            {
                DCS_indicator2.BackColor = Color.Maroon;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 3)
            {
                DCS_indicator3.BackColor = Color.Maroon;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 4)
            {
                DCS_indicator4.BackColor = Color.Maroon;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 5)
            {
                DCS_indicator5.BackColor = Color.Maroon;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 6)
            {
                DCS_indicator6.BackColor = Color.Maroon;
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else
            {
                HDCPMsgbox_label.Text = "No devices selected!";
            }
        }

        private void HdcpGlobalOn_button_Click(object sender, EventArgs e)
        {
            DCS_indicator1.BackColor = Color.DarkGreen;
            DCS_indicator2.BackColor = Color.DarkGreen;
            DCS_indicator3.BackColor = Color.DarkGreen;
            DCS_indicator4.BackColor = Color.DarkGreen;
            DCS_indicator5.BackColor = Color.DarkGreen;
            DCS_indicator6.BackColor = Color.DarkGreen;
            HDCPMsgbox_label.Text = "Switched ON all devices!";
        }

        private void HdcpGlobalOff_button_Click(object sender, EventArgs e)
        {
            DCS_indicator1.BackColor = Color.Maroon;
            DCS_indicator2.BackColor = Color.Maroon;
            DCS_indicator3.BackColor = Color.Maroon;
            DCS_indicator4.BackColor = Color.Maroon;
            DCS_indicator5.BackColor = Color.Maroon;
            DCS_indicator6.BackColor = Color.Maroon;
            HDCPMsgbox_label.Text = "Switched OFF all devices!";
        }

        private void ExhaustFanSpeed_trackBar_Scroll(object sender, EventArgs e)
        {
            ExhaustFanSpeed_numericUpDown.Value = ExhaustFanSpeed_trackBar.Value;
            // progressBar1.Value = ExhaustFanSpeed_trackBar.Value;
            BeginInvoke(new EventHandler(FanPwmEncoder));
        }

        private void CoolingFanSpeed_trackBar_Scroll(object sender, EventArgs e)
        {
            CoolingFanSpeed_numericUpDown.Value = CoolingFanSpeed_trackBar.Value;
        }

        private void ExhaustFanSpeed_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ExhaustFanSpeed_trackBar.Value = (int)ExhaustFanSpeed_numericUpDown.Value;
            BeginInvoke(new EventHandler(FanPwmEncoder));
        }

        private void CoolingFanSpeed_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CoolingFanSpeed_trackBar.Value = (int)CoolingFanSpeed_numericUpDown.Value;
        }

        /* PWM VALUE ENCODER SECTION */
        // delegate to convert percentage to pwm value. Encode pwm value and writes to
        // arduino serial. Example data: [s102d] or [s255d] or [s125.44d] -> pwm: 102, 255, 125 
        private void FanPwmEncoder(object sender, EventArgs e)
        {
            PWM = ((1.0f * ExhaustFanSpeed_trackBar.Value) / 100) * 255;
            if (SerialPort1.IsOpen)
            {
                SerialPort1.WriteLine("s" + PWM.ToString());
                ExhFanPWM_progressBar.Value = (int)PWM;

            }
            //ConsoleLog_textbox.Text= PWM.ToString();
        }

        private async void ConsoleClear_button_Click(object sender, EventArgs e)
        {
            ConsoleLog_textbox.Text = "";
            ClearConsoleTextBox_label.Text = "Console cleared successfully";
            await Task.Delay(4000);
            ClearConsoleTextBox_label.Text = "";
        }
    }
}
