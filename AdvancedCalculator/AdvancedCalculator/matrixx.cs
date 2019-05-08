using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class matrixx
    {
        #region operation
        //sum
        public static float[,] sum_matrix(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrix_result = new float[matrix1.GetLongLength(0), matrix1.GetLength(1)];
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y] = matrix1[x, y] += matrix2[x, y];
                }
            }
            return matrix_result;
        }
        //subtract
        public static float[,] sub_matrix(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrix_result = new float[matrix1.GetLongLength(0), matrix1.GetLength(1)];
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    matrix_result[x, y] = matrix1[x, y] -= matrix2[x, y];
                }
            }
            return matrix_result;
        }
        //multiple
        public static float[,] mul_matrix(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrix_result = new float[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int x = 0; x < matrix_result.GetLength(0); x++)
            {
                for (int y = 0; y < matrix_result.GetLength(1); y++)
                {
                    for (int n = 0; n < matrix2.GetLength(0); n++)
                    {
                        string i = "" + matrix1[x, n];
                        matrix_result[x, y] += matrix1[x, n] * matrix2[n, y];
                    }
                }
            }
            return matrix_result;
        }
        #endregion
        #region oppsite and transpose
        public static float[,] Generate_oppsite(float[,] matrix)
        {
            float[,] matrixoppsite = new float[matrix.GetLength(0), matrix.GetLength(1)];
            for (int x = 0; x < matrixoppsite.GetLength(0); x++)
            {
                for (int y = 0; y < matrixoppsite.GetLength(1); y++)
                {
                    matrixoppsite[x, y] += matrix[x, y] * -1;
                }
            }
            return matrixoppsite;
        }
        public static float[,] Generate_transpose(float[,] matrix)
        {
            float[,] matrixtranspose = new float[matrix.GetLength(1), matrix.GetLength(0)];
            for (int x = 0; x < matrixtranspose.GetLength(0); x++)
            {
                for (int y = 0; y < matrixtranspose.GetLength(1); y++)
                {
                    matrixtranspose[x, y] += matrix[y, x];
                }
            }
            return matrixtranspose;
        }
        #endregion
        #region Determinantes
        public static float Generate_Determinante2x2(float[,] matrix)
        {
            float diagonal1 = 1;
            float diagonalsecondary = 1;
            float determinanteFinal = 0;
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (x == y)
                    {
                        diagonal1 *= matrix[x, y];
                    }
                }
            }
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (x != y)
                    {
                        diagonalsecondary *= matrix[x, y];
                    }
                }
            }
            determinanteFinal = diagonal1 - diagonalsecondary;
            return determinanteFinal;
        }
        public static float Generate_Determinante3x3(float[,] matrix)
        {
            float diagonal1 = 0;
            float diagonalsecondary = 0;
            float determinanteFinal = 0;
            int size_s = (((matrix.GetLength(0) * matrix.GetLength(1)) * 2) / 3) - 1;
            float[,] _s = new float[matrix.GetLength(0), size_s];
            for (int x = 0; x < _s.GetLength(0); x++)
            {
                for (int y = 0; y < _s.GetLength(1); y++)
                {
                    if (y > matrix.GetLength(0) - 1)
                    {
                        _s[x, y] += matrix[x, y - matrix.GetLength(0)];
                    }
                    else
                    {
                        _s[x, y] += matrix[x, y];
                    }
                }
            }
            int temp = 3;
            for (int i = 0; i < temp; i++)
            {
                int num = i;
                float mDiagonal = 1;
                for (int x = 0; x < _s.GetLength(0); x++)
                {
                    for (int y = 0; y < _s.GetLength(1); y++)
                    {
                        if (x == y)
                        {
                            string z = "" + _s[x, y + num];
                            mDiagonal *= _s[x, y + num];
                        }
                    }
                }
                diagonal1 += mDiagonal;
            }

            for (int i = 0; i < temp; i++)
            {
                int num = i;
                float mDiagonal = 1;
                for (int x = 0; x < _s.GetLength(0); x++)
                {
                    for (int y = _s.GetLength(1) - 1; y > 0; y--)
                    {
                        if (x == (_s.GetLength(1) - 1) - y)
                        {
                            string z = "" + _s[x, y - num];
                            mDiagonal *= _s[x, y - num];
                        }
                    }
                }
                diagonalsecondary += mDiagonal;
            }
            determinanteFinal = diagonal1 - diagonalsecondary;
            return determinanteFinal;
        }
        #endregion
        #region inverse
        public static float[,] Generate_cofactor2x2(float[,] matrix1)
        {
            float[,] matrixcofactor = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            float determinat = 0;

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    if (x == 0 && y == 0)
                    {
                        determinat = matrix1[x + 1, y + 1];
                    }
                    else if (x == 0 && y == 1)
                    {
                        determinat = matrix1[x + 1, y - 1];
                    }
                    else if (x == 1 && y == 0)
                    {
                        determinat = matrix1[x - 1, y + 1];
                    }
                    else if (x == 1 && y == 1)
                    {
                        determinat = matrix1[x - 1, y - 1];
                    }
                    double i = Math.Pow(-1, (x + y));
                    matrixcofactor[x, y] += (float)i * determinat;
                }
            }
            return matrixcofactor;
        }
        public static float[,] Generate_cofactor3x3(float[,] matrix1)
        {
            float[,] matrixcofactor = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            float determinat = 0;

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    determinat = DeterminanteCofator(x, y, matrix1);
                    double i = Math.Pow(-1, (x + y));
                    matrixcofactor[x, y] += (float)i * determinat;
                }
            }
            return matrixcofactor;
        }
        private static float DeterminanteCofator(int posX, int posY, float[,] matrix)
        {
            float[,] matrix_result = new float[2, 2];
            int id = 0;
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (x != posX && y != posY)
                    {
                        if (id == 0)
                        {
                            matrix_result[0, 0] += matrix[x, y];
                        }
                        else if (id == 1)
                        {
                            matrix_result[0, 1] += matrix[x, y];
                        }
                        else if (id == 2)
                        {
                            matrix_result[1, 0] += matrix[x, y];
                        }
                        else if (id == 3)
                        {
                            matrix_result[1, 1] += matrix[x, y];
                        }
                        id++;
                    }
                }
            }
            float determinate = Generate_Determinante2x2(matrix_result);
            return determinate;
        }
        public static float[,] Generate_Inverse(float determinante, float[,] matrix1)
        {
            float[,] matrix_inverse = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    float n = matrix1[x, y];
                    n = n / determinante;
                    matrix_inverse[x, y] += n;
                }
            }

            return matrix_inverse;
        }
        #endregion
    }
}
