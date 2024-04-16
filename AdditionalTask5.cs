using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class AdditionalTask5 : Form
    {
        public AdditionalTask5()
        {
            InitializeComponent();
        }

        private void AdditionalTask5_Load(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            DateTime currentTime = DateTime.Now;

            string timeFormat = Hours24RadioButton.Checked ? "HH:mm:ss" : "hh:mm:ss";
            string formattedTime = currentTime.ToString(timeFormat);

            CurrentTimeLabel.Text = formattedTime;
        }
        private void PeriodNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Timer.Interval = (int)(PeriodNumericUpDown.Value * 1000);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
