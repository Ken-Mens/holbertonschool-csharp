using System;

///<summary>Class for vector math</summary>
class VectorMath
{
	///<summary>Class Operation that calculates  vector scaling</summary>
	///<return>the resulting vector</return>
	public static double[] Multiply(double[] vector, double scalar)
	{
        double[] vector3 = new double[1] {-1};

		if (vector.Length == 2)
		{
			double[] result = { 0, 0 };
			result[0] = vector[0] * scalar;
			result[1] = vector[1] * scalar;
			return result;
		}
		else if (vector.Length == 3)
		{
		    vector3 = new double[3] {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
		}
		return (vector3);
	}
}