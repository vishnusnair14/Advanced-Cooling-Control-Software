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
        public static Color AlertC2 = Color.DarkGray;

        public static Color labelForeColor = Color.White;
        public static Color AlertlabelForeColor = Color.Yellow;
        private readonly Control[] indicatorControlName;

        public static string ASFCommand_PBT1;
        public static string ASFCommand_PBT2;
        public static string ASFCommand_CT1;
        public static string ASFCommand_CT2;
        public static string ASFCommand_XAXIS;
        public static string ASFCommand_YAXIS;
        public static string ASFCommand_ZAXIS;
        public static string ASFCommand_EXTRUDER;
        public static int ASF_TRIGGER_COUNT = 5;

        public static string AN1_label;
        public static string AN2_label;
        public static string AN3_label;
        public static string AN4_label;
        public static string AN5_label;
        public static string AN6_label;
        public static string AN7_label;
        public static string AN8_label;


        public TemperatureSettings(Control[] _indicatorControlName)
        {
            InitializeComponent();
            indicatorControlName = _indicatorControlName;
            LabelForeColor_textbox.BackColor = Color.LightGray;
            AlertLabelForeColor_textbox.BackColor = Color.LightGray;
            AlertC1_textBox.BackColor = Color.LightGray;
            AlertC2_textBox.BackColor = Color.LightGray;
            AdvSecurityCommandUpdate();
            AdvancedNotificationLabelUpdate();
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
            AlertC2_textBox.ForeColor = AlertC2;

            AlertLabelForeColor_textbox.ForeColor = AlertlabelForeColor;
            AlertLabelForeColor_textbox.Text = AlertlabelForeColor.Name;

            LabelForeColor_textbox.ForeColor = labelForeColor;
            LabelForeColor_textbox.Text = labelForeColor.Name;
            HighTempAlertOptions_groupBox.Visible = true;
            AdvancedSettings_groupbox.Visible = false;
            Size = new Size(712, 412);

            DefaultAlertCount_checkBox.Checked = true;

            AN1_NFT_textBox.Text = AN1_label;
            AN2_NFT_textBox.Text = AN2_label;
            AN3_NFT_textBox.Text = AN3_label;
            AN4_NFT_textBox.Text = AN3_label;
        }

        private void AdvSecurityCommandUpdate()
        {
            ASFCommand_PBT1 = ASFCommandPBT1_textBox.Text;
            ASFCommand_PBT2 = ASFCommandPBT2_textBox.Text;
            ASFCommand_CT1 = ASFCommandCT1_textBox.Text;
            ASFCommand_CT2 = ASFCommandCT2_textBox.Text;
            ASFCommand_XAXIS = ASFCommandXaxis_textBox.Text;
            ASFCommand_YAXIS = ASFCommandYaxis_textBox.Text;
            ASFCommand_ZAXIS = ASFCommandZaxis_textBox.Text;
            ASFCommand_EXTRUDER = ASFCommandExtruder_textBox.Text;
        }


        private void AdvancedNotificationLabelUpdate()
        {
            AN1_label = AN1_NFT_textBox.Text;
            AN2_label = AN2_NFT_textBox.Text;
            AN3_label = AN3_NFT_textBox.Text;
            AN4_label = AN4_NFT_textBox.Text;
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

            labelForeColor = LabelForeColor_textbox.ForeColor;

            MaxTempNotification_label.Text = "value updated successfully";
            await Task.Delay(100);
            MaxTempNotification_label.Text = "";
        }

        private void MakeIndicatorLabelNormal()
        {
            for (int i = 0; i < indicatorControlName.Length; i++)
            {
                indicatorControlName[i].ForeColor = labelForeColor;
                indicatorControlName[i].BackColor = Color.Transparent;
                //indicatorControlName[i].Text = labelForeColor.Name;
            }
        }


        private void AlertC1ColorSet_button_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                AlertC1_textBox.Text = colorDialog1.Color.Name;
                AlertC1_textBox.ForeColor = colorDialog1.Color;
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
                MakeIndicatorLabelNormal();
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


        private void Reset_button_Click(object sender, EventArgs e)
        {
            CoolSideMaxTemp_numericUpDown.Value = 62;
            HotSideMaxTemp_numericUpDown.Value = 62;
            Tank1MaxTemp_numericUpDown.Value = 62;
            Tank2MaxTemp_numericUpDown.Value = 62;
            XaxisMaxTemp_numericUpDown.Value = 50;
            YaxisMaxTemp_numericUpDown.Value = 50;
            ZaxisMaxTemp_numericUpDown.Value = 50;
            ExtruderMaxTemp_numericUpDown.Value = 50;
            HighTempBlinkDelay_numericUpDown.Value = 750;
            HighTempAlertText_textBox.Text = "HIGH TEMP ALERT!";

            /*
            AlertC1 = Color.Maroon;
            AlertC1_textBox.Text = Color.Maroon.Name;
            AlertC1_textBox.ForeColor = Color.Maroon;

            AlertC2 = Color.DarkGray;
            AlertC2_textBox.Text = Color.DarkGray.Name;
            AlertC2_textBox.ForeColor = Color.DarkGray;

            labelForeColor = Color.White;
            LabelForeColor_textbox.Text = Color.White.Name;
            LabelForeColor_textbox.ForeColor = Color.White;

            AlertlabelForeColor = Color.Yellow;
            AlertLabelForeColor_textbox.Text = Color.Yellow.Name;
            AlertLabelForeColor_textbox.ForeColor = Color.Yellow;
            */

            MakeIndicatorLabelNormal();
        }

        private void HighTempAlertOptions_MenuItem_Click(object sender, EventArgs e)
        {
            HighTempAlertOptions_groupBox.Visible = true;
            HighTempAlertOptions_groupBox.Location = new Point(3, 27);
            AdvancedSettings_groupbox.Visible = false;
            NotificationSettings_groupBox.Visible = false;
        }

        private void AdvancedSettings_MenuItem_Click(object sender, EventArgs e)
        {
            AdvancedSettings_groupbox.Visible = true;
            AdvancedSettings_groupbox.Location = new Point(3, 27);
            HighTempAlertOptions_groupBox.Visible = false;
            NotificationSettings_groupBox.Visible = false;
        }


        private void NotificationSettings_MenuItem_Click(object sender, EventArgs e)
        {
            NotificationSettings_groupBox.Visible = true;
            NotificationSettings_groupBox.Location = new Point(3, 27);
            AdvancedSettings_groupbox.Visible = false;
            HighTempAlertOptions_groupBox.Visible = false;
        }


        private void DefaultAlertCount_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DefaultAlertCount_checkBox.Checked)
            {
                AlertCustomCount_textBox.Enabled = false;
                oia_label.Enabled = false;
            }
            else
            {
                AlertCustomCount_textBox.Enabled = true;
                oia_label.Enabled = true;
            }
        }



        private void AlertCustomCount_textBox_TextChanged(object sender, EventArgs e)
        {
            if (AlertCustomCount_textBox.Text.Length == 0)
            {
                ASF_TRIGGER_COUNT = 0;
            }
            else
            {
                ASF_TRIGGER_COUNT = Convert.ToInt32(AlertCustomCount_textBox.Text);
            }
        }


        // if MAX-TRIGGER-TEMPERATURE changed:
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


        // if ADVANCE-SECURITY-TRIGGER-COMMAND changed:
        private void ASFCommandPBT1_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvSecurityCommandUpdate();
        }

        private void ASFCommandPBT2_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvSecurityCommandUpdate();
        }

        private void ASFCommandCT1_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvSecurityCommandUpdate();
        }

        private void ASFCommandCT2_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvSecurityCommandUpdate();
        }

        private void ASFCommandXaxis_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvSecurityCommandUpdate();
        }

        private void ASFCommandYaxis_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvSecurityCommandUpdate();
        }

        private void ASFCommandZaxis_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvSecurityCommandUpdate();
        }

        private void ASFCommandExtruder_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvSecurityCommandUpdate();
        }


        // if ADVANCED-NOTIFICATION-LABEL changed:
        private void AN1_NFT_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvancedNotificationLabelUpdate();
        }

        private void AN2_NFT_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvancedNotificationLabelUpdate();
        }

        private void AN3_NFT_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvancedNotificationLabelUpdate();
        }

        private void AN4_NFT_textBox_TextChanged(object sender, EventArgs e)
        {
            AdvancedNotificationLabelUpdate();
        }


    }
}

