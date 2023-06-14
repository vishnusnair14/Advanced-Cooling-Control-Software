namespace Advanced_Cooling_Control_Software
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ArduinoReset_button = new System.Windows.Forms.Button();
            this.CheckArduinoComPort_button = new System.Windows.Forms.Button();
            this.Disconnect_button = new System.Windows.Forms.Button();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Conn_progressBar = new System.Windows.Forms.ProgressBar();
            this.ConnectionMsgBox_label = new System.Windows.Forms.Label();
            this.Peltier2_checkBox = new System.Windows.Forms.CheckBox();
            this.Peltier1_checkBox = new System.Windows.Forms.CheckBox();
            this.MainPower_checkBox = new System.Windows.Forms.CheckBox();
            this.CabinLight_checkBox = new System.Windows.Forms.CheckBox();
            this.PCP_Indicator4 = new System.Windows.Forms.Label();
            this.PCP_Indicator3 = new System.Windows.Forms.Label();
            this.PCP_Indicator2 = new System.Windows.Forms.Label();
            this.PCP_Indicator1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HDCPMsgbox_label = new System.Windows.Forms.Label();
            this.DS3 = new System.Windows.Forms.Label();
            this.DS6 = new System.Windows.Forms.Label();
            this.DS2 = new System.Windows.Forms.Label();
            this.DS7 = new System.Windows.Forms.Label();
            this.DS5 = new System.Windows.Forms.Label();
            this.DS1 = new System.Windows.Forms.Label();
            this.SerialMonitor_groupBox = new System.Windows.Forms.GroupBox();
            this.SerialMonitor_textbox = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.CT2_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.CT1_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.PBT2_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PBT1_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.SMT_E_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.SMT_Z_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label30 = new System.Windows.Forms.Label();
            this.SMT_Y_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.SMT_X_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DS4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HDCPOff_button = new System.Windows.Forms.Button();
            this.HDCPOn_button = new System.Windows.Forms.Button();
            this.HDCPDevicelist_Combobox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Peltier4_checkBox = new System.Windows.Forms.CheckBox();
            this.PCP_Indicator5 = new System.Windows.Forms.Label();
            this.PCP_Indicator6 = new System.Windows.Forms.Label();
            this.Peltier3_checkBox = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.Send_button = new System.Windows.Forms.Button();
            this.Command_textBox = new System.Windows.Forms.TextBox();
            this.ClearConsoleTextBox_label = new System.Windows.Forms.Label();
            this.ConsoleClear_button = new System.Windows.Forms.Button();
            this.ConsoleLog_textbox = new System.Windows.Forms.TextBox();
            this.DIS4 = new System.Windows.Forms.TextBox();
            this.DIS5 = new System.Windows.Forms.TextBox();
            this.DIS3 = new System.Windows.Forms.TextBox();
            this.DIS6 = new System.Windows.Forms.TextBox();
            this.DIS1 = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DIS3B = new System.Windows.Forms.TextBox();
            this.DIS3A = new System.Windows.Forms.TextBox();
            this.DIS4B = new System.Windows.Forms.TextBox();
            this.DIS4A = new System.Windows.Forms.TextBox();
            this.DIS7 = new System.Windows.Forms.TextBox();
            this.DIS2 = new System.Windows.Forms.TextBox();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BaudRate_comboBox = new System.Windows.Forms.ComboBox();
            this.ComPort_comboBox = new System.Windows.Forms.ComboBox();
            this.connection_groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AutoConnect_checkBox = new System.Windows.Forms.CheckBox();
            this.Passcode_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.C1_ExhaustIN_trackBar = new System.Windows.Forms.TrackBar();
            this.C1_ExhaustIN_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.C2_ExhaustOUT_trackBar = new System.Windows.Forms.TrackBar();
            this.C2_ExhaustOUT_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.C2_ExhaustIN_trackBar = new System.Windows.Forms.TrackBar();
            this.C2_ExhaustIN_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.C1_ExhaustOUT_trackBar = new System.Windows.Forms.TrackBar();
            this.C1_ExhaustOUT_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ACBFanSpeed_trackBar = new System.Windows.Forms.TrackBar();
            this.ExhaustFanSpeed_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SerialMonitor_groupBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.connection_groupBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1_ExhaustIN_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1_ExhaustIN_numericUpDown)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C2_ExhaustOUT_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2_ExhaustOUT_numericUpDown)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C2_ExhaustIN_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2_ExhaustIN_numericUpDown)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1_ExhaustOUT_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1_ExhaustOUT_numericUpDown)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ACBFanSpeed_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExhaustFanSpeed_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ArduinoReset_button
            // 
            this.ArduinoReset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ArduinoReset_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ArduinoReset_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ArduinoReset_button.ForeColor = System.Drawing.Color.White;
            this.ArduinoReset_button.Location = new System.Drawing.Point(116, 31);
            this.ArduinoReset_button.Name = "ArduinoReset_button";
            this.ArduinoReset_button.Size = new System.Drawing.Size(110, 26);
            this.ArduinoReset_button.TabIndex = 34;
            this.ArduinoReset_button.Text = "Reset UNO";
            this.ArduinoReset_button.UseVisualStyleBackColor = false;
            this.ArduinoReset_button.Click += new System.EventHandler(this.ArduinoReset_button_Click);
            // 
            // CheckArduinoComPort_button
            // 
            this.CheckArduinoComPort_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CheckArduinoComPort_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.CheckArduinoComPort_button.ForeColor = System.Drawing.Color.White;
            this.CheckArduinoComPort_button.Location = new System.Drawing.Point(3, 31);
            this.CheckArduinoComPort_button.Name = "CheckArduinoComPort_button";
            this.CheckArduinoComPort_button.Size = new System.Drawing.Size(110, 26);
            this.CheckArduinoComPort_button.TabIndex = 31;
            this.CheckArduinoComPort_button.Text = "Search UNO";
            this.CheckArduinoComPort_button.UseVisualStyleBackColor = false;
            this.CheckArduinoComPort_button.Click += new System.EventHandler(this.CheckArduinoComPort_button_Click);
            // 
            // Disconnect_button
            // 
            this.Disconnect_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Disconnect_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Disconnect_button.ForeColor = System.Drawing.Color.White;
            this.Disconnect_button.Location = new System.Drawing.Point(116, 4);
            this.Disconnect_button.Name = "Disconnect_button";
            this.Disconnect_button.Size = new System.Drawing.Size(110, 26);
            this.Disconnect_button.TabIndex = 8;
            this.Disconnect_button.Text = "Disconnect";
            this.Disconnect_button.UseVisualStyleBackColor = false;
            this.Disconnect_button.Click += new System.EventHandler(this.Disconnect_button_Click);
            // 
            // Connect_button
            // 
            this.Connect_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Connect_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Connect_button.ForeColor = System.Drawing.Color.White;
            this.Connect_button.Location = new System.Drawing.Point(3, 4);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(110, 26);
            this.Connect_button.TabIndex = 8;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = false;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // Conn_progressBar
            // 
            this.Conn_progressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Conn_progressBar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Conn_progressBar.Location = new System.Drawing.Point(6, 143);
            this.Conn_progressBar.MarqueeAnimationSpeed = 10;
            this.Conn_progressBar.Name = "Conn_progressBar";
            this.Conn_progressBar.Size = new System.Drawing.Size(234, 6);
            this.Conn_progressBar.TabIndex = 7;
            // 
            // ConnectionMsgBox_label
            // 
            this.ConnectionMsgBox_label.BackColor = System.Drawing.Color.Gainsboro;
            this.ConnectionMsgBox_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConnectionMsgBox_label.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.ConnectionMsgBox_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.ConnectionMsgBox_label.Location = new System.Drawing.Point(6, 118);
            this.ConnectionMsgBox_label.Name = "ConnectionMsgBox_label";
            this.ConnectionMsgBox_label.Size = new System.Drawing.Size(234, 24);
            this.ConnectionMsgBox_label.TabIndex = 6;
            this.ConnectionMsgBox_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Peltier2_checkBox
            // 
            this.Peltier2_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.Peltier2_checkBox.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.Peltier2_checkBox.Location = new System.Drawing.Point(244, 37);
            this.Peltier2_checkBox.Name = "Peltier2_checkBox";
            this.Peltier2_checkBox.Size = new System.Drawing.Size(43, 27);
            this.Peltier2_checkBox.TabIndex = 35;
            this.Peltier2_checkBox.Text = "ON";
            this.Peltier2_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Peltier2_checkBox.UseVisualStyleBackColor = true;
            this.Peltier2_checkBox.CheckedChanged += new System.EventHandler(this.Peltier2_checkBox_CheckedChanged);
            // 
            // Peltier1_checkBox
            // 
            this.Peltier1_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.Peltier1_checkBox.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.Peltier1_checkBox.Location = new System.Drawing.Point(91, 38);
            this.Peltier1_checkBox.Name = "Peltier1_checkBox";
            this.Peltier1_checkBox.Size = new System.Drawing.Size(43, 27);
            this.Peltier1_checkBox.TabIndex = 34;
            this.Peltier1_checkBox.Text = "ON";
            this.Peltier1_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Peltier1_checkBox.UseVisualStyleBackColor = true;
            this.Peltier1_checkBox.CheckedChanged += new System.EventHandler(this.Peltier1_checkBox_CheckedChanged);
            // 
            // MainPower_checkBox
            // 
            this.MainPower_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.MainPower_checkBox.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.MainPower_checkBox.Location = new System.Drawing.Point(92, 7);
            this.MainPower_checkBox.Name = "MainPower_checkBox";
            this.MainPower_checkBox.Size = new System.Drawing.Size(43, 27);
            this.MainPower_checkBox.TabIndex = 33;
            this.MainPower_checkBox.Text = "ON";
            this.MainPower_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainPower_checkBox.UseVisualStyleBackColor = true;
            this.MainPower_checkBox.CheckedChanged += new System.EventHandler(this.MainPower_checkBox_CheckedChanged);
            // 
            // CabinLight_checkBox
            // 
            this.CabinLight_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.CabinLight_checkBox.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.CabinLight_checkBox.Location = new System.Drawing.Point(244, 6);
            this.CabinLight_checkBox.Name = "CabinLight_checkBox";
            this.CabinLight_checkBox.Size = new System.Drawing.Size(43, 27);
            this.CabinLight_checkBox.TabIndex = 32;
            this.CabinLight_checkBox.Text = "ON";
            this.CabinLight_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CabinLight_checkBox.UseVisualStyleBackColor = true;
            this.CabinLight_checkBox.CheckedChanged += new System.EventHandler(this.CabinLight_checkBox_CheckedChanged);
            // 
            // PCP_Indicator4
            // 
            this.PCP_Indicator4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator4.Location = new System.Drawing.Point(293, 37);
            this.PCP_Indicator4.Name = "PCP_Indicator4";
            this.PCP_Indicator4.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator4.TabIndex = 30;
            // 
            // PCP_Indicator3
            // 
            this.PCP_Indicator3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator3.Location = new System.Drawing.Point(140, 39);
            this.PCP_Indicator3.Name = "PCP_Indicator3";
            this.PCP_Indicator3.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator3.TabIndex = 29;
            // 
            // PCP_Indicator2
            // 
            this.PCP_Indicator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator2.Location = new System.Drawing.Point(293, 6);
            this.PCP_Indicator2.Name = "PCP_Indicator2";
            this.PCP_Indicator2.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator2.TabIndex = 28;
            // 
            // PCP_Indicator1
            // 
            this.PCP_Indicator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator1.Location = new System.Drawing.Point(140, 7);
            this.PCP_Indicator1.Name = "PCP_Indicator1";
            this.PCP_Indicator1.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(180, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Peltier 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peltier 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(162, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cabin Light:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Main Power:";
            // 
            // HDCPMsgbox_label
            // 
            this.HDCPMsgbox_label.BackColor = System.Drawing.Color.Gainsboro;
            this.HDCPMsgbox_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HDCPMsgbox_label.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.HDCPMsgbox_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.HDCPMsgbox_label.Location = new System.Drawing.Point(121, 39);
            this.HDCPMsgbox_label.Name = "HDCPMsgbox_label";
            this.HDCPMsgbox_label.Size = new System.Drawing.Size(183, 27);
            this.HDCPMsgbox_label.TabIndex = 10;
            this.HDCPMsgbox_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS3
            // 
            this.DS3.BackColor = System.Drawing.Color.Brown;
            this.DS3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DS3.ForeColor = System.Drawing.Color.Snow;
            this.DS3.Location = new System.Drawing.Point(3, 40);
            this.DS3.Name = "DS3";
            this.DS3.Size = new System.Drawing.Size(103, 15);
            this.DS3.TabIndex = 0;
            this.DS3.Text = "Exhaust 2 IN";
            this.DS3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS6
            // 
            this.DS6.BackColor = System.Drawing.Color.Brown;
            this.DS6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DS6.ForeColor = System.Drawing.Color.Snow;
            this.DS6.Location = new System.Drawing.Point(3, 100);
            this.DS6.Name = "DS6";
            this.DS6.Size = new System.Drawing.Size(103, 15);
            this.DS6.TabIndex = 31;
            this.DS6.Text = "Radiator Pump";
            this.DS6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS2
            // 
            this.DS2.BackColor = System.Drawing.Color.Brown;
            this.DS2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DS2.ForeColor = System.Drawing.Color.Snow;
            this.DS2.Location = new System.Drawing.Point(3, 20);
            this.DS2.Name = "DS2";
            this.DS2.Size = new System.Drawing.Size(103, 15);
            this.DS2.TabIndex = 0;
            this.DS2.Text = "Exhaust 1 OUT";
            this.DS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS7
            // 
            this.DS7.BackColor = System.Drawing.Color.Brown;
            this.DS7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DS7.ForeColor = System.Drawing.Color.Snow;
            this.DS7.Location = new System.Drawing.Point(3, 120);
            this.DS7.Name = "DS7";
            this.DS7.Size = new System.Drawing.Size(103, 15);
            this.DS7.TabIndex = 2;
            this.DS7.Text = "Radiator Fans";
            this.DS7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS5
            // 
            this.DS5.BackColor = System.Drawing.Color.Brown;
            this.DS5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DS5.ForeColor = System.Drawing.Color.Snow;
            this.DS5.Location = new System.Drawing.Point(3, 80);
            this.DS5.Name = "DS5";
            this.DS5.Size = new System.Drawing.Size(103, 15);
            this.DS5.TabIndex = 1;
            this.DS5.Text = "Coolant Pump";
            this.DS5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS1
            // 
            this.DS1.BackColor = System.Drawing.Color.Brown;
            this.DS1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DS1.ForeColor = System.Drawing.Color.Snow;
            this.DS1.Location = new System.Drawing.Point(3, 0);
            this.DS1.Name = "DS1";
            this.DS1.Size = new System.Drawing.Size(103, 15);
            this.DS1.TabIndex = 0;
            this.DS1.Text = "Exhaust 1 IN";
            this.DS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialMonitor_groupBox
            // 
            this.SerialMonitor_groupBox.Controls.Add(this.SerialMonitor_textbox);
            this.SerialMonitor_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.SerialMonitor_groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SerialMonitor_groupBox.Location = new System.Drawing.Point(14, 291);
            this.SerialMonitor_groupBox.Name = "SerialMonitor_groupBox";
            this.SerialMonitor_groupBox.Size = new System.Drawing.Size(382, 158);
            this.SerialMonitor_groupBox.TabIndex = 2;
            this.SerialMonitor_groupBox.TabStop = false;
            this.SerialMonitor_groupBox.Text = "Data Monitor";
            // 
            // SerialMonitor_textbox
            // 
            this.SerialMonitor_textbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SerialMonitor_textbox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.SerialMonitor_textbox.Location = new System.Drawing.Point(7, 22);
            this.SerialMonitor_textbox.Multiline = true;
            this.SerialMonitor_textbox.Name = "SerialMonitor_textbox";
            this.SerialMonitor_textbox.ReadOnly = true;
            this.SerialMonitor_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SerialMonitor_textbox.Size = new System.Drawing.Size(369, 119);
            this.SerialMonitor_textbox.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox7.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox7.Location = new System.Drawing.Point(441, 291);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(914, 447);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Temperature Console";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox9.Controls.Add(this.CT2_circularProgressBar);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.CT1_circularProgressBar);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox9.Location = new System.Drawing.Point(356, 22);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(333, 202);
            this.groupBox9.TabIndex = 37;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Coolant Temperature";
            // 
            // CT2_circularProgressBar
            // 
            this.CT2_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CT2_circularProgressBar.AnimationSpeed = 500;
            this.CT2_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CT2_circularProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.CT2_circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CT2_circularProgressBar.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.CT2_circularProgressBar.InnerMargin = 2;
            this.CT2_circularProgressBar.InnerWidth = -1;
            this.CT2_circularProgressBar.Location = new System.Drawing.Point(168, 22);
            this.CT2_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.CT2_circularProgressBar.Name = "CT2_circularProgressBar";
            this.CT2_circularProgressBar.OuterColor = System.Drawing.Color.Gainsboro;
            this.CT2_circularProgressBar.OuterMargin = -25;
            this.CT2_circularProgressBar.OuterWidth = 26;
            this.CT2_circularProgressBar.ProgressColor = System.Drawing.Color.DarkSlateBlue;
            this.CT2_circularProgressBar.ProgressWidth = 25;
            this.CT2_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.CT2_circularProgressBar.Size = new System.Drawing.Size(157, 156);
            this.CT2_circularProgressBar.StartAngle = 270;
            this.CT2_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CT2_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CT2_circularProgressBar.SubscriptText = "";
            this.CT2_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CT2_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CT2_circularProgressBar.SuperscriptText = "";
            this.CT2_circularProgressBar.TabIndex = 37;
            this.CT2_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.CT2_circularProgressBar.Value = 27;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(221, 181);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 15);
            this.label26.TabIndex = 36;
            this.label26.Text = "TANK 2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(51, 181);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 15);
            this.label27.TabIndex = 35;
            this.label27.Text = "TANK 1";
            // 
            // CT1_circularProgressBar
            // 
            this.CT1_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CT1_circularProgressBar.AnimationSpeed = 500;
            this.CT1_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CT1_circularProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.CT1_circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CT1_circularProgressBar.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.CT1_circularProgressBar.InnerMargin = 2;
            this.CT1_circularProgressBar.InnerWidth = -1;
            this.CT1_circularProgressBar.Location = new System.Drawing.Point(7, 22);
            this.CT1_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.CT1_circularProgressBar.Name = "CT1_circularProgressBar";
            this.CT1_circularProgressBar.OuterColor = System.Drawing.Color.Gainsboro;
            this.CT1_circularProgressBar.OuterMargin = -25;
            this.CT1_circularProgressBar.OuterWidth = 26;
            this.CT1_circularProgressBar.ProgressColor = System.Drawing.Color.DarkSlateBlue;
            this.CT1_circularProgressBar.ProgressWidth = 25;
            this.CT1_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.CT1_circularProgressBar.Size = new System.Drawing.Size(157, 156);
            this.CT1_circularProgressBar.StartAngle = 270;
            this.CT1_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CT1_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CT1_circularProgressBar.SubscriptText = "";
            this.CT1_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CT1_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CT1_circularProgressBar.SuperscriptText = "";
            this.CT1_circularProgressBar.TabIndex = 1;
            this.CT1_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.CT1_circularProgressBar.Value = 90;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.PBT2_circularProgressBar);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.PBT1_circularProgressBar);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox8.Location = new System.Drawing.Point(11, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(333, 202);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Peltier Block Temperature";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(213, 181);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 15);
            this.label25.TabIndex = 36;
            this.label25.Text = "HOT SIDE";
            // 
            // PBT2_circularProgressBar
            // 
            this.PBT2_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PBT2_circularProgressBar.AnimationSpeed = 500;
            this.PBT2_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.PBT2_circularProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.PBT2_circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PBT2_circularProgressBar.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.PBT2_circularProgressBar.InnerMargin = 2;
            this.PBT2_circularProgressBar.InnerWidth = -1;
            this.PBT2_circularProgressBar.Location = new System.Drawing.Point(168, 22);
            this.PBT2_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.PBT2_circularProgressBar.Name = "PBT2_circularProgressBar";
            this.PBT2_circularProgressBar.OuterColor = System.Drawing.Color.Gainsboro;
            this.PBT2_circularProgressBar.OuterMargin = -25;
            this.PBT2_circularProgressBar.OuterWidth = 26;
            this.PBT2_circularProgressBar.ProgressColor = System.Drawing.Color.SteelBlue;
            this.PBT2_circularProgressBar.ProgressWidth = 25;
            this.PBT2_circularProgressBar.SecondaryFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBT2_circularProgressBar.Size = new System.Drawing.Size(157, 156);
            this.PBT2_circularProgressBar.StartAngle = 270;
            this.PBT2_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PBT2_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.PBT2_circularProgressBar.SubscriptText = "";
            this.PBT2_circularProgressBar.SuperscriptColor = System.Drawing.Color.Black;
            this.PBT2_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.PBT2_circularProgressBar.SuperscriptText = "";
            this.PBT2_circularProgressBar.TabIndex = 36;
            this.PBT2_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.PBT2_circularProgressBar.Value = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "COOL SIDE";
            // 
            // PBT1_circularProgressBar
            // 
            this.PBT1_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PBT1_circularProgressBar.AnimationSpeed = 500;
            this.PBT1_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.PBT1_circularProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.PBT1_circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PBT1_circularProgressBar.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.PBT1_circularProgressBar.InnerMargin = 2;
            this.PBT1_circularProgressBar.InnerWidth = -1;
            this.PBT1_circularProgressBar.Location = new System.Drawing.Point(7, 22);
            this.PBT1_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.PBT1_circularProgressBar.Name = "PBT1_circularProgressBar";
            this.PBT1_circularProgressBar.OuterColor = System.Drawing.Color.Gainsboro;
            this.PBT1_circularProgressBar.OuterMargin = -25;
            this.PBT1_circularProgressBar.OuterWidth = 26;
            this.PBT1_circularProgressBar.ProgressColor = System.Drawing.Color.SteelBlue;
            this.PBT1_circularProgressBar.ProgressWidth = 25;
            this.PBT1_circularProgressBar.SecondaryFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBT1_circularProgressBar.Size = new System.Drawing.Size(157, 156);
            this.PBT1_circularProgressBar.StartAngle = 270;
            this.PBT1_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PBT1_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.PBT1_circularProgressBar.SubscriptText = "";
            this.PBT1_circularProgressBar.SuperscriptColor = System.Drawing.Color.Black;
            this.PBT1_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.PBT1_circularProgressBar.SuperscriptText = "";
            this.PBT1_circularProgressBar.TabIndex = 1;
            this.PBT1_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.PBT1_circularProgressBar.Value = 58;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.SMT_E_circularProgressBar);
            this.groupBox10.Controls.Add(this.circularProgressBar1);
            this.groupBox10.Controls.Add(this.SMT_Z_circularProgressBar);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.SMT_Y_circularProgressBar);
            this.groupBox10.Controls.Add(this.SMT_X_circularProgressBar);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F);
            this.groupBox10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox10.Location = new System.Drawing.Point(11, 235);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(678, 202);
            this.groupBox10.TabIndex = 38;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Stepper Motor Temperature";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(561, 181);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 15);
            this.label31.TabIndex = 40;
            this.label31.Text = "EXTRUDER";
            // 
            // SMT_E_circularProgressBar
            // 
            this.SMT_E_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.SMT_E_circularProgressBar.AnimationSpeed = 500;
            this.SMT_E_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.SMT_E_circularProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.SMT_E_circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SMT_E_circularProgressBar.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.SMT_E_circularProgressBar.InnerMargin = 2;
            this.SMT_E_circularProgressBar.InnerWidth = -1;
            this.SMT_E_circularProgressBar.Location = new System.Drawing.Point(513, 22);
            this.SMT_E_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.SMT_E_circularProgressBar.Name = "SMT_E_circularProgressBar";
            this.SMT_E_circularProgressBar.OuterColor = System.Drawing.Color.Gainsboro;
            this.SMT_E_circularProgressBar.OuterMargin = -25;
            this.SMT_E_circularProgressBar.OuterWidth = 26;
            this.SMT_E_circularProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.SMT_E_circularProgressBar.ProgressWidth = 25;
            this.SMT_E_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.SMT_E_circularProgressBar.Size = new System.Drawing.Size(157, 156);
            this.SMT_E_circularProgressBar.StartAngle = 270;
            this.SMT_E_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SMT_E_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.SMT_E_circularProgressBar.SubscriptText = "";
            this.SMT_E_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SMT_E_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.SMT_E_circularProgressBar.SuperscriptText = "";
            this.SMT_E_circularProgressBar.TabIndex = 38;
            this.SMT_E_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.SMT_E_circularProgressBar.Value = 30;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(345, 22);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gainsboro;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(0, 0);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 37;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 45;
            // 
            // SMT_Z_circularProgressBar
            // 
            this.SMT_Z_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.SMT_Z_circularProgressBar.AnimationSpeed = 500;
            this.SMT_Z_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.SMT_Z_circularProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.SMT_Z_circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SMT_Z_circularProgressBar.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.SMT_Z_circularProgressBar.InnerMargin = 2;
            this.SMT_Z_circularProgressBar.InnerWidth = -1;
            this.SMT_Z_circularProgressBar.Location = new System.Drawing.Point(345, 22);
            this.SMT_Z_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.SMT_Z_circularProgressBar.Name = "SMT_Z_circularProgressBar";
            this.SMT_Z_circularProgressBar.OuterColor = System.Drawing.Color.Gainsboro;
            this.SMT_Z_circularProgressBar.OuterMargin = -25;
            this.SMT_Z_circularProgressBar.OuterWidth = 26;
            this.SMT_Z_circularProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.SMT_Z_circularProgressBar.ProgressWidth = 25;
            this.SMT_Z_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.SMT_Z_circularProgressBar.Size = new System.Drawing.Size(157, 156);
            this.SMT_Z_circularProgressBar.StartAngle = 270;
            this.SMT_Z_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SMT_Z_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.SMT_Z_circularProgressBar.SubscriptText = "";
            this.SMT_Z_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SMT_Z_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.SMT_Z_circularProgressBar.SuperscriptText = "";
            this.SMT_Z_circularProgressBar.TabIndex = 37;
            this.SMT_Z_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.SMT_Z_circularProgressBar.Value = 45;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(403, 181);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 15);
            this.label30.TabIndex = 39;
            this.label30.Text = "Z-AXIS";
            // 
            // SMT_Y_circularProgressBar
            // 
            this.SMT_Y_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.SMT_Y_circularProgressBar.AnimationSpeed = 500;
            this.SMT_Y_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.SMT_Y_circularProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.SMT_Y_circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SMT_Y_circularProgressBar.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.SMT_Y_circularProgressBar.InnerMargin = 2;
            this.SMT_Y_circularProgressBar.InnerWidth = -1;
            this.SMT_Y_circularProgressBar.Location = new System.Drawing.Point(175, 22);
            this.SMT_Y_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.SMT_Y_circularProgressBar.Name = "SMT_Y_circularProgressBar";
            this.SMT_Y_circularProgressBar.OuterColor = System.Drawing.Color.Gainsboro;
            this.SMT_Y_circularProgressBar.OuterMargin = -25;
            this.SMT_Y_circularProgressBar.OuterWidth = 26;
            this.SMT_Y_circularProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.SMT_Y_circularProgressBar.ProgressWidth = 25;
            this.SMT_Y_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.SMT_Y_circularProgressBar.Size = new System.Drawing.Size(157, 156);
            this.SMT_Y_circularProgressBar.StartAngle = 270;
            this.SMT_Y_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SMT_Y_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.SMT_Y_circularProgressBar.SubscriptText = "";
            this.SMT_Y_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SMT_Y_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.SMT_Y_circularProgressBar.SuperscriptText = "";
            this.SMT_Y_circularProgressBar.TabIndex = 2;
            this.SMT_Y_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.SMT_Y_circularProgressBar.Value = 77;
            // 
            // SMT_X_circularProgressBar
            // 
            this.SMT_X_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.SMT_X_circularProgressBar.AnimationSpeed = 500;
            this.SMT_X_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.SMT_X_circularProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.SMT_X_circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SMT_X_circularProgressBar.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.SMT_X_circularProgressBar.InnerMargin = 2;
            this.SMT_X_circularProgressBar.InnerWidth = -1;
            this.SMT_X_circularProgressBar.Location = new System.Drawing.Point(7, 22);
            this.SMT_X_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.SMT_X_circularProgressBar.Name = "SMT_X_circularProgressBar";
            this.SMT_X_circularProgressBar.OuterColor = System.Drawing.Color.Gainsboro;
            this.SMT_X_circularProgressBar.OuterMargin = -25;
            this.SMT_X_circularProgressBar.OuterWidth = 26;
            this.SMT_X_circularProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.SMT_X_circularProgressBar.ProgressWidth = 25;
            this.SMT_X_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.SMT_X_circularProgressBar.Size = new System.Drawing.Size(157, 156);
            this.SMT_X_circularProgressBar.StartAngle = 270;
            this.SMT_X_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SMT_X_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.SMT_X_circularProgressBar.SubscriptText = "";
            this.SMT_X_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SMT_X_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.SMT_X_circularProgressBar.SuperscriptText = "";
            this.SMT_X_circularProgressBar.TabIndex = 1;
            this.SMT_X_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.SMT_X_circularProgressBar.Value = 61;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(65, 181);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(45, 15);
            this.label29.TabIndex = 35;
            this.label29.Text = "X-AXIS";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(231, 181);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 15);
            this.label28.TabIndex = 36;
            this.label28.Text = "Y-AXIS";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label20);
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.panel2);
            this.groupBox13.Controls.Add(this.panel4);
            this.groupBox13.Controls.Add(this.label11);
            this.groupBox13.Controls.Add(this.panel3);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox13.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox13.Location = new System.Drawing.Point(492, 14);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(462, 260);
            this.groupBox13.TabIndex = 38;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Hardware Device Control";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(338, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 17);
            this.label20.TabIndex = 62;
            this.label20.Text = "Device Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(17, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 17);
            this.label16.TabIndex = 64;
            this.label16.Text = "Device Power Control";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(17, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 17);
            this.label22.TabIndex = 63;
            this.label22.Text = "Main Power Control";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(329, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 213);
            this.panel2.TabIndex = 58;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DS1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DS2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DS3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DS4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DS5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DS6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DS7, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(109, 199);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DS4
            // 
            this.DS4.BackColor = System.Drawing.Color.Brown;
            this.DS4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DS4.ForeColor = System.Drawing.Color.Snow;
            this.DS4.Location = new System.Drawing.Point(3, 60);
            this.DS4.Name = "DS4";
            this.DS4.Size = new System.Drawing.Size(103, 15);
            this.DS4.TabIndex = 0;
            this.DS4.Text = "Exhaust 2 OUT";
            this.DS4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.HDCPOff_button);
            this.panel4.Controls.Add(this.HDCPOn_button);
            this.panel4.Controls.Add(this.HDCPDevicelist_Combobox);
            this.panel4.Controls.Add(this.HDCPMsgbox_label);
            this.panel4.Location = new System.Drawing.Point(9, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 90);
            this.panel4.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(5, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Actions:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Please select a device:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HDCPOff_button
            // 
            this.HDCPOff_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HDCPOff_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.HDCPOff_button.ForeColor = System.Drawing.Color.White;
            this.HDCPOff_button.Location = new System.Drawing.Point(70, 56);
            this.HDCPOff_button.Name = "HDCPOff_button";
            this.HDCPOff_button.Size = new System.Drawing.Size(45, 26);
            this.HDCPOff_button.TabIndex = 57;
            this.HDCPOff_button.Text = "OFF";
            this.HDCPOff_button.UseVisualStyleBackColor = false;
            this.HDCPOff_button.Click += new System.EventHandler(this.Hdcp_Off_button_Click);
            // 
            // HDCPOn_button
            // 
            this.HDCPOn_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HDCPOn_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.HDCPOn_button.ForeColor = System.Drawing.Color.White;
            this.HDCPOn_button.Location = new System.Drawing.Point(70, 28);
            this.HDCPOn_button.Name = "HDCPOn_button";
            this.HDCPOn_button.Size = new System.Drawing.Size(45, 26);
            this.HDCPOn_button.TabIndex = 56;
            this.HDCPOn_button.Text = "ON";
            this.HDCPOn_button.UseVisualStyleBackColor = false;
            this.HDCPOn_button.Click += new System.EventHandler(this.Hdcp_On_button_Click);
            // 
            // HDCPDevicelist_Combobox
            // 
            this.HDCPDevicelist_Combobox.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.HDCPDevicelist_Combobox.FormattingEnabled = true;
            this.HDCPDevicelist_Combobox.Items.AddRange(new object[] {
            "All devices",
            "Exhaust 1 IN",
            "Exhaust 1 OUT",
            "Exhaust 2 IN",
            "Exhaust 2 OUT",
            "Coolant Pump",
            "Radiator Pump",
            "Radiator Fans"});
            this.HDCPDevicelist_Combobox.Location = new System.Drawing.Point(160, 9);
            this.HDCPDevicelist_Combobox.Name = "HDCPDevicelist_Combobox";
            this.HDCPDevicelist_Combobox.Size = new System.Drawing.Size(144, 23);
            this.HDCPDevicelist_Combobox.TabIndex = 10;
            this.HDCPDevicelist_Combobox.SelectedIndexChanged += new System.EventHandler(this.Hdcp_Devicelists_Combobox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Peltier4_checkBox);
            this.panel3.Controls.Add(this.PCP_Indicator5);
            this.panel3.Controls.Add(this.PCP_Indicator6);
            this.panel3.Controls.Add(this.Peltier3_checkBox);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.Peltier2_checkBox);
            this.panel3.Controls.Add(this.MainPower_checkBox);
            this.panel3.Controls.Add(this.PCP_Indicator3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.PCP_Indicator4);
            this.panel3.Controls.Add(this.Peltier1_checkBox);
            this.panel3.Controls.Add(this.PCP_Indicator2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.PCP_Indicator1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.CabinLight_checkBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(9, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 105);
            this.panel3.TabIndex = 57;
            // 
            // Peltier4_checkBox
            // 
            this.Peltier4_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.Peltier4_checkBox.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.Peltier4_checkBox.Location = new System.Drawing.Point(244, 69);
            this.Peltier4_checkBox.Name = "Peltier4_checkBox";
            this.Peltier4_checkBox.Size = new System.Drawing.Size(43, 27);
            this.Peltier4_checkBox.TabIndex = 41;
            this.Peltier4_checkBox.Text = "ON";
            this.Peltier4_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Peltier4_checkBox.UseVisualStyleBackColor = true;
            this.Peltier4_checkBox.CheckedChanged += new System.EventHandler(this.Peltier4_checkBox_CheckedChanged);
            // 
            // PCP_Indicator5
            // 
            this.PCP_Indicator5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator5.Location = new System.Drawing.Point(140, 71);
            this.PCP_Indicator5.Name = "PCP_Indicator5";
            this.PCP_Indicator5.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator5.TabIndex = 38;
            // 
            // PCP_Indicator6
            // 
            this.PCP_Indicator6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator6.Location = new System.Drawing.Point(293, 69);
            this.PCP_Indicator6.Name = "PCP_Indicator6";
            this.PCP_Indicator6.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator6.TabIndex = 39;
            // 
            // Peltier3_checkBox
            // 
            this.Peltier3_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.Peltier3_checkBox.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.Peltier3_checkBox.Location = new System.Drawing.Point(91, 70);
            this.Peltier3_checkBox.Name = "Peltier3_checkBox";
            this.Peltier3_checkBox.Size = new System.Drawing.Size(43, 27);
            this.Peltier3_checkBox.TabIndex = 40;
            this.Peltier3_checkBox.Text = "ON";
            this.Peltier3_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Peltier3_checkBox.UseVisualStyleBackColor = true;
            this.Peltier3_checkBox.CheckedChanged += new System.EventHandler(this.Peltier3_checkBox_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Gainsboro;
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label32.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(28, 79);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 17);
            this.label32.TabIndex = 36;
            this.label32.Text = "Peltier 3:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Gainsboro;
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(180, 78);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(60, 17);
            this.label33.TabIndex = 37;
            this.label33.Text = "Peltier 4:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.Send_button);
            this.groupBox11.Controls.Add(this.Command_textBox);
            this.groupBox11.Controls.Add(this.ClearConsoleTextBox_label);
            this.groupBox11.Controls.Add(this.ConsoleClear_button);
            this.groupBox11.Controls.Add(this.ConsoleLog_textbox);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox11.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox11.Location = new System.Drawing.Point(14, 467);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(382, 512);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Serial Console";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Gainsboro;
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label38.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(7, 450);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(85, 21);
            this.label38.TabIndex = 42;
            this.label38.Text = "Command:";
            // 
            // Send_button
            // 
            this.Send_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Send_button.Enabled = false;
            this.Send_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Send_button.Location = new System.Drawing.Point(6, 477);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(80, 26);
            this.Send_button.TabIndex = 4;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = false;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // Command_textBox
            // 
            this.Command_textBox.Enabled = false;
            this.Command_textBox.Location = new System.Drawing.Point(98, 450);
            this.Command_textBox.Name = "Command_textBox";
            this.Command_textBox.Size = new System.Drawing.Size(279, 20);
            this.Command_textBox.TabIndex = 3;
            // 
            // ClearConsoleTextBox_label
            // 
            this.ClearConsoleTextBox_label.BackColor = System.Drawing.Color.DarkGray;
            this.ClearConsoleTextBox_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearConsoleTextBox_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClearConsoleTextBox_label.Location = new System.Drawing.Point(90, 480);
            this.ClearConsoleTextBox_label.Name = "ClearConsoleTextBox_label";
            this.ClearConsoleTextBox_label.Size = new System.Drawing.Size(200, 21);
            this.ClearConsoleTextBox_label.TabIndex = 2;
            this.ClearConsoleTextBox_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsoleClear_button
            // 
            this.ConsoleClear_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsoleClear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleClear_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.ConsoleClear_button.Location = new System.Drawing.Point(296, 477);
            this.ConsoleClear_button.Name = "ConsoleClear_button";
            this.ConsoleClear_button.Size = new System.Drawing.Size(80, 26);
            this.ConsoleClear_button.TabIndex = 1;
            this.ConsoleClear_button.Text = "Clear Log";
            this.ConsoleClear_button.UseVisualStyleBackColor = false;
            this.ConsoleClear_button.Click += new System.EventHandler(this.ConsoleClear_button_Click);
            // 
            // ConsoleLog_textbox
            // 
            this.ConsoleLog_textbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConsoleLog_textbox.Enabled = false;
            this.ConsoleLog_textbox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLog_textbox.Location = new System.Drawing.Point(6, 22);
            this.ConsoleLog_textbox.Multiline = true;
            this.ConsoleLog_textbox.Name = "ConsoleLog_textbox";
            this.ConsoleLog_textbox.ReadOnly = true;
            this.ConsoleLog_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleLog_textbox.Size = new System.Drawing.Size(370, 422);
            this.ConsoleLog_textbox.TabIndex = 0;
            // 
            // DIS4
            // 
            this.DIS4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DIS4.ForeColor = System.Drawing.Color.White;
            this.DIS4.Location = new System.Drawing.Point(3, 90);
            this.DIS4.Name = "DIS4";
            this.DIS4.ReadOnly = true;
            this.DIS4.Size = new System.Drawing.Size(98, 23);
            this.DIS4.TabIndex = 9;
            this.DIS4.Text = "I2CRELAY Conn";
            this.DIS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS5
            // 
            this.DIS5.BackColor = System.Drawing.Color.DimGray;
            this.DIS5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS5.ForeColor = System.Drawing.Color.White;
            this.DIS5.Location = new System.Drawing.Point(3, 148);
            this.DIS5.Name = "DIS5";
            this.DIS5.ReadOnly = true;
            this.DIS5.Size = new System.Drawing.Size(166, 23);
            this.DIS5.TabIndex = 14;
            this.DIS5.Text = "Auto INIT DS18B20 ";
            this.DIS5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS3
            // 
            this.DIS3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS3.ForeColor = System.Drawing.Color.White;
            this.DIS3.Location = new System.Drawing.Point(3, 61);
            this.DIS3.Name = "DIS3";
            this.DIS3.ReadOnly = true;
            this.DIS3.Size = new System.Drawing.Size(98, 23);
            this.DIS3.TabIndex = 12;
            this.DIS3.Text = "I2CRELAY INIT";
            this.DIS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS6
            // 
            this.DIS6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS6.ForeColor = System.Drawing.Color.White;
            this.DIS6.Location = new System.Drawing.Point(3, 119);
            this.DIS6.Name = "DIS6";
            this.DIS6.ReadOnly = true;
            this.DIS6.Size = new System.Drawing.Size(166, 23);
            this.DIS6.TabIndex = 13;
            this.DIS6.Text = "DS18B20 Sensor INIT";
            this.DIS6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS1
            // 
            this.DIS1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS1.ForeColor = System.Drawing.Color.White;
            this.DIS1.Location = new System.Drawing.Point(3, 3);
            this.DIS1.Name = "DIS1";
            this.DIS1.ReadOnly = true;
            this.DIS1.Size = new System.Drawing.Size(166, 23);
            this.DIS1.TabIndex = 14;
            this.DIS1.Text = "Serial COM Established";
            this.DIS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            this.groupBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox12.Controls.Add(this.panel1);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox12.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox12.Location = new System.Drawing.Point(278, 14);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(196, 260);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Initialization Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DIS3B);
            this.panel1.Controls.Add(this.DIS3A);
            this.panel1.Controls.Add(this.DIS4B);
            this.panel1.Controls.Add(this.DIS4A);
            this.panel1.Controls.Add(this.DIS7);
            this.panel1.Controls.Add(this.DIS1);
            this.panel1.Controls.Add(this.DIS4);
            this.panel1.Controls.Add(this.DIS6);
            this.panel1.Controls.Add(this.DIS2);
            this.panel1.Controls.Add(this.DIS3);
            this.panel1.Controls.Add(this.DIS5);
            this.panel1.Location = new System.Drawing.Point(9, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 213);
            this.panel1.TabIndex = 57;
            // 
            // DIS3B
            // 
            this.DIS3B.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS3B.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS3B.ForeColor = System.Drawing.Color.White;
            this.DIS3B.Location = new System.Drawing.Point(141, 61);
            this.DIS3B.Name = "DIS3B";
            this.DIS3B.ReadOnly = true;
            this.DIS3B.Size = new System.Drawing.Size(28, 23);
            this.DIS3B.TabIndex = 21;
            this.DIS3B.Text = "M2";
            this.DIS3B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS3A
            // 
            this.DIS3A.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS3A.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS3A.ForeColor = System.Drawing.Color.White;
            this.DIS3A.Location = new System.Drawing.Point(107, 61);
            this.DIS3A.Name = "DIS3A";
            this.DIS3A.ReadOnly = true;
            this.DIS3A.Size = new System.Drawing.Size(28, 23);
            this.DIS3A.TabIndex = 20;
            this.DIS3A.Text = "M1";
            this.DIS3A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS4B
            // 
            this.DIS4B.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS4B.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS4B.ForeColor = System.Drawing.Color.White;
            this.DIS4B.Location = new System.Drawing.Point(141, 90);
            this.DIS4B.Name = "DIS4B";
            this.DIS4B.ReadOnly = true;
            this.DIS4B.Size = new System.Drawing.Size(28, 23);
            this.DIS4B.TabIndex = 19;
            this.DIS4B.Text = "M2";
            this.DIS4B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS4A
            // 
            this.DIS4A.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS4A.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS4A.ForeColor = System.Drawing.Color.White;
            this.DIS4A.Location = new System.Drawing.Point(107, 90);
            this.DIS4A.Name = "DIS4A";
            this.DIS4A.ReadOnly = true;
            this.DIS4A.Size = new System.Drawing.Size(28, 23);
            this.DIS4A.TabIndex = 18;
            this.DIS4A.Text = "M1";
            this.DIS4A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS7
            // 
            this.DIS7.BackColor = System.Drawing.Color.DimGray;
            this.DIS7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS7.ForeColor = System.Drawing.Color.White;
            this.DIS7.Location = new System.Drawing.Point(3, 177);
            this.DIS7.Name = "DIS7";
            this.DIS7.ReadOnly = true;
            this.DIS7.Size = new System.Drawing.Size(166, 23);
            this.DIS7.TabIndex = 15;
            this.DIS7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS2
            // 
            this.DIS2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS2.ForeColor = System.Drawing.Color.White;
            this.DIS2.Location = new System.Drawing.Point(3, 32);
            this.DIS2.Name = "DIS2";
            this.DIS2.ReadOnly = true;
            this.DIS2.Size = new System.Drawing.Size(166, 23);
            this.DIS2.TabIndex = 14;
            this.DIS2.Text = "MCU I/O Pins";
            this.DIS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SerialPort1
            // 
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_serialDataReceived);
            // 
            // BaudRate_comboBox
            // 
            this.BaudRate_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.BaudRate_comboBox.FormattingEnabled = true;
            this.BaudRate_comboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BaudRate_comboBox.Location = new System.Drawing.Point(94, 58);
            this.BaudRate_comboBox.Name = "BaudRate_comboBox";
            this.BaudRate_comboBox.Size = new System.Drawing.Size(147, 21);
            this.BaudRate_comboBox.TabIndex = 3;
            // 
            // ComPort_comboBox
            // 
            this.ComPort_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComPort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPort_comboBox.DropDownWidth = 150;
            this.ComPort_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.ComPort_comboBox.FormattingEnabled = true;
            this.ComPort_comboBox.Location = new System.Drawing.Point(93, 29);
            this.ComPort_comboBox.Name = "ComPort_comboBox";
            this.ComPort_comboBox.Size = new System.Drawing.Size(147, 21);
            this.ComPort_comboBox.TabIndex = 2;
            this.ComPort_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComPort_comboBox_SelectedIndexChanged);
            // 
            // connection_groupBox
            // 
            this.connection_groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connection_groupBox.Controls.Add(this.label1);
            this.connection_groupBox.Controls.Add(this.label2);
            this.connection_groupBox.Controls.Add(this.label17);
            this.connection_groupBox.Controls.Add(this.panel5);
            this.connection_groupBox.Controls.Add(this.Passcode_textBox);
            this.connection_groupBox.Controls.Add(this.ComPort_comboBox);
            this.connection_groupBox.Controls.Add(this.BaudRate_comboBox);
            this.connection_groupBox.Controls.Add(this.ConnectionMsgBox_label);
            this.connection_groupBox.Controls.Add(this.Conn_progressBar);
            this.connection_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.connection_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connection_groupBox.Location = new System.Drawing.Point(14, 14);
            this.connection_groupBox.Name = "connection_groupBox";
            this.connection_groupBox.Size = new System.Drawing.Size(247, 260);
            this.connection_groupBox.TabIndex = 56;
            this.connection_groupBox.TabStop = false;
            this.connection_groupBox.Text = "Connection Panel";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Baud Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Gainsboro;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(15, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "COM Port:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.AutoConnect_checkBox);
            this.panel5.Controls.Add(this.Connect_button);
            this.panel5.Controls.Add(this.ArduinoReset_button);
            this.panel5.Controls.Add(this.Disconnect_button);
            this.panel5.Controls.Add(this.CheckArduinoComPort_button);
            this.panel5.Location = new System.Drawing.Point(6, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 91);
            this.panel5.TabIndex = 56;
            // 
            // AutoConnect_checkBox
            // 
            this.AutoConnect_checkBox.AutoSize = true;
            this.AutoConnect_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AutoConnect_checkBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AutoConnect_checkBox.Location = new System.Drawing.Point(5, 63);
            this.AutoConnect_checkBox.Name = "AutoConnect_checkBox";
            this.AutoConnect_checkBox.Size = new System.Drawing.Size(188, 17);
            this.AutoConnect_checkBox.TabIndex = 57;
            this.AutoConnect_checkBox.Text = "Auto connect to UNO after search";
            this.AutoConnect_checkBox.UseVisualStyleBackColor = true;
            // 
            // Passcode_textBox
            // 
            this.Passcode_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Passcode_textBox.Location = new System.Drawing.Point(94, 87);
            this.Passcode_textBox.Name = "Passcode_textBox";
            this.Passcode_textBox.PasswordChar = '*';
            this.Passcode_textBox.Size = new System.Drawing.Size(147, 20);
            this.Passcode_textBox.TabIndex = 55;
            this.Passcode_textBox.Text = "20222023v";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel10);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(971, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 260);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fan Speed Controls";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.C1_ExhaustIN_trackBar);
            this.panel10.Controls.Add(this.C1_ExhaustIN_numericUpDown);
            this.panel10.Controls.Add(this.label37);
            this.panel10.Location = new System.Drawing.Point(102, 22);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(280, 53);
            this.panel10.TabIndex = 70;
            // 
            // C1_ExhaustIN_trackBar
            // 
            this.C1_ExhaustIN_trackBar.AutoSize = false;
            this.C1_ExhaustIN_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.C1_ExhaustIN_trackBar.Location = new System.Drawing.Point(3, 20);
            this.C1_ExhaustIN_trackBar.Maximum = 100;
            this.C1_ExhaustIN_trackBar.Name = "C1_ExhaustIN_trackBar";
            this.C1_ExhaustIN_trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C1_ExhaustIN_trackBar.Size = new System.Drawing.Size(218, 26);
            this.C1_ExhaustIN_trackBar.SmallChange = 5;
            this.C1_ExhaustIN_trackBar.TabIndex = 50;
            this.C1_ExhaustIN_trackBar.TickFrequency = 5;
            // 
            // C1_ExhaustIN_numericUpDown
            // 
            this.C1_ExhaustIN_numericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.C1_ExhaustIN_numericUpDown.Font = new System.Drawing.Font("Malgun Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.C1_ExhaustIN_numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.C1_ExhaustIN_numericUpDown.Location = new System.Drawing.Point(227, 17);
            this.C1_ExhaustIN_numericUpDown.Name = "C1_ExhaustIN_numericUpDown";
            this.C1_ExhaustIN_numericUpDown.Size = new System.Drawing.Size(46, 26);
            this.C1_ExhaustIN_numericUpDown.TabIndex = 41;
            this.C1_ExhaustIN_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label37.ForeColor = System.Drawing.Color.DarkGreen;
            this.label37.Location = new System.Drawing.Point(77, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(137, 19);
            this.label37.TabIndex = 65;
            this.label37.Text = "[Cabin 1] Exhaust IN";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.C2_ExhaustOUT_trackBar);
            this.panel9.Controls.Add(this.C2_ExhaustOUT_numericUpDown);
            this.panel9.Controls.Add(this.label36);
            this.panel9.Location = new System.Drawing.Point(102, 201);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 53);
            this.panel9.TabIndex = 69;
            // 
            // C2_ExhaustOUT_trackBar
            // 
            this.C2_ExhaustOUT_trackBar.AutoSize = false;
            this.C2_ExhaustOUT_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.C2_ExhaustOUT_trackBar.Location = new System.Drawing.Point(3, 20);
            this.C2_ExhaustOUT_trackBar.Maximum = 100;
            this.C2_ExhaustOUT_trackBar.Name = "C2_ExhaustOUT_trackBar";
            this.C2_ExhaustOUT_trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C2_ExhaustOUT_trackBar.Size = new System.Drawing.Size(218, 26);
            this.C2_ExhaustOUT_trackBar.SmallChange = 5;
            this.C2_ExhaustOUT_trackBar.TabIndex = 50;
            this.C2_ExhaustOUT_trackBar.TickFrequency = 5;
            // 
            // C2_ExhaustOUT_numericUpDown
            // 
            this.C2_ExhaustOUT_numericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.C2_ExhaustOUT_numericUpDown.Font = new System.Drawing.Font("Malgun Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.C2_ExhaustOUT_numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.C2_ExhaustOUT_numericUpDown.Location = new System.Drawing.Point(227, 20);
            this.C2_ExhaustOUT_numericUpDown.Name = "C2_ExhaustOUT_numericUpDown";
            this.C2_ExhaustOUT_numericUpDown.Size = new System.Drawing.Size(46, 26);
            this.C2_ExhaustOUT_numericUpDown.TabIndex = 41;
            this.C2_ExhaustOUT_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label36.ForeColor = System.Drawing.Color.DarkGreen;
            this.label36.Location = new System.Drawing.Point(63, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(158, 19);
            this.label36.TabIndex = 65;
            this.label36.Text = "[Cabin 2]  Exhaust OUT";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.C2_ExhaustIN_trackBar);
            this.panel8.Controls.Add(this.C2_ExhaustIN_numericUpDown);
            this.panel8.Controls.Add(this.label35);
            this.panel8.Location = new System.Drawing.Point(102, 142);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 53);
            this.panel8.TabIndex = 68;
            // 
            // C2_ExhaustIN_trackBar
            // 
            this.C2_ExhaustIN_trackBar.AutoSize = false;
            this.C2_ExhaustIN_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.C2_ExhaustIN_trackBar.Location = new System.Drawing.Point(3, 20);
            this.C2_ExhaustIN_trackBar.Maximum = 100;
            this.C2_ExhaustIN_trackBar.Name = "C2_ExhaustIN_trackBar";
            this.C2_ExhaustIN_trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C2_ExhaustIN_trackBar.Size = new System.Drawing.Size(218, 26);
            this.C2_ExhaustIN_trackBar.SmallChange = 5;
            this.C2_ExhaustIN_trackBar.TabIndex = 50;
            this.C2_ExhaustIN_trackBar.TickFrequency = 5;
            // 
            // C2_ExhaustIN_numericUpDown
            // 
            this.C2_ExhaustIN_numericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.C2_ExhaustIN_numericUpDown.Font = new System.Drawing.Font("Malgun Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.C2_ExhaustIN_numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.C2_ExhaustIN_numericUpDown.Location = new System.Drawing.Point(227, 20);
            this.C2_ExhaustIN_numericUpDown.Name = "C2_ExhaustIN_numericUpDown";
            this.C2_ExhaustIN_numericUpDown.Size = new System.Drawing.Size(46, 26);
            this.C2_ExhaustIN_numericUpDown.TabIndex = 41;
            this.C2_ExhaustIN_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label35.ForeColor = System.Drawing.Color.DarkGreen;
            this.label35.Location = new System.Drawing.Point(73, -2);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(141, 19);
            this.label35.TabIndex = 65;
            this.label35.Text = "[Cabin 2]  Exhaust IN";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.C1_ExhaustOUT_trackBar);
            this.panel6.Controls.Add(this.C1_ExhaustOUT_numericUpDown);
            this.panel6.Controls.Add(this.label34);
            this.panel6.Location = new System.Drawing.Point(102, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 53);
            this.panel6.TabIndex = 67;
            // 
            // C1_ExhaustOUT_trackBar
            // 
            this.C1_ExhaustOUT_trackBar.AutoSize = false;
            this.C1_ExhaustOUT_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.C1_ExhaustOUT_trackBar.Location = new System.Drawing.Point(3, 20);
            this.C1_ExhaustOUT_trackBar.Maximum = 100;
            this.C1_ExhaustOUT_trackBar.Name = "C1_ExhaustOUT_trackBar";
            this.C1_ExhaustOUT_trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C1_ExhaustOUT_trackBar.Size = new System.Drawing.Size(218, 26);
            this.C1_ExhaustOUT_trackBar.SmallChange = 5;
            this.C1_ExhaustOUT_trackBar.TabIndex = 50;
            this.C1_ExhaustOUT_trackBar.TickFrequency = 5;
            // 
            // C1_ExhaustOUT_numericUpDown
            // 
            this.C1_ExhaustOUT_numericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.C1_ExhaustOUT_numericUpDown.Font = new System.Drawing.Font("Malgun Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.C1_ExhaustOUT_numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.C1_ExhaustOUT_numericUpDown.Location = new System.Drawing.Point(227, 20);
            this.C1_ExhaustOUT_numericUpDown.Name = "C1_ExhaustOUT_numericUpDown";
            this.C1_ExhaustOUT_numericUpDown.Size = new System.Drawing.Size(46, 26);
            this.C1_ExhaustOUT_numericUpDown.TabIndex = 41;
            this.C1_ExhaustOUT_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label34.ForeColor = System.Drawing.Color.DarkGreen;
            this.label34.Location = new System.Drawing.Point(63, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(158, 19);
            this.label34.TabIndex = 65;
            this.label34.Text = "[Cabin 1]  Exhaust OUT";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.ACBFanSpeed_trackBar);
            this.panel7.Controls.Add(this.ExhaustFanSpeed_numericUpDown);
            this.panel7.Location = new System.Drawing.Point(6, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(90, 230);
            this.panel7.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(5, 2);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 65;
            this.label12.Text = "A/C Blower";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ACBFanSpeed_trackBar
            // 
            this.ACBFanSpeed_trackBar.AutoSize = false;
            this.ACBFanSpeed_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ACBFanSpeed_trackBar.Location = new System.Drawing.Point(55, 24);
            this.ACBFanSpeed_trackBar.Maximum = 100;
            this.ACBFanSpeed_trackBar.Name = "ACBFanSpeed_trackBar";
            this.ACBFanSpeed_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ACBFanSpeed_trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ACBFanSpeed_trackBar.Size = new System.Drawing.Size(26, 197);
            this.ACBFanSpeed_trackBar.SmallChange = 5;
            this.ACBFanSpeed_trackBar.TabIndex = 50;
            this.ACBFanSpeed_trackBar.TickFrequency = 5;
            this.ACBFanSpeed_trackBar.Scroll += new System.EventHandler(this.ExhaustFanSpeed_trackBar_Scroll);
            // 
            // ExhaustFanSpeed_numericUpDown
            // 
            this.ExhaustFanSpeed_numericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.ExhaustFanSpeed_numericUpDown.Font = new System.Drawing.Font("Malgun Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.ExhaustFanSpeed_numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ExhaustFanSpeed_numericUpDown.Location = new System.Drawing.Point(3, 27);
            this.ExhaustFanSpeed_numericUpDown.Name = "ExhaustFanSpeed_numericUpDown";
            this.ExhaustFanSpeed_numericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExhaustFanSpeed_numericUpDown.Size = new System.Drawing.Size(46, 26);
            this.ExhaustFanSpeed_numericUpDown.TabIndex = 41;
            this.ExhaustFanSpeed_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.Send_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.connection_groupBox);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.SerialMonitor_groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Cooling Control Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SerialMonitor_groupBox.ResumeLayout(false);
            this.SerialMonitor_groupBox.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.connection_groupBox.ResumeLayout(false);
            this.connection_groupBox.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1_ExhaustIN_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1_ExhaustIN_numericUpDown)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C2_ExhaustOUT_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2_ExhaustOUT_numericUpDown)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C2_ExhaustIN_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2_ExhaustIN_numericUpDown)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1_ExhaustOUT_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1_ExhaustOUT_numericUpDown)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ACBFanSpeed_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExhaustFanSpeed_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar Conn_progressBar;
        private System.Windows.Forms.Label ConnectionMsgBox_label;
        private System.Windows.Forms.Button Disconnect_button;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox SerialMonitor_groupBox;
        private System.Windows.Forms.TextBox SerialMonitor_textbox;
        private System.Windows.Forms.Label HDCPMsgbox_label;
        private System.Windows.Forms.Label DS5;
        private System.Windows.Forms.Label DS1;
        private System.Windows.Forms.Label DS7;
        private System.Windows.Forms.Label DS2;
        private System.Windows.Forms.Label DS6;
        private System.Windows.Forms.Label DS3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private CircularProgressBar.CircularProgressBar PBT1_circularProgressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private CircularProgressBar.CircularProgressBar SMT_Y_circularProgressBar;
        private CircularProgressBar.CircularProgressBar SMT_X_circularProgressBar;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private CircularProgressBar.CircularProgressBar SMT_E_circularProgressBar;
        private CircularProgressBar.CircularProgressBar SMT_Z_circularProgressBar;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label PCP_Indicator1;
        private System.Windows.Forms.Label PCP_Indicator3;
        private System.Windows.Forms.Label PCP_Indicator2;
        private System.Windows.Forms.Label PCP_Indicator4;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox ConsoleLog_textbox;
        private System.Windows.Forms.Button CheckArduinoComPort_button;
        private System.Windows.Forms.Button ConsoleClear_button;
        private System.Windows.Forms.Label ClearConsoleTextBox_label;
        private System.Windows.Forms.CheckBox CabinLight_checkBox;
        private System.Windows.Forms.CheckBox Peltier1_checkBox;
        private System.Windows.Forms.CheckBox MainPower_checkBox;
        private System.Windows.Forms.CheckBox Peltier2_checkBox;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox DIS4;
        private System.Windows.Forms.TextBox DIS5;
        private System.Windows.Forms.TextBox DIS3;
        private System.Windows.Forms.TextBox DIS6;
        private System.Windows.Forms.TextBox DIS1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox DIS2;
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Button ArduinoReset_button;
        private CircularProgressBar.CircularProgressBar PBT2_circularProgressBar;
        private CircularProgressBar.CircularProgressBar CT2_circularProgressBar;
        private CircularProgressBar.CircularProgressBar CT1_circularProgressBar;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip InfoToolTip;
        private System.Windows.Forms.ComboBox HDCPDevicelist_Combobox;
        private System.Windows.Forms.ComboBox BaudRate_comboBox;
        private System.Windows.Forms.ComboBox ComPort_comboBox;
        private System.Windows.Forms.GroupBox connection_groupBox;
        private System.Windows.Forms.TextBox Passcode_textBox;
        private System.Windows.Forms.TextBox DIS7;
        private System.Windows.Forms.Button HDCPOff_button;
        private System.Windows.Forms.Button HDCPOn_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox AutoConnect_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DIS4B;
        private System.Windows.Forms.TextBox DIS4A;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DIS3B;
        private System.Windows.Forms.TextBox DIS3A;
        private System.Windows.Forms.CheckBox Peltier4_checkBox;
        private System.Windows.Forms.Label PCP_Indicator5;
        private System.Windows.Forms.Label PCP_Indicator6;
        private System.Windows.Forms.CheckBox Peltier3_checkBox;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.TextBox Command_textBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TrackBar C2_ExhaustIN_trackBar;
        private System.Windows.Forms.NumericUpDown C2_ExhaustIN_numericUpDown;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TrackBar C1_ExhaustOUT_trackBar;
        private System.Windows.Forms.NumericUpDown C1_ExhaustOUT_numericUpDown;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TrackBar ACBFanSpeed_trackBar;
        private System.Windows.Forms.NumericUpDown ExhaustFanSpeed_numericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TrackBar C2_ExhaustOUT_trackBar;
        private System.Windows.Forms.NumericUpDown C2_ExhaustOUT_numericUpDown;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TrackBar C1_ExhaustIN_trackBar;
        private System.Windows.Forms.NumericUpDown C1_ExhaustIN_numericUpDown;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label DS4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

