using System;
using System.Windows.Forms;

namespace Advanced_Cooling_Control_Software
{
    public partial class SystemInformation : Form
    {
        public SystemInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SysInfo sysInfo = new SysInfo();
            textBox1.Text = sysInfo.GetSystemInfo();
        }
    }
}
