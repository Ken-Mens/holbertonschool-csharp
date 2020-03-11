using System;
using System.Collections.Generic;

///<summary>Algebraic operations on vectors.</summary>
class VectorMath
{
    ///<summary>Adds 2d and 3d vectors alltogether.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] triple = new double[1] {-1};

        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] eureka = { 0, 0 };
			eureka[0] = vector1[0] + vector2[0];
			eureka[1] = vector1[1] + vector2[1];
			return eureka;
        }
        else if (vector1.Length == 3 && vector1.Length == vector2.Length)
        {
            triple = new double[3] {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2]+vector2[2]};
        }
        return (triple);
    }
}