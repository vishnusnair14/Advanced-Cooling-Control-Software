namespace Advanced_Cooling_Control_Software
{
    partial class SentCommandToArduino
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
            this.label1 = new System.Windows.Forms.Label();
            this.Status_label = new System.Windows.Forms.Label();
            this.Sent_groupBox = new System.Windows.Forms.GroupBox();
            this.SentCommandDirectly_checkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sent_textBox = new System.Windows.Forms.TextBox();
            this.GetInfo_button = new System.Windows.Forms.Button();
            this.SentCommand_button = new System.Windows.Forms.Button();
            this.Command_textBox = new System.Windows.Forms.TextBox();
            this.Decode_groupBox = new System.Windows.Forms.GroupBox();
            this.decodeMsg_textBox = new System.Windows.Forms.TextBox();
            this.Sent_groupBox.SuspendLayout();
            this.Decode_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection Status:";
            // 
            // Status_label
            // 
            this.Status_label.AutoEllipsis = true;
            this.Status_label.AutoSize = true;
            this.Status_label.BackColor = System.Drawing.Color.Transparent;
            this.Status_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Status_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Status_label.Location = new System.Drawing.Point(109, 17);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(53, 15);
            this.Status_label.TabIndex = 3;
            this.Status_label.Text = "OFFLINE";
            // 
            // Sent_groupBox
            // 
            this.Sent_groupBox.Controls.Add(this.SentCommandDirectly_checkBox);
            this.Sent_groupBox.Controls.Add(this.label2);
            this.Sent_groupBox.Controls.Add(this.Sent_textBox);
            this.Sent_groupBox.Controls.Add(this.GetInfo_button);
            this.Sent_groupBox.Controls.Add(this.SentCommand_button);
            this.Sent_groupBox.Controls.Add(this.Status_label);
            this.Sent_groupBox.Controls.Add(this.Command_textBox);
            this.Sent_groupBox.Controls.Add(this.label1);
            this.Sent_groupBox.Location = new System.Drawing.Point(66, 12);
            this.Sent_groupBox.Name = "Sent_groupBox";
            this.Sent_groupBox.Size = new System.Drawing.Size(244, 153);
            this.Sent_groupBox.TabIndex = 4;
            this.Sent_groupBox.TabStop = false;
            this.Sent_groupBox.Text = "Sent Command";
            // 
            // SentCommandDirectly_checkBox
            // 
            this.SentCommandDirectly_checkBox.AutoSize = true;
            this.SentCommandDirectly_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.SentCommandDirectly_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SentCommandDirectly_checkBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SentCommandDirectly_checkBox.Location = new System.Drawing.Point(5, 131);
            this.SentCommandDirectly_checkBox.Name = "SentCommandDirectly_checkBox";
            this.SentCommandDirectly_checkBox.Size = new System.Drawing.Size(192, 17);
            this.SentCommandDirectly_checkBox.TabIndex = 73;
            this.SentCommandDirectly_checkBox.Text = "Sent commands from serial console";
            this.SentCommandDirectly_checkBox.UseVisualStyleBackColor = false;
            this.SentCommandDirectly_checkBox.CheckedChanged += new System.EventHandler(this.SentCommandDirectly_checkBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Commands:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Sent_textBox
            // 
            this.Sent_textBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sent_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sent_textBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Sent_textBox.Location = new System.Drawing.Point(5, 105);
            this.Sent_textBox.Name = "Sent_textBox";
            this.Sent_textBox.ReadOnly = true;
            this.Sent_textBox.Size = new System.Drawing.Size(235, 20);
            this.Sent_textBox.TabIndex = 63;
            this.Sent_textBox.Text = "CONNECTED";
            this.Sent_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GetInfo_button
            // 
            this.GetInfo_button.Location = new System.Drawing.Point(127, 74);
            this.GetInfo_button.Name = "GetInfo_button";
            this.GetInfo_button.Size = new System.Drawing.Size(113, 23);
            this.GetInfo_button.TabIndex = 62;
            this.GetInfo_button.Text = "GET INFO";
            this.GetInfo_button.UseVisualStyleBackColor = true;
            this.GetInfo_button.Click += new System.EventHandler(this.GetInfo_button_Click);
            // 
            // SentCommand_button
            // 
            this.SentCommand_button.Location = new System.Drawing.Point(5, 74);
            this.SentCommand_button.Name = "SentCommand_button";
            this.SentCommand_button.Size = new System.Drawing.Size(116, 23);
            this.SentCommand_button.TabIndex = 61;
            this.SentCommand_button.Text = "SENT COMMAND";
            this.SentCommand_button.UseVisualStyleBackColor = true;
            this.SentCommand_button.Click += new System.EventHandler(this.SentCommand_button_Click);
            // 
            // Command_textBox
            // 
            this.Command_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Command_textBox.Location = new System.Drawing.Point(88, 44);
            this.Command_textBox.Name = "Command_textBox";
            this.Command_textBox.Size = new System.Drawing.Size(147, 20);
            this.Command_textBox.TabIndex = 59;
            this.Command_textBox.TextChanged += new System.EventHandler(this.Command_textBox_TextChanged);
            // 
            // Decode_groupBox
            // 
            this.Decode_groupBox.Controls.Add(this.decodeMsg_textBox);
            this.Decode_groupBox.Location = new System.Drawing.Point(10, 171);
            this.Decode_groupBox.Name = "Decode_groupBox";
            this.Decode_groupBox.Size = new System.Drawing.Size(358, 104);
            this.Decode_groupBox.TabIndex = 5;
            this.Decode_groupBox.TabStop = false;
            this.Decode_groupBox.Text = "Decoded Message";
            // 
            // decodeMsg_textBox
            // 
            this.decodeMsg_textBox.Location = new System.Drawing.Point(6, 19);
            this.decodeMsg_textBox.Multiline = true;
            this.decodeMsg_textBox.Name = "decodeMsg_textBox";
            this.decodeMsg_textBox.Size = new System.Drawing.Size(346, 76);
            this.decodeMsg_textBox.TabIndex = 0;
            // 
            // SentCommandToArduino
            // 
            this.AcceptButton = this.SentCommand_button;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(380, 280);
            this.ControlBox = false;
            this.Controls.Add(this.Decode_groupBox);
            this.Controls.Add(this.Sent_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SentCommandToArduino";
            this.ShowInTaskbar = false;
            this.Text = "Sent_Commands_to_Arduino";
            this.TopMost = true;
            this.Sent_groupBox.ResumeLayout(false);
            this.Sent_groupBox.PerformLayout();
            this.Decode_groupBox.ResumeLayout(false);
            this.Decode_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.GroupBox Sent_groupBox;
        private System.Windows.Forms.TextBox Command_textBox;
        private System.Windows.Forms.Button SentCommand_button;
        private System.Windows.Forms.Button GetInfo_button;
        private System.Windows.Forms.TextBox Sent_textBox;
        private System.Windows.Forms.GroupBox Decode_groupBox;
        private System.Windows.Forms.TextBox decodeMsg_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SentCommandDirectly_checkBox;
    }
}