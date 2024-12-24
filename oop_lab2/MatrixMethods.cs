using System.Text;

namespace oop_lab2
{
    public partial class Matrix
    {
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Height != b.Height || a.Width != b.Width)
            {
                throw new ArgumentException("different dimensions");
            }

            double[,] result = new double[a.Height, a.Width];
            for (int i = 0; i < a.Height; i++)
            {
                for (int j = 0; j < a.Width; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];

                }
            }

            return new Matrix(result);
        }

    }
}
