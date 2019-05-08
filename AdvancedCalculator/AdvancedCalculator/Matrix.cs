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
    public partial class Matrix : Form
    {
        private TextBox[,] matrix1;
        private TextBox[,] matrix2;
        private TextBox[,] matrix_result;
        private float determinante;

        int raw1, coulmn1;
        int raw2, coulmn2;
        public Matrix()
        {
            InitializeComponent();
        }

        private void groupBoxmatrixResult_Enter(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (matrix1 == null || matrix2 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempmatrix1 = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            float[,] tempmatrix2 = new float[matrix2.GetLength(0), matrix2.GetLength(1)];
            if (tempmatrix1.GetLength(0) != tempmatrix2.GetLength(0) || tempmatrix1.GetLength(1) != tempmatrix2.GetLength(1))
            {
                MessageBox.Show("Error");
                return;
            }

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix1[x, y].Text, out n);
                    tempmatrix1[x, y] = n;

                }
            }
            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix2[x, y].Text, out n);
                    tempmatrix2[x, y] = n;

                }
            }

            float[,] tempMatriResult = matrixx.sum_matrix(tempmatrix1, tempmatrix2);
            matrix_result = new TextBox[tempMatriResult.GetLength(0), tempMatriResult.GetLength(1)];
            int sizeText = groupBoxmatrixResult.Width / matrix_result.GetLength(1);
            groupBoxmatrixResult.Controls.Clear();
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y] = new TextBox();
                    matrix_result[x, y].Text = tempMatriResult[x, y].ToString();
                    matrix_result[x, y].Top = (x * matrix_result[x, y].Height) + 20;
                    matrix_result[x, y].Left = y * sizeText + 6;
                    matrix_result[x, y].Width = sizeText;
                    groupBoxmatrixResult.Controls.Add(matrix_result[x, y]);
                }
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (matrix1 == null || matrix2 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempmatrix1 = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            float[,] tempmatrix2 = new float[matrix2.GetLength(0), matrix2.GetLength(1)];
            if (tempmatrix1.GetLength(0) != tempmatrix2.GetLength(0) || tempmatrix1.GetLength(1) != tempmatrix2.GetLength(1))
            {
                MessageBox.Show("Error");
                return;
            }

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix1[x, y].Text, out n);
                    tempmatrix1[x, y] = n;
                }
            }
            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix2[x, y].Text, out n);
                    tempmatrix2[x, y] = n;
                }
            }

            float[,] tempMatriResult = matrixx.sub_matrix(tempmatrix1, tempmatrix2);
            matrix_result = new TextBox[tempMatriResult.GetLength(0), tempMatriResult.GetLength(1)];
            int sizeText = groupBoxmatrixResult.Width / matrix_result.GetLength(1);
            groupBoxmatrixResult.Controls.Clear();
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y] = new TextBox();
                    matrix_result[x, y].Text = tempMatriResult[x, y].ToString();
                    matrix_result[x, y].Top = (x * matrix_result[x, y].Height) + 20;
                    matrix_result[x, y].Left = y * sizeText + 6;
                    matrix_result[x, y].Width = sizeText;
                    groupBoxmatrixResult.Controls.Add(matrix_result[x, y]);
                }
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (matrix1 == null || matrix2 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempmatrix1 = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            float[,] tempmatrix2 = new float[matrix2.GetLength(0), matrix2.GetLength(1)];
            if (tempmatrix1.GetLength(1) != tempmatrix2.GetLength(0))
            {
                MessageBox.Show("Error", "Error");
                return;
            }

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix1[x, y].Text, out n);
                    tempmatrix1[x, y] = n;
                }
            }
            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix2[x, y].Text, out n);
                    tempmatrix2[x, y] = n;
                }
            }

            float[,] tempMatriResult = matrixx.mul_matrix(tempmatrix1, tempmatrix2);
            matrix_result = new TextBox[tempMatriResult.GetLength(0), tempMatriResult.GetLength(1)];
            int sizeText = groupBoxmatrixResult.Width / matrix_result.GetLength(1);
            groupBoxmatrixResult.Controls.Clear();
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y] = new TextBox();
                    matrix_result[x, y].Text = tempMatriResult[x, y].ToString();
                    matrix_result[x, y].Top = (x * matrix_result[x, y].Height) + 20;
                    matrix_result[x, y].Left = y * sizeText + 6;
                    matrix_result[x, y].Width = sizeText;
                    groupBoxmatrixResult.Controls.Add(matrix_result[x, y]);
                }
            }
        }

        private void btnAddMatrix1_Click(object sender, EventArgs e)
        {
            groupBoxmatrix1.Controls.Clear();


            if (!int.TryParse(textBox1.Text, out raw1))
            {
                MessageBox.Show("Error");
                return;
            }
            if (!int.TryParse(textBox3.Text, out coulmn1))
            {
                MessageBox.Show("Error");
                return;
            }

            matrix1 = new TextBox[raw1, coulmn1];
            int sizeText = groupBoxmatrix1.Width / coulmn1;
            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    matrix1[x, y] = new TextBox();
                    matrix1[x, y].Text = "0";
                    matrix1[x, y].Top = (x * matrix1[x, y].Height) + 20;
                    matrix1[x, y].Left = y * sizeText + 6;
                    matrix1[x, y].Width = sizeText;
                    groupBoxmatrix1.Controls.Add(matrix1[x, y]);
                }
            }
        }

        private void btnAddMatrix2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out raw2))
            {
                MessageBox.Show("Error");
                return;
            }
            if (!int.TryParse(textBox4.Text, out coulmn2))
            {
                MessageBox.Show("Error");
                return;
            }
            int sizeText = groupBoxmatrix2.Width / coulmn2;
            matrix2 = new TextBox[raw2, coulmn2];
            sizeText = groupBoxmatrix2.Width / coulmn2;
            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    matrix2[x, y] = new TextBox();
                    matrix2[x, y].Text = "0";
                    matrix2[x, y].Top = (x * matrix2[x, y].Height) + 20;
                    matrix2[x, y].Left = y * sizeText + 6;
                    matrix2[x, y].Width = sizeText;
                    groupBoxmatrix2.Controls.Add(matrix2[x, y]);
                }
            }
        }

        private void btnGerarDeterminanteM1_Click(object sender, EventArgs e)
        {
            if (matrix_result == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];

            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix_result[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                determinante = matrixx.Generate_Determinante2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                determinante = matrixx.Generate_Determinante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else
            {
                MessageBox.Show("IT is not possible to generate Matrix", "Error ");
            }
        }
        private void btnGenerate_Inverse_Click(object sender, EventArgs e)
        {
            if (matrix_result == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];
            float[,] matrizAdjunta = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];
            float[,] matrizCofatora = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];
            float determinante = 0;
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matrix is Invalid !", "Error");
                    return;
                }
            }

            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix_result[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matrizCofatora = matrixx.Generate_cofactor2x2(tempResultante);
                matrizAdjunta = matrixx.Generate_transpose(matrizCofatora);
                determinante = matrixx.Generate_Determinante2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matrizCofatora = matrixx.Generate_cofactor3x3(tempResultante);
                matrizAdjunta = matrixx.Generate_transpose(matrizCofatora);
                determinante = matrixx.Generate_Determinante3x3(tempResultante);
            }
            else
            {
                MessageBox.Show("Matrix is Invalid!", "Error");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matrix is Invalid!", "Error");
                return;
            }
            float[,] tempMatriResult = matrixx.Generate_Inverse(determinante, matrizAdjunta);
            int sizeText = groupBoxmatrixResult.Width / matrix_result.GetLength(1);
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y].Text = tempMatriResult[x, y].ToString();
                }
            }
        }

        private void btnGerarDeterminante_Click(object sender, EventArgs e)
        {
            if (matrix2 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix2.GetLength(0), matrix2.GetLength(1)];

            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                determinante = matrixx.Generate_Determinante2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinant...");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                determinante = matrixx.Generate_Determinante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Determinant...");
            }
            else
            {
                MessageBox.Show("IT is not possible to generate determinant !", "Error");
            }
        }

        private void btnGerarDeterminanteM2_Click(object sender, EventArgs e)
        {
            if (matrix1 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                determinante = matrixx.Generate_Determinante2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                determinante = matrixx.Generate_Determinante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else
            {
                MessageBox.Show("IT is not possible to generate matrix !", "Error invalida ");
            }
        }

        private void btnGerarOpostaM1_Click(object sender, EventArgs e)
        {
            if (matrix_result == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];

            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix_result[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatriResult = matrixx.Generate_oppsite(tempResultante);
            int sizeText = groupBoxmatrixResult.Width / matrix_result.GetLength(1);
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y].Text = tempMatriResult[x, y].ToString();
                }
            }
        }

        private void btnGerarOpostaM2_Click(object sender, EventArgs e)
        {
            if (matrix1 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatriResult = matrixx.Generate_oppsite(tempResultante);
            int sizeText = groupBoxmatrix1.Width / matrix1.GetLength(1);
            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    matrix1[x, y].Text = tempMatriResult[x, y].ToString();
                }
            }
        }

        private void btnGerarOposta_Click(object sender, EventArgs e)
        {
            if (matrix2 == null)
            {
                MessageBox.Show("Matrix is NULL", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix2.GetLength(0), matrix2.GetLength(1)];

            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix2[x, y].Text, out n);
                    tempResultante[x, y] = n;

                }
            }

            float[,] tempMatriResult = matrixx.Generate_oppsite(tempResultante);
            int sizeText = groupBoxmatrix2.Width / matrix2.GetLength(1);
            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    matrix2[x, y].Text = tempMatriResult[x, y].ToString();
                }
            }
        }

        private void btnGerarTranspostM2_Click(object sender, EventArgs e)
        {
            if (matrix1 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatriResult = matrixx.Generate_transpose(tempResultante);
            int sizeText = groupBoxmatrix1.Width / matrix1.GetLength(1);
            matrix1 = new TextBox[tempMatriResult.GetLength(0), tempMatriResult.GetLength(1)];
            groupBoxmatrix1.Controls.Clear();
            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    matrix1[x, y] = new TextBox();
                    matrix1[x, y].Text = tempMatriResult[x, y].ToString();
                    matrix1[x, y].Top = (x * matrix1[x, y].Height) + 20;
                    matrix1[x, y].Left = y * sizeText + 6;
                    matrix1[x, y].Width = sizeText;
                    groupBoxmatrix1.Controls.Add(matrix1[x, y]);
                }
            }
        }

        private void btnGerarTransposta_Click(object sender, EventArgs e)
        {
            if (matrix2 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix2.GetLength(0), matrix2.GetLength(1)];

            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatriResult = matrixx.Generate_transpose(tempResultante);
            int sizeText = groupBoxmatrix2.Width / matrix2.GetLength(1);
            matrix2 = new TextBox[tempMatriResult.GetLength(0), tempMatriResult.GetLength(1)];
            groupBoxmatrix2.Controls.Clear();
            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    matrix2[x, y] = new TextBox();
                    matrix2[x, y].Text = tempMatriResult[x, y].ToString();
                    matrix2[x, y].Top = (x * matrix2[x, y].Height) + 20;
                    matrix2[x, y].Left = y * sizeText + 6;
                    matrix2[x, y].Width = sizeText;
                    groupBoxmatrix2.Controls.Add(matrix2[x, y]);
                }
            }
        }

        private void btnGerarTranspostM1_Click(object sender, EventArgs e)
        {
            if (matrix_result == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];

            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix_result[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatriResult = matrixx.Generate_transpose(tempResultante);
            int sizeText = groupBoxmatrixResult.Width / matrix_result.GetLength(1);
            matrix_result = new TextBox[tempMatriResult.GetLength(0), tempMatriResult.GetLength(1)];
            groupBoxmatrixResult.Controls.Clear();
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y] = new TextBox();
                    matrix_result[x, y].Text = tempMatriResult[x, y].ToString();
                    matrix_result[x, y].Top = (x * matrix_result[x, y].Height) + 20;
                    matrix_result[x, y].Left = y * sizeText + 6;
                    matrix_result[x, y].Width = sizeText;
                    groupBoxmatrixResult.Controls.Add(matrix_result[x, y]);
                }
            }
        }

        private void btnGerarInversaM2_Click(object sender, EventArgs e)
        {
            if (matrix1 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            float[,] matrizAdjunta = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            float[,] matrizCofatora = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            float determinante = 0;
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matrix is Invalid !", "Error");
                    return;
                }
            }
            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matrizCofatora = matrixx.Generate_cofactor2x2(tempResultante);
                matrizAdjunta = matrixx.Generate_transpose(matrizCofatora);
                determinante = matrixx.Generate_Determinante2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matrizCofatora = matrixx.Generate_cofactor3x3(tempResultante);
                matrizAdjunta = matrixx.Generate_transpose(matrizCofatora);
                determinante = matrixx.Generate_Determinante3x3(tempResultante);
            }
            else
            {
                MessageBox.Show("Invalid Matrix !", "Error");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Invalid Matrix", "Error");
                return;
            }
            float[,] tempMatriResult = matrixx.Generate_Inverse(determinante, matrizAdjunta);
            int sizeText = groupBoxmatrix1.Width / matrix1.GetLength(1);
            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    matrix1[x, y].Text = tempMatriResult[x, y].ToString();
                }
            }
        }

        private void groupBoxmatrix1_Enter(object sender, EventArgs e)
        {

        }

        private void Matrix_Load(object sender, EventArgs e)
        {

        }

        private void btnGerarInversa_Click(object sender, EventArgs e)
        {
            if (matrix2 == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix2.GetLength(0), matrix2.GetLength(1)];
            float[,] matrizAdjunta = new float[matrix2.GetLength(0), matrix2.GetLength(1)];
            float[,] matrizCofatora = new float[matrix2.GetLength(0), matrix2.GetLength(1)];
            float determinante = 0;
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matrix Invalid !", "Error");
                    return;
                }
            }

            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matrizCofatora = matrixx.Generate_cofactor2x2(tempResultante);
                matrizAdjunta = matrixx.Generate_transpose(matrizCofatora);
                determinante = matrixx.Generate_Determinante2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matrizCofatora = matrixx.Generate_cofactor3x3(tempResultante);
                matrizAdjunta = matrixx.Generate_transpose(matrizCofatora);
                determinante = matrixx.Generate_Determinante3x3(tempResultante);
            }
            else
            {
                MessageBox.Show("Matrix is Invalid !", "Error");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matrix is Invalid", "Error");
                return;
            }
            float[,] tempMatriResult = matrixx.Generate_Inverse(determinante, matrizAdjunta);
            int sizeText = groupBoxmatrix2.Width / matrix2.GetLength(1);
            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                {
                    matrix2[x, y].Text = tempMatriResult[x, y].ToString();
                }
            }
        }

        private void btnGerarInversaM1_Click(object sender, EventArgs e)
        {
            if (matrix_result == null)
            {
                MessageBox.Show("Matrix is NULL !", "Error");
                return;
            }
            float[,] tempResultante = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];
            float[,] matrizAdjunta = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];
            float[,] matrizCofatora = new float[matrix_result.GetLength(0), matrix_result.GetLength(1)];
            float determinante = 0;
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matrix is Invalid !", "Error");
                    return;
                }
            }

            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrix_result[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matrizCofatora = matrixx.Generate_cofactor2x2(tempResultante);
                matrizAdjunta = matrixx.Generate_transpose(matrizCofatora);
                determinante = matrixx.Generate_Determinante2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matrizCofatora = matrixx.Generate_cofactor3x3(tempResultante);
                matrizAdjunta = matrixx.Generate_transpose(matrizCofatora);
                determinante = matrixx.Generate_Determinante3x3(tempResultante);
            }
            else
            {
                MessageBox.Show("Matrix is Invalid!", "Error");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matrix is Invalid!", "Error");
                return;
            }
            float[,] tempMatriResult = matrixx.Generate_Inverse(determinante, matrizAdjunta);
            int sizeText = groupBoxmatrixResult.Width / matrix_result.GetLength(1);
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y].Text = tempMatriResult[x, y].ToString();
                }
            }
        }
    }
}
