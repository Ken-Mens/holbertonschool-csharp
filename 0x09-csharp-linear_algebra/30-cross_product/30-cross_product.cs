using System;
using System.Collections.Generic;

///<summary>Class for algebric operations on vectors.</summary>
class VectorMath
{
    ///<summary>Cross product of two  and 3d vectors.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] triple_vec;

        if (vector1.Length == 3 && vector2.Length == 3)
        {
            triple_vec = new double[3] {
                (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]),
                (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]),
                (vector1[0] * vector2[1]) - (vector1[1] * vector2[0])
            };
            return (triple_vec);
        }
        return (new double[] {-1});
    }
}   