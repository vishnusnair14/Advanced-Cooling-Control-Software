using System;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
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

        private bool PBT1_flag = false;
        private bool PBT2_flag = false;
        private bool CT1_flag = false;
        private bool CT2_flag = false;
        private bool Xaxis_flag = false;
        private bool Yaxis_flag = false;
        private bool Zaxis_flag = false;
        private bool Extruder_flag = false;

        public Main()
        {
            InitializeComponent();
            ComPort_comboBox.Items.Clear();
            ComPort_comboBox.Items.AddRange(SerialPort.GetPortNames());

            Connect_button.Enabled = true;
            Disconnect_button.Enabled = false;
            Disconnect_button.BackColor = Color.LightSteelBlue;
            Disconnect_button.ForeColor = Color.White;
            SerialMonitor_textbox.Enabled = false;

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


            //CoolingFanSpeed_numericUpDown.Enabled = false;
            //CoolingFanSpeed_trackBar.Enabled = false;
            //slidingLabel.Text = "Advanced Cooling Control Software [vishnus_technologies(C) 2023] ";

            FanSpeedControlDeviceList_comboBox.Enabled = false;
            FanSpeedControlDeviceList_comboBox.SelectedIndex = 0;

            // HTA_textBox.Cursor = Cursors.Arrow;
            // HTA_textBox.Select(0, 0);
        }

        private void ArduinoReset_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_SerialPort1.IsOpen)
                {
                    BeginInvoke(new EventHandler(ClearBuffer_button_Click));
                    SerialMonitor_textbox.Text = "";
                    ConsoleLog_textbox.Text = "";
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
                ConnectionMsgBox_label.Text = "Unable to detected Arduino";
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
                ConnectionMsgBox_label.BackColor = Color.DarkSlateGray;
                ConnectionMsgBox_label.ForeColor = Color.White;
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
                                Console.WriteLine("Connected: " + _COMPORT + " @" + _BAUDRATE);
                                Console.WriteLine("> [MSG: Connected to port @" + _COMPORT + "]");

                                // initial soft-reset:
                                connection_groupBox.ForeColor = Color.DarkGreen;
                                BeginInvoke(new EventHandler(ArduinoReset_button_Click));

                                // @SECTION [Connection Panel]
                                ConnectionMsgBox_label.ForeColor = Color.White;
                                ConnectionMsgBox_label.BackColor = Color.SeaGreen;
                                Conn_progressBar.Value = 77;
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
                                AutoConnect_checkBox.Enabled = false;
                                SerialMonitor_textbox.Enabled = true;

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
                                ConsoleLog_textbox.Enabled = true;
                                Conn_progressBar.Value = 100;
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
                SerialMonitor_textbox.Enabled = false;

                PBT1_circularProgressBar.Value = 1;
                PBT1_circularProgressBar.Text = "0.00 °C";
                PBT2_circularProgressBar.Value = 1;
                PBT2_circularProgressBar.Text = "0.00 °C";
                CT1_circularProgressBar.Value = 1;
                CT1_circularProgressBar.Text = "0.00 °C";
                CT2_circularProgressBar.Value = 1;
                CT2_circularProgressBar.Text = "0.00 °C";
                SerialMonitor_textbox.Text = "";
                ConsoleLog_textbox.Text = "";

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
                _serialData = Main_SerialPort1.ReadLine().Trim();
                // BeginInvoke(new EventHandler(SerialDataDecoder));
                SerialDataDecoder(_serialData);
                if (HighTempWarning_checkBox.Checked)
                {
                    HighTemp_WatchDog();
                }
                else if(HighTempWarning_checkBox.Checked == false)
                {
                    //MakeAlertIndicatorNormal();
                }
            }
            catch
            {
                /* Do Nothing */
            }
        }

        /* SERIAL DATA DECODER SECTION */
        private void SerialDataDecoder(string _serialData)
        {
            // writes serial data to console log:
            SerialMonitor_textbox.AppendText(_serialData + Environment.NewLine);

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

                    ConsoleLog_textbox.AppendText(Environment.NewLine + "Peltier temp:- CS: " + TEMP1 + " | HS: " + TEMP2 + Environment.NewLine
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
                        if (DeviceRelayID == "0") ConsoleLog_textbox.AppendText("> Undefined device switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_textbox.AppendText("> PELTIER 1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_textbox.AppendText("> PELTIER 2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_textbox.AppendText("> PELTIER 3 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_textbox.AppendText("> PELTIER 4 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_textbox.AppendText("> AC BLOWER FAN FAN switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_textbox.AppendText("> RADIATOR FAN switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_textbox.AppendText("> HS WATER PUMP switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_textbox.AppendText("> CS WATER PUMP switched ON" + Environment.NewLine);
                        // if matches with I2C RELAY  #2 ID's
                        else if (DeviceRelayID == "21") ConsoleLog_textbox.AppendText("> CABIN EXHAUST IN #1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "22") ConsoleLog_textbox.AppendText("> CABIN EXHAUST OUT #1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "23") ConsoleLog_textbox.AppendText("> CABIN EXHAUST IN #2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "24") ConsoleLog_textbox.AppendText("> CABIN EXHAUST OUT #2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "25") ConsoleLog_textbox.AppendText("> CABIN LIGHT switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "26") ConsoleLog_textbox.AppendText("> NOCP#A switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "27") ConsoleLog_textbox.AppendText("> NOCP#B switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "28") ConsoleLog_textbox.AppendText("> NOCP#C switched ON" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Bn")
                    {
                        // if matches with I2C RELAY  #1 ID's
                        if (DeviceRelayID == "0") ConsoleLog_textbox.AppendText("> Undefined device switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_textbox.AppendText("> PELTIER 1 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_textbox.AppendText("> PELTIER 2 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_textbox.AppendText("> PELTIER 3 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_textbox.AppendText("> PELTIER 4 already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_textbox.AppendText("> AC BLOWER FAN FAN already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_textbox.AppendText("> RADIATOR FAN already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_textbox.AppendText("> HS WATER PUMP already switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_textbox.AppendText("> CS WATER PUMP already switched ON" + Environment.NewLine);
                        // if matches with I2C RELAY  #2 ID's
                        else if (DeviceRelayID == "21") ConsoleLog_textbox.AppendText("> CABIN EXHAUST IN #1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "22") ConsoleLog_textbox.AppendText("> CABIN EXHAUST OUT #1 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "23") ConsoleLog_textbox.AppendText("> CABIN EXHAUST IN #2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "24") ConsoleLog_textbox.AppendText("> CABIN EXHAUST OUT #2 switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "25") ConsoleLog_textbox.AppendText("> CABIN LIGHT switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "26") ConsoleLog_textbox.AppendText("> NOCP#A switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "27") ConsoleLog_textbox.AppendText("> NOCP#B switched ON" + Environment.NewLine);
                        else if (DeviceRelayID == "28") ConsoleLog_textbox.AppendText("> NOCP#C switched ON" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Xf")
                    {
                        // if matches with I2C RELAY  #1 ID's
                        if (DeviceRelayID == "0") ConsoleLog_textbox.AppendText("> Undefined device switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_textbox.AppendText("> PELTIER 1 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_textbox.AppendText("> PELTIER 2 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_textbox.AppendText("> PELTIER 3 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_textbox.AppendText("> PELTIER 4 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_textbox.AppendText("> AC BLOWER FAN FAN switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_textbox.AppendText("> RADIATOR FAN switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_textbox.AppendText("> HS WATER PUMP switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_textbox.AppendText("> CS WATER PUMP switched OFF" + Environment.NewLine);
                        // if matches with I2C RELAY  #2 ID's
                        else if (DeviceRelayID == "21") ConsoleLog_textbox.AppendText("> CABIN EXHAUST IN #1 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "22") ConsoleLog_textbox.AppendText("> CABIN EXHAUST OUT #1 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "23") ConsoleLog_textbox.AppendText("> CABIN EXHAUST IN #2 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "24") ConsoleLog_textbox.AppendText("> CABIN EXHAUST OUT #2 switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "25") ConsoleLog_textbox.AppendText("> CABIN LIGHT switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "26") ConsoleLog_textbox.AppendText("> NOCP#A switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "27") ConsoleLog_textbox.AppendText("> NOCP#B switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "28") ConsoleLog_textbox.AppendText("> NOCP#C switched OFF" + Environment.NewLine);
                    }
                    else if (DeviceRelayState == "Yf")
                    {
                        // if matches with I2C RELAY  #1 ID's
                        if (DeviceRelayID == "0") ConsoleLog_textbox.AppendText("> Undefined device switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "11") ConsoleLog_textbox.AppendText("> PELTIER 1 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "12") ConsoleLog_textbox.AppendText("> PELTIER 2 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "13") ConsoleLog_textbox.AppendText("> PELTIER 3 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "14") ConsoleLog_textbox.AppendText("> PELTIER 4 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "15") ConsoleLog_textbox.AppendText("> AC BLOWER FAN FAN already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "16") ConsoleLog_textbox.AppendText("> RADIATOR FAN already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "17") ConsoleLog_textbox.AppendText("> HS WATER PUMP already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "18") ConsoleLog_textbox.AppendText("> CS WATER PUMP already switched OFF" + Environment.NewLine);
                        // if matches with I2C RELAY  #2 ID's
                        else if (DeviceRelayID == "21") ConsoleLog_textbox.AppendText("> CABIN EXHAUST IN #1 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "22") ConsoleLog_textbox.AppendText("> CABIN EXHAUST OUT #1 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "23") ConsoleLog_textbox.AppendText("> CABIN EXHAUST IN #2 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "24") ConsoleLog_textbox.AppendText("> CABIN EXHAUST OUT #2 already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "25") ConsoleLog_textbox.AppendText("> CABIN LIGHT already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "26") ConsoleLog_textbox.AppendText("> NOCP#A already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "27") ConsoleLog_textbox.AppendText("> NOCP#B already switched OFF" + Environment.NewLine);
                        else if (DeviceRelayID == "28") ConsoleLog_textbox.AppendText("> NOCP#C already switched OFF" + Environment.NewLine);
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
                DIS3.BackColor = Color.Maroon;
                DIS3.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P202"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #1 module initialised]" + Environment.NewLine);
                DIS3A.BackColor = Color.DarkBlue;
                DIS3A.ForeColor = Color.White;
                I2C_INIT_FLAG++;
                BeginInvoke(new EventHandler(I2C_INIT_UI));
            }
            else if (_serialData.Equals("P203"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #1 I/O pins initiated]" + Environment.NewLine);
                DIS4A.BackColor = Color.DarkBlue;
                DIS4A.ForeColor = Color.White;
            }
            else if (_serialData.Equals("P204"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #1 device error!]" + Environment.NewLine);
                DIS3A.BackColor = Color.Maroon;
                DIS3A.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P205"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #2 module initialised]" + Environment.NewLine);
                DIS3B.BackColor = Color.DarkBlue;
                DIS3B.ForeColor = Color.White;
                I2C_INIT_FLAG++;
                BeginInvoke(new EventHandler(I2C_INIT_UI));
            }
            else if (_serialData.Equals("P206"))
            {
                ConsoleLog_textbox.AppendText("> [I2C_RELAY #2 I/O pins initiated]" + Environment.NewLine);
                DIS4B.BackColor = Color.DarkBlue;
                DIS4B.ForeColor = Color.White;
            }
            else if (_serialData.Equals("P207"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #2 device error!]" + Environment.NewLine);
                DIS3B.BackColor = Color.Maroon;
                DIS3B.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P208"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #1 CONNECTED]" + Environment.NewLine);
                DIS4A.BackColor = Color.DarkBlue;
                DIS4A.ForeColor = Color.White;
                I2C_CONN_FLAG++;
                BeginInvoke(new EventHandler(I2C_CONN_UI));
            }
            else if (_serialData.Equals("P209"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #1 DISCONNECTED!]" + Environment.NewLine);
                DIS4A.BackColor = Color.Maroon;
                DIS4A.ForeColor = Color.Yellow;
            }
            else if (_serialData.Equals("P210"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #2 CONNECTED]" + Environment.NewLine);
                DIS4B.BackColor = Color.DarkBlue;
                DIS4B.ForeColor = Color.White;
                I2C_CONN_FLAG++;
                BeginInvoke(new EventHandler(I2C_CONN_UI));
            }
            else if (_serialData.Equals("P211"))
            {
                ConsoleLog_textbox.AppendText("> [I2C RELAY #2 DISCONNECTED!]" + Environment.NewLine);
                DIS4B.BackColor = Color.Maroon;
                DIS4B.ForeColor = Color.Yellow;
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
                    SerialMonitor_textbox.AppendText("sk" + PWM.ToString() + Environment.NewLine);
                    preVal0 = FanSpeedControl_trackBar.Value;
                }
                else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 1)
                {
                    Main_SerialPort1.WriteLine("sl" + PWM.ToString());
                    SerialMonitor_textbox.AppendText("sl" + PWM.ToString() + Environment.NewLine);
                    preVal1 = FanSpeedControl_trackBar.Value;
                }
                else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 2)
                {
                    Main_SerialPort1.WriteLine("sm" + PWM.ToString());
                    SerialMonitor_textbox.AppendText("sm" + PWM.ToString() + Environment.NewLine);
                    preVal2 = FanSpeedControl_trackBar.Value;
                }
                else if (FanSpeedControlDeviceList_comboBox.SelectedIndex == 3)
                {
                    Main_SerialPort1.WriteLine("sn" + PWM.ToString());
                    SerialMonitor_textbox.AppendText("sn" + PWM.ToString() + Environment.NewLine);
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
                    Console.WriteLine("Serial port closed success");
                    Close();
                }
                else
                {
                    Console.WriteLine("\ndialog button clicked: " + DialogResult);
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
            TemperatureSettings temperatureSettings = new TemperatureSettings();
            temperatureSettings.ShowDialog();
        }


        private async void SerialMonitor_textbox_DoubleClick(object sender, EventArgs e)
        {
            if (SerialMonitor_textbox.Text.Length != 0)
            {
                SerialMonitor_textbox.Text = "";
                SerialMonitor_groupBox.ForeColor = Color.Maroon;
                SerialMonitor_groupBox.Text = "console cleared!";
                await Task.Delay(TemperatureSettings.HighTempAlertDelayMs);
                SerialMonitor_groupBox.ForeColor = SystemColors.ControlLightLight;
                SerialMonitor_groupBox.Text = "Data Monitor" + " [ " + _COMPORT + " @" + _BAUDRATE + " ]";
            }
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
        private Color c1, c2;
        private Control ctrl;
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
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (PBT1_circularProgressBar.Value >= TemperatureSettings.CoolSideMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    PBT1_flag = true;
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
                PBT1_flag = false;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "COOL SIDE";
            }
            else if (_id == "PBT2")
            {
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (PBT2_circularProgressBar.Value >= TemperatureSettings.HotSideMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    PBT2_flag = true;
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
                PBT2_flag = false;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "HOT SIDE";
            }
            else if (_id == "CT1")
            {
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (CT1_circularProgressBar.Value >= TemperatureSettings.Tank1MaxTemp && HighTempWarning_checkBox.Checked)
                {
                    CT1_flag = true;
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
                CT1_flag = false;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "TANK 1";
            }
            else if (_id == "CT2")
            {
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (CT2_circularProgressBar.Value >= TemperatureSettings.Tank2MaxTemp && HighTempWarning_checkBox.Checked)
                {
                    CT2_flag = true;
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
                CT2_flag = false;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "TANK 2";
            }
            else if(_id == "XAxis_SM")
            {
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (SMT_X_circularProgressBar.Value >= TemperatureSettings.XaxisMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    Xaxis_flag= true;
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
                Xaxis_flag = false;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "X-AXIS";
            }
            else if (_id == "YAxis_SM")
            {
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (SMT_Y_circularProgressBar.Value >= TemperatureSettings.YaxisMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    Yaxis_flag = true;
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
                Yaxis_flag = false;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "Y-AXIS";
            }
            else if (_id == "ZAxis_SM")
            {
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (SMT_Z_circularProgressBar.Value >= TemperatureSettings.ZaxisMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    Zaxis_flag = true;
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
                Zaxis_flag = false;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "Z-AXIS";
            }
            else if (_id == "Extruder_SM")
            {
                var _sw = new Stopwatch();
                _sw.Start();
                short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
                ctrl.ForeColor = TemperatureSettings.AlertlabelForeColor;
                ctrl.Text = TemperatureSettings.HighTempAlertText;
                //ctrl.Location = new Point(514, 178);
                while (SMT_E_circularProgressBar.Value >= TemperatureSettings.ExtruderMaxTemp && HighTempWarning_checkBox.Checked)
                {
                    Extruder_flag = true;
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
                Extruder_flag = false;
                ctrl.BackColor = Color.Transparent;
                ctrl.ForeColor = TemperatureSettings.labelForeColor;
                //ctrl.Location = new Point(550, 178);
                ctrl.Text = "EXTRUDER";
            }
        }


        private void MakeAlertIndicatorNormal()
        {
            Control[] indicatorControlName = { CoolSideTM_label, HotSideTM_label, Tank1TM_label, Tank2TM_label, XAxisTM_label, YAxisTM_label, ZAxisTM_label, ExtruderTM_label };

            string[] indicatorText = { "COOL SIDE", "HOT SIDE", "TANK 1", "TANK 2", "X-AXIS", "Y-AXIS", "Z-AXIS", "EXTRUDER" };

            for (int i = 0; i < indicatorControlName.Length; i++)
            {
                indicatorControlName[i].BackColor = Color.Transparent;
                indicatorControlName[i].ForeColor = Color.White;
            }
            for (int i = 0; i < indicatorText.Length; i++)
            {
                indicatorControlName[i].Text = indicatorText[i];
            }
        }


        private void HighTemp_WatchDog()
        {
            if (PBT1_circularProgressBar.Value >= TemperatureSettings.CoolSideMaxTemp)
            {
                if (!PBT1_flag)
                {
                    HighTempBlinkAlert("PBT1", CoolSideTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true); 
                }
            }

            if (PBT2_circularProgressBar.Value >= TemperatureSettings.HotSideMaxTemp)
            {
                if (!PBT2_flag)
                {
                    HighTempBlinkAlert("PBT2", HotSideTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (CT1_circularProgressBar.Value >= TemperatureSettings.Tank1MaxTemp)
            {
                if (!CT1_flag)
                {
                    HighTempBlinkAlert("CT1", Tank1TM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (CT2_circularProgressBar.Value >= TemperatureSettings.Tank2MaxTemp)
            {
                if (!CT2_flag)
                {
                    HighTempBlinkAlert("CT2", Tank2TM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (SMT_X_circularProgressBar.Value >= TemperatureSettings.XaxisMaxTemp)
            {
                if (!Xaxis_flag)
                {
                    HighTempBlinkAlert("XAxis_SM", XAxisTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (SMT_Y_circularProgressBar.Value >= TemperatureSettings.YaxisMaxTemp)
            {
                if (!Yaxis_flag)
                {
                    HighTempBlinkAlert("YAxis_SM", YAxisTM_label,  TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }

            if (SMT_Z_circularProgressBar.Value >= TemperatureSettings.ZaxisMaxTemp)
            {
                if (!Zaxis_flag)
                {
                    HighTempBlinkAlert("ZAxis_SM", ZAxisTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }
           /*
            if (SMT_E_circularProgressBar.Value >= TemperatureSettings.ExtruderMaxTemp)
            {
                if (!Extruder_flag)
                {
                    HighTempBlinkAlert("Extruder_SM", ExtruderTM_label, TemperatureSettings.AlertC1, TemperatureSettings.AlertC2, TemperatureSettings.HighTempAlertDelayMs, true);
                }
            }*/
        }
        //
        // --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SMT_E_circularProgressBar.Value = Convert.ToInt32(trackBar1.Value);
            SMT_E_circularProgressBar.Text = trackBar1.Value + " °C".ToString();
            if (SMT_E_circularProgressBar.Value >= TemperatureSettings.ExtruderMaxTemp)
            {
                if (!Extruder_flag)
                {
                    HighTempBlinkAlert("Extruder_SM", ExtruderTM_label,  TemperatureSettings.AlertC1,TemperatureSettings.AlertC2, 1000, true);
                }
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            if (ConsoleLog_textbox.Text.Length == 0) { ClearConsoleTextBox_label.Text = "Nothing to clear"; }
            else { ClearConsoleTextBox_label.Text = "Console cleared"; ConsoleLog_textbox.Text = ""; }
            await Task.Delay(awaitDelay);
            ClearConsoleTextBox_label.Text = "";
        }
    }
}
