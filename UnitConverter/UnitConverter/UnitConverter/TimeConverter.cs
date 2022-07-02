using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class TimeConverter : Form
    {
        public TimeConverter()
        {
            InitializeComponent();
        }

        private void calculateButtonTime_Click(object sender, EventArgs e)
        {
            Double valueTime = Double.Parse(inputValueTime.Text);

            if(timeFrom.Text == "Millisecond")
            {
                if(timeTo.Text == "Millisecond")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime + "ms");
                }

                if (timeTo.Text == "Second")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 1000 + "s");
                }

                if (timeTo.Text == "Minute")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 60000 + " min");
                }

                if (timeTo.Text == "Hour")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 3600000 + " hrs");
                }

                if (timeTo.Text == "Day")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 86400000 + " days");
                }

                if (timeTo.Text == "Week")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 604800000 + " weeks");
                }

                if (timeTo.Text == "Month")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 2628000000 + " months");
                }
            }

            if(timeFrom.Text == "Second")
            {
                if (timeTo.Text == "Millisecond")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 1000 + "ms");
                }

                if (timeTo.Text == "Second")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime + "s");
                }

                if (timeTo.Text == "Minute")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 60 + " min");
                }

                if (timeTo.Text == "Hour")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 3600 + " hrs");
                }

                if (timeTo.Text == "Day")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 86400 + " days");
                }

                if (timeTo.Text == "Week")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 604800 + " weeks");
                }

                if (timeTo.Text == "Month")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 2628000 + " months");
                }
            }

            if(timeFrom.Text == "Minute")
            {
                if (timeTo.Text == "Millisecond")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 60000 + "ms");
                }

                if (timeTo.Text == "Second")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 60 + "s");
                }

                if (timeTo.Text == "Minute")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime + " min");
                }

                if (timeTo.Text == "Hour")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 60 + " hrs");
                }

                if (timeTo.Text == "Day")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 1440 + " days");
                }

                if (timeTo.Text == "Week")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 10080 + " weeks");
                }

                if (timeTo.Text == "Month")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 43829.1 + " months");
                }
            }

            if(timeFrom.Text == "Hour")
            {
                if (timeTo.Text == "Millisecond")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 3600000 + "ms");
                }

                if (timeTo.Text == "Second")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 3600 + "s");
                }

                if (timeTo.Text == "Minute")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 60 + " min");
                }

                if (timeTo.Text == "Hour")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime + " hrs");
                }

                if (timeTo.Text == "Day")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 24 + " days");
                }

                if (timeTo.Text == "Week")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 168 + " weeks");
                }

                if (timeTo.Text == "Month")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 730 + " months");
                }
            }

            if(timeFrom.Text == "Day")
            {
                if (timeTo.Text == "Millisecond")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 86400000 + "ms");
                }

                if (timeTo.Text == "Second")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 86400 + "s");
                }

                if (timeTo.Text == "Minute")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 1440 + " min");
                }

                if (timeTo.Text == "Hour")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 24 + " hrs");
                }

                if (timeTo.Text == "Day")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime + " days");
                }

                if (timeTo.Text == "Week")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 7 + " weeks");
                }

                if (timeTo.Text == "Month")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 30.4166666667 + " months");
                }
            }

            if(timeFrom.Text == "Week")
            {
                if (timeTo.Text == "Millisecond")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 604800000 + "ms");
                }

                if (timeTo.Text == "Second")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 604800 + "s");
                }

                if (timeTo.Text == "Minute")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 10080 + " min");
                }

                if (timeTo.Text == "Hour")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 168 + " hours");
                }

                if (timeTo.Text == "Day")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 7 + " days");
                }

                if (timeTo.Text == "Week")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime + " weeks");
                }

                if (timeTo.Text == "Month")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime / 4.3452380952 + " months");
                }
            }

            if(timeFrom.Text == "Month")
            {
                if (timeTo.Text == "Millisecond")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 2628000000 + "ms");
                }

                if (timeTo.Text == "Second")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 2628000 + "s");
                }

                if (timeTo.Text == "Minute")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 43800 + " min");
                }

                if (timeTo.Text == "Hour")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 730 + " hrs");
                }

                if (timeTo.Text == "Day")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 30.4166666667 + " days");
                }

                if (timeTo.Text == "Week")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime * 4.3452380952 + " weeks");
                }

                if (timeTo.Text == "Month")
                {
                    convertLabelTime.Text = System.Convert.ToString(valueTime + " months");
                }
            }
        }

        private void TimeConverter_Load(object sender, EventArgs e)
        {
            timeFrom.Text = "Select Unit";
            timeFrom.Items.Add("Millisecond");
            timeFrom.Items.Add("Second");
            timeFrom.Items.Add("Minute");
            timeFrom.Items.Add("Hour");
            timeFrom.Items.Add("Day");
            timeFrom.Items.Add("Week");
            timeFrom.Items.Add("Month");

            timeTo.Text = "Select Unit";
            timeTo.Items.Add("Millisecond");
            timeTo.Items.Add("Second");
            timeTo.Items.Add("Minute");
            timeTo.Items.Add("Hour");
            timeTo.Items.Add("Day");
            timeTo.Items.Add("Week");
            timeTo.Items.Add("Month");
        }
    }
}
