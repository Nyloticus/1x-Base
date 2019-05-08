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
    public partial class Temp : Form
    {
        public Temp()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtdisplay1.Text);
            if (comboBox1.SelectedItem == "Celsius" && comboBox2.SelectedItem == "Fahrenheit")
            {
                double y = ((x * 9) / 5 + 32);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            if (comboBox1.SelectedItem == "Celsius" && comboBox2.SelectedItem == "Kelvin")
            {
                double y = (x + 273.15);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            if (comboBox1.SelectedItem == "Fahrenheit" && comboBox2.SelectedItem == "Celsius")
            {
                double y = (x - 32) * 5 / 9;
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            if (comboBox1.SelectedItem == "Fahrenheit" && comboBox2.SelectedItem == "Kelvin")
            {
                double y = (x + 459.67) * 5 / 9;
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            if (comboBox1.SelectedItem == "Kelvin" && comboBox2.SelectedItem == "Celsius")
            {
                double y = (x - 273.15);
                txtdisplay2.Text = System.Convert.ToString(y);
            }
            if (comboBox1.SelectedItem == "Kelvin" && comboBox2.SelectedItem == "Fahrenheit")
            {
                double y = x * 9 / 5 - 459.67;
                txtdisplay2.Text = System.Convert.ToString(y);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text = "0";
            txtdisplay2.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if(txtdisplay1.Text.Length > 0)
            {
                txtdisplay1.Text = txtdisplay1.Text.Remove(txtdisplay1.Text.Length - 1, 1);
            }
            if (txtdisplay1.Text == "")
            {
                txtdisplay1.Text = "0";
            }
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text = "-";
        }

        private void Point_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text = ".";
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

        private void Temp_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
        }

        private void lblList_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            lblList2.Visible = true;
        }

        private void lblList2_Click(object sender, EventArgs e)
        {
            treeView1.Visible = false;
            lblList2.Visible = false;
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
           
            if (e.Node.Name == "Length")
            {
                lbltitle.Text = "Length";
                treeView1.Visible = false;
                
                Length L = new Length();
                this.Hide();
                L.ShowDialog();
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
    }
}
