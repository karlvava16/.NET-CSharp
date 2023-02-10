using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Matrix
    {
        private int[,] matrixArray;
        private int min;
        private int max;

        public int[,] MatrixArray { get { return matrixArray; } set { matrixArray = value; } }

        public int Max { get { return max; } }

        public int Min { get { return min; } }

        private void MinMaxCount()
        {
            min = 0;
            max = 0;
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    if (matrixArray[i, j] > max)
                        max = matrixArray[i, j];
                    if (matrixArray[i, j] < min)
                        min = matrixArray[i, j];
                }
            }
        }
        public void RandMatrix(int fd, int sd)
        {
            Random rand = new Random();
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    matrixArray[i, j] = rand.Next(fd, sd);
                }
            }
            MinMaxCount();
        }

        public Matrix()
        {
            MatrixArray = new int[3, 3];
            min = 0; max = 0;
        }

        public Matrix(int i)
        {
            MatrixArray = new int[i, i];
            min = 0; max = 0;
        }

        public Matrix(int i, int j)
        {
            MatrixArray = new int[i, j];
            min = 0; max = 0;
        }


        public static Matrix operator +(int val, Matrix a)
        {
            Matrix temp = a;
            for (int i = 0; i < temp.MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < temp.MatrixArray.GetLength(1); j++)
                {
                    temp.MatrixArray[i, j] = val + temp.MatrixArray[i, j];
                }
            }
            return temp;
        }

        public static Matrix operator -(int val, Matrix a)
        {
            Matrix temp = a;
            for (int i = 0; i < temp.MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < temp.MatrixArray.GetLength(1); j++)
                {
                    temp.MatrixArray[i, j] = val - temp.MatrixArray[i, j];
                }
            }
            return temp;
        }

        public static Matrix operator +(Matrix a, int val)
        {
            Matrix temp = a;
            for (int i = 0; i < temp.MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < temp.MatrixArray.GetLength(1); j++)
                {
                    temp.MatrixArray[i, j] += val;
                }
            }
            return temp;
        }

        public static Matrix operator -(Matrix a, int val)
        {
            Matrix temp = a;
            for (int i = 0; i < temp.MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < temp.MatrixArray.GetLength(1); j++)
                {
                    temp.MatrixArray[i, j] -= val;
                }
            }
            return temp;
        }

        public static Matrix operator *(int val, Matrix a)
        {
            Matrix temp = a;
            for (int i = 0; i < temp.MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < temp.MatrixArray.GetLength(1); j++)
                {
                    temp.MatrixArray[i, j] = val * temp.MatrixArray[i, j];
                }
            }
            return temp;
        }

        public static Matrix operator *(Matrix a, int val)
        {
            Matrix temp = a;
            for (int i = 0; i < temp.MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < temp.MatrixArray.GetLength(1); j++)
                {
                    temp.MatrixArray[i, j] *= val;
                }
            }
            return temp;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.MatrixArray.GetLength(0) != b.MatrixArray.GetLength(0) || a.MatrixArray.GetLength(1) != b.MatrixArray.GetLength(1))
                return false;
            for (int i = 0; i < a.MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < a.MatrixArray.GetLength(1); j++)
                {
                    if (a.MatrixArray[i, j] != a.MatrixArray[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)

        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    stringBuilder.Append($"{MatrixArray[i, j]}\t");
                }
                stringBuilder.Append("\n\n");
            }
            return stringBuilder.ToString();
        }


        public int this[int i, int j]
        {
            get { return matrixArray[i, j]; }
            set
            {
                if (!(i >= 0 && i <= matrixArray.GetLength(0) - 1))
                    throw new Exception("Index i out of range");
                if (!(j >= 0 && j <= matrixArray.GetLength(1) - 1))
                    throw new Exception("Index j out of range");
                matrixArray[i, j] = value;
            }
        }
        public void SetElement(int i, int j, int value)
        {
            matrixArray[i, j] = value;
            MinMaxCount();
        }
    }
}
