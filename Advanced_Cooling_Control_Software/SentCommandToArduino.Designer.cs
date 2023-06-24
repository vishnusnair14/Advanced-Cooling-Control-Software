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
            this.Connection_label = new System.Windows.Forms.Label();
            this.Sent_textBox = new System.Windows.Forms.TextBox();
            this.GetInfo_button = new System.Windows.Forms.Button();
            this.SentCommand_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Sent_groupBox.Controls.Add(this.Connection_label);
            this.Sent_groupBox.Controls.Add(this.Sent_textBox);
            this.Sent_groupBox.Controls.Add(this.GetInfo_button);
            this.Sent_groupBox.Controls.Add(this.SentCommand_button);
            this.Sent_groupBox.Controls.Add(this.label2);
            this.Sent_groupBox.Controls.Add(this.Status_label);
            this.Sent_groupBox.Controls.Add(this.Command_textBox);
            this.Sent_groupBox.Controls.Add(this.label1);
            this.Sent_groupBox.Location = new System.Drawing.Point(66, 12);
            this.Sent_groupBox.Name = "Sent_groupBox";
            this.Sent_groupBox.Size = new System.Drawing.Size(244, 148);
            this.Sent_groupBox.TabIndex = 4;
            this.Sent_groupBox.TabStop = false;
            this.Sent_groupBox.Text = "Sent Command";
            // 
            // Connection_label
            // 
            this.Connection_label.Location = new System.Drawing.Point(5, 130);
            this.Connection_label.Name = "Connection_label";
            this.Connection_label.Size = new System.Drawing.Size(235, 13);
            this.Connection_label.TabIndex = 6;
            this.Connection_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Sent_textBox
            // 
            this.Sent_textBox.Location = new System.Drawing.Point(5, 103);
            this.Sent_textBox.Multiline = true;
            this.Sent_textBox.Name = "Sent_textBox";
            this.Sent_textBox.Size = new System.Drawing.Size(235, 24);
            this.Sent_textBox.TabIndex = 63;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Command:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Command_textBox
            // 
            this.Command_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Command_textBox.Location = new System.Drawing.Point(88, 44);
            this.Command_textBox.Name = "Command_textBox";
            this.Command_textBox.Size = new System.Drawing.Size(147, 20);
            this.Command_textBox.TabIndex = 59;
            // 
            // Decode_groupBox
            // 
            this.Decode_groupBox.Controls.Add(this.decodeMsg_textBox);
            this.Decode_groupBox.Location = new System.Drawing.Point(12, 167);
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
            this.ClientSize = new System.Drawing.Size(382, 276);
            this.ControlBox = false;
            this.Controls.Add(this.Decode_groupBox);
            this.Controls.Add(this.Sent_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SentCommandToArduino";
            this.ShowInTaskbar = false;
            this.Text = "Sent_Commands_to_Arduino";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Command_textBox;
        private System.Windows.Forms.Button SentCommand_button;
        private System.Windows.Forms.Button GetInfo_button;
        private System.Windows.Forms.TextBox Sent_textBox;
        private System.Windows.Forms.GroupBox Decode_groupBox;
        private System.Windows.Forms.TextBox decodeMsg_textBox;
        private System.Windows.Forms.Label Connection_label;
    }
}