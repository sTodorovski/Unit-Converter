using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {
            currencyFrom.Text = "Select Currency";
            currencyFrom.Items.Add("MKD");
            currencyFrom.Items.Add("ALL");
            currencyFrom.Items.Add("BAM");
            currencyFrom.Items.Add("BGN");
            currencyFrom.Items.Add("EUR");
            currencyFrom.Items.Add("RSD");
            currencyFrom.Items.Add("HRK");
            currencyFrom.Items.Add("RON");
            currencyFrom.Items.Add("TRY");
            currencyFrom.Items.Add("USD");
            currencyFrom.Items.Add("JPY");
            currencyFrom.Items.Add("GBP");
            currencyFrom.Items.Add("AUD");
            currencyFrom.Items.Add("CAD");
            currencyFrom.Items.Add("CHF");

            currencyTo.Text = "Select Currency";
            currencyTo.Items.Add("MKD");
            currencyTo.Items.Add("ALL");
            currencyTo.Items.Add("BAM");
            currencyTo.Items.Add("BGN");
            currencyTo.Items.Add("EUR");
            currencyTo.Items.Add("RSD");
            currencyTo.Items.Add("HRK");
            currencyTo.Items.Add("RON");
            currencyTo.Items.Add("TRY");
            currencyTo.Items.Add("USD");
            currencyTo.Items.Add("JPY");
            currencyTo.Items.Add("GBP");
            currencyTo.Items.Add("AUD");
            currencyTo.Items.Add("CAD");
            currencyTo.Items.Add("CHF");
        }

        private void calculateButtonCurr_Click(object sender, EventArgs e)
        {
            Double value = Double.Parse(inputValueCurr.Text);

            if (currencyFrom.Text == "MKD")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.93 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.032 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.032 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.91 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.12 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.080 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.28 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.017 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.016 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 2.32 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.014 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.025 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.022 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.016 + " CHF"));
                }
            }

            if (currencyFrom.Text == "ALL")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.52 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.016 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.016 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.99 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.064 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.042 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.15 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0088 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0084 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.21 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0073 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.013 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.011 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0084 + " CHF"));
                }
            }

            if (currencyFrom.Text == "BAM")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 31.64 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 60.91 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 60.34 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 3.87 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 2.54 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 8.96 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.54 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.51 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 72.20 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.44 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.78 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.69 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.51 + " CHF"));
                }
            }

            if (currencyFrom.Text == "BGN")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 31.51 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 60.66 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 60.09 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 3.85 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 2.53 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 8.92 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.54 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.51 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 73.13 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.44 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.78 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.69 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.51 + " CHF"));
                }
            }

            if (currencyFrom.Text == "EUR")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 61.53 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 118.46 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.94 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.96 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 117.39 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 7.53 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 4.94 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 17.43 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.05 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 142.99 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.86 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.52 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.35 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " CHF"));
                }
            }

            if (currencyFrom.Text == "RSD")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.52 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.01 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.017 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.017 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.064 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.042 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.15 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0089 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0085 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.22 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0074 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.013 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.011 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0085 + " CHF"));
                }
            }

            if (currencyFrom.Text == "HRK")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 8.18 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 15.75 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.26 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.026 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 15.60 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.66 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 2.32 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.14 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.13 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 18.98 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.11 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.20 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.18 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.13 + " CHF"));
                }
            }

            if (currencyFrom.Text == "RON")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 12.45 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 23.97 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.39 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.40 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 23.75 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.52 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 3.52 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.21 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.20 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 28.88 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.17 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.31 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.27 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.20 + " CHF"));
                }
            }

            if (currencyFrom.Text == "TRY")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 3.54 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 6.82 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.11 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.11 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 6.75 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.43 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.28 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.060 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.057 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 8.19 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.049 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.087 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.077 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.057 + " CHF"));
                }
            }

            if (currencyFrom.Text == "USD")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 58.78 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 113.17 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.86 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.87 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 112.13 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 7.19 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 4.72 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 16.64 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.96 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 136.38 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.82 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.45 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.29 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.95 + " CHF"));
                }
            }

            if (currencyFrom.Text == "JPY")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.43 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.83 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.014 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.014 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.82 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.053 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.035 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.12 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0073 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0070 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0060 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0011 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0094 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.0070 + " CHF"));
                }
            }

            if (currencyFrom.Text == "GBP")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 71.36 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 137.38 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 2.26 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 2.27 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 136.18 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 8.73 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 5.73 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 20.19 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.21 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.16 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 165.62 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.77 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.56 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.16 + " CHF"));
                }
            }

            if (currencyFrom.Text == "AUD")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 40.41 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 77.81 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.28 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.28 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 77.12 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 4.95 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 3.25 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 11.45 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.69 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.66 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 93.83 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.57 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.89 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.66 + " CHF"));
                }
            }

            if (currencyFrom.Text == "CAD")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 45.62 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 87.83 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.44 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.45 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 87.10 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 5.59 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 3.67 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 12.92 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.78 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.74 + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 105.93 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.64 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.13 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.74 + " CHF"));
                }
            }

            if (currencyFrom.Text == "CHF")
            {
                if (currencyTo.Text == "MKD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 61.62 + " MKD"));
                }

                if (currencyTo.Text == "ALL")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 118.63 + " ALL"));
                }

                if (currencyTo.Text == "BAM")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.95 + " BAM"));
                }

                if (currencyTo.Text == "BGN")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.96 + " BGN"));
                }

                if (currencyTo.Text == "RSD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 117.67 + " RSD"));
                }

                if (currencyTo.Text == "HRK")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 7.55 + " HRK"));
                }

                if (currencyTo.Text == "RON")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 4.95 + " RON"));
                }

                if (currencyTo.Text == "TRY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 17.44 + " TRY"));
                }

                if (currencyTo.Text == "USD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.05 + " USD"));
                }

                if (currencyTo.Text == "EUR")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " EUR"));
                }

                if (currencyTo.Text == "JPY")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 143.03 + " JPY"));
                }

                if (currencyTo.Text == "GBP")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 0.86 + " GBP"));
                }

                if (currencyTo.Text == "AUD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.52 + " AUD"));
                }

                if (currencyTo.Text == "CAD")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value * 1.35 + " CAD"));
                }

                if (currencyTo.Text == "CHF")
                {
                    convertLabelCurr.Text = System.Convert.ToString((value + " CHF"));
                }
            }
        }
    }
}
