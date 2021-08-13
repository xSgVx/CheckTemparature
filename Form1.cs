using System;
using System.Windows.Forms;
using static CheckTemperature.Funtions;

namespace CheckTemperature
{
    public partial class CheckTemperatureForm : Form
    {
        public CheckTemperatureForm()
        {
            InitializeComponent();

            ClockTimer timeClock = new(d => currentTimeLabel.Text = d.ToLongTimeString());
            ClockTimer dateClock = new(d => currentDateLabel.Text = d.ToLongDateString());

            timeClock.Start();
            dateClock.Start();


        }

        private void getCurrentTemperature_Click(object sender, EventArgs e)
        {
            string cityName = cityNameTextBox.Text;
            
        }


    }
}
