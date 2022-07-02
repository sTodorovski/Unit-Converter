using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {
            temperatureFrom.Text = "Select Unit";
            temperatureFrom.Items.Add("Celsius");
            temperatureFrom.Items.Add("Fahrenheit");
            temperatureFrom.Items.Add("Kelvin");

            temperatureTo.Text = "Select Unit";
            temperatureTo.Items.Add("Celsius");
            temperatureTo.Items.Add("Fahrenheit");
            temperatureTo.Items.Add("Kelvin");
        }

        private void calculateButtonTemp_Click(object sender, EventArgs e)
        {
            Double valueTemp = Double.Parse(inputValueTemp.Text);

            if (temperatureFrom.Text == "Celsius")
            {
                if (temperatureTo.Text == "Celsius")
                {
                    convertLabelTemp.Text = System.Convert.ToString(valueTemp + "°C");
                }

                if (temperatureTo.Text == "Fahrenheit")
                {
                    convertLabelTemp.Text = System.Convert.ToString((valueTemp * (9.0 / 5)) + 32 + "°F");
                }

                if (temperatureTo.Text == "Kelvin")
                {
                    convertLabelTemp.Text = System.Convert.ToString(valueTemp + 273.15 + "K");
                }
            }

            if (temperatureFrom.Text == "Fahrenheit")
            {
                if (temperatureTo.Text == "Celsius")
                {
                    convertLabelTemp.Text = System.Convert.ToString((valueTemp - 32) * (5.0 / 9) + "°C");
                }

                if (temperatureTo.Text == "Fahrenheit")
                {
                    convertLabelTemp.Text = System.Convert.ToString(valueTemp + "°F");
                }

                if (temperatureTo.Text == "Kelvin")
                {
                    convertLabelTemp.Text = System.Convert.ToString((valueTemp - 32) * (5.0 / 9) + 273.15 + "K");
                }
            }

            if (temperatureFrom.Text == "Kelvin")
            {
                if (temperatureTo.Text == "Celsius")
                {
                    convertLabelTemp.Text = System.Convert.ToString(valueTemp - 273.15 + "°C");
                }

                if (temperatureTo.Text == "Fahrenheit")
                {
                    convertLabelTemp.Text = System.Convert.ToString((valueTemp - 273.15) * (9.0 / 5) + 32 + "°F");
                }

                if (temperatureTo.Text == "Kelvin")
                {
                    convertLabelTemp.Text = System.Convert.ToString(valueTemp + "K");
                }
            }
        }
    }
}
