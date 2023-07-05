namespace Advanced_Cooling_Control_Software
{
    partial class LoadFirmware
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
            this.connection_groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AutoConnect_checkBox = new System.Windows.Forms.CheckBox();
            this.Connect_button = new System.Windows.Forms.Button();
            this.ArduinoReset_button = new System.Windows.Forms.Button();
            this.CheckArduinoComPort_button = new System.Windows.Forms.Button();
            this.Passcode_textBox = new System.Windows.Forms.TextBox();
            this.ComPort_comboBox = new System.Windows.Forms.ComboBox();
            this.BaudRate_comboBox = new System.Windows.Forms.ComboBox();
            this.ConnectionMsgBox_label = new System.Windows.Forms.Label();
            this.Conn_progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.connection_groupBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.connection_groupBox.Location = new System.Drawing.Point(28, 45);
            this.connection_groupBox.Name = "connection_groupBox";
            this.connection_groupBox.Size = new System.Drawing.Size(215, 260);
            this.connection_groupBox.TabIndex = 57;
            this.connection_groupBox.TabStop = false;
            this.connection_groupBox.Text = "Connection Panel";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "File Path:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 58);
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
            this.label17.Location = new System.Drawing.Point(15, 30);
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
            this.panel5.Controls.Add(this.CheckArduinoComPort_button);
            this.panel5.Location = new System.Drawing.Point(6, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 91);
            this.panel5.TabIndex = 56;
            // 
            // AutoConnect_checkBox
            // 
            this.AutoConnect_checkBox.AutoSize = true;
            this.AutoConnect_checkBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AutoConnect_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AutoConnect_checkBox.ForeColor = System.Drawing.Color.Blue;
            this.AutoConnect_checkBox.Location = new System.Drawing.Point(5, 62);
            this.AutoConnect_checkBox.Name = "AutoConnect_checkBox";
            this.AutoConnect_checkBox.Size = new System.Drawing.Size(188, 17);
            this.AutoConnect_checkBox.TabIndex = 57;
            this.AutoConnect_checkBox.Text = "Auto connect to UNO after search";
            this.AutoConnect_checkBox.UseVisualStyleBackColor = false;
            // 
            // Connect_button
            // 
            this.Connect_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Connect_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Connect_button.ForeColor = System.Drawing.Color.White;
            this.Connect_button.Location = new System.Drawing.Point(3, 3);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(190, 26);
            this.Connect_button.TabIndex = 8;
            this.Connect_button.Text = "Upload Firmware";
            this.Connect_button.UseVisualStyleBackColor = false;
            // 
            // ArduinoReset_button
            // 
            this.ArduinoReset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ArduinoReset_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ArduinoReset_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ArduinoReset_button.ForeColor = System.Drawing.Color.White;
            this.ArduinoReset_button.Location = new System.Drawing.Point(100, 30);
            this.ArduinoReset_button.Name = "ArduinoReset_button";
            this.ArduinoReset_button.Size = new System.Drawing.Size(93, 26);
            this.ArduinoReset_button.TabIndex = 34;
            this.ArduinoReset_button.Text = "Reset UNO";
            this.ArduinoReset_button.UseVisualStyleBackColor = false;
            // 
            // CheckArduinoComPort_button
            // 
            this.CheckArduinoComPort_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CheckArduinoComPort_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.CheckArduinoComPort_button.ForeColor = System.Drawing.Color.White;
            this.CheckArduinoComPort_button.Location = new System.Drawing.Point(3, 30);
            this.CheckArduinoComPort_button.Name = "CheckArduinoComPort_button";
            this.CheckArduinoComPort_button.Size = new System.Drawing.Size(91, 26);
            this.CheckArduinoComPort_button.TabIndex = 31;
            this.CheckArduinoComPort_button.Text = "Search UNO";
            this.CheckArduinoComPort_button.UseVisualStyleBackColor = false;
            // 
            // Passcode_textBox
            // 
            this.Passcode_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Passcode_textBox.Location = new System.Drawing.Point(94, 84);
            this.Passcode_textBox.Name = "Passcode_textBox";
            this.Passcode_textBox.Size = new System.Drawing.Size(115, 20);
            this.Passcode_textBox.TabIndex = 55;
            // 
            // ComPort_comboBox
            // 
            this.ComPort_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComPort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPort_comboBox.DropDownWidth = 150;
            this.ComPort_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.ComPort_comboBox.FormattingEnabled = true;
            this.ComPort_comboBox.Location = new System.Drawing.Point(93, 26);
            this.ComPort_comboBox.Name = "ComPort_comboBox";
            this.ComPort_comboBox.Size = new System.Drawing.Size(115, 21);
            this.ComPort_comboBox.TabIndex = 2;
            // 
            // BaudRate_comboBox
            // 
            this.BaudRate_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.BaudRate_comboBox.FormattingEnabled = true;
            this.BaudRate_comboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BaudRate_comboBox.Location = new System.Drawing.Point(94, 55);
            this.BaudRate_comboBox.Name = "BaudRate_comboBox";
            this.BaudRate_comboBox.Size = new System.Drawing.Size(114, 21);
            this.BaudRate_comboBox.TabIndex = 3;
            // 
            // ConnectionMsgBox_label
            // 
            this.ConnectionMsgBox_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConnectionMsgBox_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConnectionMsgBox_label.Font = new System.Drawing.Font("Malgun Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.ConnectionMsgBox_label.ForeColor = System.Drawing.Color.White;
            this.ConnectionMsgBox_label.Location = new System.Drawing.Point(6, 113);
            this.ConnectionMsgBox_label.Name = "ConnectionMsgBox_label";
            this.ConnectionMsgBox_label.Size = new System.Drawing.Size(202, 24);
            this.ConnectionMsgBox_label.TabIndex = 6;
            this.ConnectionMsgBox_label.Text = "Upload Success";
            this.ConnectionMsgBox_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conn_progressBar
            // 
            this.Conn_progressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Conn_progressBar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Conn_progressBar.Location = new System.Drawing.Point(6, 140);
            this.Conn_progressBar.MarqueeAnimationSpeed = 10;
            this.Conn_progressBar.Name = "Conn_progressBar";
            this.Conn_progressBar.Size = new System.Drawing.Size(202, 6);
            this.Conn_progressBar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "LOAD FIRMWARE TO ARDUINO";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 315);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connection_groupBox);
            this.Name = "LoadFirmware";
            this.Text = "Load Firmware";
            this.connection_groupBox.ResumeLayout(false);
            this.connection_groupBox.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox connection_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox AutoConnect_checkBox;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Button ArduinoReset_button;
        private System.Windows.Forms.Button CheckArduinoComPort_button;
        private System.Windows.Forms.TextBox Passcode_textBox;
        private System.Windows.Forms.ComboBox ComPort_comboBox;
        private System.Windows.Forms.ComboBox BaudRate_comboBox;
        private System.Windows.Forms.Label ConnectionMsgBox_label;
        private System.Windows.Forms.ProgressBar Conn_progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}