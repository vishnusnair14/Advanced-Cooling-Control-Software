using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Cooling_Control_Software
{
    public partial class TemperatureSettings : Form
    {
        private const int ConstantTempVal = 70;

        public static int CoolSideMaxTemp = 62;
        public static int HotSideMaxTemp = 62;
        public static int Tank1MaxTemp = 62;
        public static int Tank2MaxTemp = 62;
        public static int XaxisMaxTemp = 0;
        public static int YaxisMaxTemp = 0;
        public static int ZaxisMaxTemp = 0;
        public static int ExtruderMaxTemp = 0;

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
            Tank1MaxTemp_numericUpDown.Value = Tank1MaxTemp;
            Tank2MaxTemp_numericUpDown.Value = Tank2MaxTemp;
            XaxisMaxTemp_numericUpDown.Value = XaxisMaxTemp;
            YaxisMaxTemp_numericUpDown.Value = YaxisMaxTemp;
            ZaxisMaxTemp_numericUpDown.Value = ZaxisMaxTemp;
            ExtruderMaxTemp_numericUpDown.Value = ExtruderMaxTemp;
        }
    }
}
