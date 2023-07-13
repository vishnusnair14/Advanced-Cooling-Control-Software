using System;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
//using System.Windows.Input;

namespace Advanced_Cooling_Control_Software
{
    public partial class Main : Form
    {

        string _serialData;
        sbyte IndexOfA, IndexOfB, IndexOfC, IndexOfD;
        sbyte IndexOfSemicolon, IndexOfHash;
        sbyte IndexOfX, IndexOfY, IndexOfZ, IndexOfE;

        float PWM;
        // set your application access password here:
        readonly string AppAccessPasscode = "20222023v";
        string TEMP1, TEMP2, TEMP3, TEMP4;
        string DeviceRelayID, DeviceRelayState;
        string DTEMP_X, DTEMP_Y, DTEMP_Z, DTEMP_E;  //for dallas temperatures (X,Y,Z,E)

        string ArduinoPortDect;
        string _COMPORT, _BAUDRATE;
        int I2C_INIT_FLAG = 0;
        int I2C_CONN_FLAG = 0;

        private int preVal0 = 0;
        private int preVal1 = 0;
        private int preVal2 = 0;
        private int preVal3 = 0;
        private bool tickcolor = true;

        private Color c1, c2;
        private Control ctrl;

        private Color writeLogForeColor = Color.White;
        private Color writeLogBackColor = Color.Navy;

        private Color receiveLogForeColor = Color.White;
        private Color receiveLogBackColor = Color.DarkGreen;

        private short PBT1_flag = -1;
        private short PBT2_flag = -1;
        private short CT1_flag = -1;
        private short CT2_flag = -1;
        private short Xaxis_flag = -1;
        private short Yaxis_flag = -1;
        private short Zaxis_flag = -1;
        private short Extruder_flag = -1;

        private short BlinkAlert_PBT1_Count = 0;
        private short BlinkAlert_PBT2_Count = 0;
        private short BlinkAlert_CT1_Count = 0;
        private short BlinkAlert_CT2_Count = 0;
        private short BlinkAlert_Xaxis_Count = 0;
        private short BlinkAlert_Yaxis_Count = 0;
        private short BlinkAlert_Zaxis_Count = 0;
        private short BlinkAlert_Extruder_Count = 0;

        public TemperatureSettings ts;


        public Main()
        {
            InitializeComponent();
            InitializeFields();
        }


        private void InitializeFields()
        {
            ComPort_comboBox.Items.Clear();
            ComPort_comboBox.Items.AddRange(SerialPort.GetPortNames());

            Connect_button.Enabled = true;
            Disconnect_button.Enabled = false;
            Disconnect_button.BackColor = Color.LightSteelBlue;
            Disconnect_button.ForeColor = Color.White;
            SerialMonitor_richTextBox.Enabled = false;
            AutoConnect_checkBox.Checked = true;

            PCP_Indicator1.BackColor = Color.Maroon;
            PCP_Indicator2.BackColor = Color.Maroon;
            PCP_Indicator3.BackColor = Color.Maroon;
            PCP_Indicator4.BackColor = Color.Maroon;
            PCP_Indicator5.BackColor = Color.Maroon;
            PCP_Indicator6.BackColor = Color.Maroon;

            PBT1_circularProgressBar.Value = 1;
            PBT2_circularProgressBar.Value = 1;
            CT1_circularProgressBar.Value = 1;
            CT2_circularProgressBar.Value = 1;
            SMT_X_circularProgressBar.Value = 1;
            SMT_Y_circularProgressBar.Value = 1;
            SMT_Z_circularProgressBar.Value = 1;
            SMT_E_circularProgressBar.Value = 1;

            HighTempWarning_checkBox.Enabled = false;
            OpenTempSettings_button.Enabled = false;

            /*
            PBT1_circularProgressBar.Text = "";
            PBT2_circularProgressBar.Text = "";
            CT1_circularProgressBar.Text = "";
            CT2_circularProgressBar.Text = "";
            SMT_X_circularProgressBar.Text = "";
            SMT_Y_circularProgressBar.Text = "";
            SMT_Z_circularProgressBar.Text = "";
            SMT_E_circularProgressBar.Text = "";
            */

            FanSpeedControl_trackBar.Value = 0;
            FanSpeedControl_trackBar.Enabled = false;
            FanSpeedControl_numericUpDown.Value = 0;
            FanSpeedControl_numericUpDown.Enabled = false;

            HDCPOff_button.Enabled = false;
            HDCPOn_button.Enabled = false;
            HDCPDevicelist_Combobox.Enabled = false;
            HDCPMsgbox_label.Enabled = false;

            Conn_progressBar.Value = 0;

            MainPower_checkBox.Enabled = false;
            CabinLight_checkBox.Enabled = false;
            Peltier1_checkBox.Enabled = false;
            Peltier2_checkBox.Enabled = false;
            Peltier3_checkBox.Enabled = false;
            Peltier4_checkBox.Enabled = false;

            FanSpeedControl_numericUpDown.Enabled = false;
            FanSpeedControl_trackBar.Enabled = false;

            FanSpeedControlDeviceList_comboBox.Enabled = false;
            FanSpeedControlDeviceList_comboBox.SelectedIndex = 0;

            AN1_label.Visible = false;
            AN2_label.Visible = false;
            AN3_label.Visible = false;
            AN4_label.Visible = false;
        }


