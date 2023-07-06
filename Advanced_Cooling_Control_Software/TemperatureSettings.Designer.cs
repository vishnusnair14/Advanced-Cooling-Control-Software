namespace Advanced_Cooling_Control_Software
{
    partial class TemperatureSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaxTempNotification_label = new System.Windows.Forms.Label();
            this.MaxTemp_label = new System.Windows.Forms.Label();
            this.MaxTempUpdate_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ExtruderMaxTemp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ZaxisMaxTemp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.YaxisMaxTemp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.XaxisMaxTemp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Tank2MaxTemp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Tank1MaxTemp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HotSideMaxTemp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CoolSideMaxTemp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtruderMaxTemp_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaxisMaxTemp_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YaxisMaxTemp_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XaxisMaxTemp_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank2MaxTemp_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank1MaxTemp_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotSideMaxTemp_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolSideMaxTemp_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaxTempNotification_label);
            this.groupBox1.Controls.Add(this.MaxTemp_label);
            this.groupBox1.Controls.Add(this.MaxTempUpdate_button);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ExtruderMaxTemp_numericUpDown);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ZaxisMaxTemp_numericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.YaxisMaxTemp_numericUpDown);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.XaxisMaxTemp_numericUpDown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Tank2MaxTemp_numericUpDown);
            this.groupBox1.Controls.Add(this.Tank1MaxTemp_numericUpDown);
            this.groupBox1.Controls.Add(this.HotSideMaxTemp_numericUpDown);
            this.groupBox1.Controls.Add(this.CoolSideMaxTemp_numericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "High Temp. Trigger Settings";
            // 
            // MaxTempNotification_label
            // 
            this.MaxTempNotification_label.AutoSize = true;
            this.MaxTempNotification_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTempNotification_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaxTempNotification_label.Location = new System.Drawing.Point(12, 231);
            this.MaxTempNotification_label.Name = "MaxTempNotification_label";
            this.MaxTempNotification_label.Size = new System.Drawing.Size(10, 15);
            this.MaxTempNotification_label.TabIndex = 25;
            this.MaxTempNotification_label.Text = ":";
            // 
            // MaxTemp_label
            // 
            this.MaxTemp_label.AutoSize = true;
            this.MaxTemp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTemp_label.Location = new System.Drawing.Point(6, 231);
            this.MaxTemp_label.Name = "MaxTemp_label";
            this.MaxTemp_label.Size = new System.Drawing.Size(0, 15);
            this.MaxTemp_label.TabIndex = 24;
            // 
            // MaxTempUpdate_button
            // 
            this.MaxTempUpdate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaxTempUpdate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTempUpdate_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.MaxTempUpdate_button.Location = new System.Drawing.Point(326, 225);
            this.MaxTempUpdate_button.Name = "MaxTempUpdate_button";
            this.MaxTempUpdate_button.Size = new System.Drawing.Size(75, 23);
            this.MaxTempUpdate_button.TabIndex = 1;
            this.MaxTempUpdate_button.Text = "Update";
            this.MaxTempUpdate_button.UseVisualStyleBackColor = true;
            this.MaxTempUpdate_button.Click += new System.EventHandler(this.MaxTempUpdate_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(340, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Extruder";
            // 
            // ExtruderMaxTemp_numericUpDown
            // 
            this.ExtruderMaxTemp_numericUpDown.Location = new System.Drawing.Point(332, 191);
            this.ExtruderMaxTemp_numericUpDown.Name = "ExtruderMaxTemp_numericUpDown";
            this.ExtruderMaxTemp_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.ExtruderMaxTemp_numericUpDown.TabIndex = 22;
            this.ExtruderMaxTemp_numericUpDown.ValueChanged += new System.EventHandler(this.ExtruderMaxTemp_numericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(260, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Z Axis";
            // 
            // ZaxisMaxTemp_numericUpDown
            // 
            this.ZaxisMaxTemp_numericUpDown.Location = new System.Drawing.Point(251, 191);
            this.ZaxisMaxTemp_numericUpDown.Name = "ZaxisMaxTemp_numericUpDown";
            this.ZaxisMaxTemp_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.ZaxisMaxTemp_numericUpDown.TabIndex = 20;
            this.ZaxisMaxTemp_numericUpDown.ValueChanged += new System.EventHandler(this.ZaxisMaxTemp_numericUpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(347, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Y Axis";
            // 
            // YaxisMaxTemp_numericUpDown
            // 
            this.YaxisMaxTemp_numericUpDown.Location = new System.Drawing.Point(332, 142);
            this.YaxisMaxTemp_numericUpDown.Name = "YaxisMaxTemp_numericUpDown";
            this.YaxisMaxTemp_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.YaxisMaxTemp_numericUpDown.TabIndex = 18;
            this.YaxisMaxTemp_numericUpDown.ValueChanged += new System.EventHandler(this.YaxisMaxTemp_numericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(260, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "X Axis";
            // 
            // XaxisMaxTemp_numericUpDown
            // 
            this.XaxisMaxTemp_numericUpDown.Location = new System.Drawing.Point(251, 142);
            this.XaxisMaxTemp_numericUpDown.Name = "XaxisMaxTemp_numericUpDown";
            this.XaxisMaxTemp_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.XaxisMaxTemp_numericUpDown.TabIndex = 16;
            this.XaxisMaxTemp_numericUpDown.ValueChanged += new System.EventHandler(this.XaxisMaxTemp_numericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(22, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Set stepper motors\' max temperature:";
            // 
            // Tank2MaxTemp_numericUpDown
            // 
            this.Tank2MaxTemp_numericUpDown.Location = new System.Drawing.Point(332, 88);
            this.Tank2MaxTemp_numericUpDown.Name = "Tank2MaxTemp_numericUpDown";
            this.Tank2MaxTemp_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.Tank2MaxTemp_numericUpDown.TabIndex = 14;
            this.Tank2MaxTemp_numericUpDown.ValueChanged += new System.EventHandler(this.Tank2MaxTemp_numericUpDown_ValueChanged);
            // 
            // Tank1MaxTemp_numericUpDown
            // 
            this.Tank1MaxTemp_numericUpDown.Location = new System.Drawing.Point(251, 88);
            this.Tank1MaxTemp_numericUpDown.Name = "Tank1MaxTemp_numericUpDown";
            this.Tank1MaxTemp_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.Tank1MaxTemp_numericUpDown.TabIndex = 13;
            this.Tank1MaxTemp_numericUpDown.ValueChanged += new System.EventHandler(this.Tank1MaxTemp_numericUpDown_ValueChanged);
            // 
            // HotSideMaxTemp_numericUpDown
            // 
            this.HotSideMaxTemp_numericUpDown.Location = new System.Drawing.Point(332, 39);
            this.HotSideMaxTemp_numericUpDown.Name = "HotSideMaxTemp_numericUpDown";
            this.HotSideMaxTemp_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.HotSideMaxTemp_numericUpDown.TabIndex = 12;
            this.HotSideMaxTemp_numericUpDown.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.HotSideMaxTemp_numericUpDown.ValueChanged += new System.EventHandler(this.HotSideMaxTemp_numericUpDown_ValueChanged);
            // 
            // CoolSideMaxTemp_numericUpDown
            // 
            this.CoolSideMaxTemp_numericUpDown.Location = new System.Drawing.Point(251, 39);
            this.CoolSideMaxTemp_numericUpDown.Name = "CoolSideMaxTemp_numericUpDown";
            this.CoolSideMaxTemp_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.CoolSideMaxTemp_numericUpDown.TabIndex = 11;
            this.CoolSideMaxTemp_numericUpDown.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.CoolSideMaxTemp_numericUpDown.ValueChanged += new System.EventHandler(this.CoolSideMaxTemp_numericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(342, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tank 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(266, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tank 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(66, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Set coolant max temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(342, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hot Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(262, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cool Side";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set peltier block max temperature:";
            // 
            // TemperatureSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 294);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TemperatureSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Temperature Settings";
            this.Load += new System.EventHandler(this.TemperatureSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtruderMaxTemp_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaxisMaxTemp_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YaxisMaxTemp_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XaxisMaxTemp_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank2MaxTemp_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank1MaxTemp_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotSideMaxTemp_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolSideMaxTemp_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown HotSideMaxTemp_numericUpDown;
        private System.Windows.Forms.NumericUpDown CoolSideMaxTemp_numericUpDown;
        private System.Windows.Forms.NumericUpDown Tank2MaxTemp_numericUpDown;
        private System.Windows.Forms.NumericUpDown Tank1MaxTemp_numericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown XaxisMaxTemp_numericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown YaxisMaxTemp_numericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ExtruderMaxTemp_numericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ZaxisMaxTemp_numericUpDown;
        private System.Windows.Forms.Button MaxTempUpdate_button;
        private System.Windows.Forms.Label MaxTemp_label;
        private System.Windows.Forms.Label MaxTempNotification_label;
    }
}