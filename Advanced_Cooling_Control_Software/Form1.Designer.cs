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
            this.DCS_indicator6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.DCS_indicator4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DCS_indicator2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DCS_indicator5 = new System.Windows.Forms.Label();
            this.DCS_indicator3 = new System.Windows.Forms.Label();
            this.DCS_indicator1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HDCPOff_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.HDCPOn_button = new System.Windows.Forms.Button();
            this.HDCPDevicelist_Combobox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.ClearConsoleTextBox_label = new System.Windows.Forms.Label();
            this.ConsoleClear_button = new System.Windows.Forms.Button();
            this.ConsoleLog_textbox = new System.Windows.Forms.TextBox();
            this.DIS3 = new System.Windows.Forms.TextBox();
            this.DIS5 = new System.Windows.Forms.TextBox();
            this.DIS4 = new System.Windows.Forms.TextBox();
            this.DIS6 = new System.Windows.Forms.TextBox();
            this.DIS1 = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DIS2A = new System.Windows.Forms.TextBox();
            this.DIS1A = new System.Windows.Forms.TextBox();
            this.DIS7 = new System.Windows.Forms.TextBox();
            this.DIS2 = new System.Windows.Forms.TextBox();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BaudRate_comboBox = new System.Windows.Forms.ComboBox();
            this.ComPort_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AutoConnect_checkBox = new System.Windows.Forms.CheckBox();
            this.Passcode_textBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ExhaustFanSpeed_trackBar = new System.Windows.Forms.TrackBar();
            this.ExhaustFanSpeed_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SerialMonitor_groupBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExhaustFanSpeed_trackBar)).BeginInit();
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
            this.Peltier2_checkBox.Location = new System.Drawing.Point(260, 39);
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
            this.Peltier1_checkBox.Location = new System.Drawing.Point(98, 40);
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
            this.MainPower_checkBox.Location = new System.Drawing.Point(99, 7);
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
            this.CabinLight_checkBox.Location = new System.Drawing.Point(260, 6);
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
            this.PCP_Indicator4.Location = new System.Drawing.Point(309, 39);
            this.PCP_Indicator4.Name = "PCP_Indicator4";
            this.PCP_Indicator4.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator4.TabIndex = 30;
            // 
            // PCP_Indicator3
            // 
            this.PCP_Indicator3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator3.Location = new System.Drawing.Point(147, 41);
            this.PCP_Indicator3.Name = "PCP_Indicator3";
            this.PCP_Indicator3.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator3.TabIndex = 29;
            // 
            // PCP_Indicator2
            // 
            this.PCP_Indicator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator2.Location = new System.Drawing.Point(309, 6);
            this.PCP_Indicator2.Name = "PCP_Indicator2";
            this.PCP_Indicator2.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator2.TabIndex = 28;
            // 
            // PCP_Indicator1
            // 
            this.PCP_Indicator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCP_Indicator1.Location = new System.Drawing.Point(147, 7);
            this.PCP_Indicator1.Name = "PCP_Indicator1";
            this.PCP_Indicator1.Size = new System.Drawing.Size(11, 26);
            this.PCP_Indicator1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GhostWhite;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(196, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Peltier 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GhostWhite;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(35, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peltier 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.GhostWhite;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(170, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cabin Lights:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 15);
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
            this.HDCPMsgbox_label.Size = new System.Drawing.Size(199, 27);
            this.HDCPMsgbox_label.TabIndex = 10;
            this.HDCPMsgbox_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DCS_indicator6
            // 
            this.DCS_indicator6.BackColor = System.Drawing.Color.Maroon;
            this.DCS_indicator6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DCS_indicator6.Location = new System.Drawing.Point(108, 124);
            this.DCS_indicator6.Name = "DCS_indicator6";
            this.DCS_indicator6.Size = new System.Drawing.Size(17, 21);
            this.DCS_indicator6.TabIndex = 34;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Gainsboro;
            this.label23.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(21, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 15);
            this.label23.TabIndex = 33;
            this.label23.Text = "Exhaust Fans";
            // 
            // DCS_indicator4
            // 
            this.DCS_indicator4.BackColor = System.Drawing.Color.Maroon;
            this.DCS_indicator4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DCS_indicator4.Location = new System.Drawing.Point(108, 75);
            this.DCS_indicator4.Name = "DCS_indicator4";
            this.DCS_indicator4.Size = new System.Drawing.Size(17, 21);
            this.DCS_indicator4.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Gainsboro;
            this.label21.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(8, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 15);
            this.label21.TabIndex = 31;
            this.label21.Text = "Radiator Pump";
            // 
            // DCS_indicator2
            // 
            this.DCS_indicator2.BackColor = System.Drawing.Color.Maroon;
            this.DCS_indicator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DCS_indicator2.ForeColor = System.Drawing.Color.Goldenrod;
            this.DCS_indicator2.Location = new System.Drawing.Point(108, 26);
            this.DCS_indicator2.Name = "DCS_indicator2";
            this.DCS_indicator2.Size = new System.Drawing.Size(17, 21);
            this.DCS_indicator2.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Gainsboro;
            this.label19.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "Cabin Exhaust 2";
            // 
            // DCS_indicator5
            // 
            this.DCS_indicator5.BackColor = System.Drawing.Color.Maroon;
            this.DCS_indicator5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DCS_indicator5.Location = new System.Drawing.Point(108, 100);
            this.DCS_indicator5.Name = "DCS_indicator5";
            this.DCS_indicator5.Size = new System.Drawing.Size(17, 21);
            this.DCS_indicator5.TabIndex = 28;
            // 
            // DCS_indicator3
            // 
            this.DCS_indicator3.BackColor = System.Drawing.Color.Maroon;
            this.DCS_indicator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DCS_indicator3.Location = new System.Drawing.Point(108, 50);
            this.DCS_indicator3.Name = "DCS_indicator3";
            this.DCS_indicator3.Size = new System.Drawing.Size(17, 21);
            this.DCS_indicator3.TabIndex = 27;
            // 
            // DCS_indicator1
            // 
            this.DCS_indicator1.BackColor = System.Drawing.Color.Maroon;
            this.DCS_indicator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DCS_indicator1.Location = new System.Drawing.Point(108, 2);
            this.DCS_indicator1.Name = "DCS_indicator1";
            this.DCS_indicator1.Size = new System.Drawing.Size(17, 21);
            this.DCS_indicator1.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(15, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Radiator Fans";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Gainsboro;
            this.label14.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(14, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Coolant Pump";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Cabin Exhaust 1";
            // 
            // SerialMonitor_groupBox
            // 
            this.SerialMonitor_groupBox.Controls.Add(this.SerialMonitor_textbox);
            this.SerialMonitor_groupBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.SerialMonitor_groupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SerialMonitor_groupBox.Location = new System.Drawing.Point(14, 291);
            this.SerialMonitor_groupBox.Name = "SerialMonitor_groupBox";
            this.SerialMonitor_groupBox.Size = new System.Drawing.Size(407, 210);
            this.SerialMonitor_groupBox.TabIndex = 2;
            this.SerialMonitor_groupBox.TabStop = false;
            this.SerialMonitor_groupBox.Text = "Serial Console";
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
            this.SerialMonitor_textbox.Size = new System.Drawing.Size(391, 178);
            this.SerialMonitor_textbox.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox7.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox7.Location = new System.Drawing.Point(441, 291);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(981, 447);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Temperature Monitor";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.CT2_circularProgressBar);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.CT1_circularProgressBar);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F);
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
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.panel4);
            this.groupBox13.Controls.Add(this.label11);
            this.groupBox13.Controls.Add(this.panel3);
            this.groupBox13.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox13.Location = new System.Drawing.Point(632, 14);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(355, 260);
            this.groupBox13.TabIndex = 38;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Hardware Device Control";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(6, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 17);
            this.label16.TabIndex = 64;
            this.label16.Text = "Device Control";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label22.Location = new System.Drawing.Point(6, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 17);
            this.label22.TabIndex = 63;
            this.label22.Text = "Power Control";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.HDCPOff_button);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.HDCPOn_button);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.HDCPDevicelist_Combobox);
            this.panel4.Controls.Add(this.HDCPMsgbox_label);
            this.panel4.Location = new System.Drawing.Point(9, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 90);
            this.panel4.TabIndex = 59;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.GhostWhite;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Please select a device:";
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
            "Cabin Exhaust 1",
            "Cabin Exhaust 2",
            "Coolant Pump",
            "Radiator Pump",
            "Radiator Fans",
            "Exhaust Fans"});
            this.HDCPDevicelist_Combobox.Location = new System.Drawing.Point(168, 7);
            this.HDCPDevicelist_Combobox.Name = "HDCPDevicelist_Combobox";
            this.HDCPDevicelist_Combobox.Size = new System.Drawing.Size(152, 23);
            this.HDCPDevicelist_Combobox.TabIndex = 10;
            this.HDCPDevicelist_Combobox.SelectedIndexChanged += new System.EventHandler(this.Hdcp_Devicelists_Combobox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel3.Size = new System.Drawing.Size(332, 76);
            this.panel3.TabIndex = 57;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.ClearConsoleTextBox_label);
            this.groupBox11.Controls.Add(this.ConsoleClear_button);
            this.groupBox11.Controls.Add(this.ConsoleLog_textbox);
            this.groupBox11.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox11.Location = new System.Drawing.Point(14, 517);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(407, 485);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Log Monitor";
            // 
            // ClearConsoleTextBox_label
            // 
            this.ClearConsoleTextBox_label.BackColor = System.Drawing.Color.DarkGray;
            this.ClearConsoleTextBox_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.25F);
            this.ClearConsoleTextBox_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearConsoleTextBox_label.Location = new System.Drawing.Point(94, 456);
            this.ClearConsoleTextBox_label.Name = "ClearConsoleTextBox_label";
            this.ClearConsoleTextBox_label.Size = new System.Drawing.Size(304, 21);
            this.ClearConsoleTextBox_label.TabIndex = 2;
            this.ClearConsoleTextBox_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsoleClear_button
            // 
            this.ConsoleClear_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsoleClear_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleClear_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.ConsoleClear_button.Location = new System.Drawing.Point(7, 451);
            this.ConsoleClear_button.Name = "ConsoleClear_button";
            this.ConsoleClear_button.Size = new System.Drawing.Size(81, 27);
            this.ConsoleClear_button.TabIndex = 1;
            this.ConsoleClear_button.Text = "Clear Log";
            this.ConsoleClear_button.UseVisualStyleBackColor = false;
            this.ConsoleClear_button.Click += new System.EventHandler(this.ConsoleClear_button_Click);
            // 
            // ConsoleLog_textbox
            // 
            this.ConsoleLog_textbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConsoleLog_textbox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLog_textbox.Location = new System.Drawing.Point(7, 22);
            this.ConsoleLog_textbox.Multiline = true;
            this.ConsoleLog_textbox.Name = "ConsoleLog_textbox";
            this.ConsoleLog_textbox.ReadOnly = true;
            this.ConsoleLog_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleLog_textbox.Size = new System.Drawing.Size(391, 422);
            this.ConsoleLog_textbox.TabIndex = 0;
            // 
            // DIS3
            // 
            this.DIS3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS3.ForeColor = System.Drawing.Color.White;
            this.DIS3.Location = new System.Drawing.Point(3, 90);
            this.DIS3.Name = "DIS3";
            this.DIS3.ReadOnly = true;
            this.DIS3.Size = new System.Drawing.Size(106, 23);
            this.DIS3.TabIndex = 9;
            this.DIS3.Text = "PCF8574 I/O Pins";
            this.DIS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS5
            // 
            this.DIS5.BackColor = System.Drawing.Color.DimGray;
            this.DIS5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS5.ForeColor = System.Drawing.Color.White;
            this.DIS5.Location = new System.Drawing.Point(3, 148);
            this.DIS5.Name = "DIS5";
            this.DIS5.ReadOnly = true;
            this.DIS5.Size = new System.Drawing.Size(160, 23);
            this.DIS5.TabIndex = 14;
            this.DIS5.Text = "Auto INIT DS18B20 ";
            this.DIS5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS4
            // 
            this.DIS4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS4.ForeColor = System.Drawing.Color.White;
            this.DIS4.Location = new System.Drawing.Point(3, 61);
            this.DIS4.Name = "DIS4";
            this.DIS4.ReadOnly = true;
            this.DIS4.Size = new System.Drawing.Size(106, 23);
            this.DIS4.TabIndex = 12;
            this.DIS4.Text = "PCF8574 Module";
            this.DIS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS6
            // 
            this.DIS6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS6.ForeColor = System.Drawing.Color.White;
            this.DIS6.Location = new System.Drawing.Point(3, 119);
            this.DIS6.Name = "DIS6";
            this.DIS6.ReadOnly = true;
            this.DIS6.Size = new System.Drawing.Size(160, 23);
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
            this.DIS1.Size = new System.Drawing.Size(160, 23);
            this.DIS1.TabIndex = 14;
            this.DIS1.Text = "Serial Communication";
            this.DIS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            this.groupBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox12.Controls.Add(this.label20);
            this.groupBox12.Controls.Add(this.label18);
            this.groupBox12.Controls.Add(this.panel2);
            this.groupBox12.Controls.Add(this.panel1);
            this.groupBox12.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox12.Location = new System.Drawing.Point(278, 14);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(338, 260);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Status Panel";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label20.Location = new System.Drawing.Point(188, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 17);
            this.label20.TabIndex = 62;
            this.label20.Text = "Device Status";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label18.Location = new System.Drawing.Point(6, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 17);
            this.label18.TabIndex = 61;
            this.label18.Text = "Initilalization Status";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.DCS_indicator6);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.DCS_indicator4);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.DCS_indicator1);
            this.panel2.Controls.Add(this.DCS_indicator2);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.DCS_indicator3);
            this.panel2.Controls.Add(this.DCS_indicator5);
            this.panel2.Location = new System.Drawing.Point(191, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 210);
            this.panel2.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.DIS2A);
            this.panel1.Controls.Add(this.DIS1A);
            this.panel1.Controls.Add(this.DIS7);
            this.panel1.Controls.Add(this.DIS1);
            this.panel1.Controls.Add(this.DIS3);
            this.panel1.Controls.Add(this.DIS6);
            this.panel1.Controls.Add(this.DIS2);
            this.panel1.Controls.Add(this.DIS4);
            this.panel1.Controls.Add(this.DIS5);
            this.panel1.Location = new System.Drawing.Point(9, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 210);
            this.panel1.TabIndex = 57;
            // 
            // DIS2A
            // 
            this.DIS2A.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS2A.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS2A.ForeColor = System.Drawing.Color.White;
            this.DIS2A.Location = new System.Drawing.Point(142, 61);
            this.DIS2A.Name = "DIS2A";
            this.DIS2A.ReadOnly = true;
            this.DIS2A.Size = new System.Drawing.Size(21, 23);
            this.DIS2A.TabIndex = 17;
            this.DIS2A.Text = "2";
            this.DIS2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS1A
            // 
            this.DIS1A.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIS1A.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS1A.ForeColor = System.Drawing.Color.White;
            this.DIS1A.Location = new System.Drawing.Point(115, 61);
            this.DIS1A.Name = "DIS1A";
            this.DIS1A.ReadOnly = true;
            this.DIS1A.Size = new System.Drawing.Size(21, 23);
            this.DIS1A.TabIndex = 16;
            this.DIS1A.Text = "1";
            this.DIS1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DIS7
            // 
            this.DIS7.BackColor = System.Drawing.Color.DimGray;
            this.DIS7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS7.ForeColor = System.Drawing.Color.White;
            this.DIS7.Location = new System.Drawing.Point(3, 177);
            this.DIS7.Name = "DIS7";
            this.DIS7.ReadOnly = true;
            this.DIS7.Size = new System.Drawing.Size(160, 23);
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
            this.DIS2.Size = new System.Drawing.Size(160, 23);
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
            this.BaudRate_comboBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F);
            this.BaudRate_comboBox.FormattingEnabled = true;
            this.BaudRate_comboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BaudRate_comboBox.Location = new System.Drawing.Point(94, 58);
            this.BaudRate_comboBox.Name = "BaudRate_comboBox";
            this.BaudRate_comboBox.Size = new System.Drawing.Size(147, 23);
            this.BaudRate_comboBox.TabIndex = 3;
            // 
            // ComPort_comboBox
            // 
            this.ComPort_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComPort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPort_comboBox.DropDownWidth = 150;
            this.ComPort_comboBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F);
            this.ComPort_comboBox.FormattingEnabled = true;
            this.ComPort_comboBox.Location = new System.Drawing.Point(93, 29);
            this.ComPort_comboBox.Name = "ComPort_comboBox";
            this.ComPort_comboBox.Size = new System.Drawing.Size(147, 23);
            this.ComPort_comboBox.TabIndex = 2;
            this.ComPort_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComPort_comboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.Passcode_textBox);
            this.groupBox1.Controls.Add(this.ComPort_comboBox);
            this.groupBox1.Controls.Add(this.BaudRate_comboBox);
            this.groupBox1.Controls.Add(this.ConnectionMsgBox_label);
            this.groupBox1.Controls.Add(this.Conn_progressBar);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 260);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Panel";
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
            this.panel5.Size = new System.Drawing.Size(234, 88);
            this.panel5.TabIndex = 56;
            // 
            // AutoConnect_checkBox
            // 
            this.AutoConnect_checkBox.AutoSize = true;
            this.AutoConnect_checkBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoConnect_checkBox.ForeColor = System.Drawing.Color.Navy;
            this.AutoConnect_checkBox.Location = new System.Drawing.Point(5, 63);
            this.AutoConnect_checkBox.Name = "AutoConnect_checkBox";
            this.AutoConnect_checkBox.Size = new System.Drawing.Size(217, 19);
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
            this.Passcode_textBox.Size = new System.Drawing.Size(147, 21);
            this.Passcode_textBox.TabIndex = 55;
            this.Passcode_textBox.Text = "20222023v";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Gainsboro;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(19, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "COM Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Password:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(1002, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 260);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed Control";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.ExhaustFanSpeed_trackBar);
            this.panel7.Controls.Add(this.ExhaustFanSpeed_numericUpDown);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(6, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 53);
            this.panel7.TabIndex = 66;
            // 
            // ExhaustFanSpeed_trackBar
            // 
            this.ExhaustFanSpeed_trackBar.AutoSize = false;
            this.ExhaustFanSpeed_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExhaustFanSpeed_trackBar.Location = new System.Drawing.Point(3, 20);
            this.ExhaustFanSpeed_trackBar.Maximum = 100;
            this.ExhaustFanSpeed_trackBar.Name = "ExhaustFanSpeed_trackBar";
            this.ExhaustFanSpeed_trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExhaustFanSpeed_trackBar.Size = new System.Drawing.Size(218, 26);
            this.ExhaustFanSpeed_trackBar.SmallChange = 5;
            this.ExhaustFanSpeed_trackBar.TabIndex = 50;
            this.ExhaustFanSpeed_trackBar.TickFrequency = 5;
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
            this.ExhaustFanSpeed_numericUpDown.Location = new System.Drawing.Point(227, 20);
            this.ExhaustFanSpeed_numericUpDown.Name = "ExhaustFanSpeed_numericUpDown";
            this.ExhaustFanSpeed_numericUpDown.Size = new System.Drawing.Size(59, 26);
            this.ExhaustFanSpeed_numericUpDown.TabIndex = 41;
            this.ExhaustFanSpeed_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(77, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "Exhaust Fan (OUT)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.GhostWhite;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Actions:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(115, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(21, 23);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(142, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(21, 23);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1490, 1060);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.SerialMonitor_groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Cooling Control Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExhaustFanSpeed_trackBar)).EndInit();
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label DCS_indicator1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label DCS_indicator3;
        private System.Windows.Forms.Label DCS_indicator5;
        private System.Windows.Forms.Label DCS_indicator2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label DCS_indicator4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label DCS_indicator6;
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
        private System.Windows.Forms.TextBox DIS3;
        private System.Windows.Forms.TextBox DIS5;
        private System.Windows.Forms.TextBox DIS4;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox HDCPDevicelist_Combobox;
        private System.Windows.Forms.ComboBox BaudRate_comboBox;
        private System.Windows.Forms.ComboBox ComPort_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Passcode_textBox;
        private System.Windows.Forms.TextBox DIS7;
        private System.Windows.Forms.Button HDCPOff_button;
        private System.Windows.Forms.Button HDCPOn_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox AutoConnect_checkBox;
        private System.Windows.Forms.TextBox DIS2A;
        private System.Windows.Forms.TextBox DIS1A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TrackBar ExhaustFanSpeed_trackBar;
        private System.Windows.Forms.NumericUpDown ExhaustFanSpeed_numericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

