using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int mH = myMatrix.GetLength(0);
        int mW = myMatrix.GetLength(1);
        int temp = new int();
        int[,] neoMatrix = new int[mH, mW];
        int x = 0;
        for (; x < mH; x++)
        {
            int y = 0;
            for (; y < mW; y++)
            {
                temp = myMatrix[x, y];
                neoMatrix[x, y] = temp * temp;
            }
        }
        return (neoMatrix);
    }
}
