using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Cooling_Control_Software
{
    public partial class TemperatureSettings : Form
    {
        public static int CoolSideMaxTemp = 55;
        public static int HotSideMaxTemp = 55;

        public TemperatureSettings()
        {
            InitializeComponent();
        }

        private async void MaxTempUpdate_button_Click(object sender, EventArgs e)
        {
            CoolSideMaxTemp = Convert.ToInt32(CoolSideMaxTemp_numericUpDown.Value);
            HotSideMaxTemp = Convert.ToInt32(HotSideMaxTemp_numericUpDown.Value);
            MaxTempNotification_label.Text = "value updated successfully";
            await Task.Delay(2000);
            MaxTempNotification_label.Text = "";
        }

        private void CoolSideMaxTemp_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(MaxTempUpdate_button_Click));
        }

        private void HotSideMaxTemp_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(MaxTempUpdate_button_Click));
        }

        private void Tank1MaxTemp_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(MaxTempUpdate_button_Click));
        }

        private void Tank2MaxTemp_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(MaxTempUpdate_button_Click));
        }

        private void XaxisMaxTemp_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(MaxTempUpdate_button_Click));
        }

        private void YaxisMaxTemp_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(MaxTempUpdate_button_Click));
        }

        private void ZaxisMaxTemp_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(MaxTempUpdate_button_Click));
        }

        private void ExtruderMaxTemp_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(MaxTempUpdate_button_Click));
        }

        private void TemperatureSettings_Load(object sender, EventArgs e)
        {
            CoolSideMaxTemp_numericUpDown.Value = CoolSideMaxTemp;
            HotSideMaxTemp_numericUpDown.Value = HotSideMaxTemp;
        }
    }
}
