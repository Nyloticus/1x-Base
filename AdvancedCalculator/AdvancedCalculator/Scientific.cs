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
    public partial class Scientific : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        String firstnum, secnum;
        public Scientific()
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

        private void Scientific_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
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
                case "Mod":
                    txtdisplay.Text = (result % Double.Parse(txtdisplay.Text)).ToString();
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

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (btnTan.Text == "tan")
            {
                double zTan = double.Parse(txtdisplay.Text);
                lblShowOps.Text = System.Convert.ToString("Tan" + "(" + (txtdisplay.Text) + ")");
                zTan = Math.Tan(zTan);
                txtdisplay.Text = System.Convert.ToString(zTan);
            }
            else
            {
                double zTan = double.Parse(txtdisplay.Text);
                lblShowOps.Text = System.Convert.ToString("Atan" + "(" + (txtdisplay.Text) + ")");
                zTan = Math.Atan(zTan);
                txtdisplay.Text = System.Convert.ToString(zTan);
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (btnCos.Text == "cos")
            {
                double zCos = double.Parse(txtdisplay.Text);
                lblShowOps.Text = System.Convert.ToString("Cos" + "(" + (txtdisplay.Text) + ")");
                zCos = Math.Cos(zCos);
                txtdisplay.Text = System.Convert.ToString(zCos);
            }
            else
            {
                double zCos = double.Parse(txtdisplay.Text);
                lblShowOps.Text = System.Convert.ToString("Acos" + "(" + (txtdisplay.Text) + ")");
                zCos = Math.Acos(zCos);
                txtdisplay.Text = System.Convert.ToString(zCos);
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (btnSin.Text == "sin")
            {
                double zSin = double.Parse(txtdisplay.Text);
                lblShowOps.Text = System.Convert.ToString("Sin" + "(" + (txtdisplay.Text) + ")");
                zSin = Math.Sin(zSin);
                txtdisplay.Text = System.Convert.ToString(zSin);
            }
            else
            {
                double zSin = double.Parse(txtdisplay.Text);
                lblShowOps.Text = System.Convert.ToString("Asin" + "(" + (txtdisplay.Text) + ")");
                zSin = Math.Asin(zSin);
                txtdisplay.Text = System.Convert.ToString(zSin);
            
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double zLog = double.Parse(txtdisplay.Text);
            lblShowOps.Text = System.Convert.ToString("log" + "(" + (txtdisplay.Text) + ")");
            zLog = Math.Log10(zLog);
            txtdisplay.Text = System.Convert.ToString(zLog);
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            double zExp = double.Parse(txtdisplay.Text);
            lblShowOps.Text = System.Convert.ToString("Exp" + "(" + (txtdisplay.Text) + ")");
            zExp = Math.Exp(zExp);
            txtdisplay.Text = System.Convert.ToString(zExp);
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

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtdisplay.Text, out opr1))
            {
                txtdisplay.Text = (Math.Sqrt(opr1)).ToString();
            }
        }

        private void btnPower2_Click(object sender, EventArgs e)
        {
            double opr1;
            opr1 = Convert.ToDouble(txtdisplay.Text) * Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = System.Convert.ToString(opr1);
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

        private void btnFac_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double f = double.Parse(txtdisplay.Text);
            string result = "";



            double res = 1;
            if (f == 1 || f == 0)
                result = res.ToString();
            else
            {
                for (int i = 2; i <= f; i++)
                {
                    res *= i;
                }
            }
            txtdisplay.Text = System.Convert.ToString(res);
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

        private void button20_Click(object sender, EventArgs e)
        {
           
            txtdisplay.Text = "3.141592653589";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
           if(btnSin.Text == "sin" && btnCos.Text == "cos" && btnTan.Text == "tan")
            {
                btnChange.ForeColor = Color.Red;
                btnSin.Text = "Asin";
                btnCos.Text = "Acos";
                btnTan.Text = "Atan";

            }
          else if(btnSin.Text == "Asin" && btnCos.Text == "Acos" && btnTan.Text == "Atan")
            {
                btnChange.ForeColor = Color.Black;
                btnSin.Text = "sin";
                btnCos.Text = "cos";
                btnTan.Text = "tan";
            }
                    
        }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }

        private void operators_Click(object sender, EventArgs e)
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
    }
}