        private void ArduinoReset_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_SerialPort1.IsOpen)
                {
                    BeginInvoke(new EventHandler(ClearBuffer_button_Click));
                    SerialMonitor_richTextBox.Text = "";
                    ConsoleLog_richTextBox.Text = "";
                    ConsoleLog_richTextBox.AppendText("> [MSG: Connected to port: " + _COMPORT + " @" + _BAUDRATE + "]..." + Environment.NewLine);
                    DIS1.BackColor = SystemColors.ControlDarkDark;
                    DIS1.ForeColor = Color.White;
                    DIS2.BackColor = SystemColors.ControlDarkDark;
                    DIS2.ForeColor = Color.White;
                    DIS4.BackColor = SystemColors.ControlDarkDark;
                    DIS4.ForeColor = Color.White;
                    DIS3.BackColor = SystemColors.ControlDarkDark;
                    DIS3.ForeColor = Color.White;
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
                Main_SerialPort1.WriteLine("r");  // arduino software reset code:  'r' 
            }
            catch
            {
                ConnectionMsgBox_label.BackColor = Color.MidnightBlue;
                ConnectionMsgBox_label.ForeColor = SystemColors.HighlightText;
                ConnectionMsgBox_label.Text = "COM Port not connected!";
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Main_SerialPort1.Close();
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
                Main_SerialPort1.Close();
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
                ConnectionMsgBox_label.BackColor = Color.MidnightBlue;
                ConnectionMsgBox_label.ForeColor = SystemColors.HighlightText;
                ConnectionMsgBox_label.Text = "Unable to warning Arduino";
            }
            return null;
        }


        private void CheckArduinoComPort_button_Click(object sender, EventArgs e)
        {
            ComPort_comboBox.Items.Clear();
            ComPort_comboBox.Items.AddRange(SerialPort.GetPortNames());
            ArduinoPortDect = AutoDetectArduinoPort();
            if (string.IsNullOrEmpty(ArduinoPortDect) != true)
            {
                ConnectionMsgBox_label.Text = "Arduino warning @" + ArduinoPortDect;
                ComPort_comboBox.Text = ArduinoPortDect;
                BaudRate_comboBox.Text = "9600";
                if (AutoConnect_checkBox.Checked)
                {
                    BeginInvoke(new EventHandler(Connect_button_Click));
                }
            }
            else
            {
                ConnectionMsgBox_label.BackColor = Color.DarkSlateGray;
                ConnectionMsgBox_label.ForeColor = Color.White;
                ConnectionMsgBox_label.Text = "Arduino device not warning";
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
                            Conn_progressBar.Value = 10;
                            Main_SerialPort1.PortName = ComPort_comboBox.SelectedItem.ToString();
                            Main_SerialPort1.BaudRate = Convert.ToInt32(BaudRate_comboBox.SelectedItem);
                            _COMPORT = ComPort_comboBox.SelectedItem.ToString();
                            _BAUDRATE = BaudRate_comboBox.SelectedItem.ToString();
                            try
                            {
                                // connects to serial port:
                                Conn_progressBar.Value = 40;
                                Main_SerialPort1.Open();
                                Conn_progressBar.Value = 75;

                                consoleWrite("\nConnected: " + _COMPORT + " @" + _BAUDRATE);
                                consoleWrite("\n> [MSG: Connected to port @" + _COMPORT + "]");

                                // initial soft-reset:
                                connection_groupBox.ForeColor = Color.DarkGreen;
                                BeginInvoke(new EventHandler(ArduinoReset_button_Click));

                                // @SECTION [Connection Panel]
                                ConnectionMsgBox_label.ForeColor = Color.White;
                                ConnectionMsgBox_label.BackColor = Color.SeaGreen;
                                Conn_progressBar.Value = 77;
                                ConnectionMsgBox_label.Text = "Connected: " + _COMPORT + " @" + _BAUDRATE;

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
                                AutoConnect_checkBox.Enabled = false;
                                SerialMonitor_richTextBox.Enabled = true;

                                // @SECTION [Hardware Device Control : Main Power Control]
                                MainPower_checkBox.Enabled = true;
                                CabinLight_checkBox.Enabled = true;
                                Peltier1_checkBox.Enabled = true;
                                Peltier2_checkBox.Enabled = true;
                                Peltier3_checkBox.Enabled = true;
                                Peltier4_checkBox.Enabled = true;

                                MainPower_checkBox.BackColor = CabinLight_checkBox.BackColor =
                                Peltier1_checkBox.BackColor = Peltier2_checkBox.BackColor =
                                Peltier3_checkBox.BackColor = Peltier4_checkBox.BackColor = SystemColors.Highlight;

                                MainPower_checkBox.ForeColor = CabinLight_checkBox.ForeColor =
                                Peltier1_checkBox.ForeColor = Peltier2_checkBox.ForeColor =
                                Peltier3_checkBox.ForeColor = Peltier4_checkBox.ForeColor = Color.White;


                                // @SECTION [Hardware Device Control : Device Power Control]
                                HDCPOff_button.Enabled = true;
                                HDCPOn_button.Enabled = true;
                                HDCPDevicelist_Combobox.Enabled = true;
                                HDCPMsgbox_label.Enabled = true;

                                // @SECTION [Fan Speed Controls]
                                FanSpeedControlDeviceList_comboBox.Enabled = true;
                                FanSpeedControl_numericUpDown.Enabled = true;
                                FanSpeedControl_trackBar.Enabled = true;

                                // @SECTION [Serial Console]
                                Command_textBox.Enabled = true;
                                Send_button.Enabled = true;
                                Send_button.BackColor = SystemColors.Highlight;
                                Send_button.ForeColor = Color.White;
                                ConsoleLog_richTextBox.Enabled = true;

                                // @SECTION [Temperature Monitor]
                                HighTempWarning_checkBox.Enabled = true;
                                OpenTempSettings_button.Enabled = true;
                                Conn_progressBar.Value = 100;

                                try
                                {
                                    Control[] indicatorControlName = { CoolSideTM_label, HotSideTM_label, Tank1TM_label, Tank2TM_label, XAxisTM_label, YAxisTM_label, ZAxisTM_label, ExtruderTM_label };
                                    TemperatureSettings temperatureSettings = new TemperatureSettings(indicatorControlName);
                                    ts = temperatureSettings;
                                }
                                catch (Exception w)
                                {
                                    consoleWrite(w.ToString());
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Unable to establish connection with Port: " + _COMPORT, "COM Error");
                                connection_groupBox.ForeColor = Color.Maroon;
                            }
                        }
                        else
                        {
                            ConnectionMsgBox_label.BackColor = Color.MidnightBlue;
                            ConnectionMsgBox_label.ForeColor = SystemColors.HighlightText;
                            ConnectionMsgBox_label.Text = "Wrong passcode!";
                        }
                    }
                    else
                    {
                        ConnectionMsgBox_label.BackColor = Color.MidnightBlue;
                        ConnectionMsgBox_label.ForeColor = SystemColors.HighlightText;
                        ConnectionMsgBox_label.Text = "Please enter the passcode";
                    }
                }
                else
                {
                    ConnectionMsgBox_label.BackColor = Color.MidnightBlue;
                    ConnectionMsgBox_label.ForeColor = SystemColors.HighlightText;
                    ConnectionMsgBox_label.Text = "Please select Baud Rate";
                }
            }
            else
            {
                ConnectionMsgBox_label.BackColor = Color.MidnightBlue;
                ConnectionMsgBox_label.ForeColor = SystemColors.HighlightText;
                ConnectionMsgBox_label.Text = "Please select COM Port";
            }
        }


        private void Disconnect_button_Click(object sender, EventArgs e)
        {
            try
            {
                // set all PWM value to zero [ stops all coolant pwm fans]:
                Main_SerialPort1.WriteLine("sk0d");
                Main_SerialPort1.WriteLine("sl0d");
                Main_SerialPort1.WriteLine("sm0d");
                Main_SerialPort1.WriteLine("sn0d");

                // switch off all coolant/exhaust relays:


                // Disconnect serial COM:
                Main_SerialPort1.Close();

                // @SECTION [Connection Panel]
                connection_groupBox.ForeColor = Color.Maroon;
                Conn_progressBar.Value = 0;
                ConnectionMsgBox_label.ForeColor = Color.White;
                ConnectionMsgBox_label.BackColor = Color.DarkRed;
                ConnectionMsgBox_label.Text = "Disconnected: " + _COMPORT;
                SerialMonitor_groupBox.Text = "Data Monitor";
                SerialMonitor_richTextBox.Enabled = false;

                PBT1_circularProgressBar.Value = 1;
                PBT1_circularProgressBar.Text = "0.00 °C";
                PBT2_circularProgressBar.Value = 1;
                PBT2_circularProgressBar.Text = "0.00 °C";
                CT1_circularProgressBar.Value = 1;
                CT1_circularProgressBar.Text = "0.00 °C";
                CT2_circularProgressBar.Value = 1;
                CT2_circularProgressBar.Text = "0.00 °C";
                SerialMonitor_richTextBox.Text = "";
                ConsoleLog_richTextBox.Text = "";

                HighTempWarning_checkBox.Enabled = false;
                OpenTempSettings_button.Enabled = false;

                // *IMPORTANT* comment below line after debugging:
                Passcode_textBox.Text = AppAccessPasscode;

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
                CheckArduinoComPort_button.BackColor = SystemColors.InactiveBorder;

                MainPower_checkBox.Enabled = false;
                CabinLight_checkBox.Enabled = false;
                Peltier1_checkBox.Enabled = false;
                Peltier2_checkBox.Enabled = false;
                Peltier3_checkBox.Enabled = false;
                Peltier4_checkBox.Enabled = false;

                MainPower_checkBox.BackColor = CabinLight_checkBox.BackColor =
                Peltier1_checkBox.BackColor = Peltier2_checkBox.BackColor =
                Peltier3_checkBox.BackColor = Peltier4_checkBox.BackColor = Color.DarkGray;

                DIS1.BackColor = SystemColors.ControlDarkDark;
                DIS1.ForeColor = Color.White;
                DIS2.BackColor = SystemColors.ControlDarkDark;
                DIS2.ForeColor = Color.White;
                DIS4.BackColor = SystemColors.ControlDarkDark;
                DIS4.ForeColor = Color.White;
                DIS3.BackColor = SystemColors.ControlDarkDark;
                DIS3.ForeColor = Color.White;
                DIS5.BackColor = SystemColors.ControlDarkDark;
                DIS5.ForeColor = Color.White;
                DIS6.BackColor = SystemColors.ControlDarkDark;
                DIS6.ForeColor = Color.White;

                // @SECTION [Fan Speed Controls]
                FanSpeedControl_numericUpDown.Enabled = false;
                FanSpeedControl_trackBar.Enabled = false;
                FanSpeedControlDeviceList_comboBox.Enabled = false;

                FanSpeedControl_trackBar.Value = 0;
                FanSpeedControl_numericUpDown.Value = 0;

                AutoConnect_checkBox.Checked = false;
                AutoConnect_checkBox.Enabled = true;

                // ConsoleLog_richTextBox.Text = "> [MSG: Disconnected: port @" + _COMPORT + "]" + Environment.NewLine;
            }
            catch
            {
                ConnectionMsgBox_label.Text = "Unable to close conn. " + _COMPORT;
            }
        }


        // ***** ON SERIAL DATA RECIEVED *****
        private void Main_SerialPort1_serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                _serialData = Main_SerialPort1.ReadLine().Trim();
                // BeginInvoke(new EventHandler(SerialDataDecoder));
                SerialDataDecoder(_serialData);
                
                
                /*
                if (HighTempWarning_checkBox.Checked)
                {
                    HighTempAlert_WatchDog();
                }

                if (AdvSecurityFeature_checkBox.Checked)
                {
                    AdvSecurityFeature_WatchDog();
                    //Console.WriteLine("adv on recieve");
                }
                */
            }
            catch
            {
                /* Do Nothing */
            }
        }


        private void SerialPort_DataLog(string _data, char _type) //_type: [w, r]
        {
            if (_type == 'w' || _type == 'W')
            {
                ConsoleLog_richTextBox.SelectionStart = ConsoleLog_richTextBox.TextLength;
                ConsoleLog_richTextBox.SelectionLength = 0;
                ConsoleLog_richTextBox.SelectionColor = writeLogForeColor;
                ConsoleLog_richTextBox.SelectionBackColor = writeLogBackColor;
                ConsoleLog_richTextBox.AppendText(Environment.NewLine + _data + Environment.NewLine);
                ConsoleLog_richTextBox.SelectionColor = ConsoleLog_richTextBox.ForeColor;
                ConsoleLog_richTextBox.SelectionBackColor = ConsoleLog_richTextBox.BackColor;
            }
            else if (_type == 'r' || _type == 'R')
            {
                ConsoleLog_richTextBox.SelectionStart = ConsoleLog_richTextBox.TextLength;
                ConsoleLog_richTextBox.SelectionLength = 0;
                ConsoleLog_richTextBox.SelectionColor = receiveLogForeColor;
                ConsoleLog_richTextBox.SelectionBackColor = receiveLogBackColor;
                ConsoleLog_richTextBox.AppendText(Environment.NewLine + _data + Environment.NewLine);
                ConsoleLog_richTextBox.SelectionColor = ConsoleLog_richTextBox.ForeColor;
                ConsoleLog_richTextBox.SelectionBackColor = ConsoleLog_richTextBox.BackColor;
            }
        }


        /* SERIAL DATA DECODER SECTION */
        private void SerialDataDecoder(string _serialData)
        {
            // writes serial data to console log:
            SerialMonitor_richTextBox.AppendText(_serialData + Environment.NewLine);

            /*  TEMPERATURE DATA DECODE SECTION  (peltier block, coolant temp) */
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

                    ConsoleLog_richTextBox.AppendText(Environment.NewLine + "Peltier temp:- CS: " + TEMP1 + " | HS: " + TEMP2 + Environment.NewLine
                        + "Coolant temp:- TANK1: " + TEMP3 + " | TANK2: " + TEMP4 + Environment.NewLine + Environment.NewLine);
                }
                catch
                {
                    /* Do Nothing */
                }
            }

            /* RELAY CONTROL DATA DECODE SECTION */
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
                     FLAGS:
                     An : "switched ON"
                     Bn : "already switched ON"
                     Xf : "switched OFF"
                     Yf : "already switched OFF"  */

                    if (DeviceRelayState == "An")
                    {
                        // if matches with I2C RELAY  #1 ID's
                        if (DeviceRelayID == "0") ConsoleLog_richTextBox.AppendText("> Undefined device switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_richTextBox.AppendText("> PELTIER 1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_richTextBox.AppendText("> PELTIER 2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_richTextBox.AppendText("> PELTIER 3 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_richTextBox.AppendText("> PELTIER 4 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_richTextBox.AppendText("> AC BLOWER FAN FAN switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_richTextBox.AppendText("> RADIATOR FAN switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_richTextBox.AppendText("> HS WATER PUMP switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_richTextBox.AppendText("> CS WATER PUMP switched ON" + Environment.NewLine);
                        // if matches with I2C RELAY  #2 ID's
                        else if (DeviceRelayID == "21") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST IN #1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "22") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST OUT #1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "23") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST IN #2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "24") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST OUT #2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "25") ConsoleLog_richTextBox.AppendText("> CABIN LIGHT switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "26") ConsoleLog_richTextBox.AppendText("> NOCP#A switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "27") ConsoleLog_richTextBox.AppendText("> NOCP#B switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "28") ConsoleLog_richTextBox.AppendText("> NOCP#C switched ON" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Bn")
                    {
                        // if matches with I2C RELAY  #1 ID's
                        if (DeviceRelayID == "0") ConsoleLog_richTextBox.AppendText("> Undefined device switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_richTextBox.AppendText("> PELTIER 1 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_richTextBox.AppendText("> PELTIER 2 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_richTextBox.AppendText("> PELTIER 3 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_richTextBox.AppendText("> PELTIER 4 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_richTextBox.AppendText("> AC BLOWER FAN FAN already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_richTextBox.AppendText("> RADIATOR FAN already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_richTextBox.AppendText("> HS WATER PUMP already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_richTextBox.AppendText("> CS WATER PUMP already switched ON" + Environment.NewLine);
                        // if matches with I2C RELAY  #2 ID's
                        else if (DeviceRelayID == "21") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST IN #1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "22") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST OUT #1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "23") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST IN #2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "24") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST OUT #2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "25") ConsoleLog_richTextBox.AppendText("> CABIN LIGHT switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "26") ConsoleLog_richTextBox.AppendText("> NOCP#A switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "27") ConsoleLog_richTextBox.AppendText("> NOCP#B switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "28") ConsoleLog_richTextBox.AppendText("> NOCP#C switched ON" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Xf")
                    {
                        // if matches with I2C RELAY  #1 ID's
                        if (DeviceRelayID == "0") ConsoleLog_richTextBox.AppendText("> Undefined device switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_richTextBox.AppendText("> PELTIER 1 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_richTextBox.AppendText("> PELTIER 2 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_richTextBox.AppendText("> PELTIER 3 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_richTextBox.AppendText("> PELTIER 4 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_richTextBox.AppendText("> AC BLOWER FAN FAN switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_richTextBox.AppendText("> RADIATOR FAN switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_richTextBox.AppendText("> HS WATER PUMP switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_richTextBox.AppendText("> CS WATER PUMP switched OFF" + Environment.NewLine);
                        // if matches with I2C RELAY  #2 ID's
                        else if (DeviceRelayID == "21") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST IN #1 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "22") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST OUT #1 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "23") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST IN #2 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "24") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST OUT #2 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "25") ConsoleLog_richTextBox.AppendText("> CABIN LIGHT switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "26") ConsoleLog_richTextBox.AppendText("> NOCP#A switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "27") ConsoleLog_richTextBox.AppendText("> NOCP#B switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "28") ConsoleLog_richTextBox.AppendText("> NOCP#C switched OFF" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Yf")
                    {
                        // if matches with I2C RELAY  #1 ID's
                        if (DeviceRelayID == "0") ConsoleLog_richTextBox.AppendText("> Undefined device switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_richTextBox.AppendText("> PELTIER 1 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_richTextBox.AppendText("> PELTIER 2 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_richTextBox.AppendText("> PELTIER 3 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_richTextBox.AppendText("> PELTIER 4 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_richTextBox.AppendText("> AC BLOWER FAN FAN already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_richTextBox.AppendText("> RADIATOR FAN already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_richTextBox.AppendText("> HS WATER PUMP already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_richTextBox.AppendText("> CS WATER PUMP already switched OFF" + Environment.NewLine);
                        // if matches with I2C RELAY  #2 ID's
                        else if (DeviceRelayID == "21") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST IN #1 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "22") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST OUT #1 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "23") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST IN #2 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "24") ConsoleLog_richTextBox.AppendText("> CABIN EXHAUST OUT #2 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "25") ConsoleLog_richTextBox.AppendText("> CABIN LIGHT already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "26") ConsoleLog_richTextBox.AppendText("> NOCP#A already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "27") ConsoleLog_richTextBox.AppendText("> NOCP#B already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "28") ConsoleLog_richTextBox.AppendText("> NOCP#C already switched OFF" + Environment.NewLine);
                    }

                }
                catch
                {
                    /* Do Nothing */
                }
            }

            /* DALLAS TEMPERATURE DATA DECODE SECTION (from X,Y,Z,E mot-sensors) */
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

            /* CONSTANTS M-Code [message codes] DECODE SECTION (saves lots of Arduino-FLASH) */
            // each MCU-Unique code indicates different messages from arduino, also does helps in changing UI appearence
            // example data: [M102] [K001] or [S304] etc...
            else if (_serialData.Equals("M101"))
            {
                // ConsoleLog_richTextBox.AppendText("> [MCU I/O pin modes initiated]" + Environment.NewLine);
                SerialPort_DataLog("> [MCU I/O pin modes initiated]", 'r');
                DIS2.BackColor = Color.DarkBlue;
                DIS2.ForeColor = Color.White;
            }
            else if (_serialData.Equals("M102"))
            {
                //  ConsoleLog_richTextBox.AppendText("> [DS18B20 sensors initiated]" + Environment.NewLine);
                SerialPort_DataLog("> [DS18B20 sensors initiated]", 'r');
                DIS6.BackColor = Color.DarkBlue;
                DIS6.ForeColor = Color.White;
            }
            else if (_serialData.Equals("M103"))
            {
                // ConsoleLog_richTextBox.AppendText("> [Unable to initiated DS18B20 sensors]" + Environment.NewLine);
                SerialPort_DataLog("> [Unable to initiated DS18B20 sensors]", 'r');
                DIS6.BackColor = Color.Maroon;
                DIS6.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("M104"))
            {
                // ConsoleLog_richTextBox.AppendText("> [Serial COM started @" + _BAUDRATE + " successfully]" + Environment.NewLine);
                SerialPort_DataLog("> [Serial COM started @" + _BAUDRATE + " successfully]", 'r');
                DIS1.BackColor = Color.DarkBlue;
                DIS1.ForeColor = Color.White;
            }
            else if (_serialData.Equals("P201"))
            {
                // ConsoleLog_richTextBox.AppendText("> [Initializing PCF8574 module]" + Environment.NewLine);
                SerialPort_DataLog("> [Initializing PCF8574 module]", 'r');
                DIS3.BackColor = Color.Maroon;
                DIS3.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P202"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #1 module initialised]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C RELAY #1 module initialised]", 'r');
                DIS3A.BackColor = Color.DarkBlue;
                DIS3A.ForeColor = Color.White;
                I2C_INIT_FLAG++;
                BeginInvoke(new EventHandler(I2C_INIT_UI));
            }
            else if (_serialData.Equals("P203"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #1 I/O pins initiated]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C RELAY #1 I/O pins initiated]", 'r');
                DIS4A.BackColor = Color.DarkBlue;
                DIS4A.ForeColor = Color.White;
            }
            else if (_serialData.Equals("P204"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #1 device error!]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C RELAY #1 device error!]", 'r');
                DIS3A.BackColor = Color.Maroon;
                DIS3A.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P205"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #2 module initialised]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C RELAY #2 module initialised]", 'r');
                DIS3B.BackColor = Color.DarkBlue;
                DIS3B.ForeColor = Color.White;
                I2C_INIT_FLAG++;
                BeginInvoke(new EventHandler(I2C_INIT_UI));
            }
            else if (_serialData.Equals("P206"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C_RELAY #2 I/O pins initiated]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C_RELAY #2 I/O pins initiated]", 'r');
                DIS4B.BackColor = Color.DarkBlue;
                DIS4B.ForeColor = Color.White;
            }
            else if (_serialData.Equals("P207"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #2 device error!]" + Environment.NewLine);
                SerialPort_DataLog("> [MCU I/O pin modes initiated]", 'r');
                DIS3B.BackColor = Color.Maroon;
                DIS3B.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P208"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #1 CONNECTED]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C RELAY #1 CONNECTED]", 'r');
                DIS4A.BackColor = Color.DarkBlue;
                DIS4A.ForeColor = Color.White;
                I2C_CONN_FLAG++;
                BeginInvoke(new EventHandler(I2C_CONN_UI));
            }
            else if (_serialData.Equals("P209"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #1 DISCONNECTED!]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C RELAY #1 DISCONNECTED!]", 'r');
                DIS4A.BackColor = Color.Maroon;
                DIS4A.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P210"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #2 CONNECTED]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C RELAY #2 CONNECTED]", 'r');
                DIS4B.BackColor = Color.DarkBlue;
                DIS4B.ForeColor = Color.White;
                I2C_CONN_FLAG++;
                BeginInvoke(new EventHandler(I2C_CONN_UI));
            }
            else if (_serialData.Equals("P211"))
            {
                // ConsoleLog_richTextBox.AppendText("> [I2C RELAY #2 DISCONNECTED!]" + Environment.NewLine);
                SerialPort_DataLog("> [I2C RELAY #2 DISCONNECTED!]", 'r');
                DIS4B.BackColor = Color.Maroon;
                DIS4B.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("S101"))
            {
                // ConsoleLog_richTextBox.AppendText("> [Auto initialised DS18B20 sensors]" + Environment.NewLine);
                SerialPort_DataLog("> [Auto initialised DS18B20 sensors]", 'r');
                DIS5.BackColor = Color.DarkBlue;
                DIS5.ForeColor = Color.White;
            }
            else if (_serialData.Equals("S102"))
            {
                // ConsoleLog_richTextBox.AppendText("> [Pre-initialised DS18B20 sensors]" + Environment.NewLine);
                SerialPort_DataLog("> [Pre-initialised DS18B20 sensors]", 'r');
                DIS5.BackColor = Color.Maroon;
                DIS5.ForeColor = Color.Yellow;
            }
            // SerialMonitor_richTextBox.ScrollToCaret();
            // ConsoleLog_richTextBox.ScrollToCaret();
        }


        private void ExhaustFanSpeed_trackBar_Scroll(object sender, EventArgs e)
        {
            FanSpeedControl_numericUpDown.Value = FanSpeedControl_trackBar.Value;
            BeginInvoke(new EventHandler(FanPwmEncoder));
        }


        private void ExhaustFanSpeed_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FanSpeedControl_trackBar.Value = (int)FanSpeedControl_numericUpDown.Value;
            BeginInvoke(new EventHandler(FanPwmEncoder));
        }


        /* PWM VALUE ENCODE SECTION */
        // converts percentage to pwm value. Encode pwm value and writes to arduino serial.
        private void FanPwmEncoder(object sender, EventArgs e)
        {
            PWM = (1.0f * FanSpeedControl_trackBar.Value) / 100 * 255;
            if (Main_SerialPort1.IsOpen)
            {
                if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 0)
                {
                    Main_SerialPort1.WriteLine("sk" + PWM.ToString());
                    SerialMonitor_richTextBox.AppendText("sk" + PWM.ToString() + Environment.NewLine);
                    preVal0 = FanSpeedControl_trackBar.Value;
                }
                else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 1)
                {
                    Main_SerialPort1.WriteLine("sl" + PWM.ToString());
                    SerialMonitor_richTextBox.AppendText("sl" + PWM.ToString() + Environment.NewLine);
                    preVal1 = FanSpeedControl_trackBar.Value;
                }
                else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 2)
                {
                    Main_SerialPort1.WriteLine("sm" + PWM.ToString());
                    SerialMonitor_richTextBox.AppendText("sm" + PWM.ToString() + Environment.NewLine);
                    preVal2 = FanSpeedControl_trackBar.Value;
                }
                else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 3)
                {
                    Main_SerialPort1.WriteLine("sn" + PWM.ToString());
                    SerialMonitor_richTextBox.AppendText("sn" + PWM.ToString() + Environment.NewLine);
                    preVal3 = FanSpeedControl_trackBar.Value;
                }
            }
        }


        private void FanSpeedControl_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selVal = FanSpeedControlDeviceList_comboBox.SelectedIndex;

            FanSpeedControl_Label.Text = "Adjust " + FanSpeedControlDeviceList_comboBox.Text + " fan speed";

            if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 0)
            {
                FanSpeedControl_trackBar.Value = preVal0;
                FanSpeedControl_numericUpDown.Value = preVal0;
            }
            else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 1)
            {
                FanSpeedControl_trackBar.Value = preVal1;
                FanSpeedControl_numericUpDown.Value = preVal1;
            }
            else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 2)
            {
                FanSpeedControl_trackBar.Value = preVal2;
                FanSpeedControl_numericUpDown.Value = preVal2;
            }
            else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 3)
            {
                FanSpeedControl_trackBar.Value = preVal3;
                FanSpeedControl_numericUpDown.Value = preVal3;
            }
        }


        private void I2C_CONN_UI(object sender, EventArgs e)
        {
            if (I2C_CONN_FLAG == 0)
            {
                DIS4.BackColor = Color.Maroon;
                DIS4.ForeColor = Color.Yellow;
            }
            else if (I2C_CONN_FLAG == 1)
            {
                DIS4.BackColor = Color.Goldenrod;
                DIS4.ForeColor = Color.Snow;
            }
            else if (I2C_CONN_FLAG == 2)
            {
                DIS4.BackColor = Color.SeaGreen;
                DIS4.ForeColor = Color.Snow;
            }
            else
            {
                DIS4.BackColor = Color.Maroon;
                DIS4.ForeColor = Color.Yellow;
            }
        }


        private void I2C_INIT_UI(object sender, EventArgs e)
        {
            if (I2C_INIT_FLAG == 0)
            {
                DIS3.BackColor = Color.Maroon;
                DIS3.ForeColor = Color.Yellow;
            }
            else if (I2C_INIT_FLAG == 1)
            {
                DIS3.BackColor = Color.Goldenrod;
                DIS3.ForeColor = Color.Snow;
            }
            else if (I2C_INIT_FLAG == 2)
            {
                DIS3.BackColor = Color.SeaGreen;
                DIS3.ForeColor = Color.Snow;
            }
            else
            {
                DIS3.BackColor = Color.Maroon;
                DIS3.ForeColor = Color.Yellow;
            }
        }


        private string DecodeCommandFromFile(string _cmd)
        {
            Decode getCode = new Decode();
            return getCode.SearchCmdInDict(_cmd);
        }


        private async void Send_button_Click(object sender, EventArgs e)
        {
            if (SentCommandToArduino.SentCommandDirectly_checkState)
            {
                if (Main_SerialPort1.IsOpen)
                {
                    if (Command_textBox.Text.Length != 0)
                    {
                        try
                        {
                            Main_SerialPort1.WriteLine(Command_textBox.Text);
                            ClearConsoleTextBox_label.Text = "command sent successful";
                        }
                        catch
                        {
                            ClearConsoleTextBox_label.Text = "unable to sent command!";
                        }

                        //ConsoleLog_textbox.Text = DecodeCommandFromFile(Command_textBox.Text);
                    }

                    else
                    {
                        ClearConsoleTextBox_label.Text = "No commands specified!";
                        await Task.Delay(4000);
                        ClearConsoleTextBox_label.Text = "";
                    }
                }
                else
                {
                    ClearConsoleTextBox_label.Text = "Serial port closed!";
                    await Task.Delay(4000);
                    ClearConsoleTextBox_label.Text = "";
                }
            }
        }


        private void SoftwareInfo_MenuItem_Click(object sender, EventArgs e)
        {
            //Form2 container = new Form2();
            CommandOptions commandOptions = new CommandOptions(Main_SerialPort1);
            //cw.MdiParent = this;
            commandOptions.ShowDialog();
        }


        private void About_MenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();  // Form2: About.cs
            about.Show();
        }


        private void Exit_MenuItem_Click(object sender, EventArgs e)
        {
            if (Main_SerialPort1.IsOpen)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Serial port is connected. Do you want to close anyway?", "Confirmation", buttons);
                if (result == DialogResult.Yes)
                {
                    Main_SerialPort1.Close();
                    consoleWrite("\nSerial port closed success");
                    Close();
                }
                else
                {
                    consoleWrite("\n\ndialog button clicked: " + DialogResult);
                }
            }
            else
            {
                Close();
            }
        }


        private void CommandOptions_MenuItem_Click(object sender, EventArgs e)
        {
            CommandOptions commandContainer = new CommandOptions(Main_SerialPort1);
            commandContainer.ShowDialog();
        }


        private void TemperatureSettings_MenuItem_Click(object sender, EventArgs e)
        {
            ts.ShowDialog();
        }


        private void SystemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemInformation systeminfohelper = new SystemInformation();
            systeminfohelper.Show();
        }


        private void SerialMonitor_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void ExhaustFanSpeed_trackBar_MouseDown(object sender, MouseEventArgs e)
        {
            InfoToolTip.Active = true;
            InfoToolTip.Show("Speed controller for Exhaust Fans: ARDUINO_PIN: ~9", FanSpeedControl_trackBar);
        }


        private void ComPort_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionMsgBox_label.Text = "";
        }


        // ---------------------------------------------------------------------------------------------------
        // HIGH TEMPEARATURE ALERT ANIMATION SECTION [~ main]
        //
        private void BlinkTimer1_Tick(object sender, EventArgs e)
        {

            if (tickcolor)
            {
                ctrl.BackColor = c1;
                ctrl.ForeColor = c2;
            }
            if (!tickcolor)
            {
                ctrl.BackColor = c2;
                ctrl.ForeColor = c1;
            }
            tickcolor = !tickcolor;
        }


        // NORMAL BLINK FUNCION:
        private void StandardBlink(Control _ctrl, Color _c1, Color _c2, int _interval)
        {
            c1 = _c1; c2 = _c2; ctrl = _ctrl;
            BlinkTimer1.Interval = _interval;
            BlinkTimer1.Start();
            // ctrl.Focus();
        }


        private async void HighTempBlinkAlert(string _id, Control ctrl, Color c1, Color c2, short CycleTime_ms, bool BkClr)
        {
            _id = _id.ToUpper();
            if (_id == "PBT1")
            {
                BlinkAlert_PBT1_Count++;
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (PBT1_circularProgressBar.Value >= TemperatureSettings.CoolSideMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    PBT1_flag = 1;
                    ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                    ctrl.Text = TemperatureSettings.HighTempAlertText;
                    await Task.Delay(1);
                    var n = _sw.ElapsedMilliseconds % CycleTime_ms;
                    var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                    var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                    var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                    var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                    var clr = Color.FromArgb(red, grn, blw);
                    if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
                }
                _sw.Stop();
                PBT1_flag = 0;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "COOL SIDE";
            }
            else if (_id == "PBT2")
            {
                BlinkAlert_PBT2_Count++;
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (PBT2_circularProgressBar.Value >= TemperatureSettings.HotSideMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    PBT2_flag = 1;
                    ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                    ctrl.Text = TemperatureSettings.HighTempAlertText;
                    await Task.Delay(1);
                    var n = _sw.ElapsedMilliseconds % CycleTime_ms;
                    var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                    var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                    var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                    var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                    var clr = Color.FromArgb(red, grn, blw);
                    if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
                }
                _sw.Stop();
                PBT2_flag = 0;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "HOT SIDE";
            }
            else if (_id == "CT1")
            {
                BlinkAlert_CT1_Count++;
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (CT1_circularProgressBar.Value >= TemperatureSettings.Tank1MaxTemp && HighTempWarning_checkBox.Checked)
                {
                    CT1_flag = 1;
                    ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                    ctrl.Text = TemperatureSettings.HighTempAlertText;
                    await Task.Delay(1);
                    var n = _sw.ElapsedMilliseconds % CycleTime_ms;
                    var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                    var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                    var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                    var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                    var clr = Color.FromArgb(red, grn, blw);
                    if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
                }
                _sw.Stop();
                CT1_flag = 0;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "TANK 1";
            }
            else if (_id == "CT2")
            {
                BlinkAlert_CT2_Count++;
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (CT2_circularProgressBar.Value >= TemperatureSettings.Tank2MaxTemp && HighTempWarning_checkBox.Checked)
                {
                    CT2_flag = 1;
                    ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                    ctrl.Text = TemperatureSettings.HighTempAlertText;
                    await Task.Delay(1);
                    var n = _sw.ElapsedMilliseconds % CycleTime_ms;
                    var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                    var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                    var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                    var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                    var clr = Color.FromArgb(red, grn, blw);
                    if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
                }
                _sw.Stop();
                CT2_flag = 0;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "TANK 2";
            }
            else if (_id == "XAxis_SM")
            {
                BlinkAlert_Xaxis_Count++;
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (SMT_X_circularProgressBar.Value >= TemperatureSettings.XaxisMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    Xaxis_flag = 1;
                    ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                    ctrl.Text = TemperatureSettings.HighTempAlertText;
                    await Task.Delay(1);
                    var n = _sw.ElapsedMilliseconds % CycleTime_ms;
                    var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                    var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                    var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                    var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                    var clr = Color.FromArgb(red, grn, blw);
                    if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
                }
                _sw.Stop();
                Xaxis_flag = 0;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "X-AXIS";
            }
            else if (_id == "YAxis_SM")
            {
                BlinkAlert_Yaxis_Count++;
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (SMT_Y_circularProgressBar.Value >= TemperatureSettings.YaxisMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    Yaxis_flag = 1;
                    ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                    ctrl.Text = TemperatureSettings.HighTempAlertText;
                    await Task.Delay(1);
                    var n = _sw.ElapsedMilliseconds % CycleTime_ms;
                    var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                    var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                    var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                    var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                    var clr = Color.FromArgb(red, grn, blw);
                    if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
                }
                _sw.Stop();
                Yaxis_flag = 0;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "Y-AXIS";
            }
            else if (_id == "ZAxis_SM")
            {
                BlinkAlert_Zaxis_Count++;
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (SMT_Z_circularProgressBar.Value >= TemperatureSettings.ZaxisMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    Zaxis_flag = 1;
                    ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                    ctrl.Text = TemperatureSettings.HighTempAlertText;
                    await Task.Delay(1);
                    var n = _sw.ElapsedMilliseconds % CycleTime_ms;
                    var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                    var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                    var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                    var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                    var clr = Color.FromArgb(red, grn, blw);
                    if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
                }
                _sw.Stop();
                Zaxis_flag = 0;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "Z-AXIS";
            }
            else if (_id == "Extruder_SM")
            {
                BlinkAlert_Extruder_Count++;
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (SMT_E_circularProgressBar.Value >= TemperatureSettings.ExtruderMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    Extruder_flag = 1;
                    ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                    ctrl.Text = TemperatureSettings.HighTempAlertText;
                    await Task.Delay(1);
                    var n = _sw.ElapsedMilliseconds % CycleTime_ms;
                    var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                    var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                    var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                    var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                    var clr = Color.FromArgb(red, grn, blw);
                    if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
                }
                _sw.Stop();
                Extruder_flag = 0;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "EXTRUDER";
            }
        }


        private void HighTempWarning_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HighTempWarning_checkBox.Checked)
            {
                HighTempWarning_checkBox.BackColor = SystemColors.Highlight;
                HighTempWarning_checkBox.ForeColor = Color.White;

                HighTempAlert_watchTimer.Interval = 100;
                HighTempAlert_watchTimer.Start();
                consoleWrite("\n[HighTemperatureAlert_watchTimer: STARTED]");
            }
            else if (!HighTempWarning_checkBox.Checked)
            {
                BlinkAlert_PBT1_Count = 0;
                BlinkAlert_PBT2_Count = 0;
                BlinkAlert_CT1_Count = 0;
                BlinkAlert_CT2_Count = 0;
                BlinkAlert_Xaxis_Count = 0;
                BlinkAlert_Yaxis_Count = 0;
                BlinkAlert_Zaxis_Count = 0;

                HighTempWarning_checkBox.BackColor = Color.DarkRed;
                HighTempWarning_checkBox.ForeColor = Color.White;

                HighTempAlert_watchTimer.Stop();
                consoleWrite("\n[HighTemperatureAlert_watchTimer: STOPPED!]", ConsoleColor.DarkRed);
            }
        }


        private void HighTempAlert_watchTimer_Tick(object sender, EventArgs e)
        {
            HighTempAlert_WatchDog();
        }


        private void HighTempAlert_WatchDog()
        {
            if (PBT1_circularProgressBar.Value >= TemperatureSettings.CoolSideMaxTemp)
            {
                if (PBT1_flag == -1 /*@on-start*/ || PBT1_flag == 0)
                {
                    consoleWrite("[PBT1-(high-temp-warning-count): " + (BlinkAlert_PBT1_Count + 1) + "]", ConsoleColor.DarkYellow);
                    // BlinkAlert_PBT1_Count+= BlinkAlert_PBT1_Count;
                    HighTempBlinkAlert("PBT1", CoolSideTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (PBT2_circularProgressBar.Value >= TemperatureSettings.HotSideMaxTemp)
            {
                if (PBT2_flag == -1 || PBT2_flag == 0)
                {
                    consoleWrite("[PBT2-(high-temp-warning-count): " + (BlinkAlert_PBT2_Count + 1) + "]", ConsoleColor.DarkBlue);
                    // BlinkAlert_PBT2_Count+= BlinkAlert_PBT2_Count;
                    HighTempBlinkAlert("PBT2", HotSideTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (CT1_circularProgressBar.Value >= TemperatureSettings.Tank1MaxTemp)
            {
                if (CT1_flag == -1 || CT1_flag == 0)
                {
                    consoleWrite("[CT1-(high-temp-warning-count): " + (BlinkAlert_CT1_Count + 1) + "]", ConsoleColor.DarkRed);
                    // BlinkAlert_CT1_Count+= BlinkAlert_CT1_Count;
                    HighTempBlinkAlert("CT1", Tank1TM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (CT2_circularProgressBar.Value >= TemperatureSettings.Tank2MaxTemp)
            {
                if (CT2_flag == -1 || CT2_flag == 0)
                {
                    consoleWrite("[CT2-(high-temp-warning-count): " + (BlinkAlert_CT2_Count + 1) + "]", ConsoleColor.DarkGreen);
                    // BlinkAlert_CT2_Count+= BlinkAlert_CT2_Count;
                    HighTempBlinkAlert("CT2", Tank2TM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (SMT_X_circularProgressBar.Value >= TemperatureSettings.XaxisMaxTemp)
            {
                if (Xaxis_flag == -1 || Xaxis_flag == 0)
                {
                    consoleWrite("[X_Axis_SM-(high-temp-warning-count): " + (BlinkAlert_Xaxis_Count + 1) + "]");
                    // BlinkAlert_Xaxis_Count+= BlinkAlert_Xaxis_Count;
                    HighTempBlinkAlert("XAxis_SM", XAxisTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (SMT_Y_circularProgressBar.Value >= TemperatureSettings.YaxisMaxTemp)
            {
                if (Yaxis_flag == -1 || Yaxis_flag == 0)
                {
                    consoleWrite("[Y_Axis_SM-(high-temp-warning-count): " + (BlinkAlert_Yaxis_Count + 1) + "]");
                    // BlinkAlert_Yaxis_Count+= BlinkAlert_Yaxis_Count;
                    HighTempBlinkAlert("YAxis_SM", YAxisTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (SMT_Z_circularProgressBar.Value >= TemperatureSettings.ZaxisMaxTemp)
            {
                if (Zaxis_flag == -1 || Zaxis_flag == 0)
                {
                    consoleWrite("[Z_Axis_SM-(high-temp-warning-count): " + (BlinkAlert_Zaxis_Count + 1) + "]");
                    // BlinkAlert_Zaxis_Count+= BlinkAlert_Zaxis_Count;
                    HighTempBlinkAlert("ZAxis_SM", ZAxisTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (SMT_E_circularProgressBar.Value >= TemperatureSettings.ExtruderMaxTemp)
            {
                if (Extruder_flag == -1 || Extruder_flag == 0)
                {
                    consoleWrite("[Extruder_SM-(high-temp-warning-count): " + (BlinkAlert_Extruder_Count + 1) + "]");
                    // BlinkAlert_Extruder_Count+= BlinkAlert_Extruder_Count;
                    HighTempBlinkAlert("Extruder_SM", ExtruderTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }
        }


        private void ExecuteAutoFeatureCommand(string _id, string _cmd)
        {
            if (Main_SerialPort1.IsOpen)
            {
                try
                {
                    Main_SerialPort1.Write(_cmd);
                    consoleWrite("\n[(auto-security-feature triggered) cmd execute success (id: " + _id + ", cmd: " + _cmd + ")]\n", ConsoleColor.DarkGreen);
                    // consoleWrite("\n[(auto-security-feature triggered) cmd execute success (id: " + _id + ", cmd: " + _cmd + ")]\n");
                }
                catch
                {
                    consoleWrite("\n[(auto-security-feature triggered) cmd EXECUTE FAILED! (id: " + _id + ", cmd: " + _cmd + ")]\n", ConsoleColor.DarkRed);
                }
            }
            else
            {
                consoleWrite("\n[(auto-security-feature triggered but PORT CLOSED! (for id: " + _id + " cmd: " + _cmd + ")]\n", ConsoleColor.DarkRed);
            }
        }

        /*
        private bool EAFC_PBT1_flag = false;
        private bool EAFC_PBT2_flag = false;
        private bool EAFC_CT1_flag = false;
        private bool EAFC_CT2_flag = false;
        */


        private void AdvancedSecurityFeature_watchTimer_Tick(object sender, EventArgs e)
        {
            if (AdvSecurityFeature_checkBox.Checked)
            {
                AdvSecurityFeature_WatchDog();
            }
        }


        private void AdvSecurityFeature_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!AdvSecurityFeature_checkBox.Checked)
            {

                BlinkAlert_PBT1_Count = 0;
                BlinkAlert_PBT2_Count = 0;
                BlinkAlert_CT1_Count = 0;
                BlinkAlert_CT2_Count = 0;
                BlinkAlert_Xaxis_Count = 0;
                BlinkAlert_Yaxis_Count = 0;
                BlinkAlert_Zaxis_Count = 0;
                BlinkAlert_Extruder_Count = 0;


                AdvancedSecurityFeature_watchTimer.Stop();
                consoleWrite("\n[AdvancedSecurityFeature_watchTimer: STOPPED!]", ConsoleColor.DarkRed);
            }
            else
            {
                if (HighTempWarning_checkBox.Checked)
                {
                    AdvancedSecurityFeature_watchTimer.Interval = 100;
                    AdvancedSecurityFeature_watchTimer.Start();
                    consoleWrite("\n[AdvancedSecurityFeature_watchTimer: STARTED]");
                }
            }
        }



        private void AdvSecurityFeature_WatchDog()   // command executor
        {
            if (BlinkAlert_PBT1_Count > TemperatureSettings.ASF_TRIGGER_COUNT)
            {
                AN1_label.Enabled = true;
                AN1_label.Visible = true;
                AN1_label.Text = TemperatureSettings.AN1_label;  // AN_label -> Advance Notification Label
                AN1_label.BackColor = Color.DarkRed;
                AN1_label.ForeColor = Color.Yellow;

                ExecuteAutoFeatureCommand("PBT1", TemperatureSettings.ASFCommand_PBT1);
                BlinkAlert_PBT1_Count = 0;

                SSD_PBT1_label.Visible = true;
            }
            if (BlinkAlert_PBT2_Count > TemperatureSettings.ASF_TRIGGER_COUNT)
            {
                AN2_label.Enabled = true;
                AN2_label.Visible = true;
                AN2_label.Text = TemperatureSettings.AN2_label;
                AN2_label.BackColor = Color.DarkRed;
                AN2_label.ForeColor = Color.Yellow;

                ExecuteAutoFeatureCommand("PBT2", TemperatureSettings.ASFCommand_PBT2);
                BlinkAlert_PBT2_Count = 0;

                SSD_PBT2_label.Visible = true;
            }
            if (BlinkAlert_CT1_Count > TemperatureSettings.ASF_TRIGGER_COUNT)
            {
                AN3_label.Enabled = true;
                AN3_label.Visible = true;
                AN3_label.Text = TemperatureSettings.AN3_label;
                AN3_label.BackColor = Color.DarkRed;
                AN3_label.ForeColor = Color.Yellow;

                ExecuteAutoFeatureCommand("CT1", TemperatureSettings.ASFCommand_CT1);
                BlinkAlert_CT1_Count = 0;

                SSD_PBT3_label.Visible = true;
            }
            if (BlinkAlert_CT2_Count > TemperatureSettings.ASF_TRIGGER_COUNT)
            {
                AN4_label.Enabled = true;
                AN4_label.Visible = true;
                AN4_label.Text = TemperatureSettings.AN4_label;
                AN4_label.BackColor = Color.DarkRed;
                AN4_label.ForeColor = Color.Yellow;

                ExecuteAutoFeatureCommand("CT2", TemperatureSettings.ASFCommand_CT2);
                BlinkAlert_CT2_Count = 0;

                SSD_PBT4_label.Visible = true;
            }
        }


        private async void ResetAllSystems_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ResetAllSystems_checkBox.Checked)
            {
                // @RESET-START (on-resetting...)
                {
                    ResetAllSystems_checkBox.Text = "Please wait...";
                    ResetAllSystems_checkBox.BackColor = Color.OrangeRed;
                    ResetAllSystems_checkBox.ForeColor = Color.White;
                    await Task.Delay(2500);
                    ResetAllSystems_checkBox.BackColor = Color.Gold;
                    ResetAllSystems_checkBox.ForeColor = Color.DarkRed;
                    ResetAllSystems_checkBox.Text = "Restarting all systems...";
                    await Task.Delay(2700);

                    // perform restart-command
                    consoleWrite("OnPerformRestartSystem: CALLED");
                    OnPerformRestartSystem();
                    consoleWrite("OnPerformRestartSystem: ENDED!");
                }


                // @ON-SUCCESS
                {
                    ResetAllSystems_checkBox.Text = "Reset successful";
                    ResetAllSystems_checkBox.BackColor = Color.DarkGreen;
                    ResetAllSystems_checkBox.ForeColor = Color.White;
                    await Task.Delay(1750);
                    // back to normal state
                    ResetAllSystems_checkBox.Text = "Reset all systems";
                    ResetAllSystems_checkBox.BackColor = SystemColors.Highlight;
                    ResetAllSystems_checkBox.ForeColor = Color.White;
                }
                ResetAllSystems_checkBox.Checked = false;
            }
            else
            {
                consoleWrite("[ [ResetAllSystems_checkBox.checked: false\n[back to normal state] ]");
            }
        }


        private void OnPerformRestartSystem()
        {
            SSD_PBT1_label.Visible = false;
            SSD_PBT2_label.Visible = false;
                SSD_PBT3_label.Visible = false;
            SSD_PBT4_label.Visible = false;

            // perform/call reverse-command-function (commands to restart shutdown systems)
            BlinkAlert_PBT1_Count = 0;
            BlinkAlert_PBT2_Count = 0;
            BlinkAlert_CT1_Count = 0;
            BlinkAlert_CT2_Count = 0;
            BlinkAlert_Xaxis_Count = 0;
            BlinkAlert_Yaxis_Count = 0;
            BlinkAlert_Zaxis_Count = 0;
            BlinkAlert_Extruder_Count = 0;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(CheckArduinoComPort_button_Click));
        }


        private async void SerialMonitor_richTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SerialMonitor_richTextBox.Text.Length != 0)
            {
                SerialMonitor_richTextBox.Text = "";
                SerialMonitor_groupBox.ForeColor = Color.Maroon;
                SerialMonitor_groupBox.Text = "console cleared!";
                await Task.Delay(1750);
                SerialMonitor_groupBox.ForeColor = SystemColors.ControlLightLight;
                SerialMonitor_groupBox.Text = "Data Monitor" + " [ " + _COMPORT + " @" + _BAUDRATE + " ]";
            }
        }


        private void ConsoleLog_richTextBox_TextChanged(object sender, EventArgs e)
        {
            ConsoleLog_richTextBox.ScrollToCaret();
        }


        private void SerialMonitor_richTextBox_TextChanged(object sender, EventArgs e)
        {
            SerialMonitor_richTextBox.ScrollToCaret();
        }


        private void OpenTempSettings_button_Click(object sender, EventArgs e)
        {

            BeginInvoke(new EventHandler(TemperatureSettings_MenuItem_Click));
        }


        private void MainPower_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MainPower_checkBox.Checked == true)
            {
                PCP_Indicator1.BackColor = Color.DarkGreen;
                MainPower_checkBox.Text = "OFF";
                MainPower_checkBox.ForeColor = Color.White;
                MainPower_checkBox.BackColor = Color.DarkRed;
            }
            else if (MainPower_checkBox.Checked == false)
            {
                PCP_Indicator1.BackColor = Color.Maroon;
                MainPower_checkBox.Text = "ON";
                MainPower_checkBox.ForeColor = Color.White;
                MainPower_checkBox.BackColor = SystemColors.Highlight;
            }
        }


        private void CabinLight_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CabinLight_checkBox.Checked == true)
            {
                PCP_Indicator2.BackColor = Color.DarkGreen;
                CabinLight_checkBox.Text = "OFF";
                Main_SerialPort1.WriteLine("DN201");
                CabinLight_checkBox.ForeColor = Color.White;
                CabinLight_checkBox.BackColor = Color.DarkRed;
            }
            else if (CabinLight_checkBox.Checked == false)
            {
                PCP_Indicator2.BackColor = Color.Maroon;
                CabinLight_checkBox.Text = "ON";
                Main_SerialPort1.WriteLine("DF201");
                CabinLight_checkBox.ForeColor = Color.White;
                CabinLight_checkBox.BackColor = SystemColors.Highlight;
            }
        }


        private void Peltier1_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier1_checkBox.Checked == true)
            {
                PCP_Indicator3.BackColor = Color.DarkGreen;
                Peltier1_checkBox.Text = "OFF";
                Main_SerialPort1.WriteLine("DN101");
                Peltier1_checkBox.ForeColor = Color.White;
                Peltier1_checkBox.BackColor = Color.DarkRed;
            }
            else if (Peltier1_checkBox.Checked == false)
            {
                PCP_Indicator3.BackColor = Color.Maroon;
                Peltier1_checkBox.Text = "ON";
                Main_SerialPort1.WriteLine("DF101");
                Peltier1_checkBox.ForeColor = Color.White;
                Peltier1_checkBox.BackColor = SystemColors.Highlight;
            }
        }


        private void Peltier2_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier2_checkBox.Checked == true)
            {
                PCP_Indicator4.BackColor = Color.DarkGreen;
                Peltier2_checkBox.Text = "OFF";
                Main_SerialPort1.WriteLine("DN102");
                Peltier2_checkBox.ForeColor = Color.White;
                Peltier2_checkBox.BackColor = Color.DarkRed;
            }
            else if (Peltier2_checkBox.Checked == false)
            {
                PCP_Indicator4.BackColor = Color.Maroon;
                Peltier2_checkBox.Text = "ON";
                Main_SerialPort1.WriteLine("DF102");
                Peltier2_checkBox.ForeColor = Color.White;
                Peltier2_checkBox.BackColor = SystemColors.Highlight;
            }
        }


        private void Peltier3_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier3_checkBox.Checked == true)
            {
                PCP_Indicator5.BackColor = Color.DarkGreen;
                Peltier3_checkBox.Text = "OFF";
                Main_SerialPort1.WriteLine("DN103");
                Peltier3_checkBox.ForeColor = Color.White;
                Peltier3_checkBox.BackColor = Color.DarkRed;
            }
            else if (Peltier3_checkBox.Checked == false)
            {
                PCP_Indicator5.BackColor = Color.Maroon;
                Peltier3_checkBox.Text = "ON";
                Main_SerialPort1.WriteLine("DF103");
                Peltier3_checkBox.ForeColor = Color.White;
                Peltier3_checkBox.BackColor = SystemColors.Highlight;
            }
        }


        private void Peltier4_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier4_checkBox.Checked == true)
            {
                PCP_Indicator6.BackColor = Color.DarkGreen;
                Peltier4_checkBox.Text = "OFF";
                Main_SerialPort1.WriteLine("DN104");
                Peltier4_checkBox.ForeColor = Color.White;
                Peltier4_checkBox.BackColor = Color.DarkRed;
            }
            else if (Peltier4_checkBox.Checked == false)
            {
                PCP_Indicator6.BackColor = Color.Maroon;
                Peltier4_checkBox.Text = "ON";
                Main_SerialPort1.WriteLine("DF104");
                Peltier4_checkBox.ForeColor = Color.White;
                Peltier4_checkBox.BackColor = SystemColors.Highlight;
            }
        }


        private void ClearBuffer_button_Click(object sender, EventArgs e)
        {
            try
            {
                Main_SerialPort1.DiscardInBuffer();
                Main_SerialPort1.DiscardOutBuffer();
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
            HDCPMsgbox_label.ForeColor = Color.White;
            HDCPMsgbox_label.BackColor = SystemColors.MenuHighlight;
            if (HDCPDevicelist_Combobox.SelectedIndex == 0)
            {
                BeginInvoke(new EventHandler(HdcpGlobalOn_button_Click));
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 1)
            {
                DS1.BackColor = Color.SeaGreen;
                Main_SerialPort1.WriteLine("DN201");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 2)
            {
                DS2.BackColor = Color.SeaGreen;
                Main_SerialPort1.WriteLine("DN202");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 3)
            {
                DS3.BackColor = Color.SeaGreen;
                Main_SerialPort1.WriteLine("DN203");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 4)
            {
                DS4.BackColor = Color.SeaGreen;
                Main_SerialPort1.WriteLine("DN204");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 5)
            {
                DS5.BackColor = Color.SeaGreen;
                Main_SerialPort1.WriteLine("DN107");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 6)
            {
                DS6.BackColor = Color.SeaGreen;
                Main_SerialPort1.WriteLine("DN108");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 7)
            {
                DS7.BackColor = Color.SeaGreen;
                Main_SerialPort1.WriteLine("DN106");
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
                DS1.BackColor = Color.Brown;
                Main_SerialPort1.WriteLine("DF201");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 2)
            {
                DS2.BackColor = Color.Brown;
                Main_SerialPort1.WriteLine("DF202");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 3)
            {
                DS3.BackColor = Color.Brown;
                Main_SerialPort1.WriteLine("DF203");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 4)
            {
                DS4.BackColor = Color.Brown;
                Main_SerialPort1.WriteLine("DF204");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 5)
            {
                DS5.BackColor = Color.Brown;
                Main_SerialPort1.WriteLine("DF107");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 6)
            {
                DS6.BackColor = Color.Brown;
                Main_SerialPort1.WriteLine("DF108");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 7)
            {
                DS7.BackColor = Color.Brown;
                Main_SerialPort1.WriteLine("DF106");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else
            {
                HDCPMsgbox_label.Text = "No devices selected!";
            }
        }


        private void HdcpGlobalOn_button_Click(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(AllDev_SwitchON));
            HDCPMsgbox_label.Text = "Switched ON all devices!";
        }


        private void HdcpGlobalOff_button_Click(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(AllDev_SwitchOFF));
            HDCPMsgbox_label.Text = "Switched OFF all devices!";
        }


        private void AllDev_SwitchON(object sender, EventArgs e)
        {
            for (int RelaySubs = 1; RelaySubs <= 4; RelaySubs++)
            {
                Main_SerialPort1.WriteLine("DN20" + RelaySubs);
            }
            for (int RelaySubs = 6; RelaySubs <= 8; RelaySubs++)
            {
                Main_SerialPort1.WriteLine("DN10" + RelaySubs);
            }

            DS1.BackColor = Color.SeaGreen;
            DS1.ForeColor = Color.Snow;
            DS2.BackColor = Color.SeaGreen;
            DS2.ForeColor = Color.Snow;
            DS3.BackColor = Color.SeaGreen;
            DS3.ForeColor = Color.Snow;
            DS4.BackColor = Color.SeaGreen;
            DS4.ForeColor = Color.Snow;
            DS5.BackColor = Color.SeaGreen;
            DS5.ForeColor = Color.Snow;
            DS6.BackColor = Color.SeaGreen;
            DS6.ForeColor = Color.Snow;
            DS7.BackColor = Color.SeaGreen;
            DS7.ForeColor = Color.Snow;
        }


        private void AllDev_SwitchOFF(object sender, EventArgs e)
        {
            for (int RelaySubs = 1; RelaySubs <= 4; RelaySubs++)
            {
                Main_SerialPort1.WriteLine("DF20" + RelaySubs);
            }
            for (int RelaySubs = 6; RelaySubs <= 8; RelaySubs++)
            {
                Main_SerialPort1.WriteLine("DF10" + RelaySubs);
            }

            DS1.BackColor = Color.Brown;
            DS1.ForeColor = Color.Snow;
            DS2.BackColor = Color.Brown;
            DS2.ForeColor = Color.Snow;
            DS3.BackColor = Color.Brown;
            DS3.ForeColor = Color.Snow;
            DS4.BackColor = Color.Brown;
            DS4.ForeColor = Color.Snow;
            DS5.BackColor = Color.Brown;
            DS5.ForeColor = Color.Snow;
            DS6.BackColor = Color.Brown;
            DS6.ForeColor = Color.Snow;
            DS7.BackColor = Color.Brown;
            DS7.ForeColor = Color.Snow;
        }


        private async void ConsoleClear_button_Click(object sender, EventArgs e)
        {
            //ConsoleLog_textbox.Text = "";
            int awaitDelay = 4000;
            if (ConsoleLog_richTextBox.Text.Length == 0) { ClearConsoleTextBox_label.Text = "Nothing to clear"; }
            else { ClearConsoleTextBox_label.Text = "Console cleared"; ConsoleLog_richTextBox.Text = ""; }
            await Task.Delay(awaitDelay);
            ClearConsoleTextBox_label.Text = "";
        }


        private void consoleWrite(string message, ConsoleColor color = ConsoleColor.White)
        {
            message = "$" + message + "$";
            var pieces = Regex.Split(message, @"(\$$^\$$*\$)");

            for (int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];

                if (piece.StartsWith("$") && piece.EndsWith("$"))
                {
                    Console.ForegroundColor = color;
                    piece = piece.Substring(1, piece.Length - 2);
                }

                Console.Write(piece);
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}
// okbybye succ
