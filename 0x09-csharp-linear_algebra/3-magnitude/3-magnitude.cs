using System;
using System.Collections.Generic;

///<summary>Class for operations on vectors.</summary>
class VectorMath
{
    ///<summary>Calculates magnitude from component vectors.</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
    		double eureka = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
			return Math.Round(eureka, 2);
        }
        if (vector.Length == 3)
        {
            double eureka = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
			return Math.Round(eureka, 2);
        }
        return (-1);
    }
}