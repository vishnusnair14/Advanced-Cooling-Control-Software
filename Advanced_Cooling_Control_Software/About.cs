using System.Windows.Forms;

namespace Advanced_Cooling_Control_Software
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Gnu_textBox.Text = "This program is free software; " +
                "you can redistribute it and / or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; " +
                "either version 3 of the License, or at your option any later version. This program is distributed in the hope that it will be useful, " +
                "but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. " +
                "See the GNU General Public License for more detail.";
            about_textBox.Text = "This is an intelligent algorithm, specially desgined for 3d printers (Ender-3 PRO). " +
                "This algorithm adds more saftey to your printer. " +
                "By installing this software/algorithm you can leave your printer unattended. " +
                "It has several advanced saftey features";
        }
    }
}
