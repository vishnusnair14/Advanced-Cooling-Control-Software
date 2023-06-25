namespace Advanced_Cooling_Control_Software
{
    partial class CommandOptions
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
            this.Command_menuStrip = new System.Windows.Forms.MenuStrip();
            this.sentCommandToArduinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Command_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Command_menuStrip
            // 
            this.Command_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sentCommandToArduinoToolStripMenuItem,
            this.decodeCommandsToolStripMenuItem});
            this.Command_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Command_menuStrip.Name = "Command_menuStrip";
            this.Command_menuStrip.Size = new System.Drawing.Size(385, 24);
            this.Command_menuStrip.TabIndex = 4;
            this.Command_menuStrip.Text = "menuStrip1";
            // 
            // sentCommandToArduinoToolStripMenuItem
            // 
            this.sentCommandToArduinoToolStripMenuItem.Name = "sentCommandToArduinoToolStripMenuItem";
            this.sentCommandToArduinoToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.sentCommandToArduinoToolStripMenuItem.Text = "Sent Command to Arduino";
            this.sentCommandToArduinoToolStripMenuItem.Click += new System.EventHandler(this.SentCommandToArduino_MenuItem_Click);
            // 
            // decodeCommandsToolStripMenuItem
            // 
            this.decodeCommandsToolStripMenuItem.Name = "decodeCommandsToolStripMenuItem";
            this.decodeCommandsToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.decodeCommandsToolStripMenuItem.Text = "Decode Commands";
            this.decodeCommandsToolStripMenuItem.Click += new System.EventHandler(this.decodeCommandsToolStripMenuItem_Click);
            // 
            // CommandContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 311);
            this.Controls.Add(this.Command_menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Command_menuStrip;
            this.Name = "CommandContainer";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command";
            this.Command_menuStrip.ResumeLayout(false);
            this.Command_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Command_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sentCommandToArduinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeCommandsToolStripMenuItem;
    }
}