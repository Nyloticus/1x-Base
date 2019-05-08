using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AdvancedCalculator
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int count;
            count = int.Parse(txtdisplay1.Text);
            int i, f1 = 1, f2 = 1, f3 = 0;
            listBox1.Items.Add(f1);
            listBox1.Items.Add(f2);
            for (i = 3; i <= count; i++)
            {
                f3 = f1 + f2;
                listBox1.Items.Add(f3);
                f1 = f2;
                f2 = f3;
            }
            textBox2.Text = f3.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Fibonacci_number");
        }

        private void txtdisplay1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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

        private void Fibonacci_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
