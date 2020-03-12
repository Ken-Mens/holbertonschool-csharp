using System;

///<summary>Class for vector math</summary>
class VectorMath
{
	///<summary>calculating vector dot product for 2d and 3d</summary>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
        double eureka = -1;

		if (vector1.Length == 2 && vector2.Length == 2)
		{
			return vector1[0] * vector2[0] + vector1[1] * vector2[1];
		}
		else if (vector1.Length == 3 && vector2.Length == 3)
		{
			return vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2];
		}
		return (eureka);
	}
}