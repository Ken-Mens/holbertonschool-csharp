using System;

class MatrixMath
{
	/// <summary> Class Operation on matrices </summary>
	/// <param name="matrix"> matrix operated on scalar.</param>
	/// <param name="scalar">The scalar multiplied with matrix.</param>
	/// <returns> New matrix.</returns>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		double[,] newMatrix;
		int height = matrix.GetLength(0);
		int width = matrix.GetLength(1);
		int x = 0, y = 0;

		if (height == 2 && width == 2)
			newMatrix = new double[2, 2];
		else if (height == 3 && width == 3)
			newMatrix = new double[3, 3];
		else
			return new double[,] { { -1 } };
            x = 0;
		for (; x < height; x++)
		{
            y = 0;
			for (; y < width; y++)
			{
				newMatrix[x, y] = matrix[x, y] * scalar;
			}
		}
		return (newMatrix);
	}
}