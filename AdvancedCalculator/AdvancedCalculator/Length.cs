using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class Length : Form
    {
        public Length()
        {
            InitializeComponent();
        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtdisplay1.Text == "0")
            {
                txtdisplay1.Text = "";

            }
            if (b.Text == ".")
            {
                if (!txtdisplay1.Text.Contains("."))
                    txtdisplay1.Text = txtdisplay1.Text + b.Text;
            }
            else
            {
                txtdisplay1.Text = txtdisplay1.Text + b.Text;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtdisplay1.Text.Length > 0)
            {
                txtdisplay1.Text = txtdisplay1.Text.Remove(txtdisplay1.Text.Length - 1, 1);
            }
            if (txtdisplay1.Text == "")
            {
                txtdisplay1.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text = "0";
            txtdisplay2.Text = "0";
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text = "-";
        }

        private void Point_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text = ".";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtdisplay1.Text);
            if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 0.001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 0.000001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 0.0000001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 0.000000001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 0.000000000001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 0.00000003937008);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 0.00000000328084);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 0.0000000000062);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 0.00000000000054);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Nanometers" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 0.0000000109361);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 1000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 0.001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 0.0001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 0.000001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 0.000000001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 0.000039);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 0.000003);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 0.00000000062137);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 0.00000000053996);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Microns" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 0.000001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 1000000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 1000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 0.1);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 0.001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 0.000001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 0.03937);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 0.003281);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 6.2137e-7);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 5.3996e-7);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Millimeters" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 0.00109361);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 10000000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 10000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 10);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 0.01);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 0.00001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 0.393701);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 0.032808);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 0.000006);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 0.000005);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Centimeters" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 0.010936);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 1000000000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 1000000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 1000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 100);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 0.001);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 39.3701);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 3.28084);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 0.000621371);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 0.000539957);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Meters" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 1.09361);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 1000000000000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 1000000000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 1000000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 100000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 1000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 39370.1);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 3280.84);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 0.621371);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 0.539957);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Kilometers" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 1093.61);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 2.54e+7);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 25400);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 25.4);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 2.54);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 0.0254);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 2.54e-5);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 0.0833333);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 1.5783e-5);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 1.3715e-5);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Inches" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 0.0277778);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 3.048e+8);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 304800);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 304.8);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 30.48);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 0.3048);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 0.0003048);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 12);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 0.000189394);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 0.000164579);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 0.333333);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 1.609e+12);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 1609344000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 1.609e+6);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 160934);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 1.609e+6);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 1.60934);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 63360);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 5280);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 0.868976);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Miles" && comboBox2.SelectedItem == "Yard")
            {
                double y = (x * 1760);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 1.852e+12);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 1852000000);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 1.852e+6);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 185200);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 1852);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 1.852);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 72913.4);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 6076.12);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 1.15078);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "NauticalMiles" && comboBox2.SelectedItem == "Yards")
            {
                double y = (x * 2025.37);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Nanometers")
            {
                double y = (x * 9.144e+8);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Microns")
            {
                double y = (x * 914400);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Millimeters")
            {
                double y = (x * 914.4);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Centimeters")
            {
                double y = (x * 91.44);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Meters")
            {
                double y = (x * 0.9144);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Kilometers")
            {
                double y = (x * 0.9144);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Inches")
            {
                double y = (x * 36);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Feet")
            {
                double y = (x * 3);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "Miles")
            {
                double y = (x * 0.000568182);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            else if (comboBox1.SelectedItem == "Yards" && comboBox2.SelectedItem == "NauticalMiles")
            {
                double y = (x * 0.000493737);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Standard")
            {
                lbltitle.Text = "Standard";
                treeView1.Visible = false;
                Standard S = new Standard();
                this.Hide();
                S.ShowDialog();
            }
            if (e.Node.Name == "Scientific")
            {
                lbltitle.Text = "Scientific";
                treeView1.Visible = false;
                
                Scientific S = new Scientific();
                this.Hide();
                S.ShowDialog();
            }
            if (e.Node.Name == "Programmer")
            {
                lbltitle.Text = "Programmer";
                treeView1.Visible = false;
                
                Programmer P = new Programmer();
                this.Hide();
                P.ShowDialog();

            }
            if (e.Node.Name == "Temperature")
            {
                lbltitle.Text = "Temperature";
                treeView1.Visible = false;
                
                Temp T = new Temp();
                this.Hide();
                T.ShowDialog();
            }
           
            if (e.Node.Name == "Fibonacci")
            {
                lbltitle.Text = "Fibonacci";
                treeView1.Visible = false;
                
                Fibonacci F = new Fibonacci();
                this.Hide();
                F.ShowDialog();
            }
            if (e.Node.Name == "Matrix")
            {
                lbltitle.Text = "Matrix";
                treeView1.Visible = false;
                
                Matrix M = new Matrix();
                this.Hide();
                M.ShowDialog();
            }
        }

        private void txtdisplay1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Length_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
        }

        private void lblList2_Click(object sender, EventArgs e)
        {
            treeView1.Visible = false;
            lblList2.Visible = false;
        }

        private void lblList_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            lblList2.Visible = true;
        }
    }
}
