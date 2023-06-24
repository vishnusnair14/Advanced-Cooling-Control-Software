namespace Advanced_Cooling_Control_Software
{
    partial class DecodeCommands
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CommandFilePath_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DecodeCommand_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Command_textBox = new System.Windows.Forms.TextBox();
            this.CommandType_comboBox = new System.Windows.Forms.ComboBox();
            this.Decode_groupBox = new System.Windows.Forms.GroupBox();
            this.DecodeMsg_textBox = new System.Windows.Forms.TextBox();
            this.OpenCommand_MaplinkLabel = new System.Windows.Forms.LinkLabel();
            this.CloseCommand_MaplinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.Decode_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CommandFilePath_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DecodeCommand_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Command_textBox);
            this.groupBox1.Controls.Add(this.CommandType_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decode Commands";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CommandFilePath_textBox
            // 
            this.CommandFilePath_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CommandFilePath_textBox.Location = new System.Drawing.Point(96, 47);
            this.CommandFilePath_textBox.Name = "CommandFilePath_textBox";
            this.CommandFilePath_textBox.Size = new System.Drawing.Size(225, 20);
            this.CommandFilePath_textBox.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Code File Path:";
            // 
            // DecodeCommand_button
            // 
            this.DecodeCommand_button.Location = new System.Drawing.Point(241, 73);
            this.DecodeCommand_button.Name = "DecodeCommand_button";
            this.DecodeCommand_button.Size = new System.Drawing.Size(80, 21);
            this.DecodeCommand_button.TabIndex = 63;
            this.DecodeCommand_button.Text = "DECODE";
            this.DecodeCommand_button.UseVisualStyleBackColor = true;
            this.DecodeCommand_button.Click += new System.EventHandler(this.DecodeCommand_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Command:";
            // 
            // Command_textBox
            // 
            this.Command_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Command_textBox.Location = new System.Drawing.Point(96, 73);
            this.Command_textBox.Name = "Command_textBox";
            this.Command_textBox.Size = new System.Drawing.Size(139, 20);
            this.Command_textBox.TabIndex = 61;
            // 
            // CommandType_comboBox
            // 
            this.CommandType_comboBox.FormattingEnabled = true;
            this.CommandType_comboBox.Items.AddRange(new object[] {
            "Software Serial Commands",
            "Arduino Encode Commands"});
            this.CommandType_comboBox.Location = new System.Drawing.Point(96, 20);
            this.CommandType_comboBox.Name = "CommandType_comboBox";
            this.CommandType_comboBox.Size = new System.Drawing.Size(225, 21);
            this.CommandType_comboBox.TabIndex = 2;
            // 
            // Decode_groupBox
            // 
            this.Decode_groupBox.Controls.Add(this.DecodeMsg_textBox);
            this.Decode_groupBox.Location = new System.Drawing.Point(24, 125);
            this.Decode_groupBox.Name = "Decode_groupBox";
            this.Decode_groupBox.Size = new System.Drawing.Size(328, 134);
            this.Decode_groupBox.TabIndex = 64;
            this.Decode_groupBox.TabStop = false;
            this.Decode_groupBox.Text = "Decoded Message";
            // 
            // DecodeMsg_textBox
            // 
            this.DecodeMsg_textBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecodeMsg_textBox.Location = new System.Drawing.Point(6, 19);
            this.DecodeMsg_textBox.Multiline = true;
            this.DecodeMsg_textBox.Name = "DecodeMsg_textBox";
            this.DecodeMsg_textBox.Size = new System.Drawing.Size(315, 109);
            this.DecodeMsg_textBox.TabIndex = 0;
            // 
            // OpenCommand_MaplinkLabel
            // 
            this.OpenCommand_MaplinkLabel.AutoSize = true;
            this.OpenCommand_MaplinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.OpenCommand_MaplinkLabel.Location = new System.Drawing.Point(247, 262);
            this.OpenCommand_MaplinkLabel.Name = "OpenCommand_MaplinkLabel";
            this.OpenCommand_MaplinkLabel.Size = new System.Drawing.Size(105, 13);
            this.OpenCommand_MaplinkLabel.TabIndex = 1;
            this.OpenCommand_MaplinkLabel.TabStop = true;
            this.OpenCommand_MaplinkLabel.Text = "Open command map";
            this.OpenCommand_MaplinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenCommand_MaplinkLabel_LinkClicked);
            // 
            // CloseCommand_MaplinkLabel
            // 
            this.CloseCommand_MaplinkLabel.AutoSize = true;
            this.CloseCommand_MaplinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.CloseCommand_MaplinkLabel.Location = new System.Drawing.Point(247, 261);
            this.CloseCommand_MaplinkLabel.Name = "CloseCommand_MaplinkLabel";
            this.CloseCommand_MaplinkLabel.Size = new System.Drawing.Size(105, 13);
            this.CloseCommand_MaplinkLabel.TabIndex = 1;
            this.CloseCommand_MaplinkLabel.TabStop = true;
            this.CloseCommand_MaplinkLabel.Text = "Close command map";
            this.CloseCommand_MaplinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseCommand_MaplinkLabel_LinkClicked);
            // 
            // DecodeCommands
            // 
            this.AcceptButton = this.DecodeCommand_button;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 276);
            this.Controls.Add(this.CloseCommand_MaplinkLabel);
            this.Controls.Add(this.OpenCommand_MaplinkLabel);
            this.Controls.Add(this.Decode_groupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DecodeCommands";
            this.ShowInTaskbar = false;
            this.Text = "Decode Commands";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DecodeCommands_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Decode_groupBox.ResumeLayout(false);
            this.Decode_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CommandType_comboBox;
        private System.Windows.Forms.TextBox Command_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Decode_groupBox;
        private System.Windows.Forms.TextBox DecodeMsg_textBox;
        private System.Windows.Forms.TextBox CommandFilePath_textBox;
        private System.Windows.Forms.Button DecodeCommand_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel OpenCommand_MaplinkLabel;
        private System.Windows.Forms.LinkLabel CloseCommand_MaplinkLabel;
    }
}