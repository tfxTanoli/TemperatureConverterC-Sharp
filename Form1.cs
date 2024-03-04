using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverterC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperatureInCelsius = double.Parse(textBox1.Text);
            double convertedTemperature = 0;
            if (comboBox1.SelectedItem.Equals("Celsius"))
            {
                label3.Text = temperatureInCelsius.ToString() + "°C";
            }
            else if (comboBox1.SelectedItem.Equals("Fahrenheit"))
            {
                convertedTemperature = (temperatureInCelsius * 9 / 5) + 32;
                label3.Text = convertedTemperature.ToString() + "°F";
            }
            else
            {
                convertedTemperature = temperatureInCelsius + 273.15;
                label3.Text = convertedTemperature.ToString() + "°K";
            }
        }
    }
}
