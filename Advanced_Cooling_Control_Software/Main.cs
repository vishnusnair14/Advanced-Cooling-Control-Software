using System;
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

        public Main()
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
            PCP_Indicator5.BackColor = Color.Maroon;
            PCP_Indicator6.BackColor = Color.Maroon;

            PBT1_circularProgressBar.Value = 0;
            PBT2_circularProgressBar.Value = 0;
            CT1_circularProgressBar.Value = 0;
            CT2_circularProgressBar.Value = 0;
            SMT_X_circularProgressBar.Value = 0;
            SMT_Y_circularProgressBar.Value = 0;
            SMT_Z_circularProgressBar.Value = 0;
            SMT_E_circularProgressBar.Value = 0;
            ACBFanSpeed_trackBar.Value = 0;
            FanSpeedControl_numericUpDown.Value = 0;

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
            ACBFanSpeed_trackBar.Enabled = false;

            //CoolingFanSpeed_numericUpDown.Enabled = false;
            //CoolingFanSpeed_trackBar.Enabled = false;
            //slidingLabel.Text = "Advanced Cooling Control Software [vishnus_technologies(C) 2023] ";

            FanSpeedControl_comboBox.Enabled = false;
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
                                Console.WriteLine("Connected: " + _COMPORT + " @" + _BAUDRATE);
                                Console.WriteLine("> [MSG: Connected to port @" + _COMPORT + "]");
                                // first software reset:
                                connection_groupBox.ForeColor = Color.DarkGreen;
                                BeginInvoke(new EventHandler(ArduinoReset_button_Click));

                                // load m-code data:
                                //LOAD_MCODE load_mcode = new LOAD_MCODE("/code.txt");

                                ConnectionMsgBox_label.ForeColor = Color.DarkBlue;
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
                                Peltier3_checkBox.Enabled = true;
                                Peltier4_checkBox.Enabled = true;


                                //CoolingFanSpeed_numericUpDown.Enabled = true;
                                //CoolingFanSpeed_trackBar.Enabled = true;

                                AutoConnect_checkBox.Enabled = false;
                                //CabinLight_checkBox.Checked = false;

                                Command_textBox.Enabled = true;
                                Send_button.Enabled = true;
                                ConsoleLog_textbox.Enabled = true;

                                FanSpeedControl_comboBox.Enabled = true;
                            }
                            catch
                            {
                                MessageBox.Show("Unable to establish connection with Port: " + _COMPORT, "COM Error");
                                connection_groupBox.ForeColor = Color.Maroon;
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

                // switch off all coolant/exhaust relays:


                // Disconnect serial COM:
                SerialPort1.Close();

                connection_groupBox.ForeColor = Color.Maroon;
                Conn_progressBar.Value = 0;
                ConnectionMsgBox_label.ForeColor = Color.Maroon;
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
                Passcode_textBox.Text = "20222023v"; /* SET SOFTWARE PASSWORD HERE */

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
                Peltier3_checkBox.Enabled = false;
                Peltier4_checkBox.Enabled = false;

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

                FanSpeedControl_numericUpDown.Enabled = false;
                ACBFanSpeed_trackBar.Enabled = false;
                //CoolingFanSpeed_numericUpDown.Enabled = false;
                //CoolingFanSpeed_trackBar.Enabled = false;

                ACBFanSpeed_trackBar.Value = 0;
                FanSpeedControl_numericUpDown.Value = 0;
                //CoolingFanSpeed_trackBar.Value = 0;
                //CoolingFanSpeed_numericUpDown.Value = 0;

                AutoConnect_checkBox.Checked = false;
                AutoConnect_checkBox.Enabled = true;

                FanSpeedControl_comboBox.Enabled = false;

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
                // BeginInvoke(new EventHandler(SerialDataDecoder));
                SerialDataDecoder(_serialData);
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
                        + "Coolant temp:- CS: " + TEMP3 + " | HS: " + TEMP4 + Environment.NewLine + Environment.NewLine);
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
            if (FanSpeedControl_comboBox.Text != "--select device--")
            {
                FanSpeedControl_numericUpDown.Value = ACBFanSpeed_trackBar.Value;
                // progressBar1.Value = ExhaustFanSpeed_trackBar.Value;
                BeginInvoke(new EventHandler(FanPwmEncoder));
            }
            else
            {

            }
        }

        private void ExhaustFanSpeed_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ACBFanSpeed_trackBar.Value = (int)FanSpeedControl_numericUpDown.Value;
            BeginInvoke(new EventHandler(FanPwmEncoder));
        }


        /* PWM VALUE ENCODE SECTION */
        // delegate to convert percentage to pwm value. Encode pwm value and writes to
        // arduino serial. Example data: [s102d] or [s255d] or [s125.44d] -> pwm: 102, 255, 125 
        private void FanPwmEncoder(object sender, EventArgs e)
        {
            PWM = (1.0f * ACBFanSpeed_trackBar.Value) / 100 * 255;
            if (SerialPort1.IsOpen)
            {
                if (FanSpeedControl_comboBox.SelectedIndex == 1)
                {
                    SerialPort1.WriteLine("SA" + PWM.ToString());
                    SerialMonitor_textbox.AppendText("SA" + PWM.ToString() + Environment.NewLine);
                }
                else if (FanSpeedControl_comboBox.SelectedIndex == 2)
                {
                    SerialPort1.WriteLine("SB" + PWM.ToString());
                    SerialMonitor_textbox.AppendText("SB" + PWM.ToString() + Environment.NewLine);
                }
                else if (FanSpeedControl_comboBox.SelectedIndex == 3)
                {
                    SerialPort1.WriteLine("SC" + PWM.ToString());
                    SerialMonitor_textbox.AppendText("SC" + PWM.ToString() + Environment.NewLine);
                }
                else if (FanSpeedControl_comboBox.SelectedIndex == 4)
                {
                    SerialPort1.WriteLine("SD" + PWM.ToString());
                    SerialMonitor_textbox.AppendText("SD" + PWM.ToString() + Environment.NewLine);
                }
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


        public void Form1_Load(object sender, EventArgs e)
        {
        }


        private void CabinLight_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CabinLight_checkBox.Checked == true)
            {
                PCP_Indicator2.BackColor = Color.DarkGreen;
                CabinLight_checkBox.Text = "OFF";
                SerialPort1.WriteLine("DN201");
            }
            else if (CabinLight_checkBox.Checked == false)
            {
                PCP_Indicator2.BackColor = Color.Maroon;
                CabinLight_checkBox.Text = "ON";
                SerialPort1.WriteLine("DF201");
            }
        }

        private string DecodeCommandFromFile(string _cmd)
        {
            Decode getCode = new Decode();

            return getCode.SearchCmdInDict(_cmd);
        }

        private async void Send_button_Click(object sender, EventArgs e)
        {
            if (Command_textBox.Text.Length != 0)
            {
                if (SerialPort1.IsOpen)
                {
                    SerialPort1.WriteLine(Command_textBox.Text);
                    //ConsoleLog_textbox.Text = DecodeCommandFromFile(Command_textBox.Text);
                }
                else
                {
                    ClearConsoleTextBox_label.Text = "Serial port closed!";
                    await Task.Delay(4000);
                    ClearConsoleTextBox_label.Text = "";
                }
            }
            else
            {
                ClearConsoleTextBox_label.Text = "No commands specified!";
                await Task.Delay(4000);
                ClearConsoleTextBox_label.Text = "";
            }
        }


        private void SoftwareInfo_MenuItem_Click(object sender, EventArgs e)
        {
            //Form2 container = new Form2();
            CommandOptions cw = new CommandOptions(this.SerialPort1);
            //cw.MdiParent = this;
            cw.ShowDialog();
        }

        private void About_MenuItem_Click(object sender, EventArgs e)
        {
            About ob = new About();  // Form2: About.cs
            ob.Show();
        }

        private void Exit_MenuItem_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                string msg = "Serial port is connected. Do you want to close anyway?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, "Confirmation", buttons);
                if (result == DialogResult.Yes)
                {
                    SerialPort1.Close();
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

        private void Command_MenuItem_Click(object sender, EventArgs e)
        {
            CommandOptions commandContainer = new CommandOptions(this.SerialPort1);
            commandContainer.ShowDialog();
        }

        private void SerialMonitor_textbox_Click(object sender, EventArgs e)
        {
            SerialMonitor_textbox.Text = "";
        }

        private void systemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemInformation systeminfohelper = new SystemInformation();
            systeminfohelper.Show();
        }

        private void FanSpeedControl_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FanSpeedControl_Label.Text = FanSpeedControl_comboBox.Text + " fan speed";
            if (FanSpeedControl_comboBox.Text == "--select device--")
            {
                ACBFanSpeed_trackBar.Enabled = false;
                FanSpeedControl_numericUpDown.Enabled = false;
            }
            else
            {
                ACBFanSpeed_trackBar.Enabled = true;
                FanSpeedControl_numericUpDown.Enabled = true;
            }
        }

        private void ExhaustFanSpeed_trackBar_MouseDown(object sender, MouseEventArgs e)
        {
            InfoToolTip.Active = true;
            InfoToolTip.Show("Speed controller for Exhaust Fans: ARDUINO_PIN: ~9", ACBFanSpeed_trackBar);
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
                SerialPort1.WriteLine("DN101");
            }
            else if (Peltier1_checkBox.Checked == false)
            {
                PCP_Indicator3.BackColor = Color.Maroon;
                Peltier1_checkBox.Text = "ON";
                SerialPort1.WriteLine("DF101");
            }
        }

        private void Peltier2_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier2_checkBox.Checked == true)
            {
                PCP_Indicator4.BackColor = Color.DarkGreen;
                Peltier2_checkBox.Text = "OFF";
                SerialPort1.WriteLine("DN102");
            }
            else if (Peltier2_checkBox.Checked == false)
            {
                PCP_Indicator4.BackColor = Color.Maroon;
                Peltier2_checkBox.Text = "ON";
                SerialPort1.WriteLine("DF102");
            }
        }

        private void Peltier3_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier3_checkBox.Checked == true)
            {
                PCP_Indicator5.BackColor = Color.DarkGreen;
                Peltier3_checkBox.Text = "OFF";
                SerialPort1.WriteLine("DN103");
            }
            else if (Peltier3_checkBox.Checked == false)
            {
                PCP_Indicator5.BackColor = Color.Maroon;
                Peltier3_checkBox.Text = "ON";
                SerialPort1.WriteLine("DF103");
            }
        }

        private void Peltier4_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Peltier4_checkBox.Checked == true)
            {
                PCP_Indicator6.BackColor = Color.DarkGreen;
                Peltier4_checkBox.Text = "OFF";
                SerialPort1.WriteLine("DN104");
            }
            else if (Peltier4_checkBox.Checked == false)
            {
                PCP_Indicator6.BackColor = Color.Maroon;
                Peltier4_checkBox.Text = "ON";
                SerialPort1.WriteLine("DF104");
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
                DS1.BackColor = Color.SeaGreen;
                SerialPort1.WriteLine("DN201");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 2)
            {
                DS2.BackColor = Color.SeaGreen;
                SerialPort1.WriteLine("DN202");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 3)
            {
                DS3.BackColor = Color.SeaGreen;
                SerialPort1.WriteLine("DN203");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 4)
            {
                DS4.BackColor = Color.SeaGreen;
                SerialPort1.WriteLine("DN204");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 5)
            {
                DS5.BackColor = Color.SeaGreen;
                SerialPort1.WriteLine("DN107");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 6)
            {
                DS6.BackColor = Color.SeaGreen;
                SerialPort1.WriteLine("DN108");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": ON";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 7)
            {
                DS7.BackColor = Color.SeaGreen;
                SerialPort1.WriteLine("DN106");
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
                SerialPort1.WriteLine("DF201");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 2)
            {
                DS2.BackColor = Color.Brown;
                SerialPort1.WriteLine("DF202");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 3)
            {
                DS3.BackColor = Color.Brown;
                SerialPort1.WriteLine("DF203");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 4)
            {
                DS4.BackColor = Color.Brown;
                SerialPort1.WriteLine("DF204");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 5)
            {
                DS5.BackColor = Color.Brown;
                SerialPort1.WriteLine("DF107");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 6)
            {
                DS6.BackColor = Color.Brown;
                SerialPort1.WriteLine("DF108");
                HDCPMsgbox_label.Text = HDCPDevicelist_Combobox.SelectedItem + ": OFF";
            }
            else if (HDCPDevicelist_Combobox.SelectedIndex == 7)
            {
                DS7.BackColor = Color.Brown;
                SerialPort1.WriteLine("DF106");
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
                SerialPort1.WriteLine("DN20" + RelaySubs);
            }
            for (int RelaySubs = 6; RelaySubs <= 8; RelaySubs++)
            {
                SerialPort1.WriteLine("DN10" + RelaySubs);
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
                SerialPort1.WriteLine("DF20" + RelaySubs);
            }
            for (int RelaySubs = 6; RelaySubs <= 8; RelaySubs++)
            {
                SerialPort1.WriteLine("DF10" + RelaySubs);
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
