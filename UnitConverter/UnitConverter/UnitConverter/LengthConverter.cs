using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class LengthConverter : Form
    {
        public LengthConverter()
        {
            InitializeComponent();
        }

        private void calculateButtonLen_Click(object sender, EventArgs e)
        {
            Double valueLen = Double.Parse(inputValueLen.Text);

            if(lengthFrom.Text == "Kilometer")
            {
                if(lengthTo.Text == "Kilometer")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen + "km");
                }

                if (lengthTo.Text == "Meter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1000 + "m");
                }

                if (lengthTo.Text == "Centimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 100000 + "cm");
                }

                if (lengthTo.Text == "Milimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1000000 + "mm");
                }

                if (lengthTo.Text == "Yard")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1093.6132983377 + "yd");
                }

                if (lengthTo.Text == "Mile")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1.609344 + "mi");
                }

                if (lengthTo.Text == "Foot")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 3280.8398950131 + "ft");
                }

                if (lengthTo.Text == "Inch")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 39370.078740157 + "in");
                }
            }

            if(lengthFrom.Text == "Meter")
            {
                if(lengthTo.Text == "Kilometer")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1000 + "km");
                }

                if (lengthTo.Text == "Meter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen + "m");
                }

                if (lengthTo.Text == "Centimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 100 + "cm");
                }

                if (lengthTo.Text == "Milimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1000 + "mm");
                }

                if (lengthTo.Text == "Yard")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1.0936132983377 + "yd");
                }

                if (lengthTo.Text == "Mile")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1609.344 + "mi");
                }

                if (lengthTo.Text == "Foot")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 3.2808398950131 + "ft");
                }

                if (lengthTo.Text == "Inch")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 39.370078740157 + "in");
                }
            }

            if(lengthFrom.Text == "Centimeter")
            {
                if (lengthTo.Text == "Kilometer")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 100000 + "km");
                }

                if (lengthTo.Text == "Meter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 100 + "m");
                }

                if (lengthTo.Text == "Centimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen + "cm");
                }

                if (lengthTo.Text == "Milimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 10 + "mm");
                }

                if (lengthTo.Text == "Yard")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 91.44 + "yd");
                }

                if (lengthTo.Text == "Mile")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 160934.4 + "mi");
                }

                if (lengthTo.Text == "Foot")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 30.48 + "ft");
                }

                if (lengthTo.Text == "Inch")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 2.54 + "in");
                }
            }

            if(lengthFrom.Text == "Milimeter")
            {
                if (lengthTo.Text == "Kilometer")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1000000 + "km");
                }

                if (lengthTo.Text == "Meter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1000 + "m");
                }

                if (lengthTo.Text == "Centimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 10 + "cm");
                }

                if (lengthTo.Text == "Milimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen + "mm");
                }

                if (lengthTo.Text == "Yard")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 914.4 + "yd");
                }

                if (lengthTo.Text == "Mile")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1609344 + "mi");
                }

                if (lengthTo.Text == "Foot")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 304.8 + "ft");
                }

                if (lengthTo.Text == "Inch")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 25.4 + "in");
                }
            }

            if(lengthFrom.Text == "Yard")
            {
                if (lengthTo.Text == "Kilometer")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1093.6132983377 + "km");
                }

                if (lengthTo.Text == "Meter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1.0936132983 + "m");
                }

                if (lengthTo.Text == "Centimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 91.44 + "cm");
                }

                if (lengthTo.Text == "Milimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 914.4 + "mm");
                }

                if (lengthTo.Text == "Yard")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen + "yd");
                }

                if (lengthTo.Text == "Mile")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 1760 + "mi");
                }

                if (lengthTo.Text == "Foot")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 3 + "ft");
                }

                if (lengthTo.Text == "Inch")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 36 + "in");
                }
            }

            if(lengthFrom.Text == "Mile")
            {
                if (lengthTo.Text == "Kilometer")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1.609344 + "km");
                }

                if (lengthTo.Text == "Meter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1609.344 + "m");
                }

                if (lengthTo.Text == "Centimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 160934.4 + "cm");
                }

                if (lengthTo.Text == "Milimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1609344 + "mm");
                }

                if (lengthTo.Text == "Yard")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 1760 + "yd");
                }

                if (lengthTo.Text == "Mile")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen + "mi");
                }

                if (lengthTo.Text == "Foot")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 5280 + "ft");
                }

                if (lengthTo.Text == "Inch")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 63360 + "in");
                }
            }

            if(lengthFrom.Text == "Foot")
            {
                if (lengthTo.Text == "Kilometer")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 3280.8398950131 + "km");
                }

                if(lengthTo.Text == "Meter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 3.2808398950131 + "m");
                }

                if(lengthTo.Text == "Centimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 30.48 + "cm");
                }

                if(lengthTo.Text == "Milimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 304.8 + "mm");
                }

                if(lengthTo.Text == "Yard")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 3 + "yd");
                }

                if(lengthTo.Text == "Mile")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 5280 + "mi");
                }

                if (lengthTo.Text == "Foot")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen + "ft");
                }

                if (lengthTo.Text == "Inch")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 12 + "in");
                }
            }

            if(lengthFrom.Text == "Inch")
            {
                if (lengthTo.Text == "Kilometer")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 39370.078740157 + "km");
                }

                if (lengthTo.Text == "Meter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 39.3700787402 + "m");
                }

                if (lengthTo.Text == "Centimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 2.54 + "cm");
                }

                if (lengthTo.Text == "Milimeter")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 25.4 + "mm");
                }

                if (lengthTo.Text == "Yard")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 36 + "yd");
                }

                if (lengthTo.Text == "Mile")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen / 63360 + "mi");
                }

                if (lengthTo.Text == "Foot")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen * 63360 + "ft");
                }

                if (lengthTo.Text == "Inch")
                {
                    convertLabelLen.Text = System.Convert.ToString(valueLen + "in");
                }
            }
        }

        private void LengthConverter_Load(object sender, EventArgs e)
        {
            lengthFrom.Text = "Select Unit";
            lengthFrom.Items.Add("Kilometer");
            lengthFrom.Items.Add("Meter");
            lengthFrom.Items.Add("Centimeter");
            lengthFrom.Items.Add("Milimeter");
            lengthFrom.Items.Add("Yard");
            lengthFrom.Items.Add("Mile");
            lengthFrom.Items.Add("Foot");
            lengthFrom.Items.Add("Inch");

            lengthTo.Text = "Select Unit";
            lengthTo.Items.Add("Kilometer");
            lengthTo.Items.Add("Meter");
            lengthTo.Items.Add("Centimeter");
            lengthTo.Items.Add("Milimeter");
            lengthTo.Items.Add("Yard");
            lengthTo.Items.Add("Mile");
            lengthTo.Items.Add("Foot");
            lengthTo.Items.Add("Inch");
        }
    }
}
