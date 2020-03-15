using System;

class MatrixMath
{
	/// <summary>  method to transpose a matrix and return the resulting matrix </summary>
	/// <param name="matrix">The matrix to be transposed</param>
	/// <returns> transposed matrix.</returns>
	public static double[,] Transpose(double[,] matrix)
	{
        int Wget = matrix.GetLength(1);
        int Hget = matrix.GetLength(0);
		double[,] newMatrix = new double[Wget, Hget];
        int x = 0;
		for (; x < Wget; x++)
		{
            int y = 0;
			for (; y < Hget; y++)
			{
				newMatrix[x, y] = matrix[y, x];
			}
		}
		return (newMatrix);
	}
}