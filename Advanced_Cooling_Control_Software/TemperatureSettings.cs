using System;
using System.Drawing;
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

        public static int XaxisMaxTemp = 50;
        public static int YaxisMaxTemp = 50;
        public static int ZaxisMaxTemp = 50;
        public static int ExtruderMaxTemp = 50;

        public static short HighTempAlertDelayMs = 1000;
        public static string HighTempAlertText = "HIGH TEMP ALERT!";

        public static Color AlertC1 = Color.Maroon;
        public static Color AlertC2 = Color.Transparent;

        public static Color labelForeColor = Color.White;
        public static Color AlertlabelForeColor = Color.Yellow;


        public TemperatureSettings()
        {
            InitializeComponent();

        }

        private async void MaxTempUpdate_button_Click(object sender, EventArgs e)
        {
            CoolSideMaxTemp = Convert.ToInt32(CoolSideMaxTemp_numericUpDown.Value);
            HotSideMaxTemp = Convert.ToInt32(HotSideMaxTemp_numericUpDown.Value);
            Tank1MaxTemp = Convert.ToInt32(Tank1MaxTemp_numericUpDown.Value);
            Tank2MaxTemp = Convert.ToInt32(Tank2MaxTemp_numericUpDown.Value);

            XaxisMaxTemp = Convert.ToInt32(XaxisMaxTemp_numericUpDown.Value);
            YaxisMaxTemp = Convert.ToInt32(YaxisMaxTemp_numericUpDown.Value);
            ZaxisMaxTemp = Convert.ToInt32(ZaxisMaxTemp_numericUpDown.Value);
            ExtruderMaxTemp = Convert.ToInt32(ExtruderMaxTemp_numericUpDown.Value);

            MaxTempNotification_label.Text = "value updated successfully";
            await Task.Delay(100);
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
            HighTempAlertText_textBox.Text = HighTempAlertText;

            AlertC1_textBox.Text = AlertC1.Name;
            AlertC1_textBox.ForeColor = AlertC1;
            AlertC2_textBox.Text = AlertC2.Name;
        }

        private void AlertC1ColorSet_button_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                AlertC1_textBox.Text = colorDialog1.Color.Name;
                AlertC1_textBox.ForeColor =  colorDialog1.Color;
                AlertC1 = colorDialog1.Color;
            }
        }

        private void AlertC2ColorSet_button_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                AlertC2_textBox.Text = colorDialog1.Color.Name;
                AlertC2_textBox.ForeColor = colorDialog1.Color;
                AlertC2 = colorDialog1.Color;
            }
        }

        private void AlertLabelColorSet_button_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                AlertLabelForeColor_textbox.Text = colorDialog1.Color.Name;
                AlertLabelForeColor_textbox.ForeColor = colorDialog1.Color;
                AlertlabelForeColor = colorDialog1.Color;
            }
        }

        private void LabelColorSet_button_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                LabelForeColor_textbox.Text = colorDialog1.Color.Name;
                LabelForeColor_textbox.ForeColor = colorDialog1.Color;
                labelForeColor = colorDialog1.Color;
            }
        }

        private void AlertText_textBox_TextChanged(object sender, EventArgs e)
        {
            HighTempAlertText = HighTempAlertText_textBox.Text;
        }

        private void HighTempBlinkDelay_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            HighTempAlertDelayMs = (short)HighTempBlinkDelay_numericUpDown.Value;
        }

        private void AlertC1_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

