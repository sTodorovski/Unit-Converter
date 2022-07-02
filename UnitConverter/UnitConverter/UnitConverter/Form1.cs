using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toTemperatureConverter_Click(object sender, EventArgs e)
        {
            TemperatureConverter temperature = new TemperatureConverter();
            this.Visible = false;
            temperature.Show();
        }

        private void toCurrencyConverter_Click(object sender, EventArgs e)
        {
            CurrencyConverter currency = new CurrencyConverter();
            this.Visible = false;
            currency.Show();
        }

        private void toLengthConverter_Click(object sender, EventArgs e)
        {
            LengthConverter len = new LengthConverter();
            this.Visible = false;
            len.Show();
        }

        private void toTimeConverter_Click(object sender, EventArgs e)
        {
            TimeConverter time = new TimeConverter();
            this.Visible = false;
            time.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
