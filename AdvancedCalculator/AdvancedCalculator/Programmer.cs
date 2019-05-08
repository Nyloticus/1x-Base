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
    public partial class Programmer : Form
    {
        int result = 0;
        String operation = "";
        bool enter_value = false;
        String firstnum, secnum;
        public Programmer()
        {
            InitializeComponent();
            if (comboBox1.SelectedItem == "Decimal")
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
            }
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

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Binary")
            {

                int temp = Convert.ToInt32(txtdisplay.Text, 2);
                result = Convert.ToInt32(txtdisplay.Text, 2);

                secnum = txtdisplay.Text;
                lblShowOps.Text = "";
                switch (operation)
                {
                    case "+":
                        temp = result + temp;
                        txtdisplay.Text = Convert.ToString(temp, 2);
                        break;
                    case "-":
                        temp = result - temp;
                        txtdisplay.Text = Convert.ToString(temp, 2);
                        break;
                    case "×":
                        temp = result * temp;
                        txtdisplay.Text = Convert.ToString(temp, 2);
                        break;
                    case "÷":
                        temp = result / temp;
                        txtdisplay.Text = Convert.ToString(temp, 2);
                        break;
                    default:
                        break;
                }

                result = int.Parse(txtdisplay.Text);
                operation = "";

            }
            else if (comboBox1.SelectedItem == "Octal")
            {

                int temp = Convert.ToInt32(txtdisplay.Text, 8);
                result = Convert.ToInt32(txtdisplay.Text, 8);

                secnum = txtdisplay.Text;
                lblShowOps.Text = "";
                switch (operation)
                {
                    case "+":
                        temp = result + temp;
                        txtdisplay.Text = Convert.ToString(temp, 8);
                        break;
                    case "-":
                        temp = result - temp;
                        txtdisplay.Text = Convert.ToString(temp, 8);
                        break;
                    case "×":
                        temp = result * temp;
                        txtdisplay.Text = Convert.ToString(temp, 8);
                        break;
                    case "÷":
                        temp = result / temp;
                        txtdisplay.Text = Convert.ToString(temp, 8);
                        break;
                    default:
                        break;
                }

                result = int.Parse(txtdisplay.Text);
                operation = "";

            }
            if (comboBox1.SelectedItem == "Hexa")
            {

                int temp = Convert.ToInt32(txtdisplay.Text, 16);
                result = Convert.ToInt32(txtdisplay.Text, 16);

                secnum = txtdisplay.Text;
                lblShowOps.Text = "";
                switch (operation)
                {
                    case "+":
                        temp = result + temp;
                        txtdisplay.Text = Convert.ToString(temp, 16);
                        break;
                    case "-":
                        temp = result - temp;
                        txtdisplay.Text = Convert.ToString(temp, 16);
                        break;
                    case "×":
                        temp = result * temp;
                        txtdisplay.Text = Convert.ToString(temp, 16);
                        break;
                    case "÷":
                        temp = result / temp;
                        txtdisplay.Text = Convert.ToString(temp, 16);
                        break;
                    default:
                        break;
                }

                result = int.Parse(txtdisplay.Text);
                operation = "";

            }
            else if (comboBox1.SelectedItem == "Decimal")
            {
                secnum = txtdisplay.Text;
                lblShowOps.Text = "";
                switch (operation)
                {
                    case "+":
                        txtdisplay.Text = (result + int.Parse(txtdisplay.Text)).ToString();
                        break;
                    case "-":
                        txtdisplay.Text = (result - int.Parse(txtdisplay.Text)).ToString();
                        break;
                    case "×":
                        txtdisplay.Text = (result * int.Parse(txtdisplay.Text)).ToString();
                        break;
                    case "÷":
                        txtdisplay.Text = (result / int.Parse(txtdisplay.Text)).ToString();
                        break;
                    case "Mod":
                        txtdisplay.Text = (result % int.Parse(txtdisplay.Text)).ToString();
                        break;
                    default:
                        break;
                }
                result = int.Parse(txtdisplay.Text);
                operation = "";
            }
            btnClearHistory.Visible = true;
            rtbDisplayHistory.AppendText(firstnum + "    " + secnum + "  =  " + "\n");
            rtbDisplayHistory.AppendText("\n\t" + txtdisplay.Text + "\n\n");
            lblHistoryDisplay.Text = " ";
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
                result = int.Parse(txtdisplay.Text);
                txtdisplay.Text = "";
                lblShowOps.Text = System.Convert.ToString(result) + "  " + operation;

            }
            firstnum = lblShowOps.Text;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Convert from Decimal to >> Binary // Octal // Hexa
            if (comboBox1.SelectedItem == "Decimal")
            {
                int NumConvert = int.Parse(txtdisplay.Text);
                if (comboBox1.SelectedItem == "Decimal" && comboBox2.SelectedItem == "Binary")
                {
                    txtdisplay2.Text = Convert.ToString(NumConvert, 2);
                }
                else if (comboBox1.SelectedItem == "Decimal" && comboBox2.SelectedItem == "Octal")
                {
                    txtdisplay2.Text = Convert.ToString(NumConvert, 8);
                }
                else if (comboBox1.SelectedItem == "Decimal" && comboBox2.SelectedItem == "Hexa")
                {
                    txtdisplay2.Text = Convert.ToString(NumConvert, 16);
                }
            }
            /*********************************************************************************/
            //Convert from Binary to >> Decimal // Octal // Hex
            else if (comboBox1.SelectedItem == "Binary" && comboBox2.SelectedItem == "Decimal")
            {
                txtdisplay2.Text = Convert.ToInt32(txtdisplay.Text, 2).ToString();
            }
            else if (comboBox1.SelectedItem == "Binary" && comboBox2.SelectedItem == "Octal")
            {
                string temp = Convert.ToInt32(txtdisplay.Text, 2).ToString();
                int x = int.Parse(temp);
                txtdisplay2.Text = Convert.ToString(x, 8);
            }
            else if (comboBox1.SelectedItem == "Binary" && comboBox2.SelectedItem == "Hex")
            {
                string temp = Convert.ToInt32(txtdisplay.Text, 2).ToString();
                int x = int.Parse(temp);
                txtdisplay2.Text = Convert.ToString(x, 16);
            }
            /*******************************************************************************/
            //Convert from Octal to >> Decimal // Binary // Hex
            else if (comboBox1.SelectedItem == "Octal" && comboBox2.SelectedItem == "Decimal")
            {
                txtdisplay2.Text = Convert.ToInt32(txtdisplay.Text, 8).ToString();
            }
            else if (comboBox1.SelectedItem == "Octal" && comboBox2.SelectedItem == "Binary")
            {
                string temp = Convert.ToInt32(txtdisplay.Text, 8).ToString();
                int x = int.Parse(temp);
                txtdisplay2.Text = Convert.ToString(x, 2);
            }
            else if (comboBox1.SelectedItem == "Octal" && comboBox2.SelectedItem == "Hexa")
            {
                string temp = Convert.ToInt32(txtdisplay.Text, 8).ToString();
                int x = int.Parse(temp);
                txtdisplay2.Text = Convert.ToString(x, 16);
            }
            /*******************************************************************************/
            //Convert from Hexa to >> Decimal // Binary // Hex 
            else if (comboBox1.SelectedItem == "Hexa" && comboBox2.SelectedItem == "Decimal")
            {
                txtdisplay2.Text = Convert.ToInt32(txtdisplay.Text, 16).ToString();
            }
            else if (comboBox1.SelectedItem == "Hexa" && comboBox2.SelectedItem == "Binary")
            {
                string temp = Convert.ToInt32(txtdisplay.Text, 16).ToString();
                int x = int.Parse(temp);
                txtdisplay2.Text = Convert.ToString(x, 2);
            }
            else if (comboBox1.SelectedItem == "Hexa" && comboBox2.SelectedItem == "Octal")
            {
                string temp = Convert.ToInt32(txtdisplay.Text, 16).ToString();
                int x = int.Parse(temp);
                txtdisplay2.Text = Convert.ToString(x, 8);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
            result = 0;
            lblShowOps.Text = "";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Decimal")
            {
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
            }
            if (comboBox1.SelectedItem == "Binary")
            {
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
            }
            if (comboBox1.SelectedItem == "Octal")
            {
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
            }
            if (comboBox1.SelectedItem == "Hexa")
            {
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
        }

        private void Alphapet_Only(object sender, EventArgs e)
        {

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

        private void Programmer_Load(object sender, EventArgs e)
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

        private void AndGate_Click(object sender, EventArgs e)
        {

        }

        private void NotGate_Click(object sender, EventArgs e)
        {

        }

        private void XoRgate_Click(object sender, EventArgs e)
        {

        }

        private void OrGate_Click(object sender, EventArgs e)
        {

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

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }
    }
}
