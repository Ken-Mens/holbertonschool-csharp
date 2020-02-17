using System;

namespace MyMath
{
    ///<summary>Method performed on matrixies.</summary>
    public class Matrix
    {
        ///<summary>Divides all elements of a matrix.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            if (matrix == null)
            {
                return (null);
            }
            int m_Height = matrix.GetLength(0);
            int m_Width = matrix.GetLength(1);
            int[,] newM = new int[m_Height, m_Width];
            int x = 0;
            for (; x < m_Height; x++)
            {
                int y = 0;
                for (; y < m_Width; y++)
                {
                    newM[x, y] = matrix[x,y] / num;
                }
            }
            return (newM);
        }
    }
}

