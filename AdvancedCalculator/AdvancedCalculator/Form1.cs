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
    public partial class Standard : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        String firstnum, secnum;
        public Standard()
        {
            InitializeComponent();
        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ((txtdisplay.Text == "0") || (enter_value))
            {
                txtdisplay.Text = "";
                enter_value = false;
            }
            if (b.Text == ".")
            {
                if (!txtdisplay.Text.Contains("."))
                    txtdisplay.Text = txtdisplay.Text + b.Text;
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + b.Text;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.Length > 0)
            {
                txtdisplay.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1, 1);
            }
            if (txtdisplay.Text == "")
            {
                txtdisplay.Text = "0";
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
            result = 0;
            lblShowOps.Text = "";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (result != 0)
            {
                btnEquals.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOps.Text = System.Convert.ToString(result) + "  " + operation;
            }
            else
            {

                operation = b.Text;
                result = Double.Parse(txtdisplay.Text);
                txtdisplay.Text = "";
                lblShowOps.Text = System.Convert.ToString(result) + "  " + operation;

            }
            firstnum = lblShowOps.Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secnum = txtdisplay.Text;
            lblShowOps.Text = "";
            switch (operation)
            {
                case "+":
                    txtdisplay.Text = (result + Double.Parse(txtdisplay.Text)).ToString();
                    break;
                case "-":
                    txtdisplay.Text = (result - Double.Parse(txtdisplay.Text)).ToString();
                    break;
                case "×":
                    txtdisplay.Text = (result * Double.Parse(txtdisplay.Text)).ToString();
                    break;
                case "÷":
                    txtdisplay.Text = (result / Double.Parse(txtdisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(txtdisplay.Text);
            operation = "";
            /***************************************************************************/
            btnClearHistory.Visible = true;
            rtbDisplayHistory.AppendText(firstnum + "    " + secnum + "  =  " + "\n");
            rtbDisplayHistory.AppendText("\n\t" + txtdisplay.Text + "\n\n");
            lblHistoryDisplay.Text = " ";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
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

        private void lbllist1_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            lblList2.Visible = true;
        }

        private void lbllist2_Click(object sender, EventArgs e)
        {
            lblList2.Visible = false;
            treeView1.Visible = false;
        }

        private void btnPower2_Click(object sender, EventArgs e)
        {
            double opr1;
            opr1 = Convert.ToDouble(txtdisplay.Text) * Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = System.Convert.ToString(opr1);
        }

        private void btnPower3_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtdisplay.Text, out opr1))
            {

                opr1 = Convert.ToDouble(txtdisplay.Text) * Convert.ToDouble(txtdisplay.Text) * Convert.ToDouble(txtdisplay.Text);
                txtdisplay.Text = System.Convert.ToString(opr1);

            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtdisplay.Text, out opr1))
            {
                txtdisplay.Text = (Math.Sqrt(opr1)).ToString();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            double opr1;
            opr1 = Convert.ToDouble(txtdisplay.Text) / Convert.ToDouble(100);
            txtdisplay.Text = System.Convert.ToString(opr1);
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            rtbDisplayHistory.Clear();
            if (lblHistoryDisplay.Text == "")
            {
                lblHistoryDisplay.Text = "There is no history yet";
            }
            btnClearHistory.Visible = false;
            rtbDisplayHistory.ScrollBars = 0;
        }

        private void Standard_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
            
        }
    }
}
